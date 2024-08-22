using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Excel
{
    public class BlockFactory
    {
        public static IBlock Create(string contect)
        {
            if (DateTime.TryParse(contect, out DateTime format))
            {
                return new DatetimeBlock()
                {
                        Format ="dd/MM/yyy",
                        DateTime = format
                    
                };
            }
            if(int.TryParse(contect,out int number))
            {
                return new NumberBlock() { Number = number };
            }
            return new TextBlock {  Content = contect };
        }
    }
}
