﻿//using VotingApp_RESTAPI.DBContexts;

//namespace VotingApp_RESTAPI.Entities
//{
//    public class UnitOfWork
//    {
//        private ApplicationDbContext _entities = new ApplicationDbContext();
//        CandidateRepository _candidateRepository;
//        VoterRepository _voterRepository;  

//        public UnitOfWork(ApplicationDbContext entities)
//        {
//            _entities = entities;
//        }

//        public CandidateRepository CandidateRepository
//        {
//            get {
//                if (_candidateRepository == null)
//                {
//                    _candidateRepository = new CandidateRepository(_entities);
//                }
//                return _candidateRepository; }
//        }

//        public VoterRepository VoterRepository
//        {
//            get
//            {
//                if (_voterRepository == null)
//                {
//                    _voterRepository = new VoterRepository(_entities);
//                }
//                return _voterRepository;
//            }
//        }


//        public void Save()
//        {
//            _entities.SaveChanges();
//        }

//    }
//}