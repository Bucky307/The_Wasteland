using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace The_Wasteland
{
    public partial class PlayBoard : Form
    {


        ///////////// Class Variables /////////////


        Random rand = new Random();
        int seconds = 0;
        int minutes = 0;
        int TextCounter = 0;

        string input;
        bool StartFlag = false;

      


        int Scavenge = -1;
       
        int randEcount = -1;
        string monster;
        int monsterHealth;
        bool monsterWin = false;

        string[] Itemdrop = { ".", "." };
        bool ItemFull0 = false;
        bool ItemFull1 = false;

        int PlayerHealth = 100;
        int PlayerWater = 100;
        int PlayerHunger = 100;

        string ItemAction;
        int ItemActionAmount;
        int ItemDurability = 3;

        string[] ItemList = System.IO.File.ReadAllLines(@"E:\Wasteland New Copy\The Wasteland\Items.txt");
        string[] MCommment = System.IO.File.ReadAllLines(@"E:\Wasteland New Copy\The Wasteland\MovementComentary.txt");
        string[] Creature = System.IO.File.ReadAllLines(@"E:\Wasteland New Copy\The Wasteland\Creature.txt");
        string[] Adjectives = System.IO.File.ReadAllLines(@"E:\Wasteland New Copy\The Wasteland\Adjectives.txt");

        string[] playerItems = { "none.", "none.", "none."};

        ///////////////////////////////////////////////////////////////////////////

        public PlayBoard()
        {        
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////

        private void PlayBoard_Load(object sender, EventArgs e)
        {
            if (StartFlag)
            {
                PlayerHealth = 100;
                PlayerWater = 100;
                PlayerHunger = 100;
               string[] playerItems = { "none.", "none.", "none."};
                StartFlag = false;
                seconds = 0;
                minutes = 0;
                TextCounter = 0;

                GameTimer.Start();
                
            }
        } // Form Load

        ///////////////////////////////////////////////////////////////////////////
        
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            {
                if (seconds == 60)
                {
                    minutes += 1;
                    seconds = 0;
                }

                if (minutes < 10 && seconds < 10)
                    Timerlb.Text = "Timer: 0" + minutes + ":0" + seconds;
                else if (minutes < 10)
                    Timerlb.Text = "Timer: 0" + minutes + ":" + seconds;
                else if (seconds < 10)
                    Timerlb.Text = "Timer: " + minutes + ":0" + seconds;
                else
                    Timerlb.Text = "Timer: " + minutes + ":" + seconds;
            } // Game Time

            {
                if (seconds % 9 == 0)
                    PlayerWater--;
                if (seconds % 15 == 0)
                    PlayerHunger--;
            } // Hunger and water decrease

            if (PlayerWater <= 0 || PlayerHunger <= 0)
            {
                if (seconds % 7 == 0)
                PlayerHealth--;

                Healthlb.Text = "Health: " + PlayerHealth;
            }

            Foodlb.Text = "Food: " + PlayerHunger.ToString();
            Waterlb.Text = "Water: " + PlayerWater.ToString(); 
            seconds += 1;

            if (PlayerHealth <= 0)
            {

                Healthlb.Text = "Health: 0";
                Waterlb.Text = "Water: 0";
                Foodlb.Text = "Food: 0";

                I1lb.Text = "Item 1: none";
                I2lb.Text = "Item 2: none";
                I3lb.Text = "Item 3: none";

                DisplayBox.Clear();
                DisplayBox.AppendText("- You died.");
                BackgroundTimer.Stop();
                GameTimer.Stop();

            }

        } // Game Timer

        ///////////////////////////////////////////////////////////////////////////

        private void MovementCommentaryTimer_Tick(object sender, EventArgs e)
        {
            
           



            if (TextCounter % 9 == 0 && randEcount == -1)
            {              
                int r = rand.Next(10);
                if (r == 9)
                {
                    randEcount = 0;                   
                    DisplayBox.AppendText( "- Something is approaching...");
                }
            } // Random Encounter

            if (randEcount == -1)
            {
                if (TextCounter % 30 == 0 || TextCounter == 0)
                {
                    DisplayBox.AppendText("- " + MCommment[rand.Next(50)] + Environment.NewLine);
                }

                TextCounter += 3;
            } // Walking Commentary

            else if (randEcount == 3)
            {
                 BackgroundTimer.Stop();
             
                 RandomEncounter();
            } // Spawn the monster

            else if (randEcount < 3)
            {
                DisplayBox.AppendText("  ....");
                randEcount++;
            } // Suspense ....
               

            if (Scavenge == 3)
            {
                BackgroundTimer.Stop();
                ScavengeFind(false);
            } // Spawn ScavengeFind
            else if (Scavenge >=0)
            {
                Scavenge++;
                DisplayBox.AppendText(" ....");
            } // Suspense ...



            

        } // Background Timer

        ///////////////////////////////////////////////////////////////////////////

        private void EnterButton_Click(object sender, EventArgs e)
        {
           
            input = EnterBox.Text.ToLower();
            if (input == "start")
            {
                BackgroundTimer.Start();
                GameTimer.Start();
            }


            
            

            if (monsterWin == true || Scavenge != -1)

           {
                System.Diagnostics.Debug.Write(Itemdrop[0]);
                Scavenge = -1;
                if (input == Itemdrop[0].Substring(0, Itemdrop[0].IndexOf(".")).ToLower())
                {
                    
                    for (int i = 0; i <= 3; i++)
                    {
                        if (i == 3)
                        {
                            System.Diagnostics.Debug.Write("big men");
                            ItemFull0 = true;
                            DisplayBox.AppendText("- What item would you like to replace?" + Environment.NewLine);
                        }
                        else if (playerItems[i] == "none.")
                        {
                            ItemDurability = 3;
                            playerItems[i] = Itemdrop[0];
                            Itemdrop[0] = "";
                            break;
                        }
                    }
                }
                else if (input == Itemdrop[1].Substring(0, Itemdrop[1].IndexOf(".")).ToLower())
                {
                   
                    for (int i = 0; i <= 3; i++)
                    {
                        if (i == 3)
                        {
                            ItemFull1 = true;
                            DisplayBox.AppendText("- What item would you like to replace?" + Environment.NewLine);
                        }
                        else if (playerItems[i] == "none.")
                        {
                            ItemDurability = 3;
                            playerItems[i] = Itemdrop[1];
                            Itemdrop[0] = "";
                            break;
                        }
                    }            

                }
                if (Itemdrop[0] == "" || Itemdrop[1] == "")
                Scavenge = -1;
                else
                {
                    DisplayBox.Text += "- What else would you like to take?" + Environment.NewLine;
                }
                monsterWin = false;
            } // Take an item

            if (input == "replace item #1" && (ItemFull0 ==true || ItemFull1 == true))
            {
                if (ItemFull0 == true)
                    playerItems[0] = Itemdrop[0];
                else
                    playerItems[0] = Itemdrop[1];

                ItemDurability = 3;
                ItemFull0 = false;
                ItemFull1 = false;
            }                   //
            else if (input == "replace item #2" && (ItemFull0 == true || ItemFull1 == true))
            {
                if (ItemFull0 == true)
                    playerItems[1] = Itemdrop[0];
                else
                    playerItems[1] = Itemdrop[1];

                ItemDurability = 3;
                ItemFull0 = false;
                ItemFull1 = false;
            }          // Replace Items
            else if (input == "replace item #3" && (ItemFull0 == true || ItemFull1 == true))
            {
                if (ItemFull0 == true)
                    playerItems[2] = Itemdrop[0];
                else
                    playerItems[2] = Itemdrop[1];

                ItemDurability = 3;
                ItemFull0 = false;
                ItemFull1 = false;
            }          //

          


            if (input == "run" && randEcount == -1)
            {
                DisplayBox.Clear();
                BackgroundTimer.Start();
                Scavenge = -1;
                Statuslb.Text = "Status: Running";
                ItemFull0 = false;
                ItemFull1 = false;
            }
            if (input == "scavenge" && randEcount == -1)
            {
                BackgroundTimer.Start();
                randEcount = 4;       
                DisplayBox.Clear();
                DisplayBox.Text = "You decide to go scavenge for something...";
                Scavenge = 0;
                Statuslb.Text = "Status: Scavenging";
            }
            if (input == "punch" && randEcount != -1)
            {
                RandomEncounterAction(8, "punch");
            }
            if (input == "run away" && randEcount != -1)
            {
                runAway();
            }
            if (input == "use item #1")
            {
                System.Diagnostics.Debug.Write("use itme #1");
                   
                UseItem(0);
                
            }
           if (input == "use item #2")
            {
                UseItem(1);
            }
           if (input == "use item #3")
            {
                UseItem(2);
            }

            {
                I1lb.Text = "Item 1: " + playerItems[0].Substring(0, playerItems[0].IndexOf("."));
                I2lb.Text = "Item 2: " + playerItems[1].Substring(0, playerItems[1].IndexOf("."));
                I3lb.Text = "Item 3: " + playerItems[2].Substring(0, playerItems[2].IndexOf("."));
            } // Item Refresh 

            EnterBox.Clear();
        } // Enter Button
    
      ////////////////////////////////////////////////////////////////////////////
      
        void RandomEncounter()
        {
            DisplayBox.Clear();

           // Monster Stats //
            monster = Adjectives[rand.Next(35)] + " " + Creature[rand.Next(35)];
            monsterHealth = rand.Next(8,20);

            DisplayBox.AppendText( "- A " + monster +" with " + monsterHealth + "HP has stumbbled appon you! What will you do?" + Environment.NewLine);         
            Statuslb.Text = "Status: In Combat";

        } // Random Encounter --> Monster Spawn
  
       ///////////////////////////////////////////////////////////////////////////
      
        void RandomEncounterAction(int damage, string ItemUsed)
        {

           
            int playerDamage = rand.Next(damage);
            int retaliationDamage =  rand.Next(2, monsterHealth + 5);

          

            DisplayBox.AppendText("- You decided to " + ItemUsed + " the " + monster + " which deals " + playerDamage + " damage to it!" + Environment.NewLine);
            monsterHealth -= playerDamage;

           if (monsterHealth <= 0)
            {
                DisplayBox.AppendText("- You killed the " + monster + Environment.NewLine);
                randEcount = -1;
                ScavengeFind(true);
            }
           else
            {
            DisplayBox.AppendText( "- The " + monster + " decides to retaliate! It did " + retaliationDamage + " damage to you!" + Environment.NewLine);
            DisplayBox.AppendText(Environment.NewLine + "- " + monster + ": " + monsterHealth + "HP " + Environment.NewLine + "- What wll you do?" + Environment.NewLine);

            PlayerHealth -= retaliationDamage;
            Healthlb.Text = "Health: " + PlayerHealth.ToString();
           }        
        } // Random Encounter

        ///////////////////////////////////////////////////////////////////////////
       
        void runAway()
        {
            int r = rand.Next(4);
            int delt = rand.Next(monsterHealth / 2);

            if (r == 0)
            {
                DisplayBox.AppendText("- You ran away safely!" + Environment.NewLine);
                randEcount = -1;
               
            }
            else if (r == 1)
            {
                DisplayBox.AppendText("- You ran away, but you took " + delt + " damage" + Environment.NewLine);
                PlayerHealth -= delt;
                randEcount = -1;
               
            }
            else
            {
                DisplayBox.AppendText("- You couldn't run away... and the " + monster + " delt " + delt + " damage to you!" + Environment.NewLine);
                PlayerHealth -= delt;
            }

            Healthlb.Text = "Health: " + PlayerHealth.ToString();
            DisplayBox.AppendText("- What will you do?" + Environment.NewLine);

        } // Run Away Action

        ///////////////////////////////////////////////////////////////////////////
        
        void ScavengeFind(bool MW)
        {
           
            if (MW)
            {
                monsterWin = true;
                int r = rand.Next(50);
                if (r < 15)
                {
                    DisplayBox.AppendText("- The monster droped: nothing" + Environment.NewLine);
                    DisplayBox.AppendText("- What would you like to do?" + Environment.NewLine);
                    monsterWin = false;
                }
                else if (r < 45)
                {
                    Itemdrop[0] = ItemList[rand.Next(25)];
                    DisplayBox.AppendText("- The monster droped: " + Itemdrop[0].Substring(0, Itemdrop[0].IndexOf(".")) + Environment.NewLine);
                    DisplayBox.AppendText("- What would you like to take?" + Environment.NewLine);
                }
                else
                {
                    Itemdrop[0] = ItemList[rand.Next(25)];
                    Itemdrop[1] = ItemList[rand.Next(25)];
                    DisplayBox.AppendText("- The monster droped: " + Itemdrop[0].Substring(0, Itemdrop[0].IndexOf(".")) + " and " + Itemdrop[1].Substring(0, Itemdrop[1].IndexOf(".")) + Environment.NewLine);
                    DisplayBox.AppendText("- What would you like to take?" + Environment.NewLine);
                }

           
            }
            else
            {
                BackgroundTimer.Stop();
                int r = rand.Next(20);
                if (r < 11)
                {
                    DisplayBox.AppendText(Environment.NewLine + "- You found nothing." + Environment.NewLine);
                    DisplayBox.AppendText("- What would you like to do?" + Environment.NewLine);
                    Scavenge = -1;
                }
                else if (r < 18)
                {
                    Itemdrop[0] = ItemList[rand.Next(25)];
                    DisplayBox.AppendText(Environment.NewLine + "- You found: " + Itemdrop[0].Substring(0, Itemdrop[0].IndexOf(".")) + Environment.NewLine);
                    DisplayBox.AppendText("- What would you like to take?" + Environment.NewLine);
                }
                else
                {
                    Itemdrop[0] = ItemList[rand.Next(25)];
                    Itemdrop[1] = ItemList[rand.Next(25)];
                    DisplayBox.AppendText(Environment.NewLine + "- You found: " + Itemdrop[0].Substring(0, Itemdrop[0].IndexOf("."))+ " and " + Itemdrop[1].Substring(0, Itemdrop[1].IndexOf(".")) + Environment.NewLine);
                    DisplayBox.AppendText("- What would you like to take?" + Environment.NewLine);
                }
                PlayerHunger -= rand.Next(7);
                PlayerWater -= rand.Next(8);
                randEcount = -1;
               

                Foodlb.Text = "Food: " + PlayerHunger;
                Waterlb.Text = "Water: " + PlayerWater;
            }


        } // Scavenge Action

        ///////////////////////////////////////////////////////////////////////////

        void UseItem(int x)
        {


            if (playerItems[x] != "none." || monsterWin == false)
            {
                System.Diagnostics.Debug.Write("Sholg");
                if (playerItems[x].Substring(playerItems[x].IndexOf(".") + 1, 1) == "~")
                {
                    System.Diagnostics.Debug.Write("damage");
                    ItemAction = "damage";
                    ItemActionAmount = int.Parse(playerItems[x].Substring(playerItems[x].IndexOf("~") + 1, 2));

                }
                else if (playerItems[x].Substring(playerItems[x].IndexOf(".") + 1, 1) == "-")
                {
                    ItemAction = "healed";
                    ItemActionAmount = int.Parse(playerItems[x].Substring(playerItems[x].IndexOf("-") + 1, 2));
                }
                else if (playerItems[x].Substring(playerItems[x].IndexOf(".") + 1, 1) == "*")
                {
                    ItemAction = "replenished hunger";
                    ItemActionAmount = int.Parse(playerItems[x].Substring(playerItems[x].IndexOf("*") + 1, 2));
                }
                else if (playerItems[x].Substring(playerItems[x].IndexOf(".") + 1, 1) == "^")
                {
                    ItemAction = "replenished water";
                    ItemActionAmount = int.Parse(playerItems[x].Substring(playerItems[x].IndexOf("^") + 1, 2));
                }
            }
            
            if (ItemAction == "damage" && randEcount != -1)
            {
                ItemDurability--;
                System.Diagnostics.Debug.Write("Shark man");
                ItemAction =  playerItems[x].Substring(0, playerItems[x].IndexOf(".")); 
                RandomEncounterAction(ItemActionAmount, "used: " + ItemAction);
                if (ItemDurability == 0)
                playerItems[x] = "none.";
            }
            else if (ItemAction == "healed" && PlayerHealth <= 100)
            {
                DisplayBox.AppendText( "- You healed yourself " + ItemActionAmount + "HP." + Environment.NewLine);
                PlayerHealth += ItemActionAmount;
                playerItems[x] = "none.";
            }
            else if (ItemAction == "replenished hunger" && PlayerHunger + ItemActionAmount <= 100)
            {
                DisplayBox.AppendText("- You replenished " + ItemActionAmount + " hunger points." + Environment.NewLine);
                PlayerHunger += ItemActionAmount;
                playerItems[x] = "none.";
            }
            else if (ItemAction == "replenished water" && PlayerWater + ItemActionAmount <= 100)
            {
                DisplayBox.AppendText("- You replenished " + ItemActionAmount + " water points." + Environment.NewLine);
                PlayerWater += ItemActionAmount;
                playerItems[x] = "none.";
            }
            else
            {
                DisplayBox.AppendText("- Nothing happened" + Environment.NewLine);
            }

            Foodlb.Text = "Food: " + PlayerHunger;
            Waterlb.Text = "Water: " + PlayerWater;
            Healthlb.Text = "Health: " + PlayerHealth;

        }

        ///////////////////////////////////////////////////////////////////////////

        private void EnterButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            EnterButton.PerformClick();
        }
    }
}
