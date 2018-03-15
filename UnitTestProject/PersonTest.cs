using System;
using IntroExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// SpecFlow
// Gerkin (given when then, And)
// Step Def 
// Page Objects - drive UI



namespace UnitTestProject
{
	[TestClass]
	public class PersonTest
	{
		private Person _person;
		private string _firstName = "Bob";
		private string _lastName = "West";

		[TestInitialize]
		public void BeforeEachTest()
		{
			// login
			_person = new Person(_firstName, _lastName);

		}

		[TestCleanup]
		public void AfterEachTest()
		{
			// logout
		}

		[TestMethod]
		public void DisplayName()
		{
			string expected = "Bob!";
			string actual = _person.GetDisplayName();
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void InitialisingFirstName()
		{
			string firstName = "Bob";
			string lastName = "West";
			Person person = new Person(firstName, lastName);
			Assert.AreEqual(firstName, person.GetFirstName());
		}

		[TestMethod]
		public void SettingFirstName()
		{
			string firstName = "Bob";
			string lastName = "West";
			string expected = "Bob!";
			Person person = new Person(firstName, lastName);
			person.SetFirstName("Sue");
			Assert.AreEqual("Sue", person.GetFirstName());
		}

	}
}
