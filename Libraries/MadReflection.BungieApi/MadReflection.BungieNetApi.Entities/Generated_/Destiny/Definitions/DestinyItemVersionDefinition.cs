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
	/// The version definition currently just holds a reference to the power cap.
	/// </summary>
	public partial class DestinyItemVersionDefinition
	{
		[JsonProperty("powerCapHash")]
		public uint PowerCapHash { get; set; }
	}
}