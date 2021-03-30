using System;
using System.Reflection.Emit;
using System.Text;

namespace UnityContainerExample.Helpers
{
    public enum MessageType
    {
        Info,
        Error,
        Done
    }

    public static class ShowConsoleMessage
    {
        public static void ShowMessage(string message, MessageType messageType = MessageType.Info, bool isNewLineRequired = false)
        {
            ShowMessage(message, messageType.ToString().ToUpper(), messageType, isNewLineRequired);
        }

        public static void ShowMessage(string message, string labelText, MessageType messageType = MessageType.Info, bool isNewLineRequired = false)
        {
            if (isNewLineRequired)
            {
                Console.WriteLine();
            }

            ShowColorfulLabel(messageType, new StringBuilder("[")
                .Append(labelText)
                .Append("] ").ToString());
            Console.WriteLine(message);
        }

        private static void ShowColorfulLabel(MessageType messageType, string labelText)
        {
            switch (messageType)
            {
                case MessageType.Info:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case MessageType.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case MessageType.Done:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default: return;
            }

            Console.Write(labelText);
            Console.ResetColor();
        }
    }
}