using System;

namespace Municipality.Models
{
    // simple code model for the service request
    public class ServiceRequest
    {
       public string Id { get; set; }
            public string Description { get; set; }
      public string Status { get; set; }
        public int Priority { get; set; }
            public DateTime CreatedAt { get; set; }
        public override string ToString()
        {
          return $"{Id}: {Description} ({Status})";
        }
    }
}


