using Plugin.Settings.Abstractions;
using Plugin.Settings;
using System;

namespace Settings
{
	public static class Settings
	{
		public static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

		public const string SettingsKey = "settings_key";
		static readonly string SettingsDefault = string.Empty;

		const string FirstRunKey = "first_run_key";
		const bool FirstRunDefault = true;

		const string RandomIntKey = "random_int_key";
		const int RandomIntDefault = 5;

	    public static string GeneralSetting
	    {
	      get
	      {
	        return AppSettings.GetValueOrDefault<string>(SettingsKey, SettingsDefault);
	      }
	      set
	      {
	        AppSettings.AddOrUpdateValue<string>(SettingsKey, value);
	      }
	    }

		public static bool FirstRun
		{
			get
			{
				return AppSettings.GetValueOrDefault<bool>(FirstRunKey, FirstRunDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue<bool>(FirstRunKey, value);
			}
		}

		public static int RandomInt
		{
			get
			{
				return AppSettings.GetValueOrDefault<int>(RandomIntKey, RandomIntDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue<int>(RandomIntKey, value);
			}
		}
	}

}