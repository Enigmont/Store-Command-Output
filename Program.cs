// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Numerics;
using System.Xml.Linq;

public class StoreCommandOutput
{
    //Variable List
    static string shopType = "";
    static string shopChest = "";
    static string redstoneBarrier = "";
    static string redstoneBarrierReset = "";
    static string hopperBarrierReset = "";
    static string hopperBarrier = "";
    static string hopperClear = "";
    static string hopperClear2 = "";
    static string shopSell = "";
    static string shopSellPlayer = "";
    static string clearChest = "";
    static string signdirection = "";
    static string shopDirection = "";
    static string signRow = "";
    static string shopToken = "";
    static string tokenType = "";
    static string ubuySignCommand1 = "";
    static string ubuySignCommand2 = "";
    static string ubuySignCommand = "";
    static string chestdirection = "";
    static string chestRow = "";
    static string worldguardWorld = "";
    static string worldRaw = "";
    static string worldeditpos1 = "";
    static string worldeditpos2 = "";
    static string worldedit2pos1 = "";
    static string worldedit2pos2 = "";
    static string worldguardCommand1 = "";
    static string worldguardSub1Command1 = "";
    static string worldguardSub1Command2 = "";
    static string worldguardSub1Command3 = "";
    static string worldguardCommand2 = "";
    static string worldguardSub2Command1 = "";
    static string worldguardSub2Command2 = "";
    static string worldguardSub2Command3 = "";
    static string worldguardSub2Command4 = "";
    static string worldguardCommand3 = "";
    static string worldguardSub3Command1 = "";
    static string worldguardSub3Command2 = "";
    static string worldguardCommand4 = "";
    static string worldguardSub4Command1 = "";
    static string worldguardSub4Command2 = "";
    static string worldguardCommand5 = "";
    static string worldguardSub5Command1 = "";
    static string worldguardCommand6 = "";
    static string shopmain = "";
    static string shopstorage = "";
    static string shopblock = "";
    static string shopreset = "";
    static string serverOutput1 = "";
    static string serverOutput2 = "";
    static string signReset1 = "";
    static string signReset1a = "";
    static string signReset2 = "";
    static string signReset2a = "";
    static int shopNum;
    static int a;
    static int b;
    static int c;
    static int r = 0;
    static int standard = 0;
    static int player = 0;
    static int reset = 0;
    static int lastcommands = 0;
    static int x;
    static int y;
    static int z;
    static int ax;
    static int ay;
    static int az;
    static double shopPrice = 0;
    static double shopPriceNew;
    static string coordinates1 = "";
    static string coordinates2 = "";
    static string coordinates3 = "";

    //Add variables for store relative directions
    //Stall Variables
    //Test Variables
    static int StallX1 = -2;

    static int StallY1 = 1;
    static int StallY2 = 0;
    static int StallY3 = 3;

    static int StallZ1 = 6;
    static int StallZ2 = 1;
    static int StallZ3 = 5;
    static int StallZ4 = 2;

    //Store Variables

    //Market Variables

