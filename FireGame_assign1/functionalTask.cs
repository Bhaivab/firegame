using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGame_assign1
{
    
   public class functionalTask
    {
        public static int Start = 0;
        public int bullet = 0;
        public int shootCount = 0,shotAway=0,rndom=0,rndomShoot=0;
        public int winer = 0,winnershot=0;
        //instance of the random class to generate the random no 
        Random rd = new Random();

        public void ClkStart(Button btn) {

            Start++;
            if (Start == 1)
            {
                
                btn.Text = "End Game ";
            }
            else {
                Application.Exit();
                Start = 0;
            }
            
        }
        //this method is used to load the bullets in chamber 
        public int loadBullet() {

            //genreate the random no to copmare the shoot
            rndom = rd.Next(1, 6);
            rndomShoot = rd.Next(1, 4);

            bullet = 4;
            return bullet;
        }

        //calling the method of the shoot button
        public void clkShoot(Button btn) {
            shootCount++;
            //genreate the sound of the bullet 
            System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(FireGame_assign1.Properties.Resources.fire);
            Sound.Play();

            if (shootCount == rndom) {
                winer = 1;
                //if the trigger at the point then the player will die and lose the game 
                MessageBox.Show("You Lose the Game ");
                btn.Enabled = false;
            }
            //when the player trigger 4 time but he doesnot die then he is the winner
            if (shootCount==4 && winer==0) {
                MessageBox.Show("You won the Game and got 100 marks");
                btn.Enabled = false;
            }
            
        }

        //next click for hte shoot away 
        public void clkShtAway(Button btn) {
            shotAway++;
            //genreate the sound of the bullet 
            System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(FireGame_assign1.Properties.Resources.fire);
            Sound.Play();

            if (shotAway == rndomShoot)
            {
                winnershot = 1;
                //if the trigger at the point then the player will die and lose the game 
                MessageBox.Show("You Lose the Game ");
                btn.Enabled = false;
            }
            //when the player trigger 4 time but he doesnot die then he is the winner
            if (shotAway == 2 && winer == 0)
            {
                MessageBox.Show("You won the Game and got 100 marks");
                btn.Enabled = false;
            }
        }
    }
}
