using BooksExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Question2
{
    public partial class DisplayTitle : Form
    {
        private BooksEntities db = new BooksEntities();

        public DisplayTitle()
        {
            InitializeComponent();
        }

        private void DisplayTitle_Load(object sender, EventArgs e)
        {
            db.Titles.Load();
            db.Authors.Load();
            DisplaySortedAuthors();
        }

        private void DisplaySortedTitle()
        {
            booksBindingSource.DataSource = from book in db.Titles.Local
                                            orderby book.Title1
                                            select new
                                            {
                                                Title1 = book.Title1,
                                                Authors = String.Join(", ", from author in book.Authors.ToList()
                                                                            select String.Format("{0} {1}", author.FirstName, author.LastName))
                                            };
        }

        private void DisplaySortedAuthors()
        {
            booksBindingSource.DataSource = from book in db.Titles.Local
                                            from author in db.Authors.Local
                                            orderby book.Title1, author.LastName, author.FirstName
                                            select new
                                            {
                                                Title1 = book.Title1,
                                                Authors = String.Format("{0} {1}", author.FirstName, author.LastName)
                                            };
        }
    }
}
