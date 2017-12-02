using System;
using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SecondHFTez.Business.Concrete.Managers;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Tests
{
    [TestClass]
    public class BManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Comment_Validation_Check()
        {
            Mock<ICommentDal> mock = new Mock<ICommentDal>();
            CommentManager manager = new CommentManager(mock.Object);

            manager.Add(new Comment());
        }
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void User_Validation_Check()
        {
            Mock<ISecondHfUserDal> mock = new Mock<ISecondHfUserDal>();
            UserManager manager = new UserManager(mock.Object);

            manager.Add(new SecondHfUser());
        }

        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_Validation_Check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager manager = new ProductManager(mock.Object);

            manager.Add(new Product());
        }
    }
}
