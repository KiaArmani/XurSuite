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

namespace BungieNet.Destiny.Entities.Characters
{
	/// <summary>
	/// This component contains base properties of the character. You'll probably want to always request this component, but hey you do you.
	/// </summary>
	public partial class DestinyCharacterComponent
	{
		[JsonProperty("membershipId")]
		public long MembershipId { get; set; }

		[JsonProperty("membershipType")]
		public BungieMembershipType MembershipType { get; set; }

		[JsonProperty("characterId")]
		public long CharacterId { get; set; }

		[JsonProperty("dateLastPlayed")]
		public DateTime DateLastPlayed { get; set; }

		[JsonProperty("minutesPlayedThisSession")]
		public long MinutesPlayedThisSession { get; set; }

		[JsonProperty("minutesPlayedTotal")]
		public long MinutesPlayedTotal { get; set; }

		[JsonProperty("light")]
		public int Light { get; set; }

		[JsonProperty("stats")]
		public System.Collections.Generic.Dictionary<uint, int> Stats { get; set; }

		[JsonProperty("raceHash")]
		public uint RaceHash { get; set; }

		[JsonProperty("genderHash")]
		public uint GenderHash { get; set; }

		[JsonProperty("classHash")]
		public uint ClassHash { get; set; }

		[JsonProperty("raceType")]
		public Destiny.DestinyRace RaceType { get; set; }

		[JsonProperty("classType")]
		public Destiny.DestinyClass ClassType { get; set; }

		[JsonProperty("genderType")]
		public Destiny.DestinyGender GenderType { get; set; }

		[JsonProperty("emblemPath")]
		public string EmblemPath { get; set; }

		[JsonProperty("emblemBackgroundPath")]
		public string EmblemBackgroundPath { get; set; }

		[JsonProperty("emblemHash")]
		public uint EmblemHash { get; set; }

		[JsonProperty("emblemColor")]
		public Destiny.Misc.DestinyColor EmblemColor { get; set; }

		[JsonProperty("levelProgression")]
		public Destiny.DestinyProgression LevelProgression { get; set; }

		[JsonProperty("baseCharacterLevel")]
		public int BaseCharacterLevel { get; set; }

		[JsonProperty("percentToNextLevel")]
		public decimal PercentToNextLevel { get; set; }

		[JsonProperty("titleRecordHash")]
		public uint? TitleRecordHash { get; set; }
	}
}
