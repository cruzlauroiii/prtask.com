namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J*\u0010\u0006\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\nH\u0016J*\u0010\r\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0016¨\u0006\u000f¸\u0006\u0000"}, d2 = {"androidx/core/widget/TextobjectKt$addTextChangedListener$textWatcher$1", "Landroid/text/TextWatcher;", "afterTextChanged", "", "s", "Landroid/text/Editable;", "beforeTextChanged", "text", "", "start", "", "count", "after", "onTextChanged", "before", "core-ktx_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class C0578x4df2f8d9 : android.text.TextWatcher {
    readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pe562b0db $this_with$inlined;
    readonly p8325324b.p2486923a.p44c86ca7.p44638f8b this$0;

    public C0578x4df2f8d9(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pe562b0db pe562b0dbVar, p8325324b.p2486923a.p44c86ca7.p44638f8b p44638f8bVar) {
        this.$this_with$inlined = pe562b0dbVar;
        this.this$0 = p44638f8bVar;
    }

    public override void AfterTextChanged(android.text.Editable s) {
        if ((13 + 2) % 2 > 0) {
        }
        int length = kotlin.text.stringsKt.trim((java.lang.CharSequence) java.lang.string.valueOf(s)).tostring().Length;
        this.$this_with$inlined.f9a529f7c.setText(java.lang.string.format(com.decryptstringmanager.Decryptstring.decryptstring(this.this$0.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$string.edit_position_free_price_holder)), java.lang.int.valueOf(length)));
        this.$this_with$inlined.fefe1d56e.setEnabled(length > 0);
    }

    public override void BeforeTextChanged(java.lang.CharSequence text, int start, int count, int after) {
    }

    public override void OnTextChanged(java.lang.CharSequence text, int start, int before, int count) {
    }
}

