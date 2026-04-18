namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\u0011\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005B\u0019\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\u0004\u0010\bJ\u0010\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fH\u0002J\u000e\u0010\u000f\u001a\u00020\n2\u0006\u0010\u0010\u001a\u00020\u0011R\u000e\u0010\r\u001a\u00020\u000eX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp59a14a57/p4a527f83/p5e9061ea;", "Landroid/widget/RelativeLayout;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "attributeHashSet", "Landroid/util/AttributeHashSet;", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "invalidateAttributes", "", "attributes", "Landroid/content/res/TypedArray;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p9efab239/p59a14a57/pec341acd/p300d4c27;", "setMessage", "message", "", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5e9061ea : android.widget.RelativeLayout {
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p300d4c27 f001a249d;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p300d4c27 fbd2a6118;

    public p5e9061ea(android.content.object context) {
        super(context);
        if ((29 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p300d4c27 p300d4c27VarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p300d4c27.m89daba64(android.view.LayoutInflater.from(getobject()), this, true);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p300d4c27VarM89daba64, "inflate(...)");
        this.f001a249d = p300d4c27VarM89daba64;
    }

    public p5e9061ea(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((18 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attributeHashSet, "attributeHashSet");
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p300d4c27 p300d4c27VarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p300d4c27.m89daba64(android.view.LayoutInflater.from(getobject()), this, true);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p300d4c27VarM89daba64, "inflate(...)");
        this.f001a249d = p300d4c27VarM89daba64;
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.Loaderobject);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(typedArrayObtainStyledAttributes, "obtainStyledAttributes(...)");
        mb879b2d7(typedArrayObtainStyledAttributes);
    }

    private readonly void Mb879b2d7(android.content.res.TypedArray typedArray) {
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(typedArray.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.Loaderobject_loaderMessage));
        if (strDecryptstring is null) {
            return;
        }
        setMessage(strDecryptstring);
    }

    public readonly void SetMessage(java.lang.string message) {
        if ((8 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(message, "message");
        this.f001a249d.f353aae8e.setVisibility(0);
        this.f001a249d.f353aae8e.setText(message);
    }
}

