using baseTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baseTest.Data
{
    public class ExampleData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.tickets.Any())
            {
                context.tickets.AddRange(
                    new Ticket
                    {
                        CreateDate = DateTime.Now,
                        Description = "Example desc",
                        NameProject = "Example name",
                        CloseDate = DateTime.Now,
                        TicketStatus = "New",
                        UserId = 1
                    },
                    new Ticket
                    {
                        CreateDate = DateTime.Now,
                        Description = "Example desc",
                        NameProject = "Example name",
                        CloseDate = DateTime.Now,
                        TicketStatus = "New",
                        UserId = 1
                    },
                    new Ticket
                    {
                        CreateDate = DateTime.Now,
                        Description = "Example desc",
                        NameProject = "Example name",
                        CloseDate = DateTime.Now,
                        TicketStatus = "New",
                        UserId = 1
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
