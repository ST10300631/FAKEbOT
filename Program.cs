using System;
using CybersecurityChatbot;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║   Cybersecurity Awareness Chatbot       ║");
        Console.WriteLine("║   Type 'help' for available commands    ║");
        Console.WriteLine("║   Type 'exit' to quit                   ║");
        Console.WriteLine("╚════════════════════════════════════════╝\n");

        ChatBot chatbot = new ChatBot();
        string userInput = "";

        while (userInput.ToLower() != "exit")
        {
            Console.Write("You: ");
            userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
                continue;

            string response = chatbot.GetResponse(userInput);
            Console.WriteLine($"\nChatBot: {response}\n");
        }

        Console.WriteLine("\nThank you for using the Cybersecurity Awareness Chatbot. Stay safe!");
    }
}