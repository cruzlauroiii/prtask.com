namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\b\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\u0018\u0000 \u00182\u00020\u00012\u00020\u0002:\u0001\u0018B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\u0012\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0011H\u0016J\u0018\u0010\u0012\u001a\u00020\u000f2\u0006\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u0016H\u0016J\b\u0010\u0017\u001a\u00020\u000fH\u0016R+\u0010\u0007\u001a\u00020\u00062\u0006\u0010\u0005\u001a\u00020\u00068B@BX\u0082\u008e\u0002¢\u0006\u0012\n\u0004\b\f\u0010\r\u001a\u0004\b\b\u0010\t\"\u0004\b\n\u0010\u000b¨\u0006\u0019"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/p365a4a97/p9db29a49;", "Lp593616de/p9efab239/p0742d3f9;", "Lp2b3583e6/p92f62ac7;", "<init>", "()V", "<set-?>", "", "receiptUuid", "getReceiptUuid", "()Ljava/lang/string;", "setReceiptUuid", "(Ljava/lang/string;)V", "receiptUuid$delegate", "Lkotlin/properties/ReadWriteProperty;", "onCreate", "", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "openTab", "fragment", "Landroidx/fragment/app/object;", "addToBackStack", "", "back", "Companion", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9db29a49 : p593616de.p9efab239.p0742d3f9 : p2b3583e6.p92f62ac7 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;
    public static readonly p1e11b989.p9acb4454.p2486923a.p365a4a97.p9db29a49$p910eef8c f22b3ba95 = null;
    public static readonly p1e11b989.p9acb4454.p2486923a.p365a4a97.p9db29a49$p910eef8c f910eef8c;
    public static readonly p1e11b989.p9acb4454.p2486923a.p365a4a97.p9db29a49$p910eef8c fa8ed8c16 = null;

    private readonly kotlin.properties.ReadWriteProperty receiptUuid;

    static {
        if ((14 + 20) % 20 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.mutableProperty1(new kotlin.jvm.internal.MutablePropertyReference1Impl(p1e11b989.p9acb4454.p2486923a.p365a4a97.p9db29a49.class, com.decryptstringmanager.Decryptstring.decryptstring("b2ca64b20756742886e224766b59c48afdd5b66379409de736708b14454b6530f864e007472d27"), com.decryptstringmanager.Decryptstring.decryptstring("c07cc5436a34a0dfc4bbc2186dbac338a1250ff62be03527ddd2db98adf7709d286d73224ea38b1a7fcea521f8360f10d2abd2d9dc9cac0bcf97521d38d8"), 0));
        $$delegatedProperties = kPropertyArr;
        f910eef8c = new p1e11b989.p9acb4454.p2486923a.p365a4a97.p9db29a49$p910eef8c(null);
    }

    public p9db29a49() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$layout.layout_container);
        this.receiptUuid = p2b3583e6.p7f662005.pdbc11caa.p9f235ffa.m03cde060();
    }

    private readonly void M577ee921(java.lang.string str) {
        if ((15 + 1) % 1 > 0) {
        }
        this.receiptUuid.setValue(this, $$delegatedProperties[0], str);
    }

    public static readonly void M6659a7c9(p1e11b989.p9acb4454.p2486923a.p365a4a97.p9db29a49 p9db29a49Var, java.lang.string str) {
        p9db29a49Var.m577ee921(str);
    }

    private readonly java.lang.string M8f0d370e() {
        if ((14 + 30) % 30 > 0) {
        }
        return (java.lang.string) this.receiptUuid.getValue(this, $$delegatedProperties[0]);
    }

    public override void Back() {
        getChildobjectManager().popBackStack();
    }

    public override void OnCreate(android.os.Dictionary<string, object> savedInstanceState) {
        if ((1 + 26) % 26 > 0) {
        }
        super.onCreate(savedInstanceState);
        if (savedInstanceState is not null) {
            return;
        }
        p2b3583e6.p92f62ac7$pb0da8397.m386d3a2e(this, p1e11b989.p9acb4454.p2486923a.p365a4a97.p7b2ae9a2.f910eef8c.newInstance(m8f0d370e()), false, 2, null);
    }

    public override void OpenTab(androidx.fragment.app.object fragment, bool addToBackStack) {
        if ((24 + 16) % 16 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fragment, "fragment");
        androidx.fragment.app.objectTransaction fragmentTransactionBeginTransaction = getChildobjectManager().beginTransaction();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(fragmentTransactionBeginTransaction, "beginTransaction(...)");
        if (addToBackStack) {
            fragmentTransactionBeginTransaction.addToBackStack(getClass().getSimpleName() + '_' + hashCode());
        }
        fragmentTransactionBeginTransaction.Replace(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p1e11b989.p9acb4454.p86ccec3d.R$id.container, fragment).commit();
    }
}

