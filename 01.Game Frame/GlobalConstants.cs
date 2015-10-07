using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Game_Frame
{
    static class GC
    {
        //sizes
        public const int frameThickness = 1;
        public const int gapThickness = 1;
        public const int borderTopDownThickness = 3;
        public const int borderSideThickness = 4;
        public const int gameFieldLength = 42;
        public const int gameFieldHeight = 35;

        //coordinates
        public const int frameLeft = 0; //x
        public const int frameTop = 4; //y
        public const int gapLeft = frameLeft + frameThickness; //x
        public const int gapTop = frameTop + frameThickness; //y
        public const int borderLeft = gapLeft + gapThickness; //x
        public const int borderTop = gapTop + gapThickness; //y
        public const int gameFieldLeft = borderLeft + borderSideThickness; //x
        public const int gameFieldTop = borderTop + borderTopDownThickness; //y
        public const int gameFieldRight = gameFieldLeft + gameFieldLength - 1; //x
        public const int gameFieldBottom = gameFieldTop + gameFieldHeight - 1; //y
        public const int borderRight = gameFieldRight + borderSideThickness; //x
        public const int borderBottom = gameFieldBottom + borderTopDownThickness; //y
        public const int gapRight = borderRight + gapThickness; //x
        public const int gapBottom = borderBottom + gapThickness; //y
        public const int frameRight = gapRight + frameThickness; //x
        public const int frameBottom = gapBottom + frameThickness; //y
    }
}
