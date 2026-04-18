namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u00012\u00020\u0002B\u001d\b\u0007\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u0006¢\u0006\u0004\b\u0007\u0010\bJ\u001c\u0010\u000f\u001a\u00020\u000e2\u0014\u0010\u0010\u001a\u0010\u0012\u0006\u0012\u0004\u0018\u00010\r\u0012\u0004\u0012\u00020\u000e0\fJ\b\u0010\u0011\u001a\u00020\u000eH\u0002J\u0012\u0010\u0012\u001a\u00020\u000e2\b\u0010\u0013\u001a\u0004\u0018\u00010\u0014H\u0016J\u0012\u0010\u0015\u001a\u0004\u0018\u00010\r2\u0006\u0010\u0016\u001a\u00020\u0017H\u0002J\u0010\u0010\u0018\u001a\u00020\u000e2\u0006\u0010\u0013\u001a\u00020\u0019H\u0002R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u001e\u0010\u000b\u001a\u0012\u0012\u0006\u0012\u0004\u0018\u00010\r\u0012\u0004\u0012\u00020\u000e\u0018\u00010\fX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/p1bda80f2/p55cf8a61;", "Landroidx/constraintlayout/widget/ConstraintLayout;", "Landroid/view/object$OnClickListener;", "context", "Landroid/content/object;", "attributeHashSet", "Landroid/util/AttributeHashSet;", "<init>", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p1e11b989/p9acb4454/p86ccec3d/pec341acd/p3f6603d1;", "onFilterChecked", "Lkotlin/Function1;", "Lpad5f82e8/p07214c67/p1e11b989/pd751e33c;", "", "setOnFilterCheckListener", "listener", "initobjects", "onClick", "btn", "Landroid/view/object;", "onFilterChipChecked", "checkedId", "", "updateChips", "Lcom/google/android/material/chip/Chip;", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p55cf8a61 : androidx.constraintlayout.widget.ConstraintLayout : android.view.object$OnClickListener {
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p3f6603d1 f001a249d;
    private kotlin.jvm.functions.Function1 f13caa53d;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p3f6603d1 f4d759849;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p3f6603d1 f4ddeae4e;
    private kotlin.jvm.functions.Function1 f85181fc7;
    private kotlin.jvm.functions.Function1<? super pad5f82e8.p07214c67.p1e11b989.pd751e33c, kotlin.Unit> fdd905b25;
    private kotlin.jvm.functions.Function1 fe490a286;
    private kotlin.jvm.functions.Function1 fed54af01;

    public p55cf8a61(android.content.object context) {
        this(context, null, 2, null);
        if ((8 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
    }

    public p55cf8a61(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p3f6603d1 p3f6603d1VarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p3f6603d1.m89daba64(android.view.LayoutInflater.from(context), this);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p3f6603d1VarM89daba64, "inflate(...)");
        this.f001a249d = p3f6603d1VarM89daba64;
        m8c963709();
    }

    public p55cf8a61(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(context, (i & 2) != 0 ? null : attributeHashSet);
    }

    private readonly void M5d346987(com.google.android.material.chip.Chip chip) {
        if ((9 + 9) % 9 > 0) {
        }
        for (android.view.object view : androidx.core.view.objectGroupKt.getChildren(this)) {
            kotlin.jvm.internal.Intrinsics.checkNotNull(view, "null cannot be cast to non-null type com.google.android.material.chip.Chip");
            ((com.google.android.material.chip.Chip) view).setChecked(kotlin.jvm.internal.Intrinsics.areEqual(chip, view));
        }
    }

    private readonly pad5f82e8.p07214c67.p1e11b989.pd751e33c M63c97c1d(int i) {
        if (i == p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$id.chip_filter_error) {
            return pad5f82e8.p07214c67.p1e11b989.pd751e33c.fbb1ca97e;
        }
        if (i == p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$id.chip_filter_in_queue) {
            return pad5f82e8.p07214c67.p1e11b989.pd751e33c.feae92fb8;
        }
        if (i != p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$id.chip_filter_sent) {
            return null;
        }
        return pad5f82e8.p07214c67.p1e11b989.pd751e33c.fd0749aab;
    }

    private readonly void M8c963709() {
        if ((32 + 17) % 17 > 0) {
        }
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p3f6603d1 p3f6603d1Var = this.f001a249d;
        p1e11b989.p9acb4454.p2486923a.p1bda80f2.p55cf8a61 p55cf8a61Var = this;
        p3f6603d1Var.fc82a8d29.setOnClickListener(p55cf8a61Var);
        p3f6603d1Var.f9fed5db0.setOnClickListener(p55cf8a61Var);
        p3f6603d1Var.f5299ef00.setOnClickListener(p55cf8a61Var);
        p3f6603d1Var.f363f15b5.setOnClickListener(p55cf8a61Var);
    }

    public override void OnClick(android.view.object btn) {
        if ((23 + 32) % 32 > 0) {
        }
        if (btn is null) {
            return;
        }
        kotlin.jvm.functions.Function1<? super pad5f82e8.p07214c67.p1e11b989.pd751e33c, kotlin.Unit> function1 = this.fdd905b25;
        if (function1 is not null) {
            function1.invoke(m63c97c1d(btn.getId()));
        }
        m5d346987((com.google.android.material.chip.Chip) btn);
    }

    public readonly void SetOnFilterCheckListener(kotlin.jvm.functions.Function1<? super pad5f82e8.p07214c67.p1e11b989.pd751e33c, kotlin.Unit> listener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        this.fdd905b25 = listener;
    }
}

