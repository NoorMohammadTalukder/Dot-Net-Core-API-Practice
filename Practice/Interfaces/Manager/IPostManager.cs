using EF.Core.Repository.Interface.Manager;
using Practice.Models;

namespace Practice.Interfaces.Manager
{
    public interface IPostManager:ICommonManager<Post>
    {
        Post GetById(int id);
    }
}
