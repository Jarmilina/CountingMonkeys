namespace CountingMonkeys
{
    public class TaskCountingObjects: ITask
    {
        public int NumberOfObjects { get; private set; }
        public int ShapeOfObjects { get; private set; }
        public string Shape { get; set;  }
        public string ShapeName { get; set; }
        public List<int> ObjectsToCount { get; set; }
        public int CorrectAnswer { get { return ObjectsToCount.Count; } }


        public TaskCountingObjects()
        {
            Random rand = new Random();
            NumberOfObjects = rand.Next(1, 7);
            ShapeOfObjects = rand.Next(1, 4);
            ObjectsToCount = new List<int>();
            for (int i = 0; i < NumberOfObjects; i++)
            {
                ObjectsToCount.Add(i + 1);
            }

            switch (ShapeOfObjects)
            {
                case 1:
                    Shape = " * ";
                    ShapeName = "hvězdičky";
                    break;
                case 2:
                    Shape = " <3 ";
                    ShapeName = "srdíčka";
                    break;
                case 3:
                    Shape = " :) ";
                    ShapeName = "smajlíky";
                    break;
            }
        }

        public void DisplayQuestion()
        {
            Console.WriteLine($"Spočítej {ShapeName}:");
            Console.WriteLine("");
            foreach (var o in ObjectsToCount)
            {
                Console.Write($"{Shape}");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}