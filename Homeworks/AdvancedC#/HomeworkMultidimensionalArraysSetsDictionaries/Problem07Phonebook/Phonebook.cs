namespace Problem07Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "search")
            {
                var contact = input.Split('-');

                if (phonebook.ContainsKey(contact[0]))
                {
                    phonebook[contact[0]].Add(contact[1]);
                }
                else
                {
                    phonebook.Add(contact[0], new List<string>() { contact[1] });
                }
                
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "exit")
            {
                foreach (var key in phonebook.Keys)
                {
                    if (phonebook.ContainsKey(input))
                    {
                        var keyName = phonebook[key];

                        foreach (var numberAsString in keyName)
                        {
                            Console.WriteLine("{0} -> {1}", key, numberAsString);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input);
                    }

                    input = Console.ReadLine();
                }
            }
        }
    }
}
