namespace WillowMaze.Wasm.Decompiled;

public class P8f27460d : RecyclerView$Adapter
{
    private readonly Func<object, object> F09d4f6c5;
    private readonly List<object> F0c26d5a8;
    private string F1af03898;
    private readonly ViewBinderHelper F2144efae;
    private readonly Func<object, object> F25ad4926;
    private readonly List<object> F365a4a97;
    private readonly Func<object, object> F387b89b4;
    private readonly List<object> F3c88a000;
    private readonly Func<object, object> F50e42f41;
    private string F5d788be5;
    private string F663817e9;
    private readonly Func<object, object> F68e41ffd;
    private readonly Func<object, object> F7caaa040;
    private readonly ViewBinderHelper F8dae285a;
    private readonly List<object> F9b9e24ed;
    private readonly ViewBinderHelper Fa2f9fee1;
    private string Fb57a0e4f;
    private readonly List<object> Febb67a42;
    private readonly List<object> Ff407d80a;

    public static Func<object, object> M1a3c94a7(p8f27460d P0)
    {
        // field: p4670093c.p2486923a.p8a7a38cf.p8f27460d.f50e42f41
        return default!;
    }

    public static Func<object, object> M33aed341(p8f27460d P0)
    {
        // field: p4670093c.p2486923a.p8a7a38cf.p8f27460d.f387b89b4
        return default!;
    }

    public static List<object> M7a7a6a7d(p8f27460d P0)
    {
        // field: p4670093c.p2486923a.p8a7a38cf.p8f27460d.febb67a42
        return default!;
    }

    public static string Mbfe6fdfe(p8f27460d P0)
    {
        // field: p4670093c.p2486923a.p8a7a38cf.p8f27460d.f1af03898
        return string.Empty;
    }

    public static Func<object, object> Mea330526(p8f27460d P0)
    {
        // field: p4670093c.p2486923a.p8a7a38cf.p8f27460d.f7caaa040
        return default!;
    }

    public void AddAll(List<object> P0, List<object> P1)
    {
        // str: "actions"
        // str: "positions"
        // call: p8f27460d.notifyDataSetChanged
        // call: Intrinsics.checkNotNullParameter
        // call: List<object>.addAll
        // call: List<object>.clear
        // field: p4670093c.p2486923a.p8a7a38cf.p8f27460d.febb67a42
        // field: p4670093c.p2486923a.p8a7a38cf.p8f27460d.f365a4a97
    }

    public int GetItemCount()
    {
        // call: List<object>.size
        // field: p4670093c.p2486923a.p8a7a38cf.p8f27460d.f365a4a97
        return 0;
    }

    public void OnBindViewHolder(RecyclerView$ViewHolder P0, int P1)
    {
        // str: "holder"
        // call: ViewBinderHelper.bind
        // call: pd031d465.getUuid
        // call: List<object>.get
        // call: p8f27460d$pdf500089.getBinding
        // call: ViewBinderHelper.closeLayout
        // call: Intrinsics.checkNotNullParameter
        // call: p8f27460d$pdf500089.bind
        // call: ViewBinderHelper.setOpenOnlyOne
        // field: p4670093c.p2486923a.p8a7a38cf.p8f27460d.f365a4a97
        // field: p4670093c.p2486923a.p8a7a38cf.p8f27460d.f8dae285a
        // field: p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.pb1193d36.fee618ba6
    }

    public RecyclerView$ViewHolder OnCreateViewHolder(ViewGroup P0, int P1)
    {
        // str: "parent"
        // str: "inflate(...)"
        // call: LayoutInflater.from
        // call: p8f27460d$pdf500089.<init>
        // call: pb1193d36.m89daba64
        // call: Intrinsics.checkNotNullParameter
        // call: ViewGroup.getContext
        // call: Intrinsics.checkNotNullExpressionValue
        // type: p8f27460d$pdf500089
        return default!;
    }

    public void SetCurrency(string P0)
    {
        // str: "currency"
        // call: Intrinsics.checkNotNullParameter
        // field: p4670093c.p2486923a.p8a7a38cf.p8f27460d.f1af03898
    }

}
