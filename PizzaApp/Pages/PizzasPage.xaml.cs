using PizzaApp.Models;

namespace PizzaApp;

public partial class PizzasPage : ContentPage
{
    public List<Pizza> PizaItems { get; set; } = new List<Pizza>
{
    new Pizza() { Name = "Margherita", Description = "Classic cheese and tomato", Image = "pizzas__1.png", Price = 15 },
    new Pizza() { Name = "Pepperoni", Description = "Loaded with pepperoni slices", Image = "pizzas__2.png", Price = 18 },
    new Pizza() { Name = "BBQ Chicken", Description = "Grilled chicken with BBQ sauce", Image = "pizzas__3.png", Price = 20 },
    new Pizza() { Name = "Veggie Delight", Description = "Fresh veggies on a crisp crust", Image = "pizzas__4.png", Price = 16 },
    new Pizza() { Name = "Hawaiian", Description = "Ham and pineapple lovers' favorite", Image = "pizzas__5.png", Price = 17 },
    new Pizza() { Name = "Meat Lovers", Description = "Packed with various meats", Image = "pizzas__6.png", Price = 22 },
    new Pizza() { Name = "Four Cheese", Description = "Mozzarella, cheddar, gouda, parmesan", Image = "pizzas__7.png", Price = 19 },
    new Pizza() { Name = "Spicy Italian", Description = "Spicy sausage with hot peppers", Image = "pizzas__8.png", Price = 18 },
    new Pizza() { Name = "Seafood Special", Description = "Shrimps and calamari on top", Image = "pizzas__9.png", Price = 25 },
};
    public PizzasPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private async void OnPizzaSelected(object sender, SelectionChangedEventArgs e)
    {
        var selectedPizza = e.CurrentSelection.FirstOrDefault() as Pizza;
        if (selectedPizza != null)
        {
            await Shell.Current.GoToAsync($"PizzaPage?name={selectedPizza.Name}&price={selectedPizza.Price}&image={selectedPizza.Image}&description={selectedPizza.Description}");
        }
    }

    private async void OnImageTapped(object sender, TappedEventArgs e)
    {
        var image = (Image)sender;
        var pizza = (Pizza)image.BindingContext;
        if (pizza != null)
        {
            await Shell.Current.GoToAsync($"PizzaPage?name={pizza.Name}&price={pizza.Price}&image={pizza.Image}&description={pizza.Description}");

        }
    }
}
