/*

            C# Samples
            ==========

	1. 	Declare an Array of Integers
	2.	Declare an Array of Strings
	3.	Declare an Array of Characters
	
	4.	Declare a String variable
	
	5.	Declare a List of Integers
	6.	Declare a List of Strings
	
	7.	Convert an Array of Integers into List of Integers
	
	8.	Read each character of a string
	
	9.	Convert a string into characters
	
	10.	Declare a Dictionary or HashTable	
	11.	Various operations of a Dictionary or HashTable
	
	12.	Reverse a String
	13.	Reverse a Number
	14.	Palindrome - string and number
	15.	Count number of repeated chars of a string/number
	16.	Prime number
	17.	Fibnocci series
	18.	Strong number
	19.	Found the duplicate number or string from a input.
	20.	Display character with repeatation of a string
	 
 
*/




using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Try1Application
{
    class MyClass
    {

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.Task1_DeclareAnArrayOfIntegers();
            myClass.Task2_DeclareAnArrayOfStrings();
            myClass.Task3_DeclareAnArrayOfCharacters();
            myClass.Task4_DeclareStringVariable();
            myClass.Task5_DeclareListOfIntegers();
            myClass.Task6_DeclareListOfStrings();
            myClass.Task7_ConvertAnArrayOfIntegersIntoListOfIntegers();
            myClass.Task8_ReadEachCharacterOfString();
            myClass.Task9_ConvertStringIntoCharacters();
            myClass.Task10_DeclareDictionaryOrHashTable();
            myClass.Task12_ReverseString();
            myClass.Task13_ReverseNumber();
            myClass.Task14_PalindromeStringAndNnumber();
            myClass.Task16_CountNumberOfRepeatedCharactersOfStringOrNumber();

            myClass.Task17_PrimeNumber();
            myClass.Task18_FibnocciSeries();
            myClass.Task19_StrongNumber();
            myClass.Task20_DuplicateNumber();
            myClass.Task21_CountNumberOfRepeatedCharactersOfStringOrNumber();
            myClass.Task22_LastOccuranceOfCharacter();


        }



        void Task1_DeclareAnArrayOfIntegers()
        {
            int[] arr = new int[5];

            arr[0] = 100;
            arr[1] = 200;
            arr[2] = 300;
            arr[3] = 400;
            arr[4] = 500;

            Console.WriteLine("VALUES");

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(arr[4]);

            Console.Read();
        }

        void Task2_DeclareAnArrayOfStrings()
        {
            string[] str = new string[5];

            str[0] = "FirstValue";
            str[1] = "SecondValue";
            str[2] = "ThirdValue";
            str[3] = "FourthValue";
            str[4] = "FifthValue";

            Console.WriteLine("VALUES");

            foreach (string st in str)
            {
                Console.WriteLine(st);
            }
        }

        void Task3_DeclareAnArrayOfCharacters()
        {
            char[] chrs = new char[10];

            chrs[0] = 'a';
            chrs[1] = 'b';
            chrs[2] = 'c';
            chrs[3] = 'd';

            Console.WriteLine("VALUES");

            foreach (char c in chrs)
            {
                Console.Write(c);
            }
        }

        void Task4_DeclareStringVariable()
        {
            string str;

            str = "Hello";

            Console.WriteLine(str);

        }

        void Task5_DeclareListOfIntegers()
        {
            List<int> lstInts = new List<int>();

            lstInts.Add(1);
            lstInts.Add(2);
            lstInts.Add(3);
            lstInts.Add(4);
            lstInts.Add(5);

            Console.WriteLine("VALUES");

            foreach (int i in lstInts)
            {
                Console.WriteLine(i);
            }
        }

        void Task6_DeclareListOfStrings()
        {
            List<string> lstStrs = new List<string>();

            lstStrs.Add("One");
            lstStrs.Add("Two");
            lstStrs.Add("Three");
            lstStrs.Add("Four");

            Console.WriteLine("VALUES");

            foreach (string str in lstStrs)
            {
                Console.WriteLine($"Value:{str}");
            }
        }

        void Task7_ConvertAnArrayOfIntegersIntoListOfIntegers()
        {
            int[] arrNos = new int[5];
            int noStartsAt = 50;

            for (int i = 0; i < arrNos.Length; i++)
            {
                arrNos[i] = noStartsAt;
                noStartsAt++;
            }

            Console.WriteLine("VALUES FROM ARRAY");

            foreach (int i in arrNos)
            {
                Console.WriteLine($"No:{i}");
            }

            List<int> lstNos = arrNos.ToList();

            Console.WriteLine("VALUES FROM LIST");

            foreach (int i in lstNos)
            {
                Console.WriteLine($"No:{i}");
            }


        }


        void Task8_ReadEachCharacterOfString()
        {
            string str = "Hello";

            foreach (char c in str)
            {
                Console.WriteLine($"Character:{c}");
            }
        }


        void Task9_ConvertStringIntoCharacters()
        {
            string str = "Hello";

            char[] arrChar = str.ToCharArray();

            foreach (char c in arrChar)
            {
                Console.WriteLine($"Character: {c}");
            }
        }

        // Task 11: Various operations of a Dictionary or HashTable : Same as below
        void Task10_DeclareDictionaryOrHashTable()
        {
            Dictionary<string, int> dictOne = new Dictionary<string, int>();

            dictOne.Add("Ten", 1);
            dictOne.Add("Twenty", 2);
            dictOne.Add("Thirty", 3);
            dictOne.Add("Fourty", 4);
            dictOne.Add("Fifty", 5);

            Console.WriteLine($"Total Values in the Dictionary:{dictOne.Count}");

            Console.WriteLine("VALUES FROM DICTIONARY");

            foreach (string k in dictOne.Keys)
            {
                Console.WriteLine($"Key: {k}");
            }

            foreach (int i in dictOne.Values)
            {
                Console.WriteLine($"Value:{i}");
            }

            Console.WriteLine("KEY-VALUE PAIRS");

            foreach (string s in dictOne.Keys)
            {
                Console.WriteLine($"Key: {s} Value:{dictOne.GetValueOrDefault(s)}");

            }

        }

        void Task12_ReverseString()
        {
            // Method-1
            /*
            string str = "English";

            for(int i = str.Length-1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            */

            // Method-2
            string str = "English";
            string revStr = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr += str[i];
            }

            Console.WriteLine($"STRING: {str}");
            Console.WriteLine($"REVERSE: {revStr}");


        }

        private void Task13_ReverseNumber()
        {
            int no = 123456;
            string revNo = "";

            for (int i = no.ToString().Length; i > 0; i--)
            {
                revNo += i.ToString();
            }
            Console.WriteLine($"Number:{no}");
            Console.WriteLine($"REVERSE:{revNo}");

        }

        private void Task14_PalindromeStringAndNnumber()
        {
            string str = "malaYalaM";
            string revStr = "";

            str = str.ToLower();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr += str[i];
            }

            if (str.Equals(revStr))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");


            //if (str == revStr)
            //{
            //    Console.WriteLine("P");
            //}
            //else
            //{
            //    Console.WriteLine("Not P");
            //}

            // Palindrome Number Code 

            //int no = 12321;
            //string revNo = "";

            //for(int i = no.ToString().Length-1; i>= 0; i--)
            //{
            //    revNo+= no.ToString()[i];
            //}

            //if(no == int.Parse(revNo))
            //{
            //    Console.WriteLine("P");
            //}
            //else
            //{
            //    Console.WriteLine("Not P");
            //}




        }

        private void Task15_CountNumberOfRepeatedWordsOfStringOrNumber()
        {
            string Word;
            Console.WriteLine("Enter the word!..");
            Word = Console.ReadLine();   // Read the Input string from User at Run Time  
            var Value = Word.Split(' ');  // Split the string using 'Space' and stored it an var variable  
            Dictionary<string, int> RepeatedWordCount = new Dictionary<string, int>();
            for (int i = 0; i < Value.Length; i++) //loop the splited string  
            {
                if (RepeatedWordCount.ContainsKey(Value[i])) // Check if word already exist in dictionary update the count  
                {
                    int value = RepeatedWordCount[Value[i]];
                    RepeatedWordCount[Value[i]] = value + 1;
                }
                else
                {
                    RepeatedWordCount.Add(Value[i], 1);  // if a string is repeated and not added in dictionary , here we are adding   
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Repeated words and counts");
            foreach (KeyValuePair<string, int> kvp in RepeatedWordCount)
            {
                Console.WriteLine(kvp.Key + " Counts are " + kvp.Value);  // Print the Repeated word and its count  
            }
            Console.ReadKey();

        }

        private void Task16_CountNumberOfRepeatedCharactersOfStringOrNumber()
        {
            string str = " aabbcc";

            char[] chars = str.ToCharArray();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 1; i < chars.Length; i++)
            {
                if (dict.ContainsKey(chars[i].ToString())) // Check if character already exist in dictionary update the count  
                {
                    dict[chars[i].ToString()]++;
                    //int value = dict[chars[i].ToString()];
                    //dict[chars[i].ToString()] = value + 1;
                }
                else
                {
                    dict.Add(chars[i].ToString(), 1);  // if a string is repeated and not added in dictionary , here we are adding   
                }
            }

            Console.WriteLine("Repeated words and counts");

            for (int i = 0; i < dict.Count; i++)
            {
                Console.Write(dict.Keys.ElementAt(i));
                Console.Write(dict.Values.ElementAt(i));
            }

            //foreach (KeyValuePair<string, int> kvp in dict)
            //{
            //    //Console.WriteLine(kvp.Key + " Counts are " + kvp.Value);  
            //    Console.Write(kvp.Key + kvp.Value);
            //}

            Console.WriteLine();

            foreach (string s in dict.Keys)
                Console.WriteLine(s);

            Console.ReadKey();

        }


        private void Task17_PrimeNumber()
        {           
            int no = 14;
            bool status = false;

            for(int i=2; i< no; i++)
            {
                if (no % i == 0)
                { 
                    status = true;
                    break;
                }
                else
                    status = false;
            }

            if (status == false)
                Console.WriteLine("PRIME");
            else
                Console.WriteLine("Not Prime");
            
        }


        private void Task18_FibnocciSeries()
        {          
            int number = 5;

            int firstNum = 0;
            int secondNum=1;
            int thirdNum;

            Console.Write($"{firstNum} {secondNum}");

           for(int i=1; i< number; i++)
            {
                thirdNum = firstNum + secondNum;
                Console.Write($" {thirdNum}");

                firstNum = secondNum;
                secondNum = thirdNum;
            }
        }


        private void Task19_StrongNumber()
        {            


        }


        private void Task20_DuplicateNumber()
        {
            int no = 1234536; // 3
            char[] chars = no.ToString().ToCharArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < no.ToString().Length; i++)
            {
                if (dict.ContainsKey(chars[i].ToString()))
                {
                    dict[chars[i].ToString()]++;
                }
                else
                {
                    dict.Add(chars[i].ToString(), 1);
                }
            }

            Console.WriteLine("RESULT");

            for (int i = 0; i < dict.Count; i++)
            {
                Console.Write(dict.Keys.ElementAt(i).ToString());
                Console.Write($" : Times: {dict.Values.ElementAt(i).ToString()}");
                Console.WriteLine();
            }


        }


        private void Task21_CountNumberOfRepeatedCharactersOfStringOrNumber()
        {
            string str = "aabbcc";
            char[] chars = str.ToCharArray() ;
            Dictionary<string,int> dict = new Dictionary<string, int>();

            for (int i = 0; i< chars.Length; i++)
            {
                if (dict.ContainsKey(chars[i].ToString()))
                {
                    dict[chars[i].ToString()]++;
                }
                else
                {
                    dict.Add(chars[i].ToString(), 1);
                }
            }

            Console.WriteLine("Counts");

            for(int i=0;i<dict.Count;i++)
            {
                Console.Write($"{dict.Keys.ElementAt(i)}");
                Console.Write($"{dict.Values.ElementAt(i)}");
            }
            

        }

        private void Task22_LastOccuranceOfCharacter()
        {
            string data = "Hello World";
            int lastIndex = data.LastIndexOf('o');
            Console.WriteLine("The last index is: " + lastIndex);
        }
    
       
       
    
    }
}

