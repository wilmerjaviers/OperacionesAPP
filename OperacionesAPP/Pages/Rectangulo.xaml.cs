namespace OperacionesApp.Pages;

public partial class Rectangulo : ContentPage
{
    public Rectangulo()
    {
        InitializeComponent();
    }

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        if (double.TryParse(BaseRectangulo.Text, out double baseRect) &&
            double.TryParse(AlturaRectangulo.Text, out double altura))
        {
            double area = baseRect * altura;
            Resultado.Text = $"El área del rectángulo es: {area:F2}";
        }
        else
        {
            Resultado.Text = "Por favor ingrese valores válidos";
        }
    }

    private void OnLimpiarClicked(object sender, EventArgs e)
    {
        BaseRectangulo.Text = string.Empty;
        AlturaRectangulo.Text = string.Empty;
        Resultado.Text = string.Empty;
    }
}