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
	public partial class DestinyItemInstanceEnergy
	{
		[JsonProperty("energyTypeHash")]
		public uint EnergyTypeHash { get; set; }

		[JsonProperty("energyType")]
		public Destiny.DestinyEnergyType EnergyType { get; set; }

		[JsonProperty("energyCapacity")]
		public int EnergyCapacity { get; set; }

		[JsonProperty("energyUsed")]
		public int EnergyUsed { get; set; }

		[JsonProperty("energyUnused")]
		public int EnergyUnused { get; set; }
	}
}