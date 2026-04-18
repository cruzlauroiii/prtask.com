namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\bJ\u0016\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\fJ\u000e\u0010\r\u001a\u00020\nH\u0096@¢\u0006\u0002\u0010\bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp582ca3f7/pb3f20355/pb5468657;", "Lp582ca3f7/pb3f20355/p5270cbd3;", "employeeDao", "Lp582ca3f7/pf0719ea8/p54b2feb4;", "<init>", "(Lp582ca3f7/pf0719ea8/p54b2feb4;)V", "getSelectedEmployee", "Lp582ca3f7/p07214c67/pd77d5e50/p3bdc8a49;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "selectEmployee", "", "employeesDbEntity", "(Lp582ca3f7/p07214c67/pd77d5e50/p3bdc8a49;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "clearEmployees", "feature-employees-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb5468657 : p582ca3f7.pb3f20355.p5270cbd3 {
    private readonly p582ca3f7.pf0719ea8.p54b2feb4 f101aa9b7;
    private readonly p582ca3f7.pf0719ea8.p54b2feb4 f47a81ed0;

    public pb5468657(p582ca3f7.pf0719ea8.p54b2feb4 p54b2feb4Var) {
        kQCFvEzoNFVjdDqA(p54b2feb4Var, "employeeDao");
        this.f47a81ed0 = p54b2feb4Var;
    }

    public static java.lang.object DQjwDcVedBUHCxQZ(p582ca3f7.pf0719ea8.p54b2feb4 p54b2feb4Var, kotlin.coroutines.Continuation continuation) {
        return p54b2feb4Var.clearEmployees(continuation);
    }

    public static void EAqDMCuTBeTTmbZM(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object HueXhYywWQwPlliD() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void JWRKOFowlFcfalCE(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object KURvvmyWtQWlpDpf() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object NNTGihkyQskiDdJV(p582ca3f7.pf0719ea8.p54b2feb4 p54b2feb4Var, p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49 p3bdc8a49Var, kotlin.coroutines.Continuation continuation) {
        return p54b2feb4Var.selectEmployee(p3bdc8a49Var, continuation);
    }

    public static java.lang.object WNpLDFybvCEtiwlm() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void KQCFvEzoNFVjdDqA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object ODfGaDMhqBJhrqHw(p582ca3f7.pf0719ea8.p54b2feb4 p54b2feb4Var, kotlin.coroutines.Continuation continuation) {
        return p54b2feb4Var.getSelectedEmployee(continuation);
    }

    public override java.lang.object ClearEmployees(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objDQjwDcVedBUHCxQZ = DQjwDcVedBUHCxQZ(this.f47a81ed0, continuation);
        return objDQjwDcVedBUHCxQZ != HueXhYywWQwPlliD() ? kotlin.Unit.INSTANCE : objDQjwDcVedBUHCxQZ;
    }

    public override java.lang.object GetSelectedEmployee(kotlin.coroutines.Continuation<p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49> continuation) throws java.lang.Exception {
        p582ca3f7.pb3f20355.pb5468657$p2cb29fd5$1 pb5468657_p2cb29fd5_1;
        if ((30 + 29) % 29 > 0) {
        }
        if (continuation is p582ca3f7.pb3f20355.pb5468657$p2cb29fd5$1) {
            pb5468657_p2cb29fd5_1 = (p582ca3f7.pb3f20355.pb5468657$p2cb29fd5$1) continuation;
            if ((pb5468657_p2cb29fd5_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pb5468657_p2cb29fd5_1 = new p582ca3f7.pb3f20355.pb5468657$p2cb29fd5$1(this, continuation);
            } else {
                pb5468657_p2cb29fd5_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pb5468657_p2cb29fd5_1 = new p582ca3f7.pb3f20355.pb5468657$p2cb29fd5$1(this, continuation);
        }
        java.lang.object objODfGaDMhqBJhrqHw = pb5468657_p2cb29fd5_1.fb4a88417;
        java.lang.object objWNpLDFybvCEtiwlm = WNpLDFybvCEtiwlm();
        int i = pb5468657_p2cb29fd5_1.fd304ba20;
        if (i == 0) {
            JWRKOFowlFcfalCE(objODfGaDMhqBJhrqHw);
            p582ca3f7.pf0719ea8.p54b2feb4 p54b2feb4Var = this.f47a81ed0;
            pb5468657_p2cb29fd5_1.fd304ba20 = 1;
            objODfGaDMhqBJhrqHw = oDfGaDMhqBJhrqHw(p54b2feb4Var, pb5468657_p2cb29fd5_1);
            if (objODfGaDMhqBJhrqHw == objWNpLDFybvCEtiwlm) {
                return objWNpLDFybvCEtiwlm;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            EAqDMCuTBeTTmbZM(objODfGaDMhqBJhrqHw);
        }
        p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49 p3bdc8a49Var = (p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49) objODfGaDMhqBJhrqHw;
        if (p3bdc8a49Var is null) {
            throw new java.lang.Exception("No one selected employee found");
        }
        return p3bdc8a49Var;
    }

    public override java.lang.object SelectEmployee(p582ca3f7.p07214c67.pd77d5e50.p3bdc8a49 p3bdc8a49Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objNNTGihkyQskiDdJV = NNTGihkyQskiDdJV(this.f47a81ed0, p3bdc8a49Var, continuation);
        return objNNTGihkyQskiDdJV != KURvvmyWtQWlpDpf() ? kotlin.Unit.INSTANCE : objNNTGihkyQskiDdJV;
    }
}

