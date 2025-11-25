namespace Libreria.Cliente
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el diseñador

        private void InitializeComponent()
        {
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookYear = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtLoanUserId = new System.Windows.Forms.TextBox();
            this.txtLoanBookId = new System.Windows.Forms.TextBox();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.btnReturnLoan = new System.Windows.Forms.Button();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblLoans = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookYear = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblLoanUserId = new System.Windows.Forms.Label();
            this.lblLoanBookId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.Location = new System.Drawing.Point(12, 32);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(450, 150);
            this.dgvBooks.TabIndex = 0;
            // 
            // dgvUsers
            // 
            this.dgvUsers.Location = new System.Drawing.Point(12, 300);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(450, 120);
            this.dgvUsers.TabIndex = 1;
            // 
            // dgvLoans
            // 
            this.dgvLoans.Location = new System.Drawing.Point(480, 32);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.Size = new System.Drawing.Size(400, 366);
            this.dgvLoans.TabIndex = 2;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(12, 205);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(80, 20);
            this.txtBookId.TabIndex = 3;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(100, 205);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(150, 20);
            this.txtBookTitle.TabIndex = 4;
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(260, 205);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtBookAuthor.TabIndex = 5;
            // 
            // txtBookYear
            // 
            this.txtBookYear.Location = new System.Drawing.Point(370, 205);
            this.txtBookYear.Name = "txtBookYear";
            this.txtBookYear.Size = new System.Drawing.Size(80, 20);
            this.txtBookYear.TabIndex = 6;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(12, 230);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 23);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "Agregar";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(120, 230);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateBook.TabIndex = 8;
            this.btnUpdateBook.Text = "Actualizar";
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(230, 230);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteBook.TabIndex = 9;
            this.btnDeleteBook.Text = "Eliminar";
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(12, 440);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(80, 20);
            this.txtUserId.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(100, 440);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(150, 20);
            this.txtUserName.TabIndex = 11;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(270, 438);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 23);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.Text = "Agregar Usuario";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtLoanUserId
            // 
            this.txtLoanUserId.Location = new System.Drawing.Point(480, 438);
            this.txtLoanUserId.Name = "txtLoanUserId";
            this.txtLoanUserId.Size = new System.Drawing.Size(80, 20);
            this.txtLoanUserId.TabIndex = 13;
            // 
            // txtLoanBookId
            // 
            this.txtLoanBookId.Location = new System.Drawing.Point(579, 438);
            this.txtLoanBookId.Name = "txtLoanBookId";
            this.txtLoanBookId.Size = new System.Drawing.Size(80, 20);
            this.txtLoanBookId.TabIndex = 14;
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Location = new System.Drawing.Point(682, 435);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(100, 23);
            this.btnCreateLoan.TabIndex = 15;
            this.btnCreateLoan.Text = "Registrar Préstamo";
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // btnReturnLoan
            // 
            this.btnReturnLoan.Location = new System.Drawing.Point(682, 464);
            this.btnReturnLoan.Name = "btnReturnLoan";
            this.btnReturnLoan.Size = new System.Drawing.Size(100, 23);
            this.btnReturnLoan.TabIndex = 16;
            this.btnReturnLoan.Text = "Devolver Libro";
            this.btnReturnLoan.Click += new System.EventHandler(this.btnReturnLoan_Click);
            // 
            // lblBooks
            // 
            this.lblBooks.Location = new System.Drawing.Point(12, 12);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(100, 23);
            this.lblBooks.TabIndex = 17;
            this.lblBooks.Text = "LIBROS";
            // 
            // lblUsers
            // 
            this.lblUsers.Location = new System.Drawing.Point(12, 280);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(100, 23);
            this.lblUsers.TabIndex = 18;
            this.lblUsers.Text = "USUARIOS";
            // 
            // lblLoans
            // 
            this.lblLoans.Location = new System.Drawing.Point(480, 12);
            this.lblLoans.Name = "lblLoans";
            this.lblLoans.Size = new System.Drawing.Size(100, 23);
            this.lblLoans.TabIndex = 19;
            this.lblLoans.Text = "PRÉSTAMOS";
            // 
            // lblBookId
            // 
            this.lblBookId.Location = new System.Drawing.Point(12, 190);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(100, 23);
            this.lblBookId.TabIndex = 20;
            this.lblBookId.Text = "ID";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Location = new System.Drawing.Point(100, 190);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(100, 23);
            this.lblBookTitle.TabIndex = 21;
            this.lblBookTitle.Text = "Título";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.Location = new System.Drawing.Point(260, 190);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(100, 23);
            this.lblBookAuthor.TabIndex = 22;
            this.lblBookAuthor.Text = "Autor";
            // 
            // lblBookYear
            // 
            this.lblBookYear.Location = new System.Drawing.Point(370, 190);
            this.lblBookYear.Name = "lblBookYear";
            this.lblBookYear.Size = new System.Drawing.Size(100, 23);
            this.lblBookYear.TabIndex = 23;
            this.lblBookYear.Text = "Año";
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(12, 425);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(100, 23);
            this.lblUserId.TabIndex = 24;
            this.lblUserId.Text = "ID Usuario";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(117, 423);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 23);
            this.lblUserName.TabIndex = 25;
            this.lblUserName.Text = "Nombre Usuario";
            // 
            // lblLoanUserId
            // 
            this.lblLoanUserId.Location = new System.Drawing.Point(480, 414);
            this.lblLoanUserId.Name = "lblLoanUserId";
            this.lblLoanUserId.Size = new System.Drawing.Size(100, 22);
            this.lblLoanUserId.TabIndex = 26;
            this.lblLoanUserId.Text = "UserId";
            // 
            // lblLoanBookId
            // 
            this.lblLoanBookId.Location = new System.Drawing.Point(576, 414);
            this.lblLoanBookId.Name = "lblLoanBookId";
            this.lblLoanBookId.Size = new System.Drawing.Size(100, 23);
            this.lblLoanBookId.TabIndex = 27;
            this.lblLoanBookId.Text = "BookId";
            this.lblLoanBookId.Click += new System.EventHandler(this.lblLoanBookId_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.dgvLoans);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtBookAuthor);
            this.Controls.Add(this.txtBookYear);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtLoanUserId);
            this.Controls.Add(this.txtLoanBookId);
            this.Controls.Add(this.btnCreateLoan);
            this.Controls.Add(this.btnReturnLoan);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblLoans);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.lblBookYear);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblLoanUserId);
            this.Controls.Add(this.lblLoanBookId);
            this.Name = "Form1";
            this.Text = "Cliente WCF - Library System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvLoans;

        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookYear;

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;

        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnAddUser;

        private System.Windows.Forms.TextBox txtLoanUserId;
        private System.Windows.Forms.TextBox txtLoanBookId;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.Windows.Forms.Button btnReturnLoan;

        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblLoans;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookYear;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLoanUserId;
        private System.Windows.Forms.Label lblLoanBookId;
    }
}

