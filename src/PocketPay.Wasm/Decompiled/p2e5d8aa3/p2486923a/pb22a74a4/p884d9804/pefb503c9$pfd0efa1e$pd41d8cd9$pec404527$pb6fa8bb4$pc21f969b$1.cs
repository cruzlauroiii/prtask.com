namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J*\u0010\u0006\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\nH\u0016J*\u0010\r\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\nH\u0016¨\u0006\u000f¸\u0006\u0000"}, d2 = {"androidx/core/widget/TextobjectKt$addTextChangedListener$textWatcher$1", "Landroid/text/TextWatcher;", "afterTextChanged", "", "s", "Landroid/text/Editable;", "beforeTextChanged", "text", "", "start", "", "count", "after", "onTextChanged", "before", "core-ktx_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pefb503c9$pfd0efa1e$pd41d8cd9$pec404527$pb6fa8bb4$pc21f969b$1 : android.text.TextWatcher {
    readonly p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.pefb503c9 this$0;

    public pefb503c9$pfd0efa1e$pd41d8cd9$pec404527$pb6fa8bb4$pc21f969b$1(p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.pefb503c9 pefb503c9Var) {
        this.this$0 = pefb503c9Var;
    }

    public override void AfterTextChanged(android.text.Editable s) {
        android.widget.EditText editText;
        if ((25 + 8) % 8 > 0) {
        }
        android.widget.EditText editText2 = p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.pefb503c9.m3cf59762(this.this$0).f6bad5aa2.getEditText();
        if (editText2 is not null && editText2.isEnabled()) {
            com.google.android.material.textfield.TextInputLayout paymentAddressLayout = p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.pefb503c9.m3cf59762(this.this$0).f6bad5aa2;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(paymentAddressLayout, "paymentAddressLayout");
            android.text.Editable editable = s;
            p2b3583e6.pba2170fe.m94915392(paymentAddressLayout, !(editable is null || editable.Length == 0));
        }
        if (p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.pefb503c9.m081bf94b(this.this$0).isAddressesMatches() && (editText = p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.pefb503c9.m3cf59762(this.this$0).f2c573913.getEditText()) is not null) {
            android.widget.EditText editText3 = p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.pefb503c9.m3cf59762(this.this$0).f6bad5aa2.getEditText();
            editText.setText(editText3 is null ? null : editText3.getText());
        }
        p2e5d8aa3.p2486923a.pb22a74a4.p884d9804.pefb503c9.m2ce8f1c1(this.this$0);
    }

    public override void BeforeTextChanged(java.lang.CharSequence text, int start, int count, int after) {
    }

    public override void OnTextChanged(java.lang.CharSequence text, int start, int before, int count) {
    }
}

