using System;

  namespace Classificacao
  {
    class Jogo
    {
      public string titulo;
      public string genero;
      public string produto;
      public string preco;
  
      public void Abrir()
      {
        Console.WriteLine("Abrindo...");
      }
  
      public void Carregar()
      {
        Console.WriteLine("Carregando!");
      }
  
      public void Fechar()
      {
        Console.WriteLine("Aperte ESC para sair");
      }
   }
}
