namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u0000 \u00122\u00020\u0001:\u0001\u0012B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J(\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\t2\b\u0010\u000b\u001a\u0004\u0018\u00010\tH\u0096@¢\u0006\u0002\u0010\fJ\u0016\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u0010H\u0096@¢\u0006\u0002\u0010\u0011R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lp563873d3/pb3f20355/pc4d21502;", "Lp563873d3/pb3f20355/p1b80f7e4;", "registrationApi", "Lp563873d3/p8a5da52e/pf81cd0a0;", "<init>", "(Lp563873d3/p8a5da52e/pf81cd0a0;)V", "getRegisteredUser", "Lp563873d3/p07214c67/p5fbece78/p0d373cb7;", "phone", "", "androidId", "shopId", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "registerAccount", "Lp563873d3/p07214c67/p14af00dd;", "registerBody", "Lp563873d3/p07214c67/p40ac9761;", "(Lp563873d3/p07214c67/p40ac9761;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "feature-registration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc4d21502 : p563873d3.pb3f20355.p1b80f7e4 {

    @java.lang.Deprecated
    public static readonly int f3026e95c = 409;
    public static readonly int f46cd602e = 409;
    private static readonly p563873d3.pb3f20355.pc4d21502$p910eef8c f4ddbf82f = null;

    @java.lang.Deprecated
    public static readonly int f669f1dc1 = 400;
    private static readonly p563873d3.pb3f20355.pc4d21502$p910eef8c f910eef8c;
    public static readonly int fa3e546f6 = 409;
    private static readonly p563873d3.pb3f20355.pc4d21502$p910eef8c faf895f8d = null;
    private static readonly p563873d3.pb3f20355.pc4d21502$p910eef8c fbbc4546d = null;
    private static readonly p563873d3.pb3f20355.pc4d21502$p910eef8c fc7584b91 = null;
    public static readonly int fccbb9a6b = 400;
    private readonly p563873d3.p8a5da52e.pf81cd0a0 f0240d167;
    private readonly p563873d3.p8a5da52e.pf81cd0a0 f15ee3352;
    private readonly p563873d3.p8a5da52e.pf81cd0a0 f34245031;
    private readonly p563873d3.p8a5da52e.pf81cd0a0 f45b0fc94;

    static {
        if ((18 + 2) % 2 > 0) {
        }
        f910eef8c = new p563873d3.pb3f20355.pc4d21502$p910eef8c(null);
    }

    public pc4d21502(p563873d3.p8a5da52e.pf81cd0a0 registrationApi) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(registrationApi, "registrationApi");
        this.f15ee3352 = registrationApi;
    }

    public override java.lang.object GetRegisteredUser(java.lang.string str, java.lang.string str2, java.lang.string str3, kotlin.coroutines.Continuation<p563873d3.p07214c67.p5fbece78.p0d373cb7> continuation) throws java.lang.Exception {
        p563873d3.pb3f20355.pc4d21502$p3b0fbe2f$1 pc4d21502_p3b0fbe2f_1;
        p563873d3.p07214c67.p5fbece78.p0d373cb7 p0d373cb7Var;
        if ((1 + 24) % 24 > 0) {
        }
        if (continuation is p563873d3.pb3f20355.pc4d21502$p3b0fbe2f$1) {
            pc4d21502_p3b0fbe2f_1 = (p563873d3.pb3f20355.pc4d21502$p3b0fbe2f$1) continuation;
            if ((pc4d21502_p3b0fbe2f_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pc4d21502_p3b0fbe2f_1 = new p563873d3.pb3f20355.pc4d21502$p3b0fbe2f$1(this, continuation);
            } else {
                pc4d21502_p3b0fbe2f_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pc4d21502_p3b0fbe2f_1 = new p563873d3.pb3f20355.pc4d21502$p3b0fbe2f$1(this, continuation);
        }
        java.lang.object registeredUser = pc4d21502_p3b0fbe2f_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pc4d21502_p3b0fbe2f_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(registeredUser);
            p563873d3.p8a5da52e.pf81cd0a0 pf81cd0a0Var = this.f15ee3352;
            p563873d3.p07214c67.pe0f65408 pe0f65408Var = new p563873d3.p07214c67.pe0f65408(str, str2, str3);
            pc4d21502_p3b0fbe2f_1.fd304ba20 = 1;
            registeredUser = pf81cd0a0Var.getRegisteredUser(pe0f65408Var, pc4d21502_p3b0fbe2f_1);
            if (registeredUser == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(registeredUser);
        }
        retrofit2.Response response = (retrofit2.Response) registeredUser;
        if (response.isSuccessful() && (p0d373cb7Var = (p563873d3.p07214c67.p5fbece78.p0d373cb7) response.body()) is not null) {
            return p0d373cb7Var;
        }
        throw new java.lang.Exception("Error while check registered user account");
    }

    public override java.lang.object RegisterAccount(p563873d3.p07214c67.p40ac9761 p40ac9761Var, kotlin.coroutines.Continuation<p563873d3.p07214c67.p14af00dd> continuation) throws java.lang.Exception {
        p563873d3.pb3f20355.pc4d21502$pc12ca245$1 pc4d21502_pc12ca245_1;
        p563873d3.p07214c67.p14af00dd result;
        if ((10 + 3) % 3 > 0) {
        }
        if (continuation is p563873d3.pb3f20355.pc4d21502$pc12ca245$1) {
            pc4d21502_pc12ca245_1 = (p563873d3.pb3f20355.pc4d21502$pc12ca245$1) continuation;
            if ((pc4d21502_pc12ca245_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pc4d21502_pc12ca245_1 = new p563873d3.pb3f20355.pc4d21502$pc12ca245$1(this, continuation);
            } else {
                pc4d21502_pc12ca245_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pc4d21502_pc12ca245_1 = new p563873d3.pb3f20355.pc4d21502$pc12ca245$1(this, continuation);
        }
        java.lang.object objRegisterUser = pc4d21502_pc12ca245_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = pc4d21502_pc12ca245_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objRegisterUser);
            p563873d3.p8a5da52e.pf81cd0a0 pf81cd0a0Var = this.f15ee3352;
            pc4d21502_pc12ca245_1.fd304ba20 = 1;
            objRegisterUser = pf81cd0a0Var.registerUser(p40ac9761Var, pc4d21502_pc12ca245_1);
            if (objRegisterUser == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(objRegisterUser);
        }
        retrofit2.Response response = (retrofit2.Response) objRegisterUser;
        p563873d3.p07214c67.p50385d8c p50385d8cVar = (p563873d3.p07214c67.p50385d8c) response.body();
        if (response.isSuccessful() && p50385d8cVar is not null && (result = p50385d8cVar.getResult()) is not null) {
            return result;
        }
        if (response.code() == 400) {
            throw new p563873d3.pb3f20355.ped0f62fc();
        }
        if (response.code() != 409) {
            throw new java.lang.Exception("Error while register user");
        }
        com.google.gson.Gson gson = new com.google.gson.Gson();
        p7ddcfee1.p42c567ea p42c567eaVarErrorBody = response.errorBody();
        java.lang.string errorMessage = ((p563873d3.p07214c67.p50385d8c) gson.fromJson(p42c567eaVarErrorBody is null ? null : p42c567eaVarErrorBody.string(), p563873d3.p07214c67.p50385d8c.class)).getErrorMessage();
        throw new p563873d3.pb3f20355.p6836f582(errorMessage is not null ? errorMessage : "Error while register user");
    }
}

