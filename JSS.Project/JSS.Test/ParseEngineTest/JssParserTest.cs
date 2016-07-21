using JSS.Framework.ParseEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace JSS.Test.ParseEngineTest
{
    public class JssParserTest
    {

        const string TEST_STRING = "this is my test string";
        const string TEST_FILE_PATH = "testfile.txt";

        JssParser _parser;

        public JssParserTest()
        {
            _parser = new JssParser(TEST_FILE_PATH);

        }//ctor

        //Arrange, Act, Assert

        [Fact]
        public async Task ReadFileAsync_Path_String()
        {
            string retString = await _parser.ReadFileAsync();
            Assert.Equal(TEST_STRING, retString);

        }//ReadFileAsync_Path_String()

    }//class JssParserTest

}//namespace
