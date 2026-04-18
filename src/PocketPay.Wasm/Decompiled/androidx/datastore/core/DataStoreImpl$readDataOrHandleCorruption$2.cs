namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "Landroidx/datastore/core/Data;", "T", "locked", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$2", m533f = "DataStoreImpl.kt", m534i = {0, 1}, m535l = {370, 371}, m536m = "invokeSuspend", m537n = {"locked", "data"}, m538s = {"Z$0", "L$0"})
readonly class DataStoreImpl$readDataOrHandleCorruption$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<java.lang.bool, kotlin.coroutines.Continuation<? super androidx.datastore.core.Data<T>>, java.lang.object> {
    readonly int $preLockVersion;
    java.lang.object L$0;
    bool Z$0;
    int label;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$readDataOrHandleCorruption$2(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, int i, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$2> continuation) {
        super(2, continuation);
        this.this$0 = dataStoreImpl;
        this.$preLockVersion = i;
    }

    public static java.lang.bool MGCwMePnDJYENgAF(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void NykmCmIlBtkiJjOi(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static androidx.datastore.core.InterProcessCoordinator OcuyNIsOaYAketIj(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getCoordinator(dataStoreImpl);
    }

    public static void WsxPAHVhcMmVGxjT(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static int CQrLvWdnBrmBQseq(java.lang.Number number) {
        return number.intValue();
    }

    public static java.lang.object DtnnSdjvqVjpnPoC(androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$2 dataStoreImpl$readDataOrHandleCorruption$2, bool z, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$readDataOrHandleCorruption$2.invoke(z, continuation);
    }

    public static bool FufiOxhevljtific(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.object JDpNuFKZTHdztcDU(androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$2 dataStoreImpl$readDataOrHandleCorruption$2, java.lang.object obj) {
        return dataStoreImpl$readDataOrHandleCorruption$2.invokeSuspend(obj);
    }

    public static int KgjEqTRfRAeZcdIR(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.object KxhAluxRiIiDUOLK(androidx.datastore.core.InterProcessCoordinator interProcessCoordinator, kotlin.coroutines.Continuation continuation) {
        return interProcessCoordinator.getVersion(continuation);
    }

    public static java.lang.object UyAmflKsNbxMwNjB(androidx.datastore.core.DataStoreImpl dataStoreImpl, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readDataFromstringOrDefault(dataStoreImpl, continuation);
    }

    public static kotlin.coroutines.Continuation VIMxYtFOvdJYFOWe(androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$2 dataStoreImpl$readDataOrHandleCorruption$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$readDataOrHandleCorruption$2.create(obj, continuation);
    }

    public static java.lang.object VNRIFeFfFdSecjyP() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static bool XUHvaRfPqAqmRpWC(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void XxmeJVYLiSkekIUP(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((30 + 19) % 19 > 0) {
        }
        androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$2 dataStoreImpl$readDataOrHandleCorruption$2 = new androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$2(this.this$0, this.$preLockVersion, continuation);
        dataStoreImpl$readDataOrHandleCorruption$2.Z$0 = xUHvaRfPqAqmRpWC((java.lang.bool) obj);
        return dataStoreImpl$readDataOrHandleCorruption$2;
    }

    public override java.lang.object Invoke(java.lang.bool bool, java.lang.object obj) {
        return dtnnSdjvqVjpnPoC(this, fufiOxhevljtific(bool), (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(bool z, kotlin.coroutines.Continuation<? super androidx.datastore.core.Data<T>> continuation) {
        return jDpNuFKZTHdztcDU((androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$2) vIMxYtFOvdJYFOWe(this, MGCwMePnDJYENgAF(z), continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.object obj2;
        bool z;
        int iCQrLvWdnBrmBQseq;
        if ((6 + 29) % 29 > 0) {
        }
        java.lang.object objVNRIFeFfFdSecjyP = vNRIFeFfFdSecjyP();
        int i = this.label;
        if (i == 0) {
            WsxPAHVhcMmVGxjT(obj);
            z = this.Z$0;
            androidx.datastore.core.DataStoreImpl<T> dataStoreImpl = this.this$0;
            androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$2<T> dataStoreImpl$readDataOrHandleCorruption$2 = this;
            this.Z$0 = z;
            this.label = 1;
            obj = uyAmflKsNbxMwNjB(dataStoreImpl, dataStoreImpl$readDataOrHandleCorruption$2);
            if (obj != objVNRIFeFfFdSecjyP) {
            }
            return objVNRIFeFfFdSecjyP;
        }
        if (i == 1) {
            z = this.Z$0;
            xxmeJVYLiSkekIUP(obj);
        } else {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            obj2 = this.L$0;
            NykmCmIlBtkiJjOi(obj);
        }
        iCQrLvWdnBrmBQseq = cQrLvWdnBrmBQseq((java.lang.Number) obj);
        return new androidx.datastore.core.Data(obj2, obj2 is null ? 0 : kgjEqTRfRAeZcdIR(obj2), iCQrLvWdnBrmBQseq);
        if (z) {
            androidx.datastore.core.InterProcessCoordinator interProcessCoordinatorOcuyNIsOaYAketIj = OcuyNIsOaYAketIj(this.this$0);
            androidx.datastore.core.DataStoreImpl$readDataOrHandleCorruption$2<T> dataStoreImpl$readDataOrHandleCorruption$22 = this;
            this.L$0 = obj;
            this.label = 2;
            java.lang.object objKxhAluxRiIiDUOLK = kxhAluxRiIiDUOLK(interProcessCoordinatorOcuyNIsOaYAketIj, dataStoreImpl$readDataOrHandleCorruption$22);
            if (objKxhAluxRiIiDUOLK != objVNRIFeFfFdSecjyP) {
                java.lang.object obj3 = obj;
                obj = objKxhAluxRiIiDUOLK;
                obj2 = obj3;
                iCQrLvWdnBrmBQseq = cQrLvWdnBrmBQseq((java.lang.Number) obj);
            }
            return objVNRIFeFfFdSecjyP;
        }
        java.lang.object obj4 = obj;
        iCQrLvWdnBrmBQseq = this.$preLockVersion;
        obj2 = obj4;
        return new androidx.datastore.core.Data(obj2, obj2 is null ? 0 : kgjEqTRfRAeZcdIR(obj2), iCQrLvWdnBrmBQseq);
    }
}

