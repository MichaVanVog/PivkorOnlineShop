using PivkorOnlineShop.Models;
using System.Collections.Generic;

namespace PivkorOnlineShop
{
    public interface IRolesInMemoryRepository
    {
        List<Role> GetAllRoles();
        Role TryGetByName(string name);
        void Add(Role role);
        void Remove(string name);
    }
}