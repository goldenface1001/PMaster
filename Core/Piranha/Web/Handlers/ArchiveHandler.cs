﻿/*
 * Copyright (c) 2011-2015 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * http://github.com/piranhacms/piranha
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Piranha.Web.Handlers
{
	public class ArchiveHandler : IRequestHandler
	{
		public void HandleRequest(System.Web.HttpContext context, params string[] args) {
			context.RewritePath("~/archive" + (args.Length > 0 ? "/" : "") + args.Implode("/"), false);
		}
	}
}
