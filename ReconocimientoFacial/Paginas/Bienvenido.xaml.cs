using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ReconocimientoFacial.Modelos;

namespace ReconocimientoFacial.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bienvenido : ContentPage
    {
        Usuario usuario;

        public Bienvenido(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            imagen.Source = ImageSource.FromFile(usuario.FotoActual);
            lblMensaje.Text = usuario.MensajeBienvenida;
        }
    }
}