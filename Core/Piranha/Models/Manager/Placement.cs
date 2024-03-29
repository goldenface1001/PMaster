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
using System.Web;

namespace Piranha.Models.Manager
{
	public class Placement
	{
		public Guid Value { get; set; }
		public string Text { get; set; }
		public int Level { get; set; }
	}
}