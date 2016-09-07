namespace Shotgun.Actors {
    public class Player: Actor {

        public void FilterAction(Form1 gui) {
            if(ammo==0) {
                gui.cmdFire.Enabled = false;
            } else {
                gui.cmdFire.Enabled = true;
            }
            
            if(ammo<3) {
                gui.cmdShotgun.Enabled = false;
            } else {
                gui.cmdShotgun.Enabled = true;
            }

            if(ammo >= 3) {
                gui.cmdLoad.Enabled = false;
            } else {
                gui.cmdLoad.Enabled = true;
            }
        }
    }
}
