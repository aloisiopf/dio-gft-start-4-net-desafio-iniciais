using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
              int x = int.Parse(Console.ReadLine());
              if (x==0) {
                break;
              } else {
                if (x%2==0){
                  Console.WriteLine(Soma(x));
                } else {
                  Console.WriteLine(Soma(x+1));
                }
              }
            }//fim do while
        }//fim do método main
        
        /*
          Metódo Soma recebe um inteiro e retorna a soma dos 5 pares consecultivos
          a variável i é utilizada para receber os próximos valores pares
        */
        
        static int Soma(int i){
          int soma = i;
          for (int c = 1; c < 5; c++){
            i+=2;
            soma += i;
          }
          return soma;
        }
        
    }//fim da classe
}//fim do namespace