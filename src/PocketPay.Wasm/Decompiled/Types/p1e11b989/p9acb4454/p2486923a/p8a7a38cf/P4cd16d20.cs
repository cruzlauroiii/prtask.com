namespace WillowMaze.Wasm.Decompiled;

public class P4cd16d20 : FragmentStateAdapter
{
    private readonly List<object> F2309049a;
    private readonly List<object> F3d7e553d;
    private readonly List<object> F89ad1113;
    private readonly List<object> F944699d7;
    private readonly List<object> Fad7ba86b;

    public void AddAll(List<object> P0)
    {
        // str: "fragments"
        // call: List<object>.clear
        // call: p4cd16d20.notifyDataSetChanged
        // call: List<object>.addAll
        // call: Intrinsics.checkNotNullParameter
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p4cd16d20.fad7ba86b
    }

    public Fragment CreateFragment(int P0)
    {
        // call: List<object>.get
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p4cd16d20.fad7ba86b
        return default!;
    }

    public int GetItemCount()
    {
        // call: List<object>.size
        // field: p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p4cd16d20.fad7ba86b
        return 0;
    }

}
