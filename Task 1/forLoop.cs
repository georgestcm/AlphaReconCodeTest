using System;

namespace ForLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      //The answers to each question will be numbered from 1 to 7

      //1:Find the frequency of a character in a string
            char ch;
            Console.Write("Enter a string:");
            string str = Console.ReadLine();
            for (ch = 'A'; ch <= 'Z'; ch++)
            {
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (ch==str[i] || str[i] == (ch + 32))
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine("Char {0} having Freq of {1}", ch, count);
                }
            }
            Console.Read();








            //2:Find the number of vowels, consonants, digits and white spaces
            char[] sentence = new char[100];
         int a;
        int i, vowels = 0, consonants = 0, special = 0, n;
        int digits = 0;
        int countSpaces;
        Console.WriteLine("Enter the Length of the sentence  \n");
        n = int.Parse(Console.ReadLine());
        for (i = 0; i < n; i++)
        {
            sentence[i] = Convert.ToChar(Console.Read());
        }
        for (i = 0; sentence[i] != '\0'; i++)
        {
            if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] ==
            'i' || sentence[i] == 'o' || sentence[i] == 'u') ||
            (sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] ==
            'I' || sentence[i] == 'O' || sentence[i] == 'U'))
            {
                vowels = vowels + 1;
            }
            else
            {
                consonants = consonants + 1;
            }
            if (sentence[i] == 't' || sentence[i] == '\0' || sentence[i] == ' ')
            {
                special = special + 1;
            }
            if(int.TryParse(sentence[i], out a)){
              digits = digits +1;
            }
        }
        countSpaces = sentence.Count(Char.IsWhiteSpace)
          console.WriteLine("There are"+" "+vowels+" "+"vowels and "+" "+consonants+" "+"consonants"+" "+"and"+" "+digits+" "+"digits"+" "+"with"+" "+countSpaces+" "+"white spaces.")



      //3:Find the length of a string
      string text= "georges tchianga ";
      int textLength=0;
       for (int i = 0; i < text.Length; i++)
       {
           textLength++;
       }


//4. Concatenate multiple strings List
List<string> colors = new List<string>();
colors.Add("Red");
colors.Add("Blue");
colors.Add("Green");
List<string> names = new List<string>();
colors.Add("john");
colors.Add("devon");
colors.Add("georges");
for (int i = 0; i < names.length; i++)
{
  colors.add(names[i])
}


//5. Remove all characters in a string except alphabets
string s = "fdjgFDFGS%^&9"
for (int i = 0; i < s.Length; i++)
       {

           // Finding the character whose
           // ASCII value fall under this
           // range
           if (s[i] < 'A' || s[i] > 'Z' &&
                   s[i] < 'a' || s[i] > 'z')
           {

               // erase function to erase
               // the character
               s = s.Remove(i,1);
               i--;
           }
       }

       Console.Write(s);






//6. Sort elements in the lexicographical order (Asc/Desc)
string[] arr = new string[] {
    "African",
    "Asian",
    "American",
 };
 var sort = from a in arr
 orderby a
 select a;

 for(int i =0; i < sort.length; i++) {
    Console.WriteLine(sort[1]);
 }



//7. Reverse a string

Console.WriteLine("Enter the string to reverse :");
            string text = Console.ReadLine();

            char[] tArray = text.ToCharArray();
            string nameReverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                nameReverse += tArray[i];
            }
            Console.WriteLine(nameReverse);
    }
  }
}
