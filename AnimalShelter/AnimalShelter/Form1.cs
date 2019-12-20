using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public List<Customer> Customers = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCust_Click(object sender, EventArgs e)
        {
            Customer Cus = new Customer(CustNewLN.Text, CustNewFN.Text, DateTime.Parse(CustNewBir.Text));
            Cus.Address = CustNewAdr.Text;
            Cus.Description = CustNewDesc.Text;

            CustList.Rows.Add(Cus.FirstName, Cus.Age, Cus.IsQualified);

            Customers.Add(Cus);
        }

        public void ShowDetail(Customer cus)
        {
            CustFullName.Text = cus.FullName;
            CustAge.Text = cus.Age.ToString();
            CustIsQualified.Text = cus.IsQualified.ToString();
            CustAddress.Text = cus.Address;
            CustDetail.Text = cus.Description;

            CusPatInfo.Text = "";
            foreach(Pet pet in cus.MyPets)
            {
                CusPatInfo.Text += pet.Name + " : " + pet.MakeSound() + Environment.NewLine;
          
            }
        }

        private void CustList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string firstName = CustList.Rows[e.RowIndex].Cells[0].Value.ToString();

            foreach (Customer cus in Customers)
            {
                if (cus.FirstName == firstName)
                {
                    ShowDetail(cus);
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Customer cus = new Customer("Ian", "Na", new DateTime(2000, 1, 2));
            Cat cat = new Cat(1, "Locas", "White", "Male");
            cus.Adopt(cat);

            Pet pet;
            pet = cat;
            pet.MakeSound();

            Customers.Add(cus);
            CustList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);
        }
    }
}
