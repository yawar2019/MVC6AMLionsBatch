using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdoNetExample.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public DateTime PublishDate { get; set; }
        public string ImageName { get; set; }

        public string CategoryBookName { get; set; }
    }
}