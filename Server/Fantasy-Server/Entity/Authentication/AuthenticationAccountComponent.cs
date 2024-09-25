using Fantasy;
using Fantasy.Async;
using Fantasy.Entitas;

namespace Model;

public class AuthenticationAccountComponent : Entity

{
    public readonly Dictionary<int, Account> Cache = new Dictionary<int, Account>();
    public CoroutineLock AccountLock;
    public readonly Dictionary<uint, string> CacheOuterAddress = new Dictionary<uint, string>();
}