﻿using RosteringPractice.Entity;

namespace RosteringPractice.Services
{
    public interface IUserInfoRepository
    {
        Task<IEnumerable<Users>> GetUsersAsync();
        Task<IEnumerable<Users?>> GetUsersAsync(
            int pageNumber , int pageSize);
        Task<Users?> GetUserAsync(int UserId);
        Task<IEnumerable<Skills>> GetSkillsAsync();
        Task<IEnumerable<Skills>> GetSkillsForUserAsync(int UserId);
        Task<Skills?> GetSkillAsync(int SkillId);
        Task <bool> UserExist(int userId);
        Task AddUsers (Users user);
        Task AddSkills(int userId ,Skills skills);
        Task DeleteUsers (Users user);
        Task DeleteSkills(Skills skill);
        Task<bool> SaveChangesAsync();

    }
}
