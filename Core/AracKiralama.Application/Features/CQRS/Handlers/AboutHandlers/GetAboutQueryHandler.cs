using Arac.Domain.Entities;
using AracKiralama.Application.Features.CQRS.Quaries.AboutQuaries;
using AracKiralama.Application.Features.CQRS.Result.AboutResult;
using AracKiralama.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _aboutRepository;

        public GetAboutQueryHandler(IRepository<About> aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public async Task<List<GetAboutQueryResult>> Handle()
        {
            var value = await _aboutRepository.GetAllAsync();
            return  value.Select(x => new GetAboutQueryResult
            {
                AboutID = x.AboutID,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
