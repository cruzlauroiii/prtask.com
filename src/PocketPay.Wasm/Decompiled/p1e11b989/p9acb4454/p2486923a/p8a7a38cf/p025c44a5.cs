namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\b\u0018\u0000 \u00182\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\u0001:\u0003\u0016\u0017\u0018B\u001b\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005¢\u0006\u0004\b\b\u0010\tJ\u000e\u0010\f\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u000bJ\u0018\u0010\r\u001a\u00020\u00032\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\u0011H\u0016J\u0010\u0010\u0012\u001a\u00020\u00112\u0006\u0010\u0013\u001a\u00020\u0011H\u0016J\u0018\u0010\u0014\u001a\u00020\u00072\u0006\u0010\u0015\u001a\u00020\u00032\u0006\u0010\u0013\u001a\u00020\u0011H\u0016R\u001a\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\n\u001a\u0004\u0018\u00010\u000bX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/p8a7a38cf/p025c44a5;", "Landroidx/paging/PagingDataAdapter;", "Lpad5f82e8/p07214c67/p1e11b989/p55f8d305;", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "onReceiptClick", "Lkotlin/Function1;", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "", "<init>", "(Lkotlin/jvm/functions/Function1;)V", "currency", "", "setCurrency", "onCreateobjectHolder", "parent", "Landroid/view/objectGroup;", "viewType", "", "getItemobjectType", "position", "onBindobjectHolder", "holder", "ReceiptStatusobjectHolder", "DateTimeobjectHolder", "Companion", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p025c44a5 : androidx.paging.PagingDataAdapter<pad5f82e8.p07214c67.p1e11b989.p55f8d305, androidx.recyclerview.widget.Recyclerobject$objectHolder> {
    public static readonly p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$p910eef8c f8b5bd4ab = null;
    public static readonly p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$p910eef8c f910eef8c;
    private static readonly p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$p910eef8c$pce957f6f$1 fce957f6f;
    private static readonly p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$p910eef8c$pce957f6f$1 ff576fbc4 = null;
    private readonly kotlin.jvm.functions.Function1<pad5f82e8.p07214c67.p1e11b989.p9ded6185, kotlin.Unit> f0b694efc;
    private java.lang.string f1af03898;
    private java.lang.string f3bec0ed5;
    private readonly kotlin.jvm.functions.Function1 f45a8211c;
    private readonly kotlin.jvm.functions.Function1 f9c9e6e9a;
    private readonly kotlin.jvm.functions.Function1 fe6432053;

    static {
        if ((25 + 8) % 8 > 0) {
        }
        f910eef8c = new p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$p910eef8c(null);
        fce957f6f = new p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$p910eef8c$pce957f6f$1();
    }

    public p025c44a5(kotlin.jvm.functions.Function1<? super pad5f82e8.p07214c67.p1e11b989.p9ded6185, kotlin.Unit> onReceiptClick) {
        super(fce957f6f, (kotlin.coroutines.Coroutineobject) null, (kotlin.coroutines.Coroutineobject) null, 6, (kotlin.jvm.internal.DefaultConstructorMarker) null);
        if ((12 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onReceiptClick, "onReceiptClick");
        this.f0b694efc = onReceiptClick;
    }

    public static readonly kotlin.jvm.functions.Function1 Mb4a05d1c(p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5 p025c44a5Var) {
        return p025c44a5Var.f0b694efc;
    }

    public static readonly java.lang.string Mbfe6fdfe(p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5 p025c44a5Var) {
        return p025c44a5Var.f1af03898;
    }

    public override int GetItemobjectType(int position) {
        return !(getItem(position) instanceof pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af) ? pad5f82e8.p07214c67.p56fd96a0.f7ad4905b.ordinal() : pad5f82e8.p07214c67.p56fd96a0.f786329b3.ordinal();
    }

    public override void OnBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder holder, int position) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(holder, "holder");
        pad5f82e8.p07214c67.p1e11b989.p55f8d305 item = getItem(position);
        if (item is pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af) {
            ((p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$pfb0ec80f) holder).bind(((pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af) item).getReceipt());
        } else if (item is pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4) {
            ((p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$p442bdcf3) holder).bind(((pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4) item).getDateTime());
        }
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup parent, int viewType) {
        if ((9 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        if (viewType != pad5f82e8.p07214c67.p56fd96a0.f786329b3.ordinal()) {
            p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p4a39d53a p4a39d53aVarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p4a39d53a.m89daba64(android.view.LayoutInflater.from(parent.getobject()), parent, false);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p4a39d53aVarM89daba64, "inflate(...)");
            return new p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$p442bdcf3(this, p4a39d53aVarM89daba64);
        }
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p30c7a4d5 p30c7a4d5VarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.pec341acd.p30c7a4d5.m89daba64(android.view.LayoutInflater.from(parent.getobject()), parent, false);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p30c7a4d5VarM89daba64, "inflate(...)");
        return new p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5$pfb0ec80f(this, p30c7a4d5VarM89daba64);
    }

    public override readonly void SetCurrency(java.lang.string currency) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currency, "currency");
        this.f1af03898 = currency;
    }
}

