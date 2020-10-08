using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //Business Kontrolü
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            //Business Kontrolü
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<IList<Product>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<IList<Product>>(_productDal.GetList(filter: x => x.CategoryId == categoryId));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(filter: x => x.ProductId == productId));
        }

        public IDataResult<IList<Product>> GetList()
        {
            return new SuccessDataResult<IList<Product>>( _productDal.GetList().ToList());
        }

        public IResult Update(Product product)
        {
            //Business Kontrolümüz
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

    }
}
