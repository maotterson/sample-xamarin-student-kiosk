using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleXamarin2
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

        async void onButtonClicked(object sender, EventArgs args)
        {
            bool validCredentials = checkCredentials(textStudentId.Text, textName.Text);
            if (validCredentials)
            {
                label.Text = "successfully checked in";
            }
            else
            {
                label.Text = "unsuccessful check in";
            }
        }

        private bool checkCredentials(string studentId, string name)
        {
            // send request


            // check status code of response
            // 201 => successful
            int status = 201;
            if(status == 201)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
