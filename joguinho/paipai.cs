namespace joguinho;

public class Pai 
{
    public  int fome;
     public  int sede;
      public  int carinho;


      public Pai()
    {
        fome = 0;
        sede = 0;
        carinho = 0;
    
    }

    public void SetFome(int f)
    {
       
        if (f <= 1 || f >= 0)
         fome = f;
        else if (f > 1)
         fome = 1;
        else
         fome = 0;
    
    }
     
     public int GetFome()
     {
        return sede;
     }


      public void SetSede(int s)
    {
       
        if (s <= 1 || s >= 0)
         sede = s;
        else if (s > 1)
         sede = 1;
        else
         sede = 0;
    
    }
     
     public int GetSede()
     {
        return sede;
     }

      public void SetCarinho(int c)
    {
       
        if (c <= 1 || c >= 0)
         carinho = c;
        else if (c > 1)
         carinho = 1;
        else
         carinho = 0;
    
    }
     
     public int GetCarinho()
     {
        return carinho;
     }
}

