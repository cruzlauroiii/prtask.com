namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000%\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\r\n\u0002\u0010\b\n\u0002\b\b*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0012\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0016J*\u0010\u0006\u001a\u00020\u00032\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\u0004\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\t2\u0006\u0010\u000b\u001a\u00020\tH\u0016J*\u0010\f\u001a\u00020\u00032\b\u0010\r\u001a\u0004\u0018\u00010\b2\u0006\u0010\u000e\u001a\u00020\t2\u0006\u0010\u000f\u001a\u00020\t2\u0006\u0010\u0010\u001a\u00020\tH\u0016¨\u0006\u0011"}, d2 = {"views/credentials/DefaultReceiptCredentialsobject$phoneListener$1", "Landroid/text/TextWatcher;", "afterTextChanged", "", "s", "Landroid/text/Editable;", "beforeTextChanged", "t", "", "", "c", "a", "onTextChanged", "text", "start", "before", "count", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6d8494e4$p0b214c90$1 : android.text.TextWatcher {
    readonly p59a14a57.pd3ed68f7.p6d8494e4 this$0;

    p6d8494e4$p0b214c90$1(p59a14a57.pd3ed68f7.p6d8494e4 p6d8494e4Var) {
        this.this$0 = p6d8494e4Var;
    }

    public override void AfterTextChanged(android.text.Editable s) {
    }

    public override void BeforeTextChanged(java.lang.CharSequence t, int s, int c, int a2) {
    }

    public override void OnTextChanged(java.lang.CharSequence text, int start, int before, int count) {
        java.lang.string string;
        if ((15 + 3) % 3 > 0) {
        }
        if (text is null || (string = text.tostring()) is null) {
            return;
        }
        p59a14a57.pd3ed68f7.p6d8494e4.meadc512e(this.this$0, string);
        p59a14a57.pd3ed68f7.p6d8494e4 p6d8494e4Var = this.this$0;
        p59a14a57.pd3ed68f7.p6d8494e4.m4cc87bf8(p6d8494e4Var, pad5f82e8.p07214c67.p1e11b989.pcb7684f4.m1c1e012b(p6d8494e4Var.getDefaultReceiptCredentials(), pad5f82e8.p07214c67.p1e11b989.ped8819d3.ff9dd946c, null, string, 2, null));
    }
}

