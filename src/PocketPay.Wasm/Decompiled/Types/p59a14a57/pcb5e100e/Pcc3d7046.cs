namespace WillowMaze.Wasm.Decompiled;

public class Pcc3d7046 : RelativeLayout
{
    private readonly p0c4ef39c F001a249d;
    private readonly p0c4ef39c F1160ebe6;
    private readonly p0c4ef39c F266a63bd;
    private readonly p0c4ef39c F6b0bec93;
    private readonly p0c4ef39c Fd7f623f6;

    public static void M16f75ac6(Func<object> P0, object P1)
    {
        // call: pcc3d7046.mda4ffc4e
    }

    private void Mb879b2d7(TypedArray P0)
    {
        // call: TypedArray.getString
        // call: pcc3d7046.setMessage
        // call: DecryptString.decryptString
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$styleable.ErrorRepeatView_errorMessage
    }

    private static void Mda4ffc4e(Func<object> P0, object P1)
    {
        // str: "it"
        // call: Intrinsics.checkNotNullParameter
        // call: Func<object>.invoke
        // field: kotlin.Unit.INSTANCE
    }

    public Button GetErrorRepeatButton()
    {
        // str: "errorRepeat"
        // call: Intrinsics.checkNotNullExpressionValue
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p0c4ef39c.fd650ac9e
        // field: p59a14a57.pcb5e100e.pcc3d7046.f001a249d
        return default!;
    }

    public void SetMessage(string P0)
    {
        // str: "message"
        // call: Resources.getString
        // call: DecryptString.decryptString
        // call: pcc3d7046.getContext
        // call: string.format
        // call: object.getResources
        // call: Button.setText
        // call: Intrinsics.checkNotNullParameter
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p0c4ef39c.fd650ac9e
        // field: p59a14a57.pcb5e100e.pcc3d7046.f001a249d
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.R$string.error_repeat_message_template
    }

    public void SetRepeatClickListener(Func<object> P0)
    {
        // str: "errorRepeat"
        // str: "onRepeatClick"
        // call: pf5e18aff.m2fa6d087
        // call: Intrinsics.checkNotNullParameter
        // call: pcc3d7046$pd41d8cd9$p95263d50.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // field: p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p9efab239.p59a14a57.pec341acd.p0c4ef39c.fd650ac9e
        // field: p59a14a57.pcb5e100e.pcc3d7046.f001a249d
        // type: pcc3d7046$pd41d8cd9$p95263d50
    }

}
