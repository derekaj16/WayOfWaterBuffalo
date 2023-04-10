using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WayOfWaterBuffalo.Models.ViewModels
{
    public class PageInfo
    {
        public int totalNumBooks { get; set; }
        public int booksPerPage { get; set; }
        public int currentPage { get; set; }
        public int numPages => (int)Math.Ceiling((double)totalNumBooks / booksPerPage);
    }
}
