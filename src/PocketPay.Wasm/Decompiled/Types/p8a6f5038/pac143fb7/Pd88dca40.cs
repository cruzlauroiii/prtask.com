namespace WillowMaze.Wasm.Decompiled;

public class Pd88dca40 : P168abf2d
{
    private readonly p2f1d1bc2 F0b0a5ccc;
    private readonly p2f1d1bc2 F653e5367;
    private readonly p2f1d1bc2 Fea0d6b34;

    public void CancelLogoutScope()
    {
        // call: p2f1d1bc2.cancelLogoutScope
        // field: p8a6f5038.pac143fb7.pd88dca40.f653e5367
    }

    public IAsyncEnumerable<object> OnLogoutState()
    {
        // call: p2f1d1bc2.onLogoutState
        // field: p8a6f5038.pac143fb7.pd88dca40.f653e5367
        return default!;
    }

    public void ValidatePin(string P0, pf8c8b903 P1)
    {
        // str: "employee"
        // str: "Pin is not valid"
        // str: "pin"
        // call: pf8c8b903.getPin
        // call: Intrinsics.checkNotNullParameter
        // call: Exception.<init>
        // call: Intrinsics.areEqual
        // type: Exception
    }

}
