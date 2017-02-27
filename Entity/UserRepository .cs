using System;
using System.Collections.Generic;
using System.Data.Entity;
using TestCaseUsers.Models;

namespace TestCaseUsers.Entity
{
    public class UserRepository : IRepository<User>
    {
        private UserContext _db;

        public UserRepository(UserContext context)
        {
            this._db = context;
        }

        public void Create(User user)
        {
            _db.Users.Add(user);
        }

        public void Delete(int id)
        {
            var user = _db.Users.Find(id);
            if(user != null)
            {
                _db.Users.Remove(user);
            }
        }
        public User Get(int id)
        {
            return _db.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _db.Users;
        }

        public void Update(User user)
        {
            _db.Entry(user).State = EntityState.Modified;
        }
    }
}