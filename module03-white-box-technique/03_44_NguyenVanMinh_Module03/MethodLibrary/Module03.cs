using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLibrary
{
    public class Module03
    {

        public static int Bai03(int A, int B, int C, out double Mean)
        {
            Mean = (A + B + C) / 3.0;
            int Maximum;
            if (A > B)
                if (A > C)
                    Maximum = A;
                else
                    Maximum = B;
            else
            if (B > C)
                Maximum = B;
            else
                Maximum = C;
            return Maximum;

        }

        public static int Bai04(int a, int b, int c)
        {
            int max = 0;
            if (a > 0 && b > 0 && c > 0)
                max = a;
            else
                return 0;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            return max;
        }

        public static String Bai05(int a, int b, int c)
        {
            int match = 0;
            if (a == b)
                match = match + 1;
            if (a == c)
                match = match + 2;
            if (b == c)
                match = match + 3;
            if (match == 0)
                if ((a + b) <= c)
                    return ("Not a Triangle");
                else if ((b + c) <= a)
                    return ("Not a Triangle");
                else if ((a + c) <= b)
                    return ("Not a Triangle");
                else
                    return ("Triangle is Scalene");
            else if (match == 1)
                if ((a + c) <= b)
                    return ("Not a Triangle");
                else
                    return ("Triangle is Isosceles");
            else if (match == 2)
                if ((a + c) <= b)
                    return ("Not a Triangle");
                else
                    return ("Triangle is Isosceles");
            else if (match == 3)
                if ((b + c) <= a)
                    return ("Not a Triangle");
                else
                    return ("Triangle is Isosceles");
            else
                return ("Triangle is Equilateral");
        }

        public static double Bai06(double Sum, double Count)
        {
            if (Count == 1)
                return Sum;
            else if (Count > 0)
                return Sum / Count;
            else
                return 0;
        }

        public static byte Bai07(ushort year, byte month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (year % 400 == 0)
                    {
                        return 29;
                    }
                    else if (year % 100 == 0)
                    {
                        return 28;
                    }
                    else if (year % 4 == 0)
                    {
                        return 29;
                    }
                    else return 28;
                default:
                    return 0;
            }

        }

        public static Boolean Bai08(float a, float b, float c, out float x1, out float x2)
        {
            if (a == 0)
            {
                x1 = -c / b;
                x2 = float.NaN;
                return true;
            }
            double delta = (b * b) - (4 * a * c);
            if (delta < 0)
            {
                x1 = x2 = float.NaN;
                return false;
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                x2 = -b / (2 * a);
                return true;
            }
            else
            {

                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                return true;
            }
        }

        public static String Bai09(float a, float b, float x)
        {
            if (a > b)
                return "Error";
            else if (x < a)
                return "" + a;
            else if (x > b)
                return "" + b;
            else return "" + x;
        }

        public static Boolean Bai10(float a, float b, float c)
        {
            if (a < 0 || b < 0 || c < 0)
                return false;
            else if ((a + b) > c)
            {
                if (a + c > b)
                {
                    if (b + c > a)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }

        public static Boolean Bai11(out float x, out float y, float w, float h, float ww, float wh)
        {
            if (w <= 0 || h <= 0 || wh <= 0 || ww <= 0)
            {
                x = float.NaN; y = float.NaN;
                return false;
            }
            else
            {
                if (w > ww) x = 0;
                else x = (ww - w) / 2;
                if (h > wh)
                {
                    y = 0;
                    return true;
                }
                else
                {
                    y = (wh - h) / 2;
                    return true;
                }
            }
        }

        public static float Bai12(float total, float p1, float p2, float p3)
        {
            if (p1 < 0 || p2 < 0 || p3 < 0 || total < 0)
            {
                throw new Exception();
            }
            else if (total <= 100)
            {
                return total * p1;
            }
            else if (total <= 150)
            {
                return 100 * p1 + (total - 100) * p2;
            }
            else
                return 100 * p1 + 50 * p2 + (total - 150) * p3;
        }

        public static Boolean Bai13(float x1, float y1, float x2, float y2, float x, float y)
        {
            if (x1 > x2 || y1 > y2)
            {
                throw new Exception("Gia tri x1,x2,y1,y2 khong hop le");
            }
            else if (x < x1 || x > x2)
                return false;
            else if (y < y1 || y > y2)
                return false;
            else
                return true;
        }

        public static Boolean Bai14(float w, float h, out float s, out float x, out float y)
        {
            if (w < 0 || h < 0)
            {
                throw new Exception();
            }
            else
            {
                if (w > h)
                {

                    x = (w - h) / 2;
                    y = 0;
                    s = h;
                    return true;
                }
                else
                {
                    x = 0;
                    y = (h - w) / 2;
                    s = w;
                    return true;
                }
            }
        }

        public static Boolean Bai15(int year)
        {
            if (year > 10000 || year < 1000)
                return false;
            else
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else if (year % 4 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static Boolean Bai16(string pass)
        {
            if (pass.Length >= 6)
            {
                if (pass.Length <= 10)
                {
                    foreach (char c in pass)
                    {
                        if (char.IsDigit(c))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                return false;
            }
            return false;
        }

        public static Boolean Bai17(ushort year, byte month, byte day)
        {
            if (month >= 1 && month <= 12)
            {
                if (day >= 1)
                {
                    if (day <= Bai07(year, month))
                    {
                        return true;
                    }
                    return false;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public static Boolean Bai18(String email)
        {
            if (email.Contains("."))
            {
                if (email.Contains(".."))
                {
                    return false;
                }
                else
                {
                    if (email.Contains("@"))
                    {
                        if (email.Contains("@.") || email.Contains(".@") || email.Contains("@@"))
                        {
                            return false;
                        }
                        else return true;
                    }
                    else { return false; }
                }
            }
            else { return false; }
        }

        public static sbyte Bai19(short height, int weight)
        {
            if (height < 0)
            {
                return -1;
            }
            else
            {
                if (weight < 0)
                {
                    return -1;
                }
                else
                {
                    float scale = weight * 10000 / (height * height);
                    if (scale < 18)
                    {
                        return 2;
                    }
                    else if (scale > 20)
                    {
                        return 1;
                    }
                    else return 0;
                }
            }
        }

        const int MAX_INT = 32767;
        static string str = "Statement Coverage";
        public static int Bai20(char tmp)
        {
            int pos = MAX_INT;
            int i = 0;
            while (i < str.Length)
            {
                if (str[i] == tmp)
                {
                    pos = i;
                    break;
                }
                i++;
            }
            return pos;
        }

        public static long Bai21(string hexaString)
        {
            int c;
            long hexnum, nhex; hexnum = nhex = 0; int i = 0; while (i < hexaString.Length)
            {
                c = hexaString[i++];
                switch (c)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        /* Convert a decimal digit */
                        nhex++; hexnum *= 0x10; hexnum += (c - '0');
                        break;
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                        /* lower case hex digit */
                        nhex++; hexnum *= 0x10; hexnum += (c - 'a' + 0xa); break;
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'E':
                    case 'F':
                        /*upper case hex digit */
                        nhex++; hexnum *= 0x10; hexnum += (c - 'A' + 0xA); break;
                    default:
                        /* non-hex characters */
                        break;
                }
            }
            return hexnum;
        }
    }
}
