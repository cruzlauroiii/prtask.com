namespace WillowMaze.Wasm.Decompiled;

public class Pc0b12ae6 : RecyclerView$Adapter
{
    private readonly Func<object, object> F1e0c387a;
    private readonly List<object> F4394d4cd;
    private readonly Func<object, object> F54465807;
    private readonly List<object> Fc3469d69;
    private readonly Func<object, object> Fcf8492be;

    public static Func<object, object> Mf6966c9c(pc0b12ae6 P0)
    {
        // field: pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6.f1e0c387a
        return default!;
    }

    public void AddLauncherTypes(List<object> P0)
    {
        // str: "launcherTypes"
        // call: List<object>.addAll
        // call: pc0b12ae6.notifyDataSetChanged
        // call: Intrinsics.checkNotNullParameter
        // call: List<object>.clear
        // field: pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6.f4394d4cd
    }

    public int GetItemCount()
    {
        // call: List<object>.size
        // field: pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6.f4394d4cd
        return 0;
    }

    public int GetItemViewType(int P0)
    {
        // call: List<object>.get
        // call: p65a1ec85.getSize
        // call: p3bc21851.getType
        // field: pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6.f4394d4cd
        return 0;
    }

    public void OnBindViewHolder(RecyclerView$ViewHolder P0, int P1)
    {
        // call: pc0b12ae6.onBindViewHolder
    }

    public void OnBindViewHolder(pc0b12ae6$p3e9e9d62 P0, int P1)
    {
        // str: "holder"
        // call: Intrinsics.checkNotNullParameter
        // call: pc0b12ae6$p3e9e9d62.bind
        // call: List<object>.get
        // field: pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6.f4394d4cd
    }

    public RecyclerView$ViewHolder OnCreateViewHolder(ViewGroup P0, int P1)
    {
        // call: pc0b12ae6.onCreateViewHolder
        return default!;
    }

    public pc0b12ae6$p3e9e9d62 OnCreateViewHolder(ViewGroup P0, int P1)
    {
        // str: "parent"
        // str: "inflate(...)"
        // call: pc0b12ae6$p3e9e9d62.<init>
        // call: p3bc21851.getType
        // call: LayoutInflater.inflate
        // call: ViewGroup.getContext
        // call: Intrinsics.checkNotNullExpressionValue
        // call: LayoutInflater.from
        // call: Intrinsics.checkNotNullParameter
        // field: pf3e08b51.p07214c67.p3bc21851.f9b9c17e1
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$layout.item_launcher_small
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$layout.item_launcher_big
        // type: pc0b12ae6$p3e9e9d62
        return default!;
    }

}
