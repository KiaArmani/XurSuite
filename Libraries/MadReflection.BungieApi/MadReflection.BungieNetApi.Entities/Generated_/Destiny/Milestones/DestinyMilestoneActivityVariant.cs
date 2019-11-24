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
	/// Represents custom data that we know about an individual variant of an activity.
	/// </summary>
	public partial class DestinyMilestoneActivityVariant
	{
		[JsonProperty("activityHash")]
		public uint ActivityHash { get; set; }

		[JsonProperty("completionStatus")]
		public Destiny.Milestones.DestinyMilestoneActivityCompletionStatus CompletionStatus { get; set; }

		[JsonProperty("activityModeHash")]
		public uint? ActivityModeHash { get; set; }

		[JsonProperty("activityModeType")]
		public Destiny.HistoricalStats.Definitions.DestinyActivityModeType? ActivityModeType { get; set; }
	}
}