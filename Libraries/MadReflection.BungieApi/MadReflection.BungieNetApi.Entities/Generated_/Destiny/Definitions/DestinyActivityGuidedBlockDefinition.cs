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
	/// Guided Game information for this activity.
	/// </summary>
	public partial class DestinyActivityGuidedBlockDefinition
	{
		[JsonProperty("guidedMaxLobbySize")]
		public int GuidedMaxLobbySize { get; set; }

		[JsonProperty("guidedMinLobbySize")]
		public int GuidedMinLobbySize { get; set; }

		[JsonProperty("guidedDisbandCount")]
		public int GuidedDisbandCount { get; set; }
	}
}
