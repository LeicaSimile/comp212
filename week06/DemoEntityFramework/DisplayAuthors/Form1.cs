using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BooksExample;
using System.Data.Entity;

namespace DisplayAuthors
{
    public partial class Form1 : Form
    {
        private BooksEntities db = new BooksEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //(from author in db.Authors
            // orderby author.LastName, author.FirstName
            // select author).Load();

            db.Authors.OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName).Load();
                

            authorBindingSource.DataSource = db.Authors.Local;
        }
    }
}
