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

            var ns1 = double.Parse(txtNS1.Text);
            var ne1 = double.Parse(txtNE1.Text);
            var ns2 = double.Parse(txtNS2.Text);
            var ne2 = double.Parse(txtNE2.Text);
            string fecha = dpFecha.Date.ToString();

            double np1 = (ns1 * 0.3) + (ne1 * 0.2);

            double np2 = (ns2 * 0.3) + (ne2 * 0.2);

            double nf = np1 + np2;

            

            if (nf > 0 && nf < 5) {
                string msm = ("Alumno : " + datos1 + "\n"
                    + "fecha : " + fecha + "\n"
                    + "nota parcial 1" + np1 + "\n"
                    + "nota parcial 2" + np2 + "\n"
                    + "nota final : "+nf +"\n"
                    + "REPROBADO");
            }
            if (nf > 5 && nf < 7)
            {
                string msm = ("Alumno : " + datos1 + "\n"
                    + "fecha : " + fecha + "\n"
                    + "nota parcial 1" + np1 + "\n"
                    + "nota parcial 2" + np2 + "\n"
                    + "nota final : " + nf + "\n"
                    + "COMPLEMENTARIO");
            }
            if (nf > 7 && nf < 11)
            {
                string msm = ("Alumno : " + datos1 + "\n"
                    + "fecha : " + fecha + "\n"
                    + "nota parcial 1" + np1 + "\n"
                    + "nota parcial 2" + np2 + "\n"
                    + "nota final : " + nf + "\n"
                    + "APROBADO ");
            }
            else
            {
                DisplayAlert("Alerta", "revisa codigo", "ok");
            }


        }

    }
}