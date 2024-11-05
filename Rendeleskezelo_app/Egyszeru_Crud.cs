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
    public partial class Egyszeru_Crud : UserControl
    {
        RendelesDbContext _context = new RendelesDbContext();
        public Egyszeru_Crud()
        {
            InitializeComponent();
            LoadUgyfel();
        }

        private void New_Click(object sender, EventArgs e)
        {
            var ujUgyfel = new Ugyfel { Nev = "Új Ügyfél", Email = "uj@pelda.com" };
            _context.Ugyfel.Add(ujUgyfel);
            _context.SaveChanges();
            LoadUgyfel();
        }

        private void LoadUgyfel()
        {
            var ugyfelek = (from u in _context.Ugyfel
                            select u).ToList();

            ugyfelBindingSource.DataSource = ugyfelek;
            Crud_datagridview.DataSource = ugyfelek;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var torlendoUgyfel = Crud_datagridview.CurrentRow.DataBoundItem as Ugyfel;
            if (torlendoUgyfel != null)
            {
                _context.Ugyfel.Remove(torlendoUgyfel);
                _context.SaveChanges();
                LoadUgyfel();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            LoadUgyfel();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadUgyfel();
        }
    }
}
