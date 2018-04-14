namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oskarDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oskarDataSet1 = new WindowsFormsApp5.OskarDataSet1();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oskarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oskarDataSet = new WindowsFormsApp5.OskarDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usersTableAdapter1 = new WindowsFormsApp5.OskarDataSetTableAdapters.UsersTableAdapter();
            this.oskarDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new WindowsFormsApp5.OskarDataSetTableAdapters.ProductsTableAdapter();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter2 = new WindowsFormsApp5.OskarDataSet1TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oskarDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oskarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oskarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oskarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oskarDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.oskarDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // oskarDataSet1BindingSource
            // 
            this.oskarDataSet1BindingSource.DataSource = this.oskarDataSet1;
            this.oskarDataSet1BindingSource.Position = 0;
            // 
            // oskarDataSet1
            // 
            this.oskarDataSet1.DataSetName = "OskarDataSet1";
            this.oskarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.oskarDataSetBindingSource;
            // 
            // oskarDataSetBindingSource
            // 
            this.oskarDataSetBindingSource.DataSource = this.oskarDataSet;
            this.oskarDataSetBindingSource.Position = 0;
            // 
            // oskarDataSet
            // 
            this.oskarDataSet.DataSetName = "OskarDataSet";
            this.oskarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.oskarDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(666, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sort";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(660, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "Get";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(560, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(94, 264);
            this.listBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 376);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(401, 376);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(660, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 30);
            this.button5.TabIndex = 9;
            this.button5.Text = "List";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(651, 380);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Surname or Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Age or Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "List name";
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // oskarDataSet1BindingSource1
            // 
            this.oskarDataSet1BindingSource1.DataSource = this.oskarDataSet1;
            this.oskarDataSet1BindingSource1.Position = 0;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.oskarDataSetBindingSource;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.oskarDataSet1BindingSource;
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oskarDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oskarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oskarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oskarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oskarDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource oskarDataSetBindingSource;
        private OskarDataSet oskarDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private OskarDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource oskarDataSet1BindingSource;
        private OskarDataSet1 oskarDataSet1;
        private System.Windows.Forms.BindingSource oskarDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private OskarDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private OskarDataSet1TableAdapters.UsersTableAdapter usersTableAdapter2;
    }
}

