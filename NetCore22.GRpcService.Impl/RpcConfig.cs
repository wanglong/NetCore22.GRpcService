using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using NetCore22.GRpcService.Protocol;

namespace NetCore22.GRpcService.Impl
{
    public static class RpcConfig
    {
        private static Server _server;

        public static void Start()
        {
            _server = new Server
            {
                Services = { MsgService.BindService(new MsgServiceImpl()) },
                Ports = { new ServerPort("localhost", 40001, ServerCredentials.Insecure) }
            };
            _server.Start();

            Console.WriteLine("grpc ServerListening On Port 40001");
            Console.WriteLine("任意键退出...");
            Console.ReadKey();

            _server?.ShutdownAsync().Wait();
        }
    }
}
