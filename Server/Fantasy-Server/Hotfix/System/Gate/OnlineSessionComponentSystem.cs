using Fantasy;
using Fantasy.Network;
using Model;

namespace Hotfix;

public static class OnlineSessionComponentSystem
{
    public static void Add(this OnlineSessionComponent self, Session session)
    {
        Log.Debug($"Add Session: {session.RunTimeId}");
        self._Sessions.Add(session.RunTimeId, session);
    }

    public static void Remove(this OnlineSessionComponent self, Session session)
    {
        self._Sessions.Remove(session.RunTimeId);
    }

    public static void Remove(this OnlineSessionComponent self, long runTimeId)
    {
        self._Sessions.Remove(runTimeId);
    }


    public static bool TryGet(this OnlineSessionComponent self, long runTimeId, out Session session)
    {
        return self._Sessions.TryGetValue(runTimeId, out session);
    }
}