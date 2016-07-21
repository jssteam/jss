using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSS.Framework.ParseEngine
{

    [Serializable]
    public class JssParseEngineException : Exception
    {
        public JssParseEngineException() { }
        public JssParseEngineException(string message) : base(message) { }
        public JssParseEngineException(string message, Exception inner) : base(message, inner) { }
        protected JssParseEngineException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info.ToString()) { }
    }
}
