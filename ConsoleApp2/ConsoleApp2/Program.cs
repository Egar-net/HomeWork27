namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);

            queue.VisualizeData();

            int element = queue.Dequeue();
            Console.WriteLine("Исключен из очереди элемент: " + element);

            queue.VisualizeData();

            element = 10;
            queue.Enqueue(element);
            Console.WriteLine("Поставлен в очередь элемент: " + element);

            queue.VisualizeData();
        }
    }
}