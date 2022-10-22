using GenerateReceipt.Controllers;
using GenerateReceipt.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateReceipt.Tests
{
    public class Date
    {
        [Fact]
        public void GetDate() { 
            var mockDate = new Mock<IDate>();
            var date = mockDate.Object.GetDate();

            //Action act = () =>
            //{
            //    mockDate.Verify();
            //};

            var receiptDate = new ReceiptController(mockDate.Object, null, null);
            Assert.NotNull(receiptDate);
            //Assert.NotNull(date);
        }


    }
}
