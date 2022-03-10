using System.Threading.Tasks;

namespace RabbitAndSqs.Connections
{
    public interface ISender<in TModel>
    {
        public Task Send(TModel model);
    }
}