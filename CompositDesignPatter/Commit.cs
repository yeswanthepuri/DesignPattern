using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositDesignPatter
{
    public class Commit : GitComponent
    {
        private readonly string _commitId;
        public Commit(string commitId)
        {
            _commitId=commitId;
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"- Commit ID: {_commitId}");
        }
    }
}
