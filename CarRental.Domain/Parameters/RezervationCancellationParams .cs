﻿using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain.Parameters
{
	/// <summary>
	/// Rezervation cancellation parameters.
	/// </summary>
	public class RezervationCancellationParams
	{
		/// <summary>
		/// Rezervation identifier.
		/// </summary>
		[Required]
		public int RezervationId { get; set; }

		/// <summary>
		/// Cancelation fee rate. Used for cancellation fee adjustment.
		/// </summary>
		[Required]
		public decimal CancellationFeeRate { get; set; }
	}
}