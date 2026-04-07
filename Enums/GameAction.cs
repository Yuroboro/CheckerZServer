using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckerZ_Server.Enums
{
    public enum GameAction
    {
        //reverse for computer
        UpRight,UpLeft,
        //forward for computer
        DownRight,Downleft,
        //Captures for computer
        CaptureRight, CaptureLeft
    }
}