    static void CommandOutput()
    {
        ubuySignCommand1 = "/execute if block " + shopChest + " minecraft:chest{Items:[{id:" + "\"minecraft:" + tokenType + "\"" + ",tag:{display:{Name:\"" + "{" + @"\" + "\"" + "text" + @"\" + "\"" + ":" + @"\" + "\"" + shopToken + @"\" + "\"" + "}" + "\"" + "}}}]} ";
        ubuySignCommand2 = "run fill " + signRow + " minecraft:oak_wall_sign[facing=" + signdirection + "]{Text1:" + "'{\"text\":\"[ubuy]\"}',Text2:'{\"text\":\"1\"}',Text3:'{\"text\":\"Item\"}',Text4:'{\"text\":\"$0\"}'}";
        ubuySignCommand = ubuySignCommand1 + ubuySignCommand2;
        Console.WriteLine(ubuySignCommand);
        Console.WriteLine();
        r++;
        standard++;
    }
    static void ChestOutput()
    {
        ubuySignCommand1 = "/execute if block " + shopChest + " minecraft:chest{Items:[{id:" + "\"minecraft:" + tokenType + "\"" + ",tag:{display:{Name:\"" + "{" + @"\" + "\"" + "text" + @"\" + "\"" + ":" + @"\" + "\"" + shopToken + @"\" + "\"" + "}" + "\"" + "}}}]} ";
        ubuySignCommand2 = "run fill " + chestRow + " minecraft:chest[facing=" + chestdirection + "]";
        ubuySignCommand = ubuySignCommand1 + ubuySignCommand2;
        Console.WriteLine(ubuySignCommand);
        Console.WriteLine();
        r++;
        standard++;
    }
    static void OwnerSign()
    {
        ubuySignCommand1 = "/execute if block " + shopChest + " minecraft:chest{Items:[{id:" + "\"minecraft:" + tokenType + "\"" + ",tag:{display:{Name:\"" + "{" + @"\" + "\"" + "text" + @"\" + "\"" + ":" + @"\" + "\"" + shopToken + @"\" + "\"" + "}" + "\"" + "}}}]} ";
        ubuySignCommand2 = "run fill " + signRow + " minecraft:oak_wall_sign[facing=" + signdirection + "]{Color:\"cyan\",GlowingText:1b,Text1:" + "'{\"text\":\"" + shopType + " " + shopNum + "\"}',Text2:'{\"text\":\"Owner:\"}',Text3:'{\"selector\": \"@p\"}',Text4:'{\"text\":\"Status: In Use\"}'} replace";
        ubuySignCommand = ubuySignCommand1 + ubuySignCommand2;
        Console.WriteLine(ubuySignCommand);
        Console.WriteLine();
        r++;
        player++;
    }
    static void OwnerSignReset()
    {
        ubuySignCommand1 = "/fill " + signRow + " minecraft:air";
        ubuySignCommand2 = "/fill " + signRow + " minecraft:oak_wall_sign[facing=" + signdirection + "]{Color:\"green\",GlowingText:1b,Text1:" + "'{\"text\":\"" + shopType + " " + shopNum + "\"}',Text2:'{\"text\":\"Owner:\"}',Text3:'{\"text\":\" \"}',Text4:'{\"text\":\"Status: Available\"}'} replace";
        signReset1 = ubuySignCommand2;
        signReset1a = ubuySignCommand1;
        r = r + 2;
        reset = reset + 2;
    }
    static void OwnerSignReset2()
    {
        ubuySignCommand1 = "/fill " + signRow + " minecraft:air";
        ubuySignCommand2 = "/fill " + signRow + " minecraft:oak_wall_sign[facing=" + signdirection + "]{Color:\"green\",GlowingText:1b,Text1:" + "'{\"text\":\"" + shopType + " " + shopNum + "\"}',Text2:'{\"text\":\"Owner:\"}',Text3:'{\"text\":\" \"}',Text4:'{\"text\":\"Status: Available\"}'} replace";
        signReset2 = ubuySignCommand2;
        signReset2a = ubuySignCommand1;
        r = r + 2;
        reset = reset + 2;
    }
    static void SignVoid()
    {
        ubuySignCommand1 = "/execute if block " + shopChest + " minecraft:chest{Items:[{id:" + "\"minecraft:" + tokenType + "\"" + ",tag:{display:{Name:\"" + "{" + @"\" + "\"" + "text" + @"\" + "\"" + ":" + @"\" + "\"" + shopToken + @"\" + "\"" + "}" + "\"" + "}}}]} ";
        ubuySignCommand2 = "run fill " + signRow + " minecraft:air";
        ubuySignCommand = ubuySignCommand1 + ubuySignCommand2;
        Console.WriteLine(ubuySignCommand);
        Console.WriteLine();
        r++;
        standard++;
    }
    static void WorldguardOutput()
    {
        Console.WriteLine();
        Console.WriteLine("Worldguard Commands: ");
        Console.WriteLine(worldguardCommand1 = "1. /worldedit:/world " + worldguardWorld);
        Console.WriteLine(worldguardSub1Command1 = "2. /worldedit:/pos1 " + worldeditpos1);
        Console.WriteLine(worldguardSub1Command2 = "3. /worldedit:/pos2 " + worldeditpos2);
        Console.WriteLine(worldguardSub1Command3 = "4. /worldguard:rg define " + shopmain);
        Console.WriteLine(worldguardCommand2 = "5. /worldedit:/world " + worldguardWorld);
        Console.WriteLine(worldguardSub2Command1 = "6. /worldedit:/pos1 " + worldedit2pos1);
        Console.WriteLine(worldguardSub2Command2 = "7. /worldedit:/pos2 " + worldedit2pos2);
        Console.WriteLine(worldguardSub2Command3 = "8. /worldguard:rg define " + shopstorage);
        Console.WriteLine(worldguardSub2Command4 = "9. /rg flag " + shopstorage + " entry deny");
        Console.WriteLine(worldguardCommand3 = "10. /rg flag " + shopmain + " interact allow");
        Console.WriteLine(worldguardSub3Command1 = "11. /rg addowner -w " + "\"" + worldRaw + "\" " + shopmain + " @p");
        Console.WriteLine(worldguardSub3Command2 = "12. /rg setpriority -w " + "\"" + worldRaw + "\" " + shopmain + " 3");
        Console.WriteLine(worldguardCommand4 = "13. /rg flag " + shopstorage + " interact allow");
        Console.WriteLine(worldguardSub4Command1 = "14. /rg addowner -w " + "\"" + worldRaw + "\" " + shopstorage + " @p");
        Console.WriteLine(worldguardSub4Command2 = "15. /rg setpriority -w " + "\"" + worldRaw + "\" " + shopstorage + " 3");
        Console.WriteLine(worldguardCommand5 = "16. /rg flag " + shopreset + " entry deny");
        //Console.WriteLine(worldguardSub5Command1 = "/rg setpriority -w " + "\"" + worldRaw + "\" " + shopblock + " 2");
        Console.WriteLine(worldguardCommand6 = "17. /rg addowner -w " + "\"" + worldRaw + "\" " + shopreset + " @p");
        r = r + 18;
        player = player + 18;

    }
    static void ServerOutput()
    {
        Console.WriteLine();
        Console.WriteLine("Server Announcements: ");
        serverOutput1 = "/execute if block " + shopChest + " minecraft:chest{Items:[{id:" + "\"minecraft:" + tokenType + "\"" + ",tag:{display:{Name:\"" + "{" + @"\" + "\"" + "text" + @"\" + "\"" + ":" + @"\" + "\"" + shopToken + @"\" + "\"" + "}" + "\"" + "}}}]}";
        serverOutput2 = "run tellraw @a [{" + "\"selector\": \"@p\"},{\"text\":\" has opened Player Market " + shopType + " " + shopNum + "!\", \"color\": \"aqua\"}]";  // run tellraw @a [{"selector":"@p"},{"text":" has opened Player Market Store 2!", "color": "aqua"}]
        Console.WriteLine(serverOutput1 + " " + serverOutput2);
        serverOutput2 = "run tellraw @a {\"text\": \"Player Market " + shopType + " " + shopNum + " is now open!\", \"color\": \"green\"}"; //run tellraw @a {"text": "Player Market Store 2 is now open!", "color": "green"}
        Console.WriteLine(serverOutput1 + " " + serverOutput2);
        r = r + 2;
        player = player + 2;
    }
    static void RedstoneBarrierOutput()
    {
        ubuySignCommand1 = "/execute if block " + shopChest + " minecraft:chest{Items:[{id:" + "\"minecraft:" + tokenType + "\"" + ",tag:{display:{Name:\"" + "{" + @"\" + "\"" + "text" + @"\" + "\"" + ":" + @"\" + "\"" + shopToken + @"\" + "\"" + "}" + "\"" + "}}}]} ";
        ubuySignCommand2 = "run fill " + redstoneBarrier + " minecraft:redstone_block";
        ubuySignCommand = ubuySignCommand1 + ubuySignCommand2;
        Console.WriteLine(ubuySignCommand);
        Console.WriteLine();
        r++;
        lastcommands++;
    }
    static void HopperBarrierOutput()
    {
        ubuySignCommand1 = "/execute if block " + shopChest + " minecraft:chest{Items:[{id:" + "\"minecraft:" + tokenType + "\"" + ",tag:{display:{Name:\"" + "{" + @"\" + "\"" + "text" + @"\" + "\"" + ":" + @"\" + "\"" + shopToken + @"\" + "\"" + "}" + "\"" + "}}}]} ";
        ubuySignCommand2 = "run fill " + hopperBarrier + " minecraft:oak_planks";
        ubuySignCommand = ubuySignCommand1 + ubuySignCommand2;
        Console.WriteLine(ubuySignCommand);
        Console.WriteLine();
        r++;
        lastcommands++;
    }
    static void BarrierReset()
    {
        Console.WriteLine();
        Console.WriteLine("Chest Clear Reset Commands:");
        ubuySignCommand2 = "/fill " + redstoneBarrier + " minecraft:air";
        ubuySignCommand = ubuySignCommand2;
        Console.WriteLine(ubuySignCommand);
        Console.WriteLine();
        ubuySignCommand2 = "/fill " + hopperBarrier + " minecraft:hopper[facing=down]";
        ubuySignCommand = ubuySignCommand2;
        Console.WriteLine(ubuySignCommand);
        Console.WriteLine();
        Console.WriteLine("/fill " + hopperClear + " minecraft:air");
        Console.WriteLine();
        r = r + 3;
        reset = reset + 3;
    }
    static void ChestClear()
    {
        Console.WriteLine();
        Console.WriteLine("Chest Clear Commands:");
        Console.WriteLine();
        if (shopType == "Stall" || shopType == "Store")
        {
            a = ax + 0; b = ay + 7; c = az + -1;
            coordinates1 = a + " " + b + " " + c;
            a = ax + 0; b = ay + 7; c = az + -1;
            coordinates2 = a + " " + b + " " + c;
            redstoneBarrier = coordinates1 + " " + coordinates2;

            RedstoneBarrierOutput();

            a = ax + 0; b = ay + 8; c = az + 0;
            coordinates1 = a + " " + b + " " + c;
            a = ax + 0; b = ay + 8; c = az + 0;
            coordinates2 = a + " " + b + " " + c;
            hopperBarrier = coordinates1 + " " + coordinates2;

            HopperBarrierOutput();
        }
        else if (shopType == "Market")
        {
            a = ax + 0; b = ay + 7; c = az + 1;
            coordinates1 = a + " " + b + " " + c;
            a = ax + 0; b = ay + 7; c = az + 1;
            coordinates2 = a + " " + b + " " + c;
            redstoneBarrier = coordinates1 + " " + coordinates2;

            RedstoneBarrierOutput();

            a = ax + 0; b = ay + 8; c = az + 0;
            coordinates1 = a + " " + b + " " + c;
            a = ax + 0; b = ay + 8; c = az + 0;
            coordinates2 = a + " " + b + " " + c;
            hopperBarrier = coordinates1 + " " + coordinates2;

            HopperBarrierOutput();
        }
        else
        {
            return;
        }
        clearChest = "/loot replace block " + shopChest + " container.0 27 loot minecraft:empty";
        Console.WriteLine(clearChest);
        r++;
        lastcommands++;
    }
    static void HopperClear()
    {
        Console.WriteLine();
        Console.WriteLine("Hopper Clear Commands: ");
        Console.WriteLine();
        a = ax + 0; b = ay + 2; c = az + 0;
        coordinates1 = a + " " + b + " " + c;
        a = ax + 0; b = ay + 2; c = az + 0;
        coordinates2 = a + " " + b + " " + c;
        hopperClear = coordinates1 + " " + coordinates2;

        a = ax + 0; b = ay + 3; c = az + 0;
        coordinates3 = a + " " + b + " " + c;
        a = ax + 0; b = ay + 3; c = az + 0;
        coordinates2 = a + " " + b + " " + c;
        hopperClear2 = coordinates3 + " " + coordinates2;

        HopperCheck();
        HopperReset();
    }
    static void HopperCheck()
    {
        ubuySignCommand1 = "/execute if block " + coordinates3 + " minecraft:hopper{Items:[{id:" + "\"minecraft:" + tokenType + "\"" + ",tag:{display:{Name:\"" + "{" + @"\" + "\"" + "text" + @"\" + "\"" + ":" + @"\" + "\"" + shopToken + @"\" + "\"" + "}" + "\"" + "}}}]} ";
        ubuySignCommand2 = "run fill " + hopperClear + " minecraft:hopper[facing=down]";
        ubuySignCommand = ubuySignCommand1 + ubuySignCommand2;
        Console.WriteLine(ubuySignCommand);
        Console.WriteLine();
    }
    static void HopperReset()
    {
        Console.WriteLine("/loot replace block " + coordinates3 + " container.0 27 loot minecraft:empty");
        Console.WriteLine("/fill " + hopperClear2 + " minecraft:air");
        Console.WriteLine("/fill " + hopperClear2 + " minecraft:hopper[facing=down]");
    }
    static void SellShop()
    {
        shopPriceNew = shopPrice * 0.8;
        shopSell = "/eco give @p $" + shopPriceNew;
        shopSellPlayer = "/say @p You have been refunded 80%";
        Console.WriteLine(shopSell);
        Console.WriteLine(shopSellPlayer);
        r = r + 2;
        reset = reset + 2;
    }
    static void EastStallCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Sign Commands:");
        //Directional script
        signdirection = "west";
        //---------------------

