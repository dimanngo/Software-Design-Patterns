using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StatePattern.Context;
using StatePattern.StateBase;

namespace StatePattern.ConcreteStates
{
    public class MoviePlayingState:DVDPlayerState
    {
        public MoviePlayingState()
        {
            Console.WriteLine("MOVIE PLAYING");
        }

        public override void PlayButtonPressed(DVDPlayer player)
        {
            player.State = new MoviePausedState();
        }

        public override void MenuButtonPressed(DVDPlayer player)
        {
            player.State = new MenuState();
        }
    }
}
