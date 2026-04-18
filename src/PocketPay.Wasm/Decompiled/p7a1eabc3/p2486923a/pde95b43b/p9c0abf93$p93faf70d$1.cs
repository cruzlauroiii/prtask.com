namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventory.presentation.edit.InventoryEditobjectModel$setCommodityData$1", m533f = "InventoryEditobjectModel.kt", m534i = {1}, m535l = {186, 187}, m536m = "invokeSuspend", m537n = {"measures"}, m538s = {"L$0"})
readonly class p9c0abf93$p93faf70d$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 $commodity;
    java.lang.object L$0;
    int f3e924e8c;
    int f828f03e6;
    int fc9b4b50a;
    int fd304ba20;
    int ffd6908a9;
    readonly p7a1eabc3.p2486923a.pde95b43b.p9c0abf93 this$0;

    p9c0abf93$p93faf70d$1(p7a1eabc3.p2486923a.pde95b43b.p9c0abf93 p9c0abf93Var, p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 p4cc9492b_pca87b160, kotlin.coroutines.Continuation<? super p7a1eabc3.p2486923a.pde95b43b.p9c0abf93$p93faf70d$1> continuation) {
        super(2, continuation);
        this.this$0 = p9c0abf93Var;
        this.$commodity = p4cc9492b_pca87b160;
    }

    public static com.google.firebase.crashlytics.FirebaseCrashlytics JNOdfMSLCnmlMqEA() {
        return com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance();
    }

    public static java.lang.object KPRnEllUvCEuMxMz() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object MVXevOEHypewwkPE(p7a1eabc3.pac143fb7.p0d270184 p0d270184Var, kotlin.coroutines.Continuation continuation) {
        return p0d270184Var.getTaxes(continuation);
    }

    public static void PcfnQDSWrnJyeNwd(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static java.lang.object SQileEsaaQyNyXwY(p7a1eabc3.p2486923a.pde95b43b.p9c0abf93$p93faf70d$1 p9c0abf93_p93faf70d_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p9c0abf93_p93faf70d_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static p7a1eabc3.pac143fb7.p386625bf SyINcoLwUriGBBot(p7a1eabc3.p2486923a.pde95b43b.p9c0abf93 p9c0abf93Var) {
        return p7a1eabc3.p2486923a.pde95b43b.p9c0abf93.m18c403ae(p9c0abf93Var);
    }

    public static androidx.lifecycle.MutableLiveData YvWXVngQiCmPYojw(p7a1eabc3.p2486923a.pde95b43b.p9c0abf93 p9c0abf93Var) {
        return p7a1eabc3.p2486923a.pde95b43b.p9c0abf93.m764e690b(p9c0abf93Var);
    }

    public static void ZrixDGSWRQqlXxxi(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object AwTGwXTrCliDikXW(p7a1eabc3.p2486923a.pde95b43b.p9c0abf93$p93faf70d$1 p9c0abf93_p93faf70d_1, java.lang.object obj) {
        return p9c0abf93_p93faf70d_1.invokeSuspend(obj);
    }

    public static java.lang.object DQvocyvmhJdEApXl(p7a1eabc3.pac143fb7.p386625bf p386625bfVar, kotlin.coroutines.Continuation continuation) {
        return p386625bfVar.getMeasures(continuation);
    }

    public static kotlin.coroutines.Continuation HgRVBDSSzvqgKTxS(p7a1eabc3.p2486923a.pde95b43b.p9c0abf93$p93faf70d$1 p9c0abf93_p93faf70d_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p9c0abf93_p93faf70d_1.create(obj, continuation);
    }

    public static p7a1eabc3.pac143fb7.p0d270184 HrMIfZdbIkceBQpK(p7a1eabc3.p2486923a.pde95b43b.p9c0abf93 p9c0abf93Var) {
        return p7a1eabc3.p2486923a.pde95b43b.p9c0abf93.m9ef71404(p9c0abf93Var);
    }

    public static void JsRXQsQAmKJmCIEd(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void LkxiidlCFBgSKBnQ(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void XzsSCiRpoPXDVhSC(com.google.firebase.crashlytics.FirebaseCrashlytics firebaseCrashlytics, java.lang.Exception th) {
        firebaseCrashlytics.recordException(th);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p7a1eabc3.p2486923a.pde95b43b.p9c0abf93$p93faf70d$1(this.this$0, this.$commodity, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return SQileEsaaQyNyXwY(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return awTGwXTrCliDikXW((p7a1eabc3.p2486923a.pde95b43b.p9c0abf93$p93faf70d$1) hgRVBDSSzvqgKTxS(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.util.List list;
        java.util.List list2;
        java.lang.object objMVXevOEHypewwkPE;
        if ((17 + 15) % 15 > 0) {
        }
        java.lang.object objKPRnEllUvCEuMxMz = KPRnEllUvCEuMxMz();
        int i = this.fd304ba20;
        try {
            list2 = (java.util.List) obj;
            this.L$0 = list2;
            this.fd304ba20 = 2;
            objMVXevOEHypewwkPE = MVXevOEHypewwkPE(hrMIfZdbIkceBQpK(this.this$0), this);
            return objKPRnEllUvCEuMxMz;
        } catch (java.lang.Exception e) {
            xzsSCiRpoPXDVhSC(JNOdfMSLCnmlMqEA(), e);
        }
        if (i == 0) {
            ZrixDGSWRQqlXxxi(obj);
            this.fd304ba20 = 1;
            obj = dQvocyvmhJdEApXl(SyINcoLwUriGBBot(this.this$0), this);
            if (obj == objKPRnEllUvCEuMxMz) {
            }
            return objKPRnEllUvCEuMxMz;
        }
        if (i == 1) {
            jsRXQsQAmKJmCIEd(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            list = (java.util.List) this.L$0;
            lkxiidlCFBgSKBnQ(obj);
        }
        PcfnQDSWrnJyeNwd(YvWXVngQiCmPYojw(this.this$0), new p7a1eabc3.p2486923a.pde95b43b.pb2dfbd87(this.$commodity, list, (java.util.List) obj));
        return kotlin.Unit.INSTANCE;
        if (objMVXevOEHypewwkPE != objKPRnEllUvCEuMxMz) {
            list = list2;
            obj = objMVXevOEHypewwkPE;
            PcfnQDSWrnJyeNwd(YvWXVngQiCmPYojw(this.this$0), new p7a1eabc3.p2486923a.pde95b43b.pb2dfbd87(this.$commodity, list, (java.util.List) obj));
            return kotlin.Unit.INSTANCE;
        }
    }
}

