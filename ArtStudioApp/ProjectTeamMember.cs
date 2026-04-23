namespace DefaultNamespace;

public record ProjectTeamMember(){
    private int ProjectId { get; init; }
    string ProjectName{ get; init; }
    string Deadline{ get; init; }
    string? Nickname{ get; init; }
    string? Roles{ get; init; }
    string? LastName{ get; init; }
    string? FirstName{ get; init; }
    string? Patronymic{ get; init; }
    string? Series{ get; init; }
    string? Number{ get; init; }
    string? IssuedBy{ get; init; }
    string? DateOfIssue{ get; init; }
    string? DepartmentCode{ get; init; }
    string? ResidentialAddress{ get; init; }
};