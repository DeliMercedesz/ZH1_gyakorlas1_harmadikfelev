using Rendeleskezelo_app.Data;
using Rendeleskezelo_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendeleskezelo_app
{
    public partial class Adatkötés : UserControl
    {
        RendelesDbContext _context = new RendelesDbContext();
        public Adatkötés()
        {
            InitializeComponent();
            LoadUgyfel();
            LoadTermek();
            LoadCimek();
            LoadRendelesek();
            LoadRendelesTetel();
        }


        public void LoadUgyfel()
        {
            var ugyfelek = (from u in _context.Ugyfel
                            where u.Nev.Contains(Ugyfeltxt.Text)
                            select u).ToList();

            ugyfelBindingSource.DataSource = ugyfelek;
            ugyfelBindingSource.ResetCurrentItem();

        }

        public void LoadTermek()
        {
            var termekek = (from u in _context.Termek
                            where u.Nev.Contains(Termektxt.Text)
                            select u).ToList();

            termekBindingSource.DataSource = termekek;
            termekBindingSource.ResetCurrentItem();

        }

        public void LoadCimek()
        {
            var cimek = (from c in _context.Cim
                         select new CimDTO
                         {
                             cimID = c.CimId,
                             cimEgyben = $"{c.Iranyitoszam}-{c.Varos}, {c.Orszag}: {c.Utca} {c.Hazszam}"
                         }).ToList();

            cimDTOBindingSource.DataSource = cimek;
            comboBox1.DataSource = cimDTOBindingSource;

        }

        public void LoadRendelesek()
        {
            // 1. Ha lbUgyfelek kiválasztott eleme null, akkor return.
            if (ugyfelBindingSource.Current == null) return;

            // 3. lbUgyfelben kiválasztott ügyfélhez tartozó rendeléseket leszűrjük LINQ segítségével
            var rendeles = from x in _context.Rendeles
                           where x.UgyfelId == ((Ugyfel)ugyfelBindingSource.Current).UgyfelId
                           select x;

            // 4. rendelesBindingSource adatforrásának beállítjuk az eredményt listáját
            rendelesBindingSource.DataSource = rendeles.ToList();

            // 5. újra bekötjük az lbRendeles adatforrását
            rendeleslb.DataSource = rendelesBindingSource;

            // 6. Ha vannak rendelések, akkor kiválasztjuk az elsőt.
            if (rendeleslb.Items.Count > 0)
            {
                rendeleslb.SelectedIndex = 0;
            }

            // meghívjuk a ResetCurrentItem() metódusát a releváns bindingsourcenak.
            rendelesBindingSource.ResetCurrentItem();

        }

        public void LoadRendelesTetel()
        {
            if (rendelesBindingSource.Current == null) { return; }

            var rendeles_tetelek = (from rt in _context.RendelesTetel
                                    where rt.RendelesId == ((Rendeles)rendelesBindingSource.Current).RendelesId
                                    select new RendelesTetelDTO
                                    {
                                        TetelId = rt.TetelId,
                                        TermekNev = rt.Termek.Nev,
                                        Mennyiseg = rt.Mennyiseg,
                                        EgysegAr = rt.EgysegAr,
                                        Afa = rt.Afa,
                                        NettoAr = rt.NettoAr,
                                        BruttoAr = rt.BruttoAr
                                    }).ToList();


            rendelesTetelDTOBindingSource.DataSource = rendeles_tetelek;
            dataGridView1.DataSource = rendelesTetelDTOBindingSource;

            //UpdateVegosszeg();


        }

        private void Ugyfeltxt_TextChanged(object sender, EventArgs e)
        {
            LoadUgyfel();
        }

        private void Termektxt_TextChanged(object sender, EventArgs e)
        {
            LoadTermek();
        }

        private void Ugyfellb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesek();
        }

        private void rendeleslb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRendelesTetel();
        }

        private void Ujrendeles_Click(object sender, EventArgs e)
        {
            if (ugyfelBindingSource.Current == null)
            {
                return;
            }

            // Ha van beállítva az ügyfélhez alapértelmezett lakcím, akkor azt adja vissza, egyéb esetben a címek közül a legelsőt.
            var cim = ((Ugyfel)ugyfelBindingSource.Current).Lakcim ?? _context.Cim.FirstOrDefault();

            if (cim == null)
            {
                MessageBox.Show("Nincs cím megadva.");
                return;
            }

            var ujRendeles = new Rendeles()
            {
                UgyfelId = ((Ugyfel)ugyfelBindingSource.Current).UgyfelId,
                SzallitasiCimId = cim.CimId,
                RendelesDatum = DateTime.Now,
                Kedvezmeny = 0,
                Vegosszeg = 0,
                Statusz = "Feldolgozás alatt"
            };

            _context.Rendeles.Add(ujRendeles);
            Mentés();

            lblRendelesLabel.Text = $"A rendelés teljes értéke: {ujRendeles.Vegosszeg} Ft";

            LoadRendelesek();

            rendeleslb.SelectedItem = ujRendeles;
        }

        private void Mentés()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private const decimal AFA = .27m;

        private void Ujrendelestetel_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMennyiseg.Text, out int mennyiseg) || mennyiseg <= 0)
            {
                MessageBox.Show("Rossz mennyiség!");
                return;
            }

            if (rendelesBindingSource.Current == null || termekBindingSource.Current == null)
            {
                MessageBox.Show("Nincs kiválasztva rendelés vagy termék!");
                return;
            }

            var kivalasztottTermek = (Termek)termekBindingSource.Current;

            decimal bruttoAr = kivalasztottTermek.AktualisAr * (1 + AFA);

            var ujTetel = new RendelesTetel
            {
                RendelesId = ((Rendeles)rendelesBindingSource.Current).RendelesId,
                TermekId = kivalasztottTermek.TermekId,
                Mennyiseg = mennyiseg,
                EgysegAr = kivalasztottTermek.AktualisAr,
                Afa = AFA,
                NettoAr = kivalasztottTermek.AktualisAr * mennyiseg,
                BruttoAr = bruttoAr
            };

            _context.RendelesTetel.Add(ujTetel);
            Mentés();

            LoadRendelesTetel();
        }

        private void rendelesteteltorles_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nincs kiválasztva tétel!");
                return;
            }

            var selectedTetel = dataGridView1.SelectedRows[0].DataBoundItem as RendelesTetelDTO;

            var tetel = (from rt in _context.RendelesTetel
                         where rt.TetelId == selectedTetel!.TetelId
                         select rt).FirstOrDefault();

            if (tetel != null)
            {
                _context.RendelesTetel.Remove(tetel);
                Mentés();

                LoadRendelesTetel();
            }

        }
/*
        private void UpdateVegosszeg()
        {
            if (rendelesBindingSource.Current == null) return;

            var kivalasztottRendeles = (Rendeles)rendelesBindingSource.Current;

            var vegosszeg = _context.RendelesTetel
                .Where(rt => rt.RendelesId == kivalasztottRendeles.RendelesId)
                .Sum(rt => rt.Mennyiseg * rt.BruttoAr);

            kivalasztottRendeles.Vegosszeg = vegosszeg * (1 - kivalasztottRendeles.Kedvezmeny);

            Mentés();

            rendelesBindingSource.ResetBindings(false);
        }*/
    }
    public class CimDTO
    {
        public int cimID { get; set; }

        public string? cimEgyben { get; set; }
    }

    public class RendelesTetelDTO
    {
        public int TetelId { get; set; }
        public string? TermekNev { get; set; }
        public int Mennyiseg { get; set; }
        public decimal EgysegAr { get; set; }
        public decimal Afa { get; set; }
        public decimal NettoAr { get; set; }
        public decimal BruttoAr { get; set; }
    }
}
