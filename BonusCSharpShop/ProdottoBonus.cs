﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BONUS

namespace BonusCSharpShop
{
    public class ProdottoBonus
    { 
        //proprietà
        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private int iva;

        //costruttori
        public ProdottoBonus(int codice, string nome, string descrizione, double prezzo, int iva)
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
            if (prezzo > 0)
            {
                this.prezzo = prezzo;
            }
            else
            {
                Console.WriteLine("il prezzo deve essere maggiore di 0");
            }
        }

        public void SetIva(int iva)
        {
            if (iva >= 0)
            {
                this.iva = iva;
            }
            else
            {
                Console.WriteLine("l'iva non può essere negativa");
            }
        }

        //metodi
        public void StampaPrezzo()
        {
            //prezzo con 2 decimali
            Console.WriteLine("Prezzo (senza iva): " + prezzo.ToString("F") + " euro");
            double prezzoTotale = prezzo / 100 * iva + prezzo;
            Console.WriteLine("Prezzo (con iva): " + prezzoTotale.ToString("F") + " euro");
        }

        public void StampaNome()
        {
            Console.WriteLine("Nome completo del prodotto: " + codice + nome);
        }

        public void StampaProdotto()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("descrizione: " + descrizione);
            Console.WriteLine("prezzo (senza iva): " + prezzo.ToString("F") + " euro");
            Console.WriteLine("iva: " + iva + "%");
            double prezzoTotale = prezzo / 100 * iva + prezzo;
            Console.WriteLine("Prezzo (con iva): " + prezzoTotale.ToString("F") + " euro");
            Console.WriteLine("------------------");
        }
        
        //BONUS
        public void CodicePadLeft()
        {
            string codicePadLeft = Convert.ToString(codice).PadLeft(8, '0');
            Console.WriteLine("il codice con 8 caratteri: " + codicePadLeft);
        }
    }
}