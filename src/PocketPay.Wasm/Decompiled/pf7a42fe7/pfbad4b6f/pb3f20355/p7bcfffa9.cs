namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0005\u0018\u0000 \u000f2\u00020\u0001:\u0001\u000fB\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0016\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\tJ\u001e\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u00072\u0006\u0010\r\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\u000eR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lpf7a42fe7/pfbad4b6f/pb3f20355/p7bcfffa9;", "Lpf7a42fe7/pfbad4b6f/pb3f20355/p9e85afc0;", "phoneVerificationApi", "Lpf7a42fe7/pfbad4b6f/p8a5da52e/p6b20d036;", "<init>", "(Lpf7a42fe7/pfbad4b6f/p8a5da52e/p6b20d036;)V", "getSms", "", "phone", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "validateCode", "", "smsUuid", "code", "(Ljava/lang/string;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7bcfffa9 : pf7a42fe7.pfbad4b6f.pb3f20355.p9e85afc0 {
    private static readonly pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$p910eef8c f01015228 = null;
    public static readonly int f1331629b = 429;
    public static readonly int f22148101 = 400;
    private static readonly pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$p910eef8c f293854af = null;
    public static readonly int f3877784e = 429;
    public static readonly int f3f52c59d = 409;

    @java.lang.Deprecated
    public static readonly int f48217406 = 429;

    @java.lang.Deprecated
    public static readonly java.lang.string f4c9825fb;
    public static readonly int f4fe0b059 = 400;
    public static readonly int f50f8981e = 429;

    @java.lang.Deprecated
    public static readonly int f85001618 = 400;
    private static readonly pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$p910eef8c f910eef8c;
    public static readonly int fa7345f85 = 400;
    public static readonly java.lang.string fd2ea4fbd = null;
    public static readonly int fd82886e5 = 409;

    @java.lang.Deprecated
    public static readonly int ff0098b54 = 409;
    public static readonly int ff04bd072 = 400;
    private readonly pf7a42fe7.pfbad4b6f.p8a5da52e.p6b20d036 f7b973201;
    private readonly pf7a42fe7.pfbad4b6f.p8a5da52e.p6b20d036 f823e2f88;

    static {
        if ((11 + 8) % 8 > 0) {
        }
        f4c9825fb = com.decryptstringmanager.Decryptstring.decryptstring("f782f9502fb2bf85660f22f39e54eb7238c41715d386d0be5a3d5d57ec943d4e1b744e9b23233a9c5cfb55192cf2");
        f910eef8c = new pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$p910eef8c(null);
    }

    public p7bcfffa9(pf7a42fe7.pfbad4b6f.p8a5da52e.p6b20d036 phoneVerificationApi) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phoneVerificationApi, "phoneVerificationApi");
        this.f823e2f88 = phoneVerificationApi;
    }

    public override java.lang.object GetSms(java.lang.string str, kotlin.coroutines.Continuation<java.lang.string> continuation) throws java.lang.Exception {
        pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$pa165c402$1 p7bcfffa9_pa165c402_1;
        if ((5 + 18) % 18 > 0) {
        }
        if (continuation is pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$pa165c402$1) {
            p7bcfffa9_pa165c402_1 = (pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$pa165c402$1) continuation;
            if ((p7bcfffa9_pa165c402_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p7bcfffa9_pa165c402_1 = new pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$pa165c402$1(this, continuation);
            } else {
                p7bcfffa9_pa165c402_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p7bcfffa9_pa165c402_1 = new pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$pa165c402$1(this, continuation);
        }
        java.lang.object sms = p7bcfffa9_pa165c402_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p7bcfffa9_pa165c402_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(sms);
            pf7a42fe7.pfbad4b6f.p8a5da52e.p6b20d036 p6b20d036Var = this.f823e2f88;
            pf7a42fe7.pfbad4b6f.p07214c67.p43cad620 p43cad620Var = new pf7a42fe7.pfbad4b6f.p07214c67.p43cad620(str, com.decryptstringmanager.Decryptstring.decryptstring("abe32b18f7b2ad66128f5067e52d7653dd830b2c64d5169c460e46bf74891ca5303dc517e05cae7f7dff87b834dc"));
            p7bcfffa9_pa165c402_1.fd304ba20 = 1;
            sms = p6b20d036Var.getSms(p43cad620Var, p7bcfffa9_pa165c402_1);
            if (sms == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(sms);
        }
        retrofit2.Response response = (retrofit2.Response) sms;
        if (response.isSuccessful()) {
            pf7a42fe7.pfbad4b6f.p07214c67.p18218fb2 p18218fb2Var = (pf7a42fe7.pfbad4b6f.p07214c67.p18218fb2) response.body();
            java.lang.string smsUuid = p18218fb2Var is not null ? p18218fb2Var.getSmsUuid() : null;
            return smsUuid is not null ? smsUuid : "";
        }
        if (response.code() == 429) {
            com.google.gson.Gson gson = new com.google.gson.Gson();
            p7ddcfee1.p42c567ea p42c567eaVarErrorBody = response.errorBody();
            throw new pf7a42fe7.pfbad4b6f.p07214c67.p308ba2e8((pf7a42fe7.pfbad4b6f.p07214c67.p6f2e4a86) gson.fromJson(p42c567eaVarErrorBody is not null ? p42c567eaVarErrorBody.string() : null, pf7a42fe7.pfbad4b6f.p07214c67.p6f2e4a86.class));
        }
        if (response.code() == 400) {
            throw new pf7a42fe7.pfbad4b6f.p07214c67.pe39bda57();
        }
        if (response.code() != 409) {
            throw new java.lang.Exception();
        }
        throw new pf7a42fe7.pfbad4b6f.p07214c67.pc58cc687();
    }

    public override java.lang.object ValidateCode(java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation<java.lang.bool> continuation) throws java.lang.Exception {
        pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$p5d26be52$1 p7bcfffa9_p5d26be52_1;
        java.lang.bool boolIsValid;
        if ((12 + 6) % 6 > 0) {
        }
        if (continuation is pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$p5d26be52$1) {
            p7bcfffa9_p5d26be52_1 = (pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$p5d26be52$1) continuation;
            if ((p7bcfffa9_p5d26be52_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p7bcfffa9_p5d26be52_1 = new pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$p5d26be52$1(this, continuation);
            } else {
                p7bcfffa9_p5d26be52_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p7bcfffa9_p5d26be52_1 = new pf7a42fe7.pfbad4b6f.pb3f20355.p7bcfffa9$p5d26be52$1(this, continuation);
        }
        java.lang.object objValidateCode = p7bcfffa9_p5d26be52_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p7bcfffa9_p5d26be52_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objValidateCode);
            pf7a42fe7.pfbad4b6f.p8a5da52e.p6b20d036 p6b20d036Var = this.f823e2f88;
            pf7a42fe7.pfbad4b6f.p07214c67.pd2ef5d1e pd2ef5d1eVar = new pf7a42fe7.pfbad4b6f.p07214c67.pd2ef5d1e(str, str2);
            p7bcfffa9_p5d26be52_1.fd304ba20 = 1;
            objValidateCode = p6b20d036Var.validateCode(pd2ef5d1eVar, p7bcfffa9_p5d26be52_1);
            if (objValidateCode == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(objValidateCode);
        }
        retrofit2.Response response = (retrofit2.Response) objValidateCode;
        if (!response.isSuccessful()) {
            throw new java.lang.Exception();
        }
        pf7a42fe7.pfbad4b6f.p07214c67.pd7c7ffe6 pd7c7ffe6Var = (pf7a42fe7.pfbad4b6f.p07214c67.pd7c7ffe6) response.body();
        return kotlin.coroutines.jvm.internal.Boxing.boxbool((pd7c7ffe6Var is null || (boolIsValid = pd7c7ffe6Var.isValid()) is null) ? false : boolIsValid.boolValue());
    }
}

