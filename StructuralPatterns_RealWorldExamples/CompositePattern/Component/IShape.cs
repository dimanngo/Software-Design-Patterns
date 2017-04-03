using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern.Component
{
    public interface IShape
    {
        string Name { get; set; }
        void Render(int depth);
    }
}
