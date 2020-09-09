using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
}
        string pattern = @"[a-z]{2}[A-Z]{2}";
        string pattern = @"afgkk24679gg2XVFcatcat9970b02dogMaryxxxxbbbb22FHDFISHMOTHERfasklasjfjasdfjzxcvxcE
YERTR345262372546vbcvb0000000carTT2356236623732623462366johnxcxcvC#00002499xbvvcfgooglecvcvxzvdfgsd
jiiruewortuiwerioptunxn990348590234523907854034sdnskfshwateririweotowyuwituwreutpwetuwertueryuwertwerutpweu
rtpuweptnvmxcvnnxcxcxvb";

        foreach (Match m in Regex.Matches(input, pattern))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
      }
    }
