namespace FruttiCsharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            String[] frutti = { "Pera", "Mela", "Banana", "Melograno", "Arancia" };
            ShowArrayInfo(frutti);
        }
        private static void ShowArrayInfo(Array arr)
        {
            Console.WriteLine("Lunghezza classifica dei miei frutti: {0,4}", arr.Length);

            Console.WriteLine("I miei frutti preferiti in ordine (dal migliore al peggiore) sono: Melograno, Pera, Mela, Banana, Arancia");

            Console.WriteLine("Il mio frutto preferito è: Melograno");

            Console.WriteLine("Il mio ultimo frutto preferito è: Arancia");

        }
    }
}

