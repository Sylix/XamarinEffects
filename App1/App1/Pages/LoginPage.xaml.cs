using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            var vm = new LoginViewModel();
            BindingContext = vm;

            InitializeComponent();

            EmailEntry.Completed += (object sender, EventArgs e) => { PasswordEntry.Focus(); };


            PasswordEntry.Completed += (object sender, EventArgs e) =>
            {
                //vm.SubmitCommand.Execute(null);

                EmailEntry.Text = "";
                PasswordEntry.Text = "";
            };
        }
    }
}