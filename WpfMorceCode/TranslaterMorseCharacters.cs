using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMorceCode
{
    class TranslaterMorseCharacters
    {
        public static string setStringMorse(string crt)
        {

            if (crt != null)
            {
                crt = crt.Replace("  ", " space ");

                return crt;
            }

            return null;
        }



        public static List<string> ListMorse(string crt)
        {
            List<string> listMorse = new List<string>();
            if (crt != null)
            {
                String[] str = crt.Split(' ');
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    listMorse.Add(str[i]);
                }

                return listMorse;
            }

            return null;
        }

        public static string TranslaterMorse(string crt)
        {
            if (crt != null)
            {

                switch (crt)
                {

                    case "....":
                        return "H";
                    case ".":
                        return "E";
                    case "-.--":
                        return "Y";
                    case ".---":
                        return "J";
                    case "..-":
                        return "U";
                    case "-..":
                        return "D";
                    case ".-":
                        return "A";
                    case "-...":
                        return "B";
                    case "-.-.":
                        return "C";
                    case "..-.":
                        return "F";
                    case "--.":
                        return "G";
                    case "..":
                        return "I";
                    case "-.-":
                        return "K";
                    case ".-..":
                        return "L";
                    case "--":
                        return "M";
                    case "-.":
                        return "N";
                    case "---":
                        return "O";
                    case ".--.":
                        return "P";
                    case "--.-":
                        return "Q";
                    case ".-.":
                        return "R";
                    case "...":
                        return "S";
                    case "-":
                        return "T";
                    case "..--":
                        return "U";
                    case "...-":
                        return "V";
                    case ".--":
                        return "W";
                    case "-..-":
                        return "X";
                    case "--..":
                        return "Z";
                    case ".----":
                        return "1";
                    case "..---":
                        return "2";
                    case "...--":
                        return "3";
                    case "....-":
                        return "4";
                    case ".....":
                        return "5";
                    case "-....":
                        return "6";
                    case "--...":
                        return "7";
                    case "---..":
                        return "8";
                    case "----.":
                        return "9";
                    case "-----":
                        return "0";
                    case "space":
                        return " ";
                    default:
                        return "";
                }
            }

            return "";
        }



        public static string decodeMorse(string morseCode)
        {
            if (morseCode != null)
            {
                morseCode = setStringMorse(morseCode);

                List<string> listMorse = ListMorse(morseCode);
                morseCode = "";

                for (int i = listMorse.Count - 1; i >= 0; i--)

                    morseCode += TranslaterMorse(listMorse[i]);

                return morseCode;
            }

            return "";
        }

    }
}
