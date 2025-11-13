using System; 
using Municipality.Models;
using System.Collections.Generic;

namespace Municipality.Data
{

    // code for in memory repository with data 
    public static class ServiceRequestRepository
    {
        private static Dictionary<string, ServiceRequest> requests = new Dictionary<string, ServiceRequest>();
     static ServiceRequestRepository()
        {
            // this is seeded sample data/information 
        Add(new ServiceRequest { Id = "RSA101", Description = "There is a pothole on the main road", Status = "Open", Priority = 2, CreatedAt = DateTime.Now.AddDays(-3) });
           Add(new ServiceRequest { Id = "RSA102", Description = "Street Robot is out", Status = "In Progress", Priority = 1, CreatedAt = DateTime.Now.AddDays(-1) });
       Add(new ServiceRequest { Id = "RSA103", Description = "Water pipe burts", Status = "Open", Priority = 3, CreatedAt = DateTime.Now.AddDays(-5) });
          Add(new ServiceRequest { Id = "RSA104", Description = "vandalism on the walls", Status = "Closed", Priority = 5, CreatedAt = DateTime.Now.AddDays(-10) });
            Add(new ServiceRequest { Id = "RSA105", Description = "Tree truck has fallen", Status = "In Progress", Priority = 1, CreatedAt = DateTime.Now.AddDays(-2) });
      }

          public static void Add(ServiceRequest req)
     {
        requests[req.Id] = req;
      }

          public static IEnumerable<ServiceRequest> GetAll()
       {
                return requests.Values;
        }
        public static ServiceRequest GetById(string id)
        {
           requests.TryGetValue(id, out var r);
            return r;
        }
  }
}
    
