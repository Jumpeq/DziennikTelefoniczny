namespace DziennikTelefoniczny
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefon = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dziennikTelefonicznyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new DziennikTelefoniczny.AppData();
            this.txtImie = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAdres = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Zapisz = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numerTelefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pełneImięDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anuluj = new MaterialSkin.Controls.MaterialFlatButton();
            this.Edytuj = new MaterialSkin.Controls.MaterialFlatButton();
            this.Nowy = new MaterialSkin.Controls.MaterialFlatButton();
            this.dziennikTelefonicznyTableAdapter = new DziennikTelefoniczny.AppDataTableAdapters.DziennikTelefonicznyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dziennikTelefonicznyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(21, 84);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(121, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Numer Telefonu:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dziennikTelefonicznyBindingSource, "NumerTelefonu", true));
            this.txtTelefon.Depth = 0;
            this.txtTelefon.Hint = "";
            this.txtTelefon.Location = new System.Drawing.Point(148, 84);
            this.txtTelefon.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.PasswordChar = '\0';
            this.txtTelefon.SelectedText = "";
            this.txtTelefon.SelectionLength = 0;
            this.txtTelefon.SelectionStart = 0;
            this.txtTelefon.Size = new System.Drawing.Size(178, 23);
            this.txtTelefon.TabIndex = 0;
            this.txtTelefon.UseSystemPasswordChar = false;
            this.txtTelefon.Click += new System.EventHandler(this.txtTelefon_Click);
            // 
            // dziennikTelefonicznyBindingSource
            // 
            this.dziennikTelefonicznyBindingSource.DataMember = "DziennikTelefoniczny";
            this.dziennikTelefonicznyBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtImie
            // 
            this.txtImie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dziennikTelefonicznyBindingSource, "PełneImię", true));
            this.txtImie.Depth = 0;
            this.txtImie.Hint = "";
            this.txtImie.Location = new System.Drawing.Point(148, 113);
            this.txtImie.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtImie.Name = "txtImie";
            this.txtImie.PasswordChar = '\0';
            this.txtImie.SelectedText = "";
            this.txtImie.SelectionLength = 0;
            this.txtImie.SelectionStart = 0;
            this.txtImie.Size = new System.Drawing.Size(178, 23);
            this.txtImie.TabIndex = 1;
            this.txtImie.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(21, 113);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Pełne Imię:";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dziennikTelefonicznyBindingSource, "Email", true));
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(148, 142);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(339, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(21, 142);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(98, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Adres E-mail:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(21, 171);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(52, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dziennikTelefonicznyBindingSource, "Adres", true));
            this.txtAdres.Depth = 0;
            this.txtAdres.Hint = "";
            this.txtAdres.Location = new System.Drawing.Point(148, 171);
            this.txtAdres.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.PasswordChar = '\0';
            this.txtAdres.SelectedText = "";
            this.txtAdres.SelectionLength = 0;
            this.txtAdres.SelectionStart = 0;
            this.txtAdres.Size = new System.Drawing.Size(339, 23);
            this.txtAdres.TabIndex = 3;
            this.txtAdres.UseSystemPasswordChar = false;
            // 
            // Zapisz
            // 
            this.Zapisz.AutoSize = true;
            this.Zapisz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Zapisz.Depth = 0;
            this.Zapisz.Location = new System.Drawing.Point(567, 436);
            this.Zapisz.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Zapisz.MouseState = MaterialSkin.MouseState.HOVER;
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Primary = false;
            this.Zapisz.Size = new System.Drawing.Size(59, 36);
            this.Zapisz.TabIndex = 8;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerTelefonuDataGridViewTextBoxColumn,
            this.pełneImięDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dziennikTelefonicznyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(601, 227);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // numerTelefonuDataGridViewTextBoxColumn
            // 
            this.numerTelefonuDataGridViewTextBoxColumn.DataPropertyName = "NumerTelefonu";
            this.numerTelefonuDataGridViewTextBoxColumn.HeaderText = "NumerTelefonu";
            this.numerTelefonuDataGridViewTextBoxColumn.Name = "numerTelefonuDataGridViewTextBoxColumn";
            // 
            // pełneImięDataGridViewTextBoxColumn
            // 
            this.pełneImięDataGridViewTextBoxColumn.DataPropertyName = "PełneImię";
            this.pełneImięDataGridViewTextBoxColumn.HeaderText = "PełneImię";
            this.pełneImięDataGridViewTextBoxColumn.Name = "pełneImięDataGridViewTextBoxColumn";
            this.pełneImięDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 150;
            // 
            // Anuluj
            // 
            this.Anuluj.AutoSize = true;
            this.Anuluj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Anuluj.Depth = 0;
            this.Anuluj.Location = new System.Drawing.Point(495, 436);
            this.Anuluj.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Anuluj.MouseState = MaterialSkin.MouseState.HOVER;
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Primary = false;
            this.Anuluj.Size = new System.Drawing.Size(64, 36);
            this.Anuluj.TabIndex = 7;
            this.Anuluj.Text = "ANULUJ";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // Edytuj
            // 
            this.Edytuj.AutoSize = true;
            this.Edytuj.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Edytuj.Depth = 0;
            this.Edytuj.Location = new System.Drawing.Point(425, 436);
            this.Edytuj.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Edytuj.MouseState = MaterialSkin.MouseState.HOVER;
            this.Edytuj.Name = "Edytuj";
            this.Edytuj.Primary = false;
            this.Edytuj.Size = new System.Drawing.Size(62, 36);
            this.Edytuj.TabIndex = 6;
            this.Edytuj.Text = "Edytuj";
            this.Edytuj.UseVisualStyleBackColor = true;
            this.Edytuj.Click += new System.EventHandler(this.Edytuj_Click);
            // 
            // Nowy
            // 
            this.Nowy.AutoSize = true;
            this.Nowy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Nowy.Depth = 0;
            this.Nowy.Location = new System.Drawing.Point(365, 436);
            this.Nowy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Nowy.MouseState = MaterialSkin.MouseState.HOVER;
            this.Nowy.Name = "Nowy";
            this.Nowy.Primary = false;
            this.Nowy.Size = new System.Drawing.Size(52, 36);
            this.Nowy.TabIndex = 5;
            this.Nowy.Text = "NOWY";
            this.Nowy.UseVisualStyleBackColor = true;
            this.Nowy.Click += new System.EventHandler(this.Nowy_Click);
            // 
            // dziennikTelefonicznyTableAdapter
            // 
            this.dziennikTelefonicznyTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 487);
            this.Controls.Add(this.Nowy);
            this.Controls.Add(this.Edytuj);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Zapisz);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dziennik Telefoniczny";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dziennikTelefonicznyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefon;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtImie;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAdres;
        private MaterialSkin.Controls.MaterialFlatButton Zapisz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton Anuluj;
        private MaterialSkin.Controls.MaterialFlatButton Edytuj;
        private MaterialSkin.Controls.MaterialFlatButton Nowy;
        private AppData appData;
        private System.Windows.Forms.BindingSource dziennikTelefonicznyBindingSource;
        private AppDataTableAdapters.DziennikTelefonicznyTableAdapter dziennikTelefonicznyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerTelefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pełneImięDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}

