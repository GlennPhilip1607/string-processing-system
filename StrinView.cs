using System;
using StringProcessingApp.Services;

namespace StringProcessingApp.Views
{
    public class StringView
    {
        private readonly StringService service = new StringService();

        public void Run()
        {
            int choice;
            do
            {
                ShowMenu();
                Console.Write("Enter choice: ");
                if (!int.TryParse(Console.ReadLine(), out choice)) continue;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter text: ");
                        service.SetText(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine($"Current Text: {service.GetText()}");
                        break;
                    case 3:
                        service.UpdateText(service.ToUppercase());
                        Console.WriteLine("Converted to UPPERCASE.");
                        break;
                    case 4:
                        service.UpdateText(service.ToLowercase());
                        Console.WriteLine("Converted to lowercase.");
                        break;
                    case 5:
                        Console.WriteLine($"Character Count: {service.CountCharacters()}");
                        break;
                    case 6:
                        Console.Write("Enter word to check: ");
                        string word = Console.ReadLine();
                        Console.WriteLine(service.ContainsWord(word)
                            ? "Word found!"
                            : "Word not found.");
                        break;
                    case 7:
                        Console.Write("Enter word to replace: ");
                        string oldWord = Console.ReadLine();
                        Console.Write("Enter new word: ");
                        string newWord = Console.ReadLine();
                        service.UpdateText(service.ReplaceWord(oldWord, newWord));
                        Console.WriteLine("Word replaced.");
                        break;
                    case 8:
                        Console.Write("Enter start index: ");
                        int start = int.Parse(Console.ReadLine());
                        Console.Write("Enter length: ");
                        int length = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Substring: {service.ExtractSubstring(start, length)}");
                        break;
                    case 9:
                        service.UpdateText(service.TrimSpaces());
                        Console.WriteLine("Spaces trimmed.");
                        break;
                    case 10:
                        service.ResetText();
                        Console.WriteLine("Text reset to original.");
                        break;
                    case 11:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 11);
        }

        private void ShowMenu()
        {
            Console.WriteLine("=== String Processing System ===");
            Console.WriteLine("1. Enter Text");
            Console.WriteLine("2. View Current Text");
            Console.WriteLine("3. Convert to UPPERCASE");
            Console.WriteLine("4. Convert to lowercase");
            Console.WriteLine("5. Count Characters");
            Console.WriteLine("6. Check if Contains Word");
            Console.WriteLine("7. Replace Word");
            Console.WriteLine("8. Extract Substring");
            Console.WriteLine("9. Trim Spaces");
            Console.WriteLine("10. Reset Text");
            Console.WriteLine("11. Exit");
        }
    }
}
