using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDHOMEWORD2
{
    public class TDDHW2
    {
        public int Accounting(List<Book> booklist,int price)
        {
            int sum = 0;

            sum = booklist.Sum(x=>x.Quantity);

            return sum*price;
        }
    }


    public class Book
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

    }
}
