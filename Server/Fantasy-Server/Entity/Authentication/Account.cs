using Fantasy;
using Fantasy.Entitas;
using Fantasy.Entitas.Interface;

namespace Model;

public class Account : Entity,ISupportedDataBase
{
    public string UserName;
    public string Password;
    public long LogicTime;
    public long CreatTime;
}