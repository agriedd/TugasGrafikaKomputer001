using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasGrafikaKomputer001
{
    class DDA{

        private int x0, y0, x1, y1;
        public List<int[]> nilai;

        public DDA(int x0, int y0, int x1, int y1){
            this.x0 = x0;
            this.x1 = x1;
            this.y0 = y0;
            this.y1 = y1;
        }

        public void draw(Panel parent){
            var canvas = parent.CreateGraphics();
            var penampung = this.algoritma();
            this.nilai = penampung;

            canvas.Clear(Color.White);

            if (penampung.Count > 0)
                foreach (int[] i in penampung)
                {
                    canvas.DrawRectangle(new Pen(Color.Black, 0), i[0], i[1], 1, 1);
                }
        }

        /**
         * keluaran list<int[]> [i][0:1] - 0:x - 1:y
         * 
         */
        public List<int[]> algoritma() {
            var penampung = new List<int[]>();

            /**
             * 1. Tentukan dua titik yang akan dihubungkan dalam pembentukan garis ✔️
             *
             * 2. Tentukan salah satunya sebagai titik awal (x1, y1) dan yang lain sebagai titik akhir (x2, y2).             *              */

            float x0 = this.x0;
            float y0 = this.y0;
            float x1 = this.x1;
            float y1 = this.y1;

            /**
             * 3. Hitung : dx = x2 − x1 dan dy = y2 − y1             *             */

            float dx = x1 - x0;            float dy = y1 - y0;

            /**            * 4. Tentukan step, dengan ketentuan berikut:
            * - bila |dx| > |dy| maka step = |dx|            * - bila tidak, maka step = |dy|             *             */

            float step = Math.Abs(dy);
            if (Math.Abs(dx) > Math.Abs(dy))
                step = Math.Abs(dx);
            /**
             * 5. Hitung penambahan koordinat piksel dengan persamaan:
             * x_inc = dx / step 
             * y_inc = dy / step
             * 
             */

            float x_inc = dx / step;
            float y_inc = dy / step;

            /**
             * 6.Koordinat selanjutnya:
             * x = x + x_inc y = y + y_inc
             * 
             */

            float x = x0;
            float y = y0;
            bool selesai = false;

            while (!selesai){

                x = x + x_inc;
                y = y + y_inc;

                /**
                 * 7. Lakukan pembulatan u = Round(x), v = Round(x), kemudian plot piksel (u, v) pada layar
                 *
                 */

                int u = (int)Math.Round(x);
                int v = (int)Math.Round(y);

                penampung.Add(new int[] { u, v });

                if (u == x1 && v == y1)
                    selesai = true;
            }

            return penampung;
        }

        public ArrayList getListViewItems(){
            var penampung = new ArrayList();
            foreach (int[] i in this.nilai)
                penampung.Add(String.Join(", ", i));
            return penampung;
        }
    }

}
