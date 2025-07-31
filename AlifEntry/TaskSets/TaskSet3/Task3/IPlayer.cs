namespace AlifEntry.TaskSets.TaskSet3.Task3
{
    public interface IPlayer
    {
        string Name { get; }
        int Number { get; }
        string Team { get; }
        string Position { get; }
        int Score { get; }
        int Assists { get; }

        void ScorePoint();
        void AssistTo(IPlayer player);
        void GetInfo();
    }
}
