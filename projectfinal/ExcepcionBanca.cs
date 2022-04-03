using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace projectfinal
{
    internal class ExcepcionBanca : Exception
    {
        public ExcepcionBanca() : base()
        { }
        public ExcepcionBanca(string message) : base(message)
        { }
        public ExcepcionBanca(string message, Exception innerException)
            : base(message, innerException)
        { }
        public ExcepcionBanca(SerializationInfo info, StreamingContext context)
            : base(info, context);
         }
    }

