namespace Complementario52429841
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(Entry1.Text) && !string.IsNullOrEmpty(Entry2.Text) && !string.IsNullOrEmpty(Entry3.Text) && !String.IsNullOrEmpty(Entry3.Text) && !String.IsNullOrEmpty(Entry4.Text)) ;
            {
                double altura, Base, Perimetro, Superficie;
                altura = Convert.ToDouble(Entry1.Text);
                Base = Convert.ToDouble(Entry2.Text);


                Superficie = (altura * Base);
                Entry4.Text = "La superficie del rectangulo es: " + Superficie.ToString();


                Perimetro = (altura + Base) * 2;
                Entry3.Text = "El perimetro del rectangulo es: " + Perimetro.ToString();
            }
        }
    }

}
