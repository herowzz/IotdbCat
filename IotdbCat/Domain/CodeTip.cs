using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IotdbCat.Domain
{
    /// <summary>
    /// code pop tips
    /// </summary>
    public class CodeTip
    {
        public string Name { get; set; }

        public TipType Type { get; set; }
    }

    public enum TipType
    {
        Syntax, Table, Function
    }
}
