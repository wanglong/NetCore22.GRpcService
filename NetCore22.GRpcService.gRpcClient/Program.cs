using System;
using NetCore22.GRpcService.Protocol;

namespace NetCore22.GRpcService.gRpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World  gRPC Client!");
            GetMsgSumReply msgSum = MsgServiceClient.GetSum(10, 2);
            Console.WriteLine("grpc Client Call GetSum():" + msgSum.Sum);
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
        }
    }
}
