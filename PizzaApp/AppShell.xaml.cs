using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace PizzaApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PizzasPage), typeof(PizzasPage));
            Routing.RegisterRoute(nameof(PizzaPage), typeof(PizzaPage));
        }
    }
}
