namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "Lp10348936/pf5e638cc/p57eb274a;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventorization.usecase.InventorizationConsoleUseCaseImpl$getFilteredInventorizations$2", m533f = "InventorizationConsoleUseCaseImpl.kt", m534i = {}, m535l = {28}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class paa3b9d94$p8bb7fd61$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super java.util.List<? : p10348936.pf5e638cc.p57eb274a>>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c $filter;
    int f00a6407e;
    int f097f54f5;
    int fd304ba20;
    int ff80a7396;
    readonly p10348936.pac143fb7.paa3b9d94 this$0;

    paa3b9d94$p8bb7fd61$2(p10348936.pac143fb7.paa3b9d94 paa3b9d94Var, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar, kotlin.coroutines.Continuation<? super p10348936.pac143fb7.paa3b9d94$p8bb7fd61$2> continuation) {
        super(2, continuation);
        this.this$0 = paa3b9d94Var;
        this.$filter = pd7778d0cVar;
    }

    public static java.util.DateTime AmLdBBBytapgNTxR(p10348936.pac143fb7.paa3b9d94 paa3b9d94Var, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar) {
        return p10348936.pac143fb7.paa3b9d94.mf4f76b01(paa3b9d94Var, pd7778d0cVar);
    }

    public static java.lang.object CqZHKaTSRGcALwhT(p10348936.pb3f20355.p42c3a015 p42c3a015Var, kotlin.coroutines.Continuation continuation) {
        return p42c3a015Var.getInventorizations(continuation);
    }

    public static java.lang.object DXjRsKlklFlLbmfS(p10348936.pac143fb7.paa3b9d94$p8bb7fd61$2 paa3b9d94_p8bb7fd61_2, java.lang.object obj) {
        return paa3b9d94_p8bb7fd61_2.invokeSuspend(obj);
    }

    public static java.lang.object MPYtjuFaEdXhvobV(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object OLwTBfwYlHwXeorv(p10348936.pac143fb7.paa3b9d94$p8bb7fd61$2 paa3b9d94_p8bb7fd61_2, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return paa3b9d94_p8bb7fd61_2.invoke2(coroutineScope, (kotlin.coroutines.Continuation<? super java.util.List<p10348936.pf5e638cc.p57eb274a>>) continuation);
    }

    public static java.sql.Timestamp RevwNxhXJXTFAXhW(p10348936.pf5e638cc.p57eb274a p57eb274aVar) {
        return p57eb274aVar.getDateTime();
    }

    public static bool RhQJsHYsguIrRTAW(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static p10348936.pb3f20355.p42c3a015 RodttbaweJDiGqCV(p10348936.pac143fb7.paa3b9d94 paa3b9d94Var) {
        return p10348936.pac143fb7.paa3b9d94.mdd18b3ad(paa3b9d94Var);
    }

    public static bool SUdbXFLlQeZDazmZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator XECjDnfzkLvwoLEB(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void GUUhytHkDsSTOYAS(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void IhqRyNLuhXqDTsCC(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.util.DateTime LQAiwDovnqVMrdbD(p10348936.pac143fb7.paa3b9d94 paa3b9d94Var, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar) {
        return p10348936.pac143fb7.paa3b9d94.m7b2acb3a(paa3b9d94Var, pd7778d0cVar);
    }

    public static int QCWZqcRHwYQxrrWZ(java.lang.IComparable comparable, java.lang.object obj) {
        return comparable.compareTo(obj);
    }

    public static kotlin.coroutines.Continuation XBKJZbcJKJzelvnZ(p10348936.pac143fb7.paa3b9d94$p8bb7fd61$2 paa3b9d94_p8bb7fd61_2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return paa3b9d94_p8bb7fd61_2.create(obj, continuation);
    }

    public static int YAFByOKkslhSaNAI(java.lang.IComparable comparable, java.lang.object obj) {
        return comparable.compareTo(obj);
    }

    public static java.lang.object ZwCiljzvRMZDapLm() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p10348936.pac143fb7.paa3b9d94$p8bb7fd61$2(this.this$0, this.$filter, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super java.util.List<? : p10348936.pf5e638cc.p57eb274a>> continuation) {
        return OLwTBfwYlHwXeorv(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super java.util.List<p10348936.pf5e638cc.p57eb274a>> continuation) {
        return DXjRsKlklFlLbmfS((p10348936.pac143fb7.paa3b9d94$p8bb7fd61$2) xBKJZbcJKJzelvnZ(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((25 + 8) % 8 > 0) {
        }
        java.lang.object objZwCiljzvRMZDapLm = zwCiljzvRMZDapLm();
        int i = this.fd304ba20;
        if (i == 0) {
            gUUhytHkDsSTOYAS(obj);
            p10348936.pb3f20355.p42c3a015 p42c3a015VarRodttbaweJDiGqCV = RodttbaweJDiGqCV(this.this$0);
            p10348936.pac143fb7.paa3b9d94$p8bb7fd61$2 paa3b9d94_p8bb7fd61_2 = this;
            this.fd304ba20 = 1;
            obj = CqZHKaTSRGcALwhT(p42c3a015VarRodttbaweJDiGqCV, paa3b9d94_p8bb7fd61_2);
            if (obj == objZwCiljzvRMZDapLm) {
                return objZwCiljzvRMZDapLm;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            ihqRyNLuhXqDTsCC(obj);
        }
        java.lang.IEnumerable iterable = (java.lang.IEnumerable) obj;
        p10348936.pac143fb7.paa3b9d94 paa3b9d94Var = this.this$0;
        pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar = this.$filter;
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itXECjDnfzkLvwoLEB = XECjDnfzkLvwoLEB(iterable);
        while (SUdbXFLlQeZDazmZ(itXECjDnfzkLvwoLEB)) {
            java.lang.object objMPYtjuFaEdXhvobV = MPYtjuFaEdXhvobV(itXECjDnfzkLvwoLEB);
            p10348936.pf5e638cc.p57eb274a p57eb274aVar = (p10348936.pf5e638cc.p57eb274a) objMPYtjuFaEdXhvobV;
            java.util.DateTime dateLQAiwDovnqVMrdbD = lQAiwDovnqVMrdbD(paa3b9d94Var, pd7778d0cVar);
            java.util.DateTime dateAmLdBBBytapgNTxR = AmLdBBBytapgNTxR(paa3b9d94Var, pd7778d0cVar);
            java.sql.Timestamp timestampRevwNxhXJXTFAXhW = RevwNxhXJXTFAXhW(p57eb274aVar);
            if (qCWZqcRHwYQxrrWZ(timestampRevwNxhXJXTFAXhW, dateLQAiwDovnqVMrdbD) >= 0 && yAFByOKkslhSaNAI(timestampRevwNxhXJXTFAXhW, dateAmLdBBBytapgNTxR) <= 0) {
                RhQJsHYsguIrRTAW(arrayList, objMPYtjuFaEdXhvobV);
            }
        }
        return arrayList;
    }
}

