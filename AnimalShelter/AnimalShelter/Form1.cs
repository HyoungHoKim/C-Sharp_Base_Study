using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public Customer[] CustomerArray = new Customer[10];
        public int CustomerArrIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCust_Click(object sender, EventArgs e)
        {
            CustomerArray[CustomerArrIndex] = new Customer(CustNewLN.Text, CustNewFN.Text, DateTime.Parse(CustNewBir.Text));
            CustomerArray[CustomerArrIndex].Address = CustNewAdr.Text;
            CustomerArray[CustomerArrIndex].Description = CustNewDesc.Text;

            CustList.Items.Add(CustomerArray[CustomerArrIndex].FirstName);


            CustomerArrIndex++;
        }

        public void ShowDetail(Customer cus)
        {
            CustFullName.Text = cus.FullName;
            CustAge.Text = cus.Age.ToString();
            CustIsQualified.Text = cus.IsQualified.ToString();
            CustAddress.Text = cus.Address;
            CustDetail.Text = cus.Description;
        }

        private void CustList_Click(object sender, EventArgs e)
        {
            string firstName = CustList.SelectedItem.ToString();

            for(int i = 0; i < CustomerArrIndex; i++)
            {
                if(CustomerArray[i].FirstName == firstName)
                {
                    ShowDetail(CustomerArray[i]);
                    break;
                }
            }
        }
    }
}
