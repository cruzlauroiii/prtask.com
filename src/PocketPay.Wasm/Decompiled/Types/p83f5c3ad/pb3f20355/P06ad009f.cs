namespace WillowMaze.Wasm.Decompiled;

public class P06ad009f : Pc33d3892
{
    private static object[] $$delegatedProperties;
    public static string F399c7945;
    public static string F72adb75c;
    public static string F75ee255f;
    public static string F7e72fbec;
    public static p06ad009f$p910eef8c F910eef8c;
    public static p06ad009f$p910eef8c Facef2c3d;
    private pa9a62e70 F05b295b1;
    private readonly MutableSharedFlow F180432d8;
    private pa9a62e70 F24eed33e;
    private readonly MutableSharedFlow F30b5ef83;
    private readonly object F3189b814;
    private readonly object F31a1fd14;
    private readonly MutableSharedFlow F3d3ec0c6;
    private readonly pff5fedb1 F4260ded3;
    private readonly pfa2012fc F496a5ac6;
    private readonly pfa2012fc F4a139836;
    private readonly object F5478d274;
    private readonly pff5fedb1 F5ac3f4d2;
    private pa9a62e70 F7381e3a4;
    private readonly object F7beae0aa;
    private readonly object F931c5254;
    private pa9a62e70 Fb63eb1b1;
    private readonly pff5fedb1 Fcc5805ef;
    private readonly pff5fedb1 Fd88d4cee;
    private readonly MutableSharedFlow Fe4cd86a8;
    private readonly MutableSharedFlow Fe55be9ea;
    private readonly pfa2012fc Fe8e9d286;
    private pa9a62e70 Ff3a5fd5e;
    private readonly ReadWriteProperty IsActivated$delegate;
    private readonly Lazy<object> Sp$delegate;

    public static MutableSharedFlow M2a5d772c(p06ad009f P0)
    {
        // field: p83f5c3ad.pb3f20355.p06ad009f.f30b5ef83
        return default!;
    }

    public static Dictionary<string, object> M48ee6d88(object P0)
    {
        // call: p06ad009f.m68395acf
        return default!;
    }

    private static Dictionary<string, object> M68395acf(object P0)
    {
        // str: "7e814862264d038e2eebd53d71751c88dc746f96d4cf41c1dbf85aefbf8743116e9c0b658b4f2b"
        // call: DecryptString.decryptString
        // call: object.getSharedPreferences
        return default!;
    }

    private Dictionary<string, object> M88f189d6()
    {
        // str: "getValue(...)"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Lazy<object>.getValue
        // field: p83f5c3ad.pb3f20355.p06ad009f.sp$delegate
        return default!;
    }

    private void Md2bd8000(bool P0)
    {
        // call: ReadWriteProperty.setValue
        // call: bool.valueOf
        // field: p83f5c3ad.pb3f20355.p06ad009f.$$delegatedProperties
        // field: p83f5c3ad.pb3f20355.p06ad009f.isActivated$delegate
    }

    private bool Mf9c0b3d1()
    {
        // call: bool.booleanValue
        // call: ReadWriteProperty.getValue
        // field: p83f5c3ad.pb3f20355.p06ad009f.$$delegatedProperties
        // field: p83f5c3ad.pb3f20355.p06ad009f.isActivated$delegate
        return false;
    }

    public bool CheckActivated()
    {
        // call: p970119bf.getActivationManager
        // call: pb0de681f.isActivated
        // call: pff5fedb1.getSecurityProvider
        // field: p83f5c3ad.pb3f20355.p06ad009f.fd88d4cee
        return false;
    }

    public object ConfirmRegWithOtp(string P0, object P1)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // str: ""
        // call: IllegalStateException.<init>
        // call: ResultKt.throwOnFailure
        // call: pca201447.<init>
        // call: p06ad009f$pbb5eb0ce$1.<init>
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: RxAwaitKt.await
        // call: pa9a62e70.confirmActivationWithOtp
        // field: p83f5c3ad.pb3f20355.p06ad009f.f24eed33e
        // field: p83f5c3ad.pb3f20355.p06ad009f$pbb5eb0ce$1.fd304ba20
        // field: kotlin.Unit.INSTANCE
        // field: p83f5c3ad.pb3f20355.p06ad009f$pbb5eb0ce$1.fb4a88417
        // type: IllegalStateException
        // type: pca201447
        // type: p06ad009f$pbb5eb0ce$1
        return default!;
    }

    public SharedFlow GetActivationSms()
    {
        // call: FlowKt.asSharedFlow
        // field: p83f5c3ad.pb3f20355.p06ad009f.f30b5ef83
        return default!;
    }

    public pfa2012fc GetTokenRepository()
    {
        // field: p83f5c3ad.pb3f20355.p06ad009f.f496a5ac6
        return default!;
    }

    public pff5fedb1 GetTophLibrary()
    {
        // field: p83f5c3ad.pb3f20355.p06ad009f.fd88d4cee
        return default!;
    }

    public void HandleActivationSms(object P0)
    {
        // str: "activationSms"
        // call: p06ad009f$p063eed77$1.<init>
        // call: BuildersKt.launch$default
        // call: Intrinsics.checkNotNullParameter
        // field: p83f5c3ad.pb3f20355.p06ad009f.f31a1fd14
        // type: p06ad009f$p063eed77$1
    }

    public object InitActivation(p4536d9ae P0, object P1)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: pff5fedb1.getSecurityProvider
        // call: p4536d9ae.getActivationType
        // call: p970119bf.getActivationManager
        // call: ResultKt.throwOnFailure
        // call: p4536d9ae.getActivationCredentials
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: RxAwaitKt.await
        // call: pb0de681f.performActivation
        // call: pfa2012fc.getFcmToken
        // call: IllegalStateException.<init>
        // call: p06ad009f$p27a1f813$1.<init>
        // field: p83f5c3ad.pb3f20355.p06ad009f$p27a1f813$1.fd304ba20
        // field: p83f5c3ad.pb3f20355.p06ad009f$p27a1f813$1.L$1
        // field: p83f5c3ad.pb3f20355.p06ad009f$p27a1f813$1.L$3
        // field: p83f5c3ad.pb3f20355.p06ad009f$p27a1f813$1.L$2
        // field: p83f5c3ad.pb3f20355.p06ad009f$p27a1f813$1.L$0
        // field: p83f5c3ad.pb3f20355.p06ad009f.fd88d4cee
        // field: p83f5c3ad.pb3f20355.p06ad009f.f24eed33e
        // field: p83f5c3ad.pb3f20355.p06ad009f.f496a5ac6
        // field: kotlin.Unit.INSTANCE
        // field: p83f5c3ad.pb3f20355.p06ad009f$p27a1f813$1.fb4a88417
        // type: p06ad009f$p27a1f813$1
        // type: IllegalStateException
        return default!;
    }

    public bool IsTopActivated()
    {
        // call: p06ad009f.mf9c0b3d1
        return false;
    }

    public object ResetActivation(object P0)
    {
        // call: RxAwaitKt.await
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: pb0de681f.resetActivation
        // call: p970119bf.getActivationManager
        // call: pff5fedb1.getSecurityProvider
        // field: p83f5c3ad.pb3f20355.p06ad009f.fd88d4cee
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public void ResetTopActivated()
    {
        // call: p06ad009f.md2bd8000
    }

    public void SetTopActivated()
    {
        // call: p06ad009f.md2bd8000
    }

}
