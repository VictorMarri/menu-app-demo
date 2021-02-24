using System;
using static System.Console;

namespace KeyboardMenuDemo
{
    class Game
    {
        public void Start()
        {
            Title = "Aula de POO - 2° Período";
            RunMainMenu();
        }




        private void RunMainMenu()
        {
            string prompt = @"

               
   _____  _  _       __                   _ _          _                 
  / ____|| || |_    /_/                  (_) |        | |                
 | |   |_  __  _|   ___   _ __ ___  _   _ _| |_ ___   | | ___   ___ ___  
 | |    _| || |_   / _ \ | '_ ` _ \| | | | | __/ _ \  | |/ _ \ / __/ _ \ 
 | |___|_  __  _| |  __/ | | | | | | |_| | | || (_) | | | (_) | (_| (_) |
  \_____||_||_|    \___| |_| |_| |_|\__,_|_|\__\___/  |_|\___/ \___\___/ 
                                                                         
                                                                         
                                     
                                                                  


Bem vindo(a)! O que vc deseja? 
(Use as setas do seu teclado entre as opções e tecle enter)";
            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);

            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;

            }
        }

        private void ExitGame()
        {
            WriteLine("\n Pressione qualquer tecla pra sair");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("Esse menu foi criado por Victor Marri.");
            WriteLine("Use os assets do site 'patorjk.com' para simular os escritos em binarios");
            WriteLine("Data: 07/07/2020");
            WriteLine("Tecle qualquer tecla pra voltar ao menu");
            ReadKey(true);
            RunMainMenu();

        }

        private void RunFirstChoice()
        {
            Console.WriteLine("Victor");
            ExitGame();
        }
    }
}
