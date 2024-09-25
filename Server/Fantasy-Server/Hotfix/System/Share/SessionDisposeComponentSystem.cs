using Fantasy;
using Fantasy.Entitas.Interface;
using Fantasy.Network;
using Model;

namespace Hotfix;

public sealed class SessionDisposeComponentDestroySystem : DestroySystem<SessionDisposeComponent>
{
    protected override void Destroy(SessionDisposeComponent self)
    {
        self.Clear();
    }
}

public static class SessionDisposeComponentSystem
{
    public static void SetTimeOut(this Session session, int timeOut)
    {
        var sessionDisposeComponent = session.GetComponent<SessionDisposeComponent>() ?? session.AddComponent<SessionDisposeComponent>();
        sessionDisposeComponent.SetTimeOut(timeOut);
    }

    public static void SetTimeOut(this SessionDisposeComponent self, int timeOut)
    {
        self.Clear();
        var runtimeId = self.Parent.RunTimeId;
        self.timerId =  self.Scene.TimerComponent.Net.OnceTimer(timeOut, () =>
        {
            if (runtimeId != self.Parent.RunTimeId)
            {
                return;
            }

            self.Parent.Dispose();
            Log.Info("SessionDisposeComponentSystem.SetTimeOut");
        });
    }

    public static void Clear(this SessionDisposeComponent self)
    {
        if (self.timerId == 0)
        {
            return;
        }
        self.Scene.TimerComponent.Net.Remove(ref self.timerId);
    }
}