using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using RabbitAndSqs.Models;

namespace RabbitAndSqs.Connections
{
    public interface IReceiver<TModel>
    {
        public Task<IEnumerable<TModel>> ReceiveBatch();
    }

    public interface IOutgoingTransport<TModel>
    {
        Task Send(ISerializedMessage<TModel> message);
    }

    public interface IIncomingTransport<TModel>
    {
        Task<IEnumerable<ISerializedMessage<TModel>>> ReceiveBatch(CancellationToken cancellationToken);
    }
}
