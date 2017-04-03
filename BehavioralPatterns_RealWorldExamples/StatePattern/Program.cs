using StatePattern.Context;

namespace StatePattern
{
    class Program
    {
        static void Main()
        {
            var player = new DVDPlayer();

            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
        }
    }
}
