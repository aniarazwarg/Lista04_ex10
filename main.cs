using System;
// Escrever um algoritmo para ler uma temperatura em Fahrenheit e apresentá-la convertida em  graus Centígrados. (Fahrenheit 32) x 5 Fórmula: Centígrados =9   
class Program {
  public static void Main (string[] args) {
   double C, F; 
  do{
   Console.WriteLine("Digite a temperatura em °F: "); 
    F=double.Parse(Console.ReadLine());
  
    C = (F-32)/ 1.8;
    Console.WriteLine("{0:F2}°C.", C); 
  }while(C==0&&C<0&&C>0);
  }
}