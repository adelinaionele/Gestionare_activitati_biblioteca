using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookWorms.BusinessLogic.DataModel;
using Microsoft.PowerBI.Api;

namespace BookWorms.Models.Admins
{
    public class AdminBookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
