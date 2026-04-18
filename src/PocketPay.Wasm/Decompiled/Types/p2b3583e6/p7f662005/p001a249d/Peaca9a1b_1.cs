namespace WillowMaze.Wasm.Decompiled;

public class Peaca9a1b_1 : DefaultLifecycleObserver
{
    private readonly Observer F0bed3cb6;
    private readonly Observer Fd8275c46;
    private readonly peaca9a1b This$0;

    public static void M1634d1a4(peaca9a1b P0, LifecycleOwner P1)
    {
        // call: peaca9a1b$1.m78982db2
    }

    private static void M78982db2(peaca9a1b P0, LifecycleOwner P1)
    {
        // call: Lifecycle.addObserver
        // call: peaca9a1b$1$p0bed3cb6$1$1.<init>
        // call: LifecycleOwner.getLifecycle
        // type: peaca9a1b$1$p0bed3cb6$1$1
    }

    public Observer GetViewLifecycleOwnerLiveDataObserver()
    {
        // field: p2b3583e6.p7f662005.p001a249d.peaca9a1b$1.f0bed3cb6
        return default!;
    }

    public void OnCreate(LifecycleOwner P0)
    {
        // str: "owner"
        // call: LiveData.observeForever
        // call: Intrinsics.checkNotNullParameter
        // call: peaca9a1b.m7b72fb5a
        // call: Fragment.getViewLifecycleOwnerLiveData
        // field: p2b3583e6.p7f662005.p001a249d.peaca9a1b$1.this$0
        // field: p2b3583e6.p7f662005.p001a249d.peaca9a1b$1.f0bed3cb6
    }

    public void OnDestroy(LifecycleOwner P0)
    {
        // str: "owner"
        // call: peaca9a1b.m7b72fb5a
        // call: Fragment.getViewLifecycleOwnerLiveData
        // call: Intrinsics.checkNotNullParameter
        // call: LiveData.removeObserver
        // field: p2b3583e6.p7f662005.p001a249d.peaca9a1b$1.f0bed3cb6
        // field: p2b3583e6.p7f662005.p001a249d.peaca9a1b$1.this$0
    }

}
