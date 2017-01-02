using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLBookTracker
{
    /// <summary>
    /// This control is designed for editing / making new books. It DOES NOT edit the book you provide it, it creates a NEW book which you must retrieve and handle yourself.
    /// </summary>
    public partial class ControlEditBook : UserControl
    {
        #region Private Fields

        /// <summary>
        /// Whether or not to allow editing.
        /// </summary>
        private bool allowEditing = true;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public ControlEditBook()
        {
            InitializeComponent();
        }

        #endregion

        #region Public Delegates / Events

        /// <summary>
        /// Delegate for handling the save click.
        /// </summary>
        /// <param name="sender">The Sender for the event.</param>
        /// <param name="e">The EventArgs for the event.</param>
        public delegate void SaveClicked(object sender, EventArgs e);

        /// <summary>
        /// Handler for save being clicked.
        /// </summary>
        public SaveClicked OnSaveClicked;

        #endregion

        #region Public Properties

        /// <summary>
        /// Sets the text of the save button.
        /// </summary>
        public string SaveButtonText
        {
            get
            {
                return this.btnFinish.Text;
            }

            set
            {
                if (this.btnFinish.Text != value)
                {
                    this.btnFinish.Text = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets whether editing is allowed.
        /// </summary>
        public bool AllowEditing
        {
            get
            {
                return this.allowEditing;
            }

            set
            {
                if (this.allowEditing != value)
                {
                    this.allowEditing = value;
                    this.UpdateForAllowEditing();
                }

            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates a book from the controls.
        /// </summary>
        /// <returns>The book represented ont he controls.</returns>
        public Book BuildBookFromControl()
        {
            Book retBook = new Book();

            retBook.Name = this.tbxBookName.Text;
            retBook.Author = this.tbxAuthor.Text;

            decimal parseDec = 0.00m;
            decimal.TryParse(this.tbxPrice.Text, out parseDec);
            retBook.Price = parseDec;

            int parseInt = 0;
            int.TryParse(this.tbxQuantity.Text, out parseInt);
            retBook.Quantity = parseInt;

            return retBook;
        }

        /// <summary>
        /// Updates the controls on this screen to match the book provided.
        /// </summary>
        /// <param name="bookToUpdateFor">The book to update the screen for.</param>
        public void UpdateScreenForBook(Book bookToUpdateFor)
        {
            if (bookToUpdateFor != null)
            {
                this.tbxAuthor.Text = bookToUpdateFor.Author;
                this.tbxBookName.Text = bookToUpdateFor.Name;

                if (this.allowEditing)
                {
                    this.tbxQuantity.Text = bookToUpdateFor.Quantity.ToString();
                    this.tbxPrice.Text = bookToUpdateFor.Price.ToString();
                }
                else
                {
                    this.tbxQuantity.Text = bookToUpdateFor.Quantity.ToString("N0");
                    this.tbxPrice.Text = "$" + bookToUpdateFor.Price.ToString("N2");
                }
            }
            else
            {
                this.tbxAuthor.Text = string.Empty;
                this.tbxBookName.Text = string.Empty;
                this.tbxPrice.Text = string.Empty;
                this.tbxQuantity.Text = string.Empty;
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Updates properties on the control to allow editing
        /// </summary>
        private void UpdateForAllowEditing()
        {
            if (this.allowEditing)
            {
                this.tbxAuthor.ReadOnly = true;
                this.tbxBookName.ReadOnly = true;
                this.tbxPrice.ReadOnly = true;
                this.tbxQuantity.ReadOnly = true;

                this.btnFinish.Hide();
            }
            else
            {
                this.tbxAuthor.ReadOnly = false;
                this.tbxBookName.ReadOnly = false;
                this.tbxPrice.ReadOnly = false;
                this.tbxQuantity.ReadOnly = false;

                this.btnFinish.Show();
            }
        }

        #endregion

        #region Private Events

        /// <summary>
        /// Button Finish Click.
        /// </summary>
        /// <param name="sender">The Sender for the event.</param>
        /// <param name="e">The EventArgs for the event.</param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (this.allowEditing && this.OnSaveClicked != null)
            {
                this.OnSaveClicked(this, EventArgs.Empty);
            }
        }

        #endregion
    }
}