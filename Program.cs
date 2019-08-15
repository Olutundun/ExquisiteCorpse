using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            //BuildACreature("ghost", "monster", "bug");
            Console.WriteLine("***WELCOME TO EXQUISITE CORPSE!!***");
            Console.Write("Enter YES to randomly generate a creature or NO to create one manually: ");
            string answer = Console.ReadLine().ToUpper();
            switch (answer)
            {
                case "YES":
                    RandomMode();
                    break;
                case "NO":
                    ManualMode();
                    break;
                default:
                    RandomMode();
                    break;
            }

        }
        static void BuildACreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);
            SwitchCase(headNum, bodyNum, feetNum);
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            SwitchCase(head, body, feet);
        }

        static void ManualMode()
        {
            Console.WriteLine("Are you ready to create your own creature?");
            Console.WriteLine("Let's get started!");
            Console.WriteLine("Enter two underscores like this: __");
            Console.WriteLine("On the second line, Enter a small letter o,a dash, a single quote, a vertical bar, a back slash, three underscores, a forward slash and a closing parenthesis.");
            Console.WriteLine("On the third line, enter a back slash, an underscore, forward slash, a vertical bar (tip: make sure it aligns with the top one), an underscore, a closing parenthesis, four spaces and a closing parenthesis(tip: make it align with the top one)");
            Console.WriteLine("On the third line start right below the vertical bar. Enter two foward slash, an opening parenthesis, two underscores, a closing parenthesis and two back slash like this: //(__)\\ ");
            Console.WriteLine("On the last line, enter two vertical bars, four spaces and teo more veritical bar");
            Console.WriteLine("Voila! You just created a dog spider like this: ||    || ");
        }
        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    MonsterHead();
                    break;
                case 3:
                    BugHead();
                    break;
            }
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    MonsterBody();
                    break;
                case 3:
                    BugBody();
                    break;
            }
            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    MonsterFeet();
                    break;
                case 3:
                    BugFeet();
                    break;
            }
        }

        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;
                case "monster":
                    return 2;
                case "bug":
                    return 3;
                default:
                    return 1;
            }
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
