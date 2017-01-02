using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLBookTracker
{
    /// <summary>
    /// Form for testing the controls I made.
    /// </summary>
    public partial class TestForm : Form
    {

        #region Constructors

        /// <summary>
        /// The Default Constructor
        /// </summary>
        public TestForm()
        {
            InitializeComponent();

            this.ProgramModel = new Model();
            this.controlEditBook1.OnSaveClicked += this.OnNewBookMade;

            this.controlViewBooks1.BooksToDisplay = this.ProgramModel.LoadedBooks; // Tell the control for viewing books that we want to view the books the model has loaded.
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// The Program's Model
        /// </summary>
        public Model ProgramModel { get; set; }

        #endregion

        #region Private Events

        /// <summary>
        /// Form Closing Event. Saves all the data in the model.
        /// </summary>
        /// <param name="sender">The Sender for the event.</param>
        /// <param name="e">The FormClosingEventArgs for the event.</param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ProgramModel.SaveAll();
        }

        /// <summary>
        /// Event Handler for a new book being made.
        /// </summary>
        /// <param name="sender">The Sender for the event.</param>
        /// <param name="e">The EventArgs for the event.</param>
        private void OnNewBookMade(object sender, EventArgs e)
        {
            this.ProgramModel.LoadedBooks.Add(this.controlEditBook1.BuildBookFromControl());
            this.controlViewBooks1.NewBookAdded(); // Tell the control for viewing books that there's a new book to be rendered.
        }

        #endregion
    }
}
