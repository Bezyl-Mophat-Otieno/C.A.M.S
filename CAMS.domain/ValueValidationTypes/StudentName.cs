using ClassAttendanceManagementSystem.Errors;

namespace CAMS.domain.ValueValidationTypes;

public record StudentName
{
    public string Name { get; private set; }

    public string Value => Name;

    private StudentName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Invalid Student Name provided");
        }
        Name = name;
    }

    public static StudentName From(string value) => new(value);

};