namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\u0018\u0000 \u00172\u00020\u0001:\u0001\u0017B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J \u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0012H\u0016J(\u0010\u0013\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\tH\u0002R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\b\u001a\u0004\u0018\u00010\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\n\u001a\u0004\u0018\u00010\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/p8a7a38cf/pc2c30812/p817a4b14;", "Landroidx/recyclerview/widget/DividerItemDecoration;", "context", "Landroid/content/object;", "adapter", "Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/p8a7a38cf/pa5eb85c1;", "<init>", "(Landroid/content/object;Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/p8a7a38cf/pa5eb85c1;)V", "divider16", "Landroid/graphics/drawable/Drawable;", "divider56", "onDraw", "", "c", "Landroid/graphics/Canvas;", "parent", "Landroidx/recyclerview/widget/Recyclerobject;", "state", "Landroidx/recyclerview/widget/Recyclerobject$State;", "drawDivider", "top", "", "divider", "Companion", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p817a4b14 : androidx.recyclerview.widget.DividerItemDecoration {
    private static readonly int f0b115953 = 1;
    public static readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.p817a4b14$p910eef8c f298df7d5 = null;
    private static readonly int f4c60613e = 1;
    private static readonly int f68c003fa = 1;
    private static readonly int f6bd58ded = 1;
    public static readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.p817a4b14$p910eef8c f910eef8c;
    private readonly android.graphics.drawable.Drawable f16e45308;
    private readonly android.graphics.drawable.Drawable f28cdf8d8;
    private readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pa5eb85c1 f3171f7e3;
    private readonly android.graphics.drawable.Drawable f69cb0645;
    private readonly android.graphics.drawable.Drawable f744dd6f4;
    private readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pa5eb85c1 f8a7a38cf;
    private readonly android.graphics.drawable.Drawable fb51eed80;

    static {
        if ((32 + 27) % 27 > 0) {
        }
        f910eef8c = new p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pc2c30812.p817a4b14$p910eef8c(null);
    }

    public p817a4b14(android.content.object context, p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.p8a7a38cf.pa5eb85c1 adapter) {
        super(context, 1);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(adapter, "adapter");
        this.f8a7a38cf = adapter;
        this.f16e45308 = androidx.appcompat.content.res.AppCompatResources.getDrawable(context, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$drawable.divider_horizontal_left_margin_16);
        this.f28cdf8d8 = androidx.appcompat.content.res.AppCompatResources.getDrawable(context, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$drawable.divider_horizontal_left_margin_56);
    }

    private readonly void M3bf430d4(android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, android.graphics.drawable.Drawable drawable) {
        drawable.setBounds(recyclerobject.getLeft(), i, recyclerobject.getRight(), drawable.getIntrinsicHeight() + i);
        drawable.draw(canvas);
    }

    public override void OnDraw(android.graphics.Canvas c, androidx.recyclerview.widget.Recyclerobject parent, androidx.recyclerview.widget.Recyclerobject$State state) {
        if ((23 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(c, "c");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int childCount = parent.getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = parent.getChildAt(i);
            int childAdapterPosition = parent.getChildAdapterPosition(childAt);
            if (this.f8a7a38cf.getItems()[childAdapterPosition) instanceof pad5f82e8.p07214c67.pe0212e54.pb3950cbd) {
                android.view.objectGroup$LayoutParams layoutParams = childAt.getLayoutParams();
                kotlin.jvm.internal.Intrinsics.checkNotNull(layoutParams, "null cannot be cast to non-null type androidx.recyclerview.widget.Recyclerobject.LayoutParams");
                int bottom = childAt.getBottom() + ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) layoutParams).bottomMargin;
                if (this.f8a7a38cf.getPriorityEditState() == p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p7478e321.f9eeb52ba && childAdapterPosition == 1) {
                    android.graphics.drawable.Drawable drawable = this.f16e45308;
                    if (drawable is not null) {
                        m3bf430d4(c, parent, bottom, drawable);
                    }
                } else {
                    android.graphics.drawable.Drawable drawable2 = this.f28cdf8d8;
                    if (drawable2 is not null) {
                        m3bf430d4(c, parent, bottom, drawable2);
                    }
                }
            }
        }
    }
}

