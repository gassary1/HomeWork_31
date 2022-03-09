using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_31.Message_decorator
{
    class AlertMessage : Message
    {
        public AlertMessage(string text) : base(text) { }

        public override void PrintMessage()
        {
            Console.Beep();
            Console.WriteLine(_text);
        }
    }
}
