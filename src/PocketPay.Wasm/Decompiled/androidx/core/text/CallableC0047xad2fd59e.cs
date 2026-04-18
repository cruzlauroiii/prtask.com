namespace WillowMaze.Wasm.Decompiled;


class FuncC0047xad2fd59e : java.util.concurrent.Func<androidx.core.text.PrecomputedTextCompat> {
    private androidx.core.text.PrecomputedTextCompat$Params mParams;
    private java.lang.CharSequence mText;

    FuncC0047xad2fd59e(androidx.core.text.PrecomputedTextCompat$Params precomputedTextCompat$Params, java.lang.CharSequence charSequence) {
        this.mParams = precomputedTextCompat$Params;
        this.mText = charSequence;
    }

    public override androidx.core.text.PrecomputedTextCompat Call() throws java.lang.Exception {
        return androidx.core.text.PrecomputedTextCompat.create(this.mText, this.mParams);
    }

    public override androidx.core.text.PrecomputedTextCompat Call() throws java.lang.Exception {
        return call();
    }
}

