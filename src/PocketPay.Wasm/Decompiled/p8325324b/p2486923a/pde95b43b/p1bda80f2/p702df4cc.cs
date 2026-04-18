namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0011\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005B\u0019\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\u0004\u0010\bJ\u0016\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eJ\b\u0010\u000f\u001a\u00020\u0010H\u0016J\b\u0010\u0011\u001a\u00020\u0010H\u0016¨\u0006\u0012"}, d2 = {"Lp8325324b/p2486923a/pde95b43b/p1bda80f2/p702df4cc;", "Lp59a14a57/pc02fdf0f/p9004bc47;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "attributeHashSet", "Landroid/util/AttributeHashSet;", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "initBoarding", "", "boarding", "Lpad5f82e8/p07214c67/pc02fdf0f/p94b45d4f;", "boardingListener", "Lp59a14a57/pc02fdf0f/p44573bc3;", "getCurrentText", "", "getCurrentNameBtn", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p702df4cc : p59a14a57.pc02fdf0f.p9004bc47 {
    public p702df4cc(android.content.object context) {
        super(context);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
    }

    public p702df4cc(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attributeHashSet, "attributeHashSet");
    }

    public override java.lang.string GetCurrentNameBtn() {
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(getResources().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$string.action_ok));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        return strDecryptstring;
    }

    public override java.lang.string GetCurrentText() {
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(getResources().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$string.sell_edit_note_boarding_text));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        return strDecryptstring;
    }

    public readonly void InitBoarding(pad5f82e8.p07214c67.pc02fdf0f.p94b45d4f boarding, p59a14a57.pc02fdf0f.p44573bc3 boardingListener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(boarding, "boarding");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(boardingListener, "boardingListener");
        setBoarding(boarding);
        setBoardingListener(boardingListener);
        updateBoarding();
    }
}

