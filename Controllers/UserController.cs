using System;
using System.Web.Mvc;
using TestCaseUsers.Entity;
using TestCaseUsers.Models;
using System.Web.Script.Serialization;

namespace TestCaseUsers.Controllers
{
    public class UserController : Controller
    {
        UnitOfWork _unitOfWork = new UnitOfWork();
        public void Create(User user)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Users.Create(user);
                _unitOfWork.Save();
            }
        }
        public void Update(User user)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Users.Update(user);
                _unitOfWork.Save();
            }
        }
        public object Get(int id)
        {
            var user = _unitOfWork.Users.Get(id);
            var json = new JavaScriptSerializer().Serialize(user);
            return (json);
        }
        public void Remove(int id)
        {
            _unitOfWork.Users.Delete(id);
            _unitOfWork.Save();
        }

    }
}