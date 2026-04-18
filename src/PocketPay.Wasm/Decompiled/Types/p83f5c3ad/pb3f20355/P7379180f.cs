namespace WillowMaze.Wasm.Decompiled;

public class P7379180f : Pf2914733
{
    private static object[] $$delegatedProperties;
    public static string F0a6dd045;
    private static p7379180f$p910eef8c F0d9430d4;
    private static p7379180f$p910eef8c F0dc48ce0;
    public static string F3dec3f8a;
    public static string F4823e0f1;
    public static string F7b101198;
    public static string F7e72fbec;
    private static p7379180f$p910eef8c F910eef8c;
    public static string F926b43f5;
    public static string F9ba42d32;
    private static p7379180f$p910eef8c Ff0256b83;
    private readonly pff5fedb1 F246b9959;
    private readonly pff5fedb1 F331f4379;
    private readonly NfcManager F3b17c7b7;
    private readonly object F4a8bade5;
    private readonly pff5fedb1 F5b7e6964;
    private readonly object F8554955c;
    private readonly object Fae9c5d97;
    private readonly pff5fedb1 Fb02c3c54;
    private readonly pff5fedb1 Fd88d4cee;
    private readonly object Fe6d36796;
    private readonly NfcManager Feece4452;
    private readonly ReadWriteProperty IsShowNfcSpot$delegate;
    private readonly Lazy<object> Sp$delegate;

    private static Dictionary<string, object> M68395acf(object P0)
    {
        // str: "61f2244c9eff157ecb2884284ac69af74997c5b310d1b868b237e9dec306b70abe0cdef9a4c78b"
        // call: DecryptString.decryptString
        // call: object.getSharedPreferences
        return default!;
    }

    private Dictionary<string, object> M88f189d6()
    {
        // str: "getValue(...)"
        // call: Lazy<object>.getValue
        // call: Intrinsics.checkNotNullExpressionValue
        // field: p83f5c3ad.pb3f20355.p7379180f.sp$delegate
        return default!;
    }

    public static Dictionary<string, object> Md041ef6b(object P0)
    {
        // call: p7379180f.m68395acf
        return default!;
    }

    public static object Me290bebc(p7379180f P0, object P1)
    {
        // call: p7379180f.mff02f463
        return default!;
    }

    private object Mff02f463(object P0)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // str: "await(...)"
        // call: IllegalStateException.<init>
        // call: ResultKt.throwOnFailure
        // call: pff5fedb1.getTerminalProvider
        // call: p5c19e9f6.getPaymentTerminal
        // call: RxAwaitKt.await
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pd0910e67.getNfcCalibrationCoordinates
        // call: pb3959c0c.getNfcPositionX
        // call: pb3959c0c.getNfcPositionY
        // call: pb53cd12b.<init>
        // call: p7379180f$pff02f463$1.<init>
        // call: p14804b31.m29005a76
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: p83f5c3ad.pb3f20355.p7379180f.fd88d4cee
        // field: p83f5c3ad.pb3f20355.p7379180f$pff02f463$1.fd304ba20
        // field: p83f5c3ad.pb3f20355.p7379180f$pff02f463$1.fb4a88417
        // type: pb53cd12b
        // type: IllegalStateException
        // type: p7379180f$pff02f463$1
        return default!;
    }

    public object CalibrateNfc(pd0910e67 P0, object P1)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // str: "await(...)"
        // call: pd0910e67.calibrateNfc
        // call: ResultKt.throwOnFailure
        // call: pe6ff918f.<init>
        // call: IllegalStateException.<init>
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p98364e7f.getExecTime
        // call: Intrinsics.checkNotNullExpressionValue
        // call: RxAwaitKt.await
        // call: p7379180f$p8b4c9bdf$1.<init>
        // field: p83f5c3ad.pb3f20355.p7379180f$p8b4c9bdf$1.fd304ba20
        // field: p83f5c3ad.pb3f20355.p7379180f$p8b4c9bdf$1.fb4a88417
        // type: pe6ff918f
        // type: p7379180f$p8b4c9bdf$1
        // type: IllegalStateException
        return default!;
    }

    public object GetShowedNfcCalibrationCoordinates(object P0)
    {
        // call: p7379180f.isShowNfcSpot
        // call: p7379180f.mff02f463
        return default!;
    }

    public bool HasNfcFeature()
    {
        // field: p83f5c3ad.pb3f20355.p7379180f.f4a8bade5
        return false;
    }

    public object IsNfcCalibrated(object P0)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: p7379180f.mff02f463
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: ResultKt.throwOnFailure
        // call: IllegalStateException.<init>
        // call: Boxing.boxBoolean
        // call: p7379180f$pb48d42b5$1.<init>
        // field: p83f5c3ad.pb3f20355.p7379180f$pb48d42b5$1.fd304ba20
        // field: p83f5c3ad.pb3f20355.p7379180f$pb48d42b5$1.fb4a88417
        // type: p7379180f$pb48d42b5$1
        // type: IllegalStateException
        return default!;
    }

    public bool IsNfcEnabled()
    {
        // call: object.isEnabled
        // call: p7379180f.hasNfcFeature
        // field: p83f5c3ad.pb3f20355.p7379180f.f4a8bade5
        return false;
    }

    public bool IsShowNfcSpot()
    {
        // call: ReadWriteProperty.getValue
        // call: bool.booleanValue
        // field: p83f5c3ad.pb3f20355.p7379180f.isShowNfcSpot$delegate
        // field: p83f5c3ad.pb3f20355.p7379180f.$$delegatedProperties
        return false;
    }

    public IAsyncEnumerable<object> ObserveNfcCardCommunicationStatus(pd0910e67 P0)
    {
        // str: "paymentTerminal"
        // call: Intrinsics.checkNotNullParameter
        // call: FlowKt.callbackFlow
        // call: p7379180f$pc15a69f1$1.<init>
        // type: p7379180f$pc15a69f1$1
        return default!;
    }

    public object SetNfcCalibrationCoordinates(pd0910e67 P0, pb53cd12b P1, object P2)
    {
        // call: pb53cd12b.getPercentY
        // call: pd0910e67.setNfcCalibrationCoordinates
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: pb53cd12b.getPercentX
        // call: RxAwaitKt.await
        // call: pb3959c0c.<init>
        // field: kotlin.Unit.INSTANCE
        // type: pb3959c0c
        return default!;
    }

    public void SetShowNfcSpot(bool P0)
    {
        // call: ReadWriteProperty.setValue
        // call: bool.valueOf
        // field: p83f5c3ad.pb3f20355.p7379180f.$$delegatedProperties
        // field: p83f5c3ad.pb3f20355.p7379180f.isShowNfcSpot$delegate
    }

}
