using System.Text;
using System.Linq;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {

        //Code to improve
        //Change in name of static function ( Typo Fixed )
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            // Inroducing a null reference check or empty check for input parameters 
            //If required Custom exception messages can also be send based on output type. 
            // IF items are null then ArgumentNullException 
            // If items are empty then Argument Exception ( Empty )

            if (items != null && items.Length >= 1 && quote != null)
            {
                //Code would have failed if items is null or items doesn't have any value 
                // There is reference of items[0] value without checking content of array.

                // Removed string builder class and used string.join instead 
                //StringBuilder qry = new StringBuilder(string.Format("{0}{1}{0}", quote, items[0]));

                //Moved if check above
                //Removed For Loop to make it bit simplified
                //if (items.Length > 1)
                //{
                // for (int i = 1; i < items.Length; i++)
                // {
                //     qry.Append(string.Format(", {0}{1}{0}", quote, items[i]));
                // }
                //}
                return string.Join(", ", items.Select(x => $"{quote}{item}{quote}"));
            }

            //If items is null or empty empty string will be returned from function
            return string.empty;
            
        }
    }
}
