namespace Jayway.Cars.Infrastructure.Ef.Dummy
{
    public class Tests
    {
        public class TestLogger : ILogger
        {
            public int LogCount = 0;

            public void Information(string message)
            {
                LogCount++;
            }
        }

        public void Test()
        {
            //Arragne
            var ctx = new CarContext(new TestLogger());

            //Act
            //ctx.blaj();

            //Assert
        }
    }
}