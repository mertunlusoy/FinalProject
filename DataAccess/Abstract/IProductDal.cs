using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //Dal -- Data access layer
    public interface IProductDal:IEntityRepository<Product>
    {
        

    }
}
