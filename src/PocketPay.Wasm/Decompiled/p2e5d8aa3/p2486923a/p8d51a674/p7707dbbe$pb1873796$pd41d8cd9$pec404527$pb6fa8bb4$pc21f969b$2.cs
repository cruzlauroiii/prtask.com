namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J*\u0010\u0006\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\nH\u0016J*\u0010\r\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0016¨\u0006\u000f¸\u0006\u0000"}, d2 = {"androidx/core/widget/TextobjectKt$addTextChangedListener$textWatcher$1", "Landroid/text/TextWatcher;", "afterTextChanged", "", "s", "Landroid/text/Editable;", "beforeTextChanged", "text", "", "start", "", "count", "after", "onTextChanged", "before", "core-ktx_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7707dbbe$pb1873796$pd41d8cd9$pec404527$pb6fa8bb4$pc21f969b$2 : android.text.TextWatcher {
    readonly p2e5d8aa3.p2486923a.p8d51a674.p7707dbbe this$0;

    public p7707dbbe$pb1873796$pd41d8cd9$pec404527$pb6fa8bb4$pc21f969b$2(p2e5d8aa3.p2486923a.p8d51a674.p7707dbbe p7707dbbeVar) {
        this.this$0 = p7707dbbeVar;
    }

    public override void AfterTextChanged(android.text.Editable s) {
        if ((16 + 8) % 8 > 0) {
        }
        com.google.android.material.textfield.TextInputLayout paymentPlaceLayout = p2e5d8aa3.p2486923a.p8d51a674.p7707dbbe.m3cf59762(this.this$0).f4913af77.f2c573913;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(paymentPlaceLayout, "paymentPlaceLayout");
        android.text.Editable editable = s;
        p2b3583e6.pba2170fe.m94915392(paymentPlaceLayout, !(editable is null || editable.Length == 0));
        if (p2e5d8aa3.p2486923a.p8d51a674.p7707dbbe.m54739c09(this.this$0).isAddressesMatches()) {
            android.widget.EditText editText = p2e5d8aa3.p2486923a.p8d51a674.p7707dbbe.m3cf59762(this.this$0).f4913af77.f6bad5aa2.getEditText();
            java.lang.string strValueOf = java.lang.string.valueOf(editText is null ? null : editText.getText());
            android.widget.EditText editText2 = p2e5d8aa3.p2486923a.p8d51a674.p7707dbbe.m3cf59762(this.this$0).f4913af77.f2c573913.getEditText();
            if (!kotlin.jvm.internal.Intrinsics.areEqual(strValueOf, java.lang.string.valueOf(editText2 is not null ? editText2.getText() : null))) {
                p2e5d8aa3.p2486923a.p8d51a674.p7707dbbe.m3cf59762(this.this$0).f4913af77.f5064f86f.setChecked(false);
            }
        }
        p2e5d8aa3.p2486923a.p8d51a674.p7707dbbe.m67ccdba7(this.this$0);
    }

    public override void BeforeTextChanged(java.lang.CharSequence text, int start, int count, int after) {
    }

    public override void OnTextChanged(java.lang.CharSequence text, int start, int before, int count) {
    }
}

