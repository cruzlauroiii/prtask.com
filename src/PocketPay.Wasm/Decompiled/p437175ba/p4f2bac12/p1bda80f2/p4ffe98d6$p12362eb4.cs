namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\b\u0082\u0004\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\t\u001a\u00020\n2\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\u000b"}, d2 = {"Lp437175ba/p4f2bac12/p1bda80f2/p4ffe98d6$p12362eb4;", "Landroid/view/ScaleGestureDetector$OnScaleGestureListener;", "<init>", "(Lp437175ba/p4f2bac12/p1bda80f2/p4ffe98d6;)V", "onScaleBegin", "", "detector", "Landroid/view/ScaleGestureDetector;", "onScale", "onScaleEnd", "", "feature-pdf-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class p4ffe98d6$p12362eb4 : android.view.ScaleGestureDetector$OnScaleGestureListener {
    readonly p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 this$0;

    public p4ffe98d6$p12362eb4(p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 p4ffe98d6Var) {
        this.this$0 = p4ffe98d6Var;
    }

    public override bool OnScale(android.view.ScaleGestureDetector detector) {
        if ((4 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(detector, "detector");
        float fM79b484e5 = p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m79b484e5(this.this$0);
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 p4ffe98d6Var = this.this$0;
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m3fda33aa(p4ffe98d6Var, p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m79b484e5(p4ffe98d6Var) * detector.getScaleFactor());
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 p4ffe98d6Var2 = this.this$0;
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m3fda33aa(p4ffe98d6Var2, kotlin.ranges.RangesKt.coerceIn(p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m79b484e5(p4ffe98d6Var2), 1.0f, this.this$0.getMaxZoom()));
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m8ba5aa80(this.this$0, (r1.getWidth() * p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m79b484e5(this.this$0)) - this.this$0.getWidth());
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.mecd4a682(this.this$0, (r1.getHeight() * p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m79b484e5(this.this$0)) - this.this$0.getHeight());
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.mc1e341cb(this.this$0, detector.getFocusX());
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m921727cf(this.this$0, detector.getFocusY());
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 p4ffe98d6Var3 = this.this$0;
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m44ba5201(p4ffe98d6Var3, p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m87058b54(p4ffe98d6Var3) + (p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m6b646992(this.this$0) * (fM79b484e5 - p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m79b484e5(this.this$0))));
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 p4ffe98d6Var4 = this.this$0;
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m44ba5201(p4ffe98d6Var4, kotlin.ranges.RangesKt.coerceIn(p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m87058b54(p4ffe98d6Var4), -p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m06dc56ef(this.this$0), 0.0f));
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 p4ffe98d6Var5 = this.this$0;
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m3949319b(p4ffe98d6Var5, p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.mec4a04eb(p4ffe98d6Var5) + (p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.mfcd13729(this.this$0) * (fM79b484e5 - p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m79b484e5(this.this$0))));
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 p4ffe98d6Var6 = this.this$0;
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m3949319b(p4ffe98d6Var6, kotlin.ranges.RangesKt.coerceIn(p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.mec4a04eb(p4ffe98d6Var6), -p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m38c05cac(this.this$0), 0.0f));
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6 p4ffe98d6Var7 = this.this$0;
        p4ffe98d6Var7.setOverScrollMode(p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m79b484e5(p4ffe98d6Var7) <= 1.0f ? 1 : 2);
        this.this$0.invalidate();
        return true;
    }

    public override bool OnScaleBegin(android.view.ScaleGestureDetector detector) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(detector, "detector");
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m568566ec(this.this$0, true);
        return true;
    }

    public override void OnScaleEnd(android.view.ScaleGestureDetector detector) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(detector, "detector");
        p437175ba.p4f2bac12.p1bda80f2.p4ffe98d6.m568566ec(this.this$0, false);
    }
}

