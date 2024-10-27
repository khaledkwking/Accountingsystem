using System;
using System.Collections.Generic;
using System.Text;
   using System;

using Microsoft.PointOfService;
namespace ERPSYS
{

    public class CashDrawerClass
    {
        CashDrawer myCashDrawer;
        PosExplorer explorer;

        public CashDrawerClass()
        {
            explorer = new PosExplorer(this);
            DeviceInfo ObjDevicesInfo = explorer.GetDevice("CashDrawer");
            myCashDrawer = explorer.CreateInstance(ObjDevicesInfo);
        }

    }
}
