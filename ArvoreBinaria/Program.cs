namespace ArvoreBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            
            for (int i = 0; i < 11; i++) {
                Console.WriteLine("Digite um numero: ");
                var valor = Console.ReadLine();
                tree.Insert(Convert.ToInt32(valor));
            }

            tree.Invert();

            Console.ReadKey();
        }
    }
}
