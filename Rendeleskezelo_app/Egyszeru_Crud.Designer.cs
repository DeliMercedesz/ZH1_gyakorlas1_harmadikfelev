namespace Rendeleskezelo_app
{
    partial class Egyszeru_Crud
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
            Crud_datagridview = new DataGridView();
            ugyfelBindingSource = new BindingSource(components);
            New = new Button();
            Delete = new Button();
            Save = new Button();
            Refresh = new Button();
            ugyfelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonszamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lakcimIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Crud_datagridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Crud_datagridview
            // 
            Crud_datagridview.AutoGenerateColumns = false;
            Crud_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Crud_datagridview.Columns.AddRange(new DataGridViewColumn[] { ugyfelIdDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefonszamDataGridViewTextBoxColumn, lakcimIdDataGridViewTextBoxColumn });
            Crud_datagridview.DataSource = ugyfelBindingSource;
            Crud_datagridview.Location = new Point(13, 8);
            Crud_datagridview.Name = "Crud_datagridview";
            Crud_datagridview.Size = new Size(805, 462);
            Crud_datagridview.TabIndex = 0;
            // 
            // ugyfelBindingSource
            // 
            ugyfelBindingSource.DataSource = typeof(Models.Ugyfel);
            // 
            // New
            // 
            New.Location = new Point(13, 493);
            New.Name = "New";
            New.Size = new Size(164, 33);
            New.TabIndex = 1;
            New.Text = "Új (minta)";
            New.UseVisualStyleBackColor = true;
            New.Click += New_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(219, 493);
            Delete.Name = "Delete";
            Delete.Size = new Size(164, 33);
            Delete.TabIndex = 2;
            Delete.Text = "Törlés";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Save
            // 
            Save.Location = new Point(438, 493);
            Save.Name = "Save";
            Save.Size = new Size(164, 33);
            Save.TabIndex = 3;
            Save.Text = "Mentés";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Refresh
            // 
            Refresh.Location = new Point(654, 493);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(164, 33);
            Refresh.TabIndex = 4;
            Refresh.Text = "Frissítés";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // ugyfelIdDataGridViewTextBoxColumn
            // 
            ugyfelIdDataGridViewTextBoxColumn.DataPropertyName = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.HeaderText = "UgyfelId";
            ugyfelIdDataGridViewTextBoxColumn.Name = "ugyfelIdDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            telefonszamDataGridViewTextBoxColumn.DataPropertyName = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.HeaderText = "Telefonszam";
            telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            // 
            // lakcimIdDataGridViewTextBoxColumn
            // 
            lakcimIdDataGridViewTextBoxColumn.DataPropertyName = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.HeaderText = "LakcimId";
            lakcimIdDataGridViewTextBoxColumn.Name = "lakcimIdDataGridViewTextBoxColumn";
            lakcimIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            // 
            // Egyszeru_Crud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(Refresh);
            Controls.Add(Save);
            Controls.Add(Delete);
            Controls.Add(New);
            Controls.Add(Crud_datagridview);
            Name = "Egyszeru_Crud";
            Size = new Size(829, 538);
            ((System.ComponentModel.ISupportInitialize)Crud_datagridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugyfelBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Crud_datagridview;
        private BindingSource ugyfelBindingSource;
        private Button New;
        private Button Delete;
        private Button Save;
        private Button Refresh;
        private DataGridViewTextBoxColumn ugyfelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lakcimIdDataGridViewTextBoxColumn;
    }
}
