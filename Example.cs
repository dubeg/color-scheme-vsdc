using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name
{
    private class A : B, IDisposable, Child, IBlablablah
    {
        private int _i;
        private bool _b;
    }

 
    public partial class Type : Parent
    {
        private int _a;
        private Controller _a;
        private Type _a = a; 
        int a;
        int a = b;
        Type a;
        Type a = ok;
        Namespace.Type a = a;
        Namespace.IType a = 0;
        IDisposable a;
        IDump a; 

        List<IEntry> list;
        List<Entry> list2;
        List<string> list3;

        string[] ss;
        Entry[] ee;


        public int Property1 { get; set; }
        public Type Property2 { get; set; }
        public Type[] Property3 { get; set; }

        public Method0(string param1, out int param2) {}
        public Method1(string param1, out Bitmap param2) {}
        public Method2(Type param1, ref Type param2) {}
        public Method3(Type param1, Type param2) {}
        public Method4(string[] param1, Type[] param2) {}

        public Constructor(string param1, Type param2)
        {
            Method();
            Method(param1, param2)
            instance.Method(param1, param2);

            _instance = new Instance();
            _instance.Property = _isntance2.Property.SubProperty;

            if (_instance.Count == 10)
            {
                statement = a;
            }

            switch (a)
            {
                case 1:
                    break;
                default:
                    break;
            }
        }

    }
}
