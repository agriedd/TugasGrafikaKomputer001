using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TugasGrafikaKomputer001
{
    /**
     * membuat interface algoritma garis sehingga tiap class algoritma memiliki
     * kontrak method yang sama.
     * 
     */
    interface AlgoritmaGaris{

        void draw(Panel parent);

        List<int[]> algoritma();

        ArrayList getListViewItems();

    }
}
