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

namespace BungieNet.Destiny.HistoricalStats
{
	public partial class DestinyHistoricalStatsPerCharacter
	{
		[JsonProperty("characterId")]
		public long CharacterId { get; set; }

		[JsonProperty("deleted")]
		public bool Deleted { get; set; }

		[JsonProperty("results")]
		public System.Collections.Generic.Dictionary<string, Destiny.HistoricalStats.DestinyHistoricalStatsByPeriod> Results { get; set; }

		[JsonProperty("merged")]
		public Destiny.HistoricalStats.DestinyHistoricalStatsByPeriod Merged { get; set; }
	}
}
