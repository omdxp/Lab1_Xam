using Lab1_Xam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab1_Xam
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// This method is launched whenever the use click on the button.
        /// It reads the data from user.
        /// Check if the given height is in meters (if not it displays an Alert).
        /// Caclulate the BMI from a custom class "BmiCalculator"
        /// </summary>
        /// <param name="sender">Button that have been clicked</param>
        /// <param name="e">Click event</param>
        private void CalculateBMIClicked(object sender, EventArgs e)
        {
            // Reading data from user
            float height = Convert.ToSingle(eHeight.Text);
            float weight = Convert.ToSingle(eWeight.Text);
            // Check if the height is in centimeters to display an Alert
            if (height > 100)
            {
                DisplayAlert("Error", "Please for height use meters instead of centimeters", "Okay");
                return;
            }
            // Calculate the BMI
            BmiCalculator bmi = new BmiCalculator();
            bmi.Height = height;
            bmi.Weight = weight;

            float calculatedBmi = bmi.CalculateBmi();
            // Show the result
            result.Text = calculatedBmi.ToString("F2");
        }
        /// <summary>
        /// This method check if both entries are filled.
        /// </summary>
        /// <returns></returns>
        private bool CheckIfBothEntriesAreFilled()
        {
            return !string.IsNullOrEmpty(eHeight.Text) && !string.IsNullOrEmpty(eWeight.Text);
        }
        /// <summary>
        /// This method enables the button if both entries are filled.
        /// </summary>
        /// <param name="sender">Entry that have been changed</param>
        /// <param name="e">Text change event</param>
        private void eHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CheckIfBothEntriesAreFilled())
            {
                button.IsEnabled = true;
            }
            else
            {
                button.IsEnabled = false;
            }
        }
        /// <summary>
        /// This method enables the button if both entries are filled.
        /// </summary>
        /// <param name="sender">Entry that have been changed</param>
        /// <param name="e">Text change event</param>
        private void eWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CheckIfBothEntriesAreFilled())
            {
                button.IsEnabled = true;
            }
            else
            {
                button.IsEnabled = false;
            }
        }
    }
}
