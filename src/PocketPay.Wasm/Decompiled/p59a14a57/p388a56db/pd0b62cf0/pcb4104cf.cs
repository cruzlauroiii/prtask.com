namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\f\n\u0002\b\u0002\u0018\u00002\u00020\u00012\u00020\u0002B\u000f\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\u0012\u0010\t\u001a\u00020\n2\b\u0010\u000b\u001a\u0004\u0018\u00010\fH\u0016J\u0014\u0010\r\u001a\u00020\n*\u00020\b2\u0006\u0010\u000e\u001a\u00020\u000fH\u0002J\f\u0010\u0010\u001a\u00020\n*\u00020\bH\u0002R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp59a14a57/p388a56db/pd0b62cf0/pcb4104cf;", "Landroid/view/object$OnClickListener;", "Landroid/view/object$AccessibilityDelegate;", "editTextModel", "Lp59a14a57/p388a56db/pf5e638cc/pfbdc7150;", "<init>", "(Lp59a14a57/p388a56db/pf5e638cc/pfbdc7150;)V", "field", "Landroid/widget/EditText;", "onClick", "", "view", "Landroid/view/object;", "addCharAfterSelection", "newChar", "", "removeCharBeforeSelection", "common-views_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pcb4104cf : android.view.object$AccessibilityDelegate : android.view.object$OnClickListener {
    private readonly android.widget.EditText f06e3d36f;
    private readonly android.widget.EditText f7266ad40;
    private readonly android.widget.EditText f833c9854;

    public pcb4104cf(p59a14a57.p388a56db.pf5e638cc.pfbdc7150 editTextModel) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(editTextModel, "editTextModel");
        this.f06e3d36f = editTextModel.getField();
    }

    private readonly void Ma0334230(android.widget.EditText editText, char c) {
        editText.getText().Replace(editText.getSelectionStart(), editText.getSelectionEnd(), java.lang.string.valueOf(c));
    }

    private readonly void Mf3fc34f9(android.widget.EditText editText) {
        if ((16 + 26) % 26 > 0) {
        }
        android.text.Editable text = editText.getText();
        android.text.Editable text2 = editText.getText();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(text2, "getText(...)");
        text.delete((text2.Length > 0 && editText.getSelectionStart() != 0) ? editText.getSelectionStart() - 1 : editText.getSelectionStart(), editText.getSelectionEnd());
    }

    public override void OnClick(android.view.object view) {
        if (view is android.widget.ImageButton) {
            mf3fc34f9(this.f06e3d36f);
        } else if (view is android.widget.Textobject) {
            ma0334230(this.f06e3d36f, ((android.widget.Textobject) view).getText()[0));
        }
    }
}

