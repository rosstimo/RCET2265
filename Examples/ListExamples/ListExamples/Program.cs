namespace ListExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // constructor
            List<string> names = new List<string>();

            //add to the end of the list
            names.Add("Jim");
            names.Add("Bob");
            names.Add("Mary");
            names.Add("Jill");
            names.Add("Frank");
            names.Add("Billy");
            names.Add("Pam");
            names.Add("Sheila");
            names.Add("Jerry");


            //get the first index number for "Billy"
            Console.WriteLine(names.IndexOf("Billy"));

            // insert item to an exact index in the middle
            // all higher indexes shift up
            names.Insert(5, "Dave");

            //remove an item by value
            //higher indexes shift down
            names.Remove("Jill");

            //remove an item by index
            //higher indexes shift down
            names.RemoveAt(5);

            //sort by value
            names.Sort();

            // iterate through the whole list
            foreach (string name in names)
            {
                Console.WriteLine($"{name} is at index: {names.IndexOf(name)}");
            }

            Console.Read();
        }
    }
}
