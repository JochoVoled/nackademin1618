using System;
using System.Collections.Generic;

namespace Shotgun.Actors {
    public class Opponent: Actor {
        public string SelectAction(Player player) {
            var options = new List<string> { "load", "block"};
            if(player.ammo==0) {
                options.Remove("block");
            }
            if(player.ammo>ammo) {
                options.Add("fire");
                options.Add("load");
            }
            if(ammo > 0 && ammo <3) {
                options.Add("fire");
            } else if(ammo >= 3) {
                options.Remove("load");
                options.Add("shotgun");
            }
            Random dice = new Random();
            var select = dice.Next() % options.Count;
            return options[select];
        }
    }
}
