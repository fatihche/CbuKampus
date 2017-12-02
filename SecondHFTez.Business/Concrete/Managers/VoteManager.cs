using SecondHFTez.Business.Abstracts;
using SecondHFTez.DataAccess.Abstracts;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Concrete.Managers
{
    public class VoteManager : IVoteService
    {
        private readonly IVoteDal _voteDal;

        public VoteManager(IVoteDal voteDal)
        {
            _voteDal = voteDal;
        }

        public Vote Add(Vote vote)
        {
            return _voteDal.Add(vote);
        }
    }
}