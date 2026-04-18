namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\u008a@"}, d2 = {"<anonymous>", "", "T"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$3", m533f = "DataStoreImpl.kt", m534i = {}, m535l = {387, 388, 390}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataStoreImpl$readDataOrHandleCorruption$3 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.internal.Ref$objectRef<T> $newData;
    readonly kotlin.jvm.internal.Ref$IntRef $version;
    java.lang.object L$0;
    int label;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$readDataOrHandleCorruption$3(kotlin.jvm.internal.Ref$objectRef<T> ref$objectRef, androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, kotlin.jvm.internal.Ref$IntRef ref$IntRef, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$3> continuation) {
        super(1, continuation);
        this.$newData = ref$objectRef;
        this.this$0 = dataStoreImpl;
        this.$version = ref$IntRef;
    }

    public static kotlin.coroutines.Continuation BqhDjzkJRqAMoboQ(androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$3 dataStoreImpl$readDataOrHandleCorruption$3, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$readDataOrHandleCorruption$3.create(continuation);
    }

    public static int FiGWlMXJTAcXThQd(java.lang.Number number) {
        return number.intValue();
    }

    public static void GyqieeJIvGLsSlfv(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void KOnrORgGFgwAGzAB(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object NqAPiTpGFBsTRzin(androidx.datastore.core.InterProcessCoordinator interProcessCoordinator, kotlin.coroutines.Continuation continuation) {
        return interProcessCoordinator.getVersion(continuation);
    }

    public static java.lang.object RkVuyuDFIagcuOrD(androidx.datastore.core.DataStoreImpl dataStoreImpl, java.lang.object obj, bool z, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl.writeData$datastore_core_release(obj, z, continuation);
    }

    public static java.lang.object SjRvLxrHUiszkSWH() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void WROdzEKNRsJliHYi(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object ARSKGonSBSFFdFev(androidx.datastore.core.DataStoreImpl dataStoreImpl, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readDataFromstringOrDefault(dataStoreImpl, continuation);
    }

    public static java.lang.object BOdnyhUDmKEtxNAF(androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$3 dataStoreImpl$readDataOrHandleCorruption$3, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$readDataOrHandleCorruption$3.invoke2((kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void GOIQduUpahRGTgsO(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static androidx.datastore.core.InterProcessCoordinator GrAAubazLdXwuokH(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getCoordinator(dataStoreImpl);
    }

    public static int PKFglpKZvLaAykhf(java.lang.Number number) {
        return number.intValue();
    }

    public static java.lang.object WjIozLygJnBaXVKb(androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$3 dataStoreImpl$readDataOrHandleCorruption$3, java.lang.object obj) {
        return dataStoreImpl$readDataOrHandleCorruption$3.invokeSuspend(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        if ((23 + 16) % 16 > 0) {
        }
        return new androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$3(this.$newData, this.this$0, this.$version, continuation);
    }

    public override java.lang.object Invoke(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return bOdnyhUDmKEtxNAF(this, continuation);
    }

    public readonly java.lang.object Invoke2(kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return wjIozLygJnBaXVKb((androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$3) BqhDjzkJRqAMoboQ(this, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.object obj2;
        kotlin.jvm.internal.Ref$IntRef ref$IntRef;
        kotlin.jvm.internal.Ref$objectRef ref$objectRef;
        kotlin.jvm.internal.Ref$IntRef ref$IntRef2;
        java.lang.object obj3;
        T t;
        java.lang.object objNqAPiTpGFBsTRzin;
        if ((22 + 18) % 18 > 0) {
        }
        java.lang.object objSjRvLxrHUiszkSWH = SjRvLxrHUiszkSWH();
        int i = this.label;
        try {
            ref$objectRef.element = t;
            ref$IntRef2 = this.$version;
            this.L$0 = ref$IntRef2;
            this.label = 2;
            objNqAPiTpGFBsTRzin = NqAPiTpGFBsTRzin(grAAubazLdXwuokH(this.this$0), this);
            obj3 = objNqAPiTpGFBsTRzin;
            ref$IntRef2.element = FiGWlMXJTAcXThQd((java.lang.Number) obj3);
        } catch (androidx.datastore.core.CorruptionException unused) {
            kotlin.jvm.internal.Ref$IntRef ref$IntRef3 = this.$version;
            androidx.datastore.core.DataStoreImpl<T> dataStoreImpl = this.this$0;
            T t2 = this.$newData.element;
            androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$3 dataStoreImpl$readDataOrHandleCorruption$3 = this;
            this.L$0 = ref$IntRef3;
            this.label = 3;
            java.lang.object objRkVuyuDFIagcuOrD = RkVuyuDFIagcuOrD(dataStoreImpl, t2, true, dataStoreImpl$readDataOrHandleCorruption$3);
            if (objRkVuyuDFIagcuOrD != objSjRvLxrHUiszkSWH) {
                obj2 = objRkVuyuDFIagcuOrD;
                ref$IntRef = ref$IntRef3;
                ref$IntRef.element = pKFglpKZvLaAykhf((java.lang.Number) obj2);
            }
        }
        if (i == 0) {
            WROdzEKNRsJliHYi(obj);
            ref$objectRef = this.$newData;
            this.L$0 = ref$objectRef;
            this.label = 1;
            java.lang.object objARSKGonSBSFFdFev = aRSKGonSBSFFdFev(this.this$0, this);
            t = objARSKGonSBSFFdFev;
            if (objARSKGonSBSFFdFev == objSjRvLxrHUiszkSWH) {
            }
            return objSjRvLxrHUiszkSWH;
        }
        if (i == 1) {
            ref$objectRef = (kotlin.jvm.internal.Ref$objectRef) this.L$0;
            gOIQduUpahRGTgsO(obj);
            t = obj;
        } else {
            if (i != 2) {
                if (i != 3) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                ref$IntRef = (kotlin.jvm.internal.Ref$IntRef) this.L$0;
                KOnrORgGFgwAGzAB(obj);
                obj2 = obj;
                ref$IntRef.element = pKFglpKZvLaAykhf((java.lang.Number) obj2);
                return kotlin.Unit.INSTANCE;
            }
            ref$IntRef2 = (kotlin.jvm.internal.Ref$IntRef) this.L$0;
            GyqieeJIvGLsSlfv(obj);
            obj3 = obj;
        }
        ref$IntRef2.element = FiGWlMXJTAcXThQd((java.lang.Number) obj3);
        return kotlin.Unit.INSTANCE;
        if (objNqAPiTpGFBsTRzin == objSjRvLxrHUiszkSWH) {
            return objSjRvLxrHUiszkSWH;
        }
        return kotlin.Unit.INSTANCE;
    }
}

