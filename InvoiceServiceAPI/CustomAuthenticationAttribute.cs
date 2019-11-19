using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading;
using System.Security.Principal;
using System.Web.Http.Filters;
using System.Web.Http.Controllers;

namespace InvoiceServiceAPI
{
    public class CustomAuthenticationAttribute : AuthorizationFilterAttribute


    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "Credentials nedded");
            }

            else
            {
                string AuthenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                // AuthenticationToken will be base 64 encoded
                string DecodedeAuthenticationToken = Encoding.UTF8.GetString(Convert.FromBase64String(AuthenticationToken));
                string[] UserPassArray = DecodedeAuthenticationToken.Split(':');
                string userName = UserPassArray[0];
                string password = UserPassArray[1];

                if (userName=="Varathan"&&password=="Varathan")//DB check
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(userName), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }

        }
    }
}