using CharacterBuilder.Console.Commons;
using System;
using Xunit;

namespace CharacterBuilder.xunitTest
{
    public class CharacterBuilder_Test
    {
        [Fact]
        public void CommonHandler_GetDataCollection_ReturnNotEmpty()
        {

            //Act
            string res = CommonHandler.GetDataCollection("a");
            //Asset
            Assert.NotEmpty(res);

        }

        [Fact]
        public void CommonHandler_GetDataCollection_ReturnEmpty()
        {

            //Act
            string res = CommonHandler.GetDataCollection("djfkdjfkdjfkdjf");
            //Asset
            Assert.Empty(res);

        }

        [Fact]
        public void CommonHandler_GetLetter_ReturnExist()
        {
            //Act
            string res = CommonHandler.GetLetter(2);
            //Asset
            Assert.NotEmpty(res);

        }

        [Fact]
        public void CommonHandler_GetLetter_ReturnNotExist()
        {
            //Act
            string res = CommonHandler.GetLetter(165);
            //Asset
            Assert.Empty(res);

        }
    }
}
