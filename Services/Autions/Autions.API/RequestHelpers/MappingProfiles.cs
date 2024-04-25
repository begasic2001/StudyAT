using Autions.API.Dtos;
using Autions.Domain.Entities;
using AutoMapper;

namespace Autions.Application.RequestHelpers;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
        CreateMap<Item, AuctionDto>();
        CreateMap<CreateAuctionDto,Autions>()
            .ForMember(d => d.)
    }
}
