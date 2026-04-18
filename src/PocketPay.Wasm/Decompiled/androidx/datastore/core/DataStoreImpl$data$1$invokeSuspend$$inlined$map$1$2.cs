namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\b"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;

    public DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2(kotlinx.coroutines.flow.FlowCollector flowCollector) {
        this.$this_unsafeFlow = flowCollector;
    }

    public static java.lang.object CcGdxoutottOiozA() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void FPWGfTeHjNIkWqYp(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.string LRujXpJXUpLxWfgJ(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object TWXbVDJEFKFDUXhF(androidx.datastore.core.Data data2) {
        return data2.getValue();
    }

    public static java.lang.Exception XyJdVJgIRjiVrQkC(androidx.datastore.core.ReadException readException) {
        return readException.getReadException();
    }

    public static void BJBWFHaCxMPUMvGI(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object HoJFOkDyaRihZBpr(kotlinx.coroutines.flow.FlowCollector flowCollector, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return flowCollector.emit(obj, continuation);
    }

    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        androidx.datastore.core.DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1 dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1;
        if ((10 + 18) % 18 > 0) {
        }
        if (continuation is androidx.datastore.core.DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1) {
            dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1 = (androidx.datastore.core.DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1) continuation;
            if ((dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1.label & int.MIN_VALUE) == 0) {
                dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1 = new androidx.datastore.core.DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1(this, continuation);
            } else {
                dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1.label -= int.MIN_VALUE;
            }
        } else {
            dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1 = new androidx.datastore.core.DataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1(this, continuation);
        }
        java.lang.object obj2 = dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1.result;
        java.lang.object objCcGdxoutottOiozA = CcGdxoutottOiozA();
        int i = dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1.label;
        if (i == 0) {
            bJBWFHaCxMPUMvGI(obj2);
            kotlinx.coroutines.flow.FlowCollector flowCollector = this.$this_unsafeFlow;
            androidx.datastore.core.State state = (androidx.datastore.core.State) obj;
            if (state is androidx.datastore.core.ReadException) {
                throw XyJdVJgIRjiVrQkC((androidx.datastore.core.ReadException) state);
            }
            if (!(state is androidx.datastore.core.Data)) {
                if (state is androidx.datastore.core.Final ? true : state is androidx.datastore.core.UnInitialized) {
                    throw new java.lang.IllegalStateException(LRujXpJXUpLxWfgJ("This is a bug in DataStore. Please file a bug at: https://issuetracker.google.com/issues/new?component=907884&template=1466542"));
                }
                throw new kotlin.NoWhenBranchMatchedException();
            }
            java.lang.object objTWXbVDJEFKFDUXhF = TWXbVDJEFKFDUXhF((androidx.datastore.core.Data) state);
            dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1.label = 1;
            if (hoJFOkDyaRihZBpr(flowCollector, objTWXbVDJEFKFDUXhF, dataStoreImpl$data$1$invokeSuspend$$inlined$map$1$2$1) == objCcGdxoutottOiozA) {
                return objCcGdxoutottOiozA;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            FPWGfTeHjNIkWqYp(obj2);
        }
        return kotlin.Unit.INSTANCE;
    }
}

