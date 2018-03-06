using System;
using System.Collections.Generic;

using System.Text;

namespace FunyJapanese.Domain
{
   public class Alphabet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfWord { get; set; }
        public string Description { get; set; }
        List<Wordcs> Word { get; set; }
    }
}
