namespace SubscriptionAds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            List<User> users = new List<User>
            {
                new User { Login = "user1", Name = "Masha", IsPremium = false },
                new User { Login = "user2", Name = "Pasha", IsPremium = true },
                new User { Login = "user3", Name = "Kolya", IsPremium = false }
            };
            foreach (var user in users)
            {
                Console.WriteLine("Hello " + user.Name);
                if (!user.IsPremium)
                    Ads.ShowAds();
            }
        }
    }
}
