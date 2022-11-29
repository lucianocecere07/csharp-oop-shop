using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop
{
    public class Prodotto
    {
        //proprietà
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private int iva;

        //costruttori
        public Prodotto(int codice, string nome, string descrizione, double prezzo, int iva)
        {
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        //getter
        public int GetCodice()
        {
            return this.codice;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public double GetPrezzo()
        {
            return this.prezzo;
        }

        public int GetIva()
        {
            return this.iva;
        }
        //setter
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetDescrizione(string descrizione)
        {
            this.descrizione = descrizione;
        }

        public void SetPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }

        public void SetIva(int iva)
        {
            this.iva = iva;
        }

        //metodi
        public void StampaPrezzo()
        {
            Console.WriteLine("Prezzo (senza iva): " + prezzo);
            double prezzoTotale = prezzo / 100 * iva + prezzo;
            Console.WriteLine("Prezzo (con iva): " + prezzoTotale);
        }

        public void StampaNome()
        {
            Console.WriteLine("Nome completo del prodotto: " + codice + nome);
        }
    }
}
