using System;

namespace ProejctBlogAPI.Infrastructure.Exceptions
{
    public class TestDomainException : Exception
    {
        public TestDomainException()
        { }

        public TestDomainException(string message)
            : base(message)
        { }

        public TestDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
