using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    public interface ITranslator
    {
        string Translate(string toTranslate);
    }
}
