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

namespace BungieNet.Destiny
{
	/// <summary>
	/// Information about a current character's status with a Progression. A progression is a value that can increase with activity and has levels. Think Character Level and Reputation Levels. Combine this "live" data with the related DestinyProgressionDefinition for a full picture of the Progression.
	/// </summary>
	public partial class DestinyProgression
	{
		[JsonProperty("progressionHash")]
		public uint ProgressionHash { get; set; }

		[JsonProperty("dailyProgress")]
		public int DailyProgress { get; set; }

		[JsonProperty("dailyLimit")]
		public int DailyLimit { get; set; }

		[JsonProperty("weeklyProgress")]
		public int WeeklyProgress { get; set; }

		[JsonProperty("weeklyLimit")]
		public int WeeklyLimit { get; set; }

		[JsonProperty("currentProgress")]
		public int CurrentProgress { get; set; }

		[JsonProperty("level")]
		public int Level { get; set; }

		[JsonProperty("levelCap")]
		public int LevelCap { get; set; }

		[JsonProperty("stepIndex")]
		public int StepIndex { get; set; }

		[JsonProperty("progressToNextLevel")]
		public int ProgressToNextLevel { get; set; }

		[JsonProperty("nextLevelAt")]
		public int NextLevelAt { get; set; }

		[JsonProperty("currentResetCount")]
		public int? CurrentResetCount { get; set; }

		[JsonProperty("seasonResets")]
		public Destiny.DestinyProgressionResetEntry[] SeasonResets { get; set; }
	}
}
