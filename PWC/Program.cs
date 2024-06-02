
//1° Exercício 

 string texto1 = "Hello, World OpenAI is amazing";
 string[] palavras = texto1.Split(' ');
 string textoInvertido = "";

 for (int i = palavras.Length - 1; i >= 0; i--)
 {
     textoInvertido += palavras[i];

    if (i != 0)
   {
       textoInvertido += " ";
   }
 }


//2° exercício 


string texto2 = "Hello, World!";
string novoTexto = "";

for(int i= 0; i <= texto2.Length - 1; i++)
{
if(novoTexto.IndexOf(texto2[i]) == -1)
{
    novoTexto += texto2[i];
}
}

Console.WriteLine(novoTexto);



//3° exercício
{
    static void Main(string[] args)
    {
        string word = "arara";
        List<string> palindromicSubstrings = GeneratePalindromicSubstrings(word);
        
        Console.WriteLine("Substrings palindrômicas:");
        foreach (string substring in palindromicSubstrings)
        {
            Console.WriteLine(substring);
        }
    }
    
    static List<string> GeneratePalindromicSubstrings(string word)
    {
        List<string> palindromicSubstrings = new List<string>();
        
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i + 1; j <= word.Length; j++)
            {
                string substring = word.Substring(i, j - i);
                if (IsPalindrome(substring))
                {
                    palindromicSubstrings.Add(substring);
                }
            }
        }
        
        return palindromicSubstrings;
    }
    
    static bool IsPalindrome(string word)
    {
        char[] characters = word.ToCharArray();
        Array.Reverse(characters);
        string reversedWord = new string(characters);
        
        return word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase);
    }
}






//4° Exercício
var texto4 = "hello, how are you ? i`m fine, thank you.";
var upper = char.ToUpper(texto4[0]) + texto4.Substring(1);

Console.WriteLine(texto4);

//5 exercício

{
    static void Main(string[] args)
    {
        string word = "racecar";
        bool isPalindrome = IsPalindrome(word);
        
        if (isPalindrome)
        {
            Console.WriteLine($"{word} é um palíndromo.");
        }
        else
        {
            Console.WriteLine($"{word} não é um palíndromo.");
        }
    }
    
    static bool IsPalindrome(string word)
    {
        char[] characters = word.ToCharArray();
        Array.Reverse(characters);
        string reversedWord = new string(characters);
        
        return word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase);
    }
}
     

