using System.Collections.Generic;
using Method1.Models.People;

namespace Method1.Repositories
{
    public interface IPeopleRepository
    {
        IEnumerable<PeopleVM> FindPeople();
        PeopleVM FindPeopleById(int id);

        IEnumerable<PeopleVM2> FindPeopleV2();
        PeopleVM2 FindPeopleV2ById(int id);
    }
}