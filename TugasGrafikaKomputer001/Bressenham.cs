using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasGrafikaKomputer001
{
    class Bressenham : AlgoritmaGaris
    {

        private int x0, y0, x1, y1;
        public List<int[]> nilai;

        public Bressenham(int x0, int y0, int x1, int y1)
        {
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
        public List<int[]> algoritma()
        {
            var penampung = new List<int[]>();

            /**
             * 1. Tentukan dua titik yang akan dihubungkan dalam pembentukan garis. ✔️
             * 2. Tentukan salah satu sebagai titik awal (x0, y0) dan titik akhir (x1, y1).
             * 
             */

            int x0 = this.x0;
            int y0 = this.y0;
            int x1 = this.x1;
            int y1 = this.y1;


            /**
             * 3. Hitung dx, dy, 2|dy| dan 2|dy| − 2|dx|
             * 
             */

            int dx = x1 - x0;
            int dy = y1 - y0;


            /**
             * 
             * tambahan
             * 
             * 
             */

            /**
             * 
             * periksa apakah dx > dari dy, maka 
             * 
             */

            if(dx >= dy){
                return this.dxLebihDariDy(penampung, dx, dy, x0, y0);
            } else {
                return this.dyLebihDariDx(penampung, dx, dy, x0, y0);
            }

        }

        public List<int[]> dxLebihDariDy(List<int[]> penampung, int dx, int dy, int x0, int y0){

            int dy_2 = 2 * Math.Abs(dy);
            int dx_2 = 2 * Math.Abs(dx);
            int dy_2_kurang_dx_2 = dy_2 - dx_2;

            /**
             * 4. Hitung parameter : po = 2|dy| − |dx|
             * 
             */

            //var p = new List<int>();
            int p = dy_2 - Math.Abs(dx);

            /**
             * 5. Untuk setiap xk sepanjang jalur garis, dimulai dengan k = 0
             * - bila pk  0 maka titik selanjutnya adalah:
             * (xk+1, yk) dan pk+1 = pk + 2|dy|
             *      - bila tidak, titik selanjutnya adalah: 
             *      (xk+1, yk+1) dan pk+1 = pk + 2|dy| – 2|dx|
             */

            int x = x0;
            int y = y0;
            int k = 0;

            float m = ((float)dy) / ((float)dx);

            penampung.Add(new int[] { x, y });

            bool selesai = false;


            /**
             * mencek arah x ke kiri atau ke kanan
             * 
             * arah_x akan menentukan kemana garis akan menuju jika ke kiri maka arah_x bernilai -1
             * 
             */
            int arah_x = 1;
            if (this.x1 < x0)
                arah_x = -1;

            /**
             * mencek arah y ke atas atau ke bawah
             * 
             * arah_y akan menentukan kemana garis akan menuju jika ke atas maka arah_y bernilai -1
             * 
             */
            int arah_y = 1;
            if (this.y1 < y0)
                arah_y = -1;


            while (!selesai && k < 500){

                if (p < 0){
                    x += arah_x;
                    p = p + dy_2;
                } else {
                    x += arah_x;
                    y += arah_y;
                    p = p + dy_2_kurang_dx_2;
                }

                penampung.Add(new int[] { x, y });

                k++;
                if (x == x1 && y == y1)
                    selesai = true;
            }

            return penampung;
        }


        public List<int[]> dyLebihDariDx(List<int[]> penampung, int dx, int dy, int x0, int y0)
        {

            int dy_2 = 2 * Math.Abs(dy);
            int dx_2 = 2 * Math.Abs(dx);
            int dx_2_kurang_dy_2 = dx_2 - dy_2;

            /**
             * 4. Hitung parameter : po = 2|dx| − |dy|
             * 
             */

            //var p = new List<int>();
            int p = dx_2 - Math.Abs(dy);

            /**
             * 5. Untuk setiap xk sepanjang jalur garis, dimulai dengan k = 0
             * - bila pk  0 maka titik selanjutnya adalah:
             * (xk+1, yk) dan pk+1 = pk + 2|dy|
             *      - bila tidak, titik selanjutnya adalah: 
             *      (xk+1, yk+1) dan pk+1 = pk + 2|dy| – 2|dx|
             */

            int x = x0;
            int y = y0;
            int k = 0;

            float m = ((float)dy) / ((float)dx);

            penampung.Add(new int[] { x, y });

            bool selesai = false;


            /**
             * mencek arah x ke kiri atau ke kanan
             * 
             * arah_x akan menentukan kemana garis akan menuju jika ke kiri maka arah_x bernilai -1
             * 
             */
            int arah_x = 1;
            if (this.x1 < x0)
                arah_x = -1;

            /**
             * mencek arah y ke atas atau ke bawah
             * 
             * arah_y akan menentukan kemana garis akan menuju jika ke atas maka arah_y bernilai -1
             * 
             */
            int arah_y = 1;
            if (this.y1 < y0)
                arah_y = -1;

            while (!selesai && k < 500){

                if (p < 0)
                {
                    y += arah_y;
                    p = p + dx_2;
                } else {
                    x += arah_x;
                    y += arah_y;
                    p = p + dx_2_kurang_dy_2;
                }

                penampung.Add(new int[] { x, y });

                k++;
                if (x == x1 && y == y1)
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
