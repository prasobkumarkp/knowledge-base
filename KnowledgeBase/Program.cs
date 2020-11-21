using System;
using KnowledgeBase.Delegates;
using KnowledgeBase.SystemInternal;

namespace KnowledgeBase
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICode code = new BinarySearch();
            //ICode code = new PrintPattern.Pyramid();
            ICode code = new AsyncAwait();
            //ICode code = new BasicDelegate();
            code.Run();
        }
    }
}



