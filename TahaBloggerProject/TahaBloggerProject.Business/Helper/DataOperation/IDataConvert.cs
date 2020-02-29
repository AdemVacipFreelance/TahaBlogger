using System;
using System.Collections.Generic;
using System.Text;

namespace TahaBloggerProject.Business.Helper.DataOperation
{
  public  interface IDataConvert
    {
        T JsonToObject<T>(string jsonString) where T : class, new();
        string ObjectToJson<T>(T entityObject) where T : class, new();
        T ParseObjectDataArray<T>(byte[] rawBytes) where T : class, new();
    }
}
