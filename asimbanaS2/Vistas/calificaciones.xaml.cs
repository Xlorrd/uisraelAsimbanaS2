namespace asimbanaS2.Vistas;

public partial class calificaciones : ContentPage
{
	public calificaciones()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		

		double notaP1 = Convert.ToDouble(txtnotaP1.Text);
		double notaP2 = Convert.ToDouble(txtnotaP2.Text);
		double examen = Convert.ToDouble(txtnotaExamen.Text);
		double examen2 = Convert.ToDouble(txtnotaExamen2.Text);

		//Parcial 1
		double multip1 = notaP1 * 0.3;
		double multiExa = examen * 0.2;
		double resultadop1 = multip1 + multiExa;

		// Parcial 2
		double multip2 = notaP2 * 0.3;
		double multiExa2 = examen2 * 0.2;
		double resultadop2 = multip2 + multiExa2;
		double sumaTotal = resultadop1 + resultadop2;

		if (sumaTotal >= 7)
		{
            DisplayAlert("Resultado", $"Hola tus calificaciones del primer parcial son \n parcial 1: {resultadop1}\n parcial 2:{resultadop2} \n Aprobaste con {sumaTotal} ", "OK");
		}
		else { 
            DisplayAlert("Resultado", $"Hola tus calificaciones del primer parcial son \n parcial 1: {resultadop1}\n parcial 2:{resultadop2} \n Reprobaste con {sumaTotal} ", "OK");


        }




    }
}