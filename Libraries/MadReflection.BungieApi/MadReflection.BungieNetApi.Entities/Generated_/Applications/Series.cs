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

namespace BungieNet.Applications
{
	public partial class Series
	{
		[JsonProperty("datapoints")]
		public Applications.Datapoint[] Datapoints { get; set; }

		[JsonProperty("target")]
		public string Target { get; set; }
	}
}