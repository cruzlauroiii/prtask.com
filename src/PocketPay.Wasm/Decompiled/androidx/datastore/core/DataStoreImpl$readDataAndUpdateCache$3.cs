namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\u0010\u0000\u001a\u0014\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00030\u0002\u0012\u0004\u0012\u00020\u00040\u0001\"\u0004\b\u0000\u0010\u0003H\u008a@"}, d2 = {"<anonymous>", "Lkotlin/ValueTuple;", "Landroidx/datastore/core/State;", "T", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$3", m533f = "DataStoreImpl.kt", m534i = {}, m535l = {298, 300}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataStoreImpl$readDataAndUpdateCache$3<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function1<kotlin.coroutines.Continuation<? super kotlin.ValueTuple<? : androidx.datastore.core.State<T>, ? : java.lang.bool>>, java.lang.object> {
    java.lang.object L$0;
    int label;
    readonly androidx.datastore.core.DataStoreImpl<T> this$0;

    DataStoreImpl$readDataAndUpdateCache$3(androidx.datastore.core.DataStoreImpl<T> dataStoreImpl, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$3> continuation) {
        super(1, continuation);
        this.this$0 = dataStoreImpl;
    }

    public static void DOFQCJKqdWKEIsfM(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation GusCeleJXCgCZvHL(androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$3 dataStoreImpl$readDataAndUpdateCache$3, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$readDataAndUpdateCache$3.create(continuation);
    }

    public static void IGMxalinoxUtYqer(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object LDnknRfynaCHFYQb() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.bool QbdjimGexbVzQPQw(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public static java.lang.object QuLYCTMBLgjkbssX(androidx.datastore.core.DataStoreImpl dataStoreImpl, bool z, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.core.DataStoreImpl.access$readDataOrHandleCorruption(dataStoreImpl, z, continuation);
    }

    public static int WfqBJqGXMxFYkqYF(java.lang.Number number) {
        return number.intValue();
    }

    public static java.lang.object YkCmYsOlRqvFEzYA(androidx.datastore.core.InterProcessCoordinator interProcessCoordinator, kotlin.coroutines.Continuation continuation) {
        return interProcessCoordinator.getVersion(continuation);
    }

    public static java.lang.object ELiCTfUfbKZtPYUy(androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$3 dataStoreImpl$readDataAndUpdateCache$3, java.lang.object obj) {
        return dataStoreImpl$readDataAndUpdateCache$3.invokeSuspend(obj);
    }

    public static kotlin.ValueTuple GMJYiDJCkPrICHkB(java.lang.object obj, java.lang.object obj2) {
        return kotlin.TuplesKt.to(obj, obj2);
    }

    public static androidx.datastore.core.InterProcessCoordinator KMmqGxQmGPfxzknf(androidx.datastore.core.DataStoreImpl dataStoreImpl) {
        return androidx.datastore.core.DataStoreImpl.access$getCoordinator(dataStoreImpl);
    }

    public static java.lang.object QdPsVEQjTAlDEoSt(androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$3 dataStoreImpl$readDataAndUpdateCache$3, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$readDataAndUpdateCache$3.invoke(continuation);
    }

    public static void WLpLSnaAItSvIYJu(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$3(this.this$0, continuation);
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        return qdPsVEQjTAlDEoSt(this, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlin.coroutines.Continuation<? super kotlin.ValueTuple<? : androidx.datastore.core.State<T>, java.lang.bool>> continuation) {
        return eLiCTfUfbKZtPYUy((androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$3) GusCeleJXCgCZvHL(this, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.Exception th;
        androidx.datastore.core.ReadException readException;
        if ((9 + 10) % 10 > 0) {
        }
        java.lang.object objLDnknRfynaCHFYQb = LDnknRfynaCHFYQb();
        int i = this.label;
        try {
            readException = (androidx.datastore.core.State) obj;
        } catch (java.lang.Exception th2) {
            androidx.datastore.core.InterProcessCoordinator interProcessCoordinatorKMmqGxQmGPfxzknf = kMmqGxQmGPfxzknf(this.this$0);
            androidx.datastore.core.DataStoreImpl$readDataAndUpdateCache$3<T> dataStoreImpl$readDataAndUpdateCache$3 = this;
            this.L$0 = th2;
            this.label = 2;
            java.lang.object objYkCmYsOlRqvFEzYA = YkCmYsOlRqvFEzYA(interProcessCoordinatorKMmqGxQmGPfxzknf, dataStoreImpl$readDataAndUpdateCache$3);
            if (objYkCmYsOlRqvFEzYA != objLDnknRfynaCHFYQb) {
                obj = objYkCmYsOlRqvFEzYA;
                th = th2;
                readException = new androidx.datastore.core.ReadException(th, WfqBJqGXMxFYkqYF((java.lang.Number) obj));
            }
        }
        if (i == 0) {
            DOFQCJKqdWKEIsfM(obj);
            this.label = 1;
            obj = QuLYCTMBLgjkbssX(this.this$0, true, this);
            if (obj == objLDnknRfynaCHFYQb) {
                return objLDnknRfynaCHFYQb;
            }
        } else {
            if (i != 1) {
                if (i != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                th = (java.lang.Exception) this.L$0;
                wLpLSnaAItSvIYJu(obj);
                readException = new androidx.datastore.core.ReadException(th, WfqBJqGXMxFYkqYF((java.lang.Number) obj));
                return gMJYiDJCkPrICHkB(readException, QbdjimGexbVzQPQw(true));
            }
            IGMxalinoxUtYqer(obj);
        }
        return gMJYiDJCkPrICHkB(readException, QbdjimGexbVzQPQw(true));
    }
}

