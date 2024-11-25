namespace OperacionesApp.Pages;

public partial class Circulo : ContentPage
{
    public Circulo()
    {
        InitializeComponent();
    }

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        if (double.TryParse(RadioCirculo.Text, out double radio))
        {
            double area = Math.PI * Math.Pow(radio, 2);
            Resultado.Text = $"El área del círculo es: {area:F2}";
        }
        else
        {
            Resultado.Text = "Por favor ingrese un valor válido";
        }
    }

    private void OnLimpiarClicked(object sender, EventArgs e)
    {
        RadioCirculo.Text = string.Empty;
        Resultado.Text = string.Empty;
    }
}
