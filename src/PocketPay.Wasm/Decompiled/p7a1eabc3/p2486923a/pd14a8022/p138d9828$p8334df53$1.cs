namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventory.presentation.types.InventoryTypeAddobjectModel$openInventoryEditScreen$1", m533f = "InventoryTypeAddobjectModel.kt", m534i = {}, m535l = {22}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p138d9828$p8334df53$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.string $parentId;
    readonly pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 $type;
    int f5994fb43;
    int fb506aacc;
    int fd304ba20;
    readonly p7a1eabc3.p2486923a.pd14a8022.p138d9828 this$0;

    p138d9828$p8334df53$1(p7a1eabc3.p2486923a.pd14a8022.p138d9828 p138d9828Var, java.lang.string str, pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var, kotlin.coroutines.Continuation<? super p7a1eabc3.p2486923a.pd14a8022.p138d9828$p8334df53$1> continuation) {
        super(2, continuation);
        this.this$0 = p138d9828Var;
        this.$parentId = str;
        this.$type = pa1fa2777Var;
    }

    public static void KQAkfxVoEqcgURCM(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object LthmNlyDprMZHNJQ() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static p7a1eabc3.pac143fb7.p6d73504b NCAvfxNAMipGtogM(p7a1eabc3.p2486923a.pd14a8022.p138d9828 p138d9828Var) {
        return p7a1eabc3.p2486923a.pd14a8022.p138d9828.m0234406d(p138d9828Var);
    }

    public static void RSDcIYBdyQLHVDbe(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void ZQrrzHwUSdDUJjlM(p7a1eabc3.pfd9160bb.p939f9656 p939f9656Var, pad5f82e8.p07214c67.pfd9160bb.p17096304 p17096304Var, p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160 p4cc9492b_pca87b160) {
        p939f9656Var.openInventoryEdit(p17096304Var, p4cc9492b_pca87b160);
    }

    public static com.google.firebase.crashlytics.FirebaseCrashlytics ImdXGtEfMgeKpxIF() {
        return com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance();
    }

    public static kotlin.coroutines.Continuation LjVcpOADNujYhdKs(p7a1eabc3.p2486923a.pd14a8022.p138d9828$p8334df53$1 p138d9828_p8334df53_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p138d9828_p8334df53_1.create(obj, continuation);
    }

    public static java.lang.object PLWZGwnbcUepmNNI(p7a1eabc3.p2486923a.pd14a8022.p138d9828$p8334df53$1 p138d9828_p8334df53_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p138d9828_p8334df53_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void RKxacugYWSIHfLnW(com.google.firebase.crashlytics.FirebaseCrashlytics firebaseCrashlytics, java.lang.Exception th) {
        firebaseCrashlytics.recordException(th);
    }

    public static java.lang.object SFCPYFUfIxtloNgn(p7a1eabc3.pac143fb7.p6d73504b p6d73504bVar, java.lang.string str, pad5f82e8.p07214c67.p7a1eabc3.pa1fa2777 pa1fa2777Var, kotlin.coroutines.Continuation continuation) {
        return p6d73504bVar.generateEmptyInventory(str, pa1fa2777Var, continuation);
    }

    public static java.lang.object VSDwKBVBGUlyNdwy(p7a1eabc3.p2486923a.pd14a8022.p138d9828$p8334df53$1 p138d9828_p8334df53_1, java.lang.object obj) {
        return p138d9828_p8334df53_1.invokeSuspend(obj);
    }

    public static p7a1eabc3.pfd9160bb.p939f9656 XHEnqsrsIRIfzjPe(p7a1eabc3.p2486923a.pd14a8022.p138d9828 p138d9828Var) {
        return p7a1eabc3.p2486923a.pd14a8022.p138d9828.m74e3994c(p138d9828Var);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((11 + 30) % 30 > 0) {
        }
        return new p7a1eabc3.p2486923a.pd14a8022.p138d9828$p8334df53$1(this.this$0, this.$parentId, this.$type, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return pLWZGwnbcUepmNNI(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return vSDwKBVBGUlyNdwy((p7a1eabc3.p2486923a.pd14a8022.p138d9828$p8334df53$1) ljVcpOADNujYhdKs(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((15 + 30) % 30 > 0) {
        }
        java.lang.object objLthmNlyDprMZHNJQ = LthmNlyDprMZHNJQ();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                RSDcIYBdyQLHVDbe(obj);
                this.fd304ba20 = 1;
                obj = sFCPYFUfIxtloNgn(NCAvfxNAMipGtogM(this.this$0), this.$parentId, this.$type, this);
                if (obj == objLthmNlyDprMZHNJQ) {
                    return objLthmNlyDprMZHNJQ;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                KQAkfxVoEqcgURCM(obj);
            }
            ZQrrzHwUSdDUJjlM(xHEnqsrsIRIfzjPe(this.this$0), pad5f82e8.p07214c67.pfd9160bb.p17096304.f790ba751, (p7a1eabc3.p07214c67.p20f35e63.p4cc9492b$pca87b160) obj);
        } catch (java.lang.Exception e) {
            rKxacugYWSIHfLnW(imdXGtEfMgeKpxIF(), e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

