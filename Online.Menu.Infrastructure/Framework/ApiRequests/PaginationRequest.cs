using System.ComponentModel.DataAnnotations;

namespace Sanpad.Chmlu.MiningLab.InfraStracture.Framework.ApiRequests;

public class PaginationRequest
{
    [Range(1, ushort.MaxValue)]
    public ushort PageNo { get; set; }

    [Range(1, ushort.MaxValue)]
    public ushort PageSize { get; set; }

    public (ushort PageNo, ushort PageSize) GetPaginationInfo() => new(PageNo, PageSize);
}
