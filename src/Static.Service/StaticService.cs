using ServiceStack;
using System;

namespace Static.Service
{
    public class StaticService : ServiceStack.Service
    {
        public void Get(ExampleDTO dto)
        {
            throw new NotImplementedException();
        }
    }

    [Route("/example","GET")]
    public class ExampleDTO
    {
        public int Id { get; set; }
    }

}
