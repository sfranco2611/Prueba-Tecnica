using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IStaircaseBuilder
    {
        string RightAlignedStaircaseBuilder(int size);
        string InvertedRightAlignedStaircaseBuilder(int size);
        string CenterAlignedStaircaseBuilder(int size);
    }
}
