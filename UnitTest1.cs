using FluentAssertions;
using Machine.Specifications;
using System;
// using Moq;

// using IT = Moq.It;
// using It = Machine.Specifications.It;


[Subject("test One")]
public class when_adding_two_operands
{
	static int value; 

	Establish context = () => value = 1;

	Because of = () =>
		value++;

        It should_now_be_two = () => value.Should().BeGreaterOrEqualTo(2);
		
}

[Subject("adding multiple operands")]
public class when_adding_multiple_operands
{
	static decimal value;

	Establish context = () => value = 1;

	Because of = () =>
		value--;

        It should_now_be_zero = () => 
        {
            Console.WriteLine(value);
            value.Should().Be(3);
        };
}
