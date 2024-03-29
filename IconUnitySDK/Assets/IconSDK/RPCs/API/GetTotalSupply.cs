using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using Newtonsoft.Json;
using Cysharp.Threading.Tasks;

namespace IconSDK.RPCs
{
    using Types;
    using Extensions;
    using Blockchain;

    public class GetTotalSupplyRequestMessage : RPCRequestMessage
    {
        public GetTotalSupplyRequestMessage()
        : base("icx_getTotalSupply")
        {

        }
    }

    public class GetTotalSupplyResponseMessage : RPCResponseMessage<BigInteger>
    {

    }

    public class GetTotalSupply : RPC<GetTotalSupplyRequestMessage, GetTotalSupplyResponseMessage>
    {
        public GetTotalSupply(string url) : base(url)
        {

        }

        public async UniTask<BigInteger> Invoke()
        {
            var request = new GetTotalSupplyRequestMessage();
            var response = await Invoke(request);
            return response.Result;
        }

        public static new Func<UniTask<BigInteger>> Create(string url)
        {
            return new GetTotalSupply(url).Invoke;
        }
    }
}
