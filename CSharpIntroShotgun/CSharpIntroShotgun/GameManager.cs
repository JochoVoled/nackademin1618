using Shotgun.Actors;
using System;
using System.Windows.Forms;

namespace Shotgun {
    public static class GameManager {
        public static Player player = new Player();
        public static Opponent opponent = new Opponent();

        public static void GameLoop() {
            if(player.isAlive && opponent.isAlive) {
                opponent.action = opponent.SelectAction(player);
                PlayTurn(player, opponent);
                PlayTurn(opponent, player);
                if(!player.isAlive || !opponent.isAlive) {
                    if(!player.isAlive && opponent.isAlive) {
                        EndScreen end = new EndScreen("Thrust back, the world faded");
                        end.Show();
                    } else if(!opponent.isAlive && player.isAlive) {
                        EndScreen end = new EndScreen("A rival down, the sun sets");
                        end.Show();
                    } else {
                        EndScreen end = new EndScreen("And so, both duelists fell");
                        end.Show();
                    }
                }
            }
        }

        public static void RenderGui(Form1 gui) {
            player.FilterAction(gui);
            DisplayPlayerAmmo(gui);
            DisplayOpponentAmmo(gui);
            DisplayTurnReport(gui);
        }

        private static void DisplayTurnReport(Form1 gui) {
            if(player.action == null) {
                gui.txtTurnReport.Text = string.Format("As the sun sets, a deadly duel commence");
            } else {
                gui.txtTurnReport.Text = string.Format("You {0}, Opponent {1}s", player.action, opponent.action);
            }
        }

        private static void DisplayOpponentAmmo(Form1 gui) {
            if(opponent.ammo == 0) {
                gui.txtOpponentAmmo.Text = string.Format("Opponent\'s shotgun is empty");
            } else if(opponent.ammo == 3) {
                gui.txtOpponentAmmo.Text = string.Format("Opponent\'s shotgun is fully loaded");
            } else {
                gui.txtOpponentAmmo.Text = string.Format("Opponent\'s ammo is {0}/3 filled", opponent.ammo);
            }
        }

        private static void DisplayPlayerAmmo(Form1 gui) {
            if(player.ammo == 0) {
                gui.txtPlayerAmmo.Text = string.Format("Your shotgun is empty");
            } else if(player.ammo == 3) {
                gui.txtPlayerAmmo.Text = string.Format("Your shotgun is fully loaded");
            } else {
                gui.txtPlayerAmmo.Text = string.Format("Your ammo is {0}/3 filled", player.ammo);
            }
        }

        private static void PlayTurn(Actor me, Actor other) {
            /* Ladda  ladda   Båda spelarna får ett skott
             * Ladda  blocka  Spelaren som laddar får ett skott
             * Blocka blocka  Ingenting händer
             * Skjuta blocka  Spelaren som skjuter förlorar ett skott
             * Skjuta skjuta  Båda spelarna förlorar ett skott
             * Skjuta ladda   Spelaren som skjuter vinner spelet
            */
            if(me.action == "fire") {
                if(other.action == "load") {
                    other.isAlive = false;
                    return;
                }
                me.ammo--;
                return;
            } else if(me.action == "load") {
                me.ammo++;
                return;
            } else if(me.action == "block") {
                return;
            } else if(me.action == "shotgun") {
                other.isAlive = false;
                return;
            } else{
                throw new InvalidOperationException();
            }
        }
    }
}