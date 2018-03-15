using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroExample
{
	public class Person
	{
		public string _firstName;
		public string _lastName;


		public Person(string firstName, string lastName)
		{
			_firstName = firstName;
			_lastName = lastName;
		}

		private bool IsValidFirstName(string name)
		{
			if (name.Length < 3)
			{
				return false;
			}
			return true;
		}

		public void SetFirstName(string firstName)
		{
			if (IsValidFirstName(firstName))
			{
				_firstName = firstName;

			}
		}
		public string GetFirstName()
		{
			return _firstName;
		}

		public string GetDisplayName()
		{
			if (_firstName == null && _lastName == null)
			{
				return "Guest";
			}

			string display = _firstName + "!";
			return display;
		}


	}
}
