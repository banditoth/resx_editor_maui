﻿using System;
using ResxEditor.Interfaces;

namespace ResxEditor.Services
{
	public class DialogHandlerService : IDialogHandler
	{
		public DialogHandlerService()
		{

		}

        public Task DisplayAlert(string title, string message, string confirm)
        {
            return Application.Current.MainPage.DisplayAlert(title, message, confirm);
        }

        public Task<string> DisplayPrompt(string title, string message, string confirm)
        {
            return Application.Current.MainPage.DisplayPromptAsync(title, message, confirm);
        }

    }
}

