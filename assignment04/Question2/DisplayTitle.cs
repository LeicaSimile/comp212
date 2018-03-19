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


// Angelica Catalan, 300846458
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
            DisplaySortedTitle();
        }

        private void DisplaySortedTitle()
        {
            var titlesAndAuthors = from book in db.Titles
                                   from author in db.Authors
                                   orderby book.Title1
                                   select new
                                   {
                                       book.Title1,
                                       author.FirstName,
                                       author.LastName
                                   };

            txtOutput.Text = "";
            txtOutput.AppendText("Titles and authors (sorted by title):");
            foreach (var ele in titlesAndAuthors)
            {
                txtOutput.AppendText(String.Format("\r\n\t{0, -70}\t{1} {2}", ele.Title1, ele.FirstName, ele.LastName));
            }
        }

        private void DisplaySortedAuthors()
        {
            var titlesAndAuthors = from book in db.Titles
                                   from author in db.Authors
                                   orderby book.Title1, author.LastName, author.FirstName
                                   select new
                                   {
                                       book.Title1,
                                       author.FirstName,
                                       author.LastName
                                   };

            txtOutput.Text = "";
            txtOutput.AppendText("Titles and authors (sorted by title, author last name, author first name):");
            foreach (var ele in titlesAndAuthors)
            {
                txtOutput.AppendText(String.Format("\r\n\t{0, -70}\t{1} {2}", ele.Title1, ele.FirstName, ele.LastName));
            }
        }

        private void DisplayGroupedByTitle()
        {
            var authorsByTitle = from title in db.Titles
                                 orderby title.Title1
                                 select new
                                 {
                                     Title = title.Title1,
                                     Authors = from author in title.Authors
                                               orderby author.LastName, author.FirstName
                                               select new
                                               {
                                                   Firstname = author.FirstName,
                                                   Lastname = author.LastName
                                               }
                                 };

            txtOutput.Text = "";
            txtOutput.AppendText("Authors grouped by title:");
            foreach (var title in authorsByTitle)
            {
                txtOutput.AppendText(String.Format("\r\n\t\"{0}\":", title.Title));
                foreach (var author in title.Authors)
                {
                    txtOutput.AppendText(String.Format("\r\n\t\t{0} {1}", author.Firstname, author.Lastname));
                }
            }
        }

        private void btnTitleSort_Click(object sender, EventArgs e)
        {
            DisplaySortedTitle();
        }

        private void btnAuthorSort_Click(object sender, EventArgs e)
        {
            DisplaySortedAuthors();
        }

        private void btnGroupAuthors_Click(object sender, EventArgs e)
        {
            DisplayGroupedByTitle();
        }
    }
}
