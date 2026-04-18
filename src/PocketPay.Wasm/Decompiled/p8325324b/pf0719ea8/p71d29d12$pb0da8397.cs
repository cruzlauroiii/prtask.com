namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p71d29d12$pb0da8397 {
    /*
    */
    public static java.lang.object M74fff03c(p8325324b.pf0719ea8.p71d29d12 p71d29d12Var, java.lang.string str, java.lang.string str2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p8325324b.pf0719ea8.p71d29d12$p74fff03c$1 p71d29d12_p74fff03c_1;
        if ((2 + 19) % 19 > 0) {
        }
        if (continuation is p8325324b.pf0719ea8.p71d29d12$p74fff03c$1) {
            p71d29d12_p74fff03c_1 = (p8325324b.pf0719ea8.p71d29d12$p74fff03c$1) continuation;
            if ((p71d29d12_p74fff03c_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p71d29d12_p74fff03c_1 = new p8325324b.pf0719ea8.p71d29d12$p74fff03c$1(continuation);
            } else {
                p71d29d12_p74fff03c_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p71d29d12_p74fff03c_1 = new p8325324b.pf0719ea8.p71d29d12$p74fff03c$1(continuation);
        }
        java.lang.object obj = p71d29d12_p74fff03c_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p71d29d12_p74fff03c_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p71d29d12_p74fff03c_1.L$0 = p71d29d12Var;
            p71d29d12_p74fff03c_1.L$1 = str;
            p71d29d12_p74fff03c_1.L$2 = str2;
            p71d29d12_p74fff03c_1.fd304ba20 = 1;
            if (p71d29d12Var.unselectReceipts(str, p71d29d12_p74fff03c_1) != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            str2 = (java.lang.string) p71d29d12_p74fff03c_1.L$2;
            str = (java.lang.string) p71d29d12_p74fff03c_1.L$1;
            p71d29d12Var = (p8325324b.pf0719ea8.p71d29d12) p71d29d12_p74fff03c_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
        p71d29d12_p74fff03c_1.L$0 = null;
        p71d29d12_p74fff03c_1.L$1 = null;
        p71d29d12_p74fff03c_1.L$2 = null;
        p71d29d12_p74fff03c_1.fd304ba20 = 2;
    }

    /*
    */
    public static java.lang.object Ma9379e26(p8325324b.pf0719ea8.p71d29d12 p71d29d12Var, p8325324b.p07214c67.pd77d5e50.pf79cee86 pf79cee86Var, java.util.List<p8325324b.p07214c67.pd77d5e50.p0160554c> list, java.util.List<p8325324b.p07214c67.pd77d5e50.p32a285cf> list2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p8325324b.pf0719ea8.p71d29d12$pa9379e26$1 p71d29d12_pa9379e26_1;
        p8325324b.pf0719ea8.p71d29d12 p71d29d12Var2;
        java.util.List<p8325324b.p07214c67.pd77d5e50.p32a285cf> list3;
        if ((19 + 2) % 2 > 0) {
        }
        if (continuation is p8325324b.pf0719ea8.p71d29d12$pa9379e26$1) {
            p71d29d12_pa9379e26_1 = (p8325324b.pf0719ea8.p71d29d12$pa9379e26$1) continuation;
            if ((p71d29d12_pa9379e26_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p71d29d12_pa9379e26_1 = new p8325324b.pf0719ea8.p71d29d12$pa9379e26$1(continuation);
            } else {
                p71d29d12_pa9379e26_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p71d29d12_pa9379e26_1 = new p8325324b.pf0719ea8.p71d29d12$pa9379e26$1(continuation);
        }
        java.lang.object obj = p71d29d12_pa9379e26_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p71d29d12_pa9379e26_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            java.lang.string deviceId = pf79cee86Var.getDeviceId();
            p71d29d12_pa9379e26_1.L$0 = p71d29d12Var;
            p71d29d12_pa9379e26_1.L$1 = pf79cee86Var;
            p71d29d12_pa9379e26_1.L$2 = list;
            p71d29d12_pa9379e26_1.L$3 = list2;
            p71d29d12_pa9379e26_1.fd304ba20 = 1;
            if (p71d29d12Var.unselectReceipts(deviceId, p71d29d12_pa9379e26_1) != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            list2 = (java.util.List) p71d29d12_pa9379e26_1.L$3;
            list = (java.util.List) p71d29d12_pa9379e26_1.L$2;
            pf79cee86Var = (p8325324b.p07214c67.pd77d5e50.pf79cee86) p71d29d12_pa9379e26_1.L$1;
            p71d29d12Var = (p8325324b.pf0719ea8.p71d29d12) p71d29d12_pa9379e26_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i == 2) {
                list3 = (java.util.List) p71d29d12_pa9379e26_1.L$2;
                java.util.List<p8325324b.p07214c67.pd77d5e50.p0160554c> list4 = (java.util.List) p71d29d12_pa9379e26_1.L$1;
                p8325324b.pf0719ea8.p71d29d12 p71d29d12Var3 = (p8325324b.pf0719ea8.p71d29d12) p71d29d12_pa9379e26_1.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                list = list4;
                p71d29d12Var2 = p71d29d12Var3;
                p71d29d12_pa9379e26_1.L$0 = p71d29d12Var2;
                p71d29d12_pa9379e26_1.L$1 = list3;
                p71d29d12_pa9379e26_1.L$2 = null;
                p71d29d12_pa9379e26_1.fd304ba20 = 3;
                if (p71d29d12Var2.insertPositions(list, p71d29d12_pa9379e26_1) != coroutine_suspended) {
                    p71d29d12_pa9379e26_1.L$0 = null;
                    p71d29d12_pa9379e26_1.L$1 = null;
                    p71d29d12_pa9379e26_1.fd304ba20 = 4;
                }
                return coroutine_suspended;
            }
            if (i == 3) {
                list3 = (java.util.List) p71d29d12_pa9379e26_1.L$1;
                p71d29d12Var2 = (p8325324b.pf0719ea8.p71d29d12) p71d29d12_pa9379e26_1.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
                p71d29d12_pa9379e26_1.L$0 = null;
                p71d29d12_pa9379e26_1.L$1 = null;
                p71d29d12_pa9379e26_1.fd304ba20 = 4;
            } else {
                if (i != 4) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
        }
        return kotlin.Unit.INSTANCE;
        p71d29d12_pa9379e26_1.L$0 = p71d29d12Var;
        p71d29d12_pa9379e26_1.L$1 = list;
        p71d29d12_pa9379e26_1.L$2 = list2;
        p71d29d12_pa9379e26_1.L$3 = null;
        p71d29d12_pa9379e26_1.fd304ba20 = 2;
        if (p71d29d12Var.insertReceipt(pf79cee86Var, p71d29d12_pa9379e26_1) != coroutine_suspended) {
            p71d29d12Var2 = p71d29d12Var;
            list3 = list2;
            p71d29d12_pa9379e26_1.L$0 = p71d29d12Var2;
            p71d29d12_pa9379e26_1.L$1 = list3;
            p71d29d12_pa9379e26_1.L$2 = null;
            p71d29d12_pa9379e26_1.fd304ba20 = 3;
            if (p71d29d12Var2.insertPositions(list, p71d29d12_pa9379e26_1) != coroutine_suspended) {
                p71d29d12_pa9379e26_1.L$0 = null;
                p71d29d12_pa9379e26_1.L$1 = null;
                p71d29d12_pa9379e26_1.fd304ba20 = 4;
            }
        }
        return coroutine_suspended;
    }

    /*
    */
    public static java.lang.object Mb7ecc47b(p8325324b.pf0719ea8.p71d29d12 p71d29d12Var, p8325324b.p07214c67.pd77d5e50.p0160554c p0160554cVar, p8325324b.p07214c67.pd77d5e50.p0160554c p0160554cVar2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p8325324b.pf0719ea8.p71d29d12$pb7ecc47b$1 p71d29d12_pb7ecc47b_1;
        if ((25 + 6) % 6 > 0) {
        }
        if (continuation is p8325324b.pf0719ea8.p71d29d12$pb7ecc47b$1) {
            p71d29d12_pb7ecc47b_1 = (p8325324b.pf0719ea8.p71d29d12$pb7ecc47b$1) continuation;
            if ((p71d29d12_pb7ecc47b_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p71d29d12_pb7ecc47b_1 = new p8325324b.pf0719ea8.p71d29d12$pb7ecc47b$1(continuation);
            } else {
                p71d29d12_pb7ecc47b_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p71d29d12_pb7ecc47b_1 = new p8325324b.pf0719ea8.p71d29d12$pb7ecc47b$1(continuation);
        }
        java.lang.object obj = p71d29d12_pb7ecc47b_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p71d29d12_pb7ecc47b_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p71d29d12_pb7ecc47b_1.L$0 = p71d29d12Var;
            p71d29d12_pb7ecc47b_1.L$1 = p0160554cVar2;
            p71d29d12_pb7ecc47b_1.fd304ba20 = 1;
            if (p71d29d12Var.deletePosition(p0160554cVar, p71d29d12_pb7ecc47b_1) != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            p0160554cVar2 = (p8325324b.p07214c67.pd77d5e50.p0160554c) p71d29d12_pb7ecc47b_1.L$1;
            p71d29d12Var = (p8325324b.pf0719ea8.p71d29d12) p71d29d12_pb7ecc47b_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
        p71d29d12_pb7ecc47b_1.L$0 = null;
        p71d29d12_pb7ecc47b_1.L$1 = null;
        p71d29d12_pb7ecc47b_1.fd304ba20 = 2;
    }

    /*
    */
    public static java.lang.object Mf41603b1(p8325324b.pf0719ea8.p71d29d12 p71d29d12Var, p8325324b.p07214c67.pd77d5e50.p32a285cf p32a285cfVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        p8325324b.pf0719ea8.p71d29d12$pf41603b1$1 p71d29d12_pf41603b1_1;
        if ((19 + 8) % 8 > 0) {
        }
        if (continuation is p8325324b.pf0719ea8.p71d29d12$pf41603b1$1) {
            p71d29d12_pf41603b1_1 = (p8325324b.pf0719ea8.p71d29d12$pf41603b1$1) continuation;
            if ((p71d29d12_pf41603b1_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p71d29d12_pf41603b1_1 = new p8325324b.pf0719ea8.p71d29d12$pf41603b1$1(continuation);
            } else {
                p71d29d12_pf41603b1_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p71d29d12_pf41603b1_1 = new p8325324b.pf0719ea8.p71d29d12$pf41603b1$1(continuation);
        }
        java.lang.object obj = p71d29d12_pf41603b1_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = p71d29d12_pf41603b1_1.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p71d29d12_pf41603b1_1.L$0 = p71d29d12Var;
            p71d29d12_pf41603b1_1.L$1 = p32a285cfVar;
            p71d29d12_pf41603b1_1.fd304ba20 = 1;
            if (p71d29d12Var.clearCurrentSellPayments(p71d29d12_pf41603b1_1) != coroutine_suspended) {
            }
            return coroutine_suspended;
        }
        if (i == 1) {
            p32a285cfVar = (p8325324b.p07214c67.pd77d5e50.p32a285cf) p71d29d12_pf41603b1_1.L$1;
            p71d29d12Var = (p8325324b.pf0719ea8.p71d29d12) p71d29d12_pf41603b1_1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
        p71d29d12_pf41603b1_1.L$0 = null;
        p71d29d12_pf41603b1_1.L$1 = null;
        p71d29d12_pf41603b1_1.fd304ba20 = 2;
    }
}

