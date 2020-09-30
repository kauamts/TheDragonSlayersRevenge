using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DragonSlayersRevenge
{
    class Player //This is the Player Controller
    {
        //For player choice in town
        int iInnChoice;
        int iShopChoice;
        //current hp
        public int iPlayerHP;
        //players atk
        public int iPlayerATK;
        //players defense
        public int iPlayerDEF;
        //current AP
        public int iPlayerAP;
        //damage done
        private int iPlayerFINAL;
        //max hp
        private int iPlayerMaxHP;
        //max ap
        private int iPlayerMaxAP;
        //players gold
        public int iPlayerGold;
        //players current exp
        public int iCurrentEXP;
        //exp cap 
        public int iEXPCap;
        //players level
        public int iLevel;
        //input for special atk switch
        int iSpecATKInput;
        //players current area #
        public int iCurrentArea;
        //name of weapon
        public string sWeapon;
        //current weapon used in stats readout
        public string sCurrentWeapon;
        //name of armor
        public string sArmor;
        //current weapon used in stats readout
        public string sCurrentArmor;
        //weapon atk modifier
        public int iWeaponMod;
        //armor def modifier
        public int iArmorMod;
        //players name
        string sName;
        //int for total combo hit
        int iComboDamage;
        //random used for attacks
        public Random iPATKRoll = new Random();
        //how much you healed for heal function
        int iHealed;
        //for using skills inside skill menu
        int iSkillMenuInput;
        //detects if player has made their move
        int iPlayerTurn;

        //------------------------------------------ITEMS-------------------------------------//
        // items for the player
        public int iItemChoice;
        // healing potions for the player
        //Item 1
        public int iHPot1;
        //item 2
        public int iHPot2;
        //item 3
        public int iHPot3;
        //item 4
        public int iHPot4;


        // AP potions for the player
        //item 5
        public int iAPPot1;
        //item 6
        public int iAPPot2;
        //item 7
        public int iAPPot3;
        //item 8
        public int iAPPot4;

        // future item expansions below here

        // stat increase items
        // Atk incraese item
        public int iSteroids1;
        //DEF increase item
        public int iIronChest1;
        // Exp increase item
        public int iSmarter1;
        // AP increase item
        public int iPowerHouse1;
        // HP increase Item
        public int iThickSkin1;
        // item  bought in bulk
        public int iItemPurchase;
        //# of item
        public int iItemAmount;
        //------ITEMS-----//




        //constructor function
        public Player(string sTempName)
        {
            //player stats

            sName = sTempName;
            iSpecATKInput = 0;
            iCurrentArea = 0;
            iPlayerMaxAP = 100;
            iPlayerAP = iPlayerMaxAP;
            iPlayerATK = 100;
            iPlayerDEF = 5;
            iPlayerMaxHP = 100;
            iCurrentEXP = 0;
            iEXPCap = 100;
            iLevel = 1;
            iPlayerGold = 250;
            iPlayerHP = iPlayerMaxHP;
            iWeaponMod = 0;
            iArmorMod = 0;
            sArmor = ("Shirt");
            sWeapon = ("Rusty Sword");
            sCurrentArmor = (sArmor+" + "+iArmorMod+" DEF");
            sCurrentWeapon = (sWeapon+" + "+iWeaponMod+" ATK");
            iHPot1 = 3;
            iHPot2 = 1;
            iAPPot1 = 3;
        }


        //---------------------ITEM FUNCTION---------------------------//
        // Calls item from inventory
        public void ItemCall()
        {     // item name
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(sName + ":");
            Console.WriteLine("Level: " + iLevel);
            Console.WriteLine("───────────────────────────────────────────");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("HP: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(iPlayerHP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(iPlayerMaxHP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" AP: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(iPlayerAP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(iPlayerMaxAP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nAttack: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(iPlayerATK);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nDefense: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(iPlayerDEF + "\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("ITEMS: ");

            //Minor Hp restore Function
            if (iHPot1 >= 1)
            {
                //item name to console and what it does or how many player has
                Console.Write("1 = Minor Life Potion (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+100 HP");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iHPot1 + "\n");         // amount player has if any
            }


            // item names

            //Medium HP restore potion
            if (iHPot2 >= 1)
            {
                //item name to console and what it does or how many player has
                Console.Write("2 = Medium Life Potion (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+500 HP");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iHPot1 + "\n");      // amount player has if any
            }


            //Large HP restore potion Function
            if (iHPot3 >= 1)
            {
                //item name to console and what it does or how many player has
                Console.Write("3 = Large Life Potion (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+1000 HP");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iHPot3 + "\n");     // amount player has if any
            }




            //Max HP restore potion Function
            if (iHPot4 >= 1)
            {
                //item name to console and what it does or how many player has
                Console.Write("4 = Maximum Life Potion (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+ Max HP");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iHPot4 + "\n");   // amount player has if any
            }


            // AP restore potion function
            if (iAPPot1 >= 1)
            {
                //item name to console and what it does or how many player has
                Console.Write("5 = Minor AP Potion (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+25 AP");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iAPPot1 + "\n");   // amount player has if any
            }

            // AP restore potion function
            if (iAPPot2 >= 1)
            {
                //item name to console and what it does or how many player has
                Console.Write("6 = Medium AP Potion (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+250 AP");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iAPPot2 + "\n");  // amount player has if any


            }
            // Large AP potion function 
            if (iAPPot3 >= 1)
            {
                //item name to console and what it does or how many player has
                Console.Write("7 = LARGE AP Potion (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+1000 AP");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iAPPot3 + "\n");  // amount player has if any
            }

            // AP restore potion
            if (iAPPot4 >= 1)
            {
                //item name to console and what it does or how many player has
                Console.Write("8 = MAX AP Potion (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+MAX AP");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iAPPot4 + "\n");   // amount player has if any
            }



            //Increase Attack strength permentaly
            if (iSteroids1 >= 1)
            {
                //item name to console and what it does or how many player has
                Console.Write("9 = Steroids Make Me Stronger! (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+ PLACEHOLDER # Attack ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iSteroids1 + "\n");   // amount player has if any
            }

            //Item that Increases Defense permenantly
            if (iIronChest1 >= 1)
            {
                //item name to console and what it does or how many player has
                Console.Write("10 = IronChest Elixer! (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+ PLACEHOLDER #  Defense ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iIronChest1 + "\n");  // amount player has if any
            }

            //item that increases EXP permenantly
            if (iSmarter1 >= 1)
            {
                //item name to console and what it does or how many player has
                Console.Write("11 = Wisdom Elixer! (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+ PLACEHOLDER # EXP ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iSmarter1 + "\n");  // amount player has if any
            }
            //Increases Map AP permenantly
            if (iPowerHouse1 >= 1)
            {
                //item name to console and what it does or how many player has
                Console.Write("12 = PowerHouse Elixer! (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+ PLACEHOLDER # MAX AP ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iPowerHouse1 + "\n"); // amount player has if any
            }
            // increases max HP permenantly
            if (iThickSkin1 >= 1)
            {   //item name to console and what it does or how many player has
                Console.Write("13 = Thick Skinned Elixer! (");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("+ PLACEHOLDER # MAX HP ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(") ");
                Console.WriteLine("     Quantity: x" + iThickSkin1 + "\n"); // amount player has if any
            }







            //-------------------------------------------------------------ITEM USE SWITCH-----------------------------------//



            ///what u wanna use?
            Console.WriteLine("0 = EXIT");
            Console.WriteLine("\n \n \n  WHAT ITEM DO U WANNA USE? ");
            ///convert readline to switch
            Console.Write("\nChoice ");
            Console.ForegroundColor = ConsoleColor.Green;
            iItemChoice = 100;
            string iItemChoices = Console.ReadLine();
            if (iItemChoices == "0")
            {
                iItemChoice = 0;
            }
            if (iItemChoices == "1")
            {
                iItemChoice = 1;
            }
            if (iItemChoices == "2")
            {
                iItemChoice = 2;
            }
            if (iItemChoices == "3")
            {
                iItemChoice = 3;
            }
            if (iItemChoices == "4")
            {
                iItemChoice = 4;
            }
            if (iItemChoices == "5")
            {
                iItemChoice = 5;
            }
            if (iItemChoices == "6")
            {
                iItemChoice = 6;
            }
            if (iItemChoices == "7")
            {
                iItemChoice = 7;
            }
            if (iItemChoices == "8")
            {
                iItemChoice = 8;
            }
            if (iItemChoices == "9")
            {
                iItemChoice = 9;
            }
            if (iItemChoices == "10")
            {
                iItemChoice = 10;
            }
            if (iItemChoices == "11")
            {
                iItemChoice = 11;
            }
            if (iItemChoices == "12")
            {
                iItemChoice = 12;
            }
            if (iItemChoices == "13")
            {
                iItemChoice = 13;
            }
            if (iItemChoices == "14")
            {
                iItemChoice = 14;
            }
            if (iItemChoices == "15")
            {
                iItemChoice = 15;
            }
            //iItemChoice = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;
            switch (iItemChoice)
            {
                case 0:
                    {
                        break;
                    }


                case 1:
                    {
                        // Checks player function for Small hp potion in inventory
                        if (iHPot1 >= 1 && iPlayerHP != iPlayerMaxHP)
                        {
                            iPlayerHP = iPlayerHP + 100;  // Hp amount
                            iHPot1--;   // minus from the total potion count


                            // check players max health so potion will not heal above max HP
                            if (iPlayerHP >= iPlayerMaxHP)
                            {

                                iPlayerHP = iPlayerMaxHP;
                            }

                            Console.WriteLine("\nHP Restored");
                            // text to screen how much has been restored

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("+100 HP");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        // if the player makes a bad selection a safeguard.
                        else
                        {
                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }
                        // if current health is less than max health set player health to max health

                        break;
                    }

                case 2:
                    {
                        // Checks player function for Medium hp potion in inventory
                        if (iHPot2 >= 1 && iPlayerHP != iPlayerMaxHP)
                        {
                            iPlayerHP = iPlayerHP + 500;  // Hp amount healed
                            iHPot2--;    // minus from the total potion count

                            // check players max health so potion will not heal above max HP
                            if (iPlayerHP >= iPlayerMaxHP)
                            {
                                iPlayerHP = iPlayerMaxHP;
                            }
                            Console.WriteLine("\nHP Restored");

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("+500 HP");
                            Console.ForegroundColor = ConsoleColor.Gray;



                        }
                        // if the player makes a bad selection a safeguard.
                        else
                        {
                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }


                        break;
                    }


                case 3:
                    {
                        // Checks player function for Large hp potion in inventory
                        if (iHPot3 >= 1 && iPlayerHP != iPlayerMaxHP)
                        {
                            iPlayerHP = iPlayerHP + 1000; // amount of HP healed
                            iHPot3--;   // minus from the total potion count


                            // check players max health so potion will not heal above max HP
                            if (iPlayerHP >= iPlayerMaxHP)
                            {
                                iPlayerHP = iPlayerMaxHP;
                            }
                            // text to screen action has taken place   
                            Console.WriteLine("\nHP Restored");
                            // text to screen how much has been restored

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("+1000 HP");
                            Console.ForegroundColor = ConsoleColor.Gray;


                        }
                        // if the player makes a bad selection a safeguard.
                        else
                        {
                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }



                        break;
                    }

                case 4:
                    {
                        // Checks player function for Max hp potion in inventory
                        if (iHPot4 >= 1 && iPlayerHP != iPlayerMaxHP)
                        {
                            iPlayerHP = iPlayerMaxHP; // amount of HP healed  MAX
                            iHPot4--;  // minus from the total potion count



                            if (iPlayerHP >= iPlayerMaxHP)
                            {
                                iPlayerHP = iPlayerMaxHP;
                            }

                            // text to screen action has taken place   
                            Console.WriteLine("\nHP Restored");
                            // text to screen how much has been restored

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("All HP RESTORED");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }

                            // if the player makes a bad selection a safeguard.
                        else
                        {
                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }


                        break;
                    }

                case 5:
                    {
                        // Checks player function forSmall AP potion in inventory
                        if (iAPPot1 >= 1 && iPlayerAP != iPlayerMaxAP)
                        {
                            iPlayerAP = iPlayerAP + 25;  // AP amount restored
                            iAPPot1--;   // minus from the total potion count



                            // check players max health so potion will not heal above max HP
                            if (iPlayerAP >= iPlayerMaxAP)
                            {
                                iPlayerAP = iPlayerMaxAP;
                            }


                            // text to screen action has taken place   
                            Console.WriteLine("\nAP Restored");
                            // text to screen how much has been restored

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("+25 AP");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }


                        break;
                    }
                case 6:
                    {
                        // Checks player function for Medium AP potion in inventory
                        if (iAPPot2 >= 1 && iPlayerAP != iPlayerMaxAP)
                        {
                            iPlayerAP = iPlayerAP + 150;  // AP amount restored
                            iAPPot2--;  // minus from the total potion count



                            // check players max AP so potion will not Restore above max AP
                            if (iPlayerAP >= iPlayerMaxAP)
                            {
                                iPlayerAP = iPlayerMaxAP;
                            }


                            // text to screen action has taken place   
                            Console.WriteLine("\nAP Restored");
                            // text to screen how much has been restored
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("+150 AP");
                            Console.ForegroundColor = ConsoleColor.Gray;

                        }


                            // if the player makes a bad selection a safeguard.
                        else
                        {
                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }


                        break;
                    }

                case 7:
                    {
                        //Checks player inventory for Large AP Potion
                        if (iAPPot3 >= 1 && iPlayerAP != iPlayerMaxAP)
                        {
                            iPlayerAP = iPlayerAP + 500;  // AP amount restored
                            iAPPot3--;   // minus from the total potion count



                            // check players max AP so potion will not Restore above max AP
                            if (iPlayerAP >= iPlayerMaxAP)
                            {
                                iPlayerAP = iPlayerMaxAP;
                            }


                            // text to screen action has taken place   
                            Console.WriteLine("\nAP Restored");
                            // text to screen how much has been restored
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("+500 AP");
                            Console.ForegroundColor = ConsoleColor.Gray;

                        }
                        // user presses an incorrect key! a failsafe
                        else
                        {
                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }



                        break;
                    }
                case 8:
                    {
                        // checks player inventory for Max AP hp Potion
                        if (iAPPot4 >= 1 && iPlayerAP != iPlayerMaxAP)
                        {
                            iPlayerAP = iPlayerMaxAP;  // AP amount restored
                            iAPPot4--;   // minus from the total potion count



                            // check players max AP so potion will not Restore above max AP
                            if (iPlayerAP >= iPlayerMaxAP)
                            {
                                iPlayerAP = iPlayerMaxAP;
                            }


                            // text to screen action has taken place   
                            Console.WriteLine("\nAP Restored");
                            // text to screen how much has been restored
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("+ALL AP");
                            Console.ForegroundColor = ConsoleColor.Gray;

                        }
                        // user presses an incorrect key! a failsafe
                        else
                        {
                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }



                        break;
                    }
                case 9:
                    {
                        // checks for steroids function item
                        if (iSteroids1 >= 1)
                        {
                            iPlayerATK = iPlayerATK + 10;  // MAX ATTACK increased  CHANGE FOR INCREASE / BALANCE
                            iSteroids1--;   // minus from the total potion count


                            // text to screen action has taken place   
                            Console.WriteLine("\nYou feel like you are capable of kicking more monster ass! ");
                            // text to screen how much has been restored
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("+Atk");
                            Console.ForegroundColor = ConsoleColor.Gray;

                        }
                        // user presses an incorrect key! a failsafe
                        else
                        {
                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }



                        break;

                    }
                case 10:
                    {
                        // checks for function IronChest item
                        if (iIronChest1 >= 1)
                        {
                            iPlayerDEF = iPlayerDEF + 10;  // MAX DEF increased  CHANGE FOR INCREASE / BALANCE
                            iIronChest1--;   // minus from the total potion count


                            // text to screen action has taken place   
                            Console.WriteLine("\nYou feel like your skin is more impenetrable! ");
                            // text to screen how much has been restored
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("+10 Def");
                            Console.ForegroundColor = ConsoleColor.Gray;

                        }
                        // user presses an incorrect key! a failsafe
                        else
                        {
                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }



                        break;
                    }
                case 11:
                    {
                        // checks the function for the ISmarter1 item
                        if (iSmarter1 >= 1)
                        {
                            iCurrentEXP = iCurrentEXP + 1000;  // EXP increased  CHANGE FOR INCREASE / BALANCE
                            iSmarter1--;   // minus from the total potion count




                            // text to screen action has taken place   
                            Console.WriteLine("\nYou feel More Experienced! ");
                            // text to screen how much has been restored
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("+1000 EXP");
                            Console.ForegroundColor = ConsoleColor.Gray;

                            // checks Players current level and will level them up if it passes exp 
                            // threshold so the player will not  have to enter combat.
                            if (iCurrentEXP >= iEXPCap)
                            {
                                LevelUp();
                            }

                        }
                        // user presses an incorrect key! a failsafe
                        else
                        {
                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }



                        break;
                    }

                case 12:
                    {
                        // calls the Increase AP item function
                        if (iPowerHouse1 >= 1)
                        {
                            iPlayerMaxAP = iPlayerMaxAP + 10;  // AP increased  CHANGE FOR INCREASE / BALANCE
                            iPowerHouse1--;   // minus from the total potion count



                            // text to screen action has taken place   
                            Console.WriteLine("\nYou feel like you can use special attacks more! ");
                            // text to screen how much has been restored
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("+10 AP");
                            Console.ForegroundColor = ConsoleColor.Gray;

                        }
                        // user presses an incorrect key! a failsafe
                        else
                        {
                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }
                    }


                    break;

                case 13:
                    {
                        // calls the Increase HP item function
                        if (iThickSkin1 >= 1)
                        {
                            iPlayerMaxHP = iPlayerMaxHP + 15;  // HP increased  CHANGE FOR INCREASE / BALANCE
                            iThickSkin1--;   // minus from the total potion count


                            // text to screen action has taken place   
                            Console.WriteLine("\nYou feel more Like a Meat Sheild! ");
                            // text to screen how much has been restored
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("+15 HP");
                            Console.ForegroundColor = ConsoleColor.Gray;

                        }
                        // user presses an incorrect key! a failsafe
                        else
                        {

                            //plays if player imputs a bad number!!  silly player
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU CANT USE THAT OPTION");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            ItemCall();
                        }
                    }
                    break;

                default:
                    {
                        //plays if player imputs a bad number!!  silly player
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("YOU CANT USE THAT OPTION");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        ItemCall();
                        break;
                    }

            }


        }
        //-----------------------------ITEMS------------------------------//




        //------------------------------------------------------------------LEVEL UP YAY!!!----------------------------------------
        //unlock new special attacks
        public void LevelUp()
        {
            //increases stats
            iLevel++;
            iPlayerMaxHP = iPlayerMaxHP / 4 + iPlayerMaxHP;
            iPlayerMaxAP = iPlayerMaxAP + 15;
            iPlayerATK = iPlayerATK + 15;
            iPlayerDEF = iPlayerDEF + 2;
            if (iLevel >= 1 && iLevel < 10)
            {
                iEXPCap = iEXPCap / 2 + iEXPCap;
            }
            if (iLevel >= 10 && iLevel < 20)
            {
                iEXPCap = iEXPCap / 3 + iEXPCap;
            }
            if (iLevel >= 20 && iLevel < 30)
            {
                iEXPCap = iEXPCap / 4 + iEXPCap;
            }
            if (iLevel >= 30)
            {
                iEXPCap = iEXPCap / 5 + iEXPCap;
            }
            iPlayerAP = iPlayerAP + iPlayerMaxAP /2;
            iPlayerHP = iPlayerHP + iPlayerMaxHP / 2;
            if (iPlayerAP > iPlayerMaxAP)
            {
                iPlayerAP = iPlayerMaxAP;
            }
            if (iPlayerHP > iPlayerMaxHP)
            {
                iPlayerHP = iPlayerMaxHP;
            }
            //level up readout
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\nL");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("E");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("V");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("E");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("L");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" U");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("P");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("!\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            //level up stats
            Console.WriteLine("CURRENT LEVEL: " + iLevel);
            Console.WriteLine("\nYOU GROW STRONGER:\n");
            Console.Write("HP: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(iPlayerHP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(iPlayerMaxHP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" AP: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(iPlayerAP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(iPlayerMaxAP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("ATK: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(iPlayerATK);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("DEF: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(iPlayerDEF);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("EXP: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(iCurrentEXP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(iEXPCap);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("GOLD: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(iPlayerGold);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
            Console.ReadKey();
            if (iLevel == 5 || iLevel == 10 || iLevel == 17 || iLevel == 25)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nYOU'VE LEARNED A NEW SKILL!!");
                if (iLevel == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n\nSKULL CRUSHER ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("(");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("-15 AP");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(")");
                    Console.WriteLine("Good for headaches. Apply to someone else's face when needed.");
                }
                if (iLevel == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n\nHEAL");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("(");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("-25 AP");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(")");
                    Console.WriteLine("With willpower the size of a mountain, you heal just by wishing it.");
                }
                if (iLevel == 17)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n\nMULTI SLASH ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("(");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("-35 AP");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(")");
                    Console.WriteLine("You hit faster then anyone can say 'Oh, shit!'.");
                }
                if (iLevel == 25)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n\nDEATHBLOW ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("(");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("-50 AP");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(")");
                    Console.WriteLine("This one hurts. Seriously, it's not funny.");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                Console.ReadKey();
            }
            Console.Clear();
        }

        //CHECKING STATUS FUNCTION
        public void CheckStatus()
        {
            int iStatusInput;
            Console.Clear();
            Console.WriteLine("STATUS:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(sName + ":");
            Console.WriteLine("Level: " + iLevel);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Current Weapon: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sCurrentWeapon);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Current Armor: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(sCurrentArmor);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("HP: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(iPlayerHP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(iPlayerMaxHP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("AP: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(iPlayerAP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(iPlayerMaxAP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("ATK: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(iPlayerATK);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("DEF: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(iPlayerDEF);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("EXP: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(iCurrentEXP);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(iEXPCap);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("GOLD: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(iPlayerGold);
            Console.ForegroundColor = ConsoleColor.Gray;


            //STATUS CHOICES
            Console.WriteLine();
            Console.WriteLine("1 = USE AN ITEM");
            //SKILLS WITH INFO AND USABLE HEALS
            Console.WriteLine(" 2 = SKILLS");
            Console.WriteLine("  3 = EXIT");
            Console.Write("\nChoice: ");
            Console.ForegroundColor = ConsoleColor.Green;
            iStatusInput = 100;
            string iStatusInputs = Console.ReadLine();
            if (iStatusInputs == "0")
            {
                iStatusInput = 0;
            }
            if (iStatusInputs == "1")
            {
                iStatusInput = 1;
            }
            if (iStatusInputs == "2")
            {
                iStatusInput = 2;
            }
            if (iStatusInputs == "3")
            {
                iStatusInput = 3;
            }
            if (iStatusInputs == "4")
            {
                iStatusInput = 4;
            }
            if (iStatusInputs == "5")
            {
                iStatusInput = 5;
            }
            //iStatusInput = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;
            switch (iStatusInput)
            {
                    //USE AN ITEM
                case 1:
                    {
                        Console.Clear();
                        //USE ITEM FUNCTION
                        ItemCall();
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        Console.Clear();
                        CheckStatus();
                        break;
                    }

                    //CHECK MY SKILLS
                case 2:
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("INFO: USEABLE SKILLS ARE GREEN");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("SKILL LIST:");
                        Console.Write("\nBASH (");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("-5 AP");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(")");
                        Console.WriteLine("Drive your shoulder into the enemy when you attack.");
                        if (iLevel >= 5)
                        {
                            Console.Write("\nSKULL CRUSHER (");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("-15 AP");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine(")");
                            Console.WriteLine("Swing your weapon down onto your enemies head.");
                        }
                        if (iLevel >= 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\n3 = HEAL");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("(");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("-25 AP");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine(")");
                            Console.WriteLine("Restore 1/4 of your max HP.");
                        }
                        if (iLevel >= 17)
                        {
                            Console.Write("\nMULTI SLASH (");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("-35 AP");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine(")");
                            Console.WriteLine("Chance of hitting 4 times in a row.");
                        }
                        if (iLevel >= 25)
                        {
                            Console.Write("\nDEATHBLOW (");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("-50 AP");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine(")");
                            Console.WriteLine("A life-changing experience.");
                        }
                        Console.WriteLine("\n0 = BACK");
                        Console.Write("\nChoice: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        iSkillMenuInput = 100;
                        string iSkillMenuInputs = Console.ReadLine();
                        if (iSkillMenuInputs == "0")
                        {
                            iSkillMenuInput = 0;
                        }
                        if (iSkillMenuInputs == "1")
                        {
                            iSkillMenuInput = 1;
                        }
                        if (iSkillMenuInputs == "2")
                        {
                            iSkillMenuInput = 2;
                        }
                        if (iSkillMenuInputs == "3")
                        {
                            iSkillMenuInput = 3;
                        }
                        if (iSkillMenuInputs == "4")
                        {
                            iSkillMenuInput = 4;
                        }
                        if (iSkillMenuInputs == "5")
                        {
                            iSkillMenuInput = 5;
                        }
                        //iSkillMenuInput = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Gray;
                        switch (iSkillMenuInput)
                        {
                            default:
                                {
                                    Console.WriteLine("INVALID");
                                    break;
                                }
                            case 3:
                                {
                                    if (iLevel >= 10)
                                    {
                                        Heal1();
                                    }
                                    break;
                                }
                        }
                        CheckStatus();
                        break;
                    }

                default:
                    {
                        Console.Clear();
                        break;
                    }
            }

            //END OF STATUS SWITCH
        }




        //INN----------------------------------------------------------------------------------------------------------------------

        //RESTING AT HOME AND INN FUNCTION
        public void RestHome()
        {
            if (iCurrentArea == 0)
            {
                Console.Clear();
                Console.WriteLine("A day has passed...");
                Console.WriteLine("You feel well rested.");
                Console.ReadKey();
                iPlayerHP = iPlayerMaxHP;
                iPlayerAP = iPlayerMaxAP;
            }


            //1st INN--------------------------------------------------------
            if (iCurrentArea == 21)//1ST CITY'S INN
            {
                //Nice conversation
                Console.Clear();
                Console.WriteLine("\n\nInn Keeper: \"Hello! Welcome to Valeria Village's Inn!\n\n            You look like you've been throught a lot today,\n\n            would you like to rent one of our rooms for the night?");
                Console.Write("\n            It's only ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("150");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" gold!\" ^^'");
                Console.WriteLine("\n\n\n1 = Yes, Please.");
                Console.WriteLine("2 = No, Thank you.");
                //Gets player choice
                Console.WriteLine();
                Console.Write("Choice: ");
                Console.ForegroundColor = ConsoleColor.Green;
                iInnChoice = 100;
                string iInnChoices = Console.ReadLine();
                if (iInnChoices == "0")
                {
                    iInnChoice = 0;
                }
                if (iInnChoices == "1")
                {
                    iInnChoice = 1;
                }
                if (iInnChoices == "2")
                {
                    iInnChoice = 2;
                }
                if (iInnChoices == "3")
                {
                    iInnChoice = 3;
                }
                if (iInnChoices == "4")
                {
                    iInnChoice = 4;
                }
                if (iInnChoices == "5")
                {
                    iInnChoice = 5;
                }
                //iInnChoice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;

                if (iInnChoice == 1)//IF YES
                {
                    //Test if player has money
                    if (iPlayerGold < 150)
                    {
                        //Nice conversation?!
                        Console.Clear();
                        Console.WriteLine("\n\nInn Keeper: \"Sorry, aparently you don't have enough money...\n\n            Come back another time!\"");
                        //Sends player back to town
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        iCurrentArea = 2;
                    }
                    else
                    {
                        //Takes 20 gold off the player
                        iPlayerGold = iPlayerGold - 150;
                        //Nice conversation
                        Console.Clear();
                        Console.WriteLine("\n\nInn Keeper: \"Certainly! Here's your key, have a good night!\"");
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n\n   You move to your room and sleep...");
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n\n   A day has passed...");
                        Console.WriteLine("\n   You feel well rested.");
                        //Fully recovers player HP and AP
                        iPlayerHP = iPlayerMaxHP;
                        iPlayerAP = iPlayerMaxAP;
                        //Sends player back to town
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        iCurrentArea = 2;
                    }
                }

                if (iInnChoice == 2)//IF NO
                {
                    //Nice conversation
                    Console.Clear();
                    Console.WriteLine("\n\nInn Keeper: \"Ok, Goodbye.\"");
                    //Sends player back to town
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    iCurrentArea = 2;
                }
            }


            //2nd INN--------------------------------------------------------
            if (iCurrentArea == 31)//2ND CITY'S INN
            {
                //Nice conversation
                Console.Clear();
                Console.WriteLine("\n\nInn Keeper: \"Hello! Welcome to Wolf Haven's Inn!\n\n            You look like you've been throught a lot today,\n\n            would you like to rent one of our rooms for the night?");
                Console.Write("\n            It's only ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("500");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" gold!\" ^^'");
                Console.WriteLine("\n\n\n1 = Yes, Please.");
                Console.WriteLine("2 = No, Thank you.");
                //Gets player choice
                Console.WriteLine();
                Console.Write("Choice: ");
                Console.ForegroundColor = ConsoleColor.Green;
                iInnChoice = 100;
                string iInnChoices = Console.ReadLine();
                if (iInnChoices == "0")
                {
                    iInnChoice = 0;
                }
                if (iInnChoices == "1")
                {
                    iInnChoice = 1;
                }
                if (iInnChoices == "2")
                {
                    iInnChoice = 2;
                }
                if (iInnChoices == "3")
                {
                    iInnChoice = 3;
                }
                if (iInnChoices == "4")
                {
                    iInnChoice = 4;
                }
                if (iInnChoices == "5")
                {
                    iInnChoice = 5;
                }
                //iInnChoice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;

                if (iInnChoice == 1)//IF YES
                {
                    //Test if player has money
                    if (iPlayerGold < 500)
                    {
                        //Nice conversation?!
                        Console.Clear();
                        Console.WriteLine("\n\nInn Keeper: \"Sorry, aparently you don't have enough money...\n\n            Come back another time!\"");
                        //Sends player back to town
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        iCurrentArea = 3;
                    }
                    else
                    {
                        //Takes 20 gold off the player
                        iPlayerGold = iPlayerGold - 500;
                        //Nice conversation
                        Console.Clear();
                        Console.WriteLine("\n\nInn Keeper: \"Certainly! Here's your key, have a good night!\"");
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n\n   You move to your room and sleep...");
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n\n   A day has passed...");
                        Console.WriteLine("\n   You feel well rested.");
                        //Fully recovers player HP and AP
                        iPlayerHP = iPlayerMaxHP;
                        iPlayerAP = iPlayerMaxAP;
                        //Sends player back to town
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        iCurrentArea = 3;
                    }
                }

                if (iInnChoice == 2)//IF NO
                {
                    //Nice conversation
                    Console.Clear();
                    Console.WriteLine("\n\nInn Keeper: \"Ok, Goodbye.\"");
                    //Sends player back to town
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    iCurrentArea = 3;
                }
            }


            //3rd INN--------------------------------------------------------
            if (iCurrentArea == 41)//3RD CITY'S INN
            {
                //Nice conversation
                Console.Clear();
                Console.WriteLine("\n\nInn Keeper: \"Hello! Welcome to Alkemia Fortress' Inn!\n\n            You look like you've been throught a lot today,\n\n            would you like to rent one of our rooms for the night?");
                Console.Write("\n            It's only ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("1000");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" gold!\" ^^'");
                Console.WriteLine("\n\n\n1 = Yes, Please.");
                Console.WriteLine("2 = No, Thank you.");
                //Gets player choice
                Console.WriteLine();
                Console.Write("Choice: ");
                Console.ForegroundColor = ConsoleColor.Green;
                iInnChoice = 100;
                string iInnChoices = Console.ReadLine();
                if (iInnChoices == "0")
                {
                    iInnChoice = 0;
                }
                if (iInnChoices == "1")
                {
                    iInnChoice = 1;
                }
                if (iInnChoices == "2")
                {
                    iInnChoice = 2;
                }
                if (iInnChoices == "3")
                {
                    iInnChoice = 3;
                }
                if (iInnChoices == "4")
                {
                    iInnChoice = 4;
                }
                if (iInnChoices == "5")
                {
                    iInnChoice = 5;
                }
                //iInnChoice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;

                if (iInnChoice == 1)//IF YES
                {
                    //Test if player has money
                    if (iPlayerGold < 1000)
                    {
                        //Nice conversation?!
                        Console.Clear();
                        Console.WriteLine("\n\nInn Keeper: \"Sorry, aparently you don't have enough money...\n\n            Come back another time!\"");
                        //Sends player back to town
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        iCurrentArea = 4;
                    }
                    else
                    {
                        //Takes 20 gold off the player
                        iPlayerGold = iPlayerGold - 1000;
                        //Nice conversation
                        Console.Clear();
                        Console.WriteLine("\n\nInn Keeper: \"Certainly! Here's your key, have a good night!\"");
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n\n   You move to your room and sleep...");
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\n\n   A day has passed...");
                        Console.WriteLine("\n   You feel well rested.");
                        //Fully recovers player HP and AP
                        iPlayerHP = iPlayerMaxHP;
                        iPlayerAP = iPlayerMaxAP;
                        //Sends player back to town
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        iCurrentArea = 4;
                    }
                }

                if (iInnChoice == 2)//IF NO
                {
                    //Nice conversation
                    Console.Clear();
                    Console.WriteLine("\n\nInn Keeper: \"Ok, Goodbye.\"");
                    //Sends player back to town
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    iCurrentArea = 4;
                }
            }
        }


        //SHOP-------------------------------------------------------------------------------------

        //ITEM SHOP AND ARMORY ARE BOTH RUN INSIDE "Shop"
        public void Shop()
        {

            //ITEM SHOP - VALERIA VILLAGE ------------------------------------------------------------------------------------------
            if (iCurrentArea == 22)
            {
                //Nice conversation
                Console.Clear();
                Console.WriteLine("\n\nShop Keeper: \"Greetings stranger, welcome to my humble shop!\n\n              Here I sell potions and scrolls, amongst other items...\n\n              What can I help you with?\"");
                Console.WriteLine("\n\n\n1 = Browse items.");
                Console.WriteLine("2 = Thanks, but I should go.");
                //Gets player choice
                Console.WriteLine();
                Console.Write("Choice: ");
                Console.ForegroundColor = ConsoleColor.Green;
                iInnChoice = 100;
                string iInnChoices = Console.ReadLine();
                if (iInnChoices == "0")
                {
                    iInnChoice = 0;
                }
                if (iInnChoices == "1")
                {
                    iInnChoice = 1;
                }
                if (iInnChoices == "2")
                {
                    iInnChoice = 2;
                }
                if (iInnChoices == "3")
                {
                    iInnChoice = 3;
                }
                if (iInnChoices == "4")
                {
                    iInnChoice = 4;
                }
                if (iInnChoices == "5")
                {
                    iInnChoice = 5;
                }
                //iInnChoice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;

                do
                {
                    if (iInnChoice == 1)//IF 1
                    {

                        //PURCHASEABLES ARE PROMPTED
                        Console.Clear();
                        Console.WriteLine("\n\nITEMS:");
                        Console.Write("YOUR CURRENT GOLD: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(iPlayerGold);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("1 = Minor Health Potion + 100 HP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 50");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n2 = Medium Life Potion + 500 HP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 250");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n3 = Minor AP Potion + 25 AP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 70");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n4 =  Medium AP Potion + 250 AP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 350");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n0 = EXIT");
                        //Gets player choice
                        Console.WriteLine();
                        Console.Write("Choice: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        iItemChoice = 100;
                        string iItemChoices = Console.ReadLine();
                        if (iItemChoices == "0")
                        {
                            iItemChoice = 0;
                        }
                        if (iItemChoices == "1")
                        {
                            iItemChoice = 1;
                        }
                        if (iItemChoices == "2")
                        {
                            iItemChoice = 2;
                        }
                        if (iItemChoices == "3")
                        {
                            iItemChoice = 3;
                        }
                        if (iItemChoices == "4")
                        {
                            iItemChoice = 4;
                        }
                        if (iItemChoices == "5")
                        {
                            iItemChoice = 5;
                        }
                        //iItemChoice = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Gray;

                        switch (iItemChoice)
                        {
                            case 0:
                                {
                                    iInnChoice = 2;
                                    break;
                                }

                            case 1:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 50;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iHPot1 = iHPot1 + iItemAmount;
                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + " Small Hp Potions");
                                        Console.ReadKey();

                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;

                                        Console.WriteLine("You bought a " + iHPot1);
                                    }
                                    else
                                    {


                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                            case 2:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 250;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iHPot2 = iHPot2 + iItemAmount;
                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + " Medium HP Potions");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }

                            case 3:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 70;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iAPPot1 = iAPPot1 + iItemAmount;
                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + " Small AP Potions");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                        // gold is taken away and player is given item
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 350;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iAPPot2 = iAPPot2 + iItemAmount;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + " Medium AP Potions");
                                        Console.ReadKey();

                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }
                        }
                    }
                }
                while (iInnChoice == 1);

                if (iInnChoice == 2)//IF 2
                {
                    //Nice conversation
                    Console.Clear();
                    Console.WriteLine("\n\nShop Keeper: \"Thank you, come again!\"");
                    //Sends player back to town
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    iCurrentArea = 2;

                }
            }


            //ARMORY - VALERIA VILLAGE ------------------------------------------------------------------------------------------JEFF CHANGED UP
            if (iCurrentArea == 23)
            {
                //Nice conversation
                Console.Clear();
                Console.WriteLine("\n\nBlacksmith: \"Hello there! Welcome! I'm the village's blacksmith and in charge\n\n             of the Armory. Here I sell Weapons and Armor. Take a look at my\n\n             items if you like. Let me know if you like something.\"");
                Console.WriteLine("\n\n\n1 = Browse wares.");
                Console.WriteLine("2 = Thanks, but I should go.");
                //Gets player choice
                Console.WriteLine();
                Console.Write("Choice: ");
                Console.ForegroundColor = ConsoleColor.Green;
                iInnChoice = 100;
                string iInnChoices = Console.ReadLine();
                if (iInnChoices == "0")
                {
                    iInnChoice = 0;
                }
                if (iInnChoices == "1")
                {
                    iInnChoice = 1;
                }
                if (iInnChoices == "2")
                {
                    iInnChoice = 2;
                }
                if (iInnChoices == "3")
                {
                    iInnChoice = 3;
                }
                if (iInnChoices == "4")
                {
                    iInnChoice = 4;
                }
                if (iInnChoices == "5")
                {
                    iInnChoice = 5;
                }
                //iInnChoice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;


                if (iInnChoice == 1)//IF 1
                {
                    do
                    {
                        //PURCHASEABLES ARE PROMPTED
                        Console.Clear();
                        Console.WriteLine("VALERIA VILLAGE ARMORY");
                        Console.Write("YOUR CURRENT GOLD: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(iPlayerGold);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n\nWEAPONS:");
                        Console.WriteLine("1 = STEEL SHORT SWORD + 20 ATK");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 150");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("2 = STEEL LONG SWORD + 35 ATK");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 250");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n\nARMOR:");
                        Console.WriteLine("3 = WOLF PELT + 4 DEF");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 150");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("4 = TUNIC + 7 DEF");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 300");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n0 = EXIT");
                        //Gets player choice
                        Console.WriteLine();
                        Console.Write("Choice: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        iShopChoice = 100;
                        string iShopChoices = Console.ReadLine();
                        if (iShopChoices == "0")
                        {
                            iShopChoice = 0;
                        }
                        if (iShopChoices == "1")
                        {
                            iShopChoice = 1;
                        }
                        if (iShopChoices == "2")
                        {
                            iShopChoice = 2;
                        }
                        if (iShopChoices == "3")
                        {
                            iShopChoice = 3;
                        }
                        if (iShopChoices == "4")
                        {
                            iShopChoice = 4;
                        }
                        if (iShopChoices == "5")
                        {
                            iShopChoice = 5;
                        }
                        //iShopChoice = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Gray;

                        switch (iShopChoice)
                        {
                            case 0:
                                {
                                    iInnChoice = 2;
                                    break;
                                }
                            //SHORT SWORD
                            case 1:
                                {
                                    if (sWeapon == "STEEL SHORT SWORD")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("THIS WEAPON IS ALREADY EQUIPPED");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    if (iPlayerGold >= 150 && sWeapon != "STEEL SHORT SWORD")
                                    {
                                        sWeapon = "STEEL SHORT SWORD";
                                        iPlayerATK = iPlayerATK - iWeaponMod;
                                        iWeaponMod = 20;
                                        sCurrentWeapon = (sWeapon + " + " + iWeaponMod + " ATK");
                                        iPlayerATK = iPlayerATK + iWeaponMod;
                                        iPlayerGold = iPlayerGold - 150;
                                        Console.WriteLine("You bought a " + sWeapon);
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();

                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            //LONG SWORD
                            case 2:
                                {
                                    if (sWeapon == "STEEL LONG SWORD")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("THIS WEAPON IS ALREADY EQUIPPED");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    if (iPlayerGold >= 250 && sWeapon != "STEEL LONG SWORD")
                                    {
                                        sWeapon = "STEEL LONG SWORD";
                                        iPlayerATK = iPlayerATK - iWeaponMod;
                                        iWeaponMod = 35;
                                        sCurrentWeapon = (sWeapon + " + " + iWeaponMod + " ATK");
                                        iPlayerATK = iPlayerATK + iWeaponMod;
                                        iPlayerGold = iPlayerGold - 250;

                                        Console.WriteLine("You bought a " + sWeapon);
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            //PELT
                            case 3:
                                {
                                    if (sArmor == "WOLF PELT")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("THIS ARMOR IS ALREADY EQUIPPED");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    if (iPlayerGold >= 150 && sArmor != "WOLF PELT")
                                    {
                                        sArmor = "WOLF PELT";
                                        iPlayerDEF = iPlayerDEF - iArmorMod;
                                        iArmorMod = 4;
                                        sCurrentArmor = (sArmor + " + " + iArmorMod + " DEF");
                                        iPlayerDEF = iPlayerDEF + iArmorMod;
                                        iPlayerGold = iPlayerGold - 150;
                                        Console.WriteLine("You bought a " + sArmor);
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            //TUNIC
                            case 4:
                                {
                                    if (sArmor == "TUNIC")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("THIS ARMOR IS ALREADY EQUIPPED");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    if (iPlayerGold >= 300 && sArmor != "TUNIC")
                                    {
                                        sArmor = "TUNIC";
                                        iPlayerDEF = iPlayerDEF - iArmorMod;
                                        iArmorMod = 7;
                                        sCurrentArmor = (sArmor + " + " + iArmorMod + " DEF");
                                        iPlayerDEF = iPlayerDEF + iArmorMod;
                                        iPlayerGold = iPlayerGold - 300;
                                        Console.WriteLine("You bought a " + sArmor);
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                        }
                    }
                    while (iInnChoice == 1);
                }

                if (iInnChoice == 2)//IF 2
                {
                    //Nice conversation
                    Console.Clear();
                    Console.WriteLine("\n\nShop Keeper: \"Thank you, come again!\"");
                    //Sends player back to town
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    iCurrentArea = 2;

                }
            }

            //ITEM SHOP - WOLF TOWN ------------------------------------------------------------------------------------------
            if (iCurrentArea == 32)
            {
                //Nice conversation
                Console.Clear();
                Console.WriteLine("\n\nShop Keeper: \"Greetings stranger, welcome to my humble shop!\n\n              Here I sell potions and scrolls, amongst other items...\n\n              What can I help you with?\"");
                Console.WriteLine("\n\n\n1 = Browse items.");
                Console.WriteLine("2 = Thanks, but I should go.");
                //Gets player choice
                Console.WriteLine();
                Console.Write("Choice: ");
                Console.ForegroundColor = ConsoleColor.Green;
                iInnChoice = 100;
                string iInnChoices = Console.ReadLine();
                if (iInnChoices == "0")
                {
                    iInnChoice = 0;
                }
                if (iInnChoices == "1")
                {
                    iInnChoice = 1;
                }
                if (iInnChoices == "2")
                {
                    iInnChoice = 2;
                }
                if (iInnChoices == "3")
                {
                    iInnChoice = 3;
                }
                if (iInnChoices == "4")
                {
                    iInnChoice = 4;
                }
                if (iInnChoices == "5")
                {
                    iInnChoice = 5;
                }
                //iInnChoice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;
                do
                {
                    if (iInnChoice == 1)//IF 1
                    {

                        //PURCHASEABLES ARE PROMPTED
                        Console.Clear();
                        Console.WriteLine("\n\nITEMS:");
                        Console.Write("YOUR CURRENT GOLD: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(iPlayerGold);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("1 = Minor Health Potion + 100 HP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 50");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n2 = Medium Life Potion + 500 HP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 250");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n3 = Minor AP Potion + 25 AP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 70");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n4 =  Medium AP Potion + 250 AP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 350");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n0 = EXIT");
                        //Gets player choice
                        Console.WriteLine();
                        Console.Write("Choice: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        iItemChoice = 100;
                        string iItemChoices = Console.ReadLine();
                        if (iItemChoices == "0")
                        {
                            iItemChoice = 0;
                        }
                        if (iItemChoices == "1")
                        {
                            iItemChoice = 1;
                        }
                        if (iItemChoices == "2")
                        {
                            iItemChoice = 2;
                        }
                        if (iItemChoices == "3")
                        {
                            iItemChoice = 3;
                        }
                        if (iItemChoices == "4")
                        {
                            iItemChoice = 4;
                        }
                        if (iItemChoices == "5")
                        {
                            iItemChoice = 5;
                        }
                        //iItemChoice = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    switch (iItemChoice)
                    {
                        case 0:
                            {
                                iInnChoice = 2;
                                break;
                            }

                        case 1:
                            {
                                //Gets player choice
                                Console.WriteLine();
                                Console.Write("How many would you like to buy? ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                iItemAmount = 0;
                                string iItemAmounts = Console.ReadLine();
                                if (iItemAmounts == "0")
                                {
                                    iItemAmount = 0;
                                }
                                if (iItemAmounts == "1")
                                {
                                    iItemAmount = 1;
                                }
                                if (iItemAmounts == "2")
                                {
                                    iItemAmount = 2;
                                }
                                if (iItemAmounts == "3")
                                {
                                    iItemAmount = 3;
                                }
                                if (iItemAmounts == "4")
                                {
                                    iItemAmount = 4;
                                }
                                if (iItemAmounts == "5")
                                {
                                    iItemAmount = 5;
                                }
                                if (iItemAmounts == "6")
                                {
                                    iItemAmount = 6;
                                }
                                if (iItemAmounts == "7")
                                {
                                    iItemAmount = 7;
                                }
                                if (iItemAmounts == "8")
                                {
                                    iItemAmount = 8;
                                }
                                if (iItemAmounts == "9")
                                {
                                    iItemAmount = 9;
                                }
                                if (iItemAmounts == "10")
                                {
                                    iItemAmount = 10;
                                }
                                if (iItemAmounts == "11")
                                {
                                    iItemAmount = 11;
                                }
                                if (iItemAmounts == "12")
                                {
                                    iItemAmount = 12;
                                }
                                if (iItemAmounts == "13")
                                {
                                    iItemAmount = 13;
                                }
                                if (iItemAmounts == "14")
                                {
                                    iItemAmount = 14;
                                }
                                if (iItemAmounts == "15")
                                {
                                    iItemAmount = 15;
                                }
                                if (iItemAmounts == "16")
                                {
                                    iItemAmount = 16;
                                }
                                if (iItemAmounts == "17")
                                {
                                    iItemAmount = 17;
                                }
                                if (iItemAmounts == "18")
                                {
                                    iItemAmount = 18;
                                }
                                if (iItemAmounts == "19")
                                {
                                    iItemAmount = 19;
                                }
                                if (iItemAmounts == "20")
                                {
                                    iItemAmount = 20;
                                }
                                if (iItemAmounts == "21")
                                {
                                    iItemAmount = 21;
                                }
                                if (iItemAmounts == "22")
                                {
                                    iItemAmount = 22;
                                }
                                if (iItemAmounts == "23")
                                {
                                    iItemAmount = 23;
                                }
                                if (iItemAmounts == "24")
                                {
                                    iItemAmount = 24;
                                }
                                if (iItemAmounts == "25")
                                {
                                    iItemAmount = 25;
                                }
                                if (iItemAmounts == "26")
                                {
                                    iItemAmount = 26;
                                }
                                if (iItemAmounts == "27")
                                {
                                    iItemAmount = 27;
                                }
                                if (iItemAmounts == "28")
                                {
                                    iItemAmount = 28;
                                }
                                if (iItemAmounts == "29")
                                {
                                    iItemAmount = 29;
                                }
                                if (iItemAmounts == "30")
                                {
                                    iItemAmount = 30;
                                }
                                if (iItemAmounts == "31")
                                {
                                    iItemAmount = 31;
                                }
                                if (iItemAmounts == "32")
                                {
                                    iItemAmount = 32;
                                }
                                if (iItemAmounts == "33")
                                {
                                    iItemAmount = 33;
                                }
                                if (iItemAmounts == "34")
                                {
                                    iItemAmount = 34;
                                }
                                if (iItemAmounts == "35")
                                {
                                    iItemAmount = 35;
                                }
                                if (iItemAmounts == "36")
                                {
                                    iItemAmount = 36;
                                }
                                if (iItemAmounts == "37")
                                {
                                    iItemAmount = 37;
                                }
                                if (iItemAmounts == "38")
                                {
                                    iItemAmount = 38;
                                }
                                if (iItemAmounts == "39")
                                {
                                    iItemAmount = 39;
                                }
                                if (iItemAmounts == "40")
                                {
                                    iItemAmount = 40;
                                }
                                if (iItemAmounts == "41")
                                {
                                    iItemAmount = 41;
                                }
                                if (iItemAmounts == "42")
                                {
                                    iItemAmount = 42;
                                }
                                if (iItemAmounts == "43")
                                {
                                    iItemAmount = 43;
                                }
                                if (iItemAmounts == "44")
                                {
                                    iItemAmount = 44;
                                }
                                if (iItemAmounts == "45")
                                {
                                    iItemAmount = 45;
                                }
                                if (iItemAmounts == "46")
                                {
                                    iItemAmount = 46;
                                }
                                if (iItemAmounts == "47")
                                {
                                    iItemAmount = 47;
                                }
                                if (iItemAmounts == "48")
                                {
                                    iItemAmount = 48;
                                }
                                if (iItemAmounts == "49")
                                {
                                    iItemAmount = 49;
                                }
                                if (iItemAmounts == "50")
                                {
                                    iItemAmount = 50;
                                }
                                //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;

                                iItemPurchase = iItemAmount * 50;

                                if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                {


                                    iHPot1 = iHPot1 + iItemAmount;



                                    // gold is taken away and player is given item
                                    iPlayerGold = iPlayerGold - iItemPurchase;
                                    Console.WriteLine("You have purchased " + "x " + iItemAmount + " Small HP Potions");
                                    Console.ReadKey();
                                    Console.WriteLine("You bought a " + iHPot1);
                                }
                                else
                                {


                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    Console.ReadKey();
                                }
                                break;
                            }

                        case 2:
                            {
                                //Gets player choice
                                Console.WriteLine();
                                Console.Write("How many would you like to buy? ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                iItemAmount = 0;
                                string iItemAmounts = Console.ReadLine();
                                if (iItemAmounts == "0")
                                {
                                    iItemAmount = 0;
                                }
                                if (iItemAmounts == "1")
                                {
                                    iItemAmount = 1;
                                }
                                if (iItemAmounts == "2")
                                {
                                    iItemAmount = 2;
                                }
                                if (iItemAmounts == "3")
                                {
                                    iItemAmount = 3;
                                }
                                if (iItemAmounts == "4")
                                {
                                    iItemAmount = 4;
                                }
                                if (iItemAmounts == "5")
                                {
                                    iItemAmount = 5;
                                }
                                if (iItemAmounts == "6")
                                {
                                    iItemAmount = 6;
                                }
                                if (iItemAmounts == "7")
                                {
                                    iItemAmount = 7;
                                }
                                if (iItemAmounts == "8")
                                {
                                    iItemAmount = 8;
                                }
                                if (iItemAmounts == "9")
                                {
                                    iItemAmount = 9;
                                }
                                if (iItemAmounts == "10")
                                {
                                    iItemAmount = 10;
                                }
                                if (iItemAmounts == "11")
                                {
                                    iItemAmount = 11;
                                }
                                if (iItemAmounts == "12")
                                {
                                    iItemAmount = 12;
                                }
                                if (iItemAmounts == "13")
                                {
                                    iItemAmount = 13;
                                }
                                if (iItemAmounts == "14")
                                {
                                    iItemAmount = 14;
                                }
                                if (iItemAmounts == "15")
                                {
                                    iItemAmount = 15;
                                }
                                if (iItemAmounts == "16")
                                {
                                    iItemAmount = 16;
                                }
                                if (iItemAmounts == "17")
                                {
                                    iItemAmount = 17;
                                }
                                if (iItemAmounts == "18")
                                {
                                    iItemAmount = 18;
                                }
                                if (iItemAmounts == "19")
                                {
                                    iItemAmount = 19;
                                }
                                if (iItemAmounts == "20")
                                {
                                    iItemAmount = 20;
                                }
                                if (iItemAmounts == "21")
                                {
                                    iItemAmount = 21;
                                }
                                if (iItemAmounts == "22")
                                {
                                    iItemAmount = 22;
                                }
                                if (iItemAmounts == "23")
                                {
                                    iItemAmount = 23;
                                }
                                if (iItemAmounts == "24")
                                {
                                    iItemAmount = 24;
                                }
                                if (iItemAmounts == "25")
                                {
                                    iItemAmount = 25;
                                }
                                if (iItemAmounts == "26")
                                {
                                    iItemAmount = 26;
                                }
                                if (iItemAmounts == "27")
                                {
                                    iItemAmount = 27;
                                }
                                if (iItemAmounts == "28")
                                {
                                    iItemAmount = 28;
                                }
                                if (iItemAmounts == "29")
                                {
                                    iItemAmount = 29;
                                }
                                if (iItemAmounts == "30")
                                {
                                    iItemAmount = 30;
                                }
                                if (iItemAmounts == "31")
                                {
                                    iItemAmount = 31;
                                }
                                if (iItemAmounts == "32")
                                {
                                    iItemAmount = 32;
                                }
                                if (iItemAmounts == "33")
                                {
                                    iItemAmount = 33;
                                }
                                if (iItemAmounts == "34")
                                {
                                    iItemAmount = 34;
                                }
                                if (iItemAmounts == "35")
                                {
                                    iItemAmount = 35;
                                }
                                if (iItemAmounts == "36")
                                {
                                    iItemAmount = 36;
                                }
                                if (iItemAmounts == "37")
                                {
                                    iItemAmount = 37;
                                }
                                if (iItemAmounts == "38")
                                {
                                    iItemAmount = 38;
                                }
                                if (iItemAmounts == "39")
                                {
                                    iItemAmount = 39;
                                }
                                if (iItemAmounts == "40")
                                {
                                    iItemAmount = 40;
                                }
                                if (iItemAmounts == "41")
                                {
                                    iItemAmount = 41;
                                }
                                if (iItemAmounts == "42")
                                {
                                    iItemAmount = 42;
                                }
                                if (iItemAmounts == "43")
                                {
                                    iItemAmount = 43;
                                }
                                if (iItemAmounts == "44")
                                {
                                    iItemAmount = 44;
                                }
                                if (iItemAmounts == "45")
                                {
                                    iItemAmount = 45;
                                }
                                if (iItemAmounts == "46")
                                {
                                    iItemAmount = 46;
                                }
                                if (iItemAmounts == "47")
                                {
                                    iItemAmount = 47;
                                }
                                if (iItemAmounts == "48")
                                {
                                    iItemAmount = 48;
                                }
                                if (iItemAmounts == "49")
                                {
                                    iItemAmount = 49;
                                }
                                if (iItemAmounts == "50")
                                {
                                    iItemAmount = 50;
                                }
                                //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;

                                iItemPurchase = iItemAmount * 250;

                                if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                {


                                    iHPot2 = iHPot2 + iItemAmount;
                                    Console.WriteLine("You have purchased " + "x " + iItemAmount + " Medium HP Potions");
                                    Console.ReadKey();
                                    // gold is taken away and player is given item
                                    iPlayerGold = iPlayerGold - iItemPurchase;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                break;
                            }

                        case 3:
                            {
                                //Gets player choice
                                Console.WriteLine();
                                Console.Write("How many would you like to buy? ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                iItemAmount = 0;
                                string iItemAmounts = Console.ReadLine();
                                if (iItemAmounts == "0")
                                {
                                    iItemAmount = 0;
                                }
                                if (iItemAmounts == "1")
                                {
                                    iItemAmount = 1;
                                }
                                if (iItemAmounts == "2")
                                {
                                    iItemAmount = 2;
                                }
                                if (iItemAmounts == "3")
                                {
                                    iItemAmount = 3;
                                }
                                if (iItemAmounts == "4")
                                {
                                    iItemAmount = 4;
                                }
                                if (iItemAmounts == "5")
                                {
                                    iItemAmount = 5;
                                }
                                if (iItemAmounts == "6")
                                {
                                    iItemAmount = 6;
                                }
                                if (iItemAmounts == "7")
                                {
                                    iItemAmount = 7;
                                }
                                if (iItemAmounts == "8")
                                {
                                    iItemAmount = 8;
                                }
                                if (iItemAmounts == "9")
                                {
                                    iItemAmount = 9;
                                }
                                if (iItemAmounts == "10")
                                {
                                    iItemAmount = 10;
                                }
                                if (iItemAmounts == "11")
                                {
                                    iItemAmount = 11;
                                }
                                if (iItemAmounts == "12")
                                {
                                    iItemAmount = 12;
                                }
                                if (iItemAmounts == "13")
                                {
                                    iItemAmount = 13;
                                }
                                if (iItemAmounts == "14")
                                {
                                    iItemAmount = 14;
                                }
                                if (iItemAmounts == "15")
                                {
                                    iItemAmount = 15;
                                }
                                if (iItemAmounts == "16")
                                {
                                    iItemAmount = 16;
                                }
                                if (iItemAmounts == "17")
                                {
                                    iItemAmount = 17;
                                }
                                if (iItemAmounts == "18")
                                {
                                    iItemAmount = 18;
                                }
                                if (iItemAmounts == "19")
                                {
                                    iItemAmount = 19;
                                }
                                if (iItemAmounts == "20")
                                {
                                    iItemAmount = 20;
                                }
                                if (iItemAmounts == "21")
                                {
                                    iItemAmount = 21;
                                }
                                if (iItemAmounts == "22")
                                {
                                    iItemAmount = 22;
                                }
                                if (iItemAmounts == "23")
                                {
                                    iItemAmount = 23;
                                }
                                if (iItemAmounts == "24")
                                {
                                    iItemAmount = 24;
                                }
                                if (iItemAmounts == "25")
                                {
                                    iItemAmount = 25;
                                }
                                if (iItemAmounts == "26")
                                {
                                    iItemAmount = 26;
                                }
                                if (iItemAmounts == "27")
                                {
                                    iItemAmount = 27;
                                }
                                if (iItemAmounts == "28")
                                {
                                    iItemAmount = 28;
                                }
                                if (iItemAmounts == "29")
                                {
                                    iItemAmount = 29;
                                }
                                if (iItemAmounts == "30")
                                {
                                    iItemAmount = 30;
                                }
                                if (iItemAmounts == "31")
                                {
                                    iItemAmount = 31;
                                }
                                if (iItemAmounts == "32")
                                {
                                    iItemAmount = 32;
                                }
                                if (iItemAmounts == "33")
                                {
                                    iItemAmount = 33;
                                }
                                if (iItemAmounts == "34")
                                {
                                    iItemAmount = 34;
                                }
                                if (iItemAmounts == "35")
                                {
                                    iItemAmount = 35;
                                }
                                if (iItemAmounts == "36")
                                {
                                    iItemAmount = 36;
                                }
                                if (iItemAmounts == "37")
                                {
                                    iItemAmount = 37;
                                }
                                if (iItemAmounts == "38")
                                {
                                    iItemAmount = 38;
                                }
                                if (iItemAmounts == "39")
                                {
                                    iItemAmount = 39;
                                }
                                if (iItemAmounts == "40")
                                {
                                    iItemAmount = 40;
                                }
                                if (iItemAmounts == "41")
                                {
                                    iItemAmount = 41;
                                }
                                if (iItemAmounts == "42")
                                {
                                    iItemAmount = 42;
                                }
                                if (iItemAmounts == "43")
                                {
                                    iItemAmount = 43;
                                }
                                if (iItemAmounts == "44")
                                {
                                    iItemAmount = 44;
                                }
                                if (iItemAmounts == "45")
                                {
                                    iItemAmount = 45;
                                }
                                if (iItemAmounts == "46")
                                {
                                    iItemAmount = 46;
                                }
                                if (iItemAmounts == "47")
                                {
                                    iItemAmount = 47;
                                }
                                if (iItemAmounts == "48")
                                {
                                    iItemAmount = 48;
                                }
                                if (iItemAmounts == "49")
                                {
                                    iItemAmount = 49;
                                }
                                if (iItemAmounts == "50")
                                {
                                    iItemAmount = 50;
                                }
                                //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;

                                iItemPurchase = iItemAmount * 70;

                                if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                {


                                    iAPPot1 = iAPPot1 + iItemAmount;
                                    Console.WriteLine("You have purchased " + "x " + iItemAmount + " Small AP Potions");
                                    Console.ReadKey();
                                    // gold is taken away and player is given item
                                    iPlayerGold = iPlayerGold - iItemPurchase;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                break;
                            }
                        case 4:
                            {
                                //Gets player choice
                                Console.WriteLine();
                                Console.Write("How many would you like to buy? ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                iItemAmount = 0;
                                string iItemAmounts = Console.ReadLine();
                                if (iItemAmounts == "0")
                                {
                                    iItemAmount = 0;
                                }
                                if (iItemAmounts == "1")
                                {
                                    iItemAmount = 1;
                                }
                                if (iItemAmounts == "2")
                                {
                                    iItemAmount = 2;
                                }
                                if (iItemAmounts == "3")
                                {
                                    iItemAmount = 3;
                                }
                                if (iItemAmounts == "4")
                                {
                                    iItemAmount = 4;
                                }
                                if (iItemAmounts == "5")
                                {
                                    iItemAmount = 5;
                                }
                                if (iItemAmounts == "6")
                                {
                                    iItemAmount = 6;
                                }
                                if (iItemAmounts == "7")
                                {
                                    iItemAmount = 7;
                                }
                                if (iItemAmounts == "8")
                                {
                                    iItemAmount = 8;
                                }
                                if (iItemAmounts == "9")
                                {
                                    iItemAmount = 9;
                                }
                                if (iItemAmounts == "10")
                                {
                                    iItemAmount = 10;
                                }
                                if (iItemAmounts == "11")
                                {
                                    iItemAmount = 11;
                                }
                                if (iItemAmounts == "12")
                                {
                                    iItemAmount = 12;
                                }
                                if (iItemAmounts == "13")
                                {
                                    iItemAmount = 13;
                                }
                                if (iItemAmounts == "14")
                                {
                                    iItemAmount = 14;
                                }
                                if (iItemAmounts == "15")
                                {
                                    iItemAmount = 15;
                                }
                                if (iItemAmounts == "16")
                                {
                                    iItemAmount = 16;
                                }
                                if (iItemAmounts == "17")
                                {
                                    iItemAmount = 17;
                                }
                                if (iItemAmounts == "18")
                                {
                                    iItemAmount = 18;
                                }
                                if (iItemAmounts == "19")
                                {
                                    iItemAmount = 19;
                                }
                                if (iItemAmounts == "20")
                                {
                                    iItemAmount = 20;
                                }
                                if (iItemAmounts == "21")
                                {
                                    iItemAmount = 21;
                                }
                                if (iItemAmounts == "22")
                                {
                                    iItemAmount = 22;
                                }
                                if (iItemAmounts == "23")
                                {
                                    iItemAmount = 23;
                                }
                                if (iItemAmounts == "24")
                                {
                                    iItemAmount = 24;
                                }
                                if (iItemAmounts == "25")
                                {
                                    iItemAmount = 25;
                                }
                                if (iItemAmounts == "26")
                                {
                                    iItemAmount = 26;
                                }
                                if (iItemAmounts == "27")
                                {
                                    iItemAmount = 27;
                                }
                                if (iItemAmounts == "28")
                                {
                                    iItemAmount = 28;
                                }
                                if (iItemAmounts == "29")
                                {
                                    iItemAmount = 29;
                                }
                                if (iItemAmounts == "30")
                                {
                                    iItemAmount = 30;
                                }
                                if (iItemAmounts == "31")
                                {
                                    iItemAmount = 31;
                                }
                                if (iItemAmounts == "32")
                                {
                                    iItemAmount = 32;
                                }
                                if (iItemAmounts == "33")
                                {
                                    iItemAmount = 33;
                                }
                                if (iItemAmounts == "34")
                                {
                                    iItemAmount = 34;
                                }
                                if (iItemAmounts == "35")
                                {
                                    iItemAmount = 35;
                                }
                                if (iItemAmounts == "36")
                                {
                                    iItemAmount = 36;
                                }
                                if (iItemAmounts == "37")
                                {
                                    iItemAmount = 37;
                                }
                                if (iItemAmounts == "38")
                                {
                                    iItemAmount = 38;
                                }
                                if (iItemAmounts == "39")
                                {
                                    iItemAmount = 39;
                                }
                                if (iItemAmounts == "40")
                                {
                                    iItemAmount = 40;
                                }
                                if (iItemAmounts == "41")
                                {
                                    iItemAmount = 41;
                                }
                                if (iItemAmounts == "42")
                                {
                                    iItemAmount = 42;
                                }
                                if (iItemAmounts == "43")
                                {
                                    iItemAmount = 43;
                                }
                                if (iItemAmounts == "44")
                                {
                                    iItemAmount = 44;
                                }
                                if (iItemAmounts == "45")
                                {
                                    iItemAmount = 45;
                                }
                                if (iItemAmounts == "46")
                                {
                                    iItemAmount = 46;
                                }
                                if (iItemAmounts == "47")
                                {
                                    iItemAmount = 47;
                                }
                                if (iItemAmounts == "48")
                                {
                                    iItemAmount = 48;
                                }
                                if (iItemAmounts == "49")
                                {
                                    iItemAmount = 49;
                                }
                                if (iItemAmounts == "50")
                                {
                                    iItemAmount = 50;
                                }
                                //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;

                                iItemPurchase = iItemAmount * 350;

                                if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                {


                                    iAPPot2 = iAPPot2 + iItemAmount;

                                    Console.WriteLine("You have purchased " + "x " + iItemAmount + "Medium AP Potions");
                                    Console.ReadKey();
                                    // gold is taken away and player is given item
                                    iPlayerGold = iPlayerGold - iItemPurchase;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                break;
                            }
                    }
                }
                while (iInnChoice == 1);
                if (iInnChoice == 2)//IF 2
                {
                    //Nice conversation
                    Console.Clear();
                    Console.WriteLine("\n\nShop Keeper: \"Thank you, come again!\"");
                    //Sends player back to town
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    iCurrentArea = 3;

                }
            }
            //ARMORY - WOLF TOWN ------------------------------------------------------------------------------------------
            if (iCurrentArea == 33)
            {
                //Nice conversation
                Console.Clear();
                Console.WriteLine("\n\nBlacksmith: \"Hello there! Welcome! I'm the village's blacksmith and in charge\n\n             of the Armory. Here I sell Weapons and Armor. Take a look at my\n\n             items if you like. Let me know if you like something.\"");
                Console.WriteLine("\n\n\n1 = Browse wares.");
                Console.WriteLine("2 = Thanks, but I should go.");
                //Gets player choice
                Console.WriteLine();
                Console.Write("Choice: ");
                Console.ForegroundColor = ConsoleColor.Green;
                iInnChoice = 100;
                string iInnChoices = Console.ReadLine();
                if (iInnChoices == "0")
                {
                    iInnChoice = 0;
                }
                if (iInnChoices == "1")
                {
                    iInnChoice = 1;
                }
                if (iInnChoices == "2")
                {
                    iInnChoice = 2;
                }
                if (iInnChoices == "3")
                {
                    iInnChoice = 3;
                }
                if (iInnChoices == "4")
                {
                    iInnChoice = 4;
                }
                if (iInnChoices == "5")
                {
                    iInnChoice = 5;
                }
                //iInnChoice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;


                if (iInnChoice == 1)//IF 1
                {
                    //PURCHASEABLES ARE PROMPTED
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("WOLF HAVEN ARMORY");
                        Console.Write("YOUR CURRENT GOLD: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(iPlayerGold);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n\nWEAPONS:");
                        Console.WriteLine("1 = BASTARD SWORD + 50 ATK");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 550");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("2 = GREAT AXE + 75 ATK");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 700");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n\nARMOR:");
                        Console.WriteLine("3 = BRONZE CHAINMAIL + 15 DEF");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 400");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("4 = IRON CHAINMAIL + 25 DEF");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 600");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n0 = EXIT");
                        //Gets player choice
                        Console.WriteLine();
                        Console.Write("Choice: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        iShopChoice = 100;
                        string iShopChoices = Console.ReadLine();
                        if (iShopChoices == "0")
                        {
                            iShopChoice = 0;
                        }
                        if (iShopChoices == "1")
                        {
                            iShopChoice = 1;
                        }
                        if (iShopChoices == "2")
                        {
                            iShopChoice = 2;
                        }
                        if (iShopChoices == "3")
                        {
                            iShopChoice = 3;
                        }
                        if (iShopChoices == "4")
                        {
                            iShopChoice = 4;
                        }
                        if (iShopChoices == "5")
                        {
                            iShopChoice = 5;
                        }
                        //iShopChoice = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Gray;

                        switch (iShopChoice)
                        {
                            default:
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    break;
                                }
                            case 0:
                                {
                                    iInnChoice = 2;
                                    break;
                                }
                            //B SWORD
                            case 1:
                                {
                                    if (sWeapon == "BASTARD SWORD")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("THIS WEAPON IS ALREADY EQUIPPED");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    if (iPlayerGold >= 550 && sWeapon != "BASTARD SWORD")
                                    {
                                        sWeapon = "BASTARD SWORD";
                                        iPlayerATK = iPlayerATK - iWeaponMod;
                                        iWeaponMod = 50;
                                        sCurrentWeapon = (sWeapon + " + " + iWeaponMod + " ATK");
                                        iPlayerATK = iPlayerATK + iWeaponMod;
                                        iPlayerGold = iPlayerGold - 550;

                                        Console.WriteLine("You bought a " + sWeapon);
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }


                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            //G AXE
                            case 2:
                                {
                                    if (sWeapon == "GREAT AXE")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("THIS WEAPON IS ALREADY EQUIPPED");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    if (iPlayerGold >= 700 && sWeapon != "GREAT AXE")
                                    {
                                        sWeapon = "GREAT AXE";
                                        iPlayerDEF = iPlayerDEF - iWeaponMod;
                                        iWeaponMod = 75;
                                        sCurrentWeapon = (sWeapon + " + " + iWeaponMod + " ATK");
                                        iPlayerATK = iPlayerATK + iWeaponMod;
                                        iPlayerGold = iPlayerGold - 700;

                                        Console.WriteLine("You bought a " + sWeapon);
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }


                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            //B CHAINMAIL
                            case 3:
                                {
                                    if (sWeapon == "BRONZE CHAINMAIL")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("THIS ARMOR IS ALREADY EQUIPPED");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    if (iPlayerGold >= 150 && sArmor != "BRONZE CHAINMAIL")
                                    {
                                        sArmor = "BRONZE CHAINMAIL";
                                        iPlayerDEF = iPlayerDEF - iArmorMod;
                                        iArmorMod = 15;
                                        sCurrentArmor = (sArmor + " + " + iArmorMod + " DEF");
                                        iPlayerDEF = iPlayerDEF + iArmorMod;
                                        iPlayerGold = iPlayerGold - 150;
                                        Console.WriteLine("You bought a " + sArmor);
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }

                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            //I CHAINMAIL
                            case 4:
                                {
                                    if (sWeapon == "IRON CHAINMAIL")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("THIS ARMOR IS ALREADY EQUIPPED");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    if (iPlayerGold >= 300 && sArmor != "IRON CHAINMAIL")
                                    {
                                        sArmor = "IRON CHAINMAIL";
                                        iPlayerDEF = iPlayerDEF - iArmorMod;
                                        iArmorMod = 25;
                                        sCurrentArmor = (sArmor + " + " + iArmorMod + " DEF");
                                        iPlayerDEF = iPlayerDEF + iArmorMod;
                                        iPlayerGold = iPlayerGold - 300;
                                        Console.WriteLine("You bought a " + sArmor);
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }

                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                        }
                    }
                    while (iInnChoice == 1);
                }

                if (iInnChoice == 2)//IF 2
                {
                    //Nice conversation
                    Console.Clear();
                    Console.WriteLine("\n\nShop Keeper: \"Thank you, come again!\"");
                    //Sends player back to town
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    iCurrentArea = 3;

                }
            }




            //ITEM SHOP - ROFLING MAO FORTRESS ------------------------------------------------------------------------------------------
            if (iCurrentArea == 42)
            {
                //Nice conversation
                Console.Clear();
                Console.WriteLine("\n\nShop Keeper: \"Greetings stranger, welcome to my humble shop!\n\n              Here I sell potions and scrolls, amongst other items...\n\n              What can I help you with?\"");
                Console.WriteLine("\n\n\n1 = Browse items.");
                Console.WriteLine("2 = Thanks, but I should go.");
                //Gets player choice
                Console.WriteLine();
                Console.Write("Choice: ");
                Console.ForegroundColor = ConsoleColor.Green;
                iInnChoice = 100;
                string iInnChoices = Console.ReadLine();
                if (iInnChoices == "0")
                {
                    iInnChoice = 0;
                }
                if (iInnChoices == "1")
                {
                    iInnChoice = 1;
                }
                if (iInnChoices == "2")
                {
                    iInnChoice = 2;
                }
                if (iInnChoices == "3")
                {
                    iInnChoice = 3;
                }
                if (iInnChoices == "4")
                {
                    iInnChoice = 4;
                }
                if (iInnChoices == "5")
                {
                    iInnChoice = 5;
                }
                //iInnChoice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;
                do
                {
                    if (iInnChoice == 1)//IF 1
                    {
                        //PURCHASEABLES ARE PROMPTED
                        Console.Clear();
                        Console.WriteLine("\n\nITEMS:");
                        Console.Write("YOUR CURRENT GOLD: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(iPlayerGold);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("1 = Minor Health Potion + 100 HP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 50");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n2 = Medium Life Potion + 500 HP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 250");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n3 = Minor AP Potion + 25 AP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 70");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n4 =  Medium AP Potion + 250 AP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 350");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n5 = MAjor Health Potion + 1000 HP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 500");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n6 = Major AP  Potion + 100 HP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 750");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n7 = Max AP  Potion + Max AP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 1500");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n8 = MaX HP  Potion + Max Health HP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 1200");
                        Console.ForegroundColor = ConsoleColor.Gray;


                        Console.WriteLine("\n9 = Steroids + Attack up");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 2500");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n10 = IronChest Elixer + Def up");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 2800");
                        Console.ForegroundColor = ConsoleColor.Gray;

                        Console.WriteLine("\n11 = Wisdom Elixer + 1000 Exp");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 2200");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n12 = PowerHouse + 10 Max AP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 3000");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n13 =Thick Skinned + 15 Max HP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 1800");
                        Console.ForegroundColor = ConsoleColor.Gray;



                        Console.WriteLine("\n0 = EXIT");
                        //Gets player choice
                        Console.WriteLine();
                        Console.Write("Choice: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        iItemChoice = 100;
                        string iItemChoices = Console.ReadLine();
                        if (iItemChoices == "0")
                        {
                            iItemChoice = 0;
                        }
                        if (iItemChoices == "1")
                        {
                            iItemChoice = 1;
                        }
                        if (iItemChoices == "2")
                        {
                            iItemChoice = 2;
                        }
                        if (iItemChoices == "3")
                        {
                            iItemChoice = 3;
                        }
                        if (iItemChoices == "4")
                        {
                            iItemChoice = 4;
                        }
                        if (iItemChoices == "5")
                        {
                            iItemChoice = 5;
                        }
                        //iItemChoice = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Gray;

                        switch (iItemChoice)
                        {
                            case 0:
                                {
                                    iInnChoice = 2;
                                    break;
                                }

                            case 1:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 50;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iHPot1 = iHPot1 + iItemAmount;


                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Small HP Potions");
                                        Console.ReadKey();
                                    }
                                    else
                                    {


                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                            case 2:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 250;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iHPot2 = iHPot2 + iItemAmount;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Medium HP Potions");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }

                            case 3:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 70;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iAPPot1 = iAPPot1 + iItemAmount;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Small AP Potions");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }
                            case 4:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 350;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iAPPot2 = iAPPot2 + iItemAmount;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Medium AP Potions");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }
                            case 5:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 500;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iHPot3 = iHPot3 + iItemAmount;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Large HP Potions");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }



                            case 6:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 750;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iAPPot3 = iAPPot3 + iItemAmount;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Large AP Potions");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }
                            case 7:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 1500;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iAPPot4 = iAPPot4 + iItemAmount;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Max AP Potions");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }
                            case 8:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 1200;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iHPot4 = iHPot4 + iItemAmount;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Max P Potions");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }
                            case 9:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 2500;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iSteroids1 = iSteroids1 + iItemAmount;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Steroids");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }
                            case 10:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 2800;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iIronChest1 = iIronChest1 + iItemAmount;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Iron Chest");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }
                            case 11:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 2200;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iSmarter1 = iSmarter1 + iItemAmount;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Wisdom Elixer");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }

                            case 12:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 3000;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iPowerHouse1 = iPowerHouse1 + iItemAmount;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Power House");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemPurchase;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }


                            case 13:
                                {
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("How many would you like to buy? ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iItemAmount = 0;
                                    string iItemAmounts = Console.ReadLine();
                                    if (iItemAmounts == "0")
                                    {
                                        iItemAmount = 0;
                                    }
                                    if (iItemAmounts == "1")
                                    {
                                        iItemAmount = 1;
                                    }
                                    if (iItemAmounts == "2")
                                    {
                                        iItemAmount = 2;
                                    }
                                    if (iItemAmounts == "3")
                                    {
                                        iItemAmount = 3;
                                    }
                                    if (iItemAmounts == "4")
                                    {
                                        iItemAmount = 4;
                                    }
                                    if (iItemAmounts == "5")
                                    {
                                        iItemAmount = 5;
                                    }
                                    if (iItemAmounts == "6")
                                    {
                                        iItemAmount = 6;
                                    }
                                    if (iItemAmounts == "7")
                                    {
                                        iItemAmount = 7;
                                    }
                                    if (iItemAmounts == "8")
                                    {
                                        iItemAmount = 8;
                                    }
                                    if (iItemAmounts == "9")
                                    {
                                        iItemAmount = 9;
                                    }
                                    if (iItemAmounts == "10")
                                    {
                                        iItemAmount = 10;
                                    }
                                    if (iItemAmounts == "11")
                                    {
                                        iItemAmount = 11;
                                    }
                                    if (iItemAmounts == "12")
                                    {
                                        iItemAmount = 12;
                                    }
                                    if (iItemAmounts == "13")
                                    {
                                        iItemAmount = 13;
                                    }
                                    if (iItemAmounts == "14")
                                    {
                                        iItemAmount = 14;
                                    }
                                    if (iItemAmounts == "15")
                                    {
                                        iItemAmount = 15;
                                    }
                                    if (iItemAmounts == "16")
                                    {
                                        iItemAmount = 16;
                                    }
                                    if (iItemAmounts == "17")
                                    {
                                        iItemAmount = 17;
                                    }
                                    if (iItemAmounts == "18")
                                    {
                                        iItemAmount = 18;
                                    }
                                    if (iItemAmounts == "19")
                                    {
                                        iItemAmount = 19;
                                    }
                                    if (iItemAmounts == "20")
                                    {
                                        iItemAmount = 20;
                                    }
                                    if (iItemAmounts == "21")
                                    {
                                        iItemAmount = 21;
                                    }
                                    if (iItemAmounts == "22")
                                    {
                                        iItemAmount = 22;
                                    }
                                    if (iItemAmounts == "23")
                                    {
                                        iItemAmount = 23;
                                    }
                                    if (iItemAmounts == "24")
                                    {
                                        iItemAmount = 24;
                                    }
                                    if (iItemAmounts == "25")
                                    {
                                        iItemAmount = 25;
                                    }
                                    if (iItemAmounts == "26")
                                    {
                                        iItemAmount = 26;
                                    }
                                    if (iItemAmounts == "27")
                                    {
                                        iItemAmount = 27;
                                    }
                                    if (iItemAmounts == "28")
                                    {
                                        iItemAmount = 28;
                                    }
                                    if (iItemAmounts == "29")
                                    {
                                        iItemAmount = 29;
                                    }
                                    if (iItemAmounts == "30")
                                    {
                                        iItemAmount = 30;
                                    }
                                    if (iItemAmounts == "31")
                                    {
                                        iItemAmount = 31;
                                    }
                                    if (iItemAmounts == "32")
                                    {
                                        iItemAmount = 32;
                                    }
                                    if (iItemAmounts == "33")
                                    {
                                        iItemAmount = 33;
                                    }
                                    if (iItemAmounts == "34")
                                    {
                                        iItemAmount = 34;
                                    }
                                    if (iItemAmounts == "35")
                                    {
                                        iItemAmount = 35;
                                    }
                                    if (iItemAmounts == "36")
                                    {
                                        iItemAmount = 36;
                                    }
                                    if (iItemAmounts == "37")
                                    {
                                        iItemAmount = 37;
                                    }
                                    if (iItemAmounts == "38")
                                    {
                                        iItemAmount = 38;
                                    }
                                    if (iItemAmounts == "39")
                                    {
                                        iItemAmount = 39;
                                    }
                                    if (iItemAmounts == "40")
                                    {
                                        iItemAmount = 40;
                                    }
                                    if (iItemAmounts == "41")
                                    {
                                        iItemAmount = 41;
                                    }
                                    if (iItemAmounts == "42")
                                    {
                                        iItemAmount = 42;
                                    }
                                    if (iItemAmounts == "43")
                                    {
                                        iItemAmount = 43;
                                    }
                                    if (iItemAmounts == "44")
                                    {
                                        iItemAmount = 44;
                                    }
                                    if (iItemAmounts == "45")
                                    {
                                        iItemAmount = 45;
                                    }
                                    if (iItemAmounts == "46")
                                    {
                                        iItemAmount = 46;
                                    }
                                    if (iItemAmounts == "47")
                                    {
                                        iItemAmount = 47;
                                    }
                                    if (iItemAmounts == "48")
                                    {
                                        iItemAmount = 48;
                                    }
                                    if (iItemAmounts == "49")
                                    {
                                        iItemAmount = 49;
                                    }
                                    if (iItemAmounts == "50")
                                    {
                                        iItemAmount = 50;
                                    }
                                    //iItemAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    iItemPurchase = iItemAmount * 1800;

                                    if (iPlayerGold >= iItemPurchase)   // number of items * player choice if gold amount is higher than current gold transaction can not be completed.
                                    {


                                        iThickSkin1 = iThickSkin1 - iItemPurchase;

                                        Console.WriteLine("You have purchased " + "x " + iItemAmount + "Thick Skin");
                                        Console.ReadKey();
                                        // gold is taken away and player is given item
                                        iPlayerGold = iPlayerGold - iItemAmount;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    break;
                                }


                        }
                    }
                }
                while (iInnChoice == 1);
                if (iInnChoice == 2)//IF 2
                {
                    //Nice conversation
                    Console.Clear();
                    Console.WriteLine("\n\nShop Keeper: \"Thank you, come again!\"");
                    //Sends player back to town
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    iCurrentArea = 4;

                }
            }



            //ARMORY - Alk  FORTRESS ------------------------------------------------------------------------------------------
            if (iCurrentArea == 43)
            {
                //Nice conversation
                Console.Clear();
                Console.WriteLine("\n\nBlacksmith: \"Hello there! Welcome! I'm the village's blacksmith and in charge\n\n             of the Armory. Here I sell Weapons and Armor. Take a look at my\n\n             items if you like. Let me know if you like something.\"");
                Console.WriteLine("\n\n\n1 = Browse wares.");
                Console.WriteLine("2 = Thanks, but I should go.");
                //Gets player choice
                Console.WriteLine();
                Console.Write("Choice: ");
                Console.ForegroundColor = ConsoleColor.Green;
                iInnChoice = 100;
                string iInnChoices = Console.ReadLine();
                if (iInnChoices == "0")
                {
                    iInnChoice = 0;
                }
                if (iInnChoices == "1")
                {
                    iInnChoice = 1;
                }
                if (iInnChoices == "2")
                {
                    iInnChoice = 2;
                }
                if (iInnChoices == "3")
                {
                    iInnChoice = 3;
                }
                if (iInnChoices == "4")
                {
                    iInnChoice = 4;
                }
                if (iInnChoices == "5")
                {
                    iInnChoice = 5;
                }
                //iInnChoice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;


                if (iInnChoice == 1)//IF 1
                {
                    //PURCHASEABLES ARE PROMPTED
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("ALKEMIA FORTRESS ARMORY");
                        Console.Write("YOUR CURRENT GOLD: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(iPlayerGold);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n\nWEAPONS:");
                        Console.WriteLine("1 = OYNX BLADE + 600 ATK");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 1550");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("2 = OYNX AXE + 500 ATK");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 1400");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n\nARMOR:");
                        Console.WriteLine("3 = DRAGON SCALE ARMOR + 50 DEF");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 1200");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("4 = SPIKED DRAGON SCALE ARMOR + 75 DEF");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     COST: 2000");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("\n0 = EXIT");
                        //Gets player choice
                        Console.WriteLine();
                        Console.Write("Choice: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        iShopChoice = 100;
                        string iShopChoices = Console.ReadLine();
                        if (iShopChoices == "0")
                        {
                            iShopChoice = 0;
                        }
                        if (iShopChoices == "1")
                        {
                            iShopChoice = 1;
                        }
                        if (iShopChoices == "2")
                        {
                            iShopChoice = 2;
                        }
                        if (iShopChoices == "3")
                        {
                            iShopChoice = 3;
                        }
                        if (iShopChoices == "4")
                        {
                            iShopChoice = 4;
                        }
                        if (iShopChoices == "5")
                        {
                            iShopChoice = 5;
                        }
                        //iShopChoice = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Gray;

                        switch (iShopChoice)
                        {
                            default:
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    break;
                                }
                            case 0:
                                {
                                    iInnChoice = 2;
                                    break;
                                }
                            //O SWORD
                            case 1:
                                {
                                    if (sWeapon == "ONYX BLADE")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("THIS WEAPON IS ALREADY EQUIPPED");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    if (iPlayerGold >= 1550 && sWeapon!= "ONYX BLADE")
                                    {
                                        sWeapon = "ONYX BLADE";
                                        iPlayerDEF = iPlayerDEF - iWeaponMod;
                                        iWeaponMod = 600;
                                        sCurrentWeapon = (sWeapon + " + " + iWeaponMod + " ATK");
                                        iPlayerATK = iPlayerATK + iWeaponMod;
                                        iPlayerGold = iPlayerGold - 1550;

                                        Console.WriteLine("You bought a " + sWeapon);
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }

                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            //O AXE
                            case 2:
                                {
                                    if (sWeapon == "ONYX AXE")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("THIS WEAPON IS ALREADY EQUIPPED");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    if (iPlayerGold >= 1400 && sWeapon != "ONYX AXE")
                                    {
                                        sWeapon = "ONYX AXE";
                                        iPlayerDEF = iPlayerDEF - iWeaponMod;
                                        iWeaponMod = 500;
                                        sCurrentWeapon = (sWeapon + " + " + iWeaponMod + " ATK");
                                        iPlayerATK = iPlayerATK + iWeaponMod;
                                        iPlayerGold = iPlayerGold - 1400;

                                        Console.WriteLine("You bought a " + sWeapon);
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }

                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            //DSA
                            case 3:
                                {
                                    if (sWeapon == "DRAGON SCALE ARMOR")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("THIS ARMOR IS ALREADY EQUIPPED");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    if (iPlayerGold >= 1200 && sArmor != "DRAGON SCALE ARMOR")
                                    {
                                        sArmor = "DRAGON SCALE ARMOR";
                                        iPlayerDEF = iPlayerDEF - iArmorMod;
                                        iArmorMod = 50;
                                        sCurrentArmor = (sArmor + " + " + iArmorMod + " DEF");
                                        iPlayerDEF = iPlayerDEF + iArmorMod;
                                        iPlayerGold = iPlayerGold - 1200;
                                        Console.WriteLine("You bought a " + sArmor);
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }

                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            //I CHAINMAIL
                            case 4:
                                {
                                    if (sWeapon == "SPIKED DRAGON SCALE ARMOR")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("THIS ARMOR IS ALREADY EQUIPPED");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    if (iPlayerGold >= 300 && sArmor != "SPIKED DRAGON SCALE ARMOR")
                                    {
                                        sArmor = "SPIKED DRAGON SCALE ARMOR";
                                        iPlayerDEF = iPlayerDEF - iArmorMod;
                                        iArmorMod = 75;
                                        sCurrentArmor = (sArmor + " + " + iArmorMod + " DEF");
                                        iPlayerDEF = iPlayerDEF + iArmorMod;
                                        iPlayerGold = iPlayerGold - 200;
                                        Console.WriteLine("You bought a " + sArmor);
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }

                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU DONT HAVE ENOUGH MONEY");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                        }
                    }
                    while (iInnChoice == 1);
                }

                if (iInnChoice == 2)//IF 2
                {
                    //Nice conversation
                    Console.Clear();
                    Console.WriteLine("\n\nShop Keeper: \"Thank you, come again!\"");
                    //Sends player back to town
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    iCurrentArea = 4;

                }
            }
        }






        //ATTACK-----------------------------------------------
        public int PlayerAttack()
        {
            iPlayerFINAL = iPlayerATK;
            iPlayerFINAL = iPATKRoll.Next(iPlayerATK / 8, iPlayerATK / 4);

            return iPlayerFINAL = iPlayerFINAL + iPlayerATK;

        }

        //BASH ATTACK------------------------------------------
        public int BashATK()
        {
            iPlayerFINAL = iPlayerATK;
            iPlayerAP = iPlayerAP - 5;
            iPlayerFINAL = iPATKRoll.Next(iPlayerATK / 2, iPlayerATK);

            return iPlayerFINAL = iPlayerFINAL + iPlayerATK;
        }

        //SKULLCRUSHER ATTACK------------------------------------------
        public int SkullCrusherATK()
        {
            iPlayerFINAL = iPlayerATK;
            iPlayerAP = iPlayerAP - 15;
            iPlayerFINAL = iPlayerATK + iPlayerATK / 2;

            return iPlayerFINAL = iPlayerFINAL + iPlayerATK;
        }


        //MULTISTRIKE ATTACK------------------------------------------

        public int ComboStrike()
        {
            iPlayerFINAL = iPlayerATK;
            iPlayerAP = iPlayerAP - 35;
            iPlayerFINAL = iPATKRoll.Next(iPlayerATK / 8, iPlayerATK / 4);

            return iPlayerFINAL = iPlayerFINAL + iPlayerATK;
        }

        //HEAL 1------------------------------------------

        public int Heal1()
        {
            iPlayerAP = iPlayerAP - 25;
            iHealed = iPlayerMaxHP / 4;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n**HEAL**");
            Console.WriteLine("     +"+iHealed+ " HP");
            Console.ForegroundColor = ConsoleColor.Gray;
            iPlayerHP = iHealed + iPlayerHP;
            return iPlayerHP;
        }

        //DEATH BLOW
        public int DeathBlow()
        {
            iPlayerFINAL = iPlayerATK;
            iPlayerAP = iPlayerAP - 50;
            iPlayerFINAL = iPlayerATK * 4;

            return iPlayerFINAL = iPlayerFINAL + iPlayerATK;
        }











        //ENEMY CONSTRUCTION


        //---------------------------------------BATTLE FUNCTION----------------------------------------------
        //BATTLE FUNCTION  
        public void Area1Battle()
        {
            //DECLARE USER INPUT
            int iAUserInput;

            //CREATE A NEW RANDOM ENEMY
            Random eRoll = new Random();
            Enemies oCurrentEnemy;

            //CREATES RANDOM ENEMY AND PICKS BASED ON CURRENT AREA
            //PLAINS OF NEVERMORE 
            //AREA 1-------LV 1- 5-----------------------------//
            if (iCurrentArea == 1)
            {
                oCurrentEnemy = new Enemies(eRoll.Next(1, 4));
            }

            //MARSHES OF INSOLENCE
            //AREA 2------LV 6 - 15 ----------------------//
            else if (iCurrentArea == 5)
            {
                oCurrentEnemy = new Enemies(eRoll.Next(5, 8));
            }

            //GOBLINS CAVE
            //AREA 2-1 (GOBLIN CAVE)------LV 16 - 20 ----------------------//
            else if (iCurrentArea == 6)
            {
                oCurrentEnemy = new Enemies(eRoll.Next(9, 12));
            }

            //GOBLINS CAVE(BOSS FIGHT)
            //TITLE AREA 2-2 (CAVE - BOSS)------LV 16 - 20 ----------------------//

            else if (iCurrentArea == 11)
            {
                oCurrentEnemy = new Enemies(13);
            }

            //AZAZEL'S DESERT
            //AREA 3----------------LV 21 - 26 ----------------------//

            else if (iCurrentArea == 7)
            {
                oCurrentEnemy = new Enemies(eRoll.Next(14, 17));
            }

            //ORC'S CAVE
            //AREA 3----------------LV 27 - 32 ----------------------//

            else if (iCurrentArea == 8)
            {
                oCurrentEnemy = new Enemies(eRoll.Next(18, 22));
            }

            //ORC'S CAVE(BOSS FIGHT)
            //TITLE AREA 3-2 (NEXT - BOSS)------LV 27 - 32 ----------------------//

            else if (iCurrentArea == 12)
            {
                oCurrentEnemy = new Enemies(23);
            }

            //DRAGON'S MOUNTAINS
            //AREA 4 ----------------LV 33 - 40 ----------------------//

            else if(iCurrentArea == 9)
            {
                oCurrentEnemy = new Enemies(eRoll.Next(24, 28));
            }

            //DRAGON'S LAYER(BOSS FIGHT)
            //TITLE AREA 4-2 (LAST BOSS FIGHT)------LV 33 - 40 ----------------------//
            else if (iCurrentArea == 10)
            {
                oCurrentEnemy = new Enemies(29);
            }


                //else statement is needed to continue
            else
            {
                oCurrentEnemy = new Enemies(4);
            }


            //AREA 1
            //ENCOUNTERED X ENEMY
            Console.Write("You ecountered a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(oCurrentEnemy.sName);
            Console.WriteLine();
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(sName + ":");
                    Console.WriteLine("Level: " + iLevel);
                    Console.WriteLine("───────────────────────────────────────────");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("HP: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(iPlayerHP);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(iPlayerMaxHP);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" AP: ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(iPlayerAP);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("/");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(iPlayerMaxAP);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\nAttack: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(iPlayerATK);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\nDefense: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(iPlayerDEF + "\n\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    //sets player turn to 0
                    iPlayerTurn = 0;
                    //options
                    Console.WriteLine("1 = ATTACK");
                    //2 goes to special attack switch
                    Console.WriteLine(" 2 = USE A SKILL");
                    Console.WriteLine("  3 = USE AN ITEM");


                    //USER INPUT ENTERED INTO COMBAT SWITCH
                    Console.Write("\nChoice: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    iAUserInput = 100;
                    string iAUserInputs = Console.ReadLine();
                    if (iAUserInputs == "0")
                    {
                        iAUserInput = 0;
                    }
                    if (iAUserInputs == "1")
                    {
                        iAUserInput = 1;
                    }
                    if (iAUserInputs == "2")
                    {
                        iAUserInput = 2;
                    }
                    if (iAUserInputs == "3")
                    {
                        iAUserInput = 3;
                    }
                    if (iAUserInputs == "4")
                    {
                        iAUserInput = 4;
                    }
                    if (iAUserInputs == "5")
                    {
                        iAUserInput = 5;
                    }
                    if (iAUserInputs == "6")
                    {
                        iAUserInput = 6;
                    }
                    if (iAUserInputs == "7")
                    {
                        iAUserInput = 7;
                    }
                    if (iAUserInputs == "8")
                    {
                        iAUserInput = 8;
                    }
                    if (iAUserInputs == "9")
                    {
                        iAUserInput = 9;
                    }
                    if (iAUserInputs == "10")
                    {
                        iAUserInput = 10;
                    }
                    //iAUserInput = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    //-----------------------------------------------COMBAT SWITCH-----------------------------------///
                    switch (iAUserInput)
                    {

                        //-----------------------NORMAL ATTACK----------------------//
                        case 1://normal attack
                            Console.Clear();
                            if (iAUserInput == 1)
                            {
                                PlayerAttack();
                                iPlayerFINAL = iPlayerFINAL - oCurrentEnemy.iEDefense;
                                if (iPlayerFINAL <= 0)
                                {
                                    iPlayerFINAL = 0;
                                }
                                Console.Write("\nATTACK!!! ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(iPlayerFINAL + " DMG\n");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                oCurrentEnemy.iEHealth = oCurrentEnemy.iEHealth - iPlayerFINAL;
                                iPlayerTurn = 1;
                            }
                            else
                            {
                                Console.WriteLine("INVALID SELECTION");
                                iPlayerTurn = 0;
                            }
                            //sets player turn to 1
                            break;


                            /////////-----------------------SPECIAL ATTACK SWITCH AND INPUT---------------------------------/////////////////
                        case 2:
                            Console.Clear();
                            if (iAUserInput == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine(sName + ":");
                                Console.WriteLine("Level: " + iLevel);
                                Console.WriteLine("________________________________________");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("HP: ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(iPlayerHP);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("/");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(iPlayerMaxHP);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write(" AP: ");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(iPlayerAP);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("/");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(iPlayerMaxAP);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("\nAttack: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(iPlayerATK);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("\nDefense: ");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(iPlayerDEF + "\n\n");
                                Console.ForegroundColor = ConsoleColor.Gray;




                                //Player is prompted to choose their skill
                                Console.WriteLine("CHOOSE YOUR SKILL:");
                                Console.WriteLine("──────────────────────────────────");

                                //bash
                                Console.Write("\n1 = BASH (");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("-5 AP");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine(")");

                                //skull crusher
                                if (iLevel >= 5)
                                {
                                    Console.Write("\n2 = SKULL CRUSHER (");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write("-15 AP");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine(")");
                                }
                                //heal
                                if (iLevel >= 10)
                                {
                                    Console.Write("\n3 = HEAL (");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write("-25 AP");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine(")");
                                }
                                //multi slash
                                if (iLevel >= 17)
                                {
                                    Console.Write("\n4 = MULTI SLASH (");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write("-35 AP");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine(")");
                                }
                                //deathblow
                                if (iLevel >= 25)
                                {
                                    Console.Write("\n4 = DEATHBLOW (");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write("-50 AP");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine(")");
                                }

                                Console.WriteLine("\n0 = EXIT");
                                //converts input into a switch for attack chosen
                                Console.Write("\nChoice: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                iSpecATKInput = 100;
                                string iSpecATKInputs = Console.ReadLine();
                                if (iSpecATKInputs == "0")
                                {
                                    iSpecATKInput = 0;
                                }
                                if (iSpecATKInputs == "1")
                                {
                                    iSpecATKInput = 1;
                                }
                                if (iSpecATKInputs == "2")
                                {
                                    iSpecATKInput = 2;
                                }
                                if (iSpecATKInputs == "3")
                                {
                                    iSpecATKInput = 3;
                                }
                                if (iSpecATKInputs == "4")
                                {
                                    iSpecATKInput = 4;
                                }
                                if (iSpecATKInputs == "5")
                                {
                                    iSpecATKInput = 5;
                                }
                                //iSpecATKInput = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;
                                switch (iSpecATKInput)
                                {
                                    case 0:
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                    //-----------------BASH--------------//
                                    case 1://BASH special attack requires 5 AP
                                        //CHANGE TO ANOTHER SWITCH TO OPEN ALL SPECIAL ATTACK OPTIONS
                                        Console.Clear();
                                        if (iPlayerAP >= 5)
                                        {
                                            BashATK();
                                            iPlayerFINAL = iPlayerFINAL - oCurrentEnemy.iEDefense;
                                            if (iPlayerFINAL <= 0)
                                            {
                                                iPlayerFINAL = 0;
                                            }
                                            Console.Write("BASH!!! ");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write(iPlayerFINAL + " DMG\n");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            oCurrentEnemy.iEHealth = oCurrentEnemy.iEHealth - iPlayerFINAL;
                                            //if enemy HP negative make zero
                                            iPlayerTurn = 1;
                                            }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Not Enough AP");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            iPlayerTurn = 0;
                                        }
                                        break;



                                    //--------------------------------SKULL CRUSHER------------------------------------------//
                                    case 2://SKULL CRUSHER special attack requires 15 AP
                                        //CHANGE TO ANOTHER SWITCH TO OPEN ALL SPECIAL ATTACK OPTIONS
                                        Console.Clear();
                                        if (iPlayerAP >= 15 && iLevel >= 5)
                                        {
                                            SkullCrusherATK();
                                            iPlayerFINAL = iPlayerFINAL - oCurrentEnemy.iEDefense;
                                            if (iPlayerFINAL <= 0)
                                            {
                                                iPlayerFINAL = 0;
                                            }
                                            Console.Write("SKULL CRUSHER!!!!!!!");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write(iPlayerFINAL + " DMG\n");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            oCurrentEnemy.iEHealth = oCurrentEnemy.iEHealth - iPlayerFINAL;
                                            iPlayerTurn = 1;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Not Enough AP");
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            iPlayerTurn = 0;
                                        }
                                        break;

                                        ////------------------------------------------HEAL----------------------------////
                                    case 3://HEAL HP COST OF MANA
                                        {
                                            if (iLevel >= 10 && iPlayerAP >=25)
                                            {
                                                Heal1();
                                                iPlayerTurn = 1;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Not Enough AP");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                iPlayerTurn = 0;
                                            }
                                        }
                                        break;

                                    //--------------------------------COMBO STRIKE------------------------------------------//
                                    case 4://COMBO STRIKE must be lvl 12 and have 25 AP
                                        //CHANGE TO ANOTHER SWITCH TO OPEN ALL SPECIAL ATTACK OPTIONS
                                        Console.Clear();
                                        Random ComboRoll = new Random();
                                        int iCombo;
                                        if (iPlayerAP >= 30 && iLevel >= 17)
                                        {
                                            //run function 2-4 times with a random
                                            iCombo = ComboRoll.Next(1, 8);
                                            Console.WriteLine(iCombo);
                                            //BEGINS CHAIN
                                            if (iCombo >= 1)
                                            {
                                                //ONE
                                                ComboStrike();
                                                iPlayerFINAL = iPlayerFINAL - oCurrentEnemy.iEDefense;
                                                if (iPlayerFINAL <= 0)
                                                {
                                                    iPlayerFINAL = 0;
                                                }
                                                Console.Write("ONE!!");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write(iPlayerFINAL + " DMG\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                oCurrentEnemy.iEHealth = oCurrentEnemy.iEHealth - iPlayerFINAL;
                                                iComboDamage = iComboDamage + iPlayerFINAL;

                                                //TWO
                                                ComboStrike();
                                                iPlayerFINAL = iPlayerFINAL - oCurrentEnemy.iEDefense;
                                                if (iPlayerFINAL <= 0)
                                                {
                                                    iPlayerFINAL = 0;
                                                }
                                                Console.Write("TWO!!");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write(iPlayerFINAL + " DMG\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                oCurrentEnemy.iEHealth = oCurrentEnemy.iEHealth - iPlayerFINAL;
                                                iComboDamage = iComboDamage + iPlayerFINAL;

                                                //THREE
                                                if (iCombo >= 3)
                                                {
                                                    ComboStrike();
                                                    iPlayerFINAL = iPlayerFINAL - oCurrentEnemy.iEDefense;
                                                    if (iPlayerFINAL <= 0)
                                                    {
                                                        iPlayerFINAL = 0;
                                                    }
                                                    Console.Write("THREE!!");
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.Write(iPlayerFINAL + " DMG\n");
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    oCurrentEnemy.iEHealth = oCurrentEnemy.iEHealth - iPlayerFINAL;
                                                    iComboDamage = iComboDamage + iPlayerFINAL;
                                                }

                                                //FOUR
                                                if (iCombo == 4)
                                                {
                                                    ComboStrike();
                                                    iPlayerFINAL = iPlayerFINAL - oCurrentEnemy.iEDefense;
                                                    if (iPlayerFINAL <= 0)
                                                    {
                                                        iPlayerFINAL = 0;
                                                    }
                                                    Console.Write("MULTI SLASH!!!");
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.Write(iPlayerFINAL + " DMG\n");
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    oCurrentEnemy.iEHealth = oCurrentEnemy.iEHealth - iPlayerFINAL;
                                                    iComboDamage = iComboDamage + iPlayerFINAL;
                                                }
                                                //NEEDS TO BE GREEN
                                                Console.Write("TOTAL COMBO DAMAGE: "); 
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write(iComboDamage + " DMG\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                iPlayerTurn = 1;
                                            }
                                        }
                                        break;
                                        //DEATHBLOW-----------------
                                    case 5:
                                        {
                                            Console.Clear();
                                            if (iPlayerAP >= 50 && iLevel >= 25)
                                            {
                                                DeathBlow();
                                                iPlayerFINAL = iPlayerFINAL - oCurrentEnemy.iEDefense;
                                                if (iPlayerFINAL <= 0)
                                                {
                                                    iPlayerFINAL = 0;
                                                }
                                                Console.Write("WHACK!!!");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write(iPlayerFINAL + " DMG\n");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                oCurrentEnemy.iEHealth = oCurrentEnemy.iEHealth - iPlayerFINAL;
                                                iPlayerTurn = 1;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Not Enough AP");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                iPlayerTurn = 0;
                                            }
                                        }
                                        break;
                                    default:
                                        {
                                            Console.Clear();
                                            break;
                                        }
                                }
                            }
                                break;
                        //USE AN ITEM
                        case 3:
                                {
                                    //SHOW STAT PRINT
                                    Console.Clear();
                                    ItemCall();
                                    if (iItemChoice == 0)
                                    {
                                        Console.Clear();
                                        iPlayerTurn = 0;
                                    }
                                    else
                                    {
                                        //CONTINUE
                                        Console.Clear();
                                        iPlayerTurn = 1;
                                    }
                                    break;
                                }
                        default:
                                {
                                    Console.Clear();
                                    break;
                                }
                    }




                    //------------------------ENEMY FIGHTS BACK--------------------------------//
                    //if enemy HP is negative set to zero
                    if (oCurrentEnemy.iEHealth <= 0 && iPlayerTurn == 1)
                    {
                        oCurrentEnemy.iEHealth = 0;
                    }

                    if (oCurrentEnemy.iEHealth >= 1 && iPlayerTurn == 1)
                    {
                        Console.WriteLine();
                        Console.Write(oCurrentEnemy.sName);
                        Console.Write("'s Health ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(oCurrentEnemy.iEHealth);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        //if enemy isnt dead run this
                        oCurrentEnemy.EnemyATK();
                        //subtracts player defense from enemy attack
                        oCurrentEnemy.iEFinal = oCurrentEnemy.iEFinal - iPlayerDEF;
                        //CHANGES ENEMY ATTACK TO 0 IF NEGATIVE OR 0
                        if (oCurrentEnemy.iEFinal <= 0)
                        {
                            oCurrentEnemy.iEFinal = 0;
                        }
                        Console.Write(oCurrentEnemy.sName + " ATTACKS YOU!!! ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(oCurrentEnemy.iEFinal + " DMG\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        iPlayerHP = iPlayerHP - oCurrentEnemy.iEFinal;

                        //set to 0
                        if (iPlayerHP <= 0)
                        {
                            iPlayerHP = 0;
                        }
                        Console.Write("\nYour Current HP: ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(iPlayerHP);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        //CONTINUE
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        Console.Clear();
                        oCurrentEnemy.iEAttack = oCurrentEnemy.iEATKTemp;

                        //-------------------------------------------ENEMY SPECIAL ATTACKS-------------------------------------------------------------------//
                        //This is to get the Goblin King to do its special attack
                        if (oCurrentEnemy.iEType == 1)
                        {
                            oCurrentEnemy.GoblinKingSpecial();
                        }

                        //This is to get the Orc Lord to do its special attack
                        if (oCurrentEnemy.iEType == 2)
                        {

                            oCurrentEnemy.OrcKingPowerup();
                        }

                        //This is to have the dragon transform into the next stage
                        //This is to get the Dark Kaiser to do its special attack
                    }
                    if (oCurrentEnemy.iEType == 4)
                    {
                        oCurrentEnemy.DK();
                        oCurrentEnemy.EnemyATK();
                        Console.WriteLine("\nDark Kaiser attacks twice!");
                        //if enemy HP is negative set to zero

                        if (oCurrentEnemy.iEHealth <= 0 && iPlayerTurn == 1)
                        {
                            oCurrentEnemy.iEHealth = 0;
                        }

                        if (oCurrentEnemy.iEHealth >= 1 && iPlayerTurn == 1)
                        {
                            Console.WriteLine();
                            Console.Write(oCurrentEnemy.sName);
                            Console.Write("'s Health ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(oCurrentEnemy.iEHealth);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            //if enemy isnt dead run this
                            oCurrentEnemy.EnemyATK();
                            //subtracts player defense from enemy attack
                            oCurrentEnemy.iEFinal = oCurrentEnemy.iEFinal - iPlayerDEF;
                            //CHANGES ENEMY ATTACK TO 0 IF NEGATIVE OR 0
                            if (oCurrentEnemy.iEFinal <= 0)
                            {
                                oCurrentEnemy.iEFinal = 0;
                            }
                            Console.Write(oCurrentEnemy.sName + " ATTACKS YOU!!! ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(oCurrentEnemy.iEFinal + " DMG\n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            iPlayerHP = iPlayerHP - oCurrentEnemy.iEFinal;

                            //set to 0
                            if (iPlayerHP <= 0)
                            {
                                iPlayerHP = 0;
                            }
                            Console.Write("\nYour Current HP: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(iPlayerHP);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            //CONTINUE
                            Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                            Console.ReadKey();
                            Console.Clear();
                            oCurrentEnemy.iEAttack = oCurrentEnemy.iEATKTemp;
                            oCurrentEnemy.iEATKTemp = 9999;
                        }
                    }


                    //if enemy is dead
                    if (oCurrentEnemy.iEHealth <= 0)
                    {
                        Console.WriteLine("\nYou killed a " + oCurrentEnemy.sName);
                        iCurrentEXP = oCurrentEnemy.iEGiveEXP + iCurrentEXP;
                        iPlayerGold = oCurrentEnemy.iEGiveGold + iPlayerGold;

                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("YOU WIN!!!");
                        Console.Write("\nYou have gained: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(oCurrentEnemy.iEGiveEXP);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" EXP");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("EXP NEEDED FOR NEXT LEVEL: ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(iCurrentEXP);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("/");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(iEXPCap);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("\nYou have gained: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(oCurrentEnemy.iEGiveGold);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" GOLD");
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        Console.Clear();
                        if (iCurrentEXP >= iEXPCap)
                        {
                            do
                            {
                                //RUN LEVEL UP FUNCTION
                                LevelUp();

                            }
                            while (iCurrentEXP >= iEXPCap);
                        }
                    }
                    if (oCurrentEnemy.iEType == 3 && oCurrentEnemy.iEHealth == 0)
                    {
                        //THIS CREATES DARK KAISER
                        oCurrentEnemy = new Enemies(30);
                        //THE PLAYER KNOWS WHATS HAPPENING WITH THE BOSS AFTER DEAFEATING IT
                        Console.WriteLine(sName + " rips through the Red Dragons chest and blood starts to gush out.");
                        Console.Write("");
                        //THE BOSS CHANGES AND THE PLAYER HAS TO FIGHT IT AGAIN
                        Console.WriteLine("\nThe Red Dragon begins to manifest and transforms .... ");

                    }
                }
                //end of battle loop
                while (oCurrentEnemy.iEHealth > 0 && iPlayerHP > 0);
        }
    }
}