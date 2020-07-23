/* Title:           Calculator
 * Date:            10-24-18
 * Author:          Terry Holmes
 * 
 * Description:     This is a test to see if this works */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorXAML
{
    public partial class MainPage : ContentPage
    {
        //setting variables
        double gdouFirstNumber;
        double gdouSecondNumber;
        double gdouTotalNumber;
        bool gblnContinueTransaction = false;
        bool gblnFunctionPressed = false;
        string gstrFunction;


        public MainPage()
        {
            InitializeComponent();
        }
        private void NumberPushed()
        {
            gblnFunctionPressed = false;
        }
        private void btnClear_Pressed(object sender, EventArgs e)
        {
            gblnContinueTransaction = false;
            gdouTotalNumber = 0;
            
            
        }
    }
}
