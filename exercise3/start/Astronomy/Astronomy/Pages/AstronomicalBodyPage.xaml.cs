namespace Astronomy.Pages;

public partial class AstronomicalBodyPage : ContentPage
{
    public AstronomicalBodyPage(AstronomicalBody body)
    {
        InitializeComponent();

        Title = body.Name;

        lblIcon.Text = body.EmojiIcon;
        lblName.Text = body.Name;
        lblMass.Text = body.Mass;
        lblCircumference.Text = body.Circumference;
        lblAge.Text = body.Age;
    }
}