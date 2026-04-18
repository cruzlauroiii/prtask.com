namespace WillowMaze.Wasm.Decompiled;

public class P973b827d : RecyclerView$Adapter
{
    private readonly List<object> F4631d544;
    private readonly Func<object, object> F6273c121;
    private readonly List<object> F931052cc;
    private readonly Func<object, object> F9b2ecce6;
    private readonly Func<object, object> Face3e996;
    private readonly Func<object, object> Fe8f0426f;
    private readonly Func<object, object> Fea466d95;

    public static Func<object, object> M184d3e04(p973b827d P0)
    {
        // field: p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d.f6273c121
        return default!;
    }

    public void AddPaymentTypes(List<object> P0)
    {
        // str: "paymentTypes"
        // call: p973b827d.notifyDataSetChanged
        // call: List<object>.addAll
        // call: List<object>.clear
        // call: Intrinsics.checkNotNullParameter
        // field: p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d.f931052cc
    }

    public int GetItemCount()
    {
        // call: List<object>.size
        // field: p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d.f931052cc
        return 0;
    }

    public void OnBindViewHolder(RecyclerView$ViewHolder P0, int P1)
    {
        // call: p973b827d.onBindViewHolder
    }

    public void OnBindViewHolder(p973b827d$pbc951a89 P0, int P1)
    {
        // str: "holder"
        // call: List<object>.get
        // call: Intrinsics.checkNotNullParameter
        // call: p973b827d$pbc951a89.bind
        // field: p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d.f931052cc
    }

    public RecyclerView$ViewHolder OnCreateViewHolder(ViewGroup P0, int P1)
    {
        // call: p973b827d.onCreateViewHolder
        return default!;
    }

    public p973b827d$pbc951a89 OnCreateViewHolder(ViewGroup P0, int P1)
    {
        // str: "inflate(...)"
        // str: "parent"
        // call: pfbcefcd6.m89daba64
        // call: LayoutInflater.from
        // call: ViewGroup.getContext
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p973b827d$pbc951a89.<init>
        // type: p973b827d$pbc951a89
        return default!;
    }

}
