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
    public partial class Faszerkezet : UserControl
    {
        RendelesDbContext _context = new RendelesDbContext();
        public Faszerkezet()
        {
            InitializeComponent();

            LoadKategoriak(); //Ez fogja betölteni a kategóriákat a TreeView-ba
        }

        private void LoadKategoriak()
        {
            // Az összes kategória lekérdezése az adatbázisból
            var kategoriak = (from k in _context.TermekKategoria
                              select k).ToList();

            // TreeView tartalmának törlése
            treeViewKategoriak.Nodes.Clear();

            // Főkategóriák hozzáadása a TreeView-hoz
            var fokategoriak = from k in kategoriak
                               where k.SzuloKategoriaId == null
                               select k;


            foreach (var kategoria in fokategoriak)
            {
                TreeNode node = CreateTreeNode(kategoria, kategoriak);
                treeViewKategoriak.Nodes.Add(node);
            }

        }

        TreeNode CreateTreeNode(TermekKategoria kategoria, List<TermekKategoria> osszeKategoria)
        {
            // TreeNode létrehozása az aktuális kategóriához
            var node = new TreeNode(kategoria.Nev) { Tag = kategoria };

            // Alkategóriák keresése és hozzáadása
            var alkategoriak = from k in osszeKategoria
                               where k.SzuloKategoriaId == kategoria.KategoriaId
                               select k;

            foreach (var gyerekKategoria in alkategoriak)
            {
                node.Nodes.Add(CreateTreeNode(gyerekKategoria, osszeKategoria));
            }

            return node;
        }
    }
}
