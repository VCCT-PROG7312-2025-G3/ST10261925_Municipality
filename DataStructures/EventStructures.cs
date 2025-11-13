using System;
using System.Collections.Generic;
using System.ComponentModel;
using Municipality.Models;

namespace Municipality.DataStructures
{ 
    // this code is the simple event side data structure
    
    public static class EventStructures
    {
        // this is the primary storage by ID
      public static Dictionary<string, EventItem> Events = new Dictionary<string, EventItem>();       
        //sort by date
     public static SortedDictionary<DateTime, List<EventItem>> EventsByDate = new SortedDictionary<DateTime, List<EventItem>>();
        //unique categories
                public static HashSet<string> Categories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
     // code for the last viewed history 
        public static Stack<String> LastViewed = new Stack<string>();
        // code for the new submsissions queue
         public static Queue<EventItem> SubmissionQueue = new Queue<EventItem>();
      // code for simple priority queue
      private static List<EventItem> priorityList = new List<EventItem>();

        public static void EnqueueByPriority(EventItem item)
        {
          priorityList.Add(item);
                priorityList.Sort((a, b) => a.Priority.CompareTo(b.Priority));
        }
      
    public static EventItem DequeueByPriority()
        {
            if (priorityList.Count == 0) return null;
          var it = priorityList[0];
                priorityList.RemoveAt(0);
            return it;
        }
       
        // code for the search count 
             private static Dictionary<string, int> searchCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
       
        public static void IncrementSearchCount(string category)
        {
         if (string.IsNullOrWhiteSpace(category)) return;
            if (!searchCounts.ContainsKey(category)) searchCounts[category] = 0;
        searchCounts[category]++;
        }
       
            public static IEnumerable<string> GetTopCategories(int n = 3)
        {
        foreach (var kv in searchCounts)
            {
             Categories.Add(kv.Key);
            }
            foreach (var kv in System.Linq.Enumerable.OrderByDescending(searchCounts, kv => kv.Value))
          {
              yield return kv.Key;
            }
        }   
       
        public static void Add(EventItem item)
        {
          Events[item.Id] = item;
            if (!EventsByDate.TryGetValue(item.Date.Date, out var list)) { list = new List<EventItem>(); EventsByDate[item.Date.Date] = list; }
        list.Add(item);
                Categories.Add(item.Category);
           EnqueueByPriority(item);
        }
        // code to seed sample events 
      static EventStructures()
        {
                Add(new EventItem { Id = "SA1001", Title = "Clean up day", Category = "Community", Date = DateTime.Now.Date.AddDays(3), Description = "cleaning the streets", Priority = 2 });
           Add(new EventItem { Id = "SA1002", Title = "Festival", Category = "Entertainment", Date = DateTime.Now.Date.AddDays(10), Description = "Yearly festival", Priority = 3 });
                Add(new EventItem { Id = "SA1003", Title = "Street maintenance", Category = "Infrastructure", Date = DateTime.Now.Date.AddDays(1), Description = "Roadworks in the CBD", Priority = 1 });
          Add(new EventItem { Id = "SA1004", Title = "Extra classes", Category = "Education", Date = DateTime.Now.Date.AddDays(7), Description = "Weekend extra classes", Priority = 4 });
                Add(new EventItem { Id = "SA1005", Title = "Marathon", Category = "Community", Date = DateTime.Now.Date.AddDays(14), Description = "10km marathon around the mountain ", Priority = 2 });
        }
    }
    public class EventItem
    {
      public string Id { get; set; }
     public string Title { get; set; }
     public string Category { get; set; }
      public DateTime Date { get; set; }
     public string Description { get; set; }
      public int Priority { get; set; }
    }
}
