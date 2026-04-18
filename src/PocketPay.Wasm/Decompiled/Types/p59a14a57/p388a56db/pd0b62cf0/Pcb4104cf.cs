namespace WillowMaze.Wasm.Decompiled;

public class Pcb4104cf : View$AccessibilityDelegate, View$OnClickListener
{
    private readonly EditText F06e3d36f;
    private readonly EditText F7266ad40;
    private readonly EditText F833c9854;

    private void Ma0334230(EditText P0, char P1)
    {
        // call: EditText.getSelectionStart
        // call: EditText.getText
        // call: string.valueOf
        // call: Editable.replace
        // call: EditText.getSelectionEnd
    }

    private void Mf3fc34f9(EditText P0)
    {
        // str: "getText(...)"
        // call: EditText.getSelectionStart
        // call: EditText.getText
        // call: Editable.delete
        // call: Intrinsics.checkNotNullExpressionValue
        // call: EditText.getSelectionEnd
        // call: CharSequence.length
    }

    public void OnClick(object P0)
    {
        // call: TextView.getText
        // call: pcb4104cf.ma0334230
        // call: pcb4104cf.mf3fc34f9
        // call: CharSequence.charAt
        // field: p59a14a57.p388a56db.pd0b62cf0.pcb4104cf.f06e3d36f
    }

}
