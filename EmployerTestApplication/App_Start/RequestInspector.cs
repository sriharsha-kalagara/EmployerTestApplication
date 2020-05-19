using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace EmployerTestApplication.App_Start
{
    public class RequestInspector : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var result = await base.SendAsync(request, cancellationToken);

            if(result.StatusCode == HttpStatusCode.InternalServerError)
            {
                result.ReasonPhrase = "this is bad";
            }

            return result;
        }
    }
}