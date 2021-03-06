﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BungieNet.Api
{
	public interface IFireteamClient
	{
		int GetActivePrivateClanFireteamCount(long groupId);
		Task<int> GetActivePrivateClanFireteamCountAsync(long groupId);

		SearchResultOfFireteamSummary GetAvailableClanFireteams(long groupId, Fireteam.FireteamPlatform platform, Fireteam.FireteamActivityType activityType, Fireteam.FireteamDateRange dateRange, Fireteam.FireteamSlotSearch slotFilter, Fireteam.FireteamPublicSearchOption publicOnly, int page, string langFilter);
		Task<SearchResultOfFireteamSummary> GetAvailableClanFireteamsAsync(long groupId, Fireteam.FireteamPlatform platform, Fireteam.FireteamActivityType activityType, Fireteam.FireteamDateRange dateRange, Fireteam.FireteamSlotSearch slotFilter, Fireteam.FireteamPublicSearchOption publicOnly, int page, string langFilter);

		SearchResultOfFireteamSummary SearchPublicAvailableClanFireteams(Fireteam.FireteamPlatform platform, Fireteam.FireteamActivityType activityType, Fireteam.FireteamDateRange dateRange, Fireteam.FireteamSlotSearch slotFilter, int page, string langFilter);
		Task<SearchResultOfFireteamSummary> SearchPublicAvailableClanFireteamsAsync(Fireteam.FireteamPlatform platform, Fireteam.FireteamActivityType activityType, Fireteam.FireteamDateRange dateRange, Fireteam.FireteamSlotSearch slotFilter, int page, string langFilter);

		SearchResultOfFireteamResponse GetMyClanFireteams(long groupId, Fireteam.FireteamPlatform platform, bool includeClosed, int page, bool groupFilter, string langFilter);
		Task<SearchResultOfFireteamResponse> GetMyClanFireteamsAsync(long groupId, Fireteam.FireteamPlatform platform, bool includeClosed, int page, bool groupFilter, string langFilter);

		Fireteam.FireteamResponse GetClanFireteam(long groupId, long fireteamId);
		Task<Fireteam.FireteamResponse> GetClanFireteamAsync(long groupId, long fireteamId);
	}

	partial interface IBungieClient
	{
		IFireteamClient Fireteam { get; }
	}

	partial class BungieClient : IFireteamClient
	{
		public IFireteamClient Fireteam => this;


		int IFireteamClient.GetActivePrivateClanFireteamCount(long groupId) => Fireteam.GetActivePrivateClanFireteamCountAsync(groupId).GetAwaiter().GetResult();
		Task<int> IFireteamClient.GetActivePrivateClanFireteamCountAsync(long groupId)
		{
			string[] pathSegments = new string[] { "Fireteam", "Clan", groupId.ToString(), "ActiveCount" };
			Uri uri = GetEndpointUri(pathSegments, true, null);
			return GetEntityAsync<int>(uri);
		}

		SearchResultOfFireteamSummary IFireteamClient.GetAvailableClanFireteams(long groupId, Fireteam.FireteamPlatform platform, Fireteam.FireteamActivityType activityType, Fireteam.FireteamDateRange dateRange, Fireteam.FireteamSlotSearch slotFilter, Fireteam.FireteamPublicSearchOption publicOnly, int page, string langFilter) => Fireteam.GetAvailableClanFireteamsAsync(groupId, platform, activityType, dateRange, slotFilter, publicOnly, page, langFilter).GetAwaiter().GetResult();
		Task<SearchResultOfFireteamSummary> IFireteamClient.GetAvailableClanFireteamsAsync(long groupId, Fireteam.FireteamPlatform platform, Fireteam.FireteamActivityType activityType, Fireteam.FireteamDateRange dateRange, Fireteam.FireteamSlotSearch slotFilter, Fireteam.FireteamPublicSearchOption publicOnly, int page, string langFilter)
		{
			string[] pathSegments = new string[] { "Fireteam", "Clan", groupId.ToString(), "Available", ((byte)platform).ToString(), ((int)activityType).ToString(), ((byte)dateRange).ToString(), ((byte)slotFilter).ToString(), ((byte)publicOnly).ToString(), page.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("langFilter", (langFilter ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, true, queryItems);
			return GetEntityAsync<SearchResultOfFireteamSummary>(uri);
		}

		SearchResultOfFireteamSummary IFireteamClient.SearchPublicAvailableClanFireteams(Fireteam.FireteamPlatform platform, Fireteam.FireteamActivityType activityType, Fireteam.FireteamDateRange dateRange, Fireteam.FireteamSlotSearch slotFilter, int page, string langFilter) => Fireteam.SearchPublicAvailableClanFireteamsAsync(platform, activityType, dateRange, slotFilter, page, langFilter).GetAwaiter().GetResult();
		Task<SearchResultOfFireteamSummary> IFireteamClient.SearchPublicAvailableClanFireteamsAsync(Fireteam.FireteamPlatform platform, Fireteam.FireteamActivityType activityType, Fireteam.FireteamDateRange dateRange, Fireteam.FireteamSlotSearch slotFilter, int page, string langFilter)
		{
			string[] pathSegments = new string[] { "Fireteam", "Search", "Available", ((byte)platform).ToString(), ((int)activityType).ToString(), ((byte)dateRange).ToString(), ((byte)slotFilter).ToString(), page.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("langFilter", (langFilter ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, true, queryItems);
			return GetEntityAsync<SearchResultOfFireteamSummary>(uri);
		}

		SearchResultOfFireteamResponse IFireteamClient.GetMyClanFireteams(long groupId, Fireteam.FireteamPlatform platform, bool includeClosed, int page, bool groupFilter, string langFilter) => Fireteam.GetMyClanFireteamsAsync(groupId, platform, includeClosed, page, groupFilter, langFilter).GetAwaiter().GetResult();
		Task<SearchResultOfFireteamResponse> IFireteamClient.GetMyClanFireteamsAsync(long groupId, Fireteam.FireteamPlatform platform, bool includeClosed, int page, bool groupFilter, string langFilter)
		{
			string[] pathSegments = new string[] { "Fireteam", "Clan", groupId.ToString(), "My", ((byte)platform).ToString(), includeClosed.ToString(), page.ToString() };
			System.Collections.Generic.List<QueryStringItem> queryItems = new System.Collections.Generic.List<QueryStringItem>()
			{
				new QueryStringItem("groupFilter", groupFilter.ToString().ToLower()),
				new QueryStringItem("langFilter", (langFilter ?? ""))
			};
			Uri uri = GetEndpointUri(pathSegments, true, queryItems);
			return GetEntityAsync<SearchResultOfFireteamResponse>(uri);
		}

		Fireteam.FireteamResponse IFireteamClient.GetClanFireteam(long groupId, long fireteamId) => Fireteam.GetClanFireteamAsync(groupId, fireteamId).GetAwaiter().GetResult();
		Task<Fireteam.FireteamResponse> IFireteamClient.GetClanFireteamAsync(long groupId, long fireteamId)
		{
			string[] pathSegments = new string[] { "Fireteam", "Clan", groupId.ToString(), "Summary", fireteamId.ToString() };
			Uri uri = GetEndpointUri(pathSegments, true, null);
			return GetEntityAsync<Fireteam.FireteamResponse>(uri);
		}
	}
}
