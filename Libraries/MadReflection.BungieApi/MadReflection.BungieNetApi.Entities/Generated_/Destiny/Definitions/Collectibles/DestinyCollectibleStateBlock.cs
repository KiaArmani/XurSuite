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

namespace BungieNet.Destiny.Definitions.Collectibles
{
	public partial class DestinyCollectibleStateBlock
	{
		[JsonProperty("obscuredOverrideItemHash")]
		public uint? ObscuredOverrideItemHash { get; set; }

		[JsonProperty("requirements")]
		public Destiny.Definitions.Presentation.DestinyPresentationNodeRequirementsBlock Requirements { get; set; }
	}
}
