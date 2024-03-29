using API.Contracts.Requests.Bugs;
using API.Contracts.Views.Bugs;
using API.DAL;
using AutoMapper;
using API.Models;
using System.Linq.Expressions;
using API.Contracts.Responses.Bugs;
using API.Infrastructure.Extensions;

namespace API.Services
{
    /// <summary>
    /// Bug management
    /// </summary>
    public interface IBugService
    {
        /// <summary>
        /// Creates a new Bug
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        BugCreateResponseView Create(BugCreateRequest input);

        /// <summary>
        /// Bug list by project, user & date range
        /// </summary>
        /// <returns></returns>
        BugListResponseView GetListByParameters(string? projectId,string? userId,
                                                DateTime? startOfInterval, DateTime? endOfInterval);

        ///// <summary>
        ///// Find some Bug by his Id
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //Task<BugDataResponseView> FindById(int id);

        ///// <summary>
        ///// Bug list
        ///// </summary>
        ///// <returns></returns>
        //Task<BugListResponseView> GetList();

        ///// <summary>
        ///// Update Bug
        ///// </summary>
        ///// <param name="input"></param>
        ///// <returns></returns>
        //Task<BugDataResponseView> Update(BugUpdateRequest input);

        ///// <summary>
        ///// Delete Bug
        ///// </summary>
        ///// <param name="input"></param>
        ///// <returns></returns>
        //Task<BugDeleteResponseView> Delete(BugDeleteRequest input);
    }


    public class BugService : IBugService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public BugService(AutoMapper.IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public BugCreateResponseView Create(BugCreateRequest input)
        {
            var result = new BugCreateResponseView();
            try
            {
                var bug = _mapper.Map<Bug>(input);
                var entityEntry = _unitOfWork.BugsRepository.Insert(bug);
                if (entityEntry is null)
                {
                    return result.ToFail<BugCreateResponseView>("No se pudo crear el error");
                }
                result.Id = entityEntry.Entity.Id;
                _unitOfWork.Save();
                return result;
            }
            catch(Exception ex) {
                return result.ToFail<BugCreateResponseView>(ex);
            }
        }

        public BugListResponseView GetListByParameters(string? projectId, string? userId,
                                                DateTime? startOfInterval, DateTime? endOfInterval)
        {
            var response = new BugListResponseView();
            try
            {
                Expression<Func<Bug, bool>> filter = null;
                if (projectId != null)
                    filter = bug => bug.ProjectId == projectId;
                if (userId != null)
                    filter = filter == null ? bug => bug.UserId == userId : 
                                            filter.And(bug => bug.UserId == userId);
                if (startOfInterval != null)
                    filter = filter == null ? bug => bug.CreationDate >= startOfInterval : 
                                            filter.And(bug => bug.CreationDate >= startOfInterval);
                if (endOfInterval != null)
                    filter = filter == null ? bug => bug.CreationDate <= endOfInterval :
                                            filter.And(bug => bug.CreationDate <= endOfInterval);

                var bugs = _unitOfWork.BugsRepository.Get(filter, null, "Project,User");
                foreach (var entity in bugs)
                {
                    response.Data.Add(_mapper.Map<BugDataResponse>(entity));
                }
                return response;
            }
            catch (Exception ex)
            {
                return response.ToFail<BugListResponseView>(ex);
            }
        }

        //Task<BugDataResponseView> FindById(int id);

        //Task<BugListResponseView> GetList();

        //Task<BugDataResponseView> Update(BugUpdateRequest input);

        //Task<BugDeleteResponseView> Delete(BugDeleteRequest input);

    }
}
