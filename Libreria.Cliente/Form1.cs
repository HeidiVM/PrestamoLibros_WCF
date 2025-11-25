using Libreria.Cliente.BookServiceReference;
using Libreria.Cliente.LoanServiceRef;
using Libreria.Cliente.UserServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria.Cliente
{
    public partial class Form1 : Form
    {
        BookServiceClient bookClient;
        UserServiceClient userClient;
        LoanServiceClient loanClient;

        public Form1()
        {
            InitializeComponent();
            bookClient = new BookServiceClient();
            userClient = new UserServiceClient();
            loanClient = new LoanServiceClient();

            CargarLibros();
            CargarUsuarios();
        }

        // ----------------------------
        // LIBROS
        // ----------------------------
        private void CargarLibros()
        {
            dgvBooks.DataSource = bookClient.GetAllBooks();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookId.Text.Trim(), out int id) ||
                string.IsNullOrWhiteSpace(txtBookTitle.Text) ||
                string.IsNullOrWhiteSpace(txtBookAuthor.Text) ||
                !int.TryParse(txtBookYear.Text.Trim(), out int year))
            {
                MessageBox.Show("Completa todos los campos correctamente.");
                return;
            }

            var book = new Book
            {
                Id = id,
                Title = txtBookTitle.Text.Trim(),
                Author = txtBookAuthor.Text.Trim(),
                Year = year
            };

            bool ok = bookClient.AddBook(book);
            MessageBox.Show(ok ? "Libro agregado." : "Error agregando libro.");
            CargarLibros();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookId.Text.Trim(), out int id) ||
                string.IsNullOrWhiteSpace(txtBookTitle.Text) ||
                string.IsNullOrWhiteSpace(txtBookAuthor.Text) ||
                !int.TryParse(txtBookYear.Text.Trim(), out int year))
            {
                MessageBox.Show("Completa todos los campos correctamente.");
                return;
            }

            var book = new Book
            {
                Id = id,
                Title = txtBookTitle.Text.Trim(),
                Author = txtBookAuthor.Text.Trim(),
                Year = year
            };

            bool ok = bookClient.UpdateBook(book);
            MessageBox.Show(ok ? "Libro actualizado." : "Error actualizando libro.");
            CargarLibros();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookId.Text.Trim(), out int id))
            {
                MessageBox.Show("Ingresa un ID válido.");
                return;
            }

            bool ok = bookClient.DeleteBook(id);
            MessageBox.Show(ok ? "Libro eliminado." : "Error eliminando libro.");
            CargarLibros();
        }

        // ----------------------------
        // USUARIOS
        // ----------------------------
        private void CargarUsuarios()
        {
            dgvUsers.DataSource = userClient.GetAllUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text.Trim(), out int id) ||
                string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Completa todos los campos correctamente.");
                return;
            }

            var user = new User
            {
                Id = id,
                Name = txtUserName.Text.Trim()
            };

            bool ok = userClient.RegisterUser(user);
            MessageBox.Show(ok ? "Usuario agregado." : "Error agregando usuario.");
            CargarUsuarios();
        }


        // ----------------------------
        // PRÉSTAMOS
        // ----------------------------
        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLoanUserId.Text.Trim(), out int userId) ||
                !int.TryParse(txtLoanBookId.Text.Trim(), out int bookId))
            {
                MessageBox.Show("Ingrese IDs válidos.");
                return;
            }

            bool ok = loanClient.BorrowBook(userId, bookId);
            MessageBox.Show(ok ? "Préstamo registrado." : "Error registrando préstamo.");
            CargarPrestamos(userId);
        }

        private void btnReturnLoan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLoanUserId.Text.Trim(), out int userId) ||
                !int.TryParse(txtLoanBookId.Text.Trim(), out int bookId))
            {
                MessageBox.Show("Ingrese IDs válidos.");
                return;
            }

            bool ok = loanClient.ReturnBook(userId, bookId);
            MessageBox.Show(ok ? "Libro devuelto." : "Error devolviendo libro.");
            CargarPrestamos(userId);
        }

        private void CargarPrestamos(int userId)
        {
            dgvLoans.DataSource = loanClient.GetLoansByUser(userId);
        }

        private void lblLoanBookId_Click(object sender, EventArgs e)
        {

        }
    }
}
