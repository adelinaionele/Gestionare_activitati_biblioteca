using System;
using System.Collections.Generic;
using System.Text;

namespace BookWorms.BusinessLogic.DataModel
{
    public class Book
    {
        public Guid Id { get; set; }
        public string BookTitle { get; set; }
        public string BookDescription { get; set; }
        public Admin Admin { get; set; }
    }
}
