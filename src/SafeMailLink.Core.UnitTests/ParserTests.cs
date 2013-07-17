using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SafeMailLink.Core.Utilities;

namespace SafeMailLink.Core.UnitTests
{
	[TestClass]
	public class ParserTests
	{
		[TestMethod]
		public void Parser_EncodeMailLink_SingleQuotes()
		{
			var parser = new Parser(Encoding.UTF8);
			var email = "username@domain.com";
			var content = string.Format("<html><body><a href='mailto:{0}'>{0}</a></body></html>", email);
			var output = parser.EncodeMailLink(content);

			Assert.IsFalse(output.Contains(email));
		}

		[TestMethod]
		public void Parser_EncodeMailLink_DoubleQuotes()
		{
			var parser = new Parser(Encoding.UTF8);
			var email = "username@domain.com";
			var content = string.Format("<html><body><a href=\"mailto:{0}\">{0}</a></body></html>", email);
			var output = parser.EncodeMailLink(content);

			Assert.IsFalse(output.Contains(email));
		}
	}
}
