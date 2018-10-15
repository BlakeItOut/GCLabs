using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Exercises obj = new Exercises();
                Console.Write("What exercise # would you like to go to? ");
                int response = int.Parse(Console.ReadLine());
                if(response > 0)
                {
                    MethodInfo method = obj.GetType().GetMethod($"Exercise{response}", BindingFlags.Public | BindingFlags.Instance);
                    method.Invoke(obj, null);
                }
                else
                {
                    MethodInfo method = obj.GetType().GetMethod($"ExerciseB{response*-1}", BindingFlags.Public | BindingFlags.Instance);
                    method.Invoke(obj, null);
                }
                /*
                switch (response)
                {
                    case -22:
                        ExerciseB22();
                        break;
                    case -21:
                        ExerciseB21();
                        break;
                    case -20:
                        ExerciseB20();
                        break;
                    case -19:
                        ExerciseB19();
                        break;
                    case -18:
                        ExerciseB18();
                        break;
                    case -17:
                        ExerciseB17();
                        break;
                    case -16:
                        ExerciseB16();
                        break;
                    case -15:
                        ExerciseB15();
                        break;
                    case -14:
                        ExerciseB14();
                        break;
                    case -13:
                        ExerciseB13();
                        break;
                    case -12:
                        ExerciseB12();
                        break;
                    case -11:
                        ExerciseB11();
                        break;
                    case -10:
                        ExerciseB10();
                        break;
                    case -9:
                        ExerciseB9();
                        break;
                    case -8:
                        ExerciseB8();
                        break;
                    case -7:
                        ExerciseB7();
                        break;
                    case -6:
                        ExerciseB6();
                        break;
                    case -5:
                        ExerciseB5();
                        break;
                    case -4:
                        ExerciseB4();
                        break;
                    case -3:
                        ExerciseB3();
                        break;
                    case -2:
                        ExerciseB2();
                        break;
                    case -1:
                        ExerciseB1();
                        break;
                    case 0:
                        Exercise0();
                        break;
                    case 1:
                        Exercise1();
                        break;
                    case 2:
                        Exercise2();
                        break;
                    case 3:
                        Exercise3();
                        break;
                    case 4:
                        Exercise4();
                        break;
                    case 5:
                        Exercise5();
                        break;
                    case 6:
                        Exercise6();
                        break;
                    case 7:
                        Exercise7();
                        break;
                    case 8:
                        Exercise8();
                        break;
                    case 9:
                        Exercise9();
                        break;
                    case 10:
                        Exercise10();
                        break;
                    case 11:
                        Exercise11();
                        break;
                    case 12:
                        Exercise12();
                        break;
                    case 13:
                        Exercise13();
                        break;
                    case 14:
                        Exercise14();
                        break;
                    case 15:
                        Exercise15();
                        break;
                    case 16:
                        Exercise16();
                        break;
                    case 17:
                        Exercise17();
                        break;
                    case 18:
                        Exercise18();
                        break;
                    case 19:
                        Exercise19();
                        break;
                    case 20:
                        Exercise20();
                        break;
                    case 21:
                        Exercise21();
                        break;
                    case 22:
                        Exercise22();
                        break;
                    case 23:
                        Exercise23();
                        break;
                    case 24:
                        Exercise24();
                        break;
                    case 25:
                        Exercise25();
                        break;
                    case 26:
                        Exercise26();
                        break;
                    case 27:
                        Exercise27();
                        break;
                    case 28:
                        Exercise28();
                        break;
                    case 29:
                        Exercise29();
                        break;
                    case 30:
                        Exercise30();
                        break;
                    case 31:
                        Exercise31();
                        break;
                    case 32:
                        Exercise32();
                        break;
                    case 33:
                        Exercise33();
                        break;
                    case 34:
                        Exercise34();
                        break;
                    case 35:
                        Exercise35();
                        break;
                    case 36:
                        Exercise36();
                        break;
                    case 37:
                        Exercise37();
                        break;
                    case 38:
                        Exercise38();
                        break;
                    case 39:
                        Exercise39();
                        break;
                    case 40:
                        Exercise40();
                        break;
                    case 41:
                        Exercise41();
                        break;
                    case 42:
                        Exercise42();
                        break;
                    case 43:
                        Exercise43();
                        break;
                    case 44:
                        Exercise44();
                        break;
                    case 45:
                        Exercise45();
                        break;
                    case 46:
                        Exercise46();
                        break;
                    case 47:
                        Exercise47();
                        break;
                    case 48:
                        Exercise48();
                        break;
                    case 49:
                        Exercise49();
                        break;
                    case 50:
                        Exercise50();
                        break;
                    case 51:
                        Exercise51();
                        break;
                    case 52:
                        Exercise52();
                        break;
                    case 53:
                        Exercise53();
                        break;
                    case 54:
                        Exercise54();
                        break;
                    case 55:
                        Exercise55();
                        break;
                    case 56:
                        Exercise56();
                        break;
                    case 57:
                        Exercise57();
                        break;
                    case 58:
                        Exercise58();
                        break;
                    case 59:
                        Exercise59();
                        break;
                    case 60:
                        Exercise60();
                        break;
                    case 61:
                        Exercise61();
                        break;
                    case 62:
                        Exercise62();
                        break;
                    case 63:
                        Exercise63();
                        break;
                    case 64:
                        Exercise64();
                        break;
                    case 65:
                        Exercise65();
                        break;
                    case 66:
                        Exercise66();
                        break;
                    case 67:
                        Exercise67();
                        break;
                    case 68:
                        Exercise68();
                        break;
                    case 69:
                        Exercise69();
                        break;
                    case 70:
                        Exercise70();
                        break;
                    case 71:
                        Exercise71();
                        break;
                    case 72:
                        Exercise72();
                        break;
                    case 73:
                        Exercise73();
                        break;
                    case 74:
                        Exercise74();
                        break;
                    case 75:
                        Exercise75();
                        break;
                    case 76:
                        Exercise76();
                        break;
                    case 77:
                        Exercise77();
                        break;
                    case 78:
                        Exercise78();
                        break;
                    default:
                        break;
                }
                */
            }
        }
    }

    public class Exercises
    {
        public Exercises()
        {

        }
        public void ExerciseB22()
        {

        }
        public void ExerciseB21()
        {

        }
        public void ExerciseB20()
        {

        }
        public void ExerciseB19()
        {

        }
        public void ExerciseB18()
        {

        }
        public void ExerciseB17()
        {

        }
        public void ExerciseB16()
        {

        }
        public void ExerciseB15()
        {

        }
        public void ExerciseB14()
        {

        }
        public void ExerciseB13()
        {

        }
        public void ExerciseB12()
        {

        }
        public void ExerciseB11()
        {

        }
        public void ExerciseB10()
        {

        }
        public void ExerciseB9()
        {

        }
        public void ExerciseB8()
        {

        }
        public void ExerciseB7()
        {

        }
        public void ExerciseB6()
        {

        }
        public void ExerciseB5()
        {

        }
        public void ExerciseB4()
        {

        }
        public void ExerciseB3()
        {

        }
        public void ExerciseB2()
        {

        }
        public void ExerciseB1()
        {

        }
        public void Exercise0()
        {

        }
        public void Exercise1()
        {
            Console.WriteLine("It works!");
        }
        public void Exercise2()
        {
            Console.WriteLine("It really does!");
        }
        public void Exercise3()
        {
            Console.WriteLine("It really really does!");
        }
        public void Exercise4()
        {

        }
        public void Exercise5()
        {

        }
        public void Exercise6()
        {

        }
        public void Exercise7()
        {

        }
        public void Exercise8()
        {

        }
        public void Exercise9()
        {

        }
        public void Exercise10()
        {

        }
        public void Exercise11()
        {

        }
        public void Exercise12()
        {

        }
        public void Exercise13()
        {

        }
        public void Exercise14()
        {

        }
        public void Exercise15()
        {

        }
        public void Exercise16()
        {

        }
        public void Exercise17()
        {

        }
        public void Exercise18()
        {

        }
        public void Exercise19()
        {

        }
        public void Exercise20()
        {

        }
        public void Exercise21()
        {

        }
        public void Exercise22()
        {

        }
        public void Exercise23()
        {

        }
        public void Exercise24()
        {

        }
        public void Exercise25()
        {

        }
        public void Exercise26()
        {

        }
        public void Exercise27()
        {

        }
        public void Exercise28()
        {

        }
        public void Exercise29()
        {

        }
        public void Exercise30()
        {

        }
        public void Exercise31()
        {

        }
        public void Exercise32()
        {

        }
        public void Exercise33()
        {

        }
        public void Exercise34()
        {

        }
        public void Exercise35()
        {

        }
        public void Exercise36()
        {

        }
        public void Exercise37()
        {

        }
        public void Exercise38()
        {

        }
        public void Exercise39()
        {

        }
        public void Exercise40()
        {

        }
        public void Exercise41()
        {

        }
        public void Exercise42()
        {

        }
        public void Exercise43()
        {

        }
        public void Exercise44()
        {

        }
        public void Exercise45()
        {

        }
        public void Exercise46()
        {

        }
        public void Exercise47()
        {

        }
        public void Exercise48()
        {

        }
        public void Exercise49()
        {

        }
        public void Exercise50()
        {

        }
        public void Exercise51()
        {

        }
        public void Exercise52()
        {

        }
        public void Exercise53()
        {

        }
        public void Exercise54()
        {

        }
        public void Exercise55()
        {

        }
        public void Exercise56()
        {

        }
        public void Exercise57()
        {

        }
        public void Exercise58()
        {

        }
        public void Exercise59()
        {

        }
        public void Exercise60()
        {

        }
        public void Exercise61()
        {

        }
        public void Exercise62()
        {

        }
        public void Exercise63()
        {

        }
        public void Exercise64()
        {

        }
        public void Exercise65()
        {

        }
        public void Exercise66()
        {

        }
        public void Exercise67()
        {

        }
        public void Exercise68()
        {

        }
        public void Exercise69()
        {

        }
        public void Exercise70()
        {

        }
        public void Exercise71()
        {

        }
        public void Exercise72()
        {

        }
        public void Exercise73()
        {

        }
        public void Exercise74()
        {

        }
        public void Exercise75()
        {

        }
        public void Exercise76()
        {

        }
        public void Exercise77()
        {

        }
        public void Exercise78()
        {

        }
    }


}
