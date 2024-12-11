using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        private double totalAmount = 0;
        private const double DiscountRate = 0.10;

        public Form3()
        {
            InitializeComponent();

            // Assign event handlers
            button1.Click += (s, e) => AddToCart("Parachute Experience", 100);
            button2.Click += (s, e) => AddToCart("Trekking Adventure", 200);
            button3.Click += (s, e) => AddToCart("Camping Experience", 150);
            button4.Click += (s, e) => AddToCart("Rafting Adventure", 250);
            buttonDiscard.Click += (s, e) => DiscardCart();
            buttonCalculate.Click += (s, e) => CalculateFinalAmount();
            buttonProceed.Click += (s, e) => ProceedToCheckout();
        }

        // Overloaded constructor
        public Form3(string someParam)
        {
            InitializeComponent();
            // You can do something with 'someParam' if needed.
        }

        private void AddToCart(string item, double price)
        {
            if (string.IsNullOrWhiteSpace(item) || price <= 0)
            {
                MessageBox.Show("Invalid item or price. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBoxCart.Items.Add($"{item} - ${price:F2}");
            totalAmount += price;
            UpdateTotal();
        }

        private void DiscardCart()
        {
            if (listBoxCart.Items.Count == 0)
            {
                MessageBox.Show("Your cart is already empty.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listBoxCart.Items.Clear();
            totalAmount = 0;
            UpdateTotal();
            ClearCalculations();
        }

        private void CalculateFinalAmount()
        {
            if (totalAmount <= 0)
            {
                MessageBox.Show("No items in the cart to calculate the final amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double discount = totalAmount * DiscountRate;
            double finalAmount = totalAmount - discount;

            textBoxTotal.Text = $"${totalAmount:F2}";
            textBoxDiscount.Text = $"${discount:F2}";
            textBoxFinalAmount.Text = $"${finalAmount:F2}";
        }

        private void ProceedToCheckout()
        {
            if (listBoxCart.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items to proceed.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to proceed to checkout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for your purchase! Proceeding to payment.", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DiscardCart();
            }
        }

        private void UpdateTotal()
        {
            labelTotal.Text = $"Total: ${totalAmount:F2}";
        }

        private void ClearCalculations()
        {
            textBoxTotal.Text = string.Empty;
            textBoxDiscount.Text = string.Empty;
            textBoxFinalAmount.Text = string.Empty;
        }
    }
}
