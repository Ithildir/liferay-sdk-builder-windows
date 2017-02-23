//------------------------------------------------------------------------------
// <copyright file="MBMessageService.cs">
//    Copyright (c) 2014-present Andrea Di Giorgi
//
//    Permission is hereby granted, free of charge, to any person obtaining a
//    copy of this software and associated documentation files (the "Software"),
//    to deal in the Software without restriction, including without limitation
//    the rights to use, copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following conditions:
//
//    The above copyright notice and this permission notice shall be included in
//    all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
//    THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// </copyright>
// <author>Andrea Di Giorgi</author>
// <website>https://github.com/Ithildir/liferay-sdk-builder-windows</website>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Liferay.SDK.Service.V62.MBMessage
{
	public class MBMessageService : ServiceBase
	{
		public MBMessageService(ISession session)
			: base(session)
		{
		}

		public async Task<dynamic> AddDiscussionMessageAsync(long groupId, string className, long classPK, string permissionClassName, long permissionClassPK, long permissionOwnerId, long threadId, long parentMessageId, string subject, string body, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("className", className);
			_parameters.Add("classPK", classPK);
			_parameters.Add("permissionClassName", permissionClassName);
			_parameters.Add("permissionClassPK", permissionClassPK);
			_parameters.Add("permissionOwnerId", permissionOwnerId);
			_parameters.Add("threadId", threadId);
			_parameters.Add("parentMessageId", parentMessageId);
			_parameters.Add("subject", subject);
			_parameters.Add("body", body);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/mbmessage/add-discussion-message", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> AddMessageAsync(long groupId, long categoryId, string subject, string body, string format, IEnumerable<object> inputStreamOVPs, bool anonymous, double priority, bool allowPingbacks, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("categoryId", categoryId);
			_parameters.Add("subject", subject);
			_parameters.Add("body", body);
			_parameters.Add("format", format);
			_parameters.Add("inputStreamOVPs", inputStreamOVPs);
			_parameters.Add("anonymous", anonymous);
			_parameters.Add("priority", priority);
			_parameters.Add("allowPingbacks", allowPingbacks);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/mbmessage/add-message", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> AddMessageAsync(long groupId, long categoryId, long threadId, long parentMessageId, string subject, string body, string format, IEnumerable<object> inputStreamOVPs, bool anonymous, double priority, bool allowPingbacks, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("categoryId", categoryId);
			_parameters.Add("threadId", threadId);
			_parameters.Add("parentMessageId", parentMessageId);
			_parameters.Add("subject", subject);
			_parameters.Add("body", body);
			_parameters.Add("format", format);
			_parameters.Add("inputStreamOVPs", inputStreamOVPs);
			_parameters.Add("anonymous", anonymous);
			_parameters.Add("priority", priority);
			_parameters.Add("allowPingbacks", allowPingbacks);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/mbmessage/add-message", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> AddMessageAsync(long categoryId, string subject, string body, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("categoryId", categoryId);
			_parameters.Add("subject", subject);
			_parameters.Add("body", body);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/mbmessage/add-message", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> AddMessageAsync(long parentMessageId, string subject, string body, string format, IEnumerable<object> inputStreamOVPs, bool anonymous, double priority, bool allowPingbacks, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("parentMessageId", parentMessageId);
			_parameters.Add("subject", subject);
			_parameters.Add("body", body);
			_parameters.Add("format", format);
			_parameters.Add("inputStreamOVPs", inputStreamOVPs);
			_parameters.Add("anonymous", anonymous);
			_parameters.Add("priority", priority);
			_parameters.Add("allowPingbacks", allowPingbacks);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/mbmessage/add-message", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task DeleteDiscussionMessageAsync(long groupId, string className, long classPK, string permissionClassName, long permissionClassPK, long permissionOwnerId, long messageId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("className", className);
			_parameters.Add("classPK", classPK);
			_parameters.Add("permissionClassName", permissionClassName);
			_parameters.Add("permissionClassPK", permissionClassPK);
			_parameters.Add("permissionOwnerId", permissionOwnerId);
			_parameters.Add("messageId", messageId);

			var _command = new JsonObject()
			{
				{ "/mbmessage/delete-discussion-message", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task DeleteMessageAsync(long messageId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("messageId", messageId);

			var _command = new JsonObject()
			{
				{ "/mbmessage/delete-message", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task DeleteMessageAttachmentsAsync(long messageId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("messageId", messageId);

			var _command = new JsonObject()
			{
				{ "/mbmessage/delete-message-attachments", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<IEnumerable<dynamic>> GetCategoryMessagesAsync(long groupId, long categoryId, int status, int start, int end)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("categoryId", categoryId);
			_parameters.Add("status", status);
			_parameters.Add("start", start);
			_parameters.Add("end", end);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-category-messages", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<long> GetCategoryMessagesCountAsync(long groupId, long categoryId, int status)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("categoryId", categoryId);
			_parameters.Add("status", status);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-category-messages-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<string> GetCategoryMessagesRssAsync(long groupId, long categoryId, int status, int max, string type, double version, string displayStyle, string feedURL, string entryURL, JsonObjectWrapper themeDisplay)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("categoryId", categoryId);
			_parameters.Add("status", status);
			_parameters.Add("max", max);
			_parameters.Add("type", type);
			_parameters.Add("version", version);
			_parameters.Add("displayStyle", displayStyle);
			_parameters.Add("feedURL", feedURL);
			_parameters.Add("entryURL", entryURL);
			this.MangleWrapper(_parameters, "themeDisplay", "com.liferay.portal.theme.ThemeDisplay", themeDisplay);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-category-messages-rss", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (string)_obj;
		}

		public async Task<string> GetCompanyMessagesRssAsync(long companyId, int status, int max, string type, double version, string displayStyle, string feedURL, string entryURL, JsonObjectWrapper themeDisplay)
		{
			var _parameters = new JsonObject();

			_parameters.Add("companyId", companyId);
			_parameters.Add("status", status);
			_parameters.Add("max", max);
			_parameters.Add("type", type);
			_parameters.Add("version", version);
			_parameters.Add("displayStyle", displayStyle);
			_parameters.Add("feedURL", feedURL);
			_parameters.Add("entryURL", entryURL);
			this.MangleWrapper(_parameters, "themeDisplay", "com.liferay.portal.theme.ThemeDisplay", themeDisplay);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-company-messages-rss", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (string)_obj;
		}

		public async Task<long> GetGroupMessagesCountAsync(long groupId, int status)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("status", status);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-group-messages-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<string> GetGroupMessagesRssAsync(long groupId, long userId, int status, int max, string type, double version, string displayStyle, string feedURL, string entryURL, JsonObjectWrapper themeDisplay)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("userId", userId);
			_parameters.Add("status", status);
			_parameters.Add("max", max);
			_parameters.Add("type", type);
			_parameters.Add("version", version);
			_parameters.Add("displayStyle", displayStyle);
			_parameters.Add("feedURL", feedURL);
			_parameters.Add("entryURL", entryURL);
			this.MangleWrapper(_parameters, "themeDisplay", "com.liferay.portal.theme.ThemeDisplay", themeDisplay);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-group-messages-rss", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (string)_obj;
		}

		public async Task<string> GetGroupMessagesRssAsync(long groupId, int status, int max, string type, double version, string displayStyle, string feedURL, string entryURL, JsonObjectWrapper themeDisplay)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("status", status);
			_parameters.Add("max", max);
			_parameters.Add("type", type);
			_parameters.Add("version", version);
			_parameters.Add("displayStyle", displayStyle);
			_parameters.Add("feedURL", feedURL);
			_parameters.Add("entryURL", entryURL);
			this.MangleWrapper(_parameters, "themeDisplay", "com.liferay.portal.theme.ThemeDisplay", themeDisplay);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-group-messages-rss", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (string)_obj;
		}

		public async Task<dynamic> GetMessageAsync(long messageId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("messageId", messageId);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-message", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> GetMessageDisplayAsync(long messageId, int status, string threadView, bool includePrevAndNext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("messageId", messageId);
			_parameters.Add("status", status);
			_parameters.Add("threadView", threadView);
			_parameters.Add("includePrevAndNext", includePrevAndNext);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-message-display", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<long> GetThreadAnswersCountAsync(long groupId, long categoryId, long threadId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("categoryId", categoryId);
			_parameters.Add("threadId", threadId);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-thread-answers-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<IEnumerable<dynamic>> GetThreadMessagesAsync(long groupId, long categoryId, long threadId, int status, int start, int end)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("categoryId", categoryId);
			_parameters.Add("threadId", threadId);
			_parameters.Add("status", status);
			_parameters.Add("start", start);
			_parameters.Add("end", end);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-thread-messages", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<long> GetThreadMessagesCountAsync(long groupId, long categoryId, long threadId, int status)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("categoryId", categoryId);
			_parameters.Add("threadId", threadId);
			_parameters.Add("status", status);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-thread-messages-count", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (long)_obj;
		}

		public async Task<string> GetThreadMessagesRssAsync(long threadId, int status, int max, string type, double version, string displayStyle, string feedURL, string entryURL, JsonObjectWrapper themeDisplay)
		{
			var _parameters = new JsonObject();

			_parameters.Add("threadId", threadId);
			_parameters.Add("status", status);
			_parameters.Add("max", max);
			_parameters.Add("type", type);
			_parameters.Add("version", version);
			_parameters.Add("displayStyle", displayStyle);
			_parameters.Add("feedURL", feedURL);
			_parameters.Add("entryURL", entryURL);
			this.MangleWrapper(_parameters, "themeDisplay", "com.liferay.portal.theme.ThemeDisplay", themeDisplay);

			var _command = new JsonObject()
			{
				{ "/mbmessage/get-thread-messages-rss", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (string)_obj;
		}

		public async Task RestoreMessageAttachmentFromTrashAsync(long messageId, string fileName)
		{
			var _parameters = new JsonObject();

			_parameters.Add("messageId", messageId);
			_parameters.Add("fileName", fileName);

			var _command = new JsonObject()
			{
				{ "/mbmessage/restore-message-attachment-from-trash", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task SubscribeMessageAsync(long messageId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("messageId", messageId);

			var _command = new JsonObject()
			{
				{ "/mbmessage/subscribe-message", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task UnsubscribeMessageAsync(long messageId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("messageId", messageId);

			var _command = new JsonObject()
			{
				{ "/mbmessage/unsubscribe-message", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task UpdateAnswerAsync(long messageId, bool answer, bool cascade)
		{
			var _parameters = new JsonObject();

			_parameters.Add("messageId", messageId);
			_parameters.Add("answer", answer);
			_parameters.Add("cascade", cascade);

			var _command = new JsonObject()
			{
				{ "/mbmessage/update-answer", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<dynamic> UpdateDiscussionMessageAsync(string className, long classPK, string permissionClassName, long permissionClassPK, long permissionOwnerId, long messageId, string subject, string body, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("className", className);
			_parameters.Add("classPK", classPK);
			_parameters.Add("permissionClassName", permissionClassName);
			_parameters.Add("permissionClassPK", permissionClassPK);
			_parameters.Add("permissionOwnerId", permissionOwnerId);
			_parameters.Add("messageId", messageId);
			_parameters.Add("subject", subject);
			_parameters.Add("body", body);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/mbmessage/update-discussion-message", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<dynamic> UpdateMessageAsync(long messageId, string subject, string body, IEnumerable<object> inputStreamOVPs, IEnumerable<string> existingFiles, double priority, bool allowPingbacks, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("messageId", messageId);
			_parameters.Add("subject", subject);
			_parameters.Add("body", body);
			_parameters.Add("inputStreamOVPs", inputStreamOVPs);
			_parameters.Add("existingFiles", existingFiles);
			_parameters.Add("priority", priority);
			_parameters.Add("allowPingbacks", allowPingbacks);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/mbmessage/update-message", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}
	}
}