using CadastroEventos.Models;

namespace CadastroEventos.Views;

public partial class CadastroEvento : ContentPage
{
	App PropriedadesApp;
	public CadastroEvento()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		dt_inicio.MinimumDate = DateTime.Now;
		dt_termino.MinimumDate = DateTime.Now;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {	try
		{
			Evento evento = new Evento
            {
               Nome = nome_evento.Text,
                DataInicio = (DateTime)dt_inicio.Date,
                DataTermino = (DateTime)dt_termino.Date,
				NumeroParticipantes = Convert.ToInt32(n_participantes.Text),
                Local = l_evento.Text,
				Custo = Convert.ToDouble(c_participante.Text)
            };
            await Navigation.PushAsync(new EventoCadastrado()
			{
				BindingContext = evento
			});

		}
		catch (Exception ex) 
		{
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}