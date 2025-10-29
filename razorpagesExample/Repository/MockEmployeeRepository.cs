using razorpagesExample.Models;

namespace razorpagesExample.Repository;

public class MockEmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employeeList;

    public MockEmployeeRepository()
    {
        _employeeList = new List<Employee>()
        {
            new Employee{Id = 1, Name="Caner Sinan", Email="canersinan@live.com",Photo="1.jpg", Department="IT"},
            new Employee{Id = 2, Name="Berkay Özcan", Email="berkayozcan@live.com",Photo="2.jpg", Department="IT"},
            new Employee{Id = 3, Name="Samet Öztürk", Email="sametozturk@live.com",Photo="3.jpg", Department="IT"},
            new Employee{Id = 4, Name="Batuhan Özcan", Email="batuhanozcan@live.com",Photo="4.jpg", Department="Health"}
        };
    }

    public Employee Create(Employee entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Employee> GetAll()
    {
        return _employeeList;
    }

    public Employee GetById(int id)
    {
        return _employeeList.FirstOrDefault(i => i.Id == id);
    }

    public Employee Update(Employee entity)
    {
        Employee employee = _employeeList.FirstOrDefault(i => i.Id == entity.Id);

        if (employee != null)
        {
            employee.Name = entity.Name;
            employee.Email = entity.Email;
            employee.Photo = entity.Photo;
            employee.Department = entity.Department;
        }
        return employee;
    }
}