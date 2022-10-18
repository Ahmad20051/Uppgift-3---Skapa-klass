using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Uppgift_3___Skapa_klass
{
    //Här skapas alla funktioner fåglarna ska ha. Namn, längd och vikt
    internal class Fågel
    {
        //Construtor gör så att vi får in nya variablar när vi skapar nya fåglar. Mha constructorn behöver vi inte skriva "set namn", "set längd" osv.
        public Fågel(string nynamn, int nylängd, int nyvikt)
        {
            namn = nynamn;
            längd = nylängd;
            vikt = nyvikt;
        }

        //Den funktioner ger tillbaka fågelns attribut
        string namn;
        int längd;
        int vikt;
        public string getNamn() { return this.namn; }
        public int getLängd() { return this.längd; }
        public int getVikt() { return this.vikt; }

        //Den funktionen finns om man vill ändra attributen, tex ändra längden
        public void setNamn(string namn) { this.namn = namn; }
        public void setLängd(int cm) { this.längd = cm; }
        public void setVikt(int g) { this.vikt = g; }

        //Här ska den valda fågeln sjunga "Craw! Craw!"
        public void sjung()
        {
            Console.WriteLine("Craw! Craw!");
        }

    }
}

