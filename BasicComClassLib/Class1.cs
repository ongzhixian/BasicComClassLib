using System;
using System.Runtime.InteropServices;

namespace BasicComClassLib
{


    [Guid("FB70BBC7-D3DF-4B2B-BFFA-05A4E17F9D87")]
    public interface BasicComClass1Interface
    {
    }

    [Guid("BA9ECC61-B933-4F54-A405-02FDD7AB23E0"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface BasicComClass1Events
    {
    }

    [Guid("463B59F1-A1BC-4FED-BD41-460163D185D5"), ClassInterface(ClassInterfaceType.None), ComSourceInterfaces(typeof(BasicComClass1Events))]
    public class ComClass1 : BasicComClass1Interface
    {
    }
}
