namespace BinarySearchTreeAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Practice problems!!!");            
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);            
                    binarySearch.Insert(30);
                    binarySearch.Insert(70);
                    binarySearch.Display();                                            
        }
    }
    
}