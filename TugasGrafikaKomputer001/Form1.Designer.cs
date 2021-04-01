namespace TugasGrafikaKomputer001
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelError = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.panelB = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelDDA = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelBF = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label13 = new System.Windows.Forms.Label();
            this.posisi_mouse = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelError.SuspendLayout();
            this.panelB.SuspendLayout();
            this.panelDDA.SuspendLayout();
            this.panelBF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panelError);
            this.panel1.Controls.Add(this.panelB);
            this.panel1.Controls.Add(this.panelDDA);
            this.panel1.Controls.Add(this.panelBF);
            this.panel1.Controls.Add(this.textBoxX1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxX0);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxY1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxY0);
            this.panel1.Location = new System.Drawing.Point(28, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 437);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.BackgroundImage = global::TugasGrafikaKomputer001.Properties.Resources.twotone_play_circle_black_24dp;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(63, 380);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(55, 53);
            this.panel8.TabIndex = 6;
            this.panel8.Click += new System.EventHandler(this.panel8_Click);
            this.panel8.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseHover);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.BackgroundImage = global::TugasGrafikaKomputer001.Properties.Resources.twotone_close_black_24dp;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(5, 380);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(55, 53);
            this.panel7.TabIndex = 6;
            this.panel7.Click += new System.EventHandler(this.pictureBox1_Click);
            this.panel7.MouseLeave += new System.EventHandler(this.panel7_MouseLeave);
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel7_MouseHover);
            // 
            // panelError
            // 
            this.panelError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelError.Controls.Add(this.labelError);
            this.panelError.Location = new System.Drawing.Point(121, 380);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(159, 53);
            this.panelError.TabIndex = 5;
            this.panelError.Visible = false;
            this.panelError.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // labelError
            // 
            this.labelError.AutoEllipsis = true;
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelError.Location = new System.Drawing.Point(11, 20);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(41, 13);
            this.labelError.TabIndex = 0;
            this.labelError.Text = "label11";
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.Gainsboro;
            this.panelB.Controls.Add(this.label9);
            this.panelB.Controls.Add(this.label10);
            this.panelB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelB.Location = new System.Drawing.Point(5, 269);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(275, 108);
            this.panelB.TabIndex = 5;
            this.panelB.Click += new System.EventHandler(this.panelB_Click);
            this.panelB.MouseLeave += new System.EventHandler(this.panel5_MouseLeave);
            this.panelB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bressenham";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Algoritma";
            // 
            // panelDDA
            // 
            this.panelDDA.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDDA.Controls.Add(this.label7);
            this.panelDDA.Controls.Add(this.label8);
            this.panelDDA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDDA.Location = new System.Drawing.Point(144, 158);
            this.panelDDA.Name = "panelDDA";
            this.panelDDA.Size = new System.Drawing.Size(136, 108);
            this.panelDDA.TabIndex = 5;
            this.panelDDA.Click += new System.EventHandler(this.panelDDA_Click);
            this.panelDDA.MouseLeave += new System.EventHandler(this.panel4_MouseLeave);
            this.panelDDA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "DDA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Algoritma";
            // 
            // panelBF
            // 
            this.panelBF.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBF.Controls.Add(this.label6);
            this.panelBF.Controls.Add(this.label5);
            this.panelBF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBF.Location = new System.Drawing.Point(5, 158);
            this.panelBF.Name = "panelBF";
            this.panelBF.Size = new System.Drawing.Size(136, 108);
            this.panelBF.TabIndex = 5;
            this.panelBF.Click += new System.EventHandler(this.panelBF_Click);
            this.panelBF.MouseLeave += new System.EventHandler(this.panel3_MouseLeave);
            this.panelBF.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "BruteForce";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Algoritma";
            // 
            // textBoxX1
            // 
            this.textBoxX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(19, 111);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(120, 23);
            this.textBoxX1.TabIndex = 3;
            this.textBoxX1.Text = "0";
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBoxX0_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(142, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y1";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxX0
            // 
            this.textBoxX0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX0.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX0.Location = new System.Drawing.Point(19, 48);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(120, 23);
            this.textBoxX0.TabIndex = 3;
            this.textBoxX0.Text = "0";
            this.textBoxX0.TextChanged += new System.EventHandler(this.textBoxX0_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(16, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(142, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxY1
            // 
            this.textBoxY1.BackColor = System.Drawing.Color.White;
            this.textBoxY1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxY1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxY1.Location = new System.Drawing.Point(145, 111);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(120, 22);
            this.textBoxY1.TabIndex = 0;
            this.textBoxY1.Text = "0";
            this.textBoxY1.TextChanged += new System.EventHandler(this.textBoxX0_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "X0";
            // 
            // textBoxY0
            // 
            this.textBoxY0.BackColor = System.Drawing.Color.White;
            this.textBoxY0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxY0.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxY0.Location = new System.Drawing.Point(145, 48);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(120, 22);
            this.textBoxY0.TabIndex = 0;
            this.textBoxY0.Text = "0";
            this.textBoxY0.TextChanged += new System.EventHandler(this.textBoxX0_TextChanged);
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.SystemColors.Window;
            this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDraw.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDraw.Location = new System.Drawing.Point(348, 33);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(428, 437);
            this.panelDraw.TabIndex = 0;
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panelDraw.DoubleClick += new System.EventHandler(this.panel2_DoubleClick);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(348, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "0,0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(730, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "425,434";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(782, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(202, 389);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(830, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Kelompok 6";
            // 
            // posisi_mouse
            // 
            this.posisi_mouse.AutoSize = true;
            this.posisi_mouse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.posisi_mouse.Location = new System.Drawing.Point(554, 13);
            this.posisi_mouse.Name = "posisi_mouse";
            this.posisi_mouse.Size = new System.Drawing.Size(22, 13);
            this.posisi_mouse.TabIndex = 3;
            this.posisi_mouse.Text = "0,0";
            this.posisi_mouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(25, 474);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(424, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Double Click dimana saja untuk menentukan titik X1,Y1 dengan menggunakan mouse ✌️" +
    "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = global::TugasGrafikaKomputer001.Properties.Resources.twotone_palette_white_24dp;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(782, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 42);
            this.panel2.TabIndex = 4;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(990, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.posisi_mouse);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                             ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelError.ResumeLayout(false);
            this.panelError.PerformLayout();
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.panelDDA.ResumeLayout(false);
            this.panelDDA.PerformLayout();
            this.panelBF.ResumeLayout(false);
            this.panelBF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.Panel panelBF;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelDDA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label posisi_mouse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
    }
}

