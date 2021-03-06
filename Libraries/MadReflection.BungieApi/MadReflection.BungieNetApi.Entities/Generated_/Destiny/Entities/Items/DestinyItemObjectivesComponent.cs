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

namespace BungieNet.Destiny.Entities.Items
{
	/// <summary>
	/// Items can have objectives and progression. When you request this block, you will obtain information about any Objectives and progression tied to this item.
	/// </summary>
	public partial class DestinyItemObjectivesComponent
	{
		[JsonProperty("objectives")]
		public Destiny.Quests.DestinyObjectiveProgress[] Objectives { get; set; }

		[JsonProperty("flavorObjective")]
		public Destiny.Quests.DestinyObjectiveProgress FlavorObjective { get; set; }

		[JsonProperty("dateCompleted")]
		public DateTime? DateCompleted { get; set; }
	}
}
