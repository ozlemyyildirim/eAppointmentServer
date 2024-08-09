using Ardalis.SmartEnum;

namespace eAppointmentServer.Domain.Enums;

public sealed class DepartmentEnum:SmartEnum<DepartmentEnum>
{
    public static readonly DepartmentEnum Acil = new("Acil", 1);
    public static readonly DepartmentEnum Radyoloji = new("Radyoloji", 2);
    public static readonly DepartmentEnum Nöroloji = new("Nöroloji", 3);
    public static readonly DepartmentEnum Endokrinoloji = new("Endokrinoloji", 4);
    public static readonly DepartmentEnum GenelCerrahi = new("Genel Cerrahi", 5);
    public static readonly DepartmentEnum Hematoloji = new("Hematoloji", 6);
    public static readonly DepartmentEnum Ortopedi = new("Ortopedi", 7);
    public static readonly DepartmentEnum Psikiyatri = new("Psikiyatri", 8);
    public static readonly DepartmentEnum Pediatri = new("Pediatri", 9);
    public static readonly DepartmentEnum Kardiyoloji = new("Kardiyoloji", 10);


    public DepartmentEnum(string name, int value):base(name,value)
    {
        
    }
}
