﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// состояние ожидания для объекты (пользователя)
    /// </summary>
    internal class SuspendedState : IState
    {
        public void SendMessage(string message)
        {
            Thread.Sleep(5000);
            Console.WriteLine("пользователь отправил сообщение с задержкой:");
            Console.WriteLine(message);
        }

        public override string ToString()
        {
            return "режим ожидания";
        }
    }
}
