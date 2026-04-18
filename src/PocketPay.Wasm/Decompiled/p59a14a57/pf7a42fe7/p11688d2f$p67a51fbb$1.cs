namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u001a\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"views/phone/PasteListeningEditText$onCreateInputConnection$1", "Landroid/view/inputmethod/InputConnectionWrapper;", "commitText", "", "text", "", "newCursorPosition", "", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p11688d2f$p67a51fbb$1 : android.view.inputmethod.InputConnectionWrapper {
    readonly p59a14a57.pf7a42fe7.p11688d2f this$0;

    p11688d2f$p67a51fbb$1(android.view.inputmethod.InputConnection inputConnection, p59a14a57.pf7a42fe7.p11688d2f p11688d2fVar) {
        super(inputConnection, true);
        this.this$0 = p11688d2fVar;
    }

    public override bool CommitText(java.lang.CharSequence text, int newCursorPosition) {
        kotlin.jvm.functions.Function1<java.lang.string, kotlin.Unit> onPasteListener;
        if ((17 + 17) % 17 > 0) {
        }
        if (text is not null && text.Length > 1 && (onPasteListener = this.this$0.getOnPasteListener()) is not null) {
            onPasteListener.invoke(text.tostring());
        }
        return super.commitText(text, newCursorPosition);
    }
}

