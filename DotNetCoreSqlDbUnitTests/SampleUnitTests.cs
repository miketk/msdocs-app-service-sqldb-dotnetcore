using DotNetCoreSqlDb.Models;

namespace DotNetCoreSqlDbUnitTests;

public class TodoTests
{



    //create unit tests for the Todo Model
    [Fact] 
    public void TestTodoModel()
    {
        //Arrange
        var todo = new Todo();
        todo.ID = 1;
        todo.Description = "Test Description";
        todo.CreatedDate = DateTime.Now;

        //Act
        var id = todo.ID;
        var description = todo.Description;
        var createdDate = todo.CreatedDate;

        //Assert
        Assert.Equal(1, id);
        Assert.Equal("Test Description", description);
        //Assert.Equal(DateTime.Now, createdDate);
    }
}


