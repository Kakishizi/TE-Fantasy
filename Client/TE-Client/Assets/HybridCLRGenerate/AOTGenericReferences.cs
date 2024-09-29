using System.Collections.Generic;
public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
	{
		"Fantasy.Unity.dll",
		"System.Core.dll",
		"TEngine.Runtime.dll",
		"Unity.InputSystem.dll",
		"UnityEngine.CoreModule.dll",
		"mscorlib.dll",
	};
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// Fantasy.Async.AsyncFTaskMethodBuilder<object>
	// Fantasy.Async.AsyncFTaskMethodBuilder<uint>
	// Fantasy.Async.FTask<object>
	// Fantasy.Async.FTask<uint>
	// Fantasy.DataStructure.Collection.OneToManyQueue<object,object>
	// System.Action<UnityEngine.InputSystem.InputAction.CallbackContext>
	// System.Action<byte>
	// System.Action<int,uint,uint>
	// System.Action<object>
	// System.Action<uint,uint>
	// System.Action<ulong,ulong>
	// System.Collections.Concurrent.ConcurrentQueue.<Enumerate>d__28<object>
	// System.Collections.Concurrent.ConcurrentQueue.Segment<object>
	// System.Collections.Concurrent.ConcurrentQueue<object>
	// System.Collections.Generic.ArraySortHelper<object>
	// System.Collections.Generic.Comparer<object>
	// System.Collections.Generic.Dictionary.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection<object,object>
	// System.Collections.Generic.Dictionary<int,object>
	// System.Collections.Generic.Dictionary<object,object>
	// System.Collections.Generic.EqualityComparer<int>
	// System.Collections.Generic.EqualityComparer<object>
	// System.Collections.Generic.HashSet.Enumerator<object>
	// System.Collections.Generic.HashSet<object>
	// System.Collections.Generic.HashSetEqualityComparer<object>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.ICollection<object>
	// System.Collections.Generic.IComparer<object>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerable<object>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerator<object>
	// System.Collections.Generic.IEqualityComparer<int>
	// System.Collections.Generic.IEqualityComparer<object>
	// System.Collections.Generic.IList<object>
	// System.Collections.Generic.KeyValuePair<int,object>
	// System.Collections.Generic.KeyValuePair<object,object>
	// System.Collections.Generic.List.Enumerator<object>
	// System.Collections.Generic.List<object>
	// System.Collections.Generic.ObjectComparer<object>
	// System.Collections.Generic.ObjectEqualityComparer<int>
	// System.Collections.Generic.ObjectEqualityComparer<object>
	// System.Collections.Generic.Queue.Enumerator<object>
	// System.Collections.Generic.Queue<object>
	// System.Collections.ObjectModel.ReadOnlyCollection<object>
	// System.Comparison<object>
	// System.Func<object,int,int,object>
	// System.Func<object,object>
	// System.IEquatable<object>
	// System.Nullable<long>
	// System.Predicate<object>
	// UnityEngine.Events.UnityAction<byte>
	// UnityEngine.InputSystem.InputBindingComposite<UnityEngine.Vector2>
	// UnityEngine.InputSystem.InputControl<UnityEngine.Vector2>
	// UnityEngine.InputSystem.InputProcessor<UnityEngine.Vector2>
	// UnityEngine.InputSystem.Utilities.InlinedArray<object>
	// }}

	public void RefMethods()
	{
		// System.Void Fantasy.Async.AsyncFTaskMethodBuilder<uint>.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,GameLogic.AuthHelper.<Register>d__0>(Cysharp.Threading.Tasks.UniTask.Awaiter&,GameLogic.AuthHelper.<Register>d__0&)
		// System.Void Fantasy.Async.AsyncFTaskMethodBuilder<uint>.AwaitUnsafeOnCompleted<object,GameLogic.AuthHelper.<Login>d__1>(object&,GameLogic.AuthHelper.<Login>d__1&)
		// System.Void Fantasy.Async.AsyncFTaskMethodBuilder<uint>.AwaitUnsafeOnCompleted<object,GameLogic.AuthHelper.<Register>d__0>(object&,GameLogic.AuthHelper.<Register>d__0&)
		// System.Void Fantasy.Async.AsyncFTaskMethodBuilder<uint>.Start<GameLogic.AuthHelper.<Login>d__1>(GameLogic.AuthHelper.<Login>d__1&)
		// System.Void Fantasy.Async.AsyncFTaskMethodBuilder<uint>.Start<GameLogic.AuthHelper.<Register>d__0>(GameLogic.AuthHelper.<Register>d__0&)
		// object Fantasy.Entitas.MessagePoolComponent.Rent<object>()
		// object System.Activator.CreateInstance<object>()
		// byte[] System.Array.Empty<byte>()
		// object[] System.Array.Empty<object>()
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<object,GameLogic.UILoginWindow.<OnClickLoginBtn>d__5>(object&,GameLogic.UILoginWindow.<OnClickLoginBtn>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<object,GameLogic.UILoginWindow.<OnClickRegisterBtn>d__6>(object&,GameLogic.UILoginWindow.<OnClickRegisterBtn>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<object,Test.<Start>d__1>(object&,Test.<Start>d__1&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<GameLogic.UILoginWindow.<OnClickLoginBtn>d__5>(GameLogic.UILoginWindow.<OnClickLoginBtn>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<GameLogic.UILoginWindow.<OnClickRegisterBtn>d__6>(GameLogic.UILoginWindow.<OnClickRegisterBtn>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Test.<Start>d__1>(Test.<Start>d__1&)
		// System.Void TEngine.EventDelegateData.Callback<byte>(byte)
		// System.Void TEngine.EventDelegateData.Callback<int,uint,uint>(int,uint,uint)
		// System.Void TEngine.EventDelegateData.Callback<uint,uint>(uint,uint)
		// System.Void TEngine.EventDelegateData.Callback<ulong,ulong>(ulong,ulong)
		// System.Void TEngine.EventDispatcher.Send<byte>(int,byte)
		// System.Void TEngine.EventDispatcher.Send<int,uint,uint>(int,int,uint,uint)
		// System.Void TEngine.EventDispatcher.Send<uint,uint>(int,uint,uint)
		// System.Void TEngine.EventDispatcher.Send<ulong,ulong>(int,ulong,ulong)
		// System.Void TEngine.GameFrameworkLog.Fatal<object>(string,object)
		// object TEngine.IResourceManager.LoadAsset<object>(string,string)
		// System.Void TEngine.Log.Fatal<object>(string,object)
		// object TEngine.ResourceModule.LoadAsset<object>(string,string)
		// object TEngine.UIBase.FindChildComponent<object>(string)
		// System.Void TEngine.UIModule.CloseUI<object>()
		// System.Void TEngine.UIModule.ShowUI<object>(object[])
		// object TEngine.UnityExtension.FindChildComponent<object>(UnityEngine.Transform,string)
		// string TEngine.Utility.Text.Format<object>(string,object)
		// string TEngine.Utility.Text.ITextHelper.Format<object>(string,object)
		// System.Void* Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<UnityEngine.Vector2>(UnityEngine.Vector2&)
		// int Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<UnityEngine.Vector2>()
		// object UnityEngine.GameObject.AddComponent<object>()
		// object UnityEngine.GameObject.GetComponent<object>()
		// UnityEngine.Vector2 UnityEngine.InputSystem.InputAction.ReadValue<UnityEngine.Vector2>()
		// UnityEngine.Vector2 UnityEngine.InputSystem.InputAction.CallbackContext.ReadValue<UnityEngine.Vector2>()
		// UnityEngine.Vector2 UnityEngine.InputSystem.InputActionState.ApplyProcessors<UnityEngine.Vector2>(int,UnityEngine.Vector2,UnityEngine.InputSystem.InputControl<UnityEngine.Vector2>)
		// UnityEngine.Vector2 UnityEngine.InputSystem.InputActionState.ReadValue<UnityEngine.Vector2>(int,int,bool)
		// object UnityEngine.Object.Instantiate<object>(object)
		// string string.Join<object>(string,System.Collections.Generic.IEnumerable<object>)
		// string string.JoinCore<object>(System.Char*,int,System.Collections.Generic.IEnumerable<object>)
	}
}