using System.Collections;
using System.Collections.Generic;
using TestApi.Models;

namespace TestApi.ViewModels
{
    public class GigViewModel : IEnumerable
    {
        public List<Gig> Gig { get; set; }
        //        public int Id { get; set; }
        //
        //        public DateTime DateTime { get; set; }
        //
        //        public string Venue { get; set; }

        public List<Genre> Genre { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}