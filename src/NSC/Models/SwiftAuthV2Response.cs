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
            public List<ServiceCatalogObject> ServiceCatalog { get; set; }
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
            public List<UserRoleObject> Roles { get; set; }
            public string Name { get; set; }
         }

        public class MetaDataObject
        {
            public bool IsAdmin { get; set; }
            public List<string> Roles { get; set; }
        }

        public class ServiceCatalogObject
        {
            public List<EndPoingObject> EndPoints { get; set; }
            public List<string> EndpointsLinks { get; set; }
            public string Type { get; set; }
            public string Name { get; set; }
        }

        public class EndPoingObject
        {
            public string AdminURL { get; set; }
            public string Region { get; set; }
            public string InternalURL { get; set; }
            public string Id { get; set; }
            public string PublicURL { get; set; }
        }

        public class UserRoleObject
        {
            public string Name { get; set; }
        }
    }
}

// https://developer.openstack.org/api-ref/identity/v3/

//{
//    "access": {
//        "token": {
//            "issued_at": "2019-03-07T06:03:26.380381",
//            "expires": "2019-03-07T07:03:26Z",
//            "id": "1da9c740d94647f79b07fc7120edfb03",
//            "tenant": {
//                "description": "admin tenant",
//                "enabled": true,
//                "id": "0147e64cf52c45499e89893846c51ff2",
//                "name": "admin"
//            },
//            "audit_ids": [
//                "jDWnqnXxQGeofhgetarQUw"
//            ]
//        },
//        "serviceCatalog": [
//            {
//                "endpoints": [
//                    {
//                        "adminURL": "http://192.168.0.2:8774/v2/0147e64cf52c45499e89893846c51ff2",
//                        "region": "RegionOne",
//                        "internalURL": "http://192.168.0.2:8774/v2/0147e64cf52c45499e89893846c51ff2",
//                        "id": "4948625c2fc44fd99883c080c7feaac8",
//                        "publicURL": "http://172.16.4.4:8774/v2/0147e64cf52c45499e89893846c51ff2"
//                    }
//                ],
//                "endpoints_links": [],
//                "type": "compute",
//                "name": "nova"
//            },
//            {
//                "endpoints": [
//                    {
//                        "adminURL": "http://192.168.0.2:9696",
//                        "region": "RegionOne",
//                        "internalURL": "http://192.168.0.2:9696",
//                        "id": "00d01e3d37ad44ffab7367cf7b78ce3f",
//                        "publicURL": "http://172.16.4.4:9696"
//                    }
//                ],
//                "endpoints_links": [],
//                "type": "network",
//                "name": "neutron"
//            },
//            {
//                "endpoints": [
//                    {
//                        "adminURL": "http://192.168.0.2:8776/v2/0147e64cf52c45499e89893846c51ff2",
//                        "region": "RegionOne",
//                        "internalURL": "http://192.168.0.2:8776/v2/0147e64cf52c45499e89893846c51ff2",
//                        "id": "3fe20868c4094ce59f0eae21fb8f23ab",
//                        "publicURL": "http://172.16.4.4:8776/v2/0147e64cf52c45499e89893846c51ff2"
//                    }
//                ],
//                "endpoints_links": [],
//                "type": "volumev2",
//                "name": "cinderv2"
//            },
//            {
//                "endpoints": [
//                    {
//                        "adminURL": "http://192.168.0.2:8774/v3",
//                        "region": "RegionOne",
//                        "internalURL": "http://192.168.0.2:8774/v3",
//                        "id": "0d69a1de0b6d458c890029c7a1bd379e",
//                        "publicURL": "http://172.16.4.4:8774/v3"
//                    }
//                ],
//                "endpoints_links": [],
//                "type": "computev3",
//                "name": "novav3"
//            },
//            {
//                "endpoints": [
//                    {
//                        "adminURL": "http://192.168.0.2:8080",
//                        "region": "RegionOne",
//                        "internalURL": "http://192.168.0.2:8080",
//                        "id": "1da793e118b24cd0a63afe2569f1c051",
//                        "publicURL": "http://172.16.4.4:8080"
//                    }
//                ],
//                "endpoints_links": [],
//                "type": "s3",
//                "name": "swift_s3"
//            },
//            {
//                "endpoints": [
//                    {
//                        "adminURL": "http://192.168.0.2:9292",
//                        "region": "RegionOne",
//                        "internalURL": "http://192.168.0.2:9292",
//                        "id": "81e33b5bdbf344d3b522927d3a232c04",
//                        "publicURL": "http://172.16.4.4:9292"
//                    }
//                ],
//                "endpoints_links": [],
//                "type": "image",
//                "name": "glance"
//            },
//            {
//                "endpoints": [
//                    {
//                        "adminURL": "http://192.168.0.2:8000/v1",
//                        "region": "RegionOne",
//                        "internalURL": "http://192.168.0.2:8000/v1",
//                        "id": "0402e27daefe4971bbcb36e9fad6a955",
//                        "publicURL": "http://172.16.4.4:8000/v1"
//                    }
//                ],
//                "endpoints_links": [],
//                "type": "cloudformation",
//                "name": "heat-cfn"
//            },
//            {
//                "endpoints": [
//                    {
//                        "adminURL": "http://192.168.0.2:8776/v1/0147e64cf52c45499e89893846c51ff2",
//                        "region": "RegionOne",
//                        "internalURL": "http://192.168.0.2:8776/v1/0147e64cf52c45499e89893846c51ff2",
//                        "id": "2e70c4cb948e4d7da794dce272b73568",
//                        "publicURL": "http://172.16.4.4:8776/v1/0147e64cf52c45499e89893846c51ff2"
//                    }
//                ],
//                "endpoints_links": [],
//                "type": "volume",
//                "name": "cinder"
//            },
//            {
//                "endpoints": [
//                    {
//                        "adminURL": "http://192.168.0.2:8773/services/Admin",
//                        "region": "RegionOne",
//                        "internalURL": "http://192.168.0.2:8773/services/Cloud",
//                        "id": "4c7aa6b39b1b48da96c3e8ff0cdfdc06",
//                        "publicURL": "http://172.16.4.4:8773/services/Cloud"
//                    }
//                ],
//                "endpoints_links": [],
//                "type": "ec2",
//                "name": "nova_ec2"
//            },
//            {
//                "endpoints": [
//                    {
//                        "adminURL": "http://192.168.0.2:8004/v1/0147e64cf52c45499e89893846c51ff2",
//                        "region": "RegionOne",
//                        "internalURL": "http://192.168.0.2:8004/v1/0147e64cf52c45499e89893846c51ff2",
//                        "id": "0fd4a01aa8a54cd1bd39de3932a394f5",
//                        "publicURL": "http://172.16.4.4:8004/v1/0147e64cf52c45499e89893846c51ff2"
//                    }
//                ],
//                "endpoints_links": [],
//                "type": "orchestration",
//                "name": "heat"
//            },
//            {
//                "endpoints": [
//                    {
//                        "adminURL": "http://192.168.0.2:8080/swift/v1",
//                        "region": "RegionOne",
//                        "internalURL": "http://192.168.0.2:8080/swift/v1",
//                        "id": "c769d34dfe8d495786f4927c680157e6",
//                        "publicURL": "http://172.16.4.4:8080/swift/v1"
//                    }
//                ],
//                "endpoints_links": [],
//                "type": "object-store",
//                "name": "swift"
//            },
//            {
//                "endpoints": [
//                    {
//                        "adminURL": "http://192.168.0.2:35357/v2.0",
//                        "region": "RegionOne",
//                        "internalURL": "http://192.168.0.2:5000/v2.0",
//                        "id": "2ca2d72dd62e40b795e55b377852aaf5",
//                        "publicURL": "http://172.16.4.4:5000/v2.0"
//                    }
//                ],
//                "endpoints_links": [],
//                "type": "identity",
//                "name": "keystone"
//            }
//        ],
//        "user": {
//            "username": "admin",
//            "roles_links": [],
//            "id": "4a113f1afc42470cb6ffb5dee46d56dc",
//            "roles": [
//                {
//                    "name": "admin"
//                }
//            ],
//            "name": "admin"
//        },
//        "metadata": {
//            "is_admin": 0,
//            "roles": [
//                "f3fbc9b3c7e34389ac15be4597f87dc1"
//            ]
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