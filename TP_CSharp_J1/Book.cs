using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TP_CSharp_J1
{
    internal class Book
    {
        // Attributs
        public int bookId { get ; set; }
        public string author { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int rackNo { get; set; }
        public string status { get; set; } // Exemple : "Disponible", "Emprunté", "Réservé"
        public string edition { get; set; }
        public DateTime dateOfPurcharse { get; set; }


        // Constructeur
        public Book(int bookId, string author, string name, double price, int rackNo, string status, string edition, DateTime dateOfPurcharse)
        {
            this.bookId = bookId;
            this.author = author;
            this.name = name;
            this.price = price;
            this.rackNo = rackNo;
            this.status = status;
            this.edition = edition;
            this.dateOfPurcharse = dateOfPurcharse;
        }

        // Fonctions 
        // Méthode pour afficher les détails du livre
        public void DisplayBookDetails()
        {
            Console.WriteLine($"ID du livre : {bookId}");
            Console.WriteLine($"Auteur : {author}");
            Console.WriteLine($"Nom du livre : {name}");
            Console.WriteLine($"Prix : {price}€");
            Console.WriteLine($"Numéro de rack : {rackNo}");
            Console.WriteLine($"Statut : {status}");
            Console.WriteLine($"Édition : {edition}");
            Console.WriteLine($"Date d'achat : {dateOfPurcharse.ToShortDateString()}");
        }
        // Méthode pour mettre à jour le statut du livre
        public void UpdateStatus(string newStatus)
        {
            status = newStatus;
            Console.WriteLine("Le statut du livre" +name + "a été mis à jour en : " + status);
        }
    }
}
