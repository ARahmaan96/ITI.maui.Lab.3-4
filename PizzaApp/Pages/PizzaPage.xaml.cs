namespace PizzaApp;

[QueryProperty(nameof(Name), "name")]
[QueryProperty(nameof(Description), "description")]
[QueryProperty(nameof(Price), "price")]
[QueryProperty(nameof(Image), "image")]
public partial class PizzaPage : ContentPage
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Image { get; set; }

    public PizzaPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        PizzaName.Text = Name;
        PizzaDescription.Text = Description;
        PizzaPrice.Text = $"Price: {Price:C}";
        PizzaImage.Source = Image;
    }
}
