using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositDesignPatter
{
    //Composit
    public class Branch : GitComponent
    {
        private readonly string _branchName;
        public Branch(string branchName)
        {
            _branchName = branchName;
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"+ Branch Name :{_branchName}");
            foreach (var component in _components)
            {
                component.ShowDetails();
            }
        }
    }
}
