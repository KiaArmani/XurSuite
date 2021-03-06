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

namespace BungieNet.GroupsV2
{
	/// <summary>
	/// A small infocard of group information, usually used for when a list of groups are returned
	/// </summary>
	public partial class GroupV2Card
	{
		[JsonProperty("groupId")]
		public long GroupId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("groupType")]
		public GroupsV2.GroupType GroupType { get; set; }

		[JsonProperty("creationDate")]
		public DateTime CreationDate { get; set; }

		[JsonProperty("about")]
		public string About { get; set; }

		[JsonProperty("motto")]
		public string Motto { get; set; }

		[JsonProperty("memberCount")]
		public int MemberCount { get; set; }

		[JsonProperty("locale")]
		public string Locale { get; set; }

		[JsonProperty("membershipOption")]
		public GroupsV2.MembershipOption MembershipOption { get; set; }

		[JsonProperty("capabilities")]
		public GroupsV2.Capabilities Capabilities { get; set; }

		[JsonProperty("clanInfo")]
		public GroupsV2.GroupV2ClanInfo ClanInfo { get; set; }

		[JsonProperty("avatarPath")]
		public string AvatarPath { get; set; }

		[JsonProperty("theme")]
		public string Theme { get; set; }
	}
}
