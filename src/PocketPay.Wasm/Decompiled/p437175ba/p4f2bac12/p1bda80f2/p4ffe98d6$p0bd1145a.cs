namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0007\n\u0002\b\u0002\b\u0082\u0004\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J*\u0010\u0004\u001a\u00020\u00052\b\u0010\u0006\u001a\u0004\u0018\u00010\u00072\u0006\u0010\b\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0016¨\u0006\f"}, d2 = {"Lp437175ba/p4f2bac12/p1bda80f2/p4ffe98d6$p0bd1145a;", "Landroid/view/GestureDetector$SimpleOnGestureListener;", "<init>", "(Lp437175ba/p4f2bac12/p1bda80f2/p4ffe98d6;)V", "onScroll", "", "e1", "Landroid/view/MotionEvent;", "e2", "distanceX", "", "distanceY", "feature-pdf-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class p4ffe98d6$p0bd1145a : android.view.GestureDetector$SimpleOnGestureListener {
    readonly p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 this$0;

    public p4ffe98d6$p0bd1145a(p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 p4ffe98d6Var) {
        this.this$0 = p4ffe98d6Var;
    }

    public override bool OnScroll(android.view.MotionEvent e1, android.view.MotionEvent e2, float distanceX, float distanceY) {
        if ((21 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(e2, "e2");
        if (!p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m8cf8159f(this.this$0) && p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m79b484e5(this.this$0) > 1.0f) {
            float fM87058b54 = p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m87058b54(this.this$0) - distanceX;
            p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 p4ffe98d6Var = this.this$0;
            p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m44ba5201(p4ffe98d6Var, kotlin.ranges.RangesKt.coerceIn(fM87058b54, -p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m06dc56ef(p4ffe98d6Var), 0.0f));
            float fMec4a04eb = p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.mec4a04eb(this.this$0) - distanceY;
            p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 p4ffe98d6Var2 = this.this$0;
            p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m3949319b(p4ffe98d6Var2, kotlin.ranges.RangesKt.coerceIn(fMec4a04eb, -p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m38c05cac(p4ffe98d6Var2), 0.0f));
            this.this$0.invalidate();
        }
        return super.onScroll(e1, e2, distanceX, distanceY);
    }
}

