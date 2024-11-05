namespace Rendeleskezelo_app
{
    partial class Faszerkezet
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeViewKategoriak = new TreeView();
            contextMenuStripKategória = new ContextMenuStrip(components);
            átnevezésToolStripMenuItem = new ToolStripMenuItem();
            frissítésToolStripMenuItem = new ToolStripMenuItem();
            törlésToolStripMenuItem = new ToolStripMenuItem();
            újFőkategóriaToolStripMenuItem = new ToolStripMenuItem();
            újAlkategóriaToolStripMenuItem = new ToolStripMenuItem();
            Nevtxt = new TextBox();
            txtLeiras = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Uj_test_kat = new Button();
            Uj_gyer_kaz = new Button();
            Save = new Button();
            Delete = new Button();
            contextMenuStripKategória.SuspendLayout();
            SuspendLayout();
            // 
            // treeViewKategoriak
            // 
            treeViewKategoriak.ContextMenuStrip = contextMenuStripKategória;
            treeViewKategoriak.LabelEdit = true;
            treeViewKategoriak.Location = new Point(15, 18);
            treeViewKategoriak.Name = "treeViewKategoriak";
            treeViewKategoriak.Size = new Size(231, 541);
            treeViewKategoriak.TabIndex = 0;
            // 
            // contextMenuStripKategória
            // 
            contextMenuStripKategória.Items.AddRange(new ToolStripItem[] { átnevezésToolStripMenuItem, frissítésToolStripMenuItem, törlésToolStripMenuItem, újFőkategóriaToolStripMenuItem, újAlkategóriaToolStripMenuItem });
            contextMenuStripKategória.Name = "contextMenuStripKategória";
            contextMenuStripKategória.Size = new Size(181, 136);
            // 
            // átnevezésToolStripMenuItem
            // 
            átnevezésToolStripMenuItem.Name = "átnevezésToolStripMenuItem";
            átnevezésToolStripMenuItem.Size = new Size(180, 22);
            átnevezésToolStripMenuItem.Text = "Átnevezés";
            // 
            // frissítésToolStripMenuItem
            // 
            frissítésToolStripMenuItem.Name = "frissítésToolStripMenuItem";
            frissítésToolStripMenuItem.Size = new Size(180, 22);
            frissítésToolStripMenuItem.Text = "Frissítés";
            // 
            // törlésToolStripMenuItem
            // 
            törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            törlésToolStripMenuItem.Size = new Size(180, 22);
            törlésToolStripMenuItem.Text = "Törlés";
            // 
            // újFőkategóriaToolStripMenuItem
            // 
            újFőkategóriaToolStripMenuItem.Name = "újFőkategóriaToolStripMenuItem";
            újFőkategóriaToolStripMenuItem.Size = new Size(180, 22);
            újFőkategóriaToolStripMenuItem.Text = "Új főkategória";
            // 
            // újAlkategóriaToolStripMenuItem
            // 
            újAlkategóriaToolStripMenuItem.Name = "újAlkategóriaToolStripMenuItem";
            újAlkategóriaToolStripMenuItem.Size = new Size(180, 22);
            újAlkategóriaToolStripMenuItem.Text = "Új alkategória";
            // 
            // Nevtxt
            // 
            Nevtxt.Location = new Point(306, 18);
            Nevtxt.Name = "Nevtxt";
            Nevtxt.Size = new Size(352, 23);
            Nevtxt.TabIndex = 1;
            // 
            // txtLeiras
            // 
            txtLeiras.Location = new Point(306, 89);
            txtLeiras.MaximumSize = new Size(0, 400);
            txtLeiras.MinimumSize = new Size(0, 400);
            txtLeiras.Name = "txtLeiras";
            txtLeiras.Size = new Size(352, 400);
            txtLeiras.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 21);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 244);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Leírás:";
            // 
            // Uj_test_kat
            // 
            Uj_test_kat.Location = new Point(306, 534);
            Uj_test_kat.Name = "Uj_test_kat";
            Uj_test_kat.Size = new Size(88, 25);
            Uj_test_kat.TabIndex = 5;
            Uj_test_kat.Text = "Új test. kat.";
            Uj_test_kat.UseVisualStyleBackColor = true;
            // 
            // Uj_gyer_kaz
            // 
            Uj_gyer_kaz.Location = new Point(400, 534);
            Uj_gyer_kaz.Name = "Uj_gyer_kaz";
            Uj_gyer_kaz.Size = new Size(88, 25);
            Uj_gyer_kaz.TabIndex = 6;
            Uj_gyer_kaz.Text = "Új gyer. kat.";
            Uj_gyer_kaz.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            Save.Location = new Point(519, 534);
            Save.Name = "Save";
            Save.Size = new Size(66, 25);
            Save.TabIndex = 7;
            Save.Text = "Mentés";
            Save.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.Location = new Point(591, 534);
            Delete.Name = "Delete";
            Delete.Size = new Size(67, 25);
            Delete.TabIndex = 8;
            Delete.Text = "Törlés";
            Delete.UseVisualStyleBackColor = true;
            // 
            // Faszerkezet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(Delete);
            Controls.Add(Save);
            Controls.Add(Uj_gyer_kaz);
            Controls.Add(Uj_test_kat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLeiras);
            Controls.Add(Nevtxt);
            Controls.Add(treeViewKategoriak);
            Name = "Faszerkezet";
            Size = new Size(675, 574);
            contextMenuStripKategória.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewKategoriak;
        private TextBox Nevtxt;
        private TextBox txtLeiras;
        private Label label1;
        private Label label2;
        private Button Uj_test_kat;
        private Button Uj_gyer_kaz;
        private Button Save;
        private Button Delete;
        private ContextMenuStrip contextMenuStripKategória;
        private ToolStripMenuItem átnevezésToolStripMenuItem;
        private ToolStripMenuItem frissítésToolStripMenuItem;
        private ToolStripMenuItem törlésToolStripMenuItem;
        private ToolStripMenuItem újFőkategóriaToolStripMenuItem;
        private ToolStripMenuItem újAlkategóriaToolStripMenuItem;
    }
}
