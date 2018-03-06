using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace FunyJapanese.Domain
{
    public class Wordcs
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string MeaningOfWord { get; set; }
        public string Pronounce { get; set; }
        public string ImageUrl { get; set; }
        public byte[] ImageBase { get; set; }
    }
}