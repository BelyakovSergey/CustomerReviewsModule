using System.Collections.Generic;
using VirtoCommerce.Platform.Core.Settings;

namespace CustomerReviewsModule.Core
{
    public static class ModuleConstants
    {
        public static class Security
        {
            public static class Permissions
            {
                public const string Read = "customerReviews:read";
                public const string Update = "customerReviews:update";
                public const string Delete = "customerReviews:delete";

                public static string[] AllPermissions { get; } = { Read, Update, Delete };
            }
        }

        public static class Settings
        {
            public static class General
            {
                public static SettingDescriptor CustomerReviewsEnabled { get; } = new SettingDescriptor
                {
                    Name = "CustomerReviews.CustomerReviewsEnabled",
                    GroupName = "Store|General",
                    ValueType = SettingValueType.Boolean,
                    DefaultValue = false
                };

                public static IEnumerable<SettingDescriptor> AllSettings
                {
                    get
                    {
                        yield return CustomerReviewsEnabled;
                    }
                }
            }

            public static IEnumerable<SettingDescriptor> AllSettings
            {
                get
                {
                    return General.AllSettings;
                }
            }
        }
    }
}
