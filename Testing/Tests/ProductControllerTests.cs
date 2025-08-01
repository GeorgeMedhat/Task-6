using ApiLayer.Controllers;
using AutoMapper;
using BusinessLogic.Models;
using BusinessLogicLayer.DTOs;
using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

public class ProductControllerTests
{
    private readonly Mock<IUnitOfWork> _mockUnitOfWork;
    private readonly ProductController _controller;
    private readonly Mock<IProductRepository> _mockProductRepo;
    private readonly Mock<IMapper> _mockMapper;

    public ProductControllerTests()
    {
        _mockUnitOfWork = new Mock<IUnitOfWork>();
        _mockProductRepo = new Mock<IProductRepository>();
        _mockMapper = new Mock<IMapper>(); // 👈 Added

        _mockUnitOfWork.Setup(u => u.Products).Returns(_mockProductRepo.Object);

        _controller = new ProductController(_mockUnitOfWork.Object, _mockMapper.Object); // 👈 Use mock here
    }

    [Fact]
    public async Task GetAllProducts_ReturnsOkResult_WithListOfProducts()
    {
        // Arrange
        var sampleProducts = new List<Product>
    {
        new Product { id = 1, title = "Product 1" },
        new Product { id = 2, title = "Product 2" }
    };

        var mappedDtos = sampleProducts.Select(p => new ProductReadDto
        {
            id = p.id,
            title = p.title
        }).ToList();

        _mockProductRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(sampleProducts);
        _mockMapper.Setup(m => m.Map<IEnumerable<ProductReadDto>>(sampleProducts)).Returns(mappedDtos);

        // Act
        var result = await _controller.GetAllProducts();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnValue = Assert.IsAssignableFrom<IEnumerable<ProductReadDto>>(okResult.Value);
        Assert.Equal(2, returnValue.Count());
    }

    [Fact]
    public async Task GetById_ValidId_ReturnsOkWithProduct()
    {
        // Arrange
        var product = new Product { id = 1, title = "Test Product" };
        var productDto = new ProductReadDto { id = 1, title = "Test Product" };

        _mockProductRepo.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(product);
        _mockMapper.Setup(m => m.Map<ProductReadDto>(product)).Returns(productDto);

        // Act
        var result = await _controller.GetById(1);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnProduct = Assert.IsType<ProductReadDto>(okResult.Value);
        Assert.Equal(product.id, returnProduct.id);
    }

    [Fact]
    public async Task GetById_InvalidId_ReturnsNotFound()
    {
        // Arrange
        _mockProductRepo.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((Product)null);

        // Act
        var result = await _controller.GetById(999);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }

    [Fact]
    public void SampleTest_ShouldRun()
    {
        Assert.True(1 + 1 == 2);
    }
}
