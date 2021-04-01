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

        /**
         * deklarasi variabel 
         * x0, y0
         * x1, x1
         * 
         */
        private int x0, y0, x1, y1;

        /**
         * tambahan menentukan warna line
         * 
         */

        private Color warna = Color.Black;

        /**
         * membuat opsi pilihan static
         * 
         * fungsinya sama seperti constant
         * jadi daripada mengetik dan men cek variabel algoritma == "bruteforce"
         *      bakalan jadi lebih mudah algoritma == BRUTEFORCE (autocomplete dan untuk mengubah nilai stringnya hanya 1x saja)
         * 
         */
        public const string BRUTEFORCE = "bruteforce";
        public const string DDA = "dda";
        public const string BRESSENHAM = "bressenham";

        /**
         * variabel algoritma untuk menyimpan state atau pilihan algoritma apa yang sedang aktif
         *      gunakan public const string BRUTEFORCE, DDA, dan BRESSENHAM diatas untuk nilai variabel ini
         *       
         */
        private string algoritma;

        /**
         * karena form ini tidak menggunakan border maka form ini tidak dapat digeser, sehingga untuk mengakalinya dengan
         * 
         * menyimpan titik awal koordinat x,y form saat mouse diklik (ditahan / saat belum dilepas)
         * dan mengubah status variabel form_moving menjadi true
         * 
         * artinya form_moving ini akan jadi parameter penentu jika form ini dapat digeser saat mouse diklik (ditahan / saat belum dilepas)
         * dan akan bernilai false ketika mouse klik dilepas
         * 
         */
        private int form_x, form_y;
        private Boolean form_moving = false;

        /**
         * constructor dalam class Form1
         * 
         * setiap form1 di instansiasi fungsi ini akan dipanggil
         * 
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e){}

        private void label2_Click(object sender, EventArgs e){}

        /**
         * fungsi ini didaftarkan ketika panel2 ( canvas yang digunakan untuk menggambar garis )
         * terjadi event doubleClick
         * 
         * ketika di double klik, maka titik koordinat x, y saat di double klik akan dimasukan kedalam
         * textBoxX1 dan textBoxY1
         * 
         */
        private void panel2_DoubleClick(object sender, EventArgs e){
            MouseEventArgs mouseEvent = (MouseEventArgs) e;
            textBoxX1.Text = mouseEvent.X.ToString();
            textBoxY1.Text = mouseEvent.Y.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}

        /**
         * fungsi yang akan dipanggil ketika tombol close di klik
         * 
         * dengan memanggil method Close() program akan dihentikan
         * 
         */
        private void pictureBox1_Click(object sender, EventArgs e){
            this.Close();
        }

        /**
         * fungsi yang menghandle event onMouseMove pada panel3
         * 
         * ketika mouse melewati objek desain ini maka teks labelnya berubah warnanya
         * dan background panel yang dimaksud (ketika dilewati mouse) juga berubah warna
         * 
         */
        private void panel3_MouseHover(object sender, EventArgs e){
            var panel = (Panel) sender;
            panel.BackColor = Color.DarkGray;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
        }

        /**
         * fungsi yang menghandle event mouseOver sebelumnya, ketika mouse keluar dari
         * objek panel maka warna background dan labelnya dikembalikan seperti sedia kala
         * 
         */
        private void panel3_MouseLeave(object sender, EventArgs e){
            var panel = (Panel)sender;
            panel.BackColor = Color.Gainsboro;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
        }
        private void panel4_MouseHover(object sender, EventArgs e){
            var panel = (Panel)sender;
            panel.BackColor = Color.DarkGray;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
        }

        private void panel4_MouseLeave(object sender, EventArgs e){
            var panel = (Panel)sender;
            panel.BackColor = Color.Gainsboro;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
        }

        private void panel5_MouseHover(object sender, EventArgs e){
            var panel = (Panel)sender;
            panel.BackColor = Color.DarkGray;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
        }

        private void panel5_MouseLeave(object sender, EventArgs e){
            var panel = (Panel)sender;
            panel.BackColor = Color.Gainsboro;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
        }

        private void panel6_Paint(object sender, PaintEventArgs e){}

        /**
         * fungsi untuk mengubah warna tombol "jalankan" menjadi berwarna hijau
         * ketika mouseOver
         * 
         */
        private void panel8_MouseHover(object sender, EventArgs e){
            var panel = (Panel)sender;
            panel.BackColor = Color.Teal;
        }

        /**
         * mengembalikan warna tombol "jalankan" ke sedia kala
         * 
         */
        private void panel8_MouseLeave(object sender, EventArgs e){
            var panel = (Panel)sender;
            panel.BackColor = Color.Gainsboro;
        }

        /**
         * mengubah warna tombol keluar aplikasi ketika mouse over
         * 
         */
        private void panel7_MouseHover(object sender, EventArgs e){
            var panel = (Panel)sender;
            panel.BackColor = Color.IndianRed;
        }

        /**
         *  mengubah warna tombol keluar seperti sedia kala.
         */
        private void panel7_MouseLeave(object sender, EventArgs e){
            var panel = (Panel)sender;
            panel.BackColor = Color.Gainsboro;
        }

        /**
         *  tombol "jalankan" ketika di-klik
         *  
         *  
         */
        private void panel8_Click(object sender, EventArgs e){
            /**
             * validasi input x0, y0, x1, y1 sebelum proses dieksekusi
             * 
             */
            bool isValid = this.validasi();

            /**
             * cek dahulu hasil validasinya apakah valid atau tidak
             * 
             */
            if (isValid){

                /**
                 *  dengan menggunakan interface akan menghemat baris perintah dari 3 buah class yang berbeda
                 *  karena ketiga class menggunakan method yang sama
                 * 
                 */
                AlgoritmaGaris algoritma = null;

                switch (this.algoritma){
                    case BRUTEFORCE:
                    default:
                        algoritma = new BruteForce(this.x0, this.y0, this.x1, this.y1);
                    break;
                    case DDA:
                        algoritma = new DDA(this.x0, this.y0, this.x1, this.y1);
                    break;
                    case BRESSENHAM:
                        algoritma = new Bressenham(this.x0, this.y0, this.x1, this.y1);
                    break;
                }

                /**
                 * menentukan warna sebelum menggambar pada canvas
                 * 
                 */
                algoritma.setColor( this.warna );

                /**
                 * mengambbar gari diatas canvas
                 * 
                 */
                algoritma.draw(panelDraw);

                /**
                 * menampung data point algoritma pembuatan garis pada listView agar ditampilkan
                 * 
                 * listView (kotak sebelah kanan)
                 * 
                 * pertama-tama item-item dari listView dibersihkan dahulu,
                 * 
                 */
                listView1.Items.Clear();

                /**
                 * 
                 * berikutnya dengan melakukan perulangan agar tiap point yang didapat dari hasil
                 * algoritma garis sebelumnya di push ( tumpuk ) pada item listview yang baru dibersihkan
                 * sebelumnya
                 * 
                 * algoritma.getListViewItems()
                 * adalah method yang mengembalikan list string titik koordinat hasil algoritma
                 * 
                 * bisa dilihat pada 3 class Algoritma diatas
                 * 
                 */
                foreach (string value in algoritma.getListViewItems()){
                    listView1.Items.Add(
                        new ListViewItem(value)
                    );
                }
            }
        }

        /**
         * 
         * ketika teksbox apa saja terjadi perubahan nilai maka label pesan error
         * disembunyikan
         * 
         */
        private void textBoxX0_TextChanged(object sender, EventArgs e){
            this.hideError();
        }

        /**
         * 
         * proses validasi inputan textbox
         * 
         */
        private bool validasi(){
            /**
             * nilai awal valid adalah false
             *  
             */
            var valid = false;


            /**
             * 
             * menggunakan try catch untuk menangkap error hasil parsing string ke int
             * ketika user menginput karakter akan terjadi error dan hasil error tsb. ditangkap pada 
             * skope catch(Exception){ ... } daripada proses dihentikan
             * 
             * jika tidak terjadi kesalahan saat parsing type data valid bernilai true
             * 
             */
            try{
                this.x0 = int.Parse(textBoxX0.Text);
                this.x1 = int.Parse(textBoxX1.Text);
                this.y0 = int.Parse(textBoxY0.Text);
                this.y1 = int.Parse(textBoxY1.Text);
                valid = true;
            }
            catch (Exception){
                /**
                 * 
                 * menampilkan pesan error dengan memanggil method showError()
                 * valid tetap valse
                 * 
                 */

                this.showError("Masukan inputan dengan benar!");
                valid = false;
            }
            /**
             * 
             * me-return hasil validasi
             * 
             */

            return valid;
        }

        /**
         * 
         * method showError hanya membuat panelError menjadi visible saja
         * dan labelnya berisikan teks yang dikirim sebagai parameter v
         * 
         */
        private void showError(string v){
            labelError.Text = v;
            panelError.Visible = true;
        }

        /**
         * 
         * method hideError hanya membuat visibilitas panelError menjadi valse saja
         * 
         */
        private void hideError(){
            panelError.Visible = false;
        }

        /**
         * 
         * awalnya algoritma belum dipilih jadi tujuan method ini
         * ketika form1 berhasil diload maka algoritma dipilih sebagai bruteforce contohnya
         * 
         */
        private void Form1_Load(object sender, EventArgs e){
            /**
             * 
             * memilih algoritma awal bruteforce
             * 
             */
            this.selectBF();
        }

        /**
         * 
         * ketika panel bruteforce diklik maka bruteforce dipilih sebagai bruteforce
         * 
         */
        private void panelBF_Click(object sender, EventArgs e){
            this.selectBF();
        }

        /**
         * 
         * sama aja sih cuma DDA
         * 
         */
        private void panelDDA_Click(object sender, EventArgs e){
            this.selectDDA();
        }

        /**
         * 
         * sama aja cuma Bressenham
         * 
         */
        private void panelB_Click(object sender, EventArgs e){
            this.selectB();
        }

        /**
         * 
         * ketika form 1 diklik maka
         * 
         * status form_1 akan ditandai moveable atau bisa digeser
         * dan titik x,y awal ketika mouse diklik
         * 
         */
        private void Form1_MouseDown(object sender, MouseEventArgs e){
            this.form_moving = true;
            this.form_x = e.X;
            this.form_y = e.Y;
        }

        /**
         * 
         * ketika mouse bergerak dan dalam keadaan moveable atau form_moving bernilai true,
         * maka form1 ini lokasi koordinatnya pada desktop akan mengikuti pergerakan mouse
         * 
         */
        private void Form1_MouseMove(object sender, MouseEventArgs e){
            if (this.form_moving){
                this.SetDesktopLocation(MousePosition.X - this.form_x, MousePosition.Y - this.form_y);
            }
        }

        /**
         * 
         * melepas klik sehingga form moving menjadi false, sehingga berdampak pada lokasi form pada desktop
         * pada method sebelumnya
         * 
         */
        private void Form1_MouseUp(object sender, MouseEventArgs e){
            this.form_moving = false;
        }


        /**
         * 
         * menulis titik koordinat x,y pada panelDraw atau kotak kanvas yang digunakan untuk menggambar titik
         * hasil algoritma
         * 
         */
        private void panelDraw_MouseMove(object sender, MouseEventArgs e){
            this.posisi_mouse.Text = e.X + "," + e.Y;
        }


        /**
         * 
         * method buat milih algoritma jadi algoritma yang dipilih
         * panelnya bakalan punya border hitam
         * 
         */
        private void selectBF(){
            this.algoritma = BRUTEFORCE;

            panelBF.BorderStyle = BorderStyle.FixedSingle;
            panelB.BorderStyle = BorderStyle.None;
            panelDDA.BorderStyle = BorderStyle.None;
        }
        private void selectB(){
            this.algoritma = BRESSENHAM;

            panelBF.BorderStyle = BorderStyle.None;
            panelB.BorderStyle = BorderStyle.FixedSingle;
            panelDDA.BorderStyle = BorderStyle.None;
        }
        private void selectDDA(){
            this.algoritma = DDA;
            panelBF.BorderStyle = BorderStyle.None;
            panelB.BorderStyle = BorderStyle.None;
            panelDDA.BorderStyle = BorderStyle.FixedSingle;
        }


        private void panel2_Click(object sender, EventArgs e){
            var color_dialog = new ColorDialog();
            var result = color_dialog.ShowDialog();
            var panel = (Panel) sender;
            if(result == DialogResult.OK){
                panel.BackColor = color_dialog.Color;
                this.warna = color_dialog.Color;
            }
            color_dialog = null;
        }
    }
}
