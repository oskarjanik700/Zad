
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{

 


    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        

        



        private void ShowData(string name)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from " + name, con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        abstract class Interfejs
        {

            // Factory Method



            public abstract string[] list_items();
            public abstract void add_item(string name, string surname, float age, int id);
            public abstract void sort_items();
            public abstract void delete_item(string name);
        };


        class Products : Interfejs
        {
            private string[] items;

            public override void delete_item(string name)
            {

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True");
                con.Open();
                string query = "DELETE FROM Products WHERE Name = '" + name + "'";
                SqlDataAdapter adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Deleted succesfuly");


            }
            public override string[] list_items()
            {



                return items;
            }
            string name, surname;
            float age;
            private object dtgv;

            public override void add_item(string name, string surname, float age, int id)
            {

                // id = dataGridView1.RowCount;

                /*
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (id ==  (int)this.dataGridView1.Rows[i].Cells[0].Value)
                        id += 2;


                        }*/


                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True");
                con.Open();
                string query = "INSERT INTO Products(id_Products, Name,  Description, Price) VALUES ('" + id + "', '" + name + "', '" + surname + "', '" + age + "')";
                SqlDataAdapter adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                con.Close();
                /*
                dataGridView1.Refresh();
                dataGridView1.Update();*/



                MessageBox.Show("Inserted succesfuly");
            }


            public override void sort_items()
            {
               

            }
        };


        class Users : Interfejs
        {

            private string[] items;


            public override void delete_item(string name)
            {

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True");
                con.Open();
                string query = "DELETE FROM Users WHERE Name = '" + name + "'";
                SqlDataAdapter adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Deleted succesfuly");
            }
            public override string[] list_items()
            {
                foreach (string x in items)
                {

                }
                return items;

            }
            public override void add_item(string name, string surname, float age, int id)
            {

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True");
                con.Open();
                string query = "INSERT INTO Users(id_Users, Name,  Surname, Age) VALUES ('" + id + "', '" + name + "', '" + surname + "', '" + age + "')";
                SqlDataAdapter adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                con.Close();
                /*
                dataGridView1.Refresh();
                dataGridView1.Update();*/



                MessageBox.Show("Inserted succesfuly");

            }
            public override void sort_items()
            {

            }
        };

        class Priviledges : Interfejs
        {

            string[] items;

            public override void delete_item(string name)
            {

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True");
                con.Open();
                string query = "DELETE FROM Priviledges WHERE Name = '" + name + "'";
                SqlDataAdapter adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Deleted succesfuly");
            }
            public override string[] list_items()
            {

                return items;
            }
            public override void add_item(string name, string surname, float age, int id)
            {

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True");
                con.Open();
                string query = "INSERT INTO Priviledges(id_Priviledges, Name) VALUES ('" + id + "', '" + name + "')";
                SqlDataAdapter adap = new SqlDataAdapter(query, con);
                adap.SelectCommand.ExecuteNonQuery();
                con.Close();
                /*
                dataGridView1.Refresh();
                dataGridView1.Update();*/



                MessageBox.Show("Inserted succesfuly");
            }
            public override void sort_items()
            {



            }
        };




        static class Factory
        {
            /// <summary>
            /// Decides which class to instantiate.
            /// </summary>
            public static Interfejs Get(int id)
            {
                switch (id)
                {
                    case 0:
                    return new Users();
                        break;
                    case 1:
                        return new Products();
                        break;
                    case 2:
                    return new Priviledges();
                        break;
                    default:
                        return null;
                }
            }
        }

    
        private BindingSource bindingSource1 = new BindingSource();


        static int id = 0;
        string name, surname;
        int age;
        string query;
        
        SqlDataAdapter adap;
        DataSet ds;
         public object usersTableAdapter;
        /*
        public object oskarDataSet { get; private set; }
        */
        public Form1()
        {
           // dataGridView1.Dock = DockStyle.Fill;
            this.Controls.Add(dataGridView1);
            InitializeComponent();
            //InitializeDataGridView();
        }
        /*
        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }*/

        private static DataTable GetData(string sqlCommand)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True";

            SqlConnection northwindConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlCommand, northwindConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'oskarDataSet.Priviliges' . Możesz go przenieść lub usunąć.
            //this.priviligesTableAdapter1.Fill(this.oskarDataSet.Priviliges);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'oskarDataSet.Products' . Możesz go przenieść lub usunąć.

            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'oskarDataSet.Users' . Możesz go przenieść lub usunąć.

            

            DataSet ds = new DataSet();
            string sql = "SELECT * FROM Users";
           SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True"); 
            
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(ds, "Users");
                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.DataSource = ds.Tables["Users"];
            

            //this.priviligesTableAdapter.Fill(this.oskarDataSet.Priviliges)

            /*
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)'\'MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True");
                con.Open();
                 adap = new SqlDataAdapter(query, con);
                 ds = new System.Data.DataSet();
                adap.Fill(ds, "Users");
                dataGridView1.DataSource = ds.Tables[0];
                query = "INSERT INTO Users(Id_Users, Name,  Surname, Age) VALUES ('" + id + "', '" + name + "', '" + surname + "', '" + age + "')";
            }
            catch(Exception ex)
            {
                MessageBox.Show("NIE POLOCZYLES SIE!!");
            }*/

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Interfejs ob;
            name = textBox1.Text;

            if (textBox4.Text == "Products")
            {
                ob = Factory.Get(1);
                ob.delete_item(name);
                ShowData("Products");

            }

            if (textBox4.Text == "Users")
            {
                ob = Factory.Get(0);
                ob.delete_item(name);
                ShowData("Users");
            }
            if (textBox4.Text == "Priviledges")
            {
                ob = Factory.Get(2);
                ob.delete_item(name);
                ShowData("Priviledges");

            }


            dataGridView1.Refresh();
            dataGridView1.Update();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True");
            con.Open();
            query = "SELECT * FROM Users ORDER BY Surname";
            adap = new SqlDataAdapter(query, con);
            adap.SelectCommand.ExecuteNonQuery();
            con.Close();
            */
            Interfejs ob;

            

            if (textBox4.Text == "Products")
            {
                ob = Factory.Get(1);
                this.dataGridView1.Sort(this.dataGridView1.Columns[2], ListSortDirection.Ascending);

            }

            if (textBox4.Text == "Users")
            {
                ob = Factory.Get(0);
                this.dataGridView1.Sort(this.dataGridView1.Columns[2], ListSortDirection.Ascending);

            }
            if (textBox4.Text == "Priviledges")
            {
                ob = Factory.Get(2);
                this.dataGridView1.Sort(this.dataGridView1.Columns[2], ListSortDirection.Ascending);

            }
           



            dataGridView1.Refresh();
            dataGridView1.Update();

            MessageBox.Show("Sorted succesfuly");
        }




        
        private void button4_Click(object sender, EventArgs e)
        {


            /*
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True");
            con.Open();
            SqlCommand query = new SqlCommand("SELECT * FROM Users", con);
            //adap = new SqlDataAdapter(query, con);
           // adap.SelectCommand.ExecuteNonQuery();

           
            SqlDataReader data = query.ExecuteReader();


            dt.Load(data);
            */


            //con.Close();

            //DataTable data = query;

            /*
            string[,] Datavalue = new string[dataGridView1.Rows.Count, dataGridView1.Columns.Count];

            foreach ( DataGridViewRow row in dataGridView1.Rows)
            {
                foreach(DataGridViewColumn col in dataGridView1.Columns)
                {
                    Datavalue[row.Index, col.Index] = dataGridView1.Rows[row.Index].Cells[col.Index].Value.ToString();
                }
            }
            */
            /*
            foreach(string ss in Datavalue)
            {

                listBox1.Items.Add(ss);

            }*/

            string value = "";

            dataGridView1.Refresh();
            dataGridView1.Update();


            foreach (DataGridViewRow row in dataGridView1.Rows)
        {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                        value = cell.Value.ToString();
                    else
                        value = "";
                  

                    listBox1.Items.Add(value);
                }
            }
            dataGridView1.Refresh();
            dataGridView1.Update();


            // dataGridView1.Refresh();
        }

        private DataGridView dataGridView2 = new DataGridView();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeDataGridView(string table)
        {
            try
            {
                // Set up the DataGridView.
                dataGridView1.Dock = DockStyle.Fill;

                // Automatically generate the DataGridView columns.
                dataGridView1.AutoGenerateColumns = true;

                // Set up the data source.
                bindingSource1.DataSource = GetData("Select * From " + table);
                dataGridView1.DataSource = bindingSource1;

                // Automatically resize the visible rows.
                dataGridView1.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                // Set the DataGridView control's border.
                dataGridView1.BorderStyle = BorderStyle.Fixed3D;

                // Put the cells in edit mode when user enters them.
                dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this sample replace connection.ConnectionString" +
                    " with a valid connection string to a Northwind" +
                    " database accessible to your system.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                System.Threading.Thread.CurrentThread.Abort();
            }
        }


        private void button5_Click_1(object sender, EventArgs e)
        {

           

            
            if (textBox4.Text == "Users")
            {
                InitializeDataGridView("Users");
            }

            if (textBox4.Text == "Products")
            {

                InitializeDataGridView("Products");

            }

            if (textBox4.Text == "Priviledges")
            {

                InitializeDataGridView("Priviledges");

            }


              
               
        }

        /*
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }*/

       

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'oskarDataSet1.Users' . Możesz go przenieść lub usunąć.
            this.usersTableAdapter2.Fill(this.oskarDataSet1.Users);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'oskarDataSet.Products' . Możesz go przenieść lub usunąć.
            this.productsTableAdapter.Fill(this.oskarDataSet.Products);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        /*
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'oskarDataSet.Users' . Możesz go przenieść lub usunąć.
            this.usersTableAdapter1.Fill(this.oskarDataSet.Users);

        }*/


        /*private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }*/




        private void button1_Click_1(object sender, EventArgs e)
        {
            name = textBox1.Text;

            if (textBox4.Text != "Priviledges")
            {
                surname = textBox2.Text;
                age = int.Parse(textBox3.Text);
            }

            Random rnd = new Random();
            id = rnd.Next(1, 1000);

            Interfejs ob;

            if (textBox4.Text == "Products")
            {
                ob = Factory.Get(1);
                ob.add_item(name, surname, age, id);
                ShowData("Products");
            }

            if (textBox4.Text == "Users")
            {
                ob = Factory.Get(0);
                ob.add_item(name, surname, age, id);
                ShowData("Users");
            }
            if (textBox4.Text == "Priviledges")
            {
                ob = Factory.Get(2);
                ob.add_item(name, surname, age, id);
                ShowData("Priviledges");
            }
            dataGridView1.Refresh();
            dataGridView1.Update();


            // id = dataGridView1.RowCount;

            /*
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (id ==  (int)this.dataGridView1.Rows[i].Cells[0].Value)
                    id += 2;


                    }*/

            /*
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Oskar;Integrated Security=True");
            con.Open();
            query = "INSERT INTO Users(id_Users, Name,  Surname, Age) VALUES ('" + id + "', '" + name + "', '" + surname + "', '" + age + "')";
            adap = new SqlDataAdapter(query, con);
            adap.SelectCommand.ExecuteNonQuery();
            con.Close();

            dataGridView1.Refresh();
            dataGridView1.Update()*/



        }
    }
}

