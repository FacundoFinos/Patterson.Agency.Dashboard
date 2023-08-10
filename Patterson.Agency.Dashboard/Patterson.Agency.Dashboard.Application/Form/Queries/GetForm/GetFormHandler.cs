using AutoMapper;
using MediatR;
using Patterson.Agency.Dashboard.Domain.Form.Interfaces;

namespace Patterson.Agency.Dashboard.Application.Form.Queries.GetForm;

public class GetFormHandler : IRequestHandler<GetFormQuery, FormDto>, IRequestHandler<GetFormUserQuery,FormDto>
{
    private readonly IFormRepository _formAnswerRepository;
    private readonly IMapper _mapper;

    public GetFormHandler(IFormRepository formAnswerRepository, IMapper mapper)
    {
        _formAnswerRepository = formAnswerRepository;
        _mapper = mapper;
    }

    public async Task<FormDto> Handle(GetFormQuery request, CancellationToken cancellationToken)
    {
        var form = await _formAnswerRepository.Find(request.FormId);
        return _mapper.Map<FormDto>(form);
    }

    public async Task<FormDto> Handle(GetFormUserQuery request, CancellationToken cancellationToken)
    {
        var form = await _formAnswerRepository.Find(request.FormId, request.UserId);
        return _mapper.Map<FormDto>(form);
    }
}