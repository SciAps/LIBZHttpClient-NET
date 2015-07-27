using System;
using NUnit.Framework;
using sciaps.libzhttpclient;

[TestFixture]
public class TestHttpClient
{
	[Test]
	public void testCreatClient ()
	{
		var client = LIBZHttpClient.createClient ("10.98.100.80");
		Assert.NotNull (client);
	}

	[Test]
	public void testGetInstrument() {

		var client = LIBZHttpClient.createClient ("10.98.100.80");
		var result = client.getInstrumentAsync().Result;

		System.Console.WriteLine ("result: " + result);
		Assert.NotNull (result);

	}
}
