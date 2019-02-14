using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using Proto.Remote;

namespace Proto.Client
{
    public class ClientEndpointWriter: IActor
    {
        private readonly IClientStreamWriter<ClientMessageBatch> _requestStream;
        private static readonly ILogger Logger = Log.CreateLogger(typeof(Client).FullName);

        public ClientEndpointWriter(IClientStreamWriter<ClientMessageBatch> clientStreamsRequestStream)
        {
            _requestStream = clientStreamsRequestStream;
        }

        public Task ReceiveAsync(IContext context)
        {
            if (!(context.Message is RemoteDeliver rd)) return Actor.Done;

            var batch = rd.getMessageBatch();
            
            Logger.LogDebug($"Sending RemoteDeliver message {rd.Message} to {rd.Target.Id} address {rd.Target.Address} from {rd.Sender}");
                
            var clientBatch = new ClientMessageBatch()
            {
                Address = rd.Target.Address,
                Batch = batch
            };
            
            return _requestStream.WriteAsync(clientBatch);


        }

      
    }
}