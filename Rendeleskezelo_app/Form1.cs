using Microsoft.EntityFrameworkCore;
using Rendeleskezelo_app.Data;
using Rendeleskezelo_app.Models;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Rendeleskezelo_app
{
    public partial class Form1 : Form
    {
        RendelesDbContext _context = new RendelesDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Egyszeru_Crud uj_Egyszeru_Crud = new Egyszeru_Crud();

            panel1.Controls.Add(uj_Egyszeru_Crud);

            uj_Egyszeru_Crud.Dock = DockStyle.Fill;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Faszerkezet uj_Egyszeru_Crud = new Faszerkezet();

            panel1.Controls.Add(uj_Egyszeru_Crud);

            uj_Egyszeru_Crud.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Lekérdezem a kategóriákat
            var kategoriak = (from k in _context.TermekKategoria select k).ToList();

            //Létrehozom az XML doksit
            XDocument xdoc = new XDocument();
            XDeclaration xdecl = new XDeclaration("1.0", "utf-8", "yes");
            xdoc.Declaration = xdecl;

            // Győkérele létrehozása
            XElement root = new XElement("kategoriak");
            xdoc.Add(root);

            // Főkategóriák kigyűjtése
            var fokategoriak = kategoriak.Where(k => k.SzuloKategoriaId == null);

            foreach (var kategoria in fokategoriak)
            {
                XElement categoryNode = CreateCategoryElement(kategoria, kategoriak);//*
                root.Add(categoryNode);
            }

            // Mentés
            MessageBox.Show(xdoc.ToString());
            Console.WriteLine("XML file created successfully.");
        }


        //*Rekúrzív függvény
        static XElement CreateCategoryElement(TermekKategoria kategoria, List<TermekKategoria> kategoriak)
        {
            // A kiválasztott főkathoz létrehozzuk a sort
            XElement node = new XElement("kategoria",
                new XAttribute("KategoriaId", kategoria.KategoriaId),
                new XAttribute("Nev", kategoria.Nev)
            );

            //alkategóriák hozzáadása
            var alkategoriak = kategoriak.Where(k => k.SzuloKategoriaId == kategoria.KategoriaId);
            foreach (var gyerekKategoria in alkategoriak)
            {
                XElement childNode = CreateCategoryElement(gyerekKategoria, kategoriak);
                node.Add(childNode);
            }

            return node;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Adatkötés uj_Egyszeru_Crud = new Adatkötés();

            panel1.Controls.Add(uj_Egyszeru_Crud);

            uj_Egyszeru_Crud.Dock = DockStyle.Fill;
        }

       
    
    }
}
