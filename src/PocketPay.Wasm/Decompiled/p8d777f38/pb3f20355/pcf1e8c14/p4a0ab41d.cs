namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u001e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\fR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp8d777f38/pb3f20355/pcf1e8c14/p4a0ab41d;", "Lp8d777f38/pb3f20355/pcf1e8c14/p68086021;", "receiptApi", "Lp8d777f38/p8a5da52e/p79fa5c32;", "<init>", "(Lp8d777f38/p8a5da52e/p79fa5c32;)V", "sendReceipt", "", "receipt", "Lpad5f82e8/p07214c67/p1e11b989/pd6d7c5a3;", "resend", "", "(Lpad5f82e8/p07214c67/p1e11b989/pd6d7c5a3;ZLkotlin/coroutines/Continuation;)Ljava/lang/object;", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4a0ab41d : p8d777f38.pb3f20355.pcf1e8c14.p68086021 {
    private readonly p8d777f38.p8a5da52e.p79fa5c32 fa5270eb2;
    private readonly p8d777f38.p8a5da52e.p79fa5c32 fcbacd391;

    public p4a0ab41d(p8d777f38.p8a5da52e.p79fa5c32 p79fa5c32Var) {
        jRAAZVwqWrDqVzFb(p79fa5c32Var, "receiptApi");
        this.fa5270eb2 = p79fa5c32Var;
    }

    public static java.lang.object FSSaNvYmkdAEaCJH(p8d777f38.p8a5da52e.p79fa5c32 p79fa5c32Var, pad5f82e8.p07214c67.p1e11b989.pd6d7c5a3 pd6d7c5a3Var, kotlin.coroutines.Continuation continuation) {
        return p79fa5c32Var.sendReceipt(pd6d7c5a3Var, continuation);
    }

    public static void DgANyHmWZSzFAerb(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static int FVJUKRpZNZiYXJjj(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void JRAAZVwqWrDqVzFb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string LOBMvqwLChmkMPxq(com.google.gson.Gson gson, java.lang.object obj) {
        return gson.toJson(obj);
    }

    public static bool PMEVxabsHmmepGHS(retrofit2.Response response) {
        return response.isSuccessful();
    }

    public static void QJntwnBxXFCgERvQ(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object WOGvwlDQqnWYMvVA() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override java.lang.object SendReceipt(pad5f82e8.p07214c67.p1e11b989.pd6d7c5a3 pd6d7c5a3Var, bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p8d777f38.pb3f20355.pcf1e8c14.p4a0ab41d$p807ee7c0$1 p4a0ab41d_p807ee7c0_1;
        if ((4 + 1) % 1 > 0) {
        }
        if (continuation is p8d777f38.pb3f20355.pcf1e8c14.p4a0ab41d$p807ee7c0$1) {
            p4a0ab41d_p807ee7c0_1 = (p8d777f38.pb3f20355.pcf1e8c14.p4a0ab41d$p807ee7c0$1) continuation;
            if ((p4a0ab41d_p807ee7c0_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p4a0ab41d_p807ee7c0_1 = new p8d777f38.pb3f20355.pcf1e8c14.p4a0ab41d$p807ee7c0$1(this, continuation);
            } else {
                p4a0ab41d_p807ee7c0_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p4a0ab41d_p807ee7c0_1 = new p8d777f38.pb3f20355.pcf1e8c14.p4a0ab41d$p807ee7c0$1(this, continuation);
        }
        java.lang.object objFSSaNvYmkdAEaCJH = p4a0ab41d_p807ee7c0_1.fb4a88417;
        java.lang.object objWOGvwlDQqnWYMvVA = wOGvwlDQqnWYMvVA();
        int i = p4a0ab41d_p807ee7c0_1.fd304ba20;
        if (i == 0) {
            dgANyHmWZSzFAerb(objFSSaNvYmkdAEaCJH);
            fVJUKRpZNZiYXJjj("SENDED_RECEIPT_JSON", lOBMvqwLChmkMPxq(new com.google.gson.Gson(), pd6d7c5a3Var));
            p8d777f38.p8a5da52e.p79fa5c32 p79fa5c32Var = this.fa5270eb2;
            p4a0ab41d_p807ee7c0_1.fd304ba20 = 1;
            objFSSaNvYmkdAEaCJH = FSSaNvYmkdAEaCJH(p79fa5c32Var, pd6d7c5a3Var, p4a0ab41d_p807ee7c0_1);
            if (objFSSaNvYmkdAEaCJH == objWOGvwlDQqnWYMvVA) {
                return objWOGvwlDQqnWYMvVA;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            qJntwnBxXFCgERvQ(objFSSaNvYmkdAEaCJH);
        }
        if (pMEVxabsHmmepGHS((retrofit2.Response) objFSSaNvYmkdAEaCJH)) {
            return kotlin.Unit.INSTANCE;
        }
        throw new android.accounts.NetworkErrorException();
    }
}

