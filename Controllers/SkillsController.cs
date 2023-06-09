﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RosteringPractice.Entity;
using RosteringPractice.Services;

namespace RosteringPractice.Controllers
{
    [Route("api/users/Skills")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly IUserInfoRepository _userInfoRepository;
        private readonly IMapper _mapper;

        public SkillsController(IUserInfoRepository userInfoRepository, IMapper mapper)
        {
            _userInfoRepository = userInfoRepository
                ?? throw new ArgumentNullException(nameof(userInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Skill>>> GetAllSkills()
        {
            var skills = await _userInfoRepository.GetAllSkillsAsync();
            return Ok(_mapper.Map<IEnumerable<Skill>>(skills));

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Skill>> GetSkill(int id)
        {
            var skill = await _userInfoRepository.GetmasterSkillAsync(id);
            if (skill == null)
            {
                return NotFound();
            }
            return Ok(skill);
        }

    }
}
