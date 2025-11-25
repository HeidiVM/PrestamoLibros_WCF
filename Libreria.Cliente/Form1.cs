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
        // Clientes WCF
        BookServiceClient bookClient;
        UserServiceClient userClient;
        LoanServiceClient loanClient;

        public Form1()
        {
            InitializeComponent();

            // Inicializar clientes
            bookClient = new BookServiceClient();
            userClient = new UserServiceClient();
            loanClient = new LoanServiceClient();

            // Cargar datos iniciales
            CargarLibros();
            CargarUsuarios();
        }

        // ------------------------------
        // CARGAR LIBROS
        // ------------------------------
        private void CargarLibros()
        {
            try
            {
                dgvBooks.DataSource = bookClient.GetAllBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando libros: " + ex.Message);
            }
        }

        // ------------------------------
        // CARGAR USUARIOS
        // ------------------------------
        private void CargarUsuarios()
        {
            try
            {
                dgvUsers.DataSource = userClient.GetAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando usuarios: " + ex.Message);
            }
        }

        // ------------------------------
        // CARGAR PRÉSTAMOS DE UN USUARIO
        // ------------------------------
        private void CargarPrestamos(int userId)
        {
            try
            {
                var prestamos = loanClient.GetLoansByUser(userId);
                dgvLoans.DataSource = prestamos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando préstamos: " + ex.Message);
            }
        }

        // ------------------------------
        // AGREGAR LIBRO
        // ------------------------------
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookTitle.Text))
            {
                MessageBox.Show("Ingrese un título de libro.");
                return;
            }

            var book = new Book
            {
                Id = 0, // WCF puede asignar Id automáticamente
                Title = txtBookTitle.Text.Trim()
            };

            try
            {
                bool ok = bookClient.AddBook(book);
                if (ok)
                {
                    MessageBox.Show("Libro agregado correctamente.");
                    CargarLibros();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar libro: " + ex.Message);
            }
        }

        // ------------------------------
        // AGREGAR USUARIO
        // ------------------------------
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Ingrese un nombre de usuario.");
                return;
            }

            var user = new User
            {
                Id = 0,
                Name = txtUserName.Text.Trim()
            };

            try
            {
                bool ok = userClient.RegisterUser(user);
                if (ok)
                {
                    MessageBox.Show("Usuario agregado correctamente.");
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
            }
        }

        // ------------------------------
        // REGISTRAR PRÉSTAMO
        // ------------------------------
        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLoanUserId.Text.Trim(), out int userId))
            {
                MessageBox.Show("Id de usuario inválido.");
                return;
            }

            if (!int.TryParse(txtLoanBookId.Text.Trim(), out int bookId))
            {
                MessageBox.Show("Id de libro inválido.");
                return;
            }

            try
            {
                bool ok = loanClient.BorrowBook(userId, bookId);
                if (ok)
                {
                    MessageBox.Show("Préstamo registrado correctamente.");
                    CargarPrestamos(userId);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el préstamo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar préstamo: " + ex.Message);
            }
        }

        // ------------------------------
        // DEVOLVER LIBRO
        // ------------------------------
        private void btnReturnLoan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLoanUserId.Text.Trim(), out int userId))
            {
                MessageBox.Show("Id de usuario inválido.");
                return;
            }

            if (!int.TryParse(txtLoanBookId.Text.Trim(), out int bookId))
            {
                MessageBox.Show("Id de libro inválido.");
                return;
            }

            try
            {
                bool ok = loanClient.ReturnBook(userId, bookId);
                if (ok)
                {
                    MessageBox.Show("Libro devuelto correctamente.");
                    CargarPrestamos(userId);
                }
                else
                {
                    MessageBox.Show("No se pudo devolver el libro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al devolver libro: " + ex.Message);
            }
        }
    }
}
