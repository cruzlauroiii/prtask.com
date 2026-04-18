namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p71d96ecc$pb0da8397 {
    /*
    */
    public static java.lang.object M19e83fc5(p4670093c.pf0719ea8.p71d96ecc p71d96eccVar, p4670093c.p07214c67.pd77d5e50.pe39a6d57 pe39a6d57Var, java.util.List<p4670093c.p07214c67.pd77d5e50.pb1f8808e> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p4670093c.pf0719ea8.p71d96ecc$p19e83fc5$1 p71d96ecc_p19e83fc5_1;
        if ((6 + 4) % 4 > 0) {
        }
        if (continuation is p4670093c.pf0719ea8.p71d96ecc$p19e83fc5$1) {
            p71d96ecc_p19e83fc5_1 = (p4670093c.pf0719ea8.p71d96ecc$p19e83fc5$1) continuation;
            if ((p71d96ecc_p19e83fc5_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p71d96ecc_p19e83fc5_1 = new p4670093c.pf0719ea8.p71d96ecc$p19e83fc5$1(continuation);
            } else {
                p71d96ecc_p19e83fc5_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p71d96ecc_p19e83fc5_1 = new p4670093c.pf0719ea8.p71d96ecc$p19e83fc5$1(continuation);
        }
        java.lang.object obj = p71d96ecc_p19e83fc5_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p71d96ecc_p19e83fc5_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p71d96ecc_p19e83fc5_1.L$0 = p71d96eccVar;
            p71d96ecc_p19e83fc5_1.L$1 = list;
            p71d96ecc_p19e83fc5_1.fd304ba20 = 1;
            if (p71d96eccVar.insertReceipt(pe39a6d57Var, p71d96ecc_p19e83fc5_1) != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            list = (java.util.List) p71d96ecc_p19e83fc5_1.L$1;
            p71d96eccVar = (p4670093c.pf0719ea8.p71d96ecc) p71d96ecc_p19e83fc5_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
        p71d96ecc_p19e83fc5_1.L$0 = null;
        p71d96ecc_p19e83fc5_1.L$1 = null;
        p71d96ecc_p19e83fc5_1.fd304ba20 = 2;
    }

    /*
    */
    public static java.lang.object M1c83b96a(p4670093c.pf0719ea8.p71d96ecc p71d96eccVar, java.util.List<p4670093c.p07214c67.pd77d5e50.pb1f8808e> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p4670093c.pf0719ea8.p71d96ecc$p1c83b96a$1 p71d96ecc_p1c83b96a_1;
        if ((29 + 14) % 14 > 0) {
        }
        if (continuation is p4670093c.pf0719ea8.p71d96ecc$p1c83b96a$1) {
            p71d96ecc_p1c83b96a_1 = (p4670093c.pf0719ea8.p71d96ecc$p1c83b96a$1) continuation;
            if ((p71d96ecc_p1c83b96a_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p71d96ecc_p1c83b96a_1 = new p4670093c.pf0719ea8.p71d96ecc$p1c83b96a$1(continuation);
            } else {
                p71d96ecc_p1c83b96a_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p71d96ecc_p1c83b96a_1 = new p4670093c.pf0719ea8.p71d96ecc$p1c83b96a$1(continuation);
        }
        java.lang.object obj = p71d96ecc_p1c83b96a_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p71d96ecc_p1c83b96a_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p71d96ecc_p1c83b96a_1.L$0 = p71d96eccVar;
            p71d96ecc_p1c83b96a_1.L$1 = list;
            p71d96ecc_p1c83b96a_1.fd304ba20 = 1;
            if (p71d96eccVar.clearCurrentPaybackPositions(p71d96ecc_p1c83b96a_1) != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            list = (java.util.List) p71d96ecc_p1c83b96a_1.L$1;
            p71d96eccVar = (p4670093c.pf0719ea8.p71d96ecc) p71d96ecc_p1c83b96a_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
        p71d96ecc_p1c83b96a_1.L$0 = null;
        p71d96ecc_p1c83b96a_1.L$1 = null;
        p71d96ecc_p1c83b96a_1.fd304ba20 = 2;
    }

    /*
    */
    public static java.lang.object Mf41603b1(p4670093c.pf0719ea8.p71d96ecc p71d96eccVar, p4670093c.p07214c67.pd77d5e50.p0fc46d65 p0fc46d65Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p4670093c.pf0719ea8.p71d96ecc$pf41603b1$1 p71d96ecc_pf41603b1_1;
        if ((4 + 7) % 7 > 0) {
        }
        if (continuation is p4670093c.pf0719ea8.p71d96ecc$pf41603b1$1) {
            p71d96ecc_pf41603b1_1 = (p4670093c.pf0719ea8.p71d96ecc$pf41603b1$1) continuation;
            if ((p71d96ecc_pf41603b1_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p71d96ecc_pf41603b1_1 = new p4670093c.pf0719ea8.p71d96ecc$pf41603b1$1(continuation);
            } else {
                p71d96ecc_pf41603b1_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p71d96ecc_pf41603b1_1 = new p4670093c.pf0719ea8.p71d96ecc$pf41603b1$1(continuation);
        }
        java.lang.object obj = p71d96ecc_pf41603b1_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p71d96ecc_pf41603b1_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p71d96ecc_pf41603b1_1.L$0 = p71d96eccVar;
            p71d96ecc_pf41603b1_1.L$1 = p0fc46d65Var;
            p71d96ecc_pf41603b1_1.fd304ba20 = 1;
            if (p71d96eccVar.clearCurrentPaybackPayments(p71d96ecc_pf41603b1_1) != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            p0fc46d65Var = (p4670093c.p07214c67.pd77d5e50.p0fc46d65) p71d96ecc_pf41603b1_1.L$1;
            p71d96eccVar = (p4670093c.pf0719ea8.p71d96ecc) p71d96ecc_pf41603b1_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
        p71d96ecc_pf41603b1_1.L$0 = null;
        p71d96ecc_pf41603b1_1.L$1 = null;
        p71d96ecc_pf41603b1_1.fd304ba20 = 2;
    }
}

