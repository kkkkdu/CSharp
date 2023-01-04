namespace System
{
    class Program{
        static void Main(string[] args){
           Menu();
           
    
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("Olá, qual a operação desejada ?");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Divisão");
            Console.WriteLine("3- Subtração");
            Console.WriteLine("4- Multiplicação");
            Console.WriteLine("------------------ ");
            Console.WriteLine(" ");
            Console.WriteLine("Selecione uma opção: ");
            short escolha = short.Parse(Console.ReadLine());
            switch  (escolha){
             case 1: Soma();
             case 2: Divisao();
             case 3: Subtracao();
             case 4: Multiplicacao();


            }
            
               
                
            
        }
        static void Soma(){
            
            Console.WriteLine("Insira o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine ("Insira o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1+valor2;

            Console.WriteLine("  ");
            Console.WriteLine("O resultado da soma é: " + resultado);
           /*Seria possivel realizar a interpolação da soma com o "$" no inicio Ex: Console.WriteLine($"O resultado da soma é: " {valor1+valor2}); 
           Também é possivel Console.WriteLine("O resultado da soma é: (v1+v2));*/

           Console.ReadKey();//Não encerrar a aplicação após a execução
        }
        static void Divisao(){     
            Console.WriteLine("Insira o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine ("Insira o segundo valor: "); 
            float valor2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine (" ");
            Console.WriteLine($"O Resultado da divisão é: {valor1/valor2}");
            Console.ReadKey();//Não encerrar a aplicação após a execução

        }
        static void Subtracao(){
            Console.WriteLine ("Insira o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine ("Insira o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine ("O resultado da subtração é de: " + (valor1-valor2));
            Console.ReadKey();//Não encerrar a aplicação após a execução

        }
        static void Multiplicacao(){
            Console.WriteLine("Insira o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            float resultado = valor1*valor2;
            Console.WriteLine("O resulltado da multiplicação é: " + resultado);

        }

    }
    
}