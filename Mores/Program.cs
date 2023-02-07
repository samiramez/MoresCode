using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose translation:");
            Console.WriteLine("[1] String to Morse");
            Console.WriteLine("[2] Morse to String");
            int.TryParse(Console.ReadLine(), out int selection);


            Console.WriteLine($"You've choosen: [{selection}]");

            string read = Console.ReadLine().ToUpper();

           // string[] ToMores = new string[read.Length];

            Dictionary<char, String> morse = new Dictionary<char, String>()
                {
                    {'A' , ".-"},
                    {'B' , "-..."},
                    {'C' , "-.-."},
                    {'D' , "-.."},
                    {'E' , "."},
                    {'F' , "..-."},
                    {'G' , "--."},
                    {'H' , "...."},
                    {'I' , ".."},
                    {'J' , ".---"},
                    {'K' , "-.-"},
                    {'L' , ".-.."},
                    {'M' , "--"},
                    {'N' , "-."},
                    {'O' , "---"},
                    {'P' , ".--."},
                    {'Q' , "--.-"},
                    {'R' , ".-."},
                    {'S' , "..."},
                    {'T' , "-"},
                    {'U' , "..-"},
                    {'V' , "...-"},
                    {'W' , ".--"},
                    {'X' , "-..-"},
                    {'Y' , "-.--"},
                    {'Z' , "--.."},
                    {'0' , "-----"},
                    {'1' , ".----"},
                    {'2' , "..---"},
                    {'3' , "...--"},
                    {'4' , "....-"},
                    {'5' , "....."},
                    {'6' , "-...."},
                    {'7' , "--..."},
                    {'8' , "---.."},
                    {'9' , "----."},
                };
            Dictionary<string, char> convertToMorse = new Dictionary<string, char>()
            {
                    {".-",'A'},
                    {"-...",'B'},
                    {"-.-.",'C'},
                    {"-..",'D'},
                    {".",'E'},
                    {"..-.",'F'},
                    {"--.",'G'},
                    {"....",'H'},
                    {".." , 'I'},
                    {".---" , 'J'},
                    {"-.-" , 'K'},
                    {".-.." , 'L'},
                    {"--" , 'M'},
                    {"-." , 'N'},
                    {"---" , 'O'},
                    {".--." , 'P'},
                    {"--.-" , 'Q'},
                    {".-." , 'R'},
                    {"..." , 'S'},
                    {"-" , 'T'},
                    {"..-" , 'U'},
                    {"...-" , 'V'},
                    {".--" , 'W'},
                    {"-..-" , 'X'},
                    {"-.--" , 'Y'},
                    {"--.." , 'Z'},
                    {"-----" , '0'},
                    {".----" , '1'},
                    {"..---" , '2'},
                    {"...--" , '3'},
                    {"....-" , '4'},
                    {"....." , '5'},
                    {"-...." , '6'},
                    {"--..." , '7'},
                    {"---.." , '8'},
                    {"----." , '9'},
            };

            string[] words = read.Split(' ');
            string decodedMessage = "";

            if (selection == 1)
            {
                for (int i = 0; i < read.Length; i++)
                {
                    char c = read[i];
                    if (morse.ContainsKey(c))
                        Console.Write(morse[c] + " ");
                }
            }
            else if (selection == 2)
            {
               foreach(string word in words)
                {
                    string decodedWord = "";
                    string[] characters = word.Split(' ');
                    foreach(string character in characters)
                    {
                        decodedWord += convertToMorse[character];
                    }
                    decodedMessage += decodedWord;
                }

                Console.WriteLine(decodedMessage);
            }
           
            Console.ReadLine();

        }
    }
}

