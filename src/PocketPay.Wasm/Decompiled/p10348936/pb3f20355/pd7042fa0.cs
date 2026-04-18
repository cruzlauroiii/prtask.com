namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0016\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0096@¢\u0006\u0002\u0010\nJ\u000e\u0010\u000b\u001a\u00020\fH\u0096@¢\u0006\u0002\u0010\rJ\u0016\u0010\u000e\u001a\u00020\u00072\u0006\u0010\u000f\u001a\u00020\u0010H\u0096@¢\u0006\u0002\u0010\u0011J\u000e\u0010\u0012\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\rJ\u0016\u0010\u0013\u001a\u00020\u00072\u0006\u0010\u0014\u001a\u00020\u0015H\u0096@¢\u0006\u0002\u0010\u0016J\u0014\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\u00190\u0018H\u0096@¢\u0006\u0002\u0010\rJ\u0016\u0010\u001a\u001a\u00020\u00072\u0006\u0010\u0014\u001a\u00020\u0015H\u0096@¢\u0006\u0002\u0010\u0016J\u000e\u0010\u001b\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\rJ\u0016\u0010\u001c\u001a\u00020\u00072\u0006\u0010\u001d\u001a\u00020\u001eH\u0096@¢\u0006\u0002\u0010\u001fR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006 "}, d2 = {"Lp10348936/pb3f20355/pd7042fa0;", "Lp10348936/pb3f20355/p226a374c;", "inventorizationDao", "Lp10348936/pf0719ea8/p4447a398;", "<init>", "(Lp10348936/pf0719ea8/p4447a398;)V", "createCurrentInventorization", "", "inventorizationDbEntity", "Lp10348936/pf5e638cc/pd77d5e50/p12e406c7;", "(Lp10348936/pf5e638cc/pd77d5e50/p12e406c7;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCurrentInventorization", "Lp10348936/pf5e638cc/pd77d5e50/p34c3b0bd;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateCurrentInventorization", "status", "Lp10348936/pf5e638cc/p14abd389;", "(Lp10348936/pf5e638cc/p14abd389;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "clearCurrentInventorizations", "insertCurrentInventorizationPosition", "inventorizationPositionDbEntity", "Lp10348936/pf5e638cc/pd77d5e50/p0ed7807b;", "(Lp10348936/pf5e638cc/pd77d5e50/p0ed7807b;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getCurrentInventorizationPositions", "", "Lp10348936/pf5e638cc/pd77d5e50/p5e3e4f48;", "updateCurrentInventorizationPosition", "clearCurrentInventorizationPositions", "removeCurrentInventorizationPosition", "uuid", "", "(Ljava/lang/string;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "feature-inventorization-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd7042fa0 : p10348936.pb3f20355.p226a374c {
    private readonly p10348936.pf0719ea8.p4447a398 fb443a65c;
    private readonly p10348936.pf0719ea8.p4447a398 fcb2451c4;
    private readonly p10348936.pf0719ea8.p4447a398 fe173c435;

    public pd7042fa0(p10348936.pf0719ea8.p4447a398 p4447a398Var) {
        eLdjVXKuTEfWRmsr(p4447a398Var, "inventorizationDao");
        this.fe173c435 = p4447a398Var;
    }

    public static java.lang.object EuevTCfqgAkIBhJH(p10348936.pf0719ea8.p4447a398 p4447a398Var, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.clearCurrentInventorizations(continuation);
    }

    public static java.lang.object HBthjClvUodgHXxS(p10348936.pf0719ea8.p4447a398 p4447a398Var, p10348936.pf5e638cc.pd77d5e50.p0ed7807b p0ed7807bVar, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.insertCurrentInventorizationPosition(p0ed7807bVar, continuation);
    }

    public static java.lang.object OUOxLsABnvyobxZW() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object QbeTgpGFAOfqhhCA(p10348936.pf0719ea8.p4447a398 p4447a398Var, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.clearCurrentInventorizationPositions(continuation);
    }

    public static java.lang.object RASPNREnKLnRIsET() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void RTfMHAQVOFUMSzMu(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object SuORIKdBoXXonGYd(p10348936.pf0719ea8.p4447a398 p4447a398Var, java.lang.string str, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.removeCurrentInventorizationPosition(str, continuation);
    }

    public static java.lang.object YYkwuPXZncyHnAyr(p10348936.pf0719ea8.p4447a398 p4447a398Var, p10348936.pf5e638cc.pd77d5e50.p12e406c7 p12e406c7Var, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.createCurrentInventorization(p12e406c7Var, continuation);
    }

    public static java.lang.object YkzUIhZzUwtBxBxX() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void ELdjVXKuTEfWRmsr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object FOmQHWUZwFmSzqRd(p10348936.pf0719ea8.p4447a398 p4447a398Var, p10348936.pf5e638cc.pd77d5e50.p0ed7807b p0ed7807bVar, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.updateCurrentInventorizationPosition(p0ed7807bVar, continuation);
    }

    public static void FynyyZXaPMScjIlq(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object GFRKjRlrufvMzUob() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object INLmMcNRwgWzVkbE() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object LXLWwytMFfckEWfA() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object LhcQKrMRYcDUqIrC(p10348936.pf0719ea8.p4447a398 p4447a398Var, p10348936.pf5e638cc.p14abd389 p14abd389Var, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.updateCurrentInventorization(p14abd389Var, continuation);
    }

    public static java.lang.object MchCyAblTWhuhyJB(p10348936.pf0719ea8.p4447a398 p4447a398Var, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.getCurrentInventorizationPositions(continuation);
    }

    public static java.lang.object QKNRywRTGiolfAnk() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object TvBDBDVKwXQRPWWR(p10348936.pf0719ea8.p4447a398 p4447a398Var, kotlin.coroutines.Continuation continuation) {
        return p4447a398Var.getCurrentInventorization(continuation);
    }

    public static java.lang.object UYOeysFOEjIvbJvt() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.string VKIgpVMlBqCBAjcL(java.lang.object obj) {
        return obj.tostring();
    }

    public override java.lang.object ClearCurrentInventorizationPositions(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objQbeTgpGFAOfqhhCA = QbeTgpGFAOfqhhCA(this.fe173c435, continuation);
        return objQbeTgpGFAOfqhhCA != iNLmMcNRwgWzVkbE() ? kotlin.Unit.INSTANCE : objQbeTgpGFAOfqhhCA;
    }

    public override java.lang.object ClearCurrentInventorizations(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objEuevTCfqgAkIBhJH = EuevTCfqgAkIBhJH(this.fe173c435, continuation);
        return objEuevTCfqgAkIBhJH != gFRKjRlrufvMzUob() ? kotlin.Unit.INSTANCE : objEuevTCfqgAkIBhJH;
    }

    public override java.lang.object CreateCurrentInventorization(p10348936.pf5e638cc.pd77d5e50.p12e406c7 p12e406c7Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objYYkwuPXZncyHnAyr = YYkwuPXZncyHnAyr(this.fe173c435, p12e406c7Var, continuation);
        return objYYkwuPXZncyHnAyr != lXLWwytMFfckEWfA() ? kotlin.Unit.INSTANCE : objYYkwuPXZncyHnAyr;
    }

    public override java.lang.object GetCurrentInventorization(kotlin.coroutines.Continuation<p10348936.pf5e638cc.pd77d5e50.p34c3b0bd> continuation) throws java.lang.Exception {
        p10348936.pb3f20355.pd7042fa0$pc3bd4f53$1 pd7042fa0_pc3bd4f53_1;
        if ((32 + 3) % 3 > 0) {
        }
        if (continuation is p10348936.pb3f20355.pd7042fa0$pc3bd4f53$1) {
            pd7042fa0_pc3bd4f53_1 = (p10348936.pb3f20355.pd7042fa0$pc3bd4f53$1) continuation;
            if ((pd7042fa0_pc3bd4f53_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pd7042fa0_pc3bd4f53_1 = new p10348936.pb3f20355.pd7042fa0$pc3bd4f53$1(this, continuation);
            } else {
                pd7042fa0_pc3bd4f53_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pd7042fa0_pc3bd4f53_1 = new p10348936.pb3f20355.pd7042fa0$pc3bd4f53$1(this, continuation);
        }
        java.lang.object objTvBDBDVKwXQRPWWR = pd7042fa0_pc3bd4f53_1.fb4a88417;
        java.lang.object objQKNRywRTGiolfAnk = qKNRywRTGiolfAnk();
        int i = pd7042fa0_pc3bd4f53_1.fd304ba20;
        if (i == 0) {
            fynyyZXaPMScjIlq(objTvBDBDVKwXQRPWWR);
            p10348936.pf0719ea8.p4447a398 p4447a398Var = this.fe173c435;
            pd7042fa0_pc3bd4f53_1.fd304ba20 = 1;
            objTvBDBDVKwXQRPWWR = tvBDBDVKwXQRPWWR(p4447a398Var, pd7042fa0_pc3bd4f53_1);
            if (objTvBDBDVKwXQRPWWR == objQKNRywRTGiolfAnk) {
                return objQKNRywRTGiolfAnk;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            RTfMHAQVOFUMSzMu(objTvBDBDVKwXQRPWWR);
        }
        p10348936.pf5e638cc.pd77d5e50.p34c3b0bd p34c3b0bdVar = (p10348936.pf5e638cc.pd77d5e50.p34c3b0bd) objTvBDBDVKwXQRPWWR;
        if (p34c3b0bdVar is null) {
            throw new java.lang.IllegalStateException(vKIgpVMlBqCBAjcL("current inventorization not created"));
        }
        return p34c3b0bdVar;
    }

    public override java.lang.object GetCurrentInventorizationPositions(kotlin.coroutines.Continuation<? super java.util.List<p10348936.pf5e638cc.pd77d5e50.p5e3e4f48>> continuation) {
        return mchCyAblTWhuhyJB(this.fe173c435, continuation);
    }

    public override java.lang.object InsertCurrentInventorizationPosition(p10348936.pf5e638cc.pd77d5e50.p0ed7807b p0ed7807bVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objHBthjClvUodgHXxS = HBthjClvUodgHXxS(this.fe173c435, p0ed7807bVar, continuation);
        return objHBthjClvUodgHXxS != uYOeysFOEjIvbJvt() ? kotlin.Unit.INSTANCE : objHBthjClvUodgHXxS;
    }

    public override java.lang.object RemoveCurrentInventorizationPosition(java.lang.string str, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objSuORIKdBoXXonGYd = SuORIKdBoXXonGYd(this.fe173c435, str, continuation);
        return objSuORIKdBoXXonGYd != YkzUIhZzUwtBxBxX() ? kotlin.Unit.INSTANCE : objSuORIKdBoXXonGYd;
    }

    public override java.lang.object UpdateCurrentInventorization(p10348936.pf5e638cc.p14abd389 p14abd389Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objLhcQKrMRYcDUqIrC = lhcQKrMRYcDUqIrC(this.fe173c435, p14abd389Var, continuation);
        return objLhcQKrMRYcDUqIrC != OUOxLsABnvyobxZW() ? kotlin.Unit.INSTANCE : objLhcQKrMRYcDUqIrC;
    }

    public override java.lang.object UpdateCurrentInventorizationPosition(p10348936.pf5e638cc.pd77d5e50.p0ed7807b p0ed7807bVar, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objFOmQHWUZwFmSzqRd = fOmQHWUZwFmSzqRd(this.fe173c435, p0ed7807bVar, continuation);
        return objFOmQHWUZwFmSzqRd != RASPNREnKLnRIsET() ? kotlin.Unit.INSTANCE : objFOmQHWUZwFmSzqRd;
    }
}

