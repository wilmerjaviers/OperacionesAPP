namespace OperacionesApp.Pages;

public partial class Cuadrado : ContentPage
{
    public Cuadrado()
    {
        InitializeComponent();
    }

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        if (double.TryParse(LadoCuadrado.Text, out double lado))
        {
            double area = Math.Pow(lado, 2);
            Resultado.Text = $"El �rea del cuadrado es: {area:F2}";
        }
        else
        {
            Resultado.Text = "Por favor ingrese un valor v�lido";
        }
    }

    private void OnLimpiarClicked(object sender, EventArgs e)
    {
        LadoCuadrado.Text = string.Empty;
        Resultado.Text = string.Empty;
    }
}