using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Books
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private List<Book> bookInventory = new List<Book>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindBookGrid();
            }
        }
 
       protected void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            Book newBook = new Book
            {
                Title = title,
                Author = author,
            };
            bookInventory.Add(newBook);
            BindBookGrid();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.ToLower();
            List<Book> searchResults = bookInventory.FindAll(book => book.Title.ToLower().Contains(searchQuery) || book.Author.ToLower().Contains(searchQuery));

            BindBookGrid(searchResults);
        }
        private void BindBookGrid(List<Book> books = null)
        {
            gridBooks.DataSource = books ?? bookInventory;
            gridBooks.DataBind();
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

}