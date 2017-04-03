using System;
using StatePattern.Context;
using StatePattern.StateBase;

namespace StatePattern.ConcreteStates
{
    public class StandbyState:DVDPlayerState
    {
        public StandbyState()
        {
            Console.WriteLine("STANDBY");
        }

        public override void PlayButtonPressed(DVDPlayer player)
        {
            player.State = new MoviePlayingState();
        }

        public override void MenuButtonPressed(DVDPlayer player)
        {
            player.State = new MenuState();
        }
    }
}
