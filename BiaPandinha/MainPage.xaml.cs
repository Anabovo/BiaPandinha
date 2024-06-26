﻿using Microsoft.Maui.Controls;

namespace BiaPandinha;

public partial class MainPage : ContentPage
{
    Animais atual;

	Girafa Gigi = new Girafa();

	Lobinho Luke = new Lobinho();

	Bambi Bambi = new Bambi();
	public MainPage()
	{
		InitializeComponent();
        atual = Gigi;

    imgAnimais.Source=atual.GetArquivo();

		var timer=Application.Current.Dispatcher.CreateTimer();
		timer.Interval=TimeSpan.FromSeconds(2);
		timer.Tick+=(s,e)=> DescerBarra();
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
		imgAnimais.Source=atual.GetArquivo();
	}
   void AtualizarBarra()
   {
    progressobrinquedo.Progress = atual.GetBrincar();
	progressocarne.Progress = atual.GetComer();
	progressoagua.Progress = atual.GetBeber();

   }
  void brincaranimalfoiclicado(object sender, EventArgs args)
  {
	atual.SetBrincar(atual.GetBrincar()+0.1);
	AtualizarBarra();
  }
//---------------------------------------------------------------------
  void comeranimalfoiclicado(object sender, EventArgs args)
  {
	atual.SetComer(atual.GetComer()+0.1);
	AtualizarBarra();
  }
//-----------------------------------------------------------------------------------------------------
  void beberanimalfoiclicado(object sender, EventArgs args)
  {
	atual.SetBeber(atual.GetBeber()+0.1);
	AtualizarBarra();
  }
//--------------------------------------------------------------------------------------------------
   void DescerBarra()
   {
	atual.SetComer(atual.GetComer() - 0.04);
	progressocarne.Progress = atual.GetComer();

	atual.SetBeber(atual.GetBeber() - 0.04);
	progressoagua.Progress = atual.GetBeber();

	atual.SetBrincar(atual.GetBrincar() - 0.04);
	progressobrinquedo.Progress = atual.GetBrincar();
    
	AtualizarBarra();
	if (Gigi.Get)
   }
   

}

