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
using System.Runtime.Serialization;
using System.Text;

namespace Piranha.Legacy.Services.DataContracts
{
	[DataContract()]
	public class Category
	{
		[DataMember()]
		public Guid Id { get; set; }
		[DataMember()]
		public string Name { get; set; }
		[DataMember()]
		public string Permalink { get; set; }
		[DataMember()]
		public string Description { get; set; }
		[DataMember()]
		public List<Extension> Extensions { get; set; }
		[DataMember()]
		public string Created { get; set; }
		[DataMember()]
		public string Updated { get; set; }

		public Category() {
			Extensions = new List<Extension>();
		}
	}
}
