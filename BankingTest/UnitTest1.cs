using System;
using Xunit;
using MySuperBank;

namespace BankingTest
{ 
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True();
        }
        public void Test2()
        {
            var account = new BankAccount("SBI", 10000);
            Assert.Throws(InvalidOperationException)(

                () => account.MakeWithDrawal(75000, DateTime.Now, "Attempt to overdraw")

               );
            //try
            //{
            //    account.MakeWithDrawal(75000, DateTime.Now, "Attempt to overdraw")
            //}
            //catch(InvalidOperationException e)
            //{
            //    console.WriteLine("exception");
            //    console.WriteLine(e.tostring());
            //}
        }
        public void Test3()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("invalid", 55));
        }
    }
}
