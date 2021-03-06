﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet.Destiny.Milestones
{
	/// <summary>
	/// If a Milestone has one or more Vendors that are relevant to it, this will contain information about that vendor that you can choose to show.
	/// </summary>
	public partial class DestinyMilestoneVendor
	{
		[JsonProperty("vendorHash")]
		public uint VendorHash { get; set; }

		[JsonProperty("previewItemHash")]
		public uint? PreviewItemHash { get; set; }
	}
}
