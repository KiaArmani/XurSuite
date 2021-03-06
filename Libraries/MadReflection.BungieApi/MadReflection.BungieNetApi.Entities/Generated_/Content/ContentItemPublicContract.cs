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

namespace BungieNet.Content
{
	public partial class ContentItemPublicContract
	{
		[JsonProperty("contentId")]
		public long ContentId { get; set; }

		[JsonProperty("cType")]
		public string CType { get; set; }

		[JsonProperty("cmsPath")]
		public string CmsPath { get; set; }

		[JsonProperty("creationDate")]
		public DateTime CreationDate { get; set; }

		[JsonProperty("modifyDate")]
		public DateTime ModifyDate { get; set; }

		[JsonProperty("allowComments")]
		public bool AllowComments { get; set; }

		[JsonProperty("hasAgeGate")]
		public bool HasAgeGate { get; set; }

		[JsonProperty("minimumAge")]
		public int MinimumAge { get; set; }

		[JsonProperty("ratingImagePath")]
		public string RatingImagePath { get; set; }

		[JsonProperty("author")]
		public User.GeneralUser Author { get; set; }

		[JsonProperty("autoEnglishPropertyFallback")]
		public bool AutoEnglishPropertyFallback { get; set; }

		[JsonProperty("properties")]
		public System.Collections.Generic.Dictionary<string, object> Properties { get; set; }

		[JsonProperty("representations")]
		public Content.ContentRepresentation[] Representations { get; set; }

		[JsonProperty("tags")]
		public string[] Tags { get; set; }

		[JsonProperty("commentSummary")]
		public Content.CommentSummary CommentSummary { get; set; }
	}
}
