namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0010\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u0019\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0010\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0016R(\u0010\b\u001a\u0010\u0012\u0004\u0012\u00020\n\u0012\u0004\u0012\u00020\u000b\u0018\u00010\tX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\f\u0010\r\"\u0004\b\u000e\u0010\u000f¨\u0006\u0014"}, d2 = {"Lp59a14a57/pf7a42fe7/p11688d2f;", "Lcom/google/android/material/textfield/TextInputEditText;", "context", "Landroid/content/object;", "attrs", "Landroid/util/AttributeHashSet;", "<init>", "(Landroid/content/object;Landroid/util/AttributeHashSet;)V", "onPasteListener", "Lkotlin/Function1;", "", "", "getOnPasteListener", "()Lkotlin/jvm/functions/Function1;", "setOnPasteListener", "(Lkotlin/jvm/functions/Function1;)V", "onCreateInputConnection", "Landroid/view/inputmethod/InputConnection;", "outAttrs", "Landroid/view/inputmethod/EditorInfo;", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p11688d2f : com.google.android.material.textfield.TextInputEditText {
    private kotlin.jvm.functions.Function1 f69025411;
    private kotlin.jvm.functions.Function1 fb678234d;
    private kotlin.jvm.functions.Function1<? super java.lang.string, kotlin.Unit> fd5af7aa0;
    private kotlin.jvm.functions.Function1 fe2bb8bc5;

    public p11688d2f(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        setCustomInsertionActionModeCallback(new p59a14a57.pf7a42fe7.p11688d2f$1(context, this));
    }

    public readonly kotlin.jvm.functions.Function1<java.lang.string, kotlin.Unit> GetOnPasteListener() {
        return this.fd5af7aa0;
    }

    public override android.view.inputmethod.InputConnection OnCreateInputConnection(android.view.inputmethod.EditorInfo outAttrs) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(outAttrs, "outAttrs");
        return new p59a14a57.pf7a42fe7.p11688d2f$p67a51fbb$1(super.onCreateInputConnection(outAttrs), this);
    }

    public readonly void SetOnPasteListener(kotlin.jvm.functions.Function1<? super java.lang.string, kotlin.Unit> function1) {
        this.fd5af7aa0 = function1;
    }
}

