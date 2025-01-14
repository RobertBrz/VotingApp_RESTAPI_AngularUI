﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Shared.CustomExceptions;
using VotingApp.Shared.IRaportRequest;
using VotingApp.Voters.Domain.Exceptions;

namespace VotingApp.Voters.Domain.Requests
{
    public class RaportRequest : IRaportRequest
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public RaportRequest(DateTime startTime, DateTime endTime)
        {
            if (startTime > endTime) throw new DataValidationException();

            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
