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

namespace BungieNet.Destiny.Components.Presentation
{
	public partial class DestinyPresentationNodeComponent
	{
		[JsonProperty("state")]
		public Destiny.DestinyPresentationNodeState State { get; set; }

		[JsonProperty("objective")]
		public Destiny.Quests.DestinyObjectiveProgress Objective { get; set; }

		[JsonProperty("progressValue")]
		public int ProgressValue { get; set; }

		[JsonProperty("completionValue")]
		public int CompletionValue { get; set; }
	}
}