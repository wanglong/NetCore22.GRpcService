using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NetCore22.GRpcService.Protocol;

namespace NetCore22.GRpcService.Impl
{
    public class MsgServiceImpl : MsgService.MsgServiceBase
    {
        public MsgServiceImpl()
        { }

        public override async Task<GetMsgSumReply> GetSum(GetMsgNumRequest request, ServerCallContext context)
        {
            var result = new GetMsgSumReply();

            result.Sum = request.Num1 + request.Num2;
            return await Task.FromResult(result);
        }
    }
}
