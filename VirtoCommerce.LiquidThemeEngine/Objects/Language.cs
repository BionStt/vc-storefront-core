using System.Collections.Generic;
using VirtoCommerce.Storefront.Model.Common;

namespace VirtoCommerce.LiquidThemeEngine.Objects
{
    /// <summary>
    /// Represent language for specified culture
    /// </summary>
    public partial class Language : ValueObject
    {
        /// <summary>
        /// culture name format (e.g. en-US)
        /// </summary>
        public string CultureName { get; set; }
        public string NativeName { get; set; }
        /// <summary>
        ///  Gets the ISO 639-2 three-letter code for the language 
        /// </summary>
        public string ThreeLeterLanguageName { get; set; }
        /// <summary>
        ///   Gets the ISO 639-1 two-letter code for the language
        /// </summary>
        public string TwoLetterLanguageName { get; set; }
        /// <summary>
        ///  Gets the two-letter code defined in ISO 3166 for the country/region.
        /// </summary>
        public string TwoLetterRegionName { get; set; }
        /// <summary>
        ///  Gets the three-letter code defined in ISO 3166 for the country/region.
        /// </summary>
        public string ThreeLetterRegionName { get; set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return CultureName;
        }


    }
}
