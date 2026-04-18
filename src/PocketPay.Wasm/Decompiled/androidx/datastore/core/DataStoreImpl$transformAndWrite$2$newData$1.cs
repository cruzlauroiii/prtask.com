namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.DataStoreImpl$transformAndWrite$2$newData$1", m533f = "DataStoreImpl.kt", m534i = {}, m535l = {331}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class DataStoreImpl$transformAndWrite$2$newData$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<T>, java.lang.object> {
    readonly androidx.datastore.core.Data<T> $curData;
    readonly kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<T>, java.lang.object> $transform;
    int label;

    DataStoreImpl$transformAndWrite$2$newData$1(kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2, androidx.datastore.core.Data<T> data2, kotlin.coroutines.Continuation<? super androidx.datastore.core.DataStoreImpl$transformAndWrite$2$newData$1> continuation) {
        super(2, continuation);
        this.$transform = function2;
        this.$curData = data2;
    }

    public static void EOTkVodtngYDZAja(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object GSaqHXkvcvuggloJ() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object PCuDGCDYavKMWrEh(androidx.datastore.core.DataStoreImpl$transformAndWrite$2$newData$1 dataStoreImpl$transformAndWrite$2$newData$1, java.lang.object obj) {
        return dataStoreImpl$transformAndWrite$2$newData$1.invokeSuspend(obj);
    }

    public static void QLuxxVXbASqfxHqE(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation SicUtKIyBgVQRNFu(androidx.datastore.core.DataStoreImpl$transformAndWrite$2$newData$1 dataStoreImpl$transformAndWrite$2$newData$1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$transformAndWrite$2$newData$1.create(obj, continuation);
    }

    public static java.lang.object TPVCFaaEZtElvoKA(androidx.datastore.core.Data data2) {
        return data2.getValue();
    }

    public static java.lang.object CQmZnhcbIAOCrzWT(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static java.lang.object TGbWrSuvcfpikvib(androidx.datastore.core.DataStoreImpl$transformAndWrite$2$newData$1 dataStoreImpl$transformAndWrite$2$newData$1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return dataStoreImpl$transformAndWrite$2$newData$1.invoke(coroutineScope, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.core.DataStoreImpl$transformAndWrite$2$newData$1(this.$transform, this.$curData, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj) {
        return tGbWrSuvcfpikvib(this, coroutineScope, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<T> continuation) {
        return PCuDGCDYavKMWrEh((androidx.datastore.core.DataStoreImpl$transformAndWrite$2$newData$1) SicUtKIyBgVQRNFu(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((26 + 1) % 1 > 0) {
        }
        java.lang.object objGSaqHXkvcvuggloJ = GSaqHXkvcvuggloJ();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            QLuxxVXbASqfxHqE(obj);
            return obj;
        }
        EOTkVodtngYDZAja(obj);
        kotlin.jvm.functions.Function2<T, kotlin.coroutines.Continuation<T>, java.lang.object> function2 = this.$transform;
        java.lang.object objTPVCFaaEZtElvoKA = TPVCFaaEZtElvoKA(this.$curData);
        this.label = 1;
        java.lang.object objCQmZnhcbIAOCrzWT = cQmZnhcbIAOCrzWT(function2, objTPVCFaaEZtElvoKA, this);
        return objCQmZnhcbIAOCrzWT != objGSaqHXkvcvuggloJ ? objCQmZnhcbIAOCrzWT : objGSaqHXkvcvuggloJ;
    }
}

