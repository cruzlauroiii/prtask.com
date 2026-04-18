namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p4447a398$pb0da8397 {
    public static void DBOWzQsrSHpzGKcX(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object UlEUzmcARHJUmzMk() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void XBhaKHwLuZCoVGUP(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void GliutkcbZDWRsTws(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object HnWsnhbVCIMoTJrB(p10348936.pf0719ea8.p4447a398 p4447a398Var, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.insertInventorizationPositions(list, continuation);
    }

    /*
    */
    public static java.lang.object M3a2c4d23(p10348936.pf0719ea8.p4447a398 p4447a398Var, p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar, java.util.List<p10348936.pf5e638cc.pd77d5e50.p555020e1> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p10348936.pf0719ea8.p4447a398$p3a2c4d23$1 p4447a398_p3a2c4d23_1;
        if ((14 + 19) % 19 > 0) {
        }
        if (continuation is p10348936.pf0719ea8.p4447a398$p3a2c4d23$1) {
            p4447a398_p3a2c4d23_1 = (p10348936.pf0719ea8.p4447a398$p3a2c4d23$1) continuation;
            if ((p4447a398_p3a2c4d23_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p4447a398_p3a2c4d23_1 = new p10348936.pf0719ea8.p4447a398$p3a2c4d23$1(continuation);
            } else {
                p4447a398_p3a2c4d23_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p4447a398_p3a2c4d23_1 = new p10348936.pf0719ea8.p4447a398$p3a2c4d23$1(continuation);
        }
        java.lang.object obj = p4447a398_p3a2c4d23_1.fb4a88417;
        java.lang.object objUlEUzmcARHJUmzMk = UlEUzmcARHJUmzMk();
        int i = p4447a398_p3a2c4d23_1.fd304ba20;
        if (i == 0) {
            XBhaKHwLuZCoVGUP(obj);
            p4447a398_p3a2c4d23_1.L$0 = p4447a398Var;
            p4447a398_p3a2c4d23_1.L$1 = list;
            p4447a398_p3a2c4d23_1.fd304ba20 = 1;
            if (tySRacDdcsAPKFSa(p4447a398Var, p4582d01fVar, p4447a398_p3a2c4d23_1) != objUlEUzmcARHJUmzMk) {
            }
            return objUlEUzmcARHJUmzMk;
        }
        if (i == 1) {
            list = (java.util.List) p4447a398_p3a2c4d23_1.L$1;
            p4447a398Var = (p10348936.pf0719ea8.p4447a398) p4447a398_p3a2c4d23_1.L$0;
            DBOWzQsrSHpzGKcX(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            gliutkcbZDWRsTws(obj);
        }
        return kotlin.Unit.INSTANCE;
        p4447a398_p3a2c4d23_1.L$0 = null;
        p4447a398_p3a2c4d23_1.L$1 = null;
        p4447a398_p3a2c4d23_1.fd304ba20 = 2;
    }

    public static java.lang.object TySRacDdcsAPKFSa(p10348936.pf0719ea8.p4447a398 p4447a398Var, p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.insertInventorization(p4582d01fVar, continuation);
    }
}

