using System;
using NetCore22.GRpcService.Impl;

namespace NetCore22.GRpcService.HostingServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Server!");
            RpcConfig.Start();
        }
    }
}
