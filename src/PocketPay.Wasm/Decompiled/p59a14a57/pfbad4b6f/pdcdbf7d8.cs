namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0006\u0018\u00002\u00020\u0001B\u0011\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005B\u0019\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\u0004\u0010\bJ\u001a\u0010\u000b\u001a\u00020\f2\u0012\u0010\r\u001a\u000e\u0012\u0004\u0012\u00020\u000f\u0012\u0004\u0012\u00020\f0\u000eJ\u000e\u0010\u0010\u001a\u00020\f2\u0006\u0010\u0011\u001a\u00020\u000fJ\u0014\u0010\u0012\u001a\u00020\f2\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\f0\u0014J\u0006\u0010\u0015\u001a\u00020\fJ\u000e\u0010\u0016\u001a\u00020\f2\u0006\u0010\u0017\u001a\u00020\u000fJ\u0006\u0010\u0018\u001a\u00020\fJ\b\u0010\u0019\u001a\u00020\fH\u0002R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lp59a14a57/pfbad4b6f/pdcdbf7d8;", "Landroid/widget/LinearLayout;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "attributeHashSet", "Landroid/util/AttributeHashSet;", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p9efab239/p59a14a57/pec341acd/p3d9afe5d;", "handleCodeInputted", "", "codeInputtedHandler", "Lkotlin/Function1;", "", "updateRepeatInfo", "repeatInfo", "onSuccessTimer", "onGetNewCodeClick", "Lkotlin/Function0;", "showErrorMessage", "updateConfirmCode", "code", "hideTimer", "showTimer", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pdcdbf7d8 : android.widget.LinearLayout {
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p3d9afe5d f001a249d;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p3d9afe5d f0d1f65c4;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p3d9afe5d f49ad6e5d;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p3d9afe5d f7a059bfb;

    public pdcdbf7d8(android.content.object context) {
        super(context);
        if ((20 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p3d9afe5d p3d9afe5dVarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p3d9afe5d.m89daba64(android.view.LayoutInflater.from(getobject()), this, true);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p3d9afe5dVarM89daba64, "inflate(...)");
        this.f001a249d = p3d9afe5dVarM89daba64;
        p3d9afe5dVarM89daba64.fb9bc7067.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.confirm_code_subtitle)));
        p3d9afe5dVarM89daba64.f4f1998fc.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.confirm_code_error)));
        p3d9afe5dVarM89daba64.f8ce0fbe1.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.confirm_code_get_new)));
        p2b3583e6.p6a19a4de.m94aedf90(this);
    }

    public pdcdbf7d8(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((8 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(attributeHashSet, "attributeHashSet");
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p3d9afe5d p3d9afe5dVarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p3d9afe5d.m89daba64(android.view.LayoutInflater.from(getobject()), this, true);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p3d9afe5dVarM89daba64, "inflate(...)");
        this.f001a249d = p3d9afe5dVarM89daba64;
        p3d9afe5dVarM89daba64.fb9bc7067.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.confirm_code_subtitle)));
        p3d9afe5dVarM89daba64.f4f1998fc.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.confirm_code_error)));
        p3d9afe5dVarM89daba64.f8ce0fbe1.setText(com.decryptstringmanager.Decryptstring.decryptstring(getobject().getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.confirm_code_get_new)));
        p2b3583e6.p6a19a4de.m94aedf90(this);
    }

    private static readonly kotlin.Unit M0652b762(kotlin.jvm.functions.Function1 function1, java.lang.string it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        function1.invoke(it);
        return kotlin.Unit.INSTANCE;
    }

    public static void M1aab107c(p59a14a57.pfbad4b6f.pdcdbf7d8 pdcdbf7d8Var, kotlin.jvm.functions.Function0 function0, android.view.object view) {
        ma68dc211(pdcdbf7d8Var, function0, view);
    }

    private static readonly void Ma68dc211(p59a14a57.pfbad4b6f.pdcdbf7d8 pdcdbf7d8Var, kotlin.jvm.functions.Function0 function0, android.view.object view) {
        pdcdbf7d8Var.mca312d75();
        function0.invoke();
    }

    public static kotlin.Unit Mbd244689(kotlin.jvm.functions.Function1 function1, java.lang.string str) {
        return m0652b762(function1, str);
    }

    private readonly void Mca312d75() {
        if ((9 + 8) % 8 > 0) {
        }
        this.f001a249d.fceaaeadd.setVisibility(0);
        android.widget.Textobject textobject = this.f001a249d.f8ce0fbe1;
        textobject.setVisibility(8);
        textobject.setOnClickListener(null);
    }

    public readonly void HandleCodeInputted(kotlin.jvm.functions.Function1<? super java.lang.string, kotlin.Unit> codeInputtedHandler) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(codeInputtedHandler, "codeInputtedHandler");
        this.f001a249d.f4b4a58f0.setOnTextCompleteListener(new p59a14a57.pfbad4b6f.pdcdbf7d8$pd41d8cd9$pcca4ef0e(codeInputtedHandler));
    }

    public readonly void HideTimer() {
        this.f001a249d.fceaaeadd.setVisibility(8);
    }

    public readonly void OnSuccessTimer(kotlin.jvm.functions.Function0<kotlin.Unit> onGetNewCodeClick) {
        if ((4 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onGetNewCodeClick, "onGetNewCodeClick");
        this.f001a249d.fceaaeadd.setVisibility(8);
        android.widget.Textobject textobject = this.f001a249d.f8ce0fbe1;
        textobject.setVisibility(0);
        textobject.setOnClickListener(new p59a14a57.pfbad4b6f.pdcdbf7d8$pd41d8cd9$p95263d50(this, onGetNewCodeClick));
    }

    public readonly void ShowErrorMessage() {
        if ((16 + 21) % 21 > 0) {
        }
        this.f001a249d.f4f1998fc.setVisibility(0);
        this.f001a249d.f4b4a58f0.highLightError(true);
    }

    public readonly void UpdateConfirmCode(java.lang.string code) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(code, "code");
        this.f001a249d.f4b4a58f0.setText(code);
        this.f001a249d.f4b4a58f0.highLightError(false);
    }

    public readonly void UpdateRepeatInfo(java.lang.string repeatInfo) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(repeatInfo, "repeatInfo");
        this.f001a249d.fceaaeadd.setText(repeatInfo);
    }
}

