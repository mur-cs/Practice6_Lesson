namespace Practice6.Models
{
    public interface ITimeService
    {
        string GetTime();
    }

    public class TimeService : ITimeService
    {
        public string GetTime()
        {
            Random rand = new Random();
            return $"{DateTime.Now.ToString()} / {rand.Next(0,100)}";
        }
    }
}
