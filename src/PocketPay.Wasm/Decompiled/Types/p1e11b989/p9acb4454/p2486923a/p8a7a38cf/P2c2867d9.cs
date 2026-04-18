namespace WillowMaze.Wasm.Decompiled;

public class P2c2867d9 : RecyclerView$Adapter
{
    private string F1af03898;
    private readonly List<object> F365a4a97;
    private string Fa45f0dbf;
    private string Fb946f3f2;
    private string Fd7c572df;
    private readonly List<object> Fdb6ec857;

    public static string Mbfe6fdfe(p2c2867d9 P0)
    {
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p2c2867d9.f1af03898
        return string.Empty;
    }

    public void AddAll(List<object> P0)
    {
        // str: "positions"
        // call: Intrinsics.checkNotNullParameter
        // call: p2c2867d9.notifyDataSetChanged
        // call: List<object>.addAll
        // call: List<object>.clear
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p2c2867d9.f365a4a97
    }

    public int GetItemCount()
    {
        // call: List<object>.size
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p2c2867d9.f365a4a97
        return 0;
    }

    public void OnBindViewHolder(RecyclerView$ViewHolder P0, int P1)
    {
        // str: "holder"
        // call: Intrinsics.checkNotNullParameter
        // call: List<object>.get
        // call: p2c2867d9$p2ad9eb9b.bind
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p2c2867d9.f365a4a97
    }

    public RecyclerView$ViewHolder OnCreateViewHolder(ViewGroup P0, int P1)
    {
        // call: p2c2867d9.onCreateViewHolder
        return default!;
    }

    public p2c2867d9$p2ad9eb9b OnCreateViewHolder(ViewGroup P0, int P1)
    {
        // str: "inflate(...)"
        // str: "parent"
        // call: p30e41678.m89daba64
        // call: Intrinsics.checkNotNullParameter
        // call: p2c2867d9$p2ad9eb9b.<init>
        // call: ViewGroup.getContext
        // call: LayoutInflater.from
        // call: Intrinsics.checkNotNullExpressionValue
        // type: p2c2867d9$p2ad9eb9b
        return default!;
    }

    public void SetCurrency(string P0)
    {
        // str: "currency"
        // call: Intrinsics.checkNotNullParameter
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p2c2867d9.f1af03898
    }

}