/*
 
            char[] m = read.ToCharArray();
            string[] output = new string[m.Length];
            string A = ".-", B = "-...", C = "-.-.", D = "-..", E = ".", F = "..-.", G = "--.", H = "....", I = "..",
                J = ".---", K = "-.-", L = ".-..", M = "--", N = "-.", O = "---", P = ".--.", Q = "--.-", R = ".-.", S = "...",
                T = "-", U = "..-", V = "...-", W = ".--", X = "-..-", Y = "-.--", Z = "--..", A1 = ".----", A2 = "..---", A3 = "...--",
                A4 = "....-", A5 = ".....", A6 = "-....", A7 = "--...", A8 = "---..", A9 = "----.", A0 = "-----";               

            for(int i=0;i <m.Length;i++)
            {
                if (m[i] == 'A')
                {
                    output[i] = A+" ";
                }
                if (m[i] == 'B')
                {
                    output[i] = B + " ";
                }
                if (m[i] == 'C')
                {
                    output[i] = C + " ";
                }
                if (m[i] == 'D')
                {
                    output[i] = D + " ";
                }
                if (m[i] == 'E')
                {
                    output[i] = E + " ";
                }
                if (m[i] == 'F')
                {
                    output[i] = F + " ";
                }
                if (m[i] == 'G')
                {
                    output[i] = G + " ";
                }
                if (m[i] == 'H')
                {
                    output[i] = H + " ";
                }
                if (m[i] == 'J')
                {
                    output[i] = J + " ";
                }
                if (m[i] == 'I')
                {
                    output[i] = I + " ";
                }
                if (m[i] == 'K')
                {
                    output[i] = K + " ";
                }
                if (m[i] == 'L')
                {
                    output[i] = L + " ";
                }
                if (m[i] == 'M')
                {
                    output[i] = M + " ";
                }
                if (m[i] == 'N')
                {
                    output[i] = N + " ";
                }
                if (m[i] == 'O')
                {
                    output[i] = O + " ";
                }
                if (m[i] == 'P')
                {
                    output[i] = P + " ";
                }
                if (m[i] == 'Q')
                {
                    output[i] = Q + " ";
                }
                if (m[i] == 'R')
                {
                    output[i] = R + " ";
                }
                if (m[i] == 'S')
                {
                    output[i] = S + " ";
                }
                if (m[i] == 'T')
                {
                    output[i] = T + " ";
                }
                if (m[i] == 'U')
                {
                    output[i] = U + " ";
                }
                if (m[i] == 'V')
                {
                    output[i] = V + " ";
                }
                if (m[i] == 'W')
                {
                    output[i] = W + " ";
                }
                if (m[i] == 'X')
                {
                    output[i] = X + " ";
                }
                if (m[i] == 'Y')
                {
                    output[i] = Y + " ";
                }
                if (m[i] == 'Z')
                {
                    output[i] = Z + " ";
                }
                if (m[i] == '1')
                {
                    output[i] = A1 + " ";
                }
                if (m[i] == '2')
                {
                    output[i] = A2 + " ";
                }
                if (m[i] == '3')
                {
                    output[i] = A3 + " ";
                }
                if (m[i] == '4')
                {
                    output[i] = A4 + " ";
                }
                if (m[i] == '5')
                {
                    output[i] = A5 + " ";
                }
                if (m[i] == '6')
                {
                    output[i] = A6 + " ";
                }
                if (m[i] == '7')
                {
                    output[i] = A7 + " ";
                }
                if (m[i] == '8')
                {
                    output[i] = A8 + " ";
                }
                if (m[i] == '9')
                {
                    output[i] = A9 + " ";
                }
                if (m[i] == '0')
                {
                    output[i] = A0 + " ";
                }               
            }
            for(int i=0;i<output.Length;i++)
            {
                Console.Write(output[i]);
            }
 
 
 */


/*
 

            char[] text = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] TranslatedMorse = { "    |", " . - |", " - . . . |", " - . - . |", " - . . |", " . |", " . . - . |"
                    , " - - . |", " . . . . |", " . . |", " . - - - |", " - . - |", " . - . . |", " - - |",
                " - . |", " - - - |", " . - - . |", " - - . - |", " . - . |", " . . . |", " _ |", " . . - |",
                " . . . - |", " . - - |", " - . . - |", " - . - - |", " - - . . |", " . - - - - |",
                " . . - - - |", " . . . - - |", " . . . . - |", " . . . . . |", " - . . . . |", " - - . . . |",
                " - - - . . |", " - - - - . |", " - - - - - |" };
            Console.WriteLine("Choose translation:");
            Console.WriteLine("[1] String to Morse");
            Console.WriteLine("[2] Morse to String");
            int.TryParse(Console.ReadLine(), out int selection);
            Console.WriteLine($"You've choosen: [{selection}]");
            string ToTranslate = "";
            string TranslatedText = "";
            if (selection == 1)
            {
                Console.WriteLine("Enter text:");
                ToTranslate = Console.ReadLine();
                ToTranslate = ToTranslate.ToLower();
                for (int i = 0; i < ToTranslate.Length; i++)
                {
                    for (int j = 0; j < 37; j++)
                    {
                        if (ToTranslate[i] == text[j])
                        {
                            TranslatedText += TranslatedMorse[j];
                            break;
                        }
                    }
                }
                Console.WriteLine($"Translated text: {TranslatedText}");

            }
            else if (selection == 2)
            {
                Console.WriteLine("Enter morse code using '.' or '-', split each letter by space, whole words split by two spaces");
                ToTranslate = Console.ReadLine();
                //This I need to solve.
            }
            else
            {
                Console.WriteLine("Nothing selected, program will shut down");
                System.Environment.Exit(1);
            }
        

 
 */


