using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErorDataResult<T>:DataResult<T>
    {
        public ErorDataResult(T data,string message):base(data,success:false,message)
        {

        }
        public ErorDataResult(T data):base(data,success:false)
        {

        }
        public ErorDataResult(string message):base(default,success:false,message)
        {

        }
        public ErorDataResult():base(default,success:false)
        {

        }
    }
}
