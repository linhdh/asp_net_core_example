using MyProject2.EntityFrameworkCore;

namespace MyProject2.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MyProject2DbContext _context;

        public TestDataBuilder(MyProject2DbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}