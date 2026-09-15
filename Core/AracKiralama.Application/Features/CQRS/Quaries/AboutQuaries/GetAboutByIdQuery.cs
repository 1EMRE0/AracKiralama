using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.Application.Features.CQRS.Quaries.AboutQuaries
{
    public class GetAboutByIdQuery
    {
        public int Id { get; set; }

        public GetAboutByIdQuery(int id)
        {
            Id = id;
        }
    }
}
