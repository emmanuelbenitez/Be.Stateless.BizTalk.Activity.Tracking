﻿#region Copyright & License

// Copyright © 2012 - 2020 François Chabot
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System.Diagnostics.CodeAnalysis;
using Be.Stateless.BizTalk.Settings;

namespace Be.Stateless.BizTalk
{
	/// <summary>
	/// Single access point for all BizTalk Factory settings coming either from the BizTalkFactory Management Database or SSO
   /// Database.
	/// </summary>
	/// <remarks>
	/// It's purpose is twofold: avoid the dissemination of magic stings all around, on one side, and support mocking and unit
	/// testing, on the other side.
	/// </remarks>
	public static class BizTalkFactorySettings
	{
		public static string ClaimStoreCheckInDirectory => (string) SsoConfigurationReader.Instance.Read(APPLICATION_NAME, CLAIM_STORE_CHECK_IN_DIRECTORY_PROPERTY_NAME);

		public static string ClaimStoreCheckOutDirectory => (string) SsoConfigurationReader.Instance.Read(APPLICATION_NAME, CLAIM_STORE_CHECK_OUT_DIRECTORY_PROPERTY_NAME);

		[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Public API.")]
		public static string TargetEnvironment => (string) SsoConfigurationReader.Instance.Read(APPLICATION_NAME, TARGET_ENVIRONMENT_PROPERTY_NAME);

		internal const string APPLICATION_NAME = "BizTalk.Factory";
		internal const string CLAIM_STORE_CHECK_IN_DIRECTORY_PROPERTY_NAME = "ClaimStoreCheckInDirectory";
		internal const string CLAIM_STORE_CHECK_OUT_DIRECTORY_PROPERTY_NAME = "ClaimStoreCheckOutDirectory";
		private const string TARGET_ENVIRONMENT_PROPERTY_NAME = "TargetEnvironment";
	}
}
