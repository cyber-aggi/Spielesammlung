using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung
{
    class VierGewinntKI
    {
        Random rnd = new Random();

        VierGewinntForm ui;

        public VierGewinntKI(VierGewinntForm ui)
        {
            this.ui = ui;
        }

        public void MacheZug()
        {
            ui.DrawBlock(rnd.Next(1, 8));
        }

        public void GebeZug(int spalte)
        { 
            
        }
    }
}
