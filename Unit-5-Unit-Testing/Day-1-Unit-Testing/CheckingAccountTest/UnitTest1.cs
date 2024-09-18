using Xunit.Sdk;

namespace CheckingAccountTest
{
    public class UnitTest1
    {

        /****************************************************************************************
         * Generate unit test for "happy path" and "edge/error" cases
         * 
         * often the requirements for the application has great starting points for tests
         * 
         * For this class we were given:
         *      an account has a balancl......
         *      
         *      an account.....
         *      
         *      an account.....
         *      
         *      an account..... 
         ***************************************************************************************/ 




        [Fact]
        public void Withdrawal_With_Overdraft_Fee()
        {
            // Arrange

            

            double testStartBalance = 0; // starting balance

            // CheckingAccount with a known balance
            CheckingAccount testAccount = new CheckingAccount("test Owner", testStartBalance);

            // Withdrawal amount greater than the balance (but less than $10 more than balance
            double testWithdrawal = 90;

            // Act - test method using test data
            testAccount.Withdrawal(testWithdrawal);

            // Assert - verify we get the expected value
            //        - is the balance -100
            Assert.Equal(-100, testWithdrawal.Balance);
            
        }
    }
}