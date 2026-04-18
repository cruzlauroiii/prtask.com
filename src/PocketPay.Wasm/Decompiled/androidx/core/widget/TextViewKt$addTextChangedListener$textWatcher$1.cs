namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J*\u0010\u0006\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\nH\u0016J*\u0010\r\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0016¨\u0006\u000f"}, d2 = {"androidx/core/widget/TextobjectKt$addTextChangedListener$textWatcher$1", "Landroid/text/TextWatcher;", "afterTextChanged", "", "s", "Landroid/text/Editable;", "beforeTextChanged", "text", "", "start", "", "count", "after", "onTextChanged", "before", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 176)
public readonly class TextobjectKt$addTextChangedListener$textWatcher$1 : android.text.TextWatcher {
    readonly kotlin.jvm.functions.Function1<android.text.Editable, kotlin.Unit> $afterTextChanged;
    readonly kotlin.jvm.functions.Function4<java.lang.CharSequence, java.lang.int, java.lang.int, java.lang.int, kotlin.Unit> $beforeTextChanged;
    readonly kotlin.jvm.functions.Function4<java.lang.CharSequence, java.lang.int, java.lang.int, java.lang.int, kotlin.Unit> $onTextChanged;

    public TextobjectKt$addTextChangedListener$textWatcher$1(kotlin.jvm.functions.Function1<? super android.text.Editable, kotlin.Unit> function1, kotlin.jvm.functions.Function4<? super java.lang.CharSequence, ? super java.lang.int, ? super java.lang.int, ? super java.lang.int, kotlin.Unit> function4, kotlin.jvm.functions.Function4<? super java.lang.CharSequence, ? super java.lang.int, ? super java.lang.int, ? super java.lang.int, kotlin.Unit> function42) {
        this.$afterTextChanged = function1;
        this.$beforeTextChanged = function4;
        this.$onTextChanged = function42;
    }

    public override void AfterTextChanged(android.text.Editable s) {
        this.$afterTextChanged.invoke(s);
    }

    public override void BeforeTextChanged(java.lang.CharSequence text, int start, int count, int after) {
        this.$beforeTextChanged.invoke(text, java.lang.int.valueOf(start), java.lang.int.valueOf(count), java.lang.int.valueOf(after));
    }

    public override void OnTextChanged(java.lang.CharSequence text, int start, int before, int count) {
        this.$onTextChanged.invoke(text, java.lang.int.valueOf(start), java.lang.int.valueOf(before), java.lang.int.valueOf(count));
    }
}

