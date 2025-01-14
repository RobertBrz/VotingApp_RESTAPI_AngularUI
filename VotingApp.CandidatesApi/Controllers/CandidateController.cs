﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using VotingApp.Shared.ModelsDto;
using VotingApp.Voters.Domain.Services.Interfaces;

namespace VotingApp.Candidates.Application.Controllers
{
    [Route("Candidate")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService _candidateService;
        private readonly ILogger<CandidateController> _logger;
        private readonly IMapper _mapper;

        public CandidateController(ILogger<CandidateController> logger,
            ICandidateService candidateService,
            IMapper mapper)
        {
            _candidateService = candidateService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetCandidates()
        {
            return Ok(_candidateService.GetCandidates());
        }

        [HttpGet]
        [Route("{candidateID}")]
        public IActionResult GetCandidate([FromRoute] int candidateID)
        {
            return Ok(_candidateService.GetCandidate(candidateID));
        }

        [HttpPost]
        [Route("AddCandidate")]
        public IActionResult AddCandidate([FromBody] CandidateDto candidateDto)
        {
            _candidateService.AddCandidate(candidateDto);
            return Ok();
        }
    }
}
