using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket
{
    public partial class PurchaseTicketUI : Form
    {
        public PurchaseTicketUI()
        {
            InitializeComponent();
        }
        int numberOfTickets = 0;
        double unitPrice = 10;
        string customerName = "";
        double totalPrice = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            numberOfTickets = Convert.ToInt16(numberOfTicketsTextBox.Text);
            customerName = customerNameTextBox.Text;
            totalPrice = unitPrice * numberOfTickets;

            customerNameTextBox.Text = "";
            numberOfTicketsTextBox.Text = "";

            MessageBox.Show(customerName + ", Please Pay " + totalPrice + "Taka to Purchase" + numberOfTickets + "Ticket(s)");

        }

        private void PurchaseTicketUI_Load(object sender, EventArgs e)
        {

        }

        private void detailsButtont_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Name :" + customerName + " nUnit Price :" + unitPrice + " nTotal Price :" + totalPrice);
        }
    }
}