/*
   static string morseEnc1ode(char x)
        {

            // refer to the Morse table
            // image attached in the article
            switch (x)
            {
                case 'a':
                    return ".-";
                case 'b':
                    return "-...";
                case 'c':
                    return "-.-.";
                case 'd':
                    return "-..";
                case 'e':
                    return ".";
                case 'f':
                    return "..-.";
                case 'g':
                    return "--.";
                case 'h':
                    return "....";
                case 'i':
                    return "..";
                case 'j':
                    return ".---";
                case 'k':
                    return "-.-";
                case 'l':
                    return ".-..";
                case 'm':
                    return "--";
                case 'n':
                    return "-.";
                case 'o':
                    return "---";
                case 'p':
                    return ".--.";
                case 'q':
                    return "--.-";
                case 'r':
                    return ".-.";
                case 's':
                    return "...";
                case 't':
                    return "-";
                case 'u':
                    return "..-";
                case 'v':
                    return "...-";
                case 'w':
                    return ".--";
                case 'x':
                    return "-..-";
                case 'y':
                    return "-.--";
                // for space
                case 'z':
                    return "--..";

                case '1':
                    return ".----";
                case '2':
                    return "..---";
                case '3':
                    return "...--";
                case '4':
                    return "....-";
                case '5':
                    return ".....";
                case '6':
                    return "-....";
                case '7':
                    return "--...";
                case '8':
                    return "---..";
                case '9':
                    return "----.";
                case '0':
                    return "-----";
            }
            return "";
        }

        static char Enc1odeMores(string x)
        {

            // refer to the Morse table
            // image attached in the article
            switch (x)
            {
                case ".-":
                    return 'a';
                case "-...":
                    return 'b';
                case "-.-.":
                    return 'c';
                case "-..":
                    return 'd';
                case ".":
                    return 'e';
                case ".. -.":
                    return 'f';

            }
            return '-';


            //    case 'g':
            //        return "--.";
            //    case 'h':
            //        return "....";
            //    case 'i':
            //        return "..";
            //    case 'j':
            //        return ".---";
            //    case 'k':
            //        return "-.-";
            //    case 'l':
            //        return ".-..";
            //    case 'm':
            //        return "--";
            //    case 'n':
            //        return "-.";
            //    case 'o':
            //        return "---";
            //    case 'p':
            //        return ".--.";
            //    case 'q':
            //        return "--.-";
            //    case 'r':
            //        return ".-.";
            //    case 's':
            //        return "...";
            //    case 't':
            //        return "-";
            //    case 'u':
            //        return "..-";
            //    case 'v':
            //        return "...-";
            //    case 'w':
            //        return ".--";
            //    case 'x':
            //        return "-..-";
            //    case 'y':
            //        return "-.--";
            //    // for space
            //    case 'z':
            //        return "--..";

            //    case '1':
            //        return ".----";
            //    case '2':
            //        return "..---";
            //    case '3':
            //        return "...--";
            //    case '4':
            //        return "....-";
            //    case '5':
            //        return ".....";
            //    case '6':
            //        return "-....";
            //    case '7':
            //        return "--...";
            //    case '8':
            //        return "---..";
            //    case '9':
            //        return "----.";
            //    case '0':
            //        return "-----";
            //}
        }

        static void fromMores(char[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(Enc1odeMores(a[i].ToString())+" ");
            }
        }

            static void morseCode(string s)
        {
            // character by character print
            // Morse code
            for (int i = 0; i < s.Length; i++)
                Console.Write(morseEnc1ode(s[i])+" ");
            Console.WriteLine();
        }
    }
 
 */

/*
             Dictionary<string, char> convertToMorse = new Dictionary<string, char>()
                {
                    {".-",'A'},
                    {"-...",'B'},
                    {"-.-.",'C'},
                    {"-..",'D'},
                    {".",'E'},
                    {"..-.",'F'},
                    {"--.",'G'},
                    {"....",'H'},
                    {".." , 'I'},
                    {".---" , 'J'},
                    {"-.-" , 'K'},
                    {".-.." , 'L'},
                    {"--" , 'M'},
                    {"-." , 'N'},
                    {"---" , 'O'},
                    {".--." , 'P'},
                    {"--.-" , 'Q'},
                    {".-." , 'R'},
                    {"..." , 'S'},
                    {"-" , 'T'},
                    {"..-" , 'U'},
                    {"...-" , 'V'},
                    {".--" , 'W'},
                    {"-..-" , 'X'},
                    {"-.--" , 'Y'},
                    {"--.." , 'Z'},
                    {"-----" , '0'},
                    {".----" , '1'},
                    {"..---" , '2'},
                    {"...--" , '3'},
                    {"....-" , '4'},
                    {"....." , '5'},
                    {"-...." , '6'},
                    {"--..." , '7'},
                    {"---.." , '8'},
                    {"----." , '9'},
                };

 */