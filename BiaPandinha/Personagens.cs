namespace BiaPandinha;

public class Animais
{
    protected double fome;

    protected double alegria;

    protected double sede;

    protected string Arquivo;

      public Animais()
      {
      }
      public void SetComer(double s)
      {
        if(s>1)
        fome=s;
        else if (s<=0)
        fome=0;
        else
        fome=s;
      }

      public double GetComer()
      {
        return fome;
      }

      public void SetBeber(double s)
      {
        if(s>1)
        sede=s;
        else if (s<=0)
        sede=0;
        else
        sede=s;
      }

      public double GetBeber()
      {
        return sede;
      }

      public void SetBrincar(double s)
      {
        if(s>1)
        alegria=s;
        else if (s<=0)
        alegria=0;
        else
        alegria=s;
      }

      public double GetBrincar()
      {
        return alegria;
      }

      public string GetArquivo()
      {
        return Arquivo;
      }
}