using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bai1.Validation
{
	public class CustomerValidation : ValidationAttribute
	{
		public CustomerValidation()
		{
			ErrorMessage = "The year of birth cannot greeter than current year(2021).";
		}
		public override bool IsValid(object value)
		{
			if(value == null)
			{
				return false;
			}
			int number = Int32.Parse(value.ToString());
			return (number < 2021);
		}
	}

}
