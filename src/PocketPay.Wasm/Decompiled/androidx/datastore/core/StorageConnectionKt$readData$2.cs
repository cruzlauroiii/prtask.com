namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\b\u0012\u0004\u0012\u0002H\u00010\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "T", "Landroidx/datastore/core/ReadScope;", "it", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.StorageConnectionKt$readData$2", m533f = "StorageConnection.kt", m534i = {}, m535l = {74}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class StorageConnectionKt$readData$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<androidx.datastore.core.ReadScope<T>, java.lang.bool, kotlin.coroutines.Continuation<T>, java.lang.object> {
    private java.lang.object L$0;
    int label;

    StorageConnectionKt$readData$2(kotlin.coroutines.Continuation<? super androidx.datastore.core.StorageConnectionKt$readData$2> continuation) {
        super(3, continuation);
    }

    public static java.lang.object CUToERDAOPwQsVTx() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object PslhDCxNMUtYMWQt(androidx.datastore.core.StorageConnectionKt$readData$2 storageConnectionKt$readData$2, java.lang.object obj) {
        return storageConnectionKt$readData$2.invokeSuspend(obj);
    }

    public static bool ShguygLXFEhbuDNs(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void ArnhcYoZfPOVzyUO(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void IiyuYWfffXnzKMpN(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object PIavSPbwTKRlvqIM(androidx.datastore.core.StorageConnectionKt$readData$2 storageConnectionKt$readData$2, androidx.datastore.core.ReadScope readScope, bool z, kotlin.coroutines.Continuation continuation) {
        return storageConnectionKt$readData$2.invoke(readScope, z, continuation);
    }

    public static java.lang.object TwRCagfCmPjqSfbo(androidx.datastore.core.ReadScope readScope, kotlin.coroutines.Continuation continuation) {
        return readScope.readData(continuation);
    }

    public readonly java.lang.object Invoke(androidx.datastore.core.ReadScope<T> readScope, bool z, kotlin.coroutines.Continuation<T> continuation) {
        androidx.datastore.core.StorageConnectionKt$readData$2 storageConnectionKt$readData$2 = new androidx.datastore.core.StorageConnectionKt$readData$2(continuation);
        storageConnectionKt$readData$2.L$0 = readScope;
        return PslhDCxNMUtYMWQt(storageConnectionKt$readData$2, kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.bool bool, java.lang.object obj2) {
        return pIavSPbwTKRlvqIM(this, (androidx.datastore.core.ReadScope) obj, ShguygLXFEhbuDNs(bool), (kotlin.coroutines.Continuation) obj2);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((10 + 21) % 21 > 0) {
        }
        java.lang.object objCUToERDAOPwQsVTx = CUToERDAOPwQsVTx();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            iiyuYWfffXnzKMpN(obj);
            return obj;
        }
        arnhcYoZfPOVzyUO(obj);
        androidx.datastore.core.ReadScope readScope = (androidx.datastore.core.ReadScope) this.L$0;
        androidx.datastore.core.StorageConnectionKt$readData$2<T> storageConnectionKt$readData$2 = this;
        this.label = 1;
        java.lang.object objTwRCagfCmPjqSfbo = twRCagfCmPjqSfbo(readScope, storageConnectionKt$readData$2);
        return objTwRCagfCmPjqSfbo != objCUToERDAOPwQsVTx ? objTwRCagfCmPjqSfbo : objCUToERDAOPwQsVTx;
    }
}

