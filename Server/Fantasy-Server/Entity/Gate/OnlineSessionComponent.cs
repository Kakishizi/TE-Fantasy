using Fantasy;
using Fantasy.Entitas;
using Fantasy.Network;

namespace Model;

public class OnlineSessionComponent : Entity
{
    public Dictionary<long, Session> _Sessions = new Dictionary<long, Session>();
}