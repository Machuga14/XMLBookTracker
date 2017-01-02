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
    /// 
    /// </summary>
    public partial class ControlViewBooks : UserControl
    {
        #region Private Fields

        /// <summary>
        /// Private storage for the list of books to display.
        /// </summary>
        private List<Book> booksToDisplay;

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ControlViewBooks()
        {
            InitializeComponent();
            this.booksToDisplay = new List<Book>();
            this.controlEditBook1.OnSaveClicked += this.OnControlViewBooksSaveClicked;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the list of books to display.
        /// </summary>
        [Browsable(false)] // Set Browsable to false so the Designer doesn't try to render this object.
        [EditorBrowsable(EditorBrowsableState.Never)] // Set it so the editor can NEVER browse this object.
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] // Do not allow automatic designer serialization of this object.
        public List<Book> BooksToDisplay
        {
            get
            {
                return this.booksToDisplay;
            }

            set
            {
                if (value != this.booksToDisplay)
                {
                    this.booksToDisplay = value;
                    this.RefreshBooksListView();
                }
            }
        }

        #endregion

        #region PublicMethods

        /// <summary>
        /// Call this whenever a new book gets added.
        /// </summary>
        public void NewBookAdded()
        {
            int lastIndex = this.booksToDisplay.Count - 1;
            
            ListViewItem item = new ListViewItem(this.booksToDisplay[lastIndex].Name);
            item.SubItems.Add(this.booksToDisplay[lastIndex].Author);
            item.SubItems.Add("$" + this.booksToDisplay[lastIndex].Price.ToString("N2")); // N2 means its a number with 2 decimal places, so it'll automatically add commas, and pad with ".00". Prepend a $ to the field, so it shows the dollar amount.
            item.SubItems.Add(this.booksToDisplay[lastIndex].Quantity.ToString("N0")); // N0 means its a number with 0 decimal places, so it'll automatically add commas.
            item.Tag = this.booksToDisplay[lastIndex];

            this.lvBooks.Items.Add(item);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Refreshes the ListView of books.
        /// </summary>
        private void RefreshBooksListView()
        {
            this.lvBooks.SuspendLayout();
            this.lvBooks.Items.Clear();

            // If we have null books to display, let's end early.
            if (this.booksToDisplay == null)
            {
                this.lvBooks.ResumeLayout();
                return;
            }

            for (int i = 0; i < this.booksToDisplay.Count; i++)
            {
                ListViewItem item = new ListViewItem(this.booksToDisplay[i].Name);
                item.SubItems.Add(this.booksToDisplay[i].Author);
                item.SubItems.Add("$" + this.booksToDisplay[i].Price.ToString("N2")); // N2 means its a number with 2 decimal places, so it'll automatically add commas, and pad with ".00". Prepend a $ to the field, so it shows the dollar amount.
                item.SubItems.Add(this.booksToDisplay[i].Quantity.ToString("N0")); // N0 means its a number with 0 decimal places, so it'll automatically add commas.
                item.Tag = this.booksToDisplay[i];

                this.lvBooks.Items.Add(item);
            }

            this.lvBooks.ResumeLayout();
        }

        /// <summary>
        /// Refreshes the text of a specific list view item.
        /// </summary>
        /// <param name="index">The index to refresh.</param>
        private void RefreshSpecificListViewItem(int index)
        {
            if (index < 0 || index > this.lvBooks.Items.Count)
            {
                return; // shouldn't happen, but here we go anyways
            }

            ListViewItem item = this.lvBooks.Items[index];
            item.SubItems[0].Text = this.booksToDisplay[index].Name;
            item.SubItems[1].Text = this.booksToDisplay[index].Author;
            item.SubItems[2].Text = "$" + this.booksToDisplay[index].Price.ToString("N2"); // N2 means its a number with 2 decimal places, so it'll automatically add commas, and pad with ".00". Prepend a $ to the field, so it shows the dollar amount.
            item.SubItems[3].Text = this.booksToDisplay[index].Quantity.ToString("N0"); // N0 means its a number with 0 decimal places, so it'll automatically add commas.

            item.Tag = this.booksToDisplay[index];
        }

        #endregion

        #region Private Events

        /// <summary>
        /// Selected Index Changed for the list view.
        /// </summary>
        /// <param name="sender">The Sender for the event.</param>
        /// <param name="e">The EventArgs for the event.</param>
        private void lvBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvBooks.SelectedIndices.Count == 0)
            {
                this.controlEditBook1.UpdateScreenForBook(null);
                this.controlEditBook1.AllowEditing = false; // Don't allow editing, since we have nothing selected.
            }
            else
            {
                this.controlEditBook1.UpdateScreenForBook(this.booksToDisplay[this.lvBooks.SelectedIndices[0]]);
                this.controlEditBook1.AllowEditing = true; // Do allow editing, since we have something selected.
            }
        }

        /// <summary>
        /// Event handler for when the book has been saved.
        /// </summary>
        /// <param name="sender">The Sender for the event.</param>
        /// <param name="e">The EventArgs for the event.</param>
        private void OnControlViewBooksSaveClicked(object sender, EventArgs e)
        {
            if (this.lvBooks.SelectedIndices.Count == 0)
            {
                return; // Weird, this shouldn't happen, probably...
            }
            else
            {
                this.booksToDisplay[this.lvBooks.SelectedIndices[0]] = this.controlEditBook1.BuildBookFromControl();
                this.RefreshSpecificListViewItem(this.lvBooks.SelectedIndices[0]);
            }
        }

        #endregion
    }
}
