﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Parameters
{
	/// <summary>
	/// Client account creation parameters used in the API.
	/// </summary>
	public class ClientAccountModificationParams : ClientAccountBaseParams
	{
		/// <summary>
		/// Client account identifier.
		/// </summary>
		public int ClientId { get; set; }
	}
}
