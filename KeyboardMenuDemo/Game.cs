using System;
using static System.Console;
namespace KeyboardMenuDemo
{
    public class Game
    {

        public void Start()
        {
            Title = "Menu Generator";

            newMenu();
        }

        // Here's all the logic you need to work with!

        private void newMenu()
        {
            string prompt = "Entry prompt goes here";
            string[] options = { "Type", "each", "option", "here", "seprately" };
            Menu newMenu = new Menu(prompt, options);
            int selectedIndex = newMenu.Run();
            WriteLine($"Your selected option is {options[selectedIndex]}, and your option number is {selectedIndex + 1}!");
        }
    }
}
