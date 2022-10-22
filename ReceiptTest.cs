using GenerateReceipt.BLL;
using GenerateReceipt.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace GenerateReceipt.Tests
{
    public class ReceiptTest
    {
        //private readonly Mock<CrudBusinessService> _receiptMock = new Mock<CrudBusinessService>();
        private readonly Mock<ICrudRepository> _crudMock = new Mock<ICrudRepository>();

        //private readonly CrudBusinessService _crudService = new CrudBusinessService(_crudMock);


        [Fact]
        public void GetReceipt_shouldwork()
        {
            //_receiptMock.Setup(p => p.GetAllReceipts()).Returns(true)
            //_receiptMock.Verify(s => s.GetAllReceipts());

            var _crudService = new CrudBusinessService(_crudMock.Object);
            //_receiptMock.Object.
            Assert.NotNull(_crudService.GetAllReceipts());

        }

    }
}
