using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSS.Framework.ParseEngine
{
    public class JssParser
    {
        public JssParser(string path)
        {

        }

        public async Task<string> ReadFileAsync()
        {
            return await Task.Run(() => {

                return  "this is my test string";
            });
        }

    }//class JssParser

}//namespace
