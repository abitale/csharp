using System.Collections.Generic;

namespace TodoAppJWT.Configuration
{
    public class AuthResult
    {
        public string token{get;set;}
        public bool success {get;set;}
        public List<string> errors {get;set;}
    }
}