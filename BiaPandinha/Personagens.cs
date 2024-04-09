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
      public void SetComer(double f)
      {
        if(f>1)
        fome=1;
        else if (f<=0)
      }

      public double GetComer()
      {
        return fome;
      }

      public Void SetBeber
      {
        sede=s;
      }

      public double GetBeber
      {
        return sede;
      }

      public void SetBrincar()
      {
        alegria=a;
      }

      public double GetBrincar()
      {
        return alegria;
      }
}