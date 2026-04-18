namespace WillowMaze.Wasm.Decompiled;

public class P8e8c9903 : P8a3a546e
{
    private readonly p9e85afc0 F2378c16f;
    private readonly p2f3c4196 F47a65b68;
    private readonly pfa2012fc F496a5ac6;
    private readonly p9e85afc0 F7733fd7e;
    private readonly p2f3c4196 F7cb50cf9;
    private readonly p9e85afc0 F7da71503;
    private readonly pfa2012fc Fa231dfc2;
    private readonly p2f3c4196 Fe3c01158;
    private readonly p2f3c4196 Fe639d08f;
    private readonly pfa2012fc Fe960cdd9;

    public object GetSms(string P0, object P1)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: pfa2012fc.clearToken
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p2f3c4196.saveSmsUuid
        // call: p9e85afc0.getSms
        // call: p8e8c9903$pa165c402$1.<init>
        // call: ResultKt.throwOnFailure
        // call: IllegalStateException.<init>
        // field: kotlin.Unit.INSTANCE
        // field: pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903$pa165c402$1.fd304ba20
        // field: pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903.fe639d08f
        // field: pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903.f496a5ac6
        // field: pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903$pa165c402$1.fb4a88417
        // field: pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903.f2378c16f
        // field: pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903$pa165c402$1.L$0
        // type: IllegalStateException
        // type: p8e8c9903$pa165c402$1
        return default!;
    }

    public object ValidateCode(string P0, object P1)
    {
        // call: p2f3c4196.getSmsUuid
        // call: p9e85afc0.validateCode
        // field: pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903.fe639d08f
        // field: pf7a42fe7.pfbad4b6f.pac143fb7.p8e8c9903.f2378c16f
        return default!;
    }

}
