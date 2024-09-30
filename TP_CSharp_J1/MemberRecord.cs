using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CSharp_J1
{
    internal class MemberRecord
    {
        // Attributs
        public int memberId {  get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateOnly dateOfMembership { get; set; }
        public string noBookIssued { get; set; }
        public string maxBookLimit { get; set; }
        public string address {  get; set; }
        public string phoneNo {  get; set; }
        
        
        // Constructeur
        public MemberRecord(int memberId, string name, string type, DateOnly dateOfMembership, string noBookIssued, string maxBookLimit, string address, string phoneNo)
        {
            this.memberId = memberId;
            Name = name;
            Type = type;
            this.dateOfMembership = dateOfMembership;
            this.noBookIssued = noBookIssued;
            this.maxBookLimit = maxBookLimit;
            this.address = address;
            this.phoneNo = phoneNo;
        }



    }





}
