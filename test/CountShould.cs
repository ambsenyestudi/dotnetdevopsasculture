using ClickCounter.Domain;
using Xunit;

namespace ClickCounter.Test
{
    public class CountShould
    {
        [Fact]
        public void StartAtZero()
        {
            var exptected = 0;
            var sut = new Count();
            Assert.Equal(exptected, sut.Total);
        }
    }
}
