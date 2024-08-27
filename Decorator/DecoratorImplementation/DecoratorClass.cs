using Decorator.ComponentDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DecoratorImplementation
{
    /// <summary>
    /// Decorator Implementation of Component
    /// </summary>
    public class DecoratorClass : Component
    {
        protected Component _component;
        public DecoratorClass(Component component)
        {
            _component = component;
        }
        public void SetComponent(Component component)
        {
            this._component = component;
        }
        public override string Operation()
        {
            if (this._component != null)
            {

                return this._component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
