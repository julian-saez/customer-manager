using System;
using System.IO;
using System.Globalization;

namespace CustomersApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCustomers()
        {
            lstCustomers.Clear();
            string directoryCustomersApp = AppDomain.CurrentDomain.BaseDirectory;
            string fileRoute = Path.Combine(directoryCustomersApp, "Customers.txt");
            if (!File.Exists(fileRoute))
            {
                MessageBox.Show("Do not exist a customer list");
            }

            using (StreamReader sr = new StreamReader(fileRoute))
            {
                while (sr.EndOfStream == false)
                {
                    var line = sr.ReadLine();
                    string[] lineToArray = line!.Split(',');
                    string customerName = lineToArray[0];
                    decimal balance = decimal.Parse(lineToArray[2], CultureInfo.InvariantCulture);
                    lstCustomers.Items.Add(balance.ToString());
                }
            }
        }

        private void addCustomerToAD()
        {
            string directoryCustomersApp = AppDomain.CurrentDomain.BaseDirectory;
            string fileRoute = Path.Combine(directoryCustomersApp, "Customers.txt");
            string name = txtCustomer.Text;
            string age = txtAge.Text;
            string balance = txtBalance.Text;


            //if (!File.Exists(fileRoute))
            //{
                using (StreamWriter sw = new StreamWriter(fileRoute, false))
                {
                    try
                    {
                        sw.WriteLine(name + "," + age + "," + balance);
                        MessageBox.Show("Customer saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al escribir en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            //}
            //else
            //{
                //using (StreamWriter sw = new StreamWriter(fileRoute, true))
                //{
                //    try
                //    {
                //        sw.WriteLine(name + "," + age, ",", balance);
                //        MessageBox.Show("Customer saved successfully!");
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show($"Error al escribir en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            getCustomers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCustomerToAD();
        }
    }
}