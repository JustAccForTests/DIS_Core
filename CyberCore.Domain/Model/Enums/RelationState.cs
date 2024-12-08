namespace CyberCore.Domain.Model;

public enum RelationState
{
    Created = 0,
    Requested = 10,
    Actual = 50,
    Declined = 70,
    End = 100
}
