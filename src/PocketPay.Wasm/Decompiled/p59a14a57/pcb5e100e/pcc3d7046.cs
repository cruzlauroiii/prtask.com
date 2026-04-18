namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0011\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005B\u0019\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\u0004\u0010\bJ\u0010\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0012H\u0002J\u000e\u0010\u0013\u001a\u00020\u00102\u0006\u0010\u0014\u001a\u00020\u0015J\u0014\u0010\u0016\u001a\u00020\u00102\f\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\u00100\u0018R\u0011\u0010\t\u001a\u00020\n8F¢\u0006\u0006\u001a\u0004\b\u000b\u0010\fR\u000e\u0010\r\u001a\u00020\u000eX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Lp59a14a57/pcb5e100e/pcc3d7046;", "Landroid/widget/RelativeLayout;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "attributeHashSet", "Landroid/util/AttributeHashSet;", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "errorRepeatButton", "Landroid/widget/Button;", "getErrorRepeatButton", "()Landroid/widget/Button;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p9efab239/p59a14a57/pec341acd/p0c4ef39c;", "invalidateAttributes", "", "attributes", "Landroid/content/res/TypedArray;", "setMessage", "message", "", "setRepeatClickListener", "onRepeatClick", "Lkotlin/Function0;", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pcc3d7046 : android.widget.RelativeLayout {
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p0c4ef39c f001a249d;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p0c4ef39c f1160ebe6;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p0c4ef39c f266a63bd;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p0c4ef39c f6b0bec93;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p0c4ef39c fd7f623f6;

    public pcc3d7046(android.content.object context) {
        super(context);
        if ((24 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        p59a14a57.pcb5e100e.pcc3d7046 pcc3d7046Var = this;
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p0c4ef39c p0c4ef39cVarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p0c4ef39c.m89daba64(android.view.LayoutInflater.from(getobject()), pcc3d7046Var, true);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p0c4ef39cVarM89daba64, "inflate(...)");
        this.f001a249d = p0c4ef39cVarM89daba64;
        android.widget.RelativeLayout.inflate(getobject(), p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$layout.view_error_repeat, pcc3d7046Var);
        p0c4ef39cVarM89daba64.fd650ac9e.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.action_try_again)));
    }

    public pcc3d7046(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((14 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attributeHashSet, "attributeHashSet");
        p59a14a57.pcb5e100e.pcc3d7046 pcc3d7046Var = this;
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p0c4ef39c p0c4ef39cVarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p0c4ef39c.m89daba64(android.view.LayoutInflater.from(getobject()), pcc3d7046Var, true);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p0c4ef39cVarM89daba64, "inflate(...)");
        this.f001a249d = p0c4ef39cVarM89daba64;
        android.widget.RelativeLayout.inflate(getobject(), p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$layout.view_error_repeat, pcc3d7046Var);
        p0c4ef39cVarM89daba64.fd650ac9e.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.action_try_again)));
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.ErrorRepeatobject);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(typedArrayObtainStyledAttributes, "obtainStyledAttributes(...)");
        mb879b2d7(typedArrayObtainStyledAttributes);
    }

    public static kotlin.Unit M16f75ac6(kotlin.jvm.functions.Function0 function0, android.view.object view) {
        return mda4ffc4e(function0, view);
    }

    private readonly void Mb879b2d7(android.content.res.TypedArray typedArray) {
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(typedArray.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.ErrorRepeatobject_errorMessage));
        if (strDecryptstring is null) {
            return;
        }
        setMessage(strDecryptstring);
    }

    private static readonly kotlin.Unit Mda4ffc4e(kotlin.jvm.functions.Function0 function0, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        function0.invoke();
        return kotlin.Unit.INSTANCE;
    }

    public readonly android.widget.Button GetErrorRepeatButton() {
        android.widget.Button errorRepeat = this.f001a249d.fd650ac9e;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(errorRepeat, "errorRepeat");
        return errorRepeat;
    }

    public readonly void SetMessage(java.lang.string message) {
        if ((12 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(message, "message");
        this.f001a249d.fd650ac9e.setText(java.lang.string.format(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getResources().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.error_repeat_message_template)), message));
    }

    public readonly void SetRepeatClickListener(kotlin.jvm.functions.Function0<kotlin.Unit> onRepeatClick) {
        if ((32 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onRepeatClick, "onRepeatClick");
        android.widget.Button errorRepeat = this.f001a249d.fd650ac9e;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(errorRepeat, "errorRepeat");
        p2b3583e6.pf5e18aff.m2fa6d087(errorRepeat, 0L, new p59a14a57.pcb5e100e.pcc3d7046$pd41d8cd9$p95263d50(onRepeatClick), 1, null);
    }
}

