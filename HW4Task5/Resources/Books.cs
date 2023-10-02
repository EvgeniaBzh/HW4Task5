using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4Task5.Resources
{
    internal class Books: Goods
    {
        public int NumberOfPages { get; set; }
        public string PublishingHouse { get; set; }
        public List<string> ListOfAuthors { get; set; }
    }
}
