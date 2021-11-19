using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baseTest.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public string NameProject { get; set; }
        public DateTime CloseDate { get; set; }
        public string TicketStatus { get; set; }
        public int UserId { get; set; }  //ссылка на модель User
        public User User { get; set; }
    }
}
