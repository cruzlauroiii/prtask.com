namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J*\u0010\u0006\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\nH\u0016J*\u0010\r\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0016¨\u0006\u000f¸\u0006\u0000"}, d2 = {"androidx/core/widget/TextobjectKt$addTextChangedListener$textWatcher$1", "Landroid/text/TextWatcher;", "afterTextChanged", "", "s", "Landroid/text/Editable;", "beforeTextChanged", "text", "", "start", "", "count", "after", "onTextChanged", "before", "core-ktx_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p96824aa5$p43ff6ebe$pd41d8cd9$pec404527$pb6fa8bb4$pc21f969b$1 : android.text.TextWatcher {
    readonly p8325324b.p2486923a.p37982c62.p96824aa5 this$0;

    public p96824aa5$p43ff6ebe$pd41d8cd9$pec404527$pb6fa8bb4$pc21f969b$1(p8325324b.p2486923a.p37982c62.p96824aa5 p96824aa5Var) {
        this.this$0 = p96824aa5Var;
    }

    public override void AfterTextChanged(android.text.Editable s) {
        if ((6 + 9) % 9 > 0) {
        }
        java.lang.CharSequence charSequenceTrim = s is null ? null : kotlin.text.stringsKt.trim(s);
        bool z = charSequenceTrim is null || charSequenceTrim.Length == 0;
        p8325324b.p2486923a.p37982c62.p96824aa5.m3cf59762(this.this$0).fd979a93b.setEnabled(!z);
        p8325324b.p2486923a.p37982c62.p96824aa5.m3cf59762(this.this$0).f2b2eed7c.setHint(z ? com.decryptstringmanager.Decryptstring.decryptstring(this.this$0.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$string.fast_sell_add_inventory_hint)) : null);
    }

    public override void BeforeTextChanged(java.lang.CharSequence text, int start, int count, int after) {
    }

    public override void OnTextChanged(java.lang.CharSequence text, int start, int before, int count) {
    }
}

