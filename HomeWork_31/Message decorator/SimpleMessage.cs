using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_31.Message_decorator
{
    class SimpleMessage : Message
    {
        public SimpleMessage(string text) : base(text) { }

        public override void PrintMessage()
        {
            Console.WriteLine(_text);
        }
    }
}
