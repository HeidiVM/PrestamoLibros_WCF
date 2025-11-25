namespace Libreria.Cliente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador.  
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtLoanUserId = new System.Windows.Forms.TextBox();
            this.txtLoanBookId = new System.Windows.Forms.TextBox();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblLoans = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
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
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(12, 32);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(350, 150);
            this.dgvBooks.TabIndex = 0;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 230);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(350, 150);
            this.dgvUsers.TabIndex = 1;
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(380, 32);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.Size = new System.Drawing.Size(350, 350);
            this.dgvLoans.TabIndex = 2;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(12, 205);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(250, 20);
            this.txtBookTitle.TabIndex = 3;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(270, 203);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(92, 23);
            this.btnAddBook.TabIndex = 4;
            this.btnAddBook.Text = "Agregar Libro";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(12, 405);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(250, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(270, 403);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(92, 23);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Agregar Usuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtLoanUserId
            // 
            this.txtLoanUserId.Location = new System.Drawing.Point(380, 405);
            this.txtLoanUserId.Name = "txtLoanUserId";
            this.txtLoanUserId.Size = new System.Drawing.Size(80, 20);
            this.txtLoanUserId.TabIndex = 7;
            // 
            // txtLoanBookId
            // 
            this.txtLoanBookId.Location = new System.Drawing.Point(480, 405);
            this.txtLoanBookId.Name = "txtLoanBookId";
            this.txtLoanBookId.Size = new System.Drawing.Size(80, 20);
            this.txtLoanBookId.TabIndex = 8;
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Location = new System.Drawing.Point(580, 403);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(150, 23);
            this.btnCreateLoan.TabIndex = 9;
            this.btnCreateLoan.Text = "Registrar Préstamo";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // Labels
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(12, 12);
            this.lblBooks.Text = "LIBROS";

            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(12, 210);
            this.lblUsers.Text = "USUARIOS";

            this.lblLoans.AutoSize = true;
            this.lblLoans.Location = new System.Drawing.Point(380, 12);
            this.lblLoans.Text = "PRÉSTAMOS";

            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(12, 190);
            this.lblBookTitle.Text = "Título del libro:";

            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 390);
            this.lblUserName.Text = "Nombre usuario:";

            this.lblLoanUserId.AutoSize = true;
            this.lblLoanUserId.Location = new System.Drawing.Point(380, 390);
            this.lblLoanUserId.Text = "UserId:";

            this.lblLoanBookId.AutoSize = true;
            this.lblLoanBookId.Location = new System.Drawing.Point(480, 390);
            this.lblLoanBookId.Text = "BookId:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblLoans);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblLoanUserId);
            this.Controls.Add(this.lblLoanBookId);

            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.dgvLoans);

            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.btnAddBook);

            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnAddUser);

            this.Controls.Add(this.txtLoanUserId);
            this.Controls.Add(this.txtLoanBookId);
            this.Controls.Add(this.btnCreateLoan);

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

        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Button btnAddBook;

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnAddUser;

        private System.Windows.Forms.TextBox txtLoanUserId;
        private System.Windows.Forms.TextBox txtLoanBookId;
        private System.Windows.Forms.Button btnCreateLoan;

        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblLoans;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLoanUserId;
        private System.Windows.Forms.Label lblLoanBookId;
    }
}

