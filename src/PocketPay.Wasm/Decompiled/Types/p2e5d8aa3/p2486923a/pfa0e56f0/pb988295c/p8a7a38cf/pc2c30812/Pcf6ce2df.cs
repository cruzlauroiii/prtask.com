namespace WillowMaze.Wasm.Decompiled;

public class Pcf6ce2df : ItemTouchHelper$Callback
{
    private readonly pad063481 F72d3166c;
    private readonly pad063481 Fa48056a3;
    private readonly pad063481 Fcba42de4;
    private readonly pad063481 Fe2a02294;
    private readonly pad063481 Ff5d1a75a;

    public int GetMovementFlags(RecyclerView P0, RecyclerView$ViewHolder P1)
    {
        // str: "viewHolder"
        // str: "recyclerView"
        // call: Intrinsics.checkNotNullParameter
        // call: ItemTouchHelper$Callback.makeMovementFlags
        // call: p49d0e439.isDraggable
        return 0;
    }

    public bool IsLongPressDragEnabled()
    {
        return false;
    }

    public void OnChildDraw(Canvas P0, RecyclerView P1, RecyclerView$ViewHolder P2, float P3, float P4, int P5, bool P6)
    {
        // str: "recyclerView"
        // str: "viewHolder"
        // str: "c"
        // call: RecyclerView.findViewHolderForAdapterPosition
        // call: Intrinsics.checkNotNullParameter
        // call: RecyclerView$ViewHolder.getAdapterPosition
        // call: ItemTouchHelper$Callback.onChildDraw
    }

    public bool OnMove(RecyclerView P0, RecyclerView$ViewHolder P1, RecyclerView$ViewHolder P2)
    {
        // str: "recyclerView"
        // str: "target"
        // str: "viewHolder"
        // call: Intrinsics.checkNotNullParameter
        // call: RecyclerView$ViewHolder.getAdapterPosition
        // call: pad063481.onItemMove
        // field: p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.pcf6ce2df.f72d3166c
        return false;
    }

    public void OnSwiped(RecyclerView$ViewHolder P0, int P1)
    {
        // str: "viewHolder"
        // call: Intrinsics.checkNotNullParameter
    }

}
