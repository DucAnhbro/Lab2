using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Bai1.Binding
{
	public class CheckNameBinding : IModelBinder
	{
		private readonly ILogger<CheckNameBinding> _logger;

		public CheckNameBinding(ILogger<CheckNameBinding> logger)
		{
			_logger = logger;	
		}

		public Task BindModelAsync(ModelBindingContext bindingContext)
		{
			if (bindingContext == null)
			{
				throw new ArgumentNullException(nameof(bindingContext));
			}

			string modulName = bindingContext.ModelName;
			ValueProviderResult valueProviderResult = bindingContext.ValueProvider.GetValue(modulName);
			if(valueProviderResult == ValueProviderResult.None)
			{
				return Task.CompletedTask;	
			}
			//Set ModelState for the value binding

			bindingContext.ModelState.SetModelValue(modulName, valueProviderResult);

			string value = valueProviderResult.FirstValue;
			if(string.IsNullOrEmpty(value))
			{
				return Task<bool>.CompletedTask;	
			}
			var s = value.ToUpper();

			if (s.Contains("XXX"))
			{
				bindingContext.ModelState.TryAddModelError(modulName, "Cannot contain this partten XXX.");
				return Task.CompletedTask;
			}
			bindingContext.Result = ModelBindingResult.Success(s.Trim());
			return Task.CompletedTask;	
		}
		
	}
}
