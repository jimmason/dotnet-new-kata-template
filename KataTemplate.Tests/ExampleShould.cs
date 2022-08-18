using FluentAssertions;

namespace KataTemplate.Tests;

public class ExampleShould
{
    [Fact]
    public void SayHelloWorld()
    {
        Example.SayHelloWorld().Should().Be("Hello world");
    }
}