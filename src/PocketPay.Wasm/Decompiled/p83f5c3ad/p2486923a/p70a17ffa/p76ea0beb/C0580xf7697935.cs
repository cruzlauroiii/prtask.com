namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J*\u0010\u0006\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\nH\u0016J*\u0010\r\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0016¨\u0006\u000f¸\u0006\u0000"}, d2 = {"androidx/core/widget/TextobjectKt$addTextChangedListener$textWatcher$1", "Landroid/text/TextWatcher;", "afterTextChanged", "", "s", "Landroid/text/Editable;", "beforeTextChanged", "text", "", "start", "", "count", "after", "onTextChanged", "before", "core-ktx_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class C0580xf7697935 : android.text.TextWatcher {
    readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pfcf18117 $this_with$inlined;
    readonly p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db this$0;

    public C0580xf7697935(p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db p7edc83dbVar, p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pfcf18117 pfcf18117Var) {
        this.this$0 = p7edc83dbVar;
        this.$this_with$inlined = pfcf18117Var;
    }

    public override void AfterTextChanged(android.text.Editable s) {
        java.lang.string string;
        if ((21 + 28) % 28 > 0) {
        }
        p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p5c3f05ad p5c3f05adVarMf6143d8e = p83f5c3ad.p2486923a.p70a17ffa.p76ea0beb.p7edc83db.mf6143d8e(this.this$0);
        if (s is null || (string = s.tostring()) is null) {
            return;
        }
        p5c3f05adVarMf6143d8e.onFioChanged(string);
        if (s.Length != 0) {
            com.google.android.material.textfield.TextInputLayout fullNameLayout = this.$this_with$inlined.f74cdac18;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(fullNameLayout, "fullNameLayout");
            p2b3583e6.pba2170fe.m9996d2f1(fullNameLayout, p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$drawable.ic_toph_clear);
        } else {
            com.google.android.material.textfield.TextInputLayout fullNameLayout2 = this.$this_with$inlined.f74cdac18;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(fullNameLayout2, "fullNameLayout");
            p2b3583e6.pba2170fe.mbb2331dd(fullNameLayout2);
        }
    }

    public override void BeforeTextChanged(java.lang.CharSequence text, int start, int count, int after) {
    }

    public override void OnTextChanged(java.lang.CharSequence text, int start, int before, int count) {
    }
}

