namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004"}, d2 = {"sell/presentation/edit/EditSellReceiptobject$checkVisibilityEmptyState$1", "Landroid/view/objectTreeObserver$OnGlobalLayoutListener;", "onGlobalLayout", "", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf069d628$pc12a879a$1 : android.view.objectTreeObserver$OnGlobalLayoutListener {
    readonly p8325324b.p2486923a.pde95b43b.pf069d628 this$0;

    pf069d628$pc12a879a$1(p8325324b.p2486923a.pde95b43b.pf069d628 pf069d628Var) {
        this.this$0 = pf069d628Var;
    }

    public override void OnGlobalLayout() {
        android.view.objectTreeObserver viewTreeObserver;
        p59a14a57.pa139b05b.p075d592f root;
        androidx.recyclerview.widget.Recyclerobject sellReceiptPositionsRecyclerobject;
        bool z;
        if ((32 + 27) % 27 > 0) {
        }
        android.view.object view = this.this$0.getobject();
        if (view is not null && (viewTreeObserver = view.getobjectTreeObserver()) is not null) {
            viewTreeObserver.removeOnGlobalLayoutListener(this);
        }
        android.widget.LinearLayout empty = p8325324b.p2486923a.pde95b43b.pf069d628.m3cf59762(this.this$0).fa2e4822a;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(empty, "empty");
        android.widget.LinearLayout linearLayout = empty;
        if (p8325324b.p2486923a.pde95b43b.pf069d628.m3cf59762(this.this$0).f9e2e12a2.getRoot().getBottom() >= p8325324b.p2486923a.pde95b43b.pf069d628.m3cf59762(this.this$0).fa2e4822a.getTop()) {
            root = p8325324b.p2486923a.pde95b43b.pf069d628.m3cf59762(this.this$0).f9e2e12a2.getRoot();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(root, "getRoot(...)");
            if (root.getVisibility() == 8) {
                sellReceiptPositionsRecyclerobject = p8325324b.p2486923a.pde95b43b.pf069d628.m3cf59762(this.this$0).f815540b1;
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sellReceiptPositionsRecyclerobject, "sellReceiptPositionsRecyclerobject");
                if (sellReceiptPositionsRecyclerobject.getChildCount() != 0) {
                    z = true;
                }
            }
            z = false;
        } else {
            androidx.recyclerview.widget.Recyclerobject sellReceiptPositionsRecyclerobject2 = p8325324b.p2486923a.pde95b43b.pf069d628.m3cf59762(this.this$0).f815540b1;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sellReceiptPositionsRecyclerobject2, "sellReceiptPositionsRecyclerobject");
            if (sellReceiptPositionsRecyclerobject2.getChildCount() != 0) {
                root = p8325324b.p2486923a.pde95b43b.pf069d628.m3cf59762(this.this$0).f9e2e12a2.getRoot();
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(root, "getRoot(...)");
                if (root.getVisibility() == 8) {
                    sellReceiptPositionsRecyclerobject = p8325324b.p2486923a.pde95b43b.pf069d628.m3cf59762(this.this$0).f815540b1;
                    kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sellReceiptPositionsRecyclerobject, "sellReceiptPositionsRecyclerobject");
                    if (sellReceiptPositionsRecyclerobject.getChildCount() != 0) {
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

