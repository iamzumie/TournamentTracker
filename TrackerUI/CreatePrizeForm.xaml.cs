using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TrackerUI
{
    /// <summary>
    /// Interaction logic for CreatePrizeForm.xaml
    /// </summary>
    public partial class CreatePrizeForm : Window
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void btnCreatePrize_Click(object sender, RoutedEventArgs e)
        {

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            
            bool placeNumberValidNumber = int.TryParse(txtPlaceNumber.Text, out placeNumber);

            // If it's a valid number
            if (placeNumberValidNumber == false)
            {
                output = false;
            }

            // If number isn't 0
            if (placeNumber < 1)
            {
                output = false;
            }

            if (txtPlaceName.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(txtPlaceAmount.Text, out prizeAmount);
            bool prizePercentageValid = int.TryParse(txtPrizePercentage.Text, out prizePercentage);

            // If prizeAmount or prizePercentage is valid
            if (prizeAmountValid == false || prizePercentageValid == false)
            {

            }

            return output;
        }
    }
}
