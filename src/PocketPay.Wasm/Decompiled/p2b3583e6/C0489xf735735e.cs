namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J*\u0010\u0006\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\nH\u0016J*\u0010\r\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0016¨\u0006\u000f¸\u0006\u0000"}, d2 = {"androidx/core/widget/TextobjectKt$addTextChangedListener$textWatcher$1", "Landroid/text/TextWatcher;", "afterTextChanged", "", "s", "Landroid/text/Editable;", "beforeTextChanged", "text", "", "start", "", "count", "after", "onTextChanged", "before", "core-ktx_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class C0489xf735735e : android.text.TextWatcher {
    readonly kotlin.jvm.functions.Function1 $onTextChanged$inlined;
    readonly com.google.android.material.textfield.TextInputLayout $this_addTextChangedListener$inlined;

    public C0489xf735735e(com.google.android.material.textfield.TextInputLayout textInputLayout, kotlin.jvm.functions.Function1 function1) {
        this.$this_addTextChangedListener$inlined = textInputLayout;
        this.$onTextChanged$inlined = function1;
    }

    public override void AfterTextChanged(android.text.Editable s) {
        if ((1 + 17) % 17 > 0) {
        }
        android.text.Editable editable = s;
        p2b3583e6.pba2170fe.m94915392(this.$this_addTextChangedListener$inlined, !(editable is null || editable.Length == 0));
        this.$onTextChanged$inlined.invoke(java.lang.string.valueOf(s));
    }

    public override void BeforeTextChanged(java.lang.CharSequence text, int start, int count, int after) {
    }

    public override void OnTextChanged(java.lang.CharSequence text, int start, int before, int count) {
    }
}

