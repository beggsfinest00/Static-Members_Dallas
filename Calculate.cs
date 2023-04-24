using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Members_Dallas
{
    static class Calculate
    {
        //initilize and set the valurable to 0
        public static float result = 0.0f;

        //set the valurable to 0
        static Calculate() 
        {
            result = 0.0f;
        }

        //INTEGERS that add, subtract, multipliy, and divide two numbers and ruturns the answer.
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Mult(int x, int y)
        {
            return x * y;
        }

        public static int Div(int x, int y)
        {
            return x / y;
        }


        //FLOATERS that add, subtract, multipliy, and divide two numbers and ruturns the answer.
        public static float Add(float x, float y)
        {
            return x + y;
        }

        public static float Sub(float x, float y)
        {
            return x - y;
        }

        public static float Mult(float x, float y)
        {
            return x * y;
        }

        public static float Div(float x, float y)
        {
            return x / y;
        }
    }
}
