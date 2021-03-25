using System;
using System.Threading;

namespace TestApplication
{
    public class RunChains
    {
        private Chain[] chains;

        public RunChains(int qt)
        {
            if (qt == -1)
            {
                qt = Chain.MAX_COL;
            }
            Chain.SetUp();
            chains = new Chain[qt];
            for (int i = 0; i < qt; i++)
            {
                chains[i] = new Chain(i + 1);
            }
        }

        public void Run()
        {
            while (true)
            {
                for (int i = 0; i < chains.Length; i++)
                {
                    chains[i] = chains[i].Print();
                }
                Thread.Sleep(Chain.TIMEOUT);
            }
        }
    }
}
