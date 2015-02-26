using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Method1.Models.People;
using Method1.Repositories;

namespace Method1.Controllers
{
    [RoutePrefix("api/people")]
    public class PeopleV2_0Controller : BaseApiController
    {
        public PeopleV2_0Controller(IPeopleRepository repository)
            : base(repository)
        {

        }

        [Route("")]
        [ResponseType(typeof(IEnumerable<PeopleVM2>))]
        public HttpResponseMessage GetPeople()
        {
            var people = PeopleRepository
                .FindPeopleV2()
                .Select(p => PeopleFactory.Create(p));

            if (people == null)
            {
                 return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            return Request.CreateResponse(HttpStatusCode.OK, new { people = people });
        }

        [Route("identifier/{id}", Name = "GetPersonByIdV2")]
        [ResponseType(typeof(PeopleVM2))]
        public HttpResponseMessage GetPersonById(int id)
        {
            var person = PeopleRepository.FindPeopleV2ById(id);
            if (person == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK, PeopleFactory.Create(person));
        }
    }
}
