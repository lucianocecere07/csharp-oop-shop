// See https://aka.ms/new-console-template for more information

/*
BONUS:
create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri 
(ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
Usando una List, dichiarate una lista dei prodotti di un negozio e inseriteci al suo interno qualche prodotto 
che vi aspettate di trovare nel negozio. Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.
*/

//BONUS

using BonusCSharpShop;

//METODO PRIVATO (PER LA CLASSE PRODOTTO)
//generare un numero random da 1 a 100
Random generatoreNumeriRandom = new Random();
int numeroRandom = generatoreNumeriRandom.Next(1, 100);

ProdottoBonus prodotto1 = new ProdottoBonus(numeroRandom, "shampoo", "per capelli normali", 1.60, 22);
/*
//stampa prezzo senza/con iva
prodotto1.StampaPrezzo();

//stampa nome completo del prodotto
prodotto1.StampaNome();

//stampa il prodotto
prodotto1.StampaProdotto();

// codice con un pad left di 0 per arrivare a 8 caratteri
prodotto1.CodicePadLeft();
*/
//LISTA
//nuovi oggetti
ProdottoBonus prodotto2 = new ProdottoBonus(numeroRandom, "sapone", "al profumo di arancia", 1.00, 22);
ProdottoBonus prodotto3 = new ProdottoBonus(numeroRandom, "crema mani", "per mani secche", 3.27, 22);
ProdottoBonus prodotto4 = new ProdottoBonus(numeroRandom, "burrocacao", "con burro di karitè", 2.50, 22);

//creazione lista
List<ProdottoBonus> listaProdotti = new List<ProdottoBonus>();
listaProdotti.Add(prodotto1);
listaProdotti.Add(prodotto2);
listaProdotti.Add(prodotto3);
listaProdotti.Add(prodotto4);

//spazio
Console.WriteLine();

Console.WriteLine("Stampa elementi della lista");

//stampa elementi della lista
for (int i = 0; i < listaProdotti.Count; i++)
{
    listaProdotti[i].StampaProdotto();
}






//---------------------------------------esercizio--------------------------------------------------------//

/*
Nel progetto CSharpShop , creare la classe Prodotto che gestisce i prodotti del vostro shop.
Un prodotto è caratterizzato da: codice (numero intero), nome, descrizione, prezzo, iva.
Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed 
eventuali altri metodi di “utilità” per fare in modo che:
- alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
- Il codice prodotto sia accessibile solo in lettura
- Gli altri attributi siano accessibili sia in lettura che in scrittura
Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva.
Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci con loro per testare tutti i metodi 
che avete previsto e implementato.


using CSharpShop;

//generare un numero random da 1 a 100
Random generatoreNumeriRandom = new Random();
int numeroRandom = generatoreNumeriRandom.Next(1, 100);

//creazione nuovo prodotto
Prodotto prodottoNegozio = new Prodotto(numeroRandom, "shampoo", "per capelli normali", 1.60, 22);

//stampa prezzo senza/con iva
prodottoNegozio.StampaPrezzo();

//stampa nome completo del prodotto
prodottoNegozio.StampaNome();
*/

//----------------------------------------------------------------------------------------------------------//
