//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4971
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Urlshortener.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class AnalyticsSnapshot {
        
        private System.Collections.Generic.IList<StringCount> _browsers;
        
        private System.Collections.Generic.IList<StringCount> _countries;
        
        private string _longUrlClicks;
        
        private System.Collections.Generic.IList<StringCount> _platforms;
        
        private System.Collections.Generic.IList<StringCount> _referrers;
        
        private string _shortUrlClicks;
        
        /// <summary>Top browsers, e.g. &quot;Chrome&quot;; sorted by (descending) click counts. Only present if this data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browsers")]
        public virtual System.Collections.Generic.IList<StringCount> Browsers {
            get {
                return this._browsers;
            }
            set {
                this._browsers = value;
            }
        }
        
        /// <summary>Top countries (expressed as country codes), e.g. &quot;US&quot; or &quot;DE&quot;; sorted by (descending) click counts. Only present if this data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countries")]
        public virtual System.Collections.Generic.IList<StringCount> Countries {
            get {
                return this._countries;
            }
            set {
                this._countries = value;
            }
        }
        
        /// <summary>Number of clicks on all goo.gl short URLs pointing to this long URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longUrlClicks")]
        public virtual string LongUrlClicks {
            get {
                return this._longUrlClicks;
            }
            set {
                this._longUrlClicks = value;
            }
        }
        
        /// <summary>Top platforms or OSes, e.g. &quot;Windows&quot;; sorted by (descending) click counts. Only present if this data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platforms")]
        public virtual System.Collections.Generic.IList<StringCount> Platforms {
            get {
                return this._platforms;
            }
            set {
                this._platforms = value;
            }
        }
        
        /// <summary>Top referring hosts, e.g. &quot;www.google.com&quot;; sorted by (descending) click counts. Only present if this data is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("referrers")]
        public virtual System.Collections.Generic.IList<StringCount> Referrers {
            get {
                return this._referrers;
            }
            set {
                this._referrers = value;
            }
        }
        
        /// <summary>Number of clicks on this short URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortUrlClicks")]
        public virtual string ShortUrlClicks {
            get {
                return this._shortUrlClicks;
            }
            set {
                this._shortUrlClicks = value;
            }
        }
    }
    
    public class AnalyticsSummary {
        
        private AnalyticsSnapshot _allTime;
        
        private AnalyticsSnapshot _day;
        
        private AnalyticsSnapshot _month;
        
        private AnalyticsSnapshot _twoHours;
        
        private AnalyticsSnapshot _week;
        
        [Newtonsoft.Json.JsonPropertyAttribute("allTime")]
        public virtual AnalyticsSnapshot AllTime {
            get {
                return this._allTime;
            }
            set {
                this._allTime = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual AnalyticsSnapshot Day {
            get {
                return this._day;
            }
            set {
                this._day = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual AnalyticsSnapshot Month {
            get {
                return this._month;
            }
            set {
                this._month = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("twoHours")]
        public virtual AnalyticsSnapshot TwoHours {
            get {
                return this._twoHours;
            }
            set {
                this._twoHours = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("week")]
        public virtual AnalyticsSnapshot Week {
            get {
                return this._week;
            }
            set {
                this._week = value;
            }
        }
    }
    
    public class StringCount {
        
        private string _count;
        
        private string _id;
        
        /// <summary>Number of clicks for this top entry, e.g. for this particular country or browser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual string Count {
            get {
                return this._count;
            }
            set {
                this._count = value;
            }
        }
        
        /// <summary>Label assigned to this top entry, e.g. &quot;US&quot; or &quot;Chrome&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
    }
    
    public class Url : Google.Apis.Requests.IDirectResponseSchema {
        
        private AnalyticsSummary _analytics;
        
        private string _created;
        
        private string _id;
        
        private string _kind;
        
        private string _longUrl;
        
        private string _status;
        
        private string _ETag;
        
        [Newtonsoft.Json.JsonPropertyAttribute("analytics")]
        public virtual AnalyticsSummary Analytics {
            get {
                return this._analytics;
            }
            set {
                this._analytics = value;
            }
        }
        
        /// <summary>Time the short URL was created; ISO 8601 representation using the yyyy-MM-dd&apos;T&apos;HH:mm:ss.SSSZZ format, e.g. &quot;2010-10-14T19:01:24.944+00:00&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("created")]
        public virtual string Created {
            get {
                return this._created;
            }
            set {
                this._created = value;
            }
        }
        
        /// <summary>Short URL, e.g. &quot;http://goo.gl/l6MS&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        /// <summary>The fixed string &quot;urlshortener#url&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        /// <summary>Long URL, e.g. &quot;http://www.google.com/&quot;. Might not be present if the status is &quot;REMOVED&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longUrl")]
        public virtual string LongUrl {
            get {
                return this._longUrl;
            }
            set {
                this._longUrl = value;
            }
        }
        
        /// <summary>Status of the target URL. Possible values: &quot;OK&quot;, &quot;MALWARE&quot;, &quot;PHISHING&quot;, or &quot;REMOVED&quot;. A URL might be marked &quot;REMOVED&quot; if it was flagged as spam, for example.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status {
            get {
                return this._status;
            }
            set {
                this._status = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
    
    public class UrlHistory : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Collections.Generic.IList<Url> _items;
        
        private System.Nullable<long> _itemsPerPage;
        
        private string _kind;
        
        private string _nextPageToken;
        
        private System.Nullable<long> _totalItems;
        
        private string _ETag;
        
        /// <summary>A list of URL resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Url> Items {
            get {
                return this._items;
            }
            set {
                this._items = value;
            }
        }
        
        /// <summary>Number of items returned with each full &quot;page&quot; of results. Note that the last page could have fewer items than the &quot;itemsPerPage&quot; value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("itemsPerPage")]
        public virtual System.Nullable<long> ItemsPerPage {
            get {
                return this._itemsPerPage;
            }
            set {
                this._itemsPerPage = value;
            }
        }
        
        /// <summary>The fixed string &quot;urlshortener#urlHistory&quot;.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        /// <summary>A token to provide to get the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken {
            get {
                return this._nextPageToken;
            }
            set {
                this._nextPageToken = value;
            }
        }
        
        /// <summary>Total number of short URLs associated with this user (may be approximate).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalItems")]
        public virtual System.Nullable<long> TotalItems {
            get {
                return this._totalItems;
            }
            set {
                this._totalItems = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
}
namespace Google.Apis.Urlshortener.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class UrlshortenerService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService _service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"etag\":\"\\\"a3GBuXuTtUYW9BV1SIieU5LiL7w/0MOFQ6j" +
            "BwyogxEWX4FW8QZIeEDM\\\"\",\"discoveryVersion\":\"v1\",\"id\":\"urlshortener:v1\",\"name\":\"u" +
            "rlshortener\",\"version\":\"v1\",\"title\":\"URL Shortener API\",\"description\":\"Lets you " +
            "create, inspect, and manage goo.gl short URLs\",\"icons\":{\"x16\":\"http://www.google" +
            ".com/images/icons/product/search-16.gif\",\"x32\":\"http://www.google.com/images/ico" +
            "ns/product/search-32.gif\"},\"documentationLink\":\"http://code.google.com/apis/urls" +
            "hortener/v1/getting_started.html\",\"protocol\":\"rest\",\"baseUrl\":\"https://www.googl" +
            "eapis.com/urlshortener/v1/\",\"basePath\":\"/urlshortener/v1/\",\"rootUrl\":\"https://ww" +
            "w.googleapis.com/\",\"servicePath\":\"urlshortener/v1/\",\"batchPath\":\"batch\",\"paramet" +
            "ers\":{\"alt\":{\"type\":\"string\",\"description\":\"Data format for the response.\",\"defa" +
            "ult\":\"json\",\"enum\":[\"json\"],\"enumDescriptions\":[\"Responses with Content-Type of " +
            "application/json\"],\"location\":\"query\"},\"fields\":{\"type\":\"string\",\"description\":\"" +
            "Selector specifying which fields to include in a partial response.\",\"location\":\"" +
            "query\"},\"key\":{\"type\":\"string\",\"description\":\"API key. Your API key identifies y" +
            "our project and provides you with API access, quota, and reports. Required unles" +
            "s you provide an OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_token\":{\"type\":\"st" +
            "ring\",\"description\":\"OAuth 2.0 token for the current user.\",\"location\":\"query\"}," +
            "\"prettyPrint\":{\"type\":\"boolean\",\"description\":\"Returns response with indentation" +
            "s and line breaks.\",\"default\":\"true\",\"location\":\"query\"},\"quotaUser\":{\"type\":\"st" +
            "ring\",\"description\":\"Available to use for quota purposes for server-side applica" +
            "tions. Can be any arbitrary string assigned to a user, but should not exceed 40 " +
            "characters. Overrides userIp if both are provided.\",\"location\":\"query\"},\"userIp\"" +
            ":{\"type\":\"string\",\"description\":\"IP address of the site where the request origin" +
            "ates. Use this if you want to enforce per-user limits.\",\"location\":\"query\"}},\"au" +
            "th\":{\"oauth2\":{\"scopes\":{\"https://www.googleapis.com/auth/urlshortener\":{\"descri" +
            "ption\":\"Manage your goo.gl short URLs\"}}}},\"schemas\":{\"AnalyticsSnapshot\":{\"id\":" +
            "\"AnalyticsSnapshot\",\"type\":\"object\",\"properties\":{\"browsers\":{\"type\":\"array\",\"de" +
            "scription\":\"Top browsers, e.g. \\\"Chrome\\\"; sorted by (descending) click counts. " +
            "Only present if this data is available.\",\"items\":{\"$ref\":\"StringCount\"}},\"countr" +
            "ies\":{\"type\":\"array\",\"description\":\"Top countries (expressed as country codes), " +
            "e.g. \\\"US\\\" or \\\"DE\\\"; sorted by (descending) click counts. Only present if this" +
            " data is available.\",\"items\":{\"$ref\":\"StringCount\"}},\"longUrlClicks\":{\"type\":\"st" +
            "ring\",\"description\":\"Number of clicks on all goo.gl short URLs pointing to this " +
            "long URL.\",\"format\":\"int64\"},\"platforms\":{\"type\":\"array\",\"description\":\"Top plat" +
            "forms or OSes, e.g. \\\"Windows\\\"; sorted by (descending) click counts. Only prese" +
            "nt if this data is available.\",\"items\":{\"$ref\":\"StringCount\"}},\"referrers\":{\"typ" +
            "e\":\"array\",\"description\":\"Top referring hosts, e.g. \\\"www.google.com\\\"; sorted b" +
            "y (descending) click counts. Only present if this data is available.\",\"items\":{\"" +
            "$ref\":\"StringCount\"}},\"shortUrlClicks\":{\"type\":\"string\",\"description\":\"Number of" +
            " clicks on this short URL.\",\"format\":\"int64\"}}},\"AnalyticsSummary\":{\"id\":\"Analyt" +
            "icsSummary\",\"type\":\"object\",\"properties\":{\"allTime\":{\"$ref\":\"AnalyticsSnapshot\"," +
            "\"description\":\"Click analytics over all time.\"},\"day\":{\"$ref\":\"AnalyticsSnapshot" +
            "\",\"description\":\"Click analytics over the last day.\"},\"month\":{\"$ref\":\"Analytics" +
            "Snapshot\",\"description\":\"Click analytics over the last month.\"},\"twoHours\":{\"$re" +
            "f\":\"AnalyticsSnapshot\",\"description\":\"Click analytics over the last two hours.\"}" +
            ",\"week\":{\"$ref\":\"AnalyticsSnapshot\",\"description\":\"Click analytics over the last" +
            " week.\"}}},\"StringCount\":{\"id\":\"StringCount\",\"type\":\"object\",\"properties\":{\"coun" +
            "t\":{\"type\":\"string\",\"description\":\"Number of clicks for this top entry, e.g. for" +
            " this particular country or browser.\",\"format\":\"int64\"},\"id\":{\"type\":\"string\",\"d" +
            "escription\":\"Label assigned to this top entry, e.g. \\\"US\\\" or \\\"Chrome\\\".\"}}},\"U" +
            "rl\":{\"id\":\"Url\",\"type\":\"object\",\"properties\":{\"analytics\":{\"$ref\":\"AnalyticsSumm" +
            "ary\",\"description\":\"A summary of the click analytics for the short and long URL." +
            " Might not be present if not requested or currently unavailable.\"},\"created\":{\"t" +
            "ype\":\"string\",\"description\":\"Time the short URL was created; ISO 8601 representa" +
            "tion using the yyyy-MM-dd\'T\'HH:mm:ss.SSSZZ format, e.g. \\\"2010-10-14T19:01:24.94" +
            "4+00:00\\\".\"},\"id\":{\"type\":\"string\",\"description\":\"Short URL, e.g. \\\"http://goo.g" +
            "l/l6MS\\\".\"},\"kind\":{\"type\":\"string\",\"description\":\"The fixed string \\\"urlshorten" +
            "er#url\\\".\",\"default\":\"urlshortener#url\"},\"longUrl\":{\"type\":\"string\",\"description" +
            "\":\"Long URL, e.g. \\\"http://www.google.com/\\\". Might not be present if the status" +
            " is \\\"REMOVED\\\".\"},\"status\":{\"type\":\"string\",\"description\":\"Status of the target" +
            " URL. Possible values: \\\"OK\\\", \\\"MALWARE\\\", \\\"PHISHING\\\", or \\\"REMOVED\\\". A URL " +
            "might be marked \\\"REMOVED\\\" if it was flagged as spam, for example.\"}}},\"UrlHist" +
            "ory\":{\"id\":\"UrlHistory\",\"type\":\"object\",\"properties\":{\"items\":{\"type\":\"array\",\"d" +
            "escription\":\"A list of URL resources.\",\"items\":{\"$ref\":\"Url\"}},\"itemsPerPage\":{\"" +
            "type\":\"integer\",\"description\":\"Number of items returned with each full \\\"page\\\" " +
            "of results. Note that the last page could have fewer items than the \\\"itemsPerPa" +
            "ge\\\" value.\",\"format\":\"int32\"},\"kind\":{\"type\":\"string\",\"description\":\"The fixed " +
            "string \\\"urlshortener#urlHistory\\\".\",\"default\":\"urlshortener#urlHistory\"},\"nextP" +
            "ageToken\":{\"type\":\"string\",\"description\":\"A token to provide to get the next pag" +
            "e of results.\"},\"totalItems\":{\"type\":\"integer\",\"description\":\"Total number of sh" +
            "ort URLs associated with this user (may be approximate).\",\"format\":\"int32\"}}}},\"" +
            "resources\":{\"url\":{\"methods\":{\"get\":{\"id\":\"urlshortener.url.get\",\"path\":\"url\",\"h" +
            "ttpMethod\":\"GET\",\"description\":\"Expands a short URL or gets creation time and an" +
            "alytics.\",\"parameters\":{\"projection\":{\"type\":\"string\",\"description\":\"Additional " +
            "information to return.\",\"enum\":[\"ANALYTICS_CLICKS\",\"ANALYTICS_TOP_STRINGS\",\"FULL" +
            "\"],\"enumDescriptions\":[\"Returns only click counts.\",\"Returns only top string cou" +
            "nts.\",\"Returns the creation timestamp and all available analytics.\"],\"location\":" +
            "\"query\"},\"shortUrl\":{\"type\":\"string\",\"description\":\"The short URL, including the" +
            " protocol.\",\"required\":true,\"location\":\"query\"}},\"parameterOrder\":[\"shortUrl\"],\"" +
            "response\":{\"$ref\":\"Url\"}},\"insert\":{\"id\":\"urlshortener.url.insert\",\"path\":\"url\"," +
            "\"httpMethod\":\"POST\",\"description\":\"Creates a new short URL.\",\"request\":{\"$ref\":\"" +
            "Url\"},\"response\":{\"$ref\":\"Url\"},\"scopes\":[\"https://www.googleapis.com/auth/urlsh" +
            "ortener\"]},\"list\":{\"id\":\"urlshortener.url.list\",\"path\":\"url/history\",\"httpMethod" +
            "\":\"GET\",\"description\":\"Retrieves a list of URLs shortened by a user.\",\"parameter" +
            "s\":{\"projection\":{\"type\":\"string\",\"description\":\"Additional information to retur" +
            "n.\",\"enum\":[\"ANALYTICS_CLICKS\",\"FULL\"],\"enumDescriptions\":[\"Returns short URL cl" +
            "ick counts.\",\"Returns short URL click counts.\"],\"location\":\"query\"},\"start-token" +
            "\":{\"type\":\"string\",\"description\":\"Token for requesting successive pages of resul" +
            "ts.\",\"location\":\"query\"}},\"response\":{\"$ref\":\"UrlHistory\"},\"scopes\":[\"https://ww" +
            "w.googleapis.com/auth/urlshortener\"]}}}}}";
        
        public const string Version = "v1";
        
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string _Key;
        
        protected UrlshortenerService(Google.Apis.Discovery.IService _service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this._service = _service;
            this._authenticator = _authenticator;
            this._url = new UrlResource(this, _authenticator);
        }
        
        public UrlshortenerService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public UrlshortenerService(Google.Apis.Authentication.IAuthenticator _authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(UrlshortenerService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameters(new System.Uri("https://www.googleapis.com/urlshortener/v1/"))), _authenticator) {
        }
        
        public Google.Apis.Authentication.IAuthenticator Authenticator {
            get {
                return this._authenticator;
            }
        }
        
        public virtual string Name {
            get {
                return "urlshortener";
            }
        }
        
        public virtual string BaseUri {
            get {
                return "https://www.googleapis.com/urlshortener/v1/";
            }
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this._Key;
            }
            set {
                this._Key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this._service.CreateRequest(resource, method);
            if ((string.IsNullOrEmpty(Key) == false)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(_authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            _service.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return _service.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return _service.DeserializeResponse<T>(response);
        }
        
        /// <summary>A list of all OAuth2.0 scopes. Each of these scopes relates to a permission or group of permissions that different methods of this API may need.</summary>
        public enum Scopes {
            
            /// <summary>Manage your goo.gl short URLs</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/urlshortener")]
            Urlshortener,
        }
    }
    
    public class UrlResource {
        
        private UrlshortenerService service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string Resource = "url";
        
        public UrlResource(UrlshortenerService service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this.service = service;
            this._authenticator = _authenticator;
        }
        
        /// <summary>Expands a short URL or gets creation time and analytics.</summary>
        /// <param name="shortUrl">Required - The short URL, including the protocol.</param>
        public virtual GetRequest Get(string shortUrl) {
            return new GetRequest(service, shortUrl);
        }
        
        /// <summary>Creates a new short URL.</summary>
        public virtual InsertRequest Insert(Google.Apis.Urlshortener.v1.Data.Url body) {
            return new InsertRequest(service, body);
        }
        
        /// <summary>Retrieves a list of URLs shortened by a user.</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        /// <summary>Additional information to return.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Projection {
            
            /// <summary>Returns only click counts.</summary>
            [Google.Apis.Util.StringValueAttribute("ANALYTICS_CLICKS")]
            ANALYTICS_CLICKS,
            
            /// <summary>Returns only top string counts.</summary>
            [Google.Apis.Util.StringValueAttribute("ANALYTICS_TOP_STRINGS")]
            ANALYTICS_TOP_STRINGS,
            
            /// <summary>Returns the creation timestamp and all available analytics.</summary>
            [Google.Apis.Util.StringValueAttribute("FULL")]
            FULL,
        }
        
        /// <summary>Additional information to return.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum ProjectionEnum {
            
            /// <summary>Returns short URL click counts.</summary>
            [Google.Apis.Util.StringValueAttribute("ANALYTICS_CLICKS")]
            ANALYTICS_CLICKS,
            
            /// <summary>Returns short URL click counts.</summary>
            [Google.Apis.Util.StringValueAttribute("FULL")]
            FULL,
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Urlshortener.v1.Data.Url> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private System.Nullable<Projection> _projection;
            
            private string _shortUrl;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, string shortUrl) : 
                    base(service) {
                this._shortUrl = shortUrl;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Additional information to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<Projection> Projection {
                get {
                    return this._projection;
                }
                set {
                    this._projection = value;
                }
            }
            
            /// <summary>The short URL, including the protocol.</summary>
            [Google.Apis.Util.RequestParameterAttribute("shortUrl", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ShortUrl {
                get {
                    return this._shortUrl;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "url";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
        
        public class InsertRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Urlshortener.v1.Data.Url> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private Google.Apis.Urlshortener.v1.Data.Url _Body;
            
            public InsertRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Urlshortener.v1.Data.Url body) : 
                    base(service) {
                this.Body = body;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Urlshortener.v1.Data.Url Body {
                get {
                    return this._Body;
                }
                set {
                    this._Body = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "url";
                }
            }
            
            protected override string MethodName {
                get {
                    return "insert";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Urlshortener.v1.Data.UrlHistory> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private System.Nullable<ProjectionEnum> _projection;
            
            private string _startToken;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Additional information to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection {
                get {
                    return this._projection;
                }
                set {
                    this._projection = value;
                }
            }
            
            /// <summary>Token for requesting successive pages of results.</summary>
            [Google.Apis.Util.RequestParameterAttribute("start-token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartToken {
                get {
                    return this._startToken;
                }
                set {
                    this._startToken = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "url";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public partial class UrlshortenerService {
        
        private const string Resource = "";
        
        private UrlResource _url;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual UrlResource Url {
            get {
                return this._url;
            }
        }
    }
}
