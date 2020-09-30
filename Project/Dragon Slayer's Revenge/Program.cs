using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DragonSlayersRevenge
{
    class Program //This is the Game Controller
    {
        static void Main(string[] args)
        {
            Console.Title = "Dragon Slayer's Revenge";
            //sets window size
            //Console.SetWindowSize(120, 58);
            //declare the bosses' quests
            int iGoblinKingQ = 1;
            int iOrcKingQ = 1;
            int iRedDragonQ = 1;
            //Ship that travels between Valeria Village and Wolf Haven
            int iShipChoice;
            //players name
            string sPName;
            //GameOver Value
            int iGameOver = 0;
            //Sets number that intro repeats
            int iIntroTimer = 1;
            int iGobi = 0;
            int iOrci = 0;

            //Welcome Screen
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                 DRAGON SLAYER'S REVENGE");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                 DRAGON SLAYER'S REVENGE");
                Thread.Sleep(100);
                Console.Clear();
                iIntroTimer = iIntroTimer + 1;
            } while (iIntroTimer < 15);

            //Start Screen
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                 DRAGON SLAYER'S REVENGE");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                                   PRESS ENTER TO START");
            Console.ReadKey();
            Console.Clear();
            //Credits
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                 -------------------GAME CREATED BY-------------------");
            Console.WriteLine("\n\n\n                                                     GAURAV SHARMA");
            Console.WriteLine("\n                                                       JEFF SHAW");
            Console.WriteLine("\n                                                 KAUAM TRIPOLONE SILVA");
            Console.WriteLine("\n                                                       TIM WIRCH");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n                                             >>PRESS ANY KEY TO CONTINUE<<");
            Console.ReadKey();
            Console.Clear();



            //Field 1 Choice
            int iFieldChoice = 0;
            Console.WriteLine("\n\n   DRAGON SLAYER'S REVENGE");
            Console.WriteLine("\n   Please insert player name");
            Console.Write("   ");
            sPName = Console.ReadLine();
            //needs a player name to continue
            Player oPlayer = new Player(sPName);


            //INTRO CUTSCENE
            Console.Clear();
            Console.WriteLine("\n\n    \"This is the tale of the greatest Dragon Slayer the world has ever known...\n\n     It all began when " + sPName + " was only a farmer, helping his old dad,\n\n     clearing the crops from animals that would eventually show up and eat the corn.\n\n     But among all these ordinary tasks, something would change his life forever...\"");
            Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
            Console.ReadKey();


            //======================================================AREAS===================================//
            do
            {

                //"""""""""""""""""""""CONSTRUCT YOUR AREA OBJECT HERE"""""""""""""""//




                //IF YOU ARE HOME-----------------------------------------------------
                if (oPlayer.iCurrentArea == 0)
                {
                    Console.Clear();
                    Console.WriteLine("CURRENT AREA: HOME");
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("1 = Rest");
                    Console.WriteLine("2 = Check Status");
                    Console.WriteLine("3 = Travel to 'The Plains of Nevermore'");
                    //Gets player choice
                    Console.WriteLine();
                    Console.Write("Choice: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    iFieldChoice = 100;
                    string iFieldChoices = Console.ReadLine();
                    if (iFieldChoices == "0")
                    {
                        iFieldChoice = 0;
                    }
                    if (iFieldChoices == "1")
                    {
                        iFieldChoice = 1;
                    }
                    if (iFieldChoices == "2")
                    {
                        iFieldChoice = 2;
                    }
                    if (iFieldChoices == "3")
                    {
                        iFieldChoice = 3;
                    }
                    if (iFieldChoices == "4")
                    {
                        iFieldChoice = 4;
                    }
                    if (iFieldChoices == "5")
                    {
                        iFieldChoice = 5;
                    }
                    //iFieldChoice = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    //HOME CHOICE
                    switch (iFieldChoice)
                    {
                        case 1:
                            {

                                oPlayer.RestHome();
                                break;
                            }
                        case 2:
                            {
                                oPlayer.CheckStatus();
                                break;
                            }
                        case 3:
                            {
                                oPlayer.iCurrentArea = 1;
                                break;
                            }
                        
                    }
                }

                //AREAS(FIELDS) AND QUEST FIELDS-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                //IF YOU ARE IN AREA ONE---------------------------------------------------
                //AREAS SHOULD BE FUNCTIONS THAT CHANGE YOUR CURRENT AREA VARIABLE

                //Enter First Area - "Plains of Nevermore"
                if (oPlayer.iCurrentArea == 1)
                {
                    //player choice in the 1st field
                    Console.Clear();
                    Console.WriteLine("CURRENT AREA: PLAINS OF NEVERMORE (LVL 1 -7)");
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("1 = Hunt");
                    Console.WriteLine("2 = Check Status");
                    Console.WriteLine("3 = Travel to 'Home'");
                    //Gets player choice
                    Console.WriteLine();
                    Console.Write("Choice: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    iFieldChoice = 100;
                    string iFieldChoices = Console.ReadLine();
                    if (iFieldChoices == "0")
                    {
                        iFieldChoice = 0;
                    }
                    if (iFieldChoices == "1")
                    {
                        iFieldChoice = 1;
                    }
                    if (iFieldChoices == "2")
                    {
                        iFieldChoice = 2;
                    }
                    if (iFieldChoices == "3")
                    {
                        iFieldChoice = 3;
                    }
                    if (iFieldChoices == "4")
                    {
                        iFieldChoice = 4;
                    }
                    if (iFieldChoices == "5")
                    {
                        iFieldChoice = 5;
                    }
                    //iFieldChoice = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    switch (iFieldChoice)
                    {
                        case 1://FIGHT
                            {
                                Console.Clear();
                                Console.WriteLine("Hunting...");
                                oPlayer.Area1Battle();

                                //if player dies player is sent home
                                //area return can be changed depending on current area IE AREA 1 = HOME RESPAWN AREA 2 = TOWN RESPAWN
                                if (oPlayer.iPlayerHP <= 0)
                                {
                                    oPlayer.iCurrentArea = 0;
                                    Console.WriteLine("YOU HAVE BEEN KNOCKED OUT");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                }
                                break;
                            }
                        case 2://CHECK STATUS
                            {
                                oPlayer.CheckStatus();
                                break;
                            }
                        case 3://TRAVEL HOME
                            {
                                oPlayer.iCurrentArea = 0;
                                break;

                            }
                    }

                    //ENGAGES JOURNEY TO NEXT AREA
                    if (oPlayer.iLevel >= 7)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n    \"While he was away the sky turned black, the air filled with a dense black smoke.\n\n     He had a feeling something was wrong and ran towards the village...\n\n     He was too late. As he stumbled across the path of fire, the images of the bodies\n\n     lying on the ground became clearer. His family... his friends... everyone...\n\n     Everyone he ever cared about was piled and burned in front of him.\n\n     Beside the pile standed a giant terrifying Red Dragon.\n\n     Upon realizing the hero's presence, the Dragon attacked.\n\n     That was his last memory of that horrible moment... His heart was now burning in rage,\n\n     begging for revenge! He wasn't ready yet, but his time would come...\"");
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                        oPlayer.iCurrentArea = 2;
                        Console.Clear();
                        Console.WriteLine("\n\nInn Keeper: \"Hello, how are you feeling? You've been out for a while... That Dragon almost killed you!\n\n             I'm... I'm sorry, I shouldn't really talk about this... I'm sorry for your loss...\n\n             I guess you might have questions... You're on Valeria Village's Inn.\n\n             Don't worry, I won't charge you a penny...\n\n             Well, you seen good now... I should go. Wish you well!\"");
                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                        Console.ReadKey();
                    }
                }



                //Enter Second Area - "Marshes of Insolence"
                if (oPlayer.iCurrentArea == 5)
                {

                    //player choice in the 2nd field
                    Console.Clear();
                    Console.WriteLine("CURRENT AREA: MARSHES OF INSOLENCE  (LVL 7 - 16)");
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("1 = Fight");
                    Console.WriteLine("2 = Check Status");
                    Console.WriteLine("3 = Travel to 'Valeria Village'");
                    Console.WriteLine("4 = Travel to 'Goblins' Cave'  (LVL 16 -20)");
                    //Gets player choice
                    Console.WriteLine();
                    Console.Write("Choice: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    iFieldChoice = 100;
                    string iFieldChoices = Console.ReadLine();
                    if (iFieldChoices == "0")
                    {
                        iFieldChoice = 0;
                    }
                    if (iFieldChoices == "1")
                    {
                        iFieldChoice = 1;
                    }
                    if (iFieldChoices == "2")
                    {
                        iFieldChoice = 2;
                    }
                    if (iFieldChoices == "3")
                    {
                        iFieldChoice = 3;
                    }
                    if (iFieldChoices == "4")
                    {
                        iFieldChoice = 4;
                    }
                    if (iFieldChoices == "5")
                    {
                        iFieldChoice = 5;
                    }
                    //iFieldChoice = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    switch (iFieldChoice)
                    {
                        case 1://FIGHT
                            {
                                Console.Clear();
                                Console.WriteLine("Looking for a fight...");
                                oPlayer.Area1Battle();

                                //if player dies player is sent back to city

                                if (oPlayer.iPlayerHP <= 0)
                                {
                                    oPlayer.iCurrentArea = 2;
                                    Console.WriteLine("YOU HAVE BEEN KNOCKED OUT");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                }
                                break;
                            }
                        case 2://CHECK STATUS
                            {
                                oPlayer.CheckStatus();
                                break;
                            }
                        case 3://TRAVEL to City
                            {
                                oPlayer.iCurrentArea = 2;

                                break;

                            }
                        case 4://TRAVEL TO Goblins' Cave
                            {
                                oPlayer.iCurrentArea = 6;
                                break;
                            }

                    }



                }



                //Enter Second Area - "Goblins' Cave"
                if (oPlayer.iCurrentArea == 6)
                {

                    //player choice in the 1st QUEST field
                    Console.Clear();
                    Console.WriteLine("CURRENT AREA: GOBLINS' CAVE (LVL 16 -20)");
                    Console.WriteLine("\nWhat would you like to do?");
                    if (iGoblinKingQ != 1)
                    {
                        Console.WriteLine("The Cave is Empty");
                    }
                    else
                    {
                        Console.WriteLine("1 = Fight The King");
                    }
                    Console.WriteLine("2 = Check Status");
                    Console.WriteLine("3 = Travel to 'Marshes of Insolence' (LVL 7 - 16)");
                    //Gets player choice
                    Console.WriteLine();
                    Console.Write("Choice: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    iFieldChoice = 100;
                    string iFieldChoices = Console.ReadLine();
                    if (iFieldChoices == "0")
                    {
                        iFieldChoice = 0;
                    }
                    if (iFieldChoices == "1")
                    {
                        iFieldChoice = 1;
                    }
                    if (iFieldChoices == "2")
                    {
                        iFieldChoice = 2;
                    }
                    if (iFieldChoices == "3")
                    {
                        iFieldChoice = 3;
                    }
                    if (iFieldChoices == "4")
                    {
                        iFieldChoice = 4;
                    }
                    if (iFieldChoices == "5")
                    {
                        iFieldChoice = 5;
                    }
                    //iFieldChoice = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    switch (iFieldChoice)
                    {
                        case 1://FIGHT
                            {
                                if (iGoblinKingQ == 1)
                                {
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Searching for the Goblin King...");
                                        oPlayer.Area1Battle();
                                        iGobi++;
                                    }
                                    while (iGobi <= 3 && oPlayer.iPlayerHP > 0);

                                    //if player dies player is sent back to city

                                    if (oPlayer.iPlayerHP <= 0)
                                    {
                                        oPlayer.iCurrentArea = 2;
                                        Console.WriteLine("YOU HAVE BEEN KNOCKED OUT");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        iGobi = 0;
                                    }
                                    if (iGobi >= 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("THE KING APPROCHES");
                                        oPlayer.iCurrentArea = 11;
                                        oPlayer.Area1Battle();

                                        //if player dies player is sent back to city

                                        if (oPlayer.iPlayerHP <= 0)
                                        {
                                            oPlayer.iCurrentArea = 2;
                                            Console.WriteLine("YOU HAVE BEEN KNOCKED OUT");
                                            Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.WriteLine("CONGRATULATIONS YOU HAVE DEFEATED THE GOBLIN KING");
                                            Console.WriteLine("RETURN TO TOWN FOR YOU REWARD");
                                            Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                            Console.ReadKey();
                                            oPlayer.iCurrentArea = 5;
                                            iGoblinKingQ = 0;
                                        }
                                    }
                                }
                                break;
                            }
                        case 2://CHECK STATUS
                            {
                                oPlayer.CheckStatus();
                                break;
                            }
                        case 3://TRAVEL back to field
                            {
                                oPlayer.iCurrentArea = 5;

                                break;

                            }

                    }

                }


                //Enter Second Area - "Azazel's Desert"
                if (oPlayer.iCurrentArea == 7)
                {

                    //player choice in the 3rd field
                    Console.Clear();
                    Console.WriteLine("CURRENT AREA: AZAZEL'S DESERT (LVL 21 - 26)");
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("1 = Fight");
                    Console.WriteLine("2 = Check Status");
                    Console.WriteLine("3 = Travel to 'Wolf Haven'");
                    Console.WriteLine("4 = Travel to 'Orcs' Garrison' (LVL 27 - 32)");
                    //Gets player choice
                    Console.WriteLine();
                    Console.Write("Choice: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    iFieldChoice = 100;
                    string iFieldChoices = Console.ReadLine();
                    if (iFieldChoices == "0")
                    {
                        iFieldChoice = 0;
                    }
                    if (iFieldChoices == "1")
                    {
                        iFieldChoice = 1;
                    }
                    if (iFieldChoices == "2")
                    {
                        iFieldChoice = 2;
                    }
                    if (iFieldChoices == "3")
                    {
                        iFieldChoice = 3;
                    }
                    if (iFieldChoices == "4")
                    {
                        iFieldChoice = 4;
                    }
                    if (iFieldChoices == "5")
                    {
                        iFieldChoice = 5;
                    }
                    //iFieldChoice = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    switch (iFieldChoice)
                    {
                        case 1://FIGHT
                            {
                                Console.Clear();
                                Console.WriteLine("Looking for a fight...");
                                oPlayer.Area1Battle();

                                //if player dies player is sent back to city

                                if (oPlayer.iPlayerHP <= 0)
                                {
                                    oPlayer.iCurrentArea = 3;
                                }
                                break;
                            }
                        case 2://CHECK STATUS
                            {
                                oPlayer.CheckStatus();
                                break;
                            }
                        case 3://TRAVEL to City
                            {
                                oPlayer.iCurrentArea = 3;

                                break;

                            }
                        case 4://TRAVEL TO Orcs' Garrison
                            {
                                oPlayer.iCurrentArea = 8;
                                break;
                            }

                    }



                }


                //Enter Second Area - "Orcs' Garrison"
                if (oPlayer.iCurrentArea == 8)
                {

                    //player choice in the 2nd QUEST field
                    Console.Clear();
                    Console.WriteLine("CURRENT AREA: ORCS' GARRISON (LVL 27 - 32)");
                    Console.WriteLine("\nWhat would you like to do?");
                    if (iOrcKingQ != 1)
                    {
                        Console.WriteLine("The Garrison is empty.");
                    }
                    else
                    {
                        Console.WriteLine("1 = Battle The King");
                    }
                    Console.WriteLine("2 = Check Status");
                    Console.WriteLine("3 = Travel to 'Azazel's Desert' (LVL 21 - 26)");
                    //Gets player choice
                    Console.WriteLine();
                    Console.Write("Choice: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    iFieldChoice = 100;
                    string iFieldChoices = Console.ReadLine();
                    if (iFieldChoices == "0")
                    {
                        iFieldChoice = 0;
                    }
                    if (iFieldChoices == "1")
                    {
                        iFieldChoice = 1;
                    }
                    if (iFieldChoices == "2")
                    {
                        iFieldChoice = 2;
                    }
                    if (iFieldChoices == "3")
                    {
                        iFieldChoice = 3;
                    }
                    if (iFieldChoices == "4")
                    {
                        iFieldChoice = 4;
                    }
                    if (iFieldChoices == "5")
                    {
                        iFieldChoice = 5;
                    }
                    //iFieldChoice = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    switch (iFieldChoice)
                    {
                        case 1://FIGHT
                            if (iOrcKingQ == 1)
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("Searching for the Orc King...");
                                    oPlayer.Area1Battle();

                                    iOrci++;
                                }
                                while (iOrci <= 5 && oPlayer.iPlayerHP > 0);

                                //if player dies player is sent back to city

                                if (oPlayer.iPlayerHP <= 0)
                                {
                                    oPlayer.iCurrentArea = 3;
                                    Console.WriteLine("YOU HAVE BEEN KNOCKED OUT");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    iOrci = 0;
                                }
                                if (iOrci >= 5)
                                {
                                    oPlayer.iCurrentArea = 12;
                                    Console.Clear();
                                    Console.WriteLine("THE KING APPROCHES");
                                    oPlayer.Area1Battle();

                                    //if player dies player is sent back to city

                                    if (oPlayer.iPlayerHP <= 0)
                                    {
                                        oPlayer.iCurrentArea = 3;
                                        Console.WriteLine("YOU HAVE BEEN KNOCKED OUT");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("CONGRATULATIONS YOU HAVE DEFEATED THE ORC KING");
                                        Console.WriteLine("RETURN TO TOWN FOR YOU REWARD");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        oPlayer.iCurrentArea = 7;
                                        iOrcKingQ = 0;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("The Garrison is empty.");
                                Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                Console.ReadKey();
                            }
                                break;

                        case 2://CHECK STATUS
                            {
                                oPlayer.CheckStatus();
                                break;
                            }
                        case 3://TRAVEL back to field
                            {
                                oPlayer.iCurrentArea = 7;

                                break;

                            }

                    }

                }


                //Enter Second Area - "Alkemia Mountains"
                if (oPlayer.iCurrentArea == 9)
                {

                    //player choice in the 4th field
                    Console.Clear();
                    Console.WriteLine("CURRENT AREA: ALKEMIA MOUNTAINS (LVL 33 - 40)");
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("1 = Fight");
                    Console.WriteLine("2 = Check Status");
                    Console.WriteLine("3 = Travel to 'Alkemia Fortress' ");
                    Console.WriteLine("4 = Travel to 'Dragon's Lair'(LVL 40+)");
                    //Gets player choice
                    Console.WriteLine();
                    Console.Write("Choice: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    iFieldChoice = 100;
                    string iFieldChoices = Console.ReadLine();
                    if (iFieldChoices == "0")
                    {
                        iFieldChoice = 0;
                    }
                    if (iFieldChoices == "1")
                    {
                        iFieldChoice = 1;
                    }
                    if (iFieldChoices == "2")
                    {
                        iFieldChoice = 2;
                    }
                    if (iFieldChoices == "3")
                    {
                        iFieldChoice = 3;
                    }
                    if (iFieldChoices == "4")
                    {
                        iFieldChoice = 4;
                    }
                    if (iFieldChoices == "5")
                    {
                        iFieldChoice = 5;
                    }
                    //iFieldChoice = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    switch (iFieldChoice)
                    {
                        case 1://FIGHT
                            {
                                Console.Clear();
                                Console.WriteLine("Looking for a fight...");
                                oPlayer.Area1Battle();

                                //if player dies player is sent back to city

                                if (oPlayer.iPlayerHP <= 0)
                                {
                                    oPlayer.iCurrentArea = 4;
                                }
                                break;
                            }
                        case 2://CHECK STATUS
                            {
                                oPlayer.CheckStatus();
                                break;
                            }
                        case 3://TRAVEL to City
                            {
                                oPlayer.iCurrentArea = 4;

                                break;

                            }
                        case 4://TRAVEL TO Dragon's Lair
                            {
                                oPlayer.iCurrentArea = 10;
                                break;
                            }

                    }



                }


                //Enter Second Area - "Dragon's Lair"
                if (oPlayer.iCurrentArea == 10)
                {

                    //player choice in the 3rd QUEST field
                    Console.Clear();
                    Console.WriteLine("CURRENT AREA: DRAGON'S LAIR (LVL 40+)");
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("1 = Fight");
                    Console.WriteLine("2 = Check Status");
                    Console.WriteLine("3 = Travel to 'Alkemia Mountains' (LVL 33 - 40)");
                    //Gets player choice
                    Console.WriteLine();
                    Console.Write("Choice: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    iFieldChoice = 100;
                    string iFieldChoices = Console.ReadLine();
                    if (iFieldChoices == "0")
                    {
                        iFieldChoice = 0;
                    }
                    if (iFieldChoices == "1")
                    {
                        iFieldChoice = 1;
                    }
                    if (iFieldChoices == "2")
                    {
                        iFieldChoice = 2;
                    }
                    if (iFieldChoices == "3")
                    {
                        iFieldChoice = 3;
                    }
                    if (iFieldChoices == "4")
                    {
                        iFieldChoice = 4;
                    }
                    if (iFieldChoices == "5")
                    {
                        iFieldChoice = 5;
                    }
                    //iFieldChoice = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    switch (iFieldChoice)
                    {
                        case 1://FIGHT
                            if (iRedDragonQ == 1)
                            {

                                    Console.Clear();
                                    Console.WriteLine("PREPARING TO BATTLE TO RED DRAGON...");
                                    oPlayer.Area1Battle();

                                //if player dies player is sent back to city

                                if (oPlayer.iPlayerHP <= 0)
                                {
                                    oPlayer.iCurrentArea = 4;
                                    Console.WriteLine("YOU HAVE BEEN KNOCKED OUT");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    iRedDragonQ = 0;
                                }
                            }
                            break;

                        case 2://CHECK STATUS
                            {
                                oPlayer.CheckStatus();
                                break;
                            }
                        case 3://TRAVEL back to field
                            {
                                oPlayer.iCurrentArea = 9;

                                break;

                            }

                    }

                }


                //CITIES-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                //Enter First City - "VALERIA VILLAGE"
                if (oPlayer.iCurrentArea == 2)
                {
                    //player choice in the 1st city
                    Console.Clear();
                    Console.WriteLine("CURRENT AREA: VALERIA VILLAGE");
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("1 = Talk to Villagers");
                    Console.WriteLine("2 = Check Status");
                    Console.WriteLine("3 = Enter the 'Inn'");
                    Console.WriteLine("4 = Enter the 'Item Shop'");
                    Console.WriteLine("5 = Enter the 'Armory'");
                    Console.WriteLine("6 = Travel to 'Marshes of Insolence' (LVL 7 - 16)");
                    if (iGoblinKingQ == 3)
                    {
                        Console.WriteLine("7 = Take ship to 'Wolf Haven'");
                    }
                    //Gets player choice
                    Console.WriteLine();
                    Console.Write("Choice: ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    iFieldChoice = 100;
                    string iFieldChoices = Console.ReadLine();
                    if (iFieldChoices == "0")
                    {
                        iFieldChoice = 0;
                    }
                    if (iFieldChoices == "1")
                    {
                        iFieldChoice = 1;
                    }
                    if (iFieldChoices == "2")
                    {
                        iFieldChoice = 2;
                    }
                    if (iFieldChoices == "3")
                    {
                        iFieldChoice = 3;
                    }
                    if (iFieldChoices == "4")
                    {
                        iFieldChoice = 4;
                    }
                    if (iFieldChoices == "5")
                    {
                        iFieldChoice = 5;
                    }
                    if (iFieldChoices == "6")
                    {
                        iFieldChoice = 6;
                    }
                    if (iFieldChoices == "7")
                    {
                        iFieldChoice = 7;
                    }
                    if (iFieldChoices == "8")
                    {
                        iFieldChoice = 8;
                    }
                    if (iFieldChoices == "9")
                    {
                        iFieldChoice = 9;
                    }
                    if (iFieldChoices == "10")
                    {
                        iFieldChoice = 10;
                    }
                    //iFieldChoice = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    switch (iFieldChoice)
                    {
                        case 1://TALK TO VILLAGERS - 'GET QUEST'
                            {

                                if (iGoblinKingQ == 0)//If Goblin King is killed.
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\nOld man: \"You Killed the Goblin King! Our village is finally safe!!\n\n         Thank you so much " + sPName + "!!");
                                    Console.WriteLine("\n         Here's a little display of our gratitude.\"");
                                    Console.Write("\n\n         You won ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("1000");
                                    //Player Gets 1000 Gold
                                    oPlayer.iPlayerGold = oPlayer.iPlayerGold + 1000;
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write(" gold!");
                                    Console.Write("\n         Your current gold is: ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(oPlayer.iPlayerGold);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    //Asks the player to press enter! \o/
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    //Asks the player if he wants to go to the next city
                                    Console.Clear();
                                    Console.WriteLine("\n\n      A Merchant approches you...");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("\n\nItalian");
                                    Console.WriteLine("Merchant: \"Scusi signore! Are you the warrior looking for the Red Dragon?\n\n           I was sailing here yesterday when it flew over my ship! It was\n\n           flying towards 'Azazel's Desert', not far from 'Wolf Haven'.\n\n           I'm leaving for 'Wolf Haven' today. Come with me, I'll give you a\n\n           free ride.\"");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    //Yes or No question
                                    Console.WriteLine("\n\nDo you wanna travel to 'Wolf Haven' now? (If no, you will lose your free ride)");
                                    Console.WriteLine("\n\n1 = Yes");
                                    Console.WriteLine("2 = No");
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("Choice: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iGoblinKingQ = 100;
                                    string iGoblinKingQs = Console.ReadLine();
                                    if (iGoblinKingQs == "0")
                                    {
                                        iGoblinKingQ = 0;
                                    }
                                    if (iGoblinKingQs == "1")
                                    {
                                        iGoblinKingQ = 1;
                                    }
                                    if (iGoblinKingQs == "2")
                                    {
                                        iGoblinKingQ = 2;
                                    }
                                    if (iGoblinKingQs == "3")
                                    {
                                        iGoblinKingQ = 3;
                                    }
                                    if (iGoblinKingQs == "4")
                                    {
                                        iGoblinKingQ = 4;
                                    }
                                    if (iGoblinKingQs == "5")
                                    {
                                        iGoblinKingQ = 5;
                                    }
                                    if (iGoblinKingQs == "6")
                                    {
                                        iGoblinKingQ = 6;
                                    }
                                    if (iGoblinKingQs == "7")
                                    {
                                        iGoblinKingQ = 7;
                                    }
                                    if (iGoblinKingQs == "8")
                                    {
                                        iGoblinKingQ = 8;
                                    }
                                    if (iGoblinKingQs == "9")
                                    {
                                        iGoblinKingQ = 9;
                                    }
                                    if (iGoblinKingQs == "10")
                                    {
                                        iGoblinKingQ = 10;
                                    }
                                    //iGoblinKingQ = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    if (iGoblinKingQ == 1)//IF YES
                                    {
                                        iGoblinKingQ = 3;
                                        Console.Clear();
                                        Console.WriteLine("\n\nItalian");
                                        Console.WriteLine("Merchant: \"Let's go then. We have a cazzo load of sea to travel across...\"");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("\n\n     You enter the ship after the merchant. The ship is fully loaded with goods.\n\n     After a couple of hour the weather suddenly changes and the ship crashes.\n\n     You wake up hours later and realize your inside a Inn.");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("\n\nInn Keeper: \"Hey! Are you ok? That was a terrible storm! I don't know how you managed to get out alive...\n\n            Anyways, welcome to the town of Wolf Haven.\"");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("\n\n     You leave the Inn.");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        oPlayer.iCurrentArea = 3;

                                    }
                                    else if (iGoblinKingQ == 2)//IF NO
                                    {
                                        iGoblinKingQ = 3;
                                        Console.Clear();
                                        Console.WriteLine("\n\nItalian");
                                        Console.WriteLine("Merchant: \"Ok then. Arrivederci!\"");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        oPlayer.iCurrentArea = 2;
                                    }


                                }

                                if (iGoblinKingQ == 1)//If Goblin King is still alive
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\nOld man: \"Our village is constantly being attacked by globins!\n\n         You look strong and healthy, would you help us?!\n\n         Kill the Goblin King and we will be forever grateful to you!\"\n\n");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                }

                                break;
                            }
                        case 2://CHECK STATUS
                            {
                                oPlayer.CheckStatus();
                                break;
                            }
                        case 3://ENTER INN
                            {
                                oPlayer.iCurrentArea = 21;
                                oPlayer.RestHome();

                                break;

                            }
                        case 4://ENTER ITEMS SHOP
                            {
                                oPlayer.iCurrentArea = 22;
                                oPlayer.Shop();

                                break;
                            }

                        case 5://ENTER ARMORY
                            {
                                oPlayer.iCurrentArea = 23;
                                oPlayer.Shop();

                                break;
                            }
                        case 6://Enter Marshes of Insolence
                            {
                                oPlayer.iCurrentArea = 5;

                                break;
                            }
                        case 7://Sail to Wolf Haven
                            {
                                Console.Clear();
                                Console.Write("\n\nShip Captain: \"I can take you to 'Wolf Haven' in no time! It's gonna cost you ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("300");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write(" gold tough...\"");
                                Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                Console.ReadKey();
                                //Yes or No question
                                Console.WriteLine("\n\nDo you wanna travel to 'Wolf Haven' now?");
                                Console.WriteLine("\n\n1 = Yes");
                                Console.WriteLine("2 = No");
                                //Gets player choice
                                Console.WriteLine();
                                Console.Write("Choice: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                iShipChoice = 100;
                                string iShipChoices = Console.ReadLine();
                                if (iShipChoices == "0")
                                {
                                    iShipChoice = 0;
                                }
                                if (iShipChoices == "1")
                                {
                                    iShipChoice = 1;
                                }
                                if (iShipChoices == "2")
                                {
                                    iShipChoice = 2;
                                }
                                if (iShipChoices == "3")
                                {
                                    iShipChoice = 3;
                                }
                                if (iShipChoices == "4")
                                {
                                    iShipChoice = 4;
                                }
                                if (iShipChoices == "5")
                                {
                                    iShipChoice = 5;
                                }
                                //iShipChoice = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;

                                if (iShipChoice == 1)//IF YES
                                {
                                    //Test if player has money
                                    if (oPlayer.iPlayerGold < 300)
                                    {
                                        //Nice conversation?!
                                        Console.Clear();
                                        Console.WriteLine("\n\nShip Captain: \"Sorry, aparently you don't have enough money...\n\n              Come back another time!\"");
                                        //Sends player back to town
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        oPlayer.iCurrentArea = 2;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.Write("\n\nShip Captain: \"Alright, let's go.\"");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("\n\n     You travel safely and arrive at 'Wolf Haven'.");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        //change player money(decrease it)
                                        oPlayer.iPlayerGold = oPlayer.iPlayerGold - 300;
                                        //send player to wolf haven
                                        oPlayer.iCurrentArea = 3;
                                    }
                                }
                                if (iShipChoice == 2)//IF NO
                                {
                                    Console.Clear();
                                    Console.Write("\n\nShip Captain: \"Ok, see'ya.\"");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    oPlayer.iCurrentArea = 2;
                                }

                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n   Wrong input...");
                                Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                Console.ReadKey();
                                break;
                            }
                    }



                }

                //Enter Second City - "WOLF HAVEN"
                if (oPlayer.iCurrentArea == 3)
                {
                    //player choice in the 2nd city
                    Console.Clear();
                    Console.WriteLine("CURRENT AREA: WOLF HAVEN");
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("1 = Talk to the Locals");
                    Console.WriteLine("2 = Check Status");
                    Console.WriteLine("3 = Enter the 'Inn'");
                    Console.WriteLine("4 = Enter the 'Item Shop'");
                    Console.WriteLine("5 = Enter the 'Armory'");
                    Console.WriteLine("6 = Travel to 'Azazel's Desert'(LVL 21 - 26)");
                    Console.WriteLine("7 = Take ship to 'Valeria Village'");
                    if (iOrcKingQ == 3)
                    {
                        Console.WriteLine("8 = Take zeppelin to 'The Alkemia Fortress'");
                    }
                    Console.WriteLine();
                    Console.Write("Choice: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    iFieldChoice = 100;
                    string iFieldChoices = Console.ReadLine();
                    if (iFieldChoices == "0")
                    {
                        iFieldChoice = 0;
                    }
                    if (iFieldChoices == "1")
                    {
                        iFieldChoice = 1;
                    }
                    if (iFieldChoices == "2")
                    {
                        iFieldChoice = 2;
                    }
                    if (iFieldChoices == "3")
                    {
                        iFieldChoice = 3;
                    }
                    if (iFieldChoices == "4")
                    {
                        iFieldChoice = 4;
                    }
                    if (iFieldChoices == "5")
                    {
                        iFieldChoice = 5;
                    }
                    if (iFieldChoices == "6")
                    {
                        iFieldChoice = 6;
                    }
                    if (iFieldChoices == "7")
                    {
                        iFieldChoice = 7;
                    }
                    if (iFieldChoices == "8")
                    {
                        iFieldChoice = 8;
                    }
                    if (iFieldChoices == "9")
                    {
                        iFieldChoice = 9;
                    }
                    if (iFieldChoices == "10")
                    {
                        iFieldChoice = 10;
                    }
                    //iFieldChoice = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;
                    switch (iFieldChoice)
                    {
                        case 1://TALK TO LOCALS - 'GET QUEST'
                            {

                                if (iOrcKingQ == 0)//If Orc King is killed.
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\nYoung Lady: \"You Killed the Orc King! Our village is finally safe!!\n\n             Thank you so much " + sPName + "!!");
                                    Console.WriteLine("\n             Here's a little display of our gratitude.\"");
                                    Console.Write("\n\n             You won ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("10000");
                                    //Player Gets 10000 Gold
                                    oPlayer.iPlayerGold = oPlayer.iPlayerGold + 10000;
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write(" gold!");
                                    Console.Write("\n             Your current gold is: ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(oPlayer.iPlayerGold);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    //Asks the player to press enter! \o/
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    //Asks the player if he wants to go to the next city
                                    Console.Clear();
                                    Console.WriteLine("\n\n      A person approches you...");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("\n\nRussian");
                                    Console.WriteLine("Scientist: \"Privet! I understand that you are the warrior looking for the Red Dragon.\n\n            Am I correct? Good, because I bring news that might be of your interest...\n\n            I heard rumors that the Red Dragon is somewhere on 'The Alkemia Mountains'.\n\n            Problem is, however, that 'The Alkemia Mountains' are days away from here... if you're going by ground.\n\n            Luckly for you, I invented a object that can fly us there. I'm willing to help you in your cause,\n\n            come with me and you won't have to pay for the ride.\"");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    //Yes or No question
                                    Console.WriteLine("\n\nDo you wanna travel to 'The Alkemia Fortress' now? (If no, you will lose your free ride)");
                                    Console.WriteLine("\n\n1 = Yes");
                                    Console.WriteLine("2 = No");
                                    //Gets player choice
                                    Console.WriteLine();
                                    Console.Write("Choice: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    iOrcKingQ = 100;
                                    string iOrcKingQs = Console.ReadLine();
                                    if (iOrcKingQs == "0")
                                    {
                                        iOrcKingQ = 0;
                                    }
                                    if (iOrcKingQs == "1")
                                    {
                                        iOrcKingQ = 1;
                                    }
                                    if (iOrcKingQs == "2")
                                    {
                                        iOrcKingQ = 2;
                                    }
                                    if (iOrcKingQs == "3")
                                    {
                                        iOrcKingQ = 3;
                                    }
                                    if (iOrcKingQs == "4")
                                    {
                                        iOrcKingQ = 4;
                                    }
                                    if (iOrcKingQs == "5")
                                    {
                                        iOrcKingQ = 5;
                                    }
                                    //iOrcKingQ = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    if (iOrcKingQ == 1)//IF YES
                                    {
                                        iOrcKingQ = 3;
                                        Console.Clear();
                                        Console.WriteLine("\n\nRussian");
                                        Console.WriteLine("Scientist: \"Let's go then. Can't wait to see if this zep... zeppelin! Good name!\n\n            Can't wait to see if this zeppelin is really gonna work!\" >.<");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("\n\n     You enter the flying machine... and realize that it is a bag filled with hot air.\n\n     You're not really sure how that works... The trip is short and doesn't take long until\n\n     you can see the peek of the mountains. You land safely and arrive at 'The Alkemia Fortress'.");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("\n\nRussian");
                                        Console.WriteLine("Scientist: \"It was good flying with you, wish you luck on you journey! Do svidaniya!\"");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();

                                        oPlayer.iCurrentArea = 4;

                                    }
                                    if (iOrcKingQ == 2)//IF NO
                                    {
                                        iOrcKingQ = 3;
                                        Console.Clear();
                                        Console.WriteLine("\n\nRussian");
                                        Console.WriteLine("Scientist: \"Ok then. Do svidaniya!\"");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        oPlayer.iCurrentArea = 3;
                                    }

                                    break;
                                }

                                if (iOrcKingQ == 1)//If Orc King is still alive.
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\nYoung Lady: \"Our village is constantly being attacked by Orcs!\n\n             You look strong and healthy, would you help us?!\n\n             Kill the Orc King and we will be forever grateful to you!\"\n\n");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                }


                                if (iOrcKingQ == 3)//After going to The Alkemia Fortress
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\nYoung Lady: \"Hey! It's you again! Our town's savior! Long live " + sPName + "!!\"");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    oPlayer.iCurrentArea = 3;
                                }

                                break;
                            }
                        case 2://CHECK STATUS
                            {
                                oPlayer.CheckStatus();
                                break;
                            }
                        case 3://ENTER INN
                            {
                                oPlayer.iCurrentArea = 31;
                                oPlayer.RestHome();

                                break;

                            }
                        case 4://ENTER ITEMS SHOP
                            {
                                oPlayer.iCurrentArea = 32;
                                oPlayer.Shop();

                                break;
                            }

                        case 5://ENTER ARMORY
                            {
                                oPlayer.iCurrentArea = 33;
                                oPlayer.Shop();

                                break;
                            }
                        case 6://Enter Azazel's Desert
                            {
                                oPlayer.iCurrentArea = 7;

                                break;
                            }
                        case 7://Sail to Valeria Village
                            {
                                Console.Clear();
                                Console.Write("\n\nShip Captain: \"I can take you to 'Valeria Village' in no time! It's gonna cost you ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("300");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write(" gold tough...\"");
                                Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                Console.ReadKey();
                                //Yes or No question
                                Console.WriteLine("\n\nDo you wanna travel to 'Valeria Village' now?");
                                Console.WriteLine("\n\n1 = Yes");
                                Console.WriteLine("2 = No");
                                //Gets player choice
                                Console.WriteLine();
                                Console.Write("Choice: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                iShipChoice = 100;
                                string iShipChoices = Console.ReadLine();
                                if (iShipChoices == "0")
                                {
                                    iShipChoice = 0;
                                }
                                if (iShipChoices == "1")
                                {
                                    iShipChoice = 1;
                                }
                                if (iShipChoices == "2")
                                {
                                    iShipChoice = 2;
                                }
                                if (iShipChoices == "3")
                                {
                                    iShipChoice = 3;
                                }
                                if (iShipChoices == "4")
                                {
                                    iShipChoice = 4;
                                }
                                if (iShipChoices == "5")
                                {
                                    iShipChoice = 5;
                                }
                                //iShipChoice = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;

                                if (iShipChoice == 1)//IF YES
                                {
                                    //Test if player has money
                                    if (oPlayer.iPlayerGold < 300)
                                    {
                                        //Nice conversation?!
                                        Console.Clear();
                                        Console.WriteLine("\n\nShip Captain: \"Sorry, aparently you don't have enough money...\n\n              Come back another time!\"");
                                        //Sends player back to town
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        oPlayer.iCurrentArea = 3;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.Write("\n\nShip Captain: \"Alright, let's go.\"");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("\n\n     You travel safely and arrive at 'Valeria Village'.");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        //change player money(decrease it)
                                        oPlayer.iPlayerGold = oPlayer.iPlayerGold - 300;
                                        //send player to wolf haven
                                        oPlayer.iCurrentArea = 2;
                                    }
                                }
                                if (iShipChoice == 2)//IF NO
                                {
                                    Console.Clear();
                                    Console.Write("\n\nShip Captain: \"Ok, see'ya.\"");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    oPlayer.iCurrentArea = 3;
                                }

                                break;
                            }
                        case 8://Fly to The Alkemia Fortress
                            {
                                Console.Clear();
                                Console.Write("\n\nPilot: \"I can take you to 'The Alkemia Fortress' in the blink of an eye! It's gonna cost you ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("1000");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write(" gold tough...\"");
                                Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                Console.ReadKey();
                                //Yes or No question
                                Console.WriteLine("\n\nDo you wanna travel to 'The Alkemia Fortress' now?");
                                Console.WriteLine("\n\n1 = Yes");
                                Console.WriteLine("2 = No");
                                //Gets player choice
                                Console.WriteLine();
                                Console.Write("Choice: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                iShipChoice = 100;
                                string iShipChoices = Console.ReadLine();
                                if (iShipChoices == "0")
                                {
                                    iShipChoice = 0;
                                }
                                if (iShipChoices == "1")
                                {
                                    iShipChoice = 1;
                                }
                                if (iShipChoices == "2")
                                {
                                    iShipChoice = 2;
                                }
                                if (iShipChoices == "3")
                                {
                                    iShipChoice = 3;
                                }
                                if (iShipChoices == "4")
                                {
                                    iShipChoice = 4;
                                }
                                if (iShipChoices == "5")
                                {
                                    iShipChoice = 5;
                                }
                                //iShipChoice = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;

                                if (iShipChoice == 1)//IF YES
                                {
                                    //Test if player has money
                                    if (oPlayer.iPlayerGold < 1000)
                                    {
                                        //Nice conversation?!
                                        Console.Clear();
                                        Console.WriteLine("\n\nPilot: \"Sorry, aparently you don't have enough money...\n\n        Come back another time!\"");
                                        //Sends player back to town
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        oPlayer.iCurrentArea = 3;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.Write("\n\nPilot: \"Alright, let's go.\"");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("\n\n     You fly safely and arrive at 'The Alkemia Fortress'.");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        //change player money(decrease it)
                                        oPlayer.iPlayerGold = oPlayer.iPlayerGold - 1000;
                                        //send player to wolf haven
                                        oPlayer.iCurrentArea = 4;
                                    }
                                }
                                if (iShipChoice == 2)//IF NO
                                {
                                    Console.Clear();
                                    Console.Write("\n\nPilot: \"Ok, see you later.\"");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    oPlayer.iCurrentArea = 3;
                                }

                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n   Wrong input...");
                                Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                Console.ReadKey();
                                break;
                            }

                    }



                }

                //Enter Third City - "THE ALKEMIA FORTRESS"
                if (oPlayer.iCurrentArea == 4)
                {
                    //player choice in the 2nd city
                    Console.Clear();
                    Console.WriteLine("CURRENT AREA: THE ALKEMIA FORTRESS");
                    Console.WriteLine("\nWhat would you like to do?");
                    Console.WriteLine("1 = Talk to Soldiers");
                    Console.WriteLine("2 = Check Status");
                    Console.WriteLine("3 = Enter the 'Inn'");
                    Console.WriteLine("4 = Enter the 'Item Shop'");
                    Console.WriteLine("5 = Enter the 'Armory'");
                    Console.WriteLine("6 = Travel to 'Alkemia Mountains' (LVL 33 - 40)");
                    Console.WriteLine("7 = Take zeppelin to 'Wolf Haven'");
                    Console.WriteLine();
                    Console.Write("Choice: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    iFieldChoice = 100;
                    string iFieldChoices = Console.ReadLine();
                    if (iFieldChoices == "0")
                    {
                        iFieldChoice = 0;
                    }
                    if (iFieldChoices == "1")
                    {
                        iFieldChoice = 1;
                    }
                    if (iFieldChoices == "2")
                    {
                        iFieldChoice = 2;
                    }
                    if (iFieldChoices == "3")
                    {
                        iFieldChoice = 3;
                    }
                    if (iFieldChoices == "4")
                    {
                        iFieldChoice = 4;
                    }
                    if (iFieldChoices == "5")
                    {
                        iFieldChoice = 5;
                    }
                    if (iFieldChoices == "6")
                    {
                        iFieldChoice = 6;
                    }
                    if (iFieldChoices == "7")
                    {
                        iFieldChoice = 7;
                    }
                    if (iFieldChoices == "8")
                    {
                        iFieldChoice = 8;
                    }
                    if (iFieldChoices == "9")
                    {
                        iFieldChoice = 9;
                    }
                    if (iFieldChoices == "10")
                    {
                        iFieldChoice = 10;
                    }
                    //iFieldChoice = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;
                    switch (iFieldChoice)
                    {
                        case 1://TALK TO SOLDIERS - 'GET QUEST'
                            {

                                if (iRedDragonQ == 0)//If Red Dragon is killed.
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\nSoldier: \"Yeah! You Killed the Red Dragon! Our world is safe from this terrible threat!!\n\n         Thank you so much " + sPName + "!!");
                                    Console.WriteLine("\n         Here's a little display of our gratitude.\"");
                                    Console.Write("\n\n         You won ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("100000");
                                    //Player Gets 100000 Gold
                                    oPlayer.iPlayerGold = oPlayer.iPlayerGold + 100000;
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write(" gold!");
                                    Console.Write("\n\n         Your current gold is: ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(oPlayer.iPlayerGold);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();

                                    break;
                                }

                                if (iRedDragonQ == 1)//If Red Dragon is still alive.
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\nSoldier: \"Scouts have reported seing the Red Dragon close to a cave on the 'Alkemia Mountains'.\n\n          That might be a good chance for you to attack! But be careful, the general gave us strict orders\n\n          to remain inside the Fortress' walls, so we can't help you...\"");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                }

                                break;
                            }
                        case 2://CHECK STATUS
                            {
                                oPlayer.CheckStatus();
                                break;
                            }
                        case 3://ENTER INN
                            {
                                oPlayer.iCurrentArea = 41;
                                oPlayer.RestHome();

                                break;

                            }
                        case 4://ENTER ITEMS SHOP
                            {
                                oPlayer.iCurrentArea = 42;
                                oPlayer.Shop();

                                break;
                            }

                        case 5://ENTER ARMORY
                            {
                                oPlayer.iCurrentArea = 43;
                                oPlayer.Shop();

                                break;
                            }
                        case 6://Enter Alkemia Mountains
                            {
                                oPlayer.iCurrentArea = 9;

                                break;
                            }
                        case 7://Fly to Wolf Haven
                            {
                                Console.Clear();
                                Console.Write("\n\nPilot: \"I can take you to 'Wolf Haven' in the blink of an eye! It's gonna cost you ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("1000");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write(" gold tough...\"");
                                Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                Console.ReadKey();
                                //Yes or No question
                                Console.WriteLine("\n\nDo you wanna travel to 'Wolf Haven' now?");
                                Console.WriteLine("\n\n1 = Yes");
                                Console.WriteLine("2 = No");
                                //Gets player choice
                                Console.WriteLine();
                                Console.Write("Choice: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                iShipChoice = 100;
                                string iShipChoices = Console.ReadLine();
                                if (iShipChoices == "0")
                                {
                                    iShipChoice = 0;
                                }
                                if (iShipChoices == "1")
                                {
                                    iShipChoice = 1;
                                }
                                if (iShipChoices == "2")
                                {
                                    iShipChoice = 2;
                                }
                                if (iShipChoices == "3")
                                {
                                    iShipChoice = 3;
                                }
                                if (iShipChoices == "4")
                                {
                                    iShipChoice = 4;
                                }
                                if (iShipChoices == "5")
                                {
                                    iShipChoice = 5;
                                }
                                //iShipChoice = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;

                                if (iShipChoice == 1)//IF YES
                                {
                                    //Test if player has money
                                    if (oPlayer.iPlayerGold < 1000)
                                    {
                                        //Nice conversation?!
                                        Console.Clear();
                                        Console.WriteLine("\n\nPilot: \"Sorry, aparently you don't have enough money...\n\n        Come back another time!\"");
                                        //Sends player back to town
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        oPlayer.iCurrentArea = 4;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.Write("\n\nPilot: \"Alright, let's go.\"");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        Console.WriteLine("\n\n     You fly safely and arrive at 'Wolf Haven'.");
                                        Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                        Console.ReadKey();
                                        Console.Clear();
                                        //change player money(decrease it)
                                        oPlayer.iPlayerGold = oPlayer.iPlayerGold - 1000;
                                        //send player to wolf haven
                                        oPlayer.iCurrentArea = 3;
                                    }
                                }
                                if (iShipChoice == 2)//IF NO
                                {
                                    Console.Clear();
                                    Console.Write("\n\nPilot: \"Ok, see you later.\"");
                                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                    Console.ReadKey();
                                    oPlayer.iCurrentArea = 4;
                                }

                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("\n\n   Wrong input...");
                                Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                                Console.ReadKey();
                                break;
                            }

                    }



                }




                //ENDS THE GAME
                if (iRedDragonQ == 0)//If Red Dragon is killed.
                {
                    Console.Clear();
                    Console.WriteLine("\n\n     \"" + sPName + "'s revenge was then finally completed... the Dragon was dead,\n\n     his blade covered in blood... But his family was forever gone and our hero\n\n     found himself with nothing more than bad memories... The Red Dragon was just the\n\n     first of many, many others...\"");
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\n\n-------------------THE END-------------------");
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    Console.WriteLine("\n\n      CONGRATULATIONS, YOU FINISHED THE GAME!");
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\n\n-------------------GAME CREATED BY-------------------");
                    Console.WriteLine("\n\n\n                    GAURAV SHARMA");
                    Console.WriteLine("\n                      JEFF SHAW");
                    Console.WriteLine("\n                KAUAM TRIPOLONE SILVA");
                    Console.WriteLine("\n                      TIM WIRCH");
                    Console.WriteLine("\n\n\n      >>PRESS ANY KEY TO CONTINUE<<");
                    Console.ReadKey();
                    int exitCode = 0;
                    Environment.Exit(exitCode);
                }




            }
            while (iGameOver == 0);
        }
    }
}
