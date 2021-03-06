using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [SecuredOperation("user.add,admin")]
        [CacheRemoveAspect("IUserService.Get")]
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        
        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }


        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
    }


}



