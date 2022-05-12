namespace Astronomy.Pages;

public partial class AstronomicalBodyPage : ContentPage
{
    public AstronomicalBodyPage()
    {
        InitializeComponent();

        AstronomicalBody body = SolarSystemData.Earth;

        Title = body.Name;

        lblIcon.Text = body.EmojiIcon;
        lblName.Text = body.Name;
        lblMass.Text = body.Mass;
        lblCircumference.Text = body.Circumference;
        lblAge.Text = body.Age;
    }
}