using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {

        ICreditCardDal creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            this.creditCardDal = creditCardDal;
        }

        public IResult Add(CreditCard creditCard)
        {
            creditCardDal.Add(creditCard);
            return new SuccessResult(Messages.AddedCreditCard);
        }

        public IResult Delete(CreditCard creditCard)
        {
            creditCardDal.Delete(creditCard);
            return new SuccessResult(Messages.DeletedCreditCard);
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(creditCardDal.GetAll());
        }

        public IDataResult<CreditCard> GetById(int id)
        {
            return new SuccessDataResult<CreditCard>(creditCardDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CreditCard>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<CreditCard>>(creditCardDal.GetAll(c => c.UserId == userId));
        }

        public IResult Update(CreditCard creditCard)
        {

            creditCardDal.Update(creditCard);
            return new SuccessResult(Messages.UpdatedCreditCard);
        }
    }
}
