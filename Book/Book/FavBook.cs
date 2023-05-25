using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class FavBook
    {
        public string BookName { get; set; }
        public string Authere { get; set; }
     
        public string bookInfo;


        public string this[int index, string bookName, string authere] {

            set{
                this.BookName = value;
                this.Authere = value;
            }
            get{

                this.BookName = bookName;
                this.Authere = authere;

               

                bookInfo = $"book name: {BookName}, authore: {Authere}";
                return bookInfo;
            }
        }       
    }
}
