namespace WillowMaze.Wasm.Decompiled;

public class P1e2c2976 : ViewModel
{
    private readonly pbd754d99 F037fca03;
    private readonly p2f3c4196 F03a2f1ad;
    private readonly p1d0d18f1 F0881a657;
    private readonly p1ceed351 F0928dfee;
    private readonly SharedFlow F0a49b529;
    private readonly MutableSharedFlow F0cdc651c;
    private readonly MutableSharedFlow F1036547e;
    private readonly MutableSharedFlow F11750328;
    private readonly SharedFlow F175cf33b;
    private readonly pe9ddd6b8 F18eeba9c;
    private readonly p2e423cc6 F1a3e756d;
    private readonly p2e423cc6 F1a68b152;
    private readonly MutableSharedFlow F23a26210;
    private readonly SharedFlow F24af0045;
    private readonly SharedFlow F25fdc4e6;
    private readonly MutableSharedFlow F271c21b0;
    private readonly pee785de8 F37c9e91b;
    private readonly SharedFlow F3e18536e;
    private readonly MutableSharedFlow F418d61b9;
    private readonly p2e423cc6 F4734ade7;
    private readonly MutableSharedFlow F49f3192a;
    private readonly p2f3c4196 F4eed651a;
    private readonly MutableSharedFlow F5596f9ac;
    private readonly p1d2e04a5 F559cf0b9;
    private readonly MutableSharedFlow F59431124;
    private readonly p1ceed351 F5be42a8a;
    private readonly pee785de8 F662f2b03;
    private readonly pe8cda3fc F68c4283d;
    private readonly pbd754d99 F6c4ee886;
    private readonly p2f3c4196 F6f4ce003;
    private readonly pe9ddd6b8 F77de4a36;
    private readonly pe9ddd6b8 F7b6fb493;
    private readonly pe9ddd6b8 F7caafe1d;
    private readonly SharedFlow F8176e291;
    private readonly p2f3c4196 Fa53c50cb;
    private readonly p1d0d18f1 Fab97ea65;
    private readonly MutableSharedFlow Fad6b610e;
    private readonly pe8cda3fc Fade981ef;
    private readonly pee785de8 Fae8e1e61;
    private readonly SharedFlow Fb0613fdb;
    private readonly p1ceed351 Fb598c16c;
    private readonly pbd754d99 Fc837d957;
    private readonly MutableSharedFlow Fd1770637;
    private readonly p1ceed351 Fd53bdfcd;
    private readonly pbd754d99 Fe56039ac;
    private readonly p2f3c4196 Fe639d08f;
    private readonly pee785de8 Fe854b2c0;
    private readonly pbd754d99 Feced03cd;
    private readonly pe8cda3fc Ff0040eb1;
    private readonly p1ceed351 Ff3395cd5;
    private readonly p1d2e04a5 Ff525f739;
    private readonly SharedFlow Ffa0926cb;

    public static MutableSharedFlow M72d10f54(p1e2c2976 P0)
    {
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.f49f3192a
        return default!;
    }

    public static pe9ddd6b8 Mfab5c515(p1e2c2976 P0)
    {
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.f18eeba9c
        return default!;
    }

    public void CheckActivationEmail(string P0)
    {
        // str: "email"
        // call: CharSequence.length
        // call: object.toString
        // call: StringsKt.trim
        // call: p1d0d18f1.validate
        // call: MutableSharedFlow.tryEmit
        // call: Intrinsics.checkNotNullParameter
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.f11750328
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.fab97ea65
        // field: p83f5c3ad.p2486923a.p24eed33e.pfdef8b4b.fc9f1a638
        // field: p83f5c3ad.p2486923a.p24eed33e.pfdef8b4b.f202a1762
    }

    public Uri CreateEmailUri()
    {
        // call: pbd754d99.getOSVersion
        // call: pbd754d99.getVersionName
        // call: p2e423cc6.getString
        // call: p1d2e04a5.createEmailUri
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.settings_email_title
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.f4734ade7
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.ff525f739
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.feced03cd
        // field: p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.settings_support_email
        return default!;
    }

    public SharedFlow GetEmailValidationState()
    {
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.fb0613fdb
        return default!;
    }

    public SharedFlow GetInitActivationState()
    {
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.f3e18536e
        return default!;
    }

    public SharedFlow GetOnFeedbackEmailState()
    {
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.f0a49b529
        return default!;
    }

    public void InitActivation(string P0)
    {
        // str: "activationCredentials"
        // call: BuildersKt.launch$default
        // call: p1e2c2976$p27a1f813$1.<init>
        // call: ViewModelKt.getViewModelScope
        // call: Intrinsics.checkNotNullParameter
        // type: p1e2c2976$p27a1f813$1
    }

    public void OpenActivationConfirmScreen(string P0)
    {
        // str: "activationCredentials"
        // call: Intrinsics.checkNotNullParameter
        // call: p1ceed351.openActivationConfirm
        // field: p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.pcff54971.p24eed33e.pdc33845b.f61a649a3
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.ff3395cd5
    }

    public void OpenFeedback()
    {
        // call: pee785de8.openFeedback
        // call: MutableSharedFlow.tryEmit
        // call: p2f3c4196.getUserRoleType
        // field: kotlin.Unit.INSTANCE
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.fe639d08f
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.f37c9e91b
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.f418d61b9
        // field: pad5f82e8.p07214c67.p49f290d6.p3dfe3c80.f8304dc30
    }

    public void OpenPreviousScreen()
    {
        // call: p1ceed351.back
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.ff3395cd5
    }

    public void ReportAuthorizationErrorCancelEvent()
    {
        // call: pe8cda3fc.reportAuthorizationErrorCancelEvent
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.f68c4283d
    }

    public void ReportAuthorizationErrorSupportEvent()
    {
        // call: pe8cda3fc.reportAuthorizationErrorSupportEvent
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.f68c4283d
    }

    public void ReportDeviceIsBlockedCancelEvent()
    {
        // call: pe8cda3fc.reportDeviceIsBlockedCancelEvent
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.f68c4283d
    }

    public void ReportDeviceIsBlockedSupportEvent()
    {
        // call: pe8cda3fc.reportDeviceIsBlockedSupportEvent
        // field: p83f5c3ad.p2486923a.p24eed33e.p0c83f57c.p1e2c2976.f68c4283d
    }

}
