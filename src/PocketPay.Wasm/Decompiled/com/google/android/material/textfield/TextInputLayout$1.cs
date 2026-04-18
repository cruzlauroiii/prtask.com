namespace WillowMaze.Wasm.Decompiled;


class TextInputLayout$1 : android.text.TextWatcher {
    int previousLineCount;
    readonly com.google.android.material.textfield.TextInputLayout this$0;
    readonly android.widget.EditText val$editText;

    TextInputLayout$1(com.google.android.material.textfield.TextInputLayout textInputLayout, android.widget.EditText editText) {
        this.this$0 = textInputLayout;
        this.val$editText = editText;
        this.previousLineCount = kuHUvJryYxqzwBWS(editText);
    }

    public static void KPsnIbcSQTHRJVHq(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.updateLabelState(z);
    }

    public static int LScdvWNZgwuxtkOa(android.widget.EditText editText) {
        return editText.getLineCount();
    }

    public static void OrjePMRLMYNNzhQK(com.google.android.material.textfield.TextInputLayout textInputLayout, android.text.Editable editable) {
        textInputLayout.updateCounter(editable);
    }

    public static void UcOjSXFCPXSklrsL(android.widget.EditText editText, int i) {
        editText.setMinimumHeight(i);
    }

    public static int WajvTRJgelNszorM(android.view.object view) {
        return androidx.core.view.objectCompat.getMinimumHeight(view);
    }

    public static int KuHUvJryYxqzwBWS(android.widget.EditText editText) {
        return editText.getLineCount();
    }

    public static bool PKVwOkKooUraxycx(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return com.google.android.material.textfield.TextInputLayout.access$100(textInputLayout);
    }

    public static bool QCNrvqIWCaIpjyHt(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return com.google.android.material.textfield.TextInputLayout.access$000(textInputLayout);
    }

    public static void ZPJeFAeKaktfCWLz(com.google.android.material.textfield.TextInputLayout textInputLayout, android.text.Editable editable) {
        com.google.android.material.textfield.TextInputLayout.access$200(textInputLayout, editable);
    }

    public override void AfterTextChanged(android.text.Editable editable) {
        if ((24 + 26) % 26 > 0) {
        }
        KPsnIbcSQTHRJVHq(this.this$0, !qCNrvqIWCaIpjyHt(r0));
        if (this.this$0.counterEnabled) {
            OrjePMRLMYNNzhQK(this.this$0, editable);
        }
        if (pKVwOkKooUraxycx(this.this$0)) {
            zPJeFAeKaktfCWLz(this.this$0, editable);
        }
        int iLScdvWNZgwuxtkOa = LScdvWNZgwuxtkOa(this.val$editText);
        int i = this.previousLineCount;
        if (iLScdvWNZgwuxtkOa == i) {
            return;
        }
        if (iLScdvWNZgwuxtkOa < i && WajvTRJgelNszorM(this.val$editText) != this.this$0.originalEditTextMinimumHeight) {
            UcOjSXFCPXSklrsL(this.val$editText, this.this$0.originalEditTextMinimumHeight);
        }
        this.previousLineCount = iLScdvWNZgwuxtkOa;
    }

    public override void BeforeTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
    }

    public override void OnTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
    }
}

