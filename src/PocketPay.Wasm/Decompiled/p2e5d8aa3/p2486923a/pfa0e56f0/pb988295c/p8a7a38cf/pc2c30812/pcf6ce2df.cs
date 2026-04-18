namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0007\n\u0002\b\u0007\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0018\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016J \u0010\f\u001a\u00020\r2\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\u000e\u001a\u00020\u000bH\u0016J@\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00122\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u00142\u0006\u0010\u0016\u001a\u00020\u00072\u0006\u0010\u0017\u001a\u00020\rH\u0016J\b\u0010\u0018\u001a\u00020\rH\u0016J\u0018\u0010\u0019\u001a\u00020\u00102\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\u001a\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/p8a7a38cf/pc2c30812/pcf6ce2df;", "Landroidx/recyclerview/widget/ItemTouchHelper$Callback;", "itemTouchHelperAdapter", "Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/p8a7a38cf/pc2c30812/pad063481;", "<init>", "(Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/p8a7a38cf/pc2c30812/pad063481;)V", "getMovementFlags", "", "recyclerobject", "Landroidx/recyclerview/widget/Recyclerobject;", "viewHolder", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "onMove", "", "target", "onChildDraw", "", "c", "Landroid/graphics/Canvas;", "dX", "", "dY", "actionState", "isCurrentlyActive", "islongPressDragEnabled", "onSwiped", "direction", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pcf6ce2df : androidx.recyclerview.widget.ItemTouchHelper$Callback {
    private readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.pad063481 f72d3166c;
    private readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.pad063481 fa48056a3;
    private readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.pad063481 fcba42de4;
    private readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.pad063481 fe2a02294;
    private readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.pad063481 ff5d1a75a;

    public pcf6ce2df(p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.pad063481 itemTouchHelperAdapter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(itemTouchHelperAdapter, "itemTouchHelperAdapter");
        this.f72d3166c = itemTouchHelperAdapter;
    }

    public override int GetMovementFlags(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder viewHolder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(recyclerobject, "recyclerobject");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(viewHolder, "viewHolder");
        return androidx.recyclerview.widget.ItemTouchHelper$Callback.makeMovementFlags(((viewHolder is p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.p49d0e439) && ((p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.p49d0e439) viewHolder).isDraggable()) ? 3 : 0, 0);
    }

    public override bool IslongPressDragEnabled() {
        return false;
    }

    public override void OnChildDraw(android.graphics.Canvas c, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder viewHolder, float dX, float dY, int actionState, bool isCurrentlyActive) {
        if ((26 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(c, "c");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(recyclerobject, "recyclerobject");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(viewHolder, "viewHolder");
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolderFindobjectHolderForAdapterPosition = recyclerobject.findobjectHolderForAdapterPosition(viewHolder.getAdapterPosition() - 1);
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolderFindobjectHolderForAdapterPosition2 = recyclerobject.findobjectHolderForAdapterPosition(viewHolder.getAdapterPosition() + 1);
        bool z = dY < 0.0f;
        if ((dY > 0.0f && !(recyclerobject$objectHolderFindobjectHolderForAdapterPosition2 is p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.p49d0e439)) || (z && !(recyclerobject$objectHolderFindobjectHolderForAdapterPosition is p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.p49d0e439))) {
            dY = 0.0f;
        }
        super.onChildDraw(c, recyclerobject, viewHolder, dX, dY, actionState, isCurrentlyActive);
    }

    public override bool OnMove(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$objectHolder viewHolder, androidx.recyclerview.widget.Recyclerobject$objectHolder target) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(recyclerobject, "recyclerobject");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(viewHolder, "viewHolder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(target, "target");
        return this.f72d3166c.onItemMove(viewHolder.getAdapterPosition(), target.getAdapterPosition());
    }

    public override void OnSwiped(androidx.recyclerview.widget.Recyclerobject$objectHolder viewHolder, int direction) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(viewHolder, "viewHolder");
    }
}

