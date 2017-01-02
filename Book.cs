using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLBookTracker
{
    /// <summary>
    /// Book class to store bookish information about books and things.
    /// </summary>
    public class Book
    {
        #region Constructor

        /// <summary>
        /// Default Constructor for a book. Initializes the data to default values of string.empty and 0.
        /// </summary>
        public Book()
        {
            this.Name = string.Empty;
            this.Author = string.Empty;
            this.Price = 0.00m;
            this.Quantity = 0;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// The name of the book
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The author of the book
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// The price of the book
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The number of books owned.
        /// </summary>
        public int Quantity { get; set; }

        #endregion
    }
}
