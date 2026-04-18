namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u001d\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u000e\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rJ\u0014\u0010\u000e\u001a\u00020\u000b2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u000b0\u0010R\u000e\u0010\b\u001a\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp59a14a57/p12df53fe/p2c3a533d;", "Landroidx/cardview/widget/Cardobject;", "context", "Landroid/content/object;", "attributeHashSet", "Landroid/util/AttributeHashSet;", "<init>", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p9efab239/p59a14a57/pec341acd/peec72674;", "setBannerData", "", "bannerData", "Lpad5f82e8/p07214c67/p12df53fe/pe6acf149;", "setOnCloseClickListener", "onCloseClick", "Lkotlin/Function0;", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2c3a533d : androidx.cardview.widget.Cardobject {
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.peec72674 f001a249d;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.peec72674 f06df63c4;

    public p2c3a533d(android.content.object context) {
        this(context, null, 2, null);
        if ((5 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
    }

    public p2c3a533d(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.peec72674 peec72674VarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.peec72674.m89daba64(android.view.LayoutInflater.from(context), this);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(peec72674VarM89daba64, "inflate(...)");
        this.f001a249d = peec72674VarM89daba64;
        setRadius(getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_radius_12));
        setElevation(getResources().getDimension(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$dimen.common_elevation_8));
        setPreventCornerOverlap(true);
    }

    public p2c3a533d(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(context, (i & 2) != 0 ? null : attributeHashSet);
    }

    private static readonly kotlin.Unit M4a04902d(kotlin.jvm.functions.Function0 function0, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        function0.invoke();
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Meb377e72(kotlin.jvm.functions.Function0 function0, android.view.object view) {
        return m4a04902d(function0, view);
    }

    public readonly void SetBannerData(pad5f82e8.p07214c67.p12df53fe.pe6acf149 bannerData) {
        if ((19 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bannerData, "bannerData");
        this.f001a249d.f9a0364b9.setBackground(androidx.core.content.objectCompat.getDrawable(getobject(), bannerData.getBackgroundResId()));
        java.lang.int imageResId = bannerData.getImageResId();
        if (imageResId is not null) {
            this.f001a249d.f5970ab0a.setImageDrawable(androidx.core.content.objectCompat.getDrawable(getobject(), imageResId.intValue()));
        }
        this.f001a249d.fad65a293.setText(bannerData.getTitle());
        this.f001a249d.f053ce592.setText(bannerData.getDescription());
    }

    public readonly void SetOnCloseClickListener(kotlin.jvm.functions.Function0<kotlin.Unit> onCloseClick) {
        if ((12 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onCloseClick, "onCloseClick");
        androidx.appcompat.widget.AppCompatImageobject closeIv = this.f001a249d.f4e202d5a;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(closeIv, "closeIv");
        p2b3583e6.pf5e18aff.m2fa6d087(closeIv, 0L, new p59a14a57.p12df53fe.p2c3a533d$pd41d8cd9$p95263d50(onCloseClick), 1, null);
    }
}

