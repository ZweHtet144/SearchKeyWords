using System;
using System.Text.RegularExpressions;

namespace SearchKeywordsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = @"Even though apple is not an excellent source of dietary fiber (it ranks as a &quot;good&quot; source in our
                                WHFoods Rating System), the fiber found in apple may combine with other apple nutrients to
                                provide you with the kind of health benefits you would ordinarily only associate with much higher
                                amounts of dietary fiber. These health benefits are particularly important in prevention of heart
                                disease through healthy regulation of blood fat levels. Recent research has shown that intake of
                                apples in their whole food form can significantly lower many of our blood fats.";
            
            var searchString = "apple";
            var pattern = @"\b" + searchString + @"\b";
            Regex rgx = new Regex(pattern);

            MatchCollection matches = rgx.Matches(paragraph);
            string[] keywords = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                keywords[i] = matches[i].Value;
                Console.WriteLine(keywords[i]);
            }
        }
    }
}
