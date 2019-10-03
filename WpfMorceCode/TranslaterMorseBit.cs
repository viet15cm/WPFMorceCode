using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMorceCode
{
    class TranslaterMorseBit
    {
        /* public static string ReverseBits(string bits)
         {
             string str = "";

             for (int i = bits.Length - 1 ; i >= 0; i--)

                 str = str + bits[i];

             return str;
         }
         */

        /*public static string DistributeBits(string bits)
       {
           string str = "";

           for(int i = bits.Length -1; i>=0; i--)
           {
               str += bits[i];
               if (i == 0) break;
               if (str[str.Length - 1] != bits[i-1])
                   return str;
           }

           return str;

       }
       */


        public static int LocationBits(string bits)
        {
            if (bits != null)
                for (int i = bits.Length - 1; i >= 0; i--)
                {
                    if (i == 0)
                        return i;
                    if (bits[i] != bits[i - 1])
                        return i;

                }



            return 0;
        }



        public static string CutBitsRight(string bits, int viTri)
        {
            if (bits != null)

                return bits.Remove(viTri, (bits.Length) - viTri);

            return null;

        }

        public static string CutBitsLeft(string bits, int viTri)
        {
            if (bits != null)

                return bits.Remove(0, viTri);

            return null;

        }


        public static List<string> ListBit(string bits)
        {
            List<string> listBits = new List<string>();

            if (bits != null)
            {
                string bitsLeft;
                string bitsRight;

                while (bits.Length != 0)
                {
                    bitsLeft = CutBitsRight(bits, LocationBits(bits));
                    bitsRight = CutBitsLeft(bits, bitsLeft.Length);
                    listBits.Add(bitsRight);
                    bits = bitsLeft;
                }
            }


            return listBits;
        }


        public static string LogicMorseBit(string bits)
        {
            if (bits != null)
            {
                if (bits[0].ToString().Equals("1") && bits.Length < 4)
                    return ".";
                else if (bits[0].ToString().Equals("1") && bits.Length > 3)
                    return "-";
                else if (bits[0].ToString().Equals("0") && bits.Length < 4)
                    return "";
                else if (bits[0].ToString().Equals("0") && bits.Length > 3 && bits.Length < 9)
                    return " ";
                else if (bits[0].ToString().Equals("0") && bits.Length > 8)
                    return "   ";
                else
                    return "";
            }

            return "";
        }

        public static string decodeBitsAdvanced(string bits)
        {
            if (bits != null)
            {
                List<string> listCodeBits = ListBit(bits);
                string morseBits = "";

                for (int i = listCodeBits.Count - 1; i >= 0; i--)

                    morseBits += LogicMorseBit(listCodeBits[i]);
                return morseBits;
            }
            return "";
        }

    }
}
