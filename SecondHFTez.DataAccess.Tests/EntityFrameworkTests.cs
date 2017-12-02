using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.DataAccess.Concrete.EntityFramework;

namespace SecondHFTez.DataAccess.Tests
{
    [TestClass]
    public class EntityFrameworkTests
    {
        private readonly ISecondHfUserDal _secondHfUserDal;

        public EntityFrameworkTests()
        {
            this._secondHfUserDal = new EfSecondHfUserDal();//burayı sor burda newledik ve classa bağımlı olduk.
        }

        [TestMethod]
        public void Get_all_returns_all_users()
        {
            var result = _secondHfUserDal.GetList();
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_Users()
        {
            var result = _secondHfUserDal.GetList(u => u.Username.Contains("001"));
            Assert.AreEqual(1, result.Count);
        }
    }
}
