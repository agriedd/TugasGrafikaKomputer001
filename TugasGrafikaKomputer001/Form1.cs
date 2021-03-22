using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasGrafikaKomputer001
{
    public partial class Form1 : Form
    {

        private int x0, y0, x1, y1;
        private string algoritma = "bruteforce";

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            var panel = (Panel) sender;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = (MouseEventArgs) e;
            textBoxX1.Text = mouseEvent.X.ToString();
            textBoxY1.Text = mouseEvent.Y.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseHover(object sender, EventArgs e){
            var panel = (Panel) sender;
            panel.BackColor = Color.DarkGray;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            panel.BackColor = Color.Gainsboro;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void panel4_MouseHover(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            panel.BackColor = Color.DarkGray;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            panel.BackColor = Color.Gainsboro;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            panel.BackColor = Color.DarkGray;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            panel.BackColor = Color.Gainsboro;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
        }

        private void panel6_Paint(object sender, PaintEventArgs e){
        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            panel.BackColor = Color.Teal;
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            panel.BackColor = Color.Gainsboro;
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            panel.BackColor = Color.HotPink;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            var panel = (Panel)sender;
            panel.BackColor = Color.Gainsboro;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            bool isValid = this.validasi();
            if (isValid){
                switch (this.algoritma){
                    case "bruteforce":
                        var algoritma = new BruteForce(this.x0, this.y0, this.x1, this.y1);
                        algoritma.draw(panelDraw);
                        listView1.Items.Clear();
                        foreach (string value in algoritma.getListViewItems()){
                            listView1.Items.Add(
                                new ListViewItem( value )
                            );
                        }
                    break;
                    case "dda":
                        var algoritma2 = new DDA(this.x0, this.y0, this.x1, this.y1);
                        algoritma2.draw(panelDraw);
                        listView1.Items.Clear();
                        foreach (string value in algoritma2.getListViewItems()){
                            listView1.Items.Add(
                                new ListViewItem( value )
                            );
                        }
                    break;
                    case "bressenham":
                        var algoritma3 = new Bressenham(this.x0, this.y0, this.x1, this.y1);
                        algoritma3.draw(panelDraw);
                        listView1.Items.Clear();
                        foreach (string value in algoritma3.getListViewItems())
                        {
                            listView1.Items.Add(
                                new ListViewItem(value)
                            );
                        }
                        break;
                }
            }
        }

        private void textBoxX0_TextChanged(object sender, EventArgs e)
        {
            this.hideError();
        }

        private bool validasi(){
            var valid = false;
            try{
                this.x0 = int.Parse(textBoxX0.Text);
                this.x1 = int.Parse(textBoxX1.Text);
                this.y0 = int.Parse(textBoxY0.Text);
                this.y1 = int.Parse(textBoxY1.Text);
                valid = true;
            }
            catch (Exception){
                showError("Masukan inputan dengan benar!");
                valid = false;
            }
            return valid;
        }

        private void showError(string v){
            labelError.Text = v;
            panelError.Visible = true;
        }
        private void hideError(){
            panelError.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.selectBF();
        }

        private void panelBF_Click(object sender, EventArgs e)
        {
            this.selectBF();
        }

        private void panelDDA_Click(object sender, EventArgs e)
        {
            this.selectDDA();
        }

        private void panelB_Click(object sender, EventArgs e)
        {
            this.selectB();
        }

        private void selectBF()
        {
            this.algoritma = "bruteforce";
            panelBF.BorderStyle = BorderStyle.FixedSingle;
            panelB.BorderStyle = BorderStyle.None;
            panelDDA.BorderStyle = BorderStyle.None;
        }
        private void selectB(){
            this.algoritma = "bressenham";
            panelBF.BorderStyle = BorderStyle.None;
            panelB.BorderStyle = BorderStyle.FixedSingle;
            panelDDA.BorderStyle = BorderStyle.None;
        }
        private void selectDDA(){
            this.algoritma = "dda";
            panelBF.BorderStyle = BorderStyle.None;
            panelB.BorderStyle = BorderStyle.None;
            panelDDA.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
