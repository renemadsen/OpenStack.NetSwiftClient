using System;
using System.Collections.Generic;
using System.Text;

namespace NetSwiftClient.Models
{
    public class SwiftAuthV2Response : SwiftBaseResponse
    {
        //public string Token { get { string token = null; thi; return token; } }
        public DateTime? TokenExpires => ContentObject?.Access?.Token?.Expires;

        public string ContentStr { get; set; }
        public TokenContainerObject ContentObject { get; set; }

        public class TokenContainerObject
        {
            public AccessObject Access { get; set; }
        }

        public class AccessObject
        {
            public TokenObject Token { get; set; }
            public List<string> ServiceCatalog { get; set; }
            public UserObject User { get; set; }
            public MetaDataObject MetaData { get; set; }
        }

        public class TokenObject
        {
            public DateTime? IssuedAt { get; set; }
            public DateTime? Expires { get; set; }
            public string Id { get; set; }
            public List<string> AuditIds { get; set; }
        }

        public class UserObject
        {
            public string UserName { get; set; }
            public List<string> RoleLinks { get; set; }
            public string Id { get; set; }
            public List<string> Roles { get; set; }
            public string Name { get; set; }
         }

        public class MetaDataObject
        {
            public bool IsAdmin { get; set; }
            public List<string> Roles { get; set; }
        }
    }
}

// https://developer.openstack.org/api-ref/identity/v3/

//{
//    "access": {
//        "token": {
//            "issued_at": "2019-03-06T09:49:42.498361",
//            "expires": "2019-03-06T10:49:42Z",
//            "id": "8bd4d8b942f74164a1eac849c8d591c8",
//            "audit_ids": [
//                "HurLktAJR3y4wQrvgMcrcA"
//            ]
//        },
//        "serviceCatalog": [],
//        "user": {
//            "username": "admin",
//            "roles_links": [],
//            "id": "4a113f1afc42470cb6ffb5dee46d56dc",
//            "roles": [],
//            "name": "admin"
//        },
//        "metadata": {
//            "is_admin": 0,
//            "roles": []
//        }
//    }
//}

//Success¶
//Code Reason
//201 - Created Resource was created and is ready to use.
//Error¶
//Code Reason
//400 - Bad Request   Some content in the request was invalid.
//401 - Unauthorized User must authenticate before making a request.
//403 - Forbidden Policy does not allow current user to do this operation.
//404 - Not Found The requested resource could not be found.
//405 - Method Not Allowed Method is not valid for this endpoint.
//409 - Conflict This operation conflicted with another operation on this resource.
//413 - Request Entity Too Large  The request is larger than the server is willing or able to process.
//415 - Unsupported Media Type The request entity has a media type which the server or resource does not support.
//503 - Service Unavailable   Service is not available. This is mostly caused by service configuration errors which prevents the service from successful start up.