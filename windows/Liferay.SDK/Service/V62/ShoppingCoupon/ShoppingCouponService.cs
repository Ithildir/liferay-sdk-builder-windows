//------------------------------------------------------------------------------
// <copyright file="ShoppingCouponService.cs">
//    Copyright (c) 2014 Andrea Di Giorgi. All rights reserved.
//
//    This library is free software; you can redistribute it and/or modify it
//    under the terms of the GNU Lesser General Public License as published by
//    the Free Software Foundation; either version 2.1 of the License, or (at
//    your option) any later version.
//
//    This library is distributed in the hope that it will be useful, but
//    WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
//    or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public
//    License for more details.
// </copyright>
// <author>Andrea Di Giorgi</author>
// <website>https://github.com/Ithildir/liferay-sdk-builder-windows</website>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Liferay.SDK.Service.V62.ShoppingCoupon
{
	public class ShoppingCouponService : ServiceBase
	{
		public ShoppingCouponService(ISession session)
			: base(session)
		{
		}

		public async Task<dynamic> AddCouponAsync(string code, bool autoCode, string name, string description, int startDateMonth, int startDateDay, int startDateYear, int startDateHour, int startDateMinute, int endDateMonth, int endDateDay, int endDateYear, int endDateHour, int endDateMinute, bool neverExpire, bool active, string limitCategories, string limitSkus, double minOrder, double discount, string discountType, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("code", code);
			_parameters.Add("autoCode", autoCode);
			_parameters.Add("name", name);
			_parameters.Add("description", description);
			_parameters.Add("startDateMonth", startDateMonth);
			_parameters.Add("startDateDay", startDateDay);
			_parameters.Add("startDateYear", startDateYear);
			_parameters.Add("startDateHour", startDateHour);
			_parameters.Add("startDateMinute", startDateMinute);
			_parameters.Add("endDateMonth", endDateMonth);
			_parameters.Add("endDateDay", endDateDay);
			_parameters.Add("endDateYear", endDateYear);
			_parameters.Add("endDateHour", endDateHour);
			_parameters.Add("endDateMinute", endDateMinute);
			_parameters.Add("neverExpire", neverExpire);
			_parameters.Add("active", active);
			_parameters.Add("limitCategories", limitCategories);
			_parameters.Add("limitSkus", limitSkus);
			_parameters.Add("minOrder", minOrder);
			_parameters.Add("discount", discount);
			_parameters.Add("discountType", discountType);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/shoppingcoupon/add-coupon", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task DeleteCouponAsync(long groupId, long couponId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("couponId", couponId);

			var _command = new JsonObject()
			{
				{ "/shoppingcoupon/delete-coupon", _parameters }
			};

			await this.Session.InvokeAsync(_command);
		}

		public async Task<dynamic> GetCouponAsync(long groupId, long couponId)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("couponId", couponId);

			var _command = new JsonObject()
			{
				{ "/shoppingcoupon/get-coupon", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}

		public async Task<IEnumerable<dynamic>> SearchAsync(long groupId, long companyId, string code, bool active, string discountType, bool andOperator, int start, int end)
		{
			var _parameters = new JsonObject();

			_parameters.Add("groupId", groupId);
			_parameters.Add("companyId", companyId);
			_parameters.Add("code", code);
			_parameters.Add("active", active);
			_parameters.Add("discountType", discountType);
			_parameters.Add("andOperator", andOperator);
			_parameters.Add("start", start);
			_parameters.Add("end", end);

			var _command = new JsonObject()
			{
				{ "/shoppingcoupon/search", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (IEnumerable<dynamic>)_obj;
		}

		public async Task<dynamic> UpdateCouponAsync(long couponId, string name, string description, int startDateMonth, int startDateDay, int startDateYear, int startDateHour, int startDateMinute, int endDateMonth, int endDateDay, int endDateYear, int endDateHour, int endDateMinute, bool neverExpire, bool active, string limitCategories, string limitSkus, double minOrder, double discount, string discountType, JsonObjectWrapper serviceContext)
		{
			var _parameters = new JsonObject();

			_parameters.Add("couponId", couponId);
			_parameters.Add("name", name);
			_parameters.Add("description", description);
			_parameters.Add("startDateMonth", startDateMonth);
			_parameters.Add("startDateDay", startDateDay);
			_parameters.Add("startDateYear", startDateYear);
			_parameters.Add("startDateHour", startDateHour);
			_parameters.Add("startDateMinute", startDateMinute);
			_parameters.Add("endDateMonth", endDateMonth);
			_parameters.Add("endDateDay", endDateDay);
			_parameters.Add("endDateYear", endDateYear);
			_parameters.Add("endDateHour", endDateHour);
			_parameters.Add("endDateMinute", endDateMinute);
			_parameters.Add("neverExpire", neverExpire);
			_parameters.Add("active", active);
			_parameters.Add("limitCategories", limitCategories);
			_parameters.Add("limitSkus", limitSkus);
			_parameters.Add("minOrder", minOrder);
			_parameters.Add("discount", discount);
			_parameters.Add("discountType", discountType);
			this.MangleWrapper(_parameters, "serviceContext", "com.liferay.portal.service.ServiceContext", serviceContext);

			var _command = new JsonObject()
			{
				{ "/shoppingcoupon/update-coupon", _parameters }
			};

			var _obj = await this.Session.InvokeAsync(_command);

			return (dynamic)_obj;
		}
	}
}