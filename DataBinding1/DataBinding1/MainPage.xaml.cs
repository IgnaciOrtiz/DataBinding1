using Xamarin.Forms;

namespace DataBinding1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var person = new Person
            {
                Name = "Nacho"
            };


            this.BindingContext = person;
        }
    }
}
