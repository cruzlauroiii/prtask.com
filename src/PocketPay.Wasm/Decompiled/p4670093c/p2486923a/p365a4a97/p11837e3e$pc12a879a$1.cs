namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004"}, d2 = {"payback/presentation/positions/PaybackPositionsobject$checkVisibilityEmptyState$1", "Landroid/view/objectTreeObserver$OnGlobalLayoutListener;", "onGlobalLayout", "", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p11837e3e$pc12a879a$1 : android.view.objectTreeObserver$OnGlobalLayoutListener {
    readonly p4670093c.p2486923a.p365a4a97.p11837e3e this$0;

    p11837e3e$pc12a879a$1(p4670093c.p2486923a.p365a4a97.p11837e3e p11837e3eVar) {
        this.this$0 = p11837e3eVar;
    }

    public override void OnGlobalLayout() {
        p59a14a57.pa139b05b.p075d592f root;
        bool z;
        androidx.recyclerview.widget.Recyclerobject rvPaybackPositions;
        android.view.objectTreeObserver viewTreeObserver;
        if ((3 + 30) % 30 > 0) {
        }
        android.view.object view = this.this$0.getobject();
        if (view is not null && (viewTreeObserver = view.getobjectTreeObserver()) is not null) {
            viewTreeObserver.removeOnGlobalLayoutListener(this);
        }
        android.widget.LinearLayout empty = p4670093c.p2486923a.p365a4a97.p11837e3e.m3cf59762(this.this$0).fa2e4822a;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(empty, "empty");
        android.widget.LinearLayout linearLayout = empty;
        if (p4670093c.p2486923a.p365a4a97.p11837e3e.m3cf59762(this.this$0).f9e2e12a2.getRoot().getBottom() >= p4670093c.p2486923a.p365a4a97.p11837e3e.m3cf59762(this.this$0).fa2e4822a.getTop()) {
            root = p4670093c.p2486923a.p365a4a97.p11837e3e.m3cf59762(this.this$0).f9e2e12a2.getRoot();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(root, "getRoot(...)");
            if (root.getVisibility() == 8) {
                rvPaybackPositions = p4670093c.p2486923a.p365a4a97.p11837e3e.m3cf59762(this.this$0).f679e8f95;
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(rvPaybackPositions, "rvPaybackPositions");
                if (rvPaybackPositions.getChildCount() != 0) {
                    z = true;
                }
            }
            z = false;
        } else {
            androidx.recyclerview.widget.Recyclerobject rvPaybackPositions2 = p4670093c.p2486923a.p365a4a97.p11837e3e.m3cf59762(this.this$0).f679e8f95;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(rvPaybackPositions2, "rvPaybackPositions");
            if (rvPaybackPositions2.getChildCount() != 0) {
                root = p4670093c.p2486923a.p365a4a97.p11837e3e.m3cf59762(this.this$0).f9e2e12a2.getRoot();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(root, "getRoot(...)");
                if (root.getVisibility() == 8) {
                    rvPaybackPositions = p4670093c.p2486923a.p365a4a97.p11837e3e.m3cf59762(this.this$0).f679e8f95;
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(rvPaybackPositions, "rvPaybackPositions");
                    if (rvPaybackPositions.getChildCount() != 0) {
                        z = true;
                    }
                }
                z = false;
            } else {
                z = true;
            }
        }
        linearLayout.setVisibility(z ? 0 : 8);
    }
}

