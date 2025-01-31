using Interface.Models;

namespace Interface.Interface.Dal;

public interface IRouteDal
{
    public Task<int> CreateRoute(int userId);
    public Task CreateDataPoint(DataPointModel[] dataPoints);
    public Task<double> GetMaxSpeed(int routeId);
    public Task<double> GetMaxLean(int routeId);
    public Task<double> GetMaxG(int routeId);
    public Task<RouteModel> GetRoute(int routeId);
    public Task DeleteRoute(int routeId);
}