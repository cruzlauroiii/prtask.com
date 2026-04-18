namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J$\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\f0\u000bH\u0096@¢\u0006\u0002\u0010\rJ\u0014\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u000f0\u000bH\u0096@¢\u0006\u0002\u0010\u0010J\u000e\u0010\u0011\u001a\u00020\u0012H\u0096@¢\u0006\u0002\u0010\u0010R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lp10348936/pb3f20355/p6be982a1;", "Lp10348936/pb3f20355/pba03ea40;", "inventorizationDao", "Lp10348936/pf0719ea8/p4447a398;", "<init>", "(Lp10348936/pf0719ea8/p4447a398;)V", "saveInventorization", "", "inventorizationDbEntity", "Lp10348936/pf5e638cc/pd77d5e50/p4582d01f;", "inventorizationPositionDbEntities", "", "Lp10348936/pf5e638cc/pd77d5e50/p555020e1;", "(Lp10348936/pf5e638cc/pd77d5e50/p4582d01f;Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getInventorizations", "Lp10348936/pf5e638cc/pd77d5e50/p649d38da;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getLastInventorizationNumber", "", "feature-inventorization-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6be982a1 : p10348936.pb3f20355.pba03ea40 {
    private readonly p10348936.pf0719ea8.p4447a398 f2e2a62f2;
    private readonly p10348936.pf0719ea8.p4447a398 f3806aa43;
    private readonly p10348936.pf0719ea8.p4447a398 f5306f996;
    private readonly p10348936.pf0719ea8.p4447a398 fe173c435;
    private readonly p10348936.pf0719ea8.p4447a398 fff045f6b;

    public p6be982a1(p10348936.pf0719ea8.p4447a398 p4447a398Var) {
        wPNrIewgodRoebpC(p4447a398Var, "inventorizationDao");
        this.fe173c435 = p4447a398Var;
    }

    public static java.lang.object AGQGgozEaVoZeJCq(p10348936.pf0719ea8.p4447a398 p4447a398Var, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.getInventorizations(continuation);
    }

    public static java.lang.object BHUSeCuxAmsLIciH(p10348936.pf0719ea8.p4447a398 p4447a398Var, p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.saveInventorization(p4582d01fVar, list, continuation);
    }

    public static java.lang.object HqNxpXSQRnxlrruu() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.int MmQfJLGpzfexrXlu(int i) {
        return kotlin.coroutines.jvm.internal.Boxing.boxInt(i);
    }

    public static int OMqJUnCKwYlvJsJV(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object VIHgUvRPUlcXlqGf() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void VvuKfPioFgQsqvSr(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void YTYJUarmQNtgjSIP(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object SkxRSltwSihmioUA(p10348936.pf0719ea8.p4447a398 p4447a398Var, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.getLastInventorizationNumber(continuation);
    }

    public static void WPNrIewgodRoebpC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override java.lang.object GetInventorizations(kotlin.coroutines.Continuation<? super java.util.List<p10348936.pf5e638cc.pd77d5e50.p649d38da>> continuation) {
        return AGQGgozEaVoZeJCq(this.fe173c435, continuation);
    }

    public override java.lang.object GetLastInventorizationNumber(kotlin.coroutines.Continuation<java.lang.int> continuation) throws java.lang.Exception {
        p10348936.pb3f20355.p6be982a1$p46ea6e27$1 p6be982a1_p46ea6e27_1;
        if ((21 + 16) % 16 > 0) {
        }
        if (continuation is p10348936.pb3f20355.p6be982a1$p46ea6e27$1) {
            p6be982a1_p46ea6e27_1 = (p10348936.pb3f20355.p6be982a1$p46ea6e27$1) continuation;
            if ((p6be982a1_p46ea6e27_1.fd304ba20 & int.MIN_VALUE) == 0) {
                p6be982a1_p46ea6e27_1 = new p10348936.pb3f20355.p6be982a1$p46ea6e27$1(this, continuation);
            } else {
                p6be982a1_p46ea6e27_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            p6be982a1_p46ea6e27_1 = new p10348936.pb3f20355.p6be982a1$p46ea6e27$1(this, continuation);
        }
        java.lang.object objSkxRSltwSihmioUA = p6be982a1_p46ea6e27_1.fb4a88417;
        java.lang.object objVIHgUvRPUlcXlqGf = VIHgUvRPUlcXlqGf();
        int i = p6be982a1_p46ea6e27_1.fd304ba20;
        if (i == 0) {
            YTYJUarmQNtgjSIP(objSkxRSltwSihmioUA);
            p10348936.pf0719ea8.p4447a398 p4447a398Var = this.fe173c435;
            p6be982a1_p46ea6e27_1.fd304ba20 = 1;
            objSkxRSltwSihmioUA = skxRSltwSihmioUA(p4447a398Var, p6be982a1_p46ea6e27_1);
            if (objSkxRSltwSihmioUA == objVIHgUvRPUlcXlqGf) {
                return objVIHgUvRPUlcXlqGf;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            VvuKfPioFgQsqvSr(objSkxRSltwSihmioUA);
        }
        java.lang.int num = (java.lang.int) objSkxRSltwSihmioUA;
        return MmQfJLGpzfexrXlu(num is null ? 0 : OMqJUnCKwYlvJsJV(num));
    }

    public override java.lang.object SaveInventorization(p10348936.pf5e638cc.pd77d5e50.p4582d01f p4582d01fVar, java.util.List<p10348936.pf5e638cc.pd77d5e50.p555020e1> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objBHUSeCuxAmsLIciH = BHUSeCuxAmsLIciH(this.fe173c435, p4582d01fVar, list, continuation);
        return objBHUSeCuxAmsLIciH != HqNxpXSQRnxlrruu() ? kotlin.Unit.INSTANCE : objBHUSeCuxAmsLIciH;
    }
}

