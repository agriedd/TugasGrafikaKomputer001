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
    class BruteForce{

        private int x0, y0, x1, y1;
        public List<int[]> nilai;

        public BruteForce(int x0, int y0, int x1, int y1){
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

            if(penampung.Count > 0)
                foreach(int[] i in penampung){
                    canvas.DrawRectangle(new Pen(Color.Black, 0), i[0], i[1], 1, 1);
                }
        }

        /**
         * keluaran list<int[]> [i][0:1] - 0:x - 1:y
         * 
         */
        public List<int[]> algoritma(){
            var penampung = new List<int[]>();

            /**
             * step 1 tentukan x0,y0 dan x1,y1 ✔️
             * 
             */

            /**
             * step 2 jika x1 == x2 maka garis vertikal
             *
             */
            if (this.isDirectionVertical())
                return this.algoritmaVertikal(penampung);

            /**
             * step 3 jika y1 == y2 maka garis horizontal
             *
             */
            if (this.isDirectionHorizontal())
                return this.algoritmaHorizontal(penampung);

            /**
             * step 4 Hitung kemiringan garis m
             * m = (y2-y1)/(x2-x1)
             *
             */
            float x1 = this.x1;
            float y1 = this.y1;
            float x0 = this.x0;
            float y0 = this.y0;
            float temp;

            /**
             * tukar nilai jika x0 lebih besar dari x1
             * 
             */
            if (this.x1 < this.x0){
                temp = x1;
                x1 = x0;
                x0 = temp;

                temp = y1;
                y1 = y0;
                y0 = temp;
            }

            float m = (float) (y1 - y0) / (x1 - x0);

            /**
             * step 5 mencari jumlah N
             * 
             */
            var N = x1 - x0 + 1;
            /**
             * inisialisasi x awal
             * 
             */
            float x = x0;

            float y;
            int y_rounded;
            for(int i = 0; i<N; i++){
                y = (float) m * (x - x0) + y0;
                y_rounded = (int) Math.Round(y);

                //draw()

                penampung.Add(new int[] { (int) x, y_rounded });
                x = x + 1;
            }

            return penampung;
        }

        private List<int[]> algoritmaVertikal(List<int[]> penampung){

            int x = this.x0;
            int y = this.y0;
            int dy = 1;

            penampung.Add(new int[] { x, y });

            /**
             * mengubah direksi sesuai dengan tujuan y1
             * 
             */
            if (y > this.y1) dy = -1;

            while(y != this.y1){
                y += dy;
                penampung.Add(new int[2] { x, y });
            }

            return penampung;
        }
        private List<int[]> algoritmaHorizontal(List<int[]> penampung){

            int x = this.x0;
            int y = this.y0;
            int dx = 1;

            penampung.Add(new int[] { x, y });

            /**
             * mengubah direksi sesuai dengan tujuan y1
             * 
             */
            if (x > this.x1) dx = -1;

            while (x != this.x1){
                x += dx;
                penampung.Add(new int[2] { x, y });
            }

            return penampung;
        }

        /**
         * memeriksa arah garis adalah vertikal
         * 
         */
        private bool isDirectionVertical(){
            return x0 == x1;
        }
        /**
         * memeriksa arah garis adalah horizontal
         * 
         */
        private bool isDirectionHorizontal(){
            return y0 == y1;
        }

        public ArrayList getListViewItems(){
            var penampung = new ArrayList();
            foreach (int[] i in this.nilai)
                penampung.Add(String.Join(", ", i));
            return penampung;
        }
    }
}
