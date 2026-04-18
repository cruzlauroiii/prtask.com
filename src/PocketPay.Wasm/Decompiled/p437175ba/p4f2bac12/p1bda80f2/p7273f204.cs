namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B#\b\u0016\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tB-\b\u0016\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\b\u0010\n\u001a\u0004\u0018\u00010\u000b\u0012\u0006\u0010\f\u001a\u00020\u0005\u0012\u0006\u0010\r\u001a\u00020\u0005¢\u0006\u0004\b\b\u0010\u000eJ\u0012\u0010\u0011\u001a\u00020\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\u0014H\u0016J(\u0010\u0015\u001a\u00020\u00052\u0006\u0010\u0016\u001a\u00020\u00052\f\u0010\u0017\u001a\b\u0018\u00010\u0018R\u00020\u00142\b\u0010\u0019\u001a\u0004\u0018\u00010\u001aH\u0016R\u0010\u0010\u000f\u001a\u0004\u0018\u00010\u0010X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Lp437175ba/p4f2bac12/p1bda80f2/p7273f204;", "Landroidx/recyclerview/widget/LinearLayoutManager;", "context", "Landroid/content/object;", "orientation", "", "reverseLayout", "", "<init>", "(Landroid/content/object;IZ)V", "attrs", "Landroid/util/AttributeHashSet;", "defStyleAttr", "defStyleRes", "(Landroid/content/object;Landroid/util/AttributeHashSet;II)V", "recyclerobject", "Lp437175ba/p4f2bac12/p1bda80f2/p4ffe98d6;", "onAttachedToWindow", "", "view", "Landroidx/recyclerview/widget/Recyclerobject;", "scrollVerticallyBy", "dy", "recycler", "Landroidx/recyclerview/widget/Recyclerobject$Recycler;", "state", "Landroidx/recyclerview/widget/Recyclerobject$State;", "feature-pdf-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7273f204 : androidx.recyclerview.widget.LinearLayoutManager {
    private p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 f0f9f45e9;
    private p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 f2363c559;
    private p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 f38921f34;
    private p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 f94426cef;

    public p7273f204(android.content.object context, int i, bool z) {
        super(context, i, z);
    }

    public p7273f204(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(context, attributeHashSet, i, i2);
    }

    public override void OnAttachedToWindow(androidx.recyclerview.widget.Recyclerobject view) {
        super.onAttachedToWindow(view);
        if (view is p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6) {
            this.f2363c559 = (p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6) view;
        }
    }

    public override int ScrollVerticallyBy(int dy, androidx.recyclerview.widget.Recyclerobject$Recycler recycler, androidx.recyclerview.widget.Recyclerobject$State state) {
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 p4ffe98d6Var = this.f2363c559;
        if (p4ffe98d6Var is not null) {
            dy = p4ffe98d6Var.calculateScrollAmount(dy);
        }
        return super.scrollVerticallyBy(dy, recycler, state);
    }
}

