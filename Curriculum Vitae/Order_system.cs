    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Curriculum_Vitae
    {
        public partial class Order_system : Form
        {
            public Order_system()
            {
                InitializeComponent();
                lblUserInfo.ForeColor = Color.White;


            }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Order_system_Load(object sender, EventArgs e)
            {
        

            //Name ng user
            if (Session.LoggedInUser != null)
            {
                lblUserInfo.Text = Session.LoggedInUser.Username;
            }

            //Peso sign
            char pesoChar = '\u20B1';
                Console.WriteLine(pesoChar);  

            
            //prices 
                radiobtn_classic.Tag = 0m; 
                radiobtn_jasmine.Tag = 0m; 
                radiobtn_van.Tag = 0m; 
                radiobtn_caramel.Tag = 0m;
                radiobtn_taro.Tag = 0m;
                radiobtn_bubble.Tag = 0m;
                radiobtn_clp.Tag = 0m;
                radiobtn_lpj.Tag = 0m;
                radiobtn_tg.Tag = 0m;
                radiobtn_tl.Tag = 0m;
                radiobtn_kyukyu.Tag = 0m;

                radiobtn_small.Tag = 50.00m; 
                radiobtn_reg.Tag = 100.00m; 
                radiobtn_large.Tag = 120.00m;

            radiobtn_small.CheckedChanged += SizeRadioButton_CheckedChanged;
            radiobtn_reg.CheckedChanged += SizeRadioButton_CheckedChanged;
            radiobtn_large.CheckedChanged += SizeRadioButton_CheckedChanged;
        
            }



            //mavview price sa textbox after choosing flavor and size
            private void SizeRadioButton_CheckedChanged(object sender, EventArgs e)
            {
                    RadioButton sizeRadioButton = sender as RadioButton;
                    if (sizeRadioButton.Checked)
                    {
                        decimal sizePrice = (decimal)sizeRadioButton.Tag;

                        string pesoSign = "\u20B1";  
                        txtPrice.Text = $"{pesoSign}{sizePrice:F2}";
                    }
            }

               

            //store all the order info.
            private StringBuilder allOrders = new StringBuilder();


            private decimal grandTotal = 0m;


            //allows multiple order
            private void addOrder_btn_Click(object sender, EventArgs e)
            {            
                    decimal sizePrice = 0;

                    // Validate quantity
                    int quantity = 0;
                    if (int.TryParse(txtQuantity.Text, out quantity) && quantity > 0)           
                    {
                        //Checks which size is selected and get its price galing sa .Tag
                        if (radiobtn_small.Checked) sizePrice = (decimal)radiobtn_small.Tag;
                        if (radiobtn_reg.Checked) sizePrice = (decimal)radiobtn_reg.Tag;
                        if (radiobtn_large.Checked) sizePrice = (decimal)radiobtn_large.Tag;

                        bool flavorSelected =
                        radiobtn_classic.Checked || radiobtn_jasmine.Checked ||
                        radiobtn_van.Checked || radiobtn_caramel.Checked ||
                        radiobtn_taro.Checked || radiobtn_bubble.Checked ||
                        radiobtn_clp.Checked || radiobtn_lpj.Checked ||
                        radiobtn_tg.Checked || radiobtn_tl.Checked || radiobtn_kyukyu.Checked;

                        if (!flavorSelected || sizePrice == 0)
                        {
                            MessageBox.Show("Please select both a flavor and a size.");
                            return;
                        }

                        // Calculate item total and add to grand total
                        decimal itemTotal = sizePrice * quantity;
                        grandTotal += itemTotal;

                        string pesoSign = "\u20B1";
                        txtTotalPrice.Text = $"{pesoSign}{grandTotal:F2}";


                        //pang append text ng prevoius orders sa receipt
                        string order = $"Flavor: {GetSelectedFlavor()}\n" +
                                       $"Size: {GetSelectedSize()} \n " +
                                       $"\nQuantity: {txtQuantity.Text}\n   " +
                                       $"Total Price: {pesoSign}{sizePrice:F2}\n";
                        allOrders.AppendLine(order);

                        //after add to order, all textbox will be cleared except sa total
                        ClearSelections();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid positive quantity.");
                    }
            }

            //pang view ng change and generate receipt
            private void btn_pay_Click(object sender, EventArgs e)
            {
                decimal totalPrice = 0;
                decimal cash = 0;

                // Check if totalPrice and cash are valid decimal numbers
                if (decimal.TryParse(txtTotalPrice.Text.Replace("₱", ""), out totalPrice) &&
                    decimal.TryParse(txtCash.Text.Replace("₱", ""), out cash))
                {
                    if (cash >= totalPrice)
                    {
                        decimal change = cash - totalPrice;

                        // Display the change in txtChange TextBox
                        string pesoSign = "\u20B1";  // Peso sign Unicode
                        txtChange.Text = $"{pesoSign}{change:F2}";

                        // Build the receipt
                        StringBuilder receipt = new StringBuilder();
                        receipt.AppendLine("------ RECEIPT ------");
                        receipt.AppendLine("\n");
                        receipt.AppendLine(allOrders.ToString());  // Append all accumulated orders

                        receipt.AppendLine("\n");
                        receipt.AppendLine($"Total Price: {pesoSign}{totalPrice:F2}");
                        receipt.AppendLine("\n");
                        receipt.AppendLine($"Cash Given: {pesoSign}{cash:F2}");
                        receipt.AppendLine("\n");
                        receipt.AppendLine($"Change: {pesoSign}{change:F2}");
                        receipt.AppendLine("\n");
                        receipt.AppendLine("\n");
                        receipt.AppendLine("------------------------");

                        // Display the receipt in the TextBox
                        txtReceipt.Text = receipt.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient cash amount.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid amounts for total price and cash.");
                }
            }
            private string GetSelectedFlavor()
            {
                if (radiobtn_classic.Checked) return "Classic Milktea";
                if (radiobtn_jasmine.Checked) return "Jasmine Milktea";
                if (radiobtn_van.Checked) return "Vanilla Milktea";
                if (radiobtn_caramel.Checked) return "Caramel Milktea";
                if (radiobtn_taro.Checked) return "Taro Milktea";
                if (radiobtn_bubble.Checked) return "Bubble Tea";
                if (radiobtn_clp.Checked) return "Classic Lava Pearls";
                if (radiobtn_lpj.Checked) return "Lava Pearls Jasmine Milktea";
                if (radiobtn_tg.Checked) return "Three Guys Milktea";
                if (radiobtn_tl.Checked) return "Three Ladies Milktea";
                if (radiobtn_kyukyu.Checked) return "Kyukyu Milktea";
                return "No flavor selected";
            }

            // Get the selected size name
            private string GetSelectedSize()
            {
                if (radiobtn_small.Checked) return "Small";
                if (radiobtn_reg.Checked) return "Medium";
                if (radiobtn_large.Checked) return "Large";
                return "No flavor selected";
            }


            private void ClearSelections()
            {
                txtPrice.Clear();
            }

        

            private void btnBack_Click(object sender, EventArgs e)
            {
                Menu form = new Menu();
                form.Show();
                this.Hide();
            }

            private void close_btn_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void size_Click(object sender, EventArgs e)
            {

            }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {
            Session.LoggedInUser = null;
            this.Hide();
            var login = new Login();
            login.Show();
        }
    }
    }
