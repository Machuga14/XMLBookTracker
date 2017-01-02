using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLBookTracker
{
    /// <summary>
    /// The model for hte program, which stores internal data objects, and provides simple utilities.
    /// </summary>
    public class Model
    {
        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Model()
        {
            this.LoadAll();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Stores the list of loaded books.
        /// </summary>
        public List<Book> LoadedBooks { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Loads all of the data for the model.
        /// </summary>
        public void LoadAll()
        {
            this.LoadBooks();
        }

        /// <summary>
        /// Loads all of the books in the model.
        /// </summary>
        public void LoadBooks()
        {
            if (File.Exists(StaticProperties.BOOKS_FILE_NAME))
            {
                using (StreamReader write = new StreamReader(StaticProperties.BOOKS_FILE_NAME))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
                    this.LoadedBooks = serializer.Deserialize(write) as List<Book>;
                }
            }
            else
            {
                this.LoadedBooks = new List<Book>();
            }
        }

        /// <summary>
        /// Saves all of the data in the Model.
        /// </summary>
        public void SaveAll()
        {
            this.SaveBooks();
        }

        /// <summary>
        /// Saves the books to their default directory.
        /// </summary>
        public void SaveBooks()
        {
            using (StreamWriter write = new StreamWriter(StaticProperties.BOOKS_FILE_NAME))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
                serializer.Serialize(write, this.LoadedBooks);
            }
        }

        #endregion
    }
}
