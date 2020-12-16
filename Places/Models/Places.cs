using System.Collections.Generic;

namespace Places.Models
{
    public class Place
    {
        public string Location { get; set; }
        public int Id { get; }
        public string Description { get; set; }
        public string Duration { get; set; }
        private static List<Place> _instances = new List<Place> { };

        public Place(string location, string description, string duration)
        {
            Location = location;
            Description = description;
            Duration = duration;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static Place Find(int searchId)
        {
            return _instances[searchId - 1];
        }

        public static List<Place> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

    }
}