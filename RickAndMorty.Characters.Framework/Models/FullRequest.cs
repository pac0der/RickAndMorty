using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Characters.Framework.Models
{
    public class FullRequest
    {
        public Info Info { get; set; }
        public Character[] Results { get; set; }
    }
    public class Info
    {
        public int Count { get; set; }
        public int Pages { get; set; }
        public string Next { get; set; }
        public string Prev { get; set; }
    }
}
