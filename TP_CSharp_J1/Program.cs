// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using TP_CSharp_J1;

Console.WriteLine("Hello, World!");




internal class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book
        {
            bookId = 1, 
            author = "Giuliano da Empoli",
            name = "Le mage du Kremlin",
            price = 8.99,
            rackNo = "A1", 
            status = "Available", 
            edition = "First", 
            dateOfPurcharse = new DateTime(2022, 6, 26)
                };

        Console.WriteLine("Détails duLivre: ");
        book1.DisplayBookDetails(); 
        Console.WriteLine($"Status du Livre : {book1.status}");

        MemberRecord student = new Student
        {
            memberId = 101,
            type = "Student",
            name = "John Doe",
            address = "123, Rue des écoles",
            phoneNo = "0123456789",
            dateOfMembership = DateTime.Now,
            maxBookLimit = 5,
            noBookIssued = 0
        };
        Librarian librarian = new Librarian
        {
            name = "Marie Paule",
            password = "password123"
        };






    }

}