using System.Collections.Generic;
using System.Linq;
using PivkorOnlineShop.Models;

namespace PivkorOnlineShop
{
    public class RolesInMemoryRespository : IRolesInMemoryRepository
    {
        private readonly List<Role> roles = new();

        public void Add(Role role)
        {
            roles.Add(role);
        }

        public List<Role> GetAllRoles()
        {
            return roles;
        }

        public Role TryGetByName(string name)
        {
            return roles.FirstOrDefault(x => x.Name == name);
        }

        public void Remove(string name)
        {
            roles.RemoveAll(x => x.Name == name);
        }
    }
}