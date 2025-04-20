
namespace TodoDomain.Domain.ValueObjects;

public record struct EntityDates(DateTimeOffset CreateDate, DateTimeOffset? UpdateDate);
