using System.Collections.Generic;
using System.Globalization;

namespace PrismMahAppsSample.Infrastructure.Interfaces
{
    public interface ILocalizerService
    {
        /// <summary>
        /// Set localization
        /// </summary>
        /// <param name="locale"></param>
        void SetLocale(string locale);

        /// <summary>
        /// Set localization
        /// </summary>
        /// <param name="culture"></param>
        void SetLocale(CultureInfo culture);

        /// <summary>
        /// Get a localized string by key
        /// </summary>
        /// <param name="key">The key</param>
        /// <returns></returns>
        string GetLocalizedString(string key);

        /// <summary>
        /// Supported languages
        /// </summary>
        IList<CultureInfo> SupportedLanguages { get; }

        /// <summary>
        /// The current selected language
        /// </summary>
        CultureInfo SelectedLanguage { get; set; }
    }
}