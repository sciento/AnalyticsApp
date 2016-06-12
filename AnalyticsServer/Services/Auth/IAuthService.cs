using System.ServiceModel;
using AnalysticsLibrary.Models;
using AnalyticsServer.Services;

namespace AnalyticsServer.Interfaces
{
    [ServiceContract]
    public interface IAuthService
    {
        [OperationContract]
        bool Auth(AuthRequest auth);



    }
}