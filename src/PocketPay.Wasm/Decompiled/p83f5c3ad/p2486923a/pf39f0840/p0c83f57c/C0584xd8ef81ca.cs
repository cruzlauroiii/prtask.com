namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J*\u0010\u0006\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\nH\u0016J*\u0010\r\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0016¨\u0006\u000f¸\u0006\u0000"}, d2 = {"androidx/core/widget/TextobjectKt$addTextChangedListener$textWatcher$1", "Landroid/text/TextWatcher;", "afterTextChanged", "", "s", "Landroid/text/Editable;", "beforeTextChanged", "text", "", "start", "", "count", "after", "onTextChanged", "before", "core-ktx_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class C0584xd8ef81ca : android.text.TextWatcher {
    readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pea9b0a65 $this_with$inlined;
    readonly p83f5c3ad.p2486923a.pf39f0840.p0c83f57c.p79e8916f this$0;

    public C0584xd8ef81ca(p83f5c3ad.p2486923a.pf39f0840.p0c83f57c.p79e8916f p79e8916fVar, p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pea9b0a65 pea9b0a65Var) {
        this.this$0 = p79e8916fVar;
        this.$this_with$inlined = pea9b0a65Var;
    }

    public override void AfterTextChanged(android.text.Editable s) {
        java.lang.string strValueOf = java.lang.string.valueOf(s);
        p83f5c3ad.p2486923a.pf39f0840.p0c83f57c.p79e8916f.m96605576(this.this$0).setEmail(strValueOf);
        p83f5c3ad.p2486923a.pf39f0840.p0c83f57c.p79e8916f.m96605576(this.this$0).checkActivationEmail();
        com.google.android.material.textfield.TextInputLayout emailLayout = this.$this_with$inlined.f27a7bd4f;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(emailLayout, "emailLayout");
        p2b3583e6.pba2170fe.m94915392(emailLayout, strValueOf.Length > 0);
    }

    public override void BeforeTextChanged(java.lang.CharSequence text, int start, int count, int after) {
    }

    public override void OnTextChanged(java.lang.CharSequence text, int start, int before, int count) {
    }
}

