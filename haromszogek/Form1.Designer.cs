﻿namespace haromszogek
{
    partial class frmFo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAoldal = new System.Windows.Forms.TextBox();
            this.tbBoldal = new System.Windows.Forms.TextBox();
            this.tbColdal = new System.Windows.Forms.TextBox();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHaromszogLista = new System.Windows.Forms.ListBox();
            this.btnTorol = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "A háromszög oldalai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "c:";
            // 
            // tbAoldal
            // 
            this.tbAoldal.Location = new System.Drawing.Point(38, 42);
            this.tbAoldal.Name = "tbAoldal";
            this.tbAoldal.Size = new System.Drawing.Size(100, 29);
            this.tbAoldal.TabIndex = 4;
            // 
            // tbBoldal
            // 
            this.tbBoldal.Location = new System.Drawing.Point(38, 76);
            this.tbBoldal.Name = "tbBoldal";
            this.tbBoldal.Size = new System.Drawing.Size(100, 29);
            this.tbBoldal.TabIndex = 5;
            // 
            // tbColdal
            // 
            this.tbColdal.Location = new System.Drawing.Point(38, 111);
            this.tbColdal.Name = "tbColdal";
            this.tbColdal.Size = new System.Drawing.Size(100, 29);
            this.tbColdal.TabIndex = 6;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(144, 282);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(85, 37);
            this.btnKilepes.TabIndex = 7;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(229, 72);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(119, 33);
            this.btnSzamol.TabIndex = 8;
            this.btnSzamol.Text = "Számolás";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnSzamol);
            this.panel1.Controls.Add(this.tbColdal);
            this.panel1.Controls.Add(this.tbBoldal);
            this.panel1.Controls.Add(this.tbAoldal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 184);
            this.panel1.TabIndex = 9;
            // 
            // lbHaromszogLista
            // 
            this.lbHaromszogLista.FormattingEnabled = true;
            this.lbHaromszogLista.ItemHeight = 24;
            this.lbHaromszogLista.Location = new System.Drawing.Point(401, 49);
            this.lbHaromszogLista.Name = "lbHaromszogLista";
            this.lbHaromszogLista.Size = new System.Drawing.Size(195, 268);
            this.lbHaromszogLista.TabIndex = 10;
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(461, 12);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 33);
            this.btnTorol.TabIndex = 11;
            this.btnTorol.Text = "Törlés";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 331);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.lbHaromszogLista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKilepes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Háromszög";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAoldal;
        private System.Windows.Forms.TextBox tbBoldal;
        private System.Windows.Forms.TextBox tbColdal;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbHaromszogLista;
        private System.Windows.Forms.Button btnTorol;
    }
}

