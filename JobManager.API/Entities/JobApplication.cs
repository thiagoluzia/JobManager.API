﻿namespace JobManager.API.Entities
{
    public class JobApplication
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
        public string CandidateName { get; set; }
        public string CandidateEmail { get; set; }
        public string? CVUrl { get; set; } // Optional CV URL stored in S3
    }
}
