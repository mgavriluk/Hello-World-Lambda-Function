using System.Collections.Generic;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace SimpleLambdaFunction;

public class Function
{
    public Response FunctionHandler(APIGatewayProxyRequest request, ILambdaContext context)
    {
        return new Response
        {
            StatusCode = 200,
            Message = "Hello from Lambda"
        };
    }

    public class Response
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
