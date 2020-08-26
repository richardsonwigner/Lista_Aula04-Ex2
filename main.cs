using System;

class MainClass {

  public static double  V (int P,int Q) {
    double r=0;
    if(P == 100){
      r = 1.7 * Q;
    }
    else if(P == 101){
      r = 2.3 * Q;
    }
    else if(P == 102){
      r = 2.6 * Q;
    }
    else if(P == 103){
      r = 2.4 * Q;
    }
    else  if(P == 104){
      r = 2.5 * Q;
    }
    else if(P == 105){
      r = 1.0 * Q;
    }
    else{
    Console.WriteLine("Codigo Invalido");
    }
   return r;
  }

  public static void Main (string[] args) {
     int P;
     int Q; 
     
      Console.WriteLine("100  Cachorro quente   R$ 1,70");
      Console.WriteLine("101   Bauru Simples    R$ 2,30");
      Console.WriteLine("102   Bauru com ovo    R$ 2,60");
      Console.WriteLine("103   Hamburguer       R$ 2,40");
      Console.WriteLine("104   Cheeseburguer    R$ 2,50");
      Console.WriteLine("105   Refrigerante     R$ 1,00");
      Console.WriteLine("Digite o codigo do produto de sua escolha");

      P = int.Parse(Console.ReadLine());
      Console.WriteLine("Escolha a Quantidade");
      Q = int.Parse(Console.ReadLine());

    double total = V(P,Q);

    Console.WriteLine("O valor da compra é {0}",total);

          
  }
}