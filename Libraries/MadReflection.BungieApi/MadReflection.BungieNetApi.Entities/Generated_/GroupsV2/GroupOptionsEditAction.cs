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
	public partial class GroupOptionsEditAction
	{
		[JsonProperty("InvitePermissionOverride")]
		public bool? InvitePermissionOverride { get; set; }

		[JsonProperty("UpdateCulturePermissionOverride")]
		public bool? UpdateCulturePermissionOverride { get; set; }

		[JsonProperty("HostGuidedGamePermissionOverride")]
		public GroupsV2.HostGuidedGamesPermissionLevel? HostGuidedGamePermissionOverride { get; set; }

		[JsonProperty("UpdateBannerPermissionOverride")]
		public bool? UpdateBannerPermissionOverride { get; set; }

		[JsonProperty("JoinLevel")]
		public GroupsV2.RuntimeGroupMemberType? JoinLevel { get; set; }
	}
}
