using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Вот и пришла мягкая, золотистая и такая непредсказуемая осень. Желтые листья слетают с веток деревьев, покрывая землю шуршащим одеялом. Под огромным старым дубом разбросаны спелые желуди. Недалеко слышен шорох упавшей ветки и треск осины. Решетчатый забор возле покосившегося дома стоит в сухих зарослях травы. Жесткий ветер прибил к нему гору опавшей листвы. Кажется, что забор обнесен сугробами, только желто - оранжевыми. Тихий дождик, словно последний шепот осени, мелко заморосил по крышам. Небо стало тяжелое и низкое.Осень, сменив лето, стала полноправно хозяйничать всюду. ";
            Dictionary<string, int> keyValues = new Dictionary<string, int>();

            string[] str = text.Split(new char[] { ' ', '\n', '\t', ',', '.','!','?',':',';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach(string i in str)
            {
                if (keyValues.ContainsKey(i))
                {
                    keyValues[i]++;
                }
                else
                {
                    keyValues[i] = 1;
                }
            }
            foreach (KeyValuePair<string, int> entry in keyValues)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }

        }
    }
}
