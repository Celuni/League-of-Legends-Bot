﻿
using System;
using System.Collections.Generic;
using System.Drawing;
using LeagueBot.Patterns;

namespace LeagueBot
{
    public class EndCoop : PatternScript
    {
        
        public override void Execute()
        {
            bot.initialize(); // scripts are isolated.

            bot.log("Match ended.");

            client.onGameEnd();
            
            bot.waitProcessOpen(CLIENT_PROCESS_NAME);

            bot.bringProcessToFront(CLIENT_PROCESS_NAME);
            bot.centerProcess(CLIENT_PROCESS_NAME);

            bot.wait(10 * 1000);
            
            bot.executePattern("StartCoop");
        }
    }
}
