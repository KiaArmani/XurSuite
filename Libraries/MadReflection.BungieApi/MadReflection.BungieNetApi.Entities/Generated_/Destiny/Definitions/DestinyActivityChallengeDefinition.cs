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
	/// Represents a reference to a Challenge, which for now is just an Objective.
	/// </summary>
	public partial class DestinyActivityChallengeDefinition
	{
		[JsonProperty("objectiveHash")]
		public uint ObjectiveHash { get; set; }

		[JsonProperty("dummyRewards")]
		public Destiny.DestinyItemQuantity[] DummyRewards { get; set; }
	}
}
