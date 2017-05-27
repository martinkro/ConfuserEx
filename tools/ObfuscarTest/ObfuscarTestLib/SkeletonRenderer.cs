using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObfuscarTestLib
{
    class SkeletonRenderer
    {
        public virtual void LateUpdate()
        {
            Console.WriteLine("SkeletonRenderer::LateUpdate");
        }

        public override string ToString()
        {
            return "SkeletonRenderer";
        }
    }
}
