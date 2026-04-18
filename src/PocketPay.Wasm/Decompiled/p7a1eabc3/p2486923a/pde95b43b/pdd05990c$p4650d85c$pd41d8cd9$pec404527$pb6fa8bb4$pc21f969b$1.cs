namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J*\u0010\u0006\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\nH\u0016J*\u0010\r\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0016¨\u0006\u000f¸\u0006\u0000"}, d2 = {"androidx/core/widget/TextobjectKt$addTextChangedListener$textWatcher$1", "Landroid/text/TextWatcher;", "afterTextChanged", "", "s", "Landroid/text/Editable;", "beforeTextChanged", "text", "", "start", "", "count", "after", "onTextChanged", "before", "core-ktx_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pdd05990c$p4650d85c$pd41d8cd9$pec404527$pb6fa8bb4$pc21f969b$1 : android.text.TextWatcher {
    readonly p7a1eabc3.p2486923a.pde95b43b.pdd05990c this$0;

    public pdd05990c$p4650d85c$pd41d8cd9$pec404527$pb6fa8bb4$pc21f969b$1(p7a1eabc3.p2486923a.pde95b43b.pdd05990c pdd05990cVar) {
        this.this$0 = pdd05990cVar;
    }

    public static void GnIsSgcIMqLMupWm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p7a1eabc3.p86ccec3d.pec341acd.p5abdc549 XJJGBiTPoLWaTznA(p7a1eabc3.p2486923a.pde95b43b.pdd05990c pdd05990cVar) {
        return p7a1eabc3.p2486923a.pde95b43b.pdd05990c.m3cf59762(pdd05990cVar);
    }

    public static void LVfeDmPXxuXTGSVb(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        p2b3583e6.pba2170fe.m94915392(textInputLayout, z);
    }

    public static int QkxugDHABuIwBxRV(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public override void AfterTextChanged(android.text.Editable s) {
        com.google.android.material.textfield.TextInputLayout textInputLayout = XJJGBiTPoLWaTznA(this.this$0).fafad020d;
        GnIsSgcIMqLMupWm(textInputLayout, "fieldArticle");
        android.text.Editable editable = s;
        lVfeDmPXxuXTGSVb(textInputLayout, !(editable is null || qkxugDHABuIwBxRV(editable) == 0));
    }

    public override void BeforeTextChanged(java.lang.CharSequence text, int start, int count, int after) {
    }

    public override void OnTextChanged(java.lang.CharSequence text, int start, int before, int count) {
    }
}

