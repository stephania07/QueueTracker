using System.Data.Entity;

namespace QueueTracker.Models
{
    public class Queue
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class QueueDBContext : DbContext
    { 
      public DbSet<Queue> Queue {get; set;}
    }

}