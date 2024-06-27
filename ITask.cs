namespace CountingMonkeys
{
    internal interface ITask
    {
        int CorrectAnswer {get; }
        public abstract void DisplayQuestion();
    }
}