using razorpagesExample.Models;

namespace razorpagesExample.Repository;

public class MockEmployeeRepository : IEmployeeRepository
{
    private List<Employees> _employeeList;

    public MockEmployeeRepository()
    {
        _employeeList = new List<Employees>()
        {
            new Employees{Id = 1, Name="Caner Sinan", Email="canersinan@live.com",Photo="1.jpg", Department="IT"},
            new Employees{Id = 2, Name="Berkay Özcan", Email="berkayozcan@live.com",Photo="2.jpg", Department="IT"},
            new Employees{Id = 3, Name="Samet Öztürk", Email="sametozturk@live.com",Photo="3.jpg", Department="IT"},
            new Employees{Id = 4, Name="Batuhan Özcan", Email="batuhanozcan@live.com",Photo="4.jpg", Department="IT"},
        }
    }
    public IEnumerable<Employees> GetAll()
    {
        return _employeeList;
}