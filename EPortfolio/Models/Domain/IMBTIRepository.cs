using System.Collections.Generic;

namespace EPortfolio.Models.Domain
{
    public interface IMBTIRepository
    {
        IEnumerable <MBTI> GetAll ();
        IEnumerable <MBTI> GetType (string type);

        MBTI GetById (int id);

        void Add (MBTI mbti);
        void Delete (MBTI mbti);
        void SaveChanges ();
    }
}
