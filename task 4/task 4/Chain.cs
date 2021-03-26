using System;


namespace TestApplication
{
    public class Chain
    {
        public static readonly int TIMEOUT = 250;                 // customizable (in milliseconds)
        public static readonly int MAX_COL = Console.WindowWidth;
        static readonly int MAX_ROW = Console.WindowHeight;
        static readonly int MAX_LENGTH = MAX_ROW / 2;
        static readonly int MAX_SPACING = MAX_ROW - 2;
        static readonly int SPACING = 4;                          // customizable
        static readonly char EMPTY = ' ';
        static readonly char[] symbols = { '1', '0' };            // customizable

        int row, col, length;
        Chain next;
        bool isLeading = true;

        public Chain(int col)
        {
            if (col > MAX_COL) throw new Exception("column exceeds the limits");
            if (MAX_ROW < 6) throw new Exception("too few lines");
            this.col = col;
            length = new Random().Next(3, MAX_LENGTH + 1);
            row = 1 - (length - 1);
            next = new Chain(this) { isLeading = false };
        }

        private Chain(Chain leading)
        {
            col = leading.col;
            length = new Random().Next(3, MAX_LENGTH + 1);
            row = 1 - (length - 1);
        }

        public Chain Print()
        {
            bool onePrinted = false;
            for (int i = 0; i < length; i++)
            {
                int y = row + i;
                if (y < 1 || y > MAX_ROW) continue;
                Console.SetCursorPosition(col - 1, y - 1);
                ChangeFG(i);
                int randIndex = new Random().Next(symbols.Length);
                Console.Write(symbols[randIndex]);
                onePrinted = true;
                if (i == 0 && y >= 2)
                {
                    // cleanup
                    int prev = y - 1;
                    Console.SetCursorPosition(col - 1, prev - 1);
                    Console.Write(EMPTY);
                }
            }
            if (isLeading) LaunchNext();
            if (!onePrinted) // full cycle
            {
                row = 1 - (length - 1);
                // cleanup
                Console.SetCursorPosition(col - 1, MAX_ROW - 1);
                Console.Write(EMPTY);
                // return new leader
                Chain newLeader = next;
                ChangeRoles();
                return newLeader;
            }
            else
            {
                row++;
                return this;
            }
        }

        public static void SetUp()
        {
            Console.Clear();
            Console.CancelKeyPress += (object sender, ConsoleCancelEventArgs e) =>
            {
                Console.Clear();
                Console.ResetColor();
            };
        }

        private void ChangeFG(int index)
        {
            switch (index)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
            }
        }

        private void LaunchNext()
        {
            if (row >= 1 + SPACING + 1)
            {
                next.Print();
            }
        }

        private void ChangeRoles()
        {
            if (isLeading)
            {
                isLeading = false;
                next.isLeading = true;
                next.next = this;
                next = null;
            }
        }

    }
}
