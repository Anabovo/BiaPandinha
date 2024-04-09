using Microsoft.Maui.Controls;

namespace BiaPandinha;

public partial class MainPage : ContentPage
{
    Animation atual;

	Girafa Gigi = new Girafa();

	Lobinho Luke = new Lobinho();

	Bambi Bambi = new Bambi();
	public MainPage()
	{
		InitializeComponent();
        atual = Gigi;
		AtualizarPersonagem();
		var timer=Application.Current.Dispatcher.CreateTimer();
		timer.Interval=TimeSpan.FromSeconds(5);
		timer.Tick+=(s,e)=>
		PassouTempo();
		timer.Start();
	}
	void mudaranimalfoiclicado(object sender, EventArgs args)
	{
		if(atual==Gigi)
		{
			atual=Luke;
		}
		else if(atual==Luke)
		{
			atual=Bambi;
		}
		else if(atual==Bambi)
		{
			atual=Gigi;
		}
		imgPersonagem.Source=atual.GetArquivo();
	}
   void AtualizarBarra()
   {
    progressobrincar.Progress=atual.GetBrincar();
	progressocomer.Progress=atual.GetComer();
	progressobeber.Progress=atual.GetBeber();

   }
  void brincaranimalfoiclicado(object sender, EventArgs args)
  {
	atual.SetBrincar(atual.GetBrincar()+0.1);
	AtualizarBarra();
  }

  void comeranimalfoiclicado(object sender, EventArgs args)
  {
	atual.SetComer(atual.GetComer()+0.1);
	AtualizarBarra();
  }

  void beberanimalfoiclicado(object sender, EventArgs args)
  {
	atual.SetBeber(AtualizarBarra.GetBeber()+0.1);
	AtualizarBarra();
  }
}

