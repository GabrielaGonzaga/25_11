using System;

namespace _25_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---Sistema de passagens aéreas---");
            Console.WriteLine("---------------------------------");


            bool senhaValida = false;

            do
            {
            Console.WriteLine("Digite sua senha");
            string senha = Console.ReadLine();
            senhaValida = EfetuarLogin(senha);
            
            } while (!senhaValida);
            
            

            //Funções 
            bool EfetuarLogin(string senha){
                
                if(senha == "123456"){
                    return true;
                }
                else{
                    Console.WriteLine("Senha incorreta");
                    return false;
                }
            }

            

        }
    }
}
