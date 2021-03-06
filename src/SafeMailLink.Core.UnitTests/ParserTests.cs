﻿using System;
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

		[TestMethod]
		public void Parser_EncodeMailLink_VerifyMailto()
		{
			var parser = new Parser(Encoding.UTF8);
			var mailto = "mailto:username@domain.com";
			var encoded = BitConverter.ToString(Encoding.UTF8.GetBytes(mailto)).Replace("-", string.Empty);
			var content = string.Format("<html><body><a href=\"{0}\">Email me</a></body></html>", mailto);
			var output = parser.EncodeMailLink(content);

			Assert.IsFalse(output.Contains(mailto));
			Assert.IsTrue(output.Contains(encoded));
		}
	}
}
