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

namespace BungieNet.Destiny.Definitions
{
	/// <summary>
	/// Some items are "sacks" - they can be "opened" to produce other items. This is information related to its sack status, mostly UI strings. Engrams are an example of items that are considered to be "Sacks".
	/// </summary>
	public partial class DestinyItemSackBlockDefinition
	{
		[JsonProperty("detailAction")]
		public string DetailAction { get; set; }

		[JsonProperty("openAction")]
		public string OpenAction { get; set; }

		[JsonProperty("selectItemCount")]
		public int SelectItemCount { get; set; }

		[JsonProperty("vendorSackType")]
		public string VendorSackType { get; set; }

		[JsonProperty("openOnAcquire")]
		public bool OpenOnAcquire { get; set; }
	}
}
