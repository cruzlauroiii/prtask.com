namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p54b2feb4$pb0da8397 {
    public static java.lang.object GAiYEQVGIdgKBlUm(p582ca3f7.pf0719ea8.p54b2feb4 p54b2feb4Var, p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49 p3bdc8a49Var, kotlin.coroutines.Continuation continuation) {
        return p54b2feb4Var.selectCurrentEmployee(p3bdc8a49Var, continuation);
    }

    public static void LoCfmninlhnvjmtG(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    /*
    */
    public static java.lang.object Mf2fcad63(p582ca3f7.pf0719ea8.p54b2feb4 p54b2feb4Var, p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49 p3bdc8a49Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p582ca3f7.pf0719ea8.p54b2feb4$pf2fcad63$1 p54b2feb4_pf2fcad63_1;
        if ((14 + 2) % 2 > 0) {
        }
        if (continuation is p582ca3f7.pf0719ea8.p54b2feb4$pf2fcad63$1) {
            p54b2feb4_pf2fcad63_1 = (p582ca3f7.pf0719ea8.p54b2feb4$pf2fcad63$1) continuation;
            if ((p54b2feb4_pf2fcad63_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p54b2feb4_pf2fcad63_1 = new p582ca3f7.pf0719ea8.p54b2feb4$pf2fcad63$1(continuation);
            } else {
                p54b2feb4_pf2fcad63_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p54b2feb4_pf2fcad63_1 = new p582ca3f7.pf0719ea8.p54b2feb4$pf2fcad63$1(continuation);
        }
        java.lang.object obj = p54b2feb4_pf2fcad63_1.fb4a88417;
        java.lang.object objRdQJyHnUUbjJUUjy = rdQJyHnUUbjJUUjy();
        int i = p54b2feb4_pf2fcad63_1.fd304ba20;
        if (i == 0) {
            loCfmninlhnvjmtG(obj);
            p54b2feb4_pf2fcad63_1.L$0 = p54b2feb4Var;
            p54b2feb4_pf2fcad63_1.L$1 = p3bdc8a49Var;
            p54b2feb4_pf2fcad63_1.fd304ba20 = 1;
            if (uvnxnlsNcyqDfhFR(p54b2feb4Var, p54b2feb4_pf2fcad63_1) != objRdQJyHnUUbjJUUjy) {
            }
            return objRdQJyHnUUbjJUUjy;
        }
        if (i == 1) {
            p3bdc8a49Var = (p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49) p54b2feb4_pf2fcad63_1.L$1;
            p54b2feb4Var = (p582ca3f7.pf0719ea8.p54b2feb4) p54b2feb4_pf2fcad63_1.L$0;
            yPqhXfvqLUnagGmw(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            yxnUEQaQFnrgrcvv(obj);
        }
        return kotlin.Unit.INSTANCE;
        p54b2feb4_pf2fcad63_1.L$0 = null;
        p54b2feb4_pf2fcad63_1.L$1 = null;
        p54b2feb4_pf2fcad63_1.fd304ba20 = 2;
    }

    public static java.lang.object RdQJyHnUUbjJUUjy() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object UvnxnlsNcyqDfhFR(p582ca3f7.pf0719ea8.p54b2feb4 p54b2feb4Var, kotlin.coroutines.Continuation continuation) {
        return p54b2feb4Var.clearEmployees(continuation);
    }

    public static void YPqhXfvqLUnagGmw(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void YxnUEQaQFnrgrcvv(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }
}

