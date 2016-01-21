using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTest
{
    class ProviderStrings : Object
    {
        public ProviderStrings();
        public static const String[] kLevelsForSigPacSpainMap = 
        {"0",         "1",         "2",         "3",       "4",
      "MTNSIGPAC",
      "MTN2000",   "MTN2000",   "MTN2000",   "MTN2000", "MTN2000",
      "MTN200",    "MTN200",    "MTN200",
      "MTN25",     "MTN25",
      "ORTOFOTOS", "ORTOFOTOS", "ORTOFOTOS", "ORTOFOTOS" };
        public String GoogleMapsAPIKey;
        // Google version strings
        public String VersionGoogleMap;
        public String VersionGoogleSatellite;
        public String VersionGoogleLabels;
        public String VersionGoogleTerrain;
        public String SecGoogleWord;
        // Google (China) version strings
        public String VersionGoogleMapChina;
        public String VersionGoogleSatelliteChina;
        public String VersionGoogleLabelsChina;
        public String VersionGoogleTerrainChina;
        // Google (Korea) version strings
        public String VersionGoogleMapKorea;
        public String VersionGoogleSatelliteKorea;
        public String VersionGoogleLabelsKorea;
        /// <summary>
        /// Google Maps API generated using http://greatmaps.codeplex.com/
        /// from http://code.google.com/intl/en-us/apis/maps/signup.html
        /// </summary>
        // Yahoo version strings
        public String VersionYahooMap;
        public String VersionYahooSatellite;
        public String VersionYahooLabels;
        // BingMaps
        public String VersionBingMaps;
        // YandexMap
        public String VersionYandexMap;
        /// <summary>
        /// Bing Maps Customer Identification, more info here
        /// http://msdn.microsoft.com/en-us/library/bb924353.aspx
        /// </summary>
        public String BingMapsClientToken;
    }
}
