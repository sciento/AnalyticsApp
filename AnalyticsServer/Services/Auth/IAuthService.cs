using System.ServiceModel;
using AnalysticsLibrary.Models;

namespace AnalyticsServer.Interfaces
{
    [ServiceContract]
    public interface IAuthService
    {
        [OperationContract]
        void Auth(AuthRequest auth);



    }
}