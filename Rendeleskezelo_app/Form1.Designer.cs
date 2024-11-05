namespace Rendeleskezelo_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(247, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 424);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(4, 12);
            button1.Name = "button1";
            button1.Size = new Size(237, 28);
            button1.TabIndex = 1;
            button1.Text = "Crud művelet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(4, 46);
            button2.Name = "button2";
            button2.Size = new Size(237, 28);
            button2.TabIndex = 2;
            button2.Text = "TreeNode";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(4, 80);
            button3.Name = "button3";
            button3.Size = new Size(237, 28);
            button3.TabIndex = 3;
            button3.Text = "XML";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(4, 114);
            button4.Name = "button4";
            button4.Size = new Size(237, 28);
            button4.TabIndex = 4;
            button4.Text = "Adatkötés";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
