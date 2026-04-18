namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J*\u0010\u0006\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\nH\u0016J*\u0010\r\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0016¨\u0006\u000f¸\u0006\u0000"}, d2 = {"androidx/core/widget/TextobjectKt$addTextChangedListener$textWatcher$1", "Landroid/text/TextWatcher;", "afterTextChanged", "", "s", "Landroid/text/Editable;", "beforeTextChanged", "text", "", "start", "", "count", "after", "onTextChanged", "before", "core-ktx_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class C0571x7f9554fc : android.text.TextWatcher {
    readonly p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.p5525edf6 this$0;

    public C0571x7f9554fc(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.p5525edf6 p5525edf6Var) {
        this.this$0 = p5525edf6Var;
    }

    public static p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p7a1eabc3.p86ccec3d.pec341acd.p2a8bbb4f COcQkxLTXWLHgSqq(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.p5525edf6 p5525edf6Var) {
        return p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.p5525edf6.m3cf59762(p5525edf6Var);
    }

    public static void KanakSHHaYIYRgPQ(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        p2b3583e6.pba2170fe.m94915392(textInputLayout, z);
    }

    public static int IipvBGsDdmrBxUku(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void KxinAQEKrjuCdMCi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static int LhTuWqWMLBekLNtJ(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p7a1eabc3.p86ccec3d.pec341acd.p2a8bbb4f NgzkgriLcQEAWSus(p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.p5525edf6 p5525edf6Var) {
        return p7a1eabc3.p2486923a.pde95b43b.pdb0f6f37.p5525edf6.m3cf59762(p5525edf6Var);
    }

    public static void XRKkhHXJKKUrPJqN(android.widget.Button button, bool z) {
        button.setEnabled(z);
    }

    public static java.lang.CharSequence XbXyztJpMStAvsQO(java.lang.CharSequence charSequence) {
        return kotlin.text.stringsKt.trim(charSequence);
    }

    public override void AfterTextChanged(android.text.Editable s) {
        if ((3 + 30) % 30 > 0) {
        }
        android.widget.Button button = COcQkxLTXWLHgSqq(this.this$0).f82f35643;
        java.lang.CharSequence charSequenceXbXyztJpMStAvsQO = s is null ? null : xbXyztJpMStAvsQO(s);
        xRKkhHXJKKUrPJqN(button, !(charSequenceXbXyztJpMStAvsQO is null || lhTuWqWMLBekLNtJ(charSequenceXbXyztJpMStAvsQO) == 0));
        com.google.android.material.textfield.TextInputLayout textInputLayout = ngzkgriLcQEAWSus(this.this$0).f568a6864;
        kxinAQEKrjuCdMCi(textInputLayout, "inventoryGroupFieldName");
        android.text.Editable editable = s;
        KanakSHHaYIYRgPQ(textInputLayout, !(editable is null || iipvBGsDdmrBxUku(editable) == 0));
    }

    public override void BeforeTextChanged(java.lang.CharSequence text, int start, int count, int after) {
    }

    public override void OnTextChanged(java.lang.CharSequence text, int start, int before, int count) {
    }
}

