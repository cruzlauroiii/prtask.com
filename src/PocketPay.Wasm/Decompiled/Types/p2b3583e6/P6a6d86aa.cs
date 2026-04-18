namespace WillowMaze.Wasm.Decompiled;

public class P6a6d86aa : MutableLiveData
{
    private readonly bool F2bfc441c;
    private readonly bool F397ea9cd;
    private readonly bool F7c6c2e5d;

    private static void M3f37fe79(p6a6d86aa P0, Observer P1, object P2)
    {
        // call: bool.compareAndSet
        // call: Observer.onChanged
        // field: p2b3583e6.p6a6d86aa.f7c6c2e5d
        // field: kotlin.Unit.INSTANCE
    }

    public static void M4e838cae(p6a6d86aa P0, Observer P1, object P2)
    {
        // call: p6a6d86aa.m3f37fe79
    }

    public void Observe(LifecycleOwner P0, Observer P1)
    {
        // str: "observer"
        // str: "owner"
        // call: p6a6d86aa$pd41d8cd9$p95263d50.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: p6a6d86aa$p332532dc$p50ed4c6d$0.<init>
        // call: MutableLiveData.observe
        // type: p6a6d86aa$pd41d8cd9$p95263d50
        // type: p6a6d86aa$p332532dc$p50ed4c6d$0
    }

    public void SetValue(object P0)
    {
        // call: bool.set
        // call: MutableLiveData.setValue
        // field: p2b3583e6.p6a6d86aa.f7c6c2e5d
    }

}
