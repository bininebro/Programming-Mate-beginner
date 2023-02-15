using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp.OOP
{
    internal class InternalClass
    {
        private int numPrivate = 1;
        public int numPublic = 1;
        internal int numInternal = 1;
        protected int numProtected = 1;
        int numDefualt = 1;
    }

    public class PublicClass
    {
        private int numPrivate = 1;
        public int numPublic = 1;
        internal int numInternal = 1;
        protected int numProtected = 1;
        int numDefualt = 1;
    }

    class DefualtClass
    {
        private int numPrivate = 1;
        public int numPublic = 1;
        internal int numInternal = 1;
        protected int numProtected = 1;
        int numDefualt = 1;
    }


    class TestEncapsulation
    {
        public TestEncapsulation()
        {
            InternalClass internalClass = new InternalClass();
            internalClass.numInternal = 1;
            internalClass.numPublic = 1;
            PublicClass publicClass = new PublicClass();
            publicClass.numInternal = 1;
            publicClass.numPublic = 1;
            DefualtClass defualtClass = new DefualtClass();
            defualtClass.numInternal = 1;
            defualtClass.numPublic = 1;

            TestSubClassInternal testSubClassInternal = new TestSubClassInternal();
            TestSubClassDefualt testSubClassDefualt = new TestSubClassDefualt();
            TestSubClassPublic testSubClassPublic = new TestSubClassPublic();
            
        }
    }

    class TestSubClassInternal : InternalClass
    {
       
    }

    class TestSubClassDefualt : DefualtClass
    {
    }
    class TestSubClassPublic : PublicClass
    {
       
    }
}
