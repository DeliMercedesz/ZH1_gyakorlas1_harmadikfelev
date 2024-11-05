namespace Rendeleskezelo_app
{
    partial class Adatkötés
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
            dataGridView1 = new DataGridView();
            tetelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            termekNevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mennyisegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            egysegArDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            afaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nettoArDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bruttoArDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rendelesTetelDTOBindingSource = new BindingSource(components);
            Ugyfeltxt = new TextBox();
            Ugyfellb = new ListBox();
            ugyfelBindingSource = new BindingSource(components);
            Termeklb = new ListBox();
            termekBindingSource = new BindingSource(components);
            Termektxt = new TextBox();
            comboBox1 = new ComboBox();
            rendelesBindingSource = new BindingSource(components);
            cimDTOBindingSource = new BindingSource(components);
            rendeleslb = new ListBox();
            comboBox2 = new ComboBox();
            Ujrendeles = new Button();
            Ujrendelestetel = new Button();
            rendelesteteltorles = new Button();
            txtMennyiseg = new TextBox();
            lblRendelesLabel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesTetelDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cimDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tetelIdDataGridViewTextBoxColumn, termekNevDataGridViewTextBoxColumn, mennyisegDataGridViewTextBoxColumn, egysegArDataGridViewTextBoxColumn, afaDataGridViewTextBoxColumn, nettoArDataGridViewTextBoxColumn, bruttoArDataGridViewTextBoxColumn });
            dataGridView1.DataSource = rendelesTetelDTOBindingSource;
            dataGridView1.Location = new Point(327, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(410, 334);
            dataGridView1.TabIndex = 0;
            // 
            // tetelIdDataGridViewTextBoxColumn
            // 
            tetelIdDataGridViewTextBoxColumn.DataPropertyName = "TetelId";
            tetelIdDataGridViewTextBoxColumn.HeaderText = "TetelId";
            tetelIdDataGridViewTextBoxColumn.Name = "tetelIdDataGridViewTextBoxColumn";
            // 
            // termekNevDataGridViewTextBoxColumn
            // 
            termekNevDataGridViewTextBoxColumn.DataPropertyName = "TermekNev";
            termekNevDataGridViewTextBoxColumn.HeaderText = "TermekNev";
            termekNevDataGridViewTextBoxColumn.Name = "termekNevDataGridViewTextBoxColumn";
            // 
            // mennyisegDataGridViewTextBoxColumn
            // 
            mennyisegDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg";
            mennyisegDataGridViewTextBoxColumn.HeaderText = "Mennyiseg";
            mennyisegDataGridViewTextBoxColumn.Name = "mennyisegDataGridViewTextBoxColumn";
            // 
            // egysegArDataGridViewTextBoxColumn
            // 
            egysegArDataGridViewTextBoxColumn.DataPropertyName = "EgysegAr";
            egysegArDataGridViewTextBoxColumn.HeaderText = "EgysegAr";
            egysegArDataGridViewTextBoxColumn.Name = "egysegArDataGridViewTextBoxColumn";
            // 
            // afaDataGridViewTextBoxColumn
            // 
            afaDataGridViewTextBoxColumn.DataPropertyName = "Afa";
            afaDataGridViewTextBoxColumn.HeaderText = "Afa";
            afaDataGridViewTextBoxColumn.Name = "afaDataGridViewTextBoxColumn";
            // 
            // nettoArDataGridViewTextBoxColumn
            // 
            nettoArDataGridViewTextBoxColumn.DataPropertyName = "NettoAr";
            nettoArDataGridViewTextBoxColumn.HeaderText = "NettoAr";
            nettoArDataGridViewTextBoxColumn.Name = "nettoArDataGridViewTextBoxColumn";
            // 
            // bruttoArDataGridViewTextBoxColumn
            // 
            bruttoArDataGridViewTextBoxColumn.DataPropertyName = "BruttoAr";
            bruttoArDataGridViewTextBoxColumn.HeaderText = "BruttoAr";
            bruttoArDataGridViewTextBoxColumn.Name = "bruttoArDataGridViewTextBoxColumn";
            // 
            // rendelesTetelDTOBindingSource
            // 
            rendelesTetelDTOBindingSource.DataSource = typeof(RendelesTetelDTO);
            // 
            // Ugyfeltxt
            // 
            Ugyfeltxt.Location = new Point(3, 44);
            Ugyfeltxt.Name = "Ugyfeltxt";
            Ugyfeltxt.Size = new Size(127, 23);
            Ugyfeltxt.TabIndex = 1;
            Ugyfeltxt.TextChanged += Ugyfeltxt_TextChanged;
            // 
            // Ugyfellb
            // 
            Ugyfellb.DataSource = ugyfelBindingSource;
            Ugyfellb.DisplayMember = "Nev";
            Ugyfellb.FormattingEnabled = true;
            Ugyfellb.ItemHeight = 15;
            Ugyfellb.Location = new Point(3, 73);
            Ugyfellb.Name = "Ugyfellb";
            Ugyfellb.Size = new Size(127, 334);
            Ugyfellb.TabIndex = 2;
            Ugyfellb.ValueMember = "UgyfelID";
            Ugyfellb.SelectedIndexChanged += Ugyfellb_SelectedIndexChanged;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // Termeklb
            // 
            Termeklb.DataSource = termekBindingSource;
            Termeklb.DisplayMember = "Nev";
            Termeklb.FormattingEnabled = true;
            Termeklb.ItemHeight = 15;
            Termeklb.Location = new Point(849, 73);
            Termeklb.Name = "Termeklb";
            Termeklb.Size = new Size(127, 334);
            Termeklb.TabIndex = 3;
            Termeklb.ValueMember = "TermekID";
            // 
            // termekBindingSource
            // 
            termekBindingSource.DataSource = typeof(Models.Termek);
            // 
            // Termektxt
            // 
            Termektxt.Location = new Point(849, 44);
            Termektxt.Name = "Termektxt";
            Termektxt.Size = new Size(127, 23);
            Termektxt.TabIndex = 4;
            Termektxt.TextChanged += Termektxt_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", rendelesBindingSource, "SzallitasiCimId", true));
            comboBox1.DataSource = cimDTOBindingSource;
            comboBox1.DisplayMember = "CimEgyben";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(327, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(410, 23);
            comboBox1.TabIndex = 5;
            comboBox1.ValueMember = "CimID";
            // 
            // rendelesBindingSource
            // 
            rendelesBindingSource.DataSource = typeof(Models.Rendeles);
            // 
            // cimDTOBindingSource
            // 
            cimDTOBindingSource.DataSource = typeof(CimDTO);
            // 
            // rendeleslb
            // 
            rendeleslb.DataSource = rendelesBindingSource;
            rendeleslb.DisplayMember = "RendelesDatum";
            rendeleslb.FormattingEnabled = true;
            rendeleslb.ItemHeight = 15;
            rendeleslb.Location = new Point(136, 73);
            rendeleslb.Name = "rendeleslb";
            rendeleslb.Size = new Size(170, 334);
            rendeleslb.TabIndex = 6;
            rendeleslb.ValueMember = "RendelesID";
            rendeleslb.SelectedIndexChanged += rendeleslb_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DataBindings.Add(new Binding("Text", rendelesBindingSource, "Statusz", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Feldolgozás alatt ", "Szállítás", "Kiszállítva", "Törölve" });
            comboBox2.Location = new Point(136, 44);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 23);
            comboBox2.TabIndex = 7;
            // 
            // Ujrendeles
            // 
            Ujrendeles.Location = new Point(327, 423);
            Ujrendeles.Name = "Ujrendeles";
            Ujrendeles.Size = new Size(88, 22);
            Ujrendeles.TabIndex = 8;
            Ujrendeles.Text = "Új rendeles";
            Ujrendeles.UseVisualStyleBackColor = true;
            Ujrendeles.Click += Ujrendeles_Click;
            // 
            // Ujrendelestetel
            // 
            Ujrendelestetel.Location = new Point(743, 197);
            Ujrendelestetel.Name = "Ujrendelestetel";
            Ujrendelestetel.Size = new Size(100, 39);
            Ujrendelestetel.TabIndex = 9;
            Ujrendelestetel.Text = "Új rendelés tétel";
            Ujrendelestetel.UseVisualStyleBackColor = true;
            Ujrendelestetel.Click += Ujrendelestetel_Click;
            // 
            // rendelesteteltorles
            // 
            rendelesteteltorles.Location = new Point(743, 242);
            rendelesteteltorles.Name = "rendelesteteltorles";
            rendelesteteltorles.Size = new Size(100, 42);
            rendelesteteltorles.TabIndex = 12;
            rendelesteteltorles.Text = "Rendelés tétel törlés";
            rendelesteteltorles.UseVisualStyleBackColor = true;
            rendelesteteltorles.Click += rendelesteteltorles_Click;
            // 
            // txtMennyiseg
            // 
            txtMennyiseg.Location = new Point(752, 168);
            txtMennyiseg.Name = "txtMennyiseg";
            txtMennyiseg.Size = new Size(91, 23);
            txtMennyiseg.TabIndex = 13;
            // 
            // lblRendelesLabel
            // 
            lblRendelesLabel.Location = new Point(421, 422);
            lblRendelesLabel.Name = "lblRendelesLabel";
            lblRendelesLabel.Size = new Size(255, 23);
            lblRendelesLabel.TabIndex = 14;
            // 
            // Adatkötés
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            Controls.Add(lblRendelesLabel);
            Controls.Add(txtMennyiseg);
            Controls.Add(rendelesteteltorles);
            Controls.Add(Ujrendelestetel);
            Controls.Add(Ujrendeles);
            Controls.Add(comboBox2);
            Controls.Add(rendeleslb);
            Controls.Add(comboBox1);
            Controls.Add(Termektxt);
            Controls.Add(Termeklb);
            Controls.Add(Ugyfellb);
            Controls.Add(Ugyfeltxt);
            Controls.Add(dataGridView1);
            Name = "Adatkötés";
            Size = new Size(984, 460);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesTetelDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)termekBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rendelesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cimDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox Ugyfeltxt;
        private ListBox Ugyfellb;
        private BindingSource ugyfelBindingSource;
        private ListBox Termeklb;
        private BindingSource termekBindingSource;
        private TextBox Termektxt;
        private ComboBox comboBox1;
        private BindingSource cimDTOBindingSource;
        private ListBox rendeleslb;
        private BindingSource rendelesBindingSource;
        private DataGridViewTextBoxColumn tetelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn termekNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyisegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegArDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn afaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nettoArDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bruttoArDataGridViewTextBoxColumn;
        private BindingSource rendelesTetelDTOBindingSource;
        private ComboBox comboBox2;
        private Button Ujrendeles;
        private Button Ujrendelestetel;
        private Button rendelesteteltorles;
        private TextBox txtMennyiseg;
        private TextBox lblRendelesLabel;
    }
}
