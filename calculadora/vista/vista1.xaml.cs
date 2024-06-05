namespace calculadora.vista;

public partial class vista1 : ContentPage
{
    public vista1()
    {
        InitializeComponent();
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        if (pkAlumnos.SelectedIndex < 0)
        {
            DisplayAlert("Alerta", "Seleccione 1", "Ok");
        }
        else
        {
            var datos = pkAlumnos.Items[pkAlumnos.SelectedIndex];
            string datos1 = datos.ToString();

            double ns1 = double.Parse(txtNS1.Text);
            double ne1 = double.Parse(txtNE1.Text);
            double ns2 = double.Parse(txtNS2.Text);
            double ne2 = double.Parse(txtNE2.Text);
            string fecha = dpFecha.Date.ToString();

            double np1 = (ns1 * 0.3) + (ne1 * 0.2);
            double np2 = (ns2 * 0.3) + (ne2 * 0.2);

            double nf = np1 + np2;

            if (nf > 0 && nf < 5)
            {
                string msm = ("Alumno : " + datos1 + "\n"
                            + "Fecha : " + fecha + "\n"
                            + "Nota parcial 1: " + np1 + "\n"
                            + "Nota parcial 2: " + np2 + "\n"
                            + "Nota final: " + nf + "\n"
                            + "Reprobado");

                DisplayAlert("Estimado: ", msm, "Ok");
            }
            else if (nf >= 5 && nf < 7)
            {
                string msm = ("Alumno : " + datos1 + "\n"
                            + "Fecha : " + fecha + "\n"
                            + "Nota parcial 1: " + np1 + "\n"
                            + "Nota parcial 2: " + np2 + "\n"
                            + "Nota final: " + nf + "\n"
                            + "Complementario");

                DisplayAlert("Estimado: ", msm, "Ok");
            }
            else if (nf >= 7 && nf <= 10)
            {
                string msm = ("Alumno : " + datos1 + "\n"
                            + "Fecha : " + fecha + "\n"
                            + "Nota parcial 1: " + np1 + "\n"
                            + "Nota parcial 2: " + np2 + "\n"
                            + "Nota final: " + nf + "\n"
                            + "Aprobado");

                DisplayAlert("Estimado: ", msm, "Ok");
            }
            else
            {
                DisplayAlert("Alerta", "Revisa codigo", "Ok");
            }
        }

    }
    
}