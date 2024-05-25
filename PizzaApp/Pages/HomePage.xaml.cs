using PizzaApp.Models;

namespace PizzaApp;

public partial class HomePage : ContentPage
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


    public List<Category> Categories { get; set; } =
[
    new Category { Name = "Vegetarian", Image = "category_1.jpg", Description = "Delicious vegetarian pizzas" },
    new Category { Name = "Meat Lovers", Image = "category_2.jpg", Description = "For those who love meaty toppings" },
    new Category { Name = "Cheese Lovers", Image = "category_3.jpg", Description = "Indulge in cheesy goodness" },
    new Category { Name = "Seafood Special", Image = "category_4.jpg", Description = "Fresh seafood toppings" },
    new Category { Name = "Supreme", Image = "category_5.jpg", Description = "The ultimate pizza experience" },
    new Category { Name = "Custom", Image = "category_6.jpg", Description = "Create your own masterpiece" }
];
    public HomePage()
    {
        InitializeComponent();

        BindingContext = this;
    }

    private async void OnCategorySelected(object sender, SelectionChangedEventArgs e)
    {
        var selectedCategory = e.CurrentSelection.FirstOrDefault() as Category;
        if (selectedCategory != null)
        {
            await Shell.Current.GoToAsync($"PizzasPage?category={selectedCategory.Name}");
        }
    }

    private void Next(object sender, EventArgs e)
    {
        PizzaCarousel.Position = (PizzaCarousel.Position + 1) % PizaItems.Count;
    }

    private void Pref(object sender, EventArgs e)
    {
        PizzaCarousel.Position = PizzaCarousel.Position != 0 ? (PizzaCarousel.Position - 1) : PizaItems.Count - 1;
    }

    async private void OpenPizzaPage(object sender, TappedEventArgs e)
    {
        var selectedPizza = PizaItems[PizzaCarousel.Position];
        if (selectedPizza != null)
        {
            await Shell.Current.GoToAsync($"PizzaPage?name={selectedPizza.Name}&price={selectedPizza.Price}&image={selectedPizza.Image}&description={selectedPizza.Description}");
        }
    }
}
