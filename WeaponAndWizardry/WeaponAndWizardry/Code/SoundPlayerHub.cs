using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// SignalR Hub Class for Sending Commands to clients to play a sound.
    /// Author: 
    ///     Name: Jia Qi Lee (George) Date: 2017-11-15
    /// </summary>
    public class SoundPlayerHub : Hub
    {
        /// <summary>
        /// Sends a command to the client to play a sound
        /// </summary>
        /// <param name="soundUrl">The URL of the sound to play</param>
        public void Play(string soundUrl)
        {
            if (!String.IsNullOrWhiteSpace(SessionHandler.SoundHubConnectionId))
            {
                Clients.Client(SessionHandler.SoundHubConnectionId).play(soundUrl, -1);
            }
        }

        /// <summary>
        /// A method called by the client to register itself to this session.
        /// </summary>
        public void RegisterClient()
        {
            SessionHandler.SoundHubConnectionId = Context.ConnectionId;
            WeaponAndWizardry.Code.WebGameEngine.Clients = GlobalHost.ConnectionManager.GetHubContext<SoundPlayerHub>().Clients;
        }
    }
}