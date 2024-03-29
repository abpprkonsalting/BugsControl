using API.Contracts.Requests.Users;
using API.Contracts.Views.Users;
using API.DAL;
using AutoMapper;
using API.Models;

namespace API.Services
{
    /// <summary>
    /// User management
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Creates a new User
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        UserCreateResponseView Create(UserCreateRequest input);

        ///// <summary>
        ///// Find some User by his Id
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //Task<UserDataResponseView> FindById(int id);

        ///// <summary>
        ///// User list
        ///// </summary>
        ///// <returns></returns>
        //Task<UserListResponseView> GetList();

        ///// <summary>
        ///// Update User
        ///// </summary>
        ///// <param name="input"></param>
        ///// <returns></returns>
        //Task<UserDataResponseView> Update(UserUpdateRequest input);

        ///// <summary>
        ///// Delete User
        ///// </summary>
        ///// <param name="input"></param>
        ///// <returns></returns>
        //Task<UserDeleteResponseView> Delete(UserDeleteRequest input);
    }

   
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(AutoMapper.IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public UserCreateResponseView Create(UserCreateRequest input)
        {
            var result = new UserCreateResponseView();
            try
            {
                var user = _mapper.Map<User>(input);
                var entityEntry = _unitOfWork.UsersRepository.Insert(user);
                if (entityEntry is null)
                {
                    return result.ToFail<UserCreateResponseView>("No se pudo crear el usuario");
                }
                result.Id = entityEntry.Entity.Id;
                _unitOfWork.Save();
                return result;
            }
            catch(Exception ex) {
                return result.ToFail<UserCreateResponseView>(ex);
            }
        }

        //Task<UserDataResponseView> FindById(int id);

        //Task<UserListResponseView> GetList();

        //Task<UserDataResponseView> Update(UserUpdateRequest input);

        //Task<UserDeleteResponseView> Delete(UserDeleteRequest input);

    }
}
