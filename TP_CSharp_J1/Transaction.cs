using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    internal class Transaction
    {
        //Attributs
        public int transId {  get; set; }
        public int memberId {  get; set; }
        public string bookId {  get; set; }
        public DateTime dateOfIssue { get; set; }
        public DateTime dueDate { get; set; }

        // Constructeur
        public Transaction(int transId, int memberId, string bookId, DateTime dateOfIssue, DateTime dueDate)
        {
            this.transId = transId;
            this.memberId = memberId;
            this.bookId = bookId;
            this.dateOfIssue = dateOfIssue;
            this.dueDate = dueDate;
        }

        // Fonctions

    }


}
