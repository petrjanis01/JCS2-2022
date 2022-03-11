using System;

namespace JCS2.DataFiles.NetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO move person to class lib (.NET vs Core => standard)

            JsonHelper.SerializePerson();
            JsonHelper.DeserializePerson();
        }
    }
}
