using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemRentACar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class masina {
            public string codmasina;
            public string denumire;
            public string descriere;
            public string culoare;
            public string marca;
            public string anulfabricatiei;
            public string taraproducatoare;
            public string tipcombustibil;
            public string greutatemaxima;
            public string nrdelocuri;
            public masina() { }
            
            public void listAllMasinile() { }
            public void searchMasina() { }

        }
        public class client
        {
            public string codclient;
            public string nume;
            public string prenume;
            public string cnp;
            public string adresa;
            public string nrci;
            public string serieci;
            public string foto;
            public bool arecarnetdesofer;
            public client() { }
           
            public void listAllClients() { }
            public void searchClient() { }
        }

        public class angajat
        {
            public string codangajat;
            public string nume;
            public string prenume;
            public string cnp;
            public string adresa;
            public string nrci;
            public string serieci;
            public string foto;
            public bool arecarnetdesofer;
            public angajat() { }

            public void listAllClients() { }
            public void searchClient() { }
        }
        public class inregistrare
        {
            public string codinregistrare;
            public string codmasina;
            public string codclient;
            public string codangajat;

            public DateTime datainregistrarii;
            public DateTime datastart;
            public DateTime datastop;

            public bool inchiriata;
            public bool platit;

            public float avans;
            public bool avansplatit;

            public float pret;
            public float tva;
            public float pretcutva;
            
            public inregistrare() { }
          
            public void listAllInregistrare() { }
            public void searchInregistrare() { }
        }
        
        public class sistemdeinchiriere
        {
            public sistemdeinchiriere() { }

            public List<inregistrare> inregistrari = new List<inregistrare>();

            public void listeazatoateinregistrarile() { }

            public void addInregistrare() { 
                inregistrari.Add(new inregistrare());
            }

            public float calculatepretcutva(int index)
            {
                return this.inregistrari[index].pret * this.inregistrari[index].tva;
            }
        }

        public sistemdeinchiriere RentACar = new sistemdeinchiriere();

        private void Form1_Load(object sender, EventArgs e)
        {
            RentACar.addInregistrare();
            RentACar.inregistrari[0].codinregistrare = "1";
            RentACar.inregistrari[0].codmasina = "SB01AGB";
            RentACar.inregistrari[0].codclient= "1";
            RentACar.inregistrari[0].codangajat = "1";
            RentACar.inregistrari[0].datainregistrarii = DateTime.Now;
            RentACar.inregistrari[0].datastart = DateTime.Now; 
            RentACar.inregistrari[0].datastop = DateTime.Now;
            RentACar.inregistrari[0].inchiriata = false;
            RentACar.inregistrari[0].platit = false;
            RentACar.inregistrari[0].avansplatit = false;
            RentACar.inregistrari[0].pret = 10.0f;
            RentACar.inregistrari[0].tva = 19.0f;
            RentACar.inregistrari[0].pretcutva = RentACar.calculatepretcutva(0);



        }
    }
}
