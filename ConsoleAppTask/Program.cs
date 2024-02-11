////////long fact1 = 1;
////////int num1 = 10;  //Hansi Vahidin Factoriali Zay metod
////////if (fact1) == 0;
////////{
////////    Console.WriteLine(i);
////////}
//////int num1 = 10;
//////int factorial = CalculateFactorial 


//using System;
//using System.Numerics;
//int u = 0;
//int i = 1;
//for (int ) ;
//{

//}
//Console.WriteLine(i);


//////////////////////////////task 1

//using System.Numerics; // sayinda problem yaranirdi deye bunu istifade ettim "long" ile alinmadi

//BigInteger fact = 1;
//int nums1 = 10000;

//for (int i = 1; i <= nums1; i++)

//{
//    fact *= i;
//}

//Console.WriteLine(fact);


///////////////////////////////////////////////////////////task2
//using System.Numerics;

//        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 16, 18, 20 };

//        BigInteger result = 1; //int,long result = 1; az olanda isleyir 

//for (int i = 0; i < arr1.Length; i++)
//        {
//            int number = arr1[i];
//            if (number % 2 == 0)

//            {
//                result *= number;
//            }

//          }
//            result *= result;     
//        Console.WriteLine(result);

///////////////////////////////////////////////////////////////task3

////test
////int nums1 = 13;
////if (nums1 % 2 == 0)
////{
////    Console.WriteLine("True");
////}
////else
////{
////    Console.WriteLine("False");
////}
///


int n = 6;
bool pow2 = false;
int power = 1;
while (power < n)
{ 
power *= 2;
}
if (power == n)
{ 
pow2 = true;
}
if (pow2)
{
    Console.WriteLine("2-nin quvettidir");
}
else
{
    Console.WriteLine("quvveti deil");
}