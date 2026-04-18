namespace WillowMaze.Wasm.Decompiled;

public class P80e23737 : RecyclerView$Adapter
{
    private readonly List<object> F090fa34f;
    private string F1af03898;
    private readonly List<object> F1f8f9a7e;
    private string F41c46403;
    private string F7dc24902;
    private readonly List<object> Fb4ac8c03;
    private readonly List<object> Fb8f23ba2;
    private string Fd233eb68;
    private readonly List<object> Fd8f9c532;

    public static string Mbfe6fdfe(p80e23737 P0)
    {
        // field: p1e11b989.p438fa616.p2486923a.p8a7a38cf.p80e23737.f1af03898
        return string.Empty;
    }

    public void AddPositionList(List<object> P0)
    {
        // str: "positions"
        // call: List<object>.addAll
        // call: p80e23737.notifyDataSetChanged
        // call: List<object>.clear
        // call: Intrinsics.checkNotNullParameter
        // field: p1e11b989.p438fa616.p2486923a.p8a7a38cf.p80e23737.fb4ac8c03
    }

    public int GetItemCount()
    {
        // call: List<object>.size
        // field: p1e11b989.p438fa616.p2486923a.p8a7a38cf.p80e23737.fb4ac8c03
        return 0;
    }

    public void OnBindViewHolder(RecyclerView$ViewHolder P0, int P1)
    {
        // call: p80e23737.onBindViewHolder
    }

    public void OnBindViewHolder(p80e23737$p10885a7b P0, int P1)
    {
        // str: "holder"
        // call: List<object>.get
        // call: Intrinsics.checkNotNullParameter
        // call: p80e23737$p10885a7b.bind
        // field: p1e11b989.p438fa616.p2486923a.p8a7a38cf.p80e23737.fb4ac8c03
    }

    public RecyclerView$ViewHolder OnCreateViewHolder(ViewGroup P0, int P1)
    {
        // call: p80e23737.onCreateViewHolder
        return default!;
    }

    public p80e23737$p10885a7b OnCreateViewHolder(ViewGroup P0, int P1)
    {
        // str: "parent"
        // str: "inflate(...)"
        // call: ViewGroup.getContext
        // call: pb7159a78.m89daba64
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p80e23737$p10885a7b.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: LayoutInflater.from
        // type: p80e23737$p10885a7b
        return default!;
    }

    public void SetCurrency(string P0)
    {
        // str: "currency"
        // call: Intrinsics.checkNotNullParameter
        // field: p1e11b989.p438fa616.p2486923a.p8a7a38cf.p80e23737.f1af03898
    }

}
