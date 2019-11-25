using System;
using System.Collections.Generic;
using Contracts;
using Entities.Models;
using xunit;

namespace Tests
{
    public class UnitTest1
    {
       [Fact]
    public void GetAllOwners_ReturnsListOfOwners_WithSingleOwner()
    {
        // Arrange
        var mockRepo = new Mock<IOwnerRepository>();
        mockRepo.Setup(repo => (repo.GetAllOwners())).Returns(GetOwners());
    
        // Act
        var result = mockRepo.Object.GetAllOwners().ToList();
    
        // Assert
        Assert.IsType<List<Owner>>(result);
        Assert.Single(result);
    }
 
    public List<Owner> GetOwners()
    {
        return new List<Owner>
        {
            new Owner
            {
                Id = Guid.NewGuid(),
                Name = "John Keen",
                DateOfBirth = new DateTime(1980, 12, 05),
                Address = "61 Wellfield Road"
            }
        };
    }
        }
}
