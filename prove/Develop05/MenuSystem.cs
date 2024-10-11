using Microsoft.VisualBasic;

namespace Develop05
{
    public class MenuSystem
    {
        private Array _options;
        

        public MenuSystem()
        {
            _options = Enum.GetValues(typeof(MenuOptions));
        }

        public void DisplayMenuSystem()
        {
            Console.Clear();
            Console.WriteLine("Menu options:");

            foreach (var item in _options)
            {
                int option = (int)item;
                Console.Write($"\t{option}. ");

                if (option == (int)MenuOptions.Quit)
                    Console.WriteLine($"{item}");
                else
                    Console.WriteLine($"Start {item} activity");
            }
            Console.Write("Select an option from the menu: ");
        }
    }
}