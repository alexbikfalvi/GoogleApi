//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4971
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Androidpublisher.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    /// <summary>A Purchase resource indicates the status of a user&apos;s subscription purchase.</summary>
    public class SubscriptionPurchase : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Nullable<bool> _autoRenewing;
        
        private string _initiationTimestampMsec;
        
        private string _kind;
        
        private string _validUntilTimestampMsec;
        
        private string _ETag;
        
        /// <summary>Whether the subscription will automatically be renewed when it reaches its current expiry time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoRenewing")]
        public virtual System.Nullable<bool> AutoRenewing {
            get {
                return this._autoRenewing;
            }
            set {
                this._autoRenewing = value;
            }
        }
        
        /// <summary>Time at which the subscription was granted, in milliseconds since Epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initiationTimestampMsec")]
        public virtual string InitiationTimestampMsec {
            get {
                return this._initiationTimestampMsec;
            }
            set {
                this._initiationTimestampMsec = value;
            }
        }
        
        /// <summary>This kind represents a subscriptionPurchase object in the androidpublisher service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        /// <summary>Time at which the subscription will expire, in milliseconds since Epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validUntilTimestampMsec")]
        public virtual string ValidUntilTimestampMsec {
            get {
                return this._validUntilTimestampMsec;
            }
            set {
                this._validUntilTimestampMsec = value;
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
namespace Google.Apis.Androidpublisher.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class AndroidpublisherService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService _service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"etag\":\"\\\"a3GBuXuTtUYW9BV1SIieU5LiL7w/w4oNsm9" +
            "WYapQlRAudY0Tr7UlWAU\\\"\",\"discoveryVersion\":\"v1\",\"id\":\"androidpublisher:v1\",\"name" +
            "\":\"androidpublisher\",\"version\":\"v1\",\"revision\":\"20120608\",\"title\":\"Google Play A" +
            "ndroid Developer API\",\"description\":\"Lets Android application developers access " +
            "their Google Play accounts.\",\"icons\":{\"x16\":\"http://www.google.com/images/icons/" +
            "product/android-16.png\",\"x32\":\"http://www.google.com/images/icons/product/androi" +
            "d-32.png\"},\"documentationLink\":\"https://developers.google.com/android-publisher\"" +
            ",\"protocol\":\"rest\",\"baseUrl\":\"https://www.googleapis.com/androidpublisher/v1/app" +
            "lications/\",\"basePath\":\"/androidpublisher/v1/applications/\",\"rootUrl\":\"https://w" +
            "ww.googleapis.com/\",\"servicePath\":\"androidpublisher/v1/applications/\",\"batchPath" +
            "\":\"batch\",\"parameters\":{\"alt\":{\"type\":\"string\",\"description\":\"Data format for th" +
            "e response.\",\"default\":\"json\",\"enum\":[\"json\"],\"enumDescriptions\":[\"Responses wit" +
            "h Content-Type of application/json\"],\"location\":\"query\"},\"fields\":{\"type\":\"strin" +
            "g\",\"description\":\"Selector specifying which fields to include in a partial respo" +
            "nse.\",\"location\":\"query\"},\"key\":{\"type\":\"string\",\"description\":\"API key. Your AP" +
            "I key identifies your project and provides you with API access, quota, and repor" +
            "ts. Required unless you provide an OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_" +
            "token\":{\"type\":\"string\",\"description\":\"OAuth 2.0 token for the current user.\",\"l" +
            "ocation\":\"query\"},\"prettyPrint\":{\"type\":\"boolean\",\"description\":\"Returns respons" +
            "e with indentations and line breaks.\",\"default\":\"true\",\"location\":\"query\"},\"quot" +
            "aUser\":{\"type\":\"string\",\"description\":\"Available to use for quota purposes for s" +
            "erver-side applications. Can be any arbitrary string assigned to a user, but sho" +
            "uld not exceed 40 characters. Overrides userIp if both are provided.\",\"location\"" +
            ":\"query\"},\"userIp\":{\"type\":\"string\",\"description\":\"IP address of the site where " +
            "the request originates. Use this if you want to enforce per-user limits.\",\"locat" +
            "ion\":\"query\"}},\"schemas\":{\"SubscriptionPurchase\":{\"id\":\"SubscriptionPurchase\",\"t" +
            "ype\":\"object\",\"description\":\"A Purchase resource indicates the status of a user\'" +
            "s subscription purchase.\",\"properties\":{\"autoRenewing\":{\"type\":\"boolean\",\"descri" +
            "ption\":\"Whether the subscription will automatically be renewed when it reaches i" +
            "ts current expiry time.\"},\"initiationTimestampMsec\":{\"type\":\"string\",\"descriptio" +
            "n\":\"Time at which the subscription was granted, in milliseconds since Epoch.\",\"f" +
            "ormat\":\"int64\"},\"kind\":{\"type\":\"string\",\"description\":\"This kind represents a su" +
            "bscriptionPurchase object in the androidpublisher service.\",\"default\":\"androidpu" +
            "blisher#subscriptionPurchase\"},\"validUntilTimestampMsec\":{\"type\":\"string\",\"descr" +
            "iption\":\"Time at which the subscription will expire, in milliseconds since Epoch" +
            ".\",\"format\":\"int64\"}}}},\"resources\":{\"purchases\":{\"methods\":{\"cancel\":{\"id\":\"and" +
            "roidpublisher.purchases.cancel\",\"path\":\"{packageName}/subscriptions/{subscriptio" +
            "nId}/purchases/{token}/cancel\",\"httpMethod\":\"POST\",\"description\":\"Cancels a user" +
            "\'s subscription purchase. The subscription remains valid until its expiration ti" +
            "me.\",\"parameters\":{\"packageName\":{\"type\":\"string\",\"description\":\"The package nam" +
            "e of the application for which this subscription was purchased (for example, \'co" +
            "m.some.thing\').\",\"required\":true,\"location\":\"path\"},\"subscriptionId\":{\"type\":\"st" +
            "ring\",\"description\":\"The purchased subscription ID (for example, \'monthly001\').\"" +
            ",\"required\":true,\"location\":\"path\"},\"token\":{\"type\":\"string\",\"description\":\"The " +
            "token provided to the user\'s device when the subscription was purchased.\",\"requi" +
            "red\":true,\"location\":\"path\"}},\"parameterOrder\":[\"packageName\",\"subscriptionId\",\"" +
            "token\"]},\"get\":{\"id\":\"androidpublisher.purchases.get\",\"path\":\"{packageName}/subs" +
            "criptions/{subscriptionId}/purchases/{token}\",\"httpMethod\":\"GET\",\"description\":\"" +
            "Checks whether a user\'s subscription purchase is valid and returns its expiry ti" +
            "me.\",\"parameters\":{\"packageName\":{\"type\":\"string\",\"description\":\"The package nam" +
            "e of the application for which this subscription was purchased (for example, \'co" +
            "m.some.thing\').\",\"required\":true,\"location\":\"path\"},\"subscriptionId\":{\"type\":\"st" +
            "ring\",\"description\":\"The purchased subscription ID (for example, \'monthly001\').\"" +
            ",\"required\":true,\"location\":\"path\"},\"token\":{\"type\":\"string\",\"description\":\"The " +
            "token provided to the user\'s device when the subscription was purchased.\",\"requi" +
            "red\":true,\"location\":\"path\"}},\"parameterOrder\":[\"packageName\",\"subscriptionId\",\"" +
            "token\"],\"response\":{\"$ref\":\"SubscriptionPurchase\"}}}}}}";
        
        public const string Version = "v1";
        
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string _Key;
        
        protected AndroidpublisherService(Google.Apis.Discovery.IService _service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this._service = _service;
            this._authenticator = _authenticator;
            this._purchases = new PurchasesResource(this, _authenticator);
        }
        
        public AndroidpublisherService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public AndroidpublisherService(Google.Apis.Authentication.IAuthenticator _authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(AndroidpublisherService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameters(new System.Uri("https://www.googleapis.com/androidpublisher/v1/applications/"))), _authenticator) {
        }
        
        public Google.Apis.Authentication.IAuthenticator Authenticator {
            get {
                return this._authenticator;
            }
        }
        
        public virtual string Name {
            get {
                return "androidpublisher";
            }
        }
        
        public virtual string BaseUri {
            get {
                return "https://www.googleapis.com/androidpublisher/v1/applications/";
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
    }
    
    public class PurchasesResource {
        
        private AndroidpublisherService service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string Resource = "purchases";
        
        public PurchasesResource(AndroidpublisherService service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this.service = service;
            this._authenticator = _authenticator;
        }
        
        /// <summary>Cancels a user&apos;s subscription purchase. The subscription remains valid until its expiration time.</summary>
        /// <param name="packageName">Required - The package name of the application for which this subscription was purchased (for example, &apos;com.some.thing&apos;).</param>
        /// <param name="subscriptionId">Required - The purchased subscription ID (for example, &apos;monthly001&apos;).</param>
        /// <param name="token">Required - The token provided to the user&apos;s device when the subscription was purchased.</param>
        public virtual CancelRequest Cancel(string packageName, string subscriptionId, string token) {
            return new CancelRequest(service, packageName, subscriptionId, token);
        }
        
        /// <summary>Checks whether a user&apos;s subscription purchase is valid and returns its expiry time.</summary>
        /// <param name="packageName">Required - The package name of the application for which this subscription was purchased (for example, &apos;com.some.thing&apos;).</param>
        /// <param name="subscriptionId">Required - The purchased subscription ID (for example, &apos;monthly001&apos;).</param>
        /// <param name="token">Required - The token provided to the user&apos;s device when the subscription was purchased.</param>
        public virtual GetRequest Get(string packageName, string subscriptionId, string token) {
            return new GetRequest(service, packageName, subscriptionId, token);
        }
        
        public class CancelRequest : Google.Apis.Requests.ServiceRequest<string> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _packageName;
            
            private string _subscriptionId;
            
            private string _token;
            
            public CancelRequest(Google.Apis.Discovery.IRequestProvider service, string packageName, string subscriptionId, string token) : 
                    base(service) {
                this._packageName = packageName;
                this._subscriptionId = subscriptionId;
                this._token = token;
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
            
            /// <summary>The package name of the application for which this subscription was purchased (for example, 'com.some.thing').</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName {
                get {
                    return this._packageName;
                }
            }
            
            /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
            [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SubscriptionId {
                get {
                    return this._subscriptionId;
                }
            }
            
            /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Token {
                get {
                    return this._token;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "purchases";
                }
            }
            
            protected override string MethodName {
                get {
                    return "cancel";
                }
            }
        }
        
        public class GetRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Androidpublisher.v1.Data.SubscriptionPurchase> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _packageName;
            
            private string _subscriptionId;
            
            private string _token;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, string packageName, string subscriptionId, string token) : 
                    base(service) {
                this._packageName = packageName;
                this._subscriptionId = subscriptionId;
                this._token = token;
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
            
            /// <summary>The package name of the application for which this subscription was purchased (for example, 'com.some.thing').</summary>
            [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string PackageName {
                get {
                    return this._packageName;
                }
            }
            
            /// <summary>The purchased subscription ID (for example, 'monthly001').</summary>
            [Google.Apis.Util.RequestParameterAttribute("subscriptionId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SubscriptionId {
                get {
                    return this._subscriptionId;
                }
            }
            
            /// <summary>The token provided to the user's device when the subscription was purchased.</summary>
            [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Token {
                get {
                    return this._token;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "purchases";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
    }
    
    public partial class AndroidpublisherService {
        
        private const string Resource = "";
        
        private PurchasesResource _purchases;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual PurchasesResource Purchases {
            get {
                return this._purchases;
            }
        }
    }
}
