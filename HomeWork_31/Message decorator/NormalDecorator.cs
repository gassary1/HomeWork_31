using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_31.Message_decorator
{
    class NormalDecorator : MessageDecorator
    {
        public NormalDecorator(Message message) : base(message) { }

        public override void PrintMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _message.PrintMessage();
            Console.ResetColor();
        }
    }
}