        a = x + StallX1; b = y + StallY1; c = z + -StallZ1;
        coordinates1 = a + " " + b + " " + c;
        a = x + StallX1; b = y + StallY2; c = z + -StallZ2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        CommandOutput();

        a = x + StallX1; b = y + StallY3; c = z + -StallZ3;
        coordinates1 = a + " " + b + " " + c;
        a = x + StallX1; b = y + StallY3; c = z + -StallZ4;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        CommandOutput();

        //Owner Signs
        Console.WriteLine();
        Console.WriteLine("Owner Sign Commands:");
        a = x + -2; b = y + 1; c = z + 0;
        coordinates1 = a + " " + b + " " + c;
        a = x + -2; b = y + 1; c = z + 0;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        SignVoid();
        Console.Write("2. ");
        OwnerSign();
        OwnerSignReset();

        a = x + -2; b = y + 1; c = z + -7;
        coordinates1 = a + " " + b + " " + c;
        a = x + -2; b = y + 1; c = z + -7;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        SignVoid();
        Console.Write("2. ");
        OwnerSign();
        OwnerSignReset2();

        //For worldguard
        a = x + -2; b = y + 3; c = z + -6;
        worldeditpos1 = a + "," + b + "," + c;
        a = x + -2; b = y + 0; c = z + -1;
        worldeditpos2 = a + "," + b + "," + c;
    }//complete
    static void EastStallChestRoomCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Chest Room Coordinates: ");
        //Directional Script
        chestdirection = "east";
        //---------------------

        a = x + 0; b = y + -4; c = z + -1;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + -3; c = z + -6;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        ChestOutput();

        //Directional Script
        chestdirection = "west";
        //---------------------
        a = x + 5; b = y + -4; c = z + -1;
        coordinates1 = a + " " + b + " " + c;
        a = x + 5; b = y + -3; c = z + -1;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        ChestOutput();

        a = x + 5; b = y + -4; c = z + -6;
        coordinates1 = a + " " + b + " " + c;
        a = x + 5; b = y + -3; c = z + -6;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        ChestOutput();

        //For worldguard
        a = x + 5; b = y + -2; c = z + -6;
        worldedit2pos1 = a + "," + b + "," + c;
        a = x + 0; b = y + -4; c = z + -1;
        worldedit2pos2 = a + "," + b + "," + c;
    }//complete
    static void WestStallCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Sign Commands:");
        //Directional script
        signdirection = "east";
        //---------------------

        //   1  West Stall ----- East
        a = x + 2; b = y + 1; c = z + 6;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 0; c = z + 1;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        CommandOutput();

        //   2  West Stall ----- East
        a = x + 2; b = y + 3; c = z + 5;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 3; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        CommandOutput();

        //Owner Signs
        Console.WriteLine();
        Console.WriteLine("Owner Sign Commands:");
        a = x + 2; b = y + 1; c = z + 7;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 1; c = z + 7;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        SignVoid();
        Console.Write("2. ");
        OwnerSign();
        OwnerSignReset();

        a = x + 2; b = y + 1; c = z + 0;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 1; c = z + 0;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        SignVoid();
        Console.Write("2. ");
        OwnerSign();
        OwnerSignReset2();

        //For worldguard
        a = x + 2; b = y + 0; c = z + 1;
        worldeditpos1 = a + "," + b + "," + c;
        a = x + 2; b = y + 3; c = z + 6;
        worldeditpos2 = a + "," + b + "," + c;
    }//complete
    static void WestStallChestRoomCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Chest Room Coordinates: ");
        //Directional Script
        chestdirection = "west";
        //---------------------
        a = x + 0; b = y + -4; c = z + 1;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + -3; c = z + 6;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        ChestOutput();

        //Directional Script
        chestdirection = "east";
        //---------------------

        a = x + -5; b = y + -4; c = z + 6;
        coordinates1 = a + " " + b + " " + c;
        a = x + -5; b = y + -3; c = z + 6;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        ChestOutput();

        a = x + -5; b = y + -4; c = z + 1;
        coordinates1 = a + " " + b + " " + c;
        a = x + -5; b = y + -3; c = z + 1;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        ChestOutput();

        //For worldguard
        a = x + 0; b = y + -4; c = z + 1;
        worldedit2pos1 = a + "," + b + "," + c;
        a = x + -5; b = y + -2; c = z + 6;
        worldedit2pos2 = a + "," + b + "," + c;
    }//complete
    //1
    static void NorthStoreCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Sign Commands:");
        //Directional script
        signdirection = "north";
        //---------------------

        //   1  North Store
        a = x + 2; b = y + 2; c = z - 2;
        coordinates1 = a + " " + b + " " + c;
        a = x - 2; b = y + 2; c = z - 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        CommandOutput();

        //   2  North Store
        a = x + 2; b = y + 0; c = z - 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 1; b = y + 0; c = z - 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        CommandOutput();

        //   3  North Store
        a = x - 1; b = y + 0; c = z - 2;
        coordinates1 = a + " " + b + " " + c;
        a = x - 2; b = y + 0; c = z - 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        CommandOutput();

        //Directional script
        signdirection = "east";
        //---------------------

        //   1  North Store
        a = x - 2; b = y + 2; c = z - 3;
        coordinates1 = a + " " + b + " " + c;
        a = x - 2; b = y + 2; c = z - 13;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("4. ");
        CommandOutput();

        //   2  North Store
        a = x - 2; b = y + 0; c = z - 3;
        coordinates1 = a + " " + b + " " + c;
        a = x - 2; b = y + 0; c = z - 13;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("5. ");
        CommandOutput();

        //Directional script
        signdirection = "south";
        //---------------------

        //   1  North Store
        a = x - 2; b = y + 2; c = z - 14;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 2; c = z - 14;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("6. ");
        CommandOutput();

        //   2  North Store ----- South
        a = x - 2; b = y + 0; c = z - 14;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 0; c = z - 14;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("7. ");
        CommandOutput();

        //Directional script
        signdirection = "west";
        //---------------------

        //   1  North Store ----- West
        a = x + 2; b = y + 2; c = z - 13;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 2; c = z - 3;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("8. ");
        CommandOutput();

        //   2  North Store ----- West
        a = x + 2; b = y + 0; c = z - 13;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 0; c = z - 3;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("9. ");
        CommandOutput();

        //Owner Signs
        //Directional script
        signdirection = "south";
        //---------------------

        Console.WriteLine();
        Console.WriteLine("Owner Sign Commands:");
        a = x + 0; b = y + 2; c = z + 1;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + 2; c = z + 1;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        SignVoid();
        Console.Write("2. ");
        OwnerSign();
        OwnerSignReset();

        //For worldguard
        a = x + -2; b = y + 2; c = z + -14;
        worldeditpos1 = a + "," + b + "," + c;
        a = x + 2; b = y + 0; c = z + -2;
        worldeditpos2 = a + "," + b + "," + c;
    }//complete
    static void NorthStoreChestRoomCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Chest Room Coordinates: ");
        //Storage Chest Direction
        chestdirection = "south";
        //---------------------
        a = x + -3; b = y + -4; c = z + -16;
        coordinates1 = a + " " + b + " " + c;
        a = x + -2; b = y + -3; c = z + -16;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        ChestOutput();

        a = x + 2; b = y + -4; c = z + -16;
        coordinates1 = a + " " + b + " " + c;
        a = x + 3; b = y + -3; c = z + -16;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        ChestOutput();

        a = x + 4; b = y + -4; c = z + -16;
        coordinates1 = a + " " + b + " " + c;
        a = x + 4; b = y + -4; c = z + -16;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        ChestOutput();

        //Storage Chest Direction
        chestdirection = "west";
        //---------------------
        a = x + 4; b = y + -4; c = z + -14;
        coordinates1 = a + " " + b + " " + c;
        a = x + 4; b = y + -3; c = z + -2;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("4. ");
        ChestOutput();

        //Storage Chest Direction
        chestdirection = "north";
        //---------------------
        a = x + 2; b = y + -4; c = z + 0;
        coordinates1 = a + " " + b + " " + c;
        a = x + -2; b = y + -3; c = z + 0;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("5. ");
        ChestOutput();

        //Storage Chest Direction
        chestdirection = "east";
        //---------------------
        a = x + -4; b = y + -4; c = z + -2;
        coordinates1 = a + " " + b + " " + c;
        a = x + -4; b = y + -3; c = z + -14;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("6. ");
        ChestOutput();

        //For worldguard
        a = x + -4; b = y + -4; c = z + -16;
        worldedit2pos1 = a + "," + b + "," + c;
        a = x + 4; b = y + -2; c = z + 0;
        worldedit2pos2 = a + "," + b + "," + c;
    }//complete
    //2
    static void EastStoreCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Sign Commands:");
        //Directional script
        signdirection = "east";
        //---------------------

        //   1  East Store ----- East
        a = x + 2; b = y + 2; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 2; c = z - 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        CommandOutput();

        //   2  East Store ----- East
        a = x + 2; b = y + 0; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 0; c = z + 1;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        CommandOutput();

        //   3  East Store ----- East
        a = x + 2; b = y + 0; c = z - 1;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 0; c = z - 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        CommandOutput();

        //Directional script
        signdirection = "south";
        //---------------------

        //   1  East Store ----- South
        a = x + 3; b = y + 2; c = z - 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 13; b = y + 2; c = z - 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("4. ");
        CommandOutput();

        //   2  East Store ----- South
        a = x + 3; b = y + 0; c = z - 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 13; b = y + 0; c = z - 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("5. ");
        CommandOutput();

        //Directional script
        signdirection = "west";
        //---------------------

        //   1  East Store ----- West
        a = x + 14; b = y + 2; c = z - 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 14; b = y + 2; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("6. ");
        CommandOutput();

        //   2  East Store ----- West
        a = x + 14; b = y + 0; c = z - 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 14; b = y + 0; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("7. ");
        CommandOutput();

        //Directional script
        signdirection = "north";
        //---------------------

        //   1  East Store ----- North
        a = x + 13; b = y + 2; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 3; b = y + 2; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("8. ");
        CommandOutput();

        //   2  East Store ----- North
        a = x + 13; b = y + 0; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 3; b = y + 0; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("9. ");
        CommandOutput();

        //Owner Signs
        //Directional script
        signdirection = "west";
        //---------------------

        Console.WriteLine();
        Console.WriteLine("Owner Sign Commands:");
        a = x + -1; b = y + 2; c = z + 0;
        coordinates1 = a + " " + b + " " + c;
        a = x + -1; b = y + 2; c = z + 0;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        SignVoid();
        Console.Write("2. ");
        OwnerSign();
        OwnerSignReset();

        //For worldguard
        a = x + 14; b = y + 0; c = z + -2;
        worldeditpos1 = a + "," + b + "," + c;
        a = x + 2; b = y + 2; c = z + 2;
        worldeditpos2 = a + "," + b + "," + c;
    }//complete
    static void EastStoreChestRoomCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Chest Room Coordinates: ");
        //Directional Script
        chestdirection = "west";
        //---------------------
        a = x + 16; b = y + -4; c = z + -3;
        coordinates1 = a + " " + b + " " + c;
        a = x + 16; b = y + -3; c = z + -2;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        ChestOutput();

        a = x + 16; b = y + -4; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 16; b = y + -3; c = z + 3;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        ChestOutput();

        a = x + 16; b = y + -4; c = z + 4;
        coordinates1 = a + " " + b + " " + c;
        a = x + 16; b = y + -4; c = z + 4;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        ChestOutput();

        //Directional Script
        chestdirection = "north";
        //---------------------
        a = x + 14; b = y + -4; c = z + 4;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + -3; c = z + 4;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("4. ");
        ChestOutput();

        //Directional Script
        chestdirection = "east";
        //---------------------
        a = x + 0; b = y + -4; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + -3; c = z + -2;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("5. ");
        ChestOutput();

        //Directional Script
        chestdirection = "south";
        //---------------------
        a = x + 2; b = y + -4; c = z + -4;
        coordinates1 = a + " " + b + " " + c;
        a = x + 14; b = y + -3; c = z + -4;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("6. ");
        ChestOutput();

        //For worldguard
        a = x + 0; b = y + -4; c = z + 4;
        worldedit2pos1 = a + "," + b + "," + c;
        a = x + 16; b = y + -2; c = z + -4;
        worldedit2pos2 = a + "," + b + "," + c;
    }//complete
    //1
    static void SouthStoreCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Sign Commands:");
        //Directional script
        signdirection = "south";
        //---------------------

        //   1  South Store ----- South
        a = x - 2; b = y + 2; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 2; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        CommandOutput();

        //   2  South Store ----- South
        a = x - 2; b = y + 0; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x - 1; b = y + 0; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        CommandOutput();

        //   3  South Store ----- South
        a = x + 1; b = y + 0; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 0; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        CommandOutput();

        //Directional script
        signdirection = "west";
        //---------------------

        //   1  South Store ----- West
        a = x + 2; b = y + 2; c = z + 3;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 2; c = z + 13;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("4. ");
        CommandOutput();

        //   2  South Store ----- West
        a = x + 2; b = y + 0; c = z + 3;
        coordinates1 = a + " " + b + " " + c;
        a = x + 2; b = y + 0; c = z + 13;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("5. ");
        CommandOutput();

        //Directional script
        signdirection = "north";
        //---------------------

        //   1  South Store ----- North
        a = x + 2; b = y + 2; c = z + 14;
        coordinates1 = a + " " + b + " " + c;
        a = x - 2; b = y + 2; c = z + 14;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("6. ");
        CommandOutput();

        //   2  South Store ----- North
        a = x + 2; b = y + 0; c = z + 14;
        coordinates1 = a + " " + b + " " + c;
        a = x - 2; b = y + 0; c = z + 14;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("7. ");
        CommandOutput();

        //Directional script
        signdirection = "east";
        //---------------------

        //   1  South Store ----- East
        a = x - 2; b = y + 2; c = z + 13;
        coordinates1 = a + " " + b + " " + c;
        a = x - 2; b = y + 2; c = z + 3;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("8. ");
        CommandOutput();

        //   2  South Store ----- East
        a = x - 2; b = y + 0; c = z + 13;
        coordinates1 = a + " " + b + " " + c;
        a = x - 2; b = y + 0; c = z + 3;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("9. ");
        CommandOutput();

        //Owner Signs
        //Directional script
        signdirection = "north";
        //---------------------

        Console.WriteLine();
        Console.WriteLine("Owner Sign Commands:");
        a = x + 0; b = y + 2; c = z + -1;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + 2; c = z + -1;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        SignVoid();
        Console.Write("2. ");
        OwnerSign();
        OwnerSignReset();

        //For worldguard
        a = x + 2; b = y + 0; c = z + 14;
        worldeditpos1 = a + "," + b + "," + c;
        a = x + -2; b = y + 2; c = z + 2;
        worldeditpos2 = a + "," + b + "," + c;
    }//complete
    static void SouthStoreChestRoomCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Chest Room Coordinates: ");
        //Directional Script
        chestdirection = "north";
        //---------------------
        a = x + 16; b = y + -3; c = z + 30;
        coordinates1 = a + " " + b + " " + c;
        a = x + 15; b = y + -2; c = z + 30;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        ChestOutput();

        a = x + 11; b = y + -3; c = z + 30;
        coordinates1 = a + " " + b + " " + c;
        a = x + 10; b = y + -2; c = z + 30;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        ChestOutput();

        a = x + 9; b = y + -3; c = z + 30;
        coordinates1 = a + " " + b + " " + c;
        a = x + 9; b = y + -3; c = z + 30;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        ChestOutput();

        //Directional Script
        chestdirection = "east";
        //---------------------
        a = x + 9; b = y + -3; c = z + 28;
        coordinates1 = a + " " + b + " " + c;
        a = x + 9; b = y + -2; c = z + 16;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("4. ");
        ChestOutput();

        //Directional Script
        chestdirection = "south";
        //---------------------
        a = x + 11; b = y + -3; c = z + 14;
        coordinates1 = a + " " + b + " " + c;
        a = x + 15; b = y + -2; c = z + 14;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("5. ");
        ChestOutput();

        //Directional Script
        chestdirection = "west";
        //---------------------
        a = x + 17; b = y + -3; c = z + 16;
        coordinates1 = a + " " + b + " " + c;
        a = x + 17; b = y + -2; c = z + 28;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("6. ");
        ChestOutput();

        //For worldguard
        a = x + 17; b = y + -3; c = z + 30;
        worldedit2pos1 = a + "," + b + "," + c;
        a = x + 9; b = y + -1; c = z + 14;
        worldedit2pos2 = a + "," + b + "," + c;
    }//complete
    //3
    static void WestStoreCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Sign Commands:");
        //Directional script
        signdirection = "west";
        //---------------------

        //   1  West Store ----- West
        a = x - 2; b = y + 2; c = z - 2;
        coordinates1 = a + " " + b + " " + c;
        a = x - 2; b = y + 2; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        CommandOutput();

        //   2  West Store ----- South
        a = x - 2; b = y + 0; c = z - 2;
        coordinates1 = a + " " + b + " " + c;
        a = x - 2; b = y + 0; c = z - 1;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        CommandOutput();

        //   3  West Store ----- South
        a = x - 2; b = y + 0; c = z + 1;
        coordinates1 = a + " " + b + " " + c;
        a = x - 2; b = y + 0; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        CommandOutput();

        //Directional script
        signdirection = "north";
        //---------------------

        //   1  West Store ----- North
        a = x - 3; b = y + 2; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x - 13; b = y + 2; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("4. ");
        CommandOutput();

        //   2  West Store ----- North
        a = x - 3; b = y + 0; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x - 13; b = y + 0; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("5. ");
        CommandOutput();

        //Directional script
        signdirection = "east";
        //---------------------

        //   1  West Store ----- East
        a = x - 14; b = y + 2; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x - 14; b = y + 2; c = z - 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("6. ");
        CommandOutput();

        //   2  West Store ----- East
        a = x - 14; b = y + 0; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x - 14; b = y + 0; c = z - 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("7. ");
        CommandOutput();

        //Directional script
        signdirection = "south";
        //---------------------

        //   1  West Store ----- South
        a = x - 13; b = y + 2; c = z - 2;
        coordinates1 = a + " " + b + " " + c;
        a = x - 3; b = y + 2; c = z - 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("8. ");
        CommandOutput();

        //   2  West Store ----- South
        a = x - 13; b = y + 0; c = z + 13;
        coordinates1 = a + " " + b + " " + c;
        a = x - 3; b = y + 0; c = z + 3;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("9. ");
        CommandOutput();

        //Owner Signs
        //Directional script
        signdirection = "east";
        //---------------------

        Console.WriteLine();
        Console.WriteLine("Owner Sign Commands:");
        a = x + 1; b = y + 2; c = z + 0;
        coordinates1 = a + " " + b + " " + c;
        a = x + 1; b = y + 2; c = z + 0;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        SignVoid();
        Console.Write("2. ");
        OwnerSign();
        OwnerSignReset();

        //For worldguard
        a = x + -14; b = y + 0; c = z + 2;
        worldeditpos1 = a + "," + b + "," + c;
        a = x + -2; b = y + 2; c = z + -2;
        worldeditpos2 = a + "," + b + "," + c;
    }//complete
    static void WestStoreChestRoomCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Chest Room Coordinates: ");
        //Directional Script
        chestdirection = "east";
        //---------------------
        a = x + -16; b = y + -4; c = z + 3;
        coordinates1 = a + " " + b + " " + c;
        a = x + -16; b = y + -3; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        ChestOutput();

        a = x + -16; b = y + -4; c = z + -2;
        coordinates1 = a + " " + b + " " + c;
        a = x + -16; b = y + -3; c = z + -3;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        ChestOutput();

        a = x + -16; b = y + -4; c = z + -4;
        coordinates1 = a + " " + b + " " + c;
        a = x + -16; b = y + -4; c = z + -4;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        ChestOutput();

        //Directional Script
        chestdirection = "south";
        //---------------------
        a = x + -14; b = y + -4; c = z + -4;
        coordinates1 = a + " " + b + " " + c;
        a = x + -2; b = y + -3; c = z + -4;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("4. ");
        ChestOutput();

        //Directional Script
        chestdirection = "west";
        //---------------------
        a = x + 0; b = y + -4; c = z + -2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + -3; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("5. ");
        ChestOutput();

        //Directional Script
        chestdirection = "north";
        //---------------------
        a = x + -14; b = y + -4; c = z + 4;
        coordinates1 = a + " " + b + " " + c;
        a = x + -2; b = y + -3; c = z + 4;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("6. ");
        ChestOutput();

        //For worldguard
        a = x + -16; b = y + -4; c = z + 4;
        worldedit2pos1 = a + "," + b + "," + c;
        a = x + 0; b = y + -2; c = z + -4;
        worldedit2pos2 = a + "," + b + "," + c;
    }//complete
    //2
    static void EastMarketCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Sign Commands:");
        //Directional script
        signdirection = "east";
        //---------------------

        //   1  East Market
        a = x + 0; b = y + 2; c = z + 6;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + 2; c = z + 3;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        CommandOutput();

        //   2  East Market
        a = x + 0; b = y + 0; c = z + 6;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + 0; c = z + 3;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        CommandOutput();

        //   3  East Market
        a = x + 0; b = y + 2; c = z + -3;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + 2; c = z + -6;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        CommandOutput();

        //   4  East Market
        a = x + 0; b = y + 0; c = z + -3;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + 0; c = z + -6;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("4. ");
        CommandOutput();

        //Directional script
        signdirection = "south";
        //---------------------

        //   1  East Market
        a = x + 0; b = y + 2; c = z + -7;
        coordinates1 = a + " " + b + " " + c;
        a = x + 22; b = y + 2; c = z + -7;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("5. ");
        CommandOutput();

        //   2  East Market
        a = x + 0; b = y + 0; c = z + -7;
        coordinates1 = a + " " + b + " " + c;
        a = x + 22; b = y + 0; c = z + -7;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("6. ");
        CommandOutput();

        //Directional script
        signdirection = "west";
        //---------------------

        //   1  East Market
        a = x + 22; b = y + 2; c = z + -6;
        coordinates1 = a + " " + b + " " + c;
        a = x + 22; b = y + 2; c = z + 6;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("7. ");
        CommandOutput();

        //   2  East Market
        a = x + 22; b = y + 0; c = z + -6;
        coordinates1 = a + " " + b + " " + c;
        a = x + 22; b = y + 0; c = z + 6;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("8. ");
        CommandOutput();

        //Directional script
        signdirection = "north";
        //---------------------

        //   1  East Market
        a = x + 0; b = y + 2; c = z + 7;
        coordinates1 = a + " " + b + " " + c;
        a = x + 22; b = y + 2; c = z + 7;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("9. ");
        CommandOutput();

        //   2  East Market
        a = x + 0; b = y + 0; c = z + 7;
        coordinates1 = a + " " + b + " " + c;
        a = x + 22; b = y + 0; c = z + 7;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("10. ");
        CommandOutput();

        //Owner Signs
        //Directional script
        signdirection = "west";
        //---------------------

        Console.WriteLine();
        Console.WriteLine("Owner Sign Commands:");
        a = x + -3; b = y + -1; c = z + -2;
        coordinates1 = a + " " + b + " " + c;
        a = x + -3; b = y + -1; c = z + -2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        SignVoid();
        Console.Write("2. ");
        OwnerSign();
        OwnerSignReset();

        a = x + -3; b = y + -1; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + -3; b = y + -1; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        SignVoid();
        Console.Write("2. ");
        OwnerSign();
        OwnerSignReset2();

        //For worldguard
        a = x + 0; b = y + 0; c = z + -7;
        worldeditpos1 = a + "," + b + "," + c;
        a = x + 22; b = y + 2; c = z + 7;
        worldeditpos2 = a + "," + b + "," + c;
    }//complete
    static void EastMarketChestRoomCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Chest Room Coordinates: ");
        //Directional Script
        chestdirection = "north";
        //---------------------
        a = x + 21; b = y + -5; c = z + -6;
        coordinates1 = a + " " + b + " " + c;
        a = x + 1; b = y + -3; c = z + -6;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        ChestOutput();

        a = x + 20; b = y + -5; c = z + -2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 1; b = y + -3; c = z + -2;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        ChestOutput();


        //Directional Script
        chestdirection = "south";
        //---------------------
        a = x + 20; b = y + -5; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 1; b = y + -3; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        ChestOutput();

        a = x + 21; b = y + -5; c = z + 6;
        coordinates1 = a + " " + b + " " + c;
        a = x + 1; b = y + -3; c = z + 6;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("4. ");
        ChestOutput();

        //For worldguard
        a = x + 21; b = y + -5; c = z + -6;
        worldedit2pos1 = a + "," + b + "," + c;
        a = x + 1; b = y + -2; c = z + 6;
        worldedit2pos2 = a + "," + b + "," + c;
    }//complete
    //2
    static void WestMarketCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Sign Commands:");
        //Directional script
        signdirection = "west";
        //---------------------

        //   1  West Market
        a = x + 0; b = y + 2; c = z + -6;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + 2; c = z + -3;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;
        
        Console.Write("1. ");
        CommandOutput();

        //   2  West Market
        a = x + 0; b = y + 0; c = z + -6;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + 0; c = z + -3;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        CommandOutput();

        //   3  West Market
        a = x + 0; b = y + 2; c = z + 3;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + 2; c = z + 6;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        CommandOutput();

        //   4  West Market
        a = x + 0; b = y + 0; c = z + 3;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + 0; c = z + 6;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("4. ");
        CommandOutput();


        //Directional script
        signdirection = "north";
        //---------------------

        //   1  West Market
        a = x + 0; b = y + 2; c = z + 7;
        coordinates1 = a + " " + b + " " + c;
        a = x + -22; b = y + 2; c = z + 7;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("5. ");
        CommandOutput();

        //   2  West Market
        a = x + 0; b = y + 0; c = z + 7;
        coordinates1 = a + " " + b + " " + c;
        a = x + -22; b = y + 0; c = z + 7;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("6. ");
        CommandOutput();

        //Directional script
        signdirection = "east";
        //---------------------

        //   1  West Market
        a = x + -22; b = y + 2; c = z + 6;
        coordinates1 = a + " " + b + " " + c;
        a = x + -22; b = y + 2; c = z + -6;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("7. ");
        CommandOutput();

        //   2  West Market
        a = x + -22; b = y + 0; c = z + 6;
        coordinates1 = a + " " + b + " " + c;
        a = x + -22; b = y + 0; c = z + -6;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("8. ");
        CommandOutput();

        //Directional script
        signdirection = "south";
        //---------------------

        //   1  West Market
        a = x + -22; b = y + 2; c = z + -7;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + 2; c = z + -7;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("9. ");
        CommandOutput();

        //   2  West Market
        a = x + -22; b = y + 0; c = z + -7;
        coordinates1 = a + " " + b + " " + c;
        a = x + 0; b = y + 0; c = z + -7;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("10. ");
        CommandOutput();

        //Owner Signs
        //Directional script
        signdirection = "east";
        //---------------------

        Console.WriteLine();
        Console.WriteLine("Owner Sign Commands:");
        a = x + 3; b = y + -1; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 3; b = y + -1; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        SignVoid();
        Console.Write("2. ");
        OwnerSign();
        OwnerSignReset();

        a = x + 3; b = y + -1; c = z + -2;
        coordinates1 = a + " " + b + " " + c;
        a = x + 3; b = y + -1; c = z + -2;
        coordinates2 = a + " " + b + " " + c;
        signRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        SignVoid();
        Console.Write("2. ");
        OwnerSign();
        OwnerSignReset2();

        //For worldguard
        a = x + 0; b = y + 0; c = z + 7;
        worldeditpos1 = a + "," + b + "," + c;
        a = x + -22; b = y + 2; c = z + -7;
        worldeditpos2 = a + "," + b + "," + c;
    }//complete
    static void WestMarketChestRoomCoordinate()
    {
        Console.WriteLine();
        Console.WriteLine("Chest Room Coordinates: ");
        //Directional Script
        chestdirection = "south";
        //---------------------
        a = x + -21; b = y + -5; c = z + 6;
        coordinates1 = a + " " + b + " " + c;
        a = x + -1; b = y + -3; c = z + 6;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("1. ");
        ChestOutput();

        a = x + -20; b = y + -5; c = z + 2;
        coordinates1 = a + " " + b + " " + c;
        a = x + -1; b = y + -3; c = z + 2;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("2. ");
        ChestOutput();

        //Directional Script
        chestdirection = "north";
        //---------------------

        a = x + -20; b = y + -5; c = z + -2;
        coordinates1 = a + " " + b + " " + c;
        a = x + -1; b = y + -3; c = z + -2;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("3. ");
        ChestOutput();

        a = x + -21; b = y + -5; c = z + -6;
        coordinates1 = a + " " + b + " " + c;
        a = x + -1; b = y + -3; c = z + -6;
        coordinates2 = a + " " + b + " " + c;
        chestRow = coordinates1 + " " + coordinates2;

        Console.Write("4. ");
        ChestOutput();

        //For worldguard
        a = x + -21; b = y + -5; c = z + 6;
        worldedit2pos1 = a + "," + b + "," + c;
        a = x + -1; b = y + -2; c = z + -6;
        worldedit2pos2 = a + "," + b + "," + c;
    }//complete


    static void StoreReset()
    {
        Console.WriteLine();
        Console.WriteLine("Reset Commands:");
        Console.WriteLine(worldguardCommand1 = "/worldedit:/world " + worldguardWorld);
        Console.WriteLine(worldguardSub1Command1 = "/worldedit:/pos1 " + worldeditpos1);
        Console.WriteLine(worldguardSub1Command2 = "/worldedit:/pos2 " + worldeditpos2);
        Console.WriteLine(worldguardSub1Command3 = "/worldguard:rg remove " + shopmain);
        Console.WriteLine("/worldedit:/replace oak_wall_sign air");
        SellShop();//2 r
        BarrierReset();//2 r
        Console.WriteLine();
        Console.WriteLine("Reset Commands (Contd.): ");
        Console.WriteLine(worldguardCommand2 = "/worldedit:/world " + worldguardWorld);
        Console.WriteLine(worldguardSub2Command1 = "/worldedit:/pos1 " + worldedit2pos1);
        Console.WriteLine(worldguardSub2Command2 = "/worldedit:/pos2 " + worldedit2pos2);
        Console.WriteLine(worldguardSub2Command3 = "/worldguard:rg remove " + shopstorage);
        //Console.WriteLine(worldguardSub2Command4 = "/worldguard:rg remove " + shopblock);
        Console.WriteLine("/worldedit:/replace chest air");
        Console.WriteLine("/rg removeowner -w " + "\"" + worldRaw + "\" " + shopreset + " @p");
        Console.WriteLine("/tp @p " + x + " " + y + " " + z);
        if (shopType == "Store")
        {
            Console.WriteLine();
            Console.Write("1. ");
            Console.WriteLine(signReset1a);
            Console.Write("1. ");
            Console.WriteLine(signReset1);
        }
        else
        {
            Console.WriteLine();
            Console.Write("1. ");
            Console.WriteLine(signReset1a);
            Console.Write("1. ");
            Console.WriteLine(signReset1);
            Console.Write("2. ");
            Console.WriteLine(signReset2a);
            Console.Write("2. ");
            Console.WriteLine(signReset2);
        }
        r = r + 13;
        reset = reset + 13;
    }
    static void Totals()
    {
        Console.WriteLine();
        Console.WriteLine("Total Commands: " + r);
        Console.WriteLine("Standard Commands: " + standard);
        Console.WriteLine("Player Commands: " + player);
        Console.WriteLine("Reset Commands: " + reset);
        Console.WriteLine("Last Commands: " + lastcommands);
    }

    public static void Main()
    {
        Console.WriteLine("Enter shop coordinate (Coordinate of door): ");
        string[] coordinate = Console.ReadLine().Split(' ');
        x = int.Parse(coordinate[0]);
        y = int.Parse(coordinate[1]);
        z = int.Parse(coordinate[2]);
        Console.WriteLine("Enter shop purchasing coordinate (chest): ");
        shopChest = Console.ReadLine();
        string[] shopChestParse = shopChest.Split(' ');
        ax = int.Parse(shopChestParse[0]);
        ay = int.Parse(shopChestParse[1]);
        az = int.Parse(shopChestParse[2]);
        Console.WriteLine("Enter type of shop (Stall | Store | Market): ");
        shopType = Console.ReadLine();
        Console.WriteLine("Direction of Shop (North | East | South | West): ");
        shopDirection = Console.ReadLine();
        Console.WriteLine("Enter token name: ");
        shopToken = Console.ReadLine();
        Console.WriteLine("Enter world name (Raw string from /world): ");
        worldRaw = Console.ReadLine();
        worldguardWorld = worldRaw.ToLower();
        Console.WriteLine("Enter Shop Number: ");
        shopNum = Convert.ToInt32(Console.ReadLine());
        shopmain = shopType.ToLower() + shopNum + "_main";
        shopstorage = shopType.ToLower() + shopNum + "_storage";
        shopblock = shopType.ToLower() + shopNum + "_block";
        shopreset = shopType.ToLower() + shopNum + "_reset";

        if (shopType == "Stall")
        {
            shopPrice = 100000;
            tokenType = "dirt_path";
            if (shopDirection == "North")
            {
                Console.WriteLine("Invalid Shop Direction");
                return;
            }
            else if (shopDirection == "East")
            {
                //Sign Coordinates
                EastStallCoordinate();

                //Stall Chest Room ----- West
                EastStallChestRoomCoordinate();

                //Worldguard Implementatiion
                WorldguardOutput();

                //Server Output
                ServerOutput();

            }
            else if (shopDirection == "South")
            {
                Console.WriteLine("Invalid Shop Direction");
                return;
            }
            else if (shopDirection == "West")
            {
                //Sign Coordinates
                WestStallCoordinate();

                //Stall Chest Room ----- East
                WestStallChestRoomCoordinate();

                //Worldguard Implementatiion
                WorldguardOutput();

                //Server Output
                ServerOutput();
            }
            else
            {
                Console.WriteLine("Invalid Shop Direction");
                return;
            }
        }
        else if (shopType == "Store")
        {
            shopPrice = 2000000;
            tokenType = "farmland";
            if (shopDirection == "North")
            {
                //Sign Coordinates
                NorthStoreCoordinate();

                //Storage Coordinates
                NorthStoreChestRoomCoordinate();

                //Worldguard Implementatiion
                WorldguardOutput();

                //Server Output
                ServerOutput();

            }
            else if (shopDirection == "East")
            {
                //Sign Coordinates
                EastStoreCoordinate();

                //Storage Coordinates
                EastStoreChestRoomCoordinate();

                //Worldguard Implementatiion
                WorldguardOutput();

                //Server Output
                ServerOutput();

            }
            else if (shopDirection == "South")
            {
                //Sign Coordinates
                SouthStoreCoordinate();

                //Storage Coordinates
                SouthStoreChestRoomCoordinate();

                //Worldguard Implementatiion
                WorldguardOutput();

                //Server Output
                ServerOutput();

            }
            else if (shopDirection == "West")
            {
                //Sign Coordinates
                WestStoreCoordinate();

                //Storage Coordinates
                WestStoreChestRoomCoordinate();

                //Worldguard Implementatiion
                WorldguardOutput();

                //Server Output
                ServerOutput();

            }
            else
            {
                return;
            }
        }
        else if (shopType == "Market")
        {
            shopPrice = 25000000;
            tokenType = "chorus_plant";
            if (shopDirection == "North")
            {
                return;
            }
            else if (shopDirection == "East")
            {
                //Sign Coordinates
                EastMarketCoordinate();

                //Storage Coordinates
                EastMarketChestRoomCoordinate();

                //Worldguard Implementatiion
                WorldguardOutput();

                //Server Output
                ServerOutput();

            }
            else if (shopDirection == "South")
            {
                return;
            }
            else if (shopDirection == "West")
            {
                //Sign Coordinates
                WestMarketCoordinate();

                //Storage Coordinates
                WestMarketChestRoomCoordinate();

                //Worldguard Implementatiion
                WorldguardOutput();

                //Server Output
                ServerOutput();

            }
            else
            {
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid Shop Type");
            return;
        }
        ChestClear();
        HopperClear();
        StoreReset();
        Totals();
        Console.WriteLine();
        Console.WriteLine(shopType);
    }
}