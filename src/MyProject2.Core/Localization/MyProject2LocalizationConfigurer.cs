using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Json;
using Abp.Reflection.Extensions;

namespace MyProject2.Localization
{
    public static class MyProject2LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flags england", isDefault: true));
            //localizationConfiguration.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flags tr"));

            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MyProject2Consts.LocalizationSourceName,
                    new JsonEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MyProject2LocalizationConfigurer).GetAssembly(),
                        "MyProject2.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}