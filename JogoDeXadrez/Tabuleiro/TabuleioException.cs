using System;

namespace tabuleiro
{
    public class TabuleioException : Exception
    {
        public TabuleioException(string message) : base(message)
        {
        }
    }
}
