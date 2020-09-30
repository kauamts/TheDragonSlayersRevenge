using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragonSlayersRevenge
{
    class Enemies //This is the Enemy Controller
    {
        //MAIN FUNCTIONS

        //NAME
        public string sName;
        //THE  ATTACK
        public int iEAttack;
        //THE  DEFENSE
        public int iEDefense;
        //THE HEALTH
        public int iEHealth;
        //TOTAL ATTACK(DAMAGED DONE)
        public int iEFinal;
        //STORE THE TEMPORARY ATTACK
        public int iEATKTemp;
        //EXPERIENCE POINTS
        public int iEGiveEXP;
        //MONEY GIVEN
        public int iEGiveGold;
        //GOBLIN KINGS COMEBACK
        int iGobKingSpec;
        //ORC KINDS COMEBACK
        int iOrcKingPWR;
        //ENEMY TYPE FOR SPECIAL ATTACK
        public int iEType;
        // DARK KAISERS SPECIAL ATTACK
        int iDKHit;



        public Enemies(int race)
        {
            switch (race)
            {
                //PLAINS OF NEVERMORE (cases 1-7)

                //AREA 1-------LV 1- 5-----------------------------//
                case 1: //Boar
                    //NAME
                    sName = "Boar";
                    //THE  ATTACK
                    iEAttack = 25;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 25;
                    //THE  DEFENSE
                    iEDefense = 80;
                    //THE HEALTH
                    iEHealth = 25;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 50;
                    //MONEY GIVEN
                    iEGiveGold = 40;


                    break;
                case 2: //Giant Spider
                    //NAME
                    sName = "Giant Spider";
                    //THE  ATTACK
                    iEAttack = 15;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 15;
                    //THE  DEFENSE
                    iEDefense = 50;
                    //THE HEALTH
                    iEHealth = 150;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 75;

                    iEGiveGold = 40;

                    break;
                case 3: //Grey Wolf
                    //NAME
                    sName = "Grey Wolf";
                    //THE  ATTACK
                    iEAttack = 25;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 25;
                    //THE  DEFENSE
                    iEDefense = 70;
                    //THE HEALTH
                    iEHealth = 200;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 100;
                    //MONEY GIVEN
                    iEGiveGold = 65;

                    break;

                case 4: //Plain Titan
                    //NAME
                    sName = "Plain Titan";
                    //THE  ATTACK
                    iEAttack = 20;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 20;
                    //THE  DEFENSE
                    iEDefense = 90;
                    //THE HEALTH
                    iEHealth = 250;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 110;
                    //MONEY GIVEN
                    iEGiveGold = 65;

                    break;

                //MARSHES OF INSOLENCE
                //AREA 2------LV 6 - 15 ----------------------//

                case 5: //Bog Beast
                    //NAME
                    sName = "Bog Beast";
                    //THE  ATTACK
                    iEAttack = 70;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 70;
                    //THE  DEFENSE
                    iEDefense = 90;
                    //THE HEALTH
                    iEHealth = 500;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 250;
                    //MONEY GIVEN
                    iEGiveGold = 70;

                    break;


                case 6: //Lazy Goblin
                    //NAME
                    sName = "Lazy Goblin";
                    //THE  ATTACK
                    iEAttack = 90;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 90;
                    //THE  DEFENSE
                    iEDefense = 110;
                    //THE HEALTH
                    iEHealth = 550;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 300;
                    //MONEY GIVEN
                    iEGiveGold = 70;

                    break;

                case 7: //Earth Troll
                    //NAME
                    sName = "Earth Troll";
                    //THE  ATTACK
                    iEAttack = 60;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 60;
                    //THE  DEFENSE
                    iEDefense = 125;
                    //THE HEALTH
                    iEHealth = 700;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 350;
                    //MONEY GIVEN
                    iEGiveGold = 35;

                    break;

                case 8: //Anaconda
                    //NAME
                    sName = "Anaconda";
                    //THE  ATTACK
                    iEAttack = 120;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 120;
                    //THE  DEFENSE
                    iEDefense = 50;
                    //THE HEALTH
                    iEHealth = 600;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 450;
                    //MONEY GIVEN
                    iEGiveGold =120;

                    break;

                //GOBLINS CAVE
                //AREA 2-1 (GOBLIN CAVE)------LV 16 - 20 ----------------------//

                case 9: //Vampire Bat
                    //NAME
                    sName = "Vampire Bat";
                    //THE  ATTACK
                    iEAttack = 180;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 180;
                    //THE  DEFENSE
                    iEDefense = 155;
                    //THE HEALTH
                    iEHealth = 800;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 650;
                    //MONEY GIVEN
                    iEGiveGold = 140;

                    break;

                case 10: //Goblin Warrior
                    //NAME
                    sName = "Goblin Warrior";
                    //THE  ATTACK
                    iEAttack = 200;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 200;
                    //THE  DEFENSE
                    iEDefense = 100;
                    //THE HEALTH
                    iEHealth = 850;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 700;
                    //MONEY GIVEN
                    iEGiveGold = 200;

                    break;

                case 11: //Goblin Shaman 
                    //NAME
                    sName = "Goblin Shaman";
                    //ATTACK
                    iEAttack = 230;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 230;
                    //THE  DEFENSE
                    iEDefense = 175;
                    //THE HEALTH
                    iEHealth = 1450;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 1000;
                    //MONEY GIVEN
                    iEGiveGold = 200;

                    break;

                case 12: //Orge
                    //NAME
                    sName = "Orge";
                    //THE  ATTACK
                    iEAttack = 190;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 190;
                    //THE  DEFENSE
                    iEDefense = 190;
                    //THE HEALTH
                    iEHealth = 1890;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 750;
                    //MONEY GIVEN
                    iEGiveGold = 150;

                    break;

                //GOBLINS CAVE(BOSS FIGHT)
                //TITLE AREA 2-2 (CAVE - BOSS)------LV 16 - 20 ----------------------//

                case 13: //Goblin King 
                    //NAME
                    sName = "Goblin King";
                    //THE  ATTACK
                    iEAttack = 400;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 400;
                    //THE  DEFENSE
                    iEDefense = 200;
                    //THE HEALTH
                    iEHealth = 2200;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 3000;
                    //MONEY GIVEN
                    iEGiveGold = 500;
                    //ENEMY TYPE FOR SPECIAL ATTACK
                    iEType = 1;

                    //Drops speical items???

                    break;

                //new ability unlocked (COMBO)


                //AZAZEL'S DESERT
                //AREA 3----------------LV 21 - 26 ----------------------//

                case 14: //Scorpion 
                    //NAME
                    sName = "Scorpion";
                    //THE  ATTACK
                    iEAttack = 340;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 340;
                    //THE  DEFENSE
                    iEDefense = 180;
                    //THE HEALTH
                    iEHealth = 1800;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 1000;
                    //MONEY GIVEN
                    iEGiveGold = 350;

                    break;

                case 15: //Cobra King
                    //NAME
                    sName = "Cobra King";
                    //THE  ATTACK
                    iEAttack = 370;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 370;
                    //THE  DEFENSE
                    iEDefense = 200;
                    //THE HEALTH
                    iEHealth = 2500;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 1300;
                    //MONEY GIVEN
                    iEGiveGold = 400;

                    break;

                case 16: //FireWing 
                    //NAME
                    sName = "FireWing";
                    //THE  ATTACK
                    iEAttack = 400;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 400;
                    //THE  DEFENSE
                    iEDefense = 350;
                    //THE HEALTH
                    iEHealth = 2200;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 1500;
                    //MONEY GIVEN
                    iEGiveGold = 500;

                    break;

                case 17: //Cacti-Fighter
                    //NAME
                    sName = "Cacti-Fighter";
                    //THE  ATTACK
                    iEAttack = 450;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 450;
                    //THE  DEFENSE
                    iEDefense = 300;
                    //THE HEALTH
                    iEHealth = 2700;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 1700;
                    //MONEY GIVEN
                    iEGiveGold = 600;

                    break;

                //ORC'S GARRISON
                //AREA 3----------------LV 27 - 32 ----------------------//

                case 18: //Skeleton 
                    //NAME
                    sName = "Skeleton";
                    //THE  ATTACK
                    iEAttack = 550;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 550;
                    //THE  DEFENSE
                    iEDefense = 400;
                    //THE HEALTH
                    iEHealth = 2600;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 2000;
                    //MONEY GIVEN
                    iEGiveGold = 800;

                    break;

                case 19: //Orochi  
                    //NAME
                    sName = "Orochi";
                    //THE  ATTACK
                    iEAttack = 470;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 470;
                    //THE  DEFENSE
                    iEDefense = 100;
                    //THE HEALTH
                    iEHealth = 3500;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 1900;
                    //MONEY GIVEN
                    iEGiveGold = 900;

                    break;

                case 20: //Orc 
                    //NAME
                    sName = "Orc";
                    //THE  ATTACK
                    iEAttack = 600;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 600;
                    //THE  DEFENSE
                    iEDefense = 450;
                    //THE HEALTH
                    iEHealth = 2800;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 2400;
                    //MONEY GIVEN
                    iEGiveGold = 1100;

                    break;

                case 21: //Orc Grunt
                    //NAME
                    sName = "Orc Grunt";
                    //THE  ATTACK
                    iEAttack = 650;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 650;
                    //THE  DEFENSE
                    iEDefense = 100;
                    //THE HEALTH
                    iEHealth = 3800;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 1800;
                    //MONEY GIVEN
                    iEGiveGold = 1500;

                    break;

                case 22: //Undead Orc
                    //NAME
                    sName = "Undead Orc";
                    //THE  ATTACK
                    iEAttack = 620;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 620;
                    //THE  DEFENSE
                    iEDefense = 500;
                    //THE HEALTH
                    iEHealth = 3000;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 2700;
                    //MONEY GIVEN
                    iEGiveGold = 1000;

                    break;

                //ORC'S GARRISON(BOSS FIGHT)
                //TITLE AREA 3-2 (NEXT - BOSS)------LV 27 - 32 ----------------------//

                case 23: //Orc Lord
                    //NAME
                    sName = "Orc Lord";
                    //THE  ATTACK
                    iEAttack = 1000;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 1000;
                    //THE  DEFENSE
                    iEDefense = 750;
                    //THE HEALTH
                    iEHealth = 4500;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 6000;
                    //MONEY GIVEN
                    iEGiveGold = 1250;
                    //ENEMY TYPE FOR SPECIAL ATTACK
                    iEType = 2;

                    break;

                //the weaker the boss gets the stronger he gets(problem health increases not attack!)


                //DRAGON'S LAYER
                //AREA 4 ----------------LV 33 - 40 ----------------------//


                case 24: //Guardian
                    //NAME
                    sName = "Guardian";
                    //THE  ATTACK
                    iEAttack = 800;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 800;
                    //THE  DEFENSE
                    iEDefense = 750;
                    //THE HEALTH
                    iEHealth = 4000;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 3000;
                    //MONEY GIVEN
                    iEGiveGold = 2000;

                    break;

                case 25: //Dragoon
                    //NAME
                    sName = "Dragoon";
                    //THE  ATTACK
                    iEAttack = 900;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 900;
                    //THE  DEFENSE
                    iEDefense = 850;
                    //THE HEALTH
                    iEHealth = 3800;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 3200;
                    //MONEY GIVEN
                    iEGiveGold = 2500;

                    break;

                case 26: //Gargoyle
                    //NAME
                    sName = "Gargoyle";
                    //THE  ATTACK
                    iEAttack = 1000;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 1000;
                    //THE  DEFENSE
                    iEDefense = 900;
                    //THE HEALTH
                    iEHealth = 4350;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 3500;
                    //MONEY GIVEN
                    iEGiveGold = 2750;

                    break;

                case 27: //Night Rider
                    //NAME
                    sName = "Night Rider";
                    //THE  ATTACK
                    iEAttack = 1250;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 1250;
                    //THE  DEFENSE
                    iEDefense = 600;
                    //THE HEALTH
                    iEHealth = 4800;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 3800;
                    //MONEY GIVEN
                    iEGiveGold = 2900;

                    break;

                //rare enemy that shows up 

                case 28: //Shadow
                    //NAME
                    sName = "Shadow";
                    //THE  ATTACK
                    iEAttack = 800;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 800;
                    //THE  DEFENSE
                    iEDefense = 1000;
                    //THE HEALTH
                    iEHealth = 2000;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 5000;
                    //MONEY GIVEN
                    iEGiveGold = 5000;

                    break;

                //DRAGON'S LAYER(BOSS FIGHT)
                //TITLE AREA 4-2 (LAST BOSS FIGHT)------LV 33 - 40 ----------------------//

                case 29: //Wyvern
                    //NAME
                    sName = "Red Dragon";
                    //THE  ATTACK
                    iEAttack = 5000;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 5000;
                    //THE  DEFENSE
                    iEDefense = 1600;
                    //THE HEALTH
                    iEHealth = 5000;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 7500;
                    //MONEY GIVEN
                    iEGiveGold = 20000;
                    //ENEMY TYPE FOR SPECIAL ATTACK
                    iEType = 3;

                    break;

                case 30: //Dark Kaiser
                    //NAME
                    sName = "Dark Kaiser";
                    //THE  ATTACK
                    iEAttack = 9999;
                    //STORE THE TEMPORARY ATTACK
                    iEATKTemp = 9999;
                    //THE  DEFENSE
                    iEDefense = 2000;
                    //THE HEALTH
                    iEHealth = 12000;
                    //EXPERIENCE POINTS
                    iEGiveEXP = 10000;
                    //MONEY GIVEN
                    iEGiveGold = 100000;
                    //ENEMY TYPE FOR SPECIAL ATTACK
                    iEType = 4;

                    break;

            }
        }

        //CURRENT ENEMIES ATTACK
        public int EnemyATK()
        {
            iEAttack = iEATKTemp;
            iEFinal = iEAttack;
            return iEFinal;
        }

        //goblin kings special attacks and abilities case #14
        public void GoblinKingSpecial()
        {

            //if the health is 650 or below then the health will start to regenerate
            if (iEHealth <= 650)
            {
                //Goblin will get a certain amount of health back between 25 to 75 for health
                Random GobKingSpecRoll = new Random();
                iGobKingSpec = GobKingSpecRoll.Next(25, 75);

                iEHealth = iEHealth + iGobKingSpec;
                Console.WriteLine("\n***REGENERATE***");
                Console.Write("Goblin King Heals ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("+" + iGobKingSpec);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("HP");
            }
        }

        //Orc King special attack event, case 24
        public void OrcKingPowerup()
        {// the Orc gains +50 to his attack once his health is below 1500 in health
            iOrcKingPWR = +50;
            //if health is below 1500 or equal then the monsters powers will increase
            if (iEHealth <= 1500)
            {
                iEATKTemp = iEATKTemp + iOrcKingPWR;
                Console.WriteLine("\nOrc Lord's is furious");
                Console.Write("Orc Lord's increases his power ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("+" + iOrcKingPWR);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("ATK");
            }
        }

        //Dark Kaiser special attack event, case 30
        public void DK()
        {
            //The enemy gets another chance to hit


            Random DKNRoll = new Random();
            iDKHit = DKNRoll.Next(50, 200);
            //the second attack that the kaiser does after the first hit
            iEATKTemp = iEATKTemp + iDKHit;

        }





    }
}
