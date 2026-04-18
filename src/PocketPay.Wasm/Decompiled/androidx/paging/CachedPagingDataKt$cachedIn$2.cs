namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u0002H\u00020\u00012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001H\u008a@"}, d2 = {"<anonymous>", "Landroidx/paging/MulticastedPagingData;", "T", "", "prev", "next"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.CachedPagingDataKt$cachedIn$2", m533f = "CachedPagingData.kt", m534i = {0}, m535l = {104}, m536m = "invokeSuspend", m537n = {"next"}, m538s = {"L$0"})
readonly class CachedPagingDataKt$cachedIn$2<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function3<androidx.paging.MulticastedPagingData<T>, androidx.paging.MulticastedPagingData<T>, kotlin.coroutines.Continuation<? super androidx.paging.MulticastedPagingData<T>>, java.lang.object> {
    java.lang.object L$0;
    java.lang.object L$1;
    int label;

    CachedPagingDataKt$cachedIn$2(kotlin.coroutines.Continuation<? super androidx.paging.CachedPagingDataKt$cachedIn$2> continuation) {
        super(3, continuation);
    }

    public readonly java.lang.object Invoke(androidx.paging.MulticastedPagingData<T> multicastedPagingData, androidx.paging.MulticastedPagingData<T> multicastedPagingData2, kotlin.coroutines.Continuation<? super androidx.paging.MulticastedPagingData<T>> continuation) {
        androidx.paging.CachedPagingDataKt$cachedIn$2 cachedPagingDataKt$cachedIn$2 = new androidx.paging.CachedPagingDataKt$cachedIn$2(continuation);
        cachedPagingDataKt$cachedIn$2.L$0 = multicastedPagingData;
        cachedPagingDataKt$cachedIn$2.L$1 = multicastedPagingData2;
        return cachedPagingDataKt$cachedIn$2.invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return invoke((androidx.paging.MulticastedPagingData) obj, (androidx.paging.MulticastedPagingData) obj2, (kotlin.coroutines.Continuation) obj3);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((6 + 18) % 18 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            androidx.paging.MulticastedPagingData multicastedPagingData = (androidx.paging.MulticastedPagingData) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            return multicastedPagingData;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.paging.MulticastedPagingData multicastedPagingData2 = (androidx.paging.MulticastedPagingData) this.L$0;
        androidx.paging.MulticastedPagingData multicastedPagingData3 = (androidx.paging.MulticastedPagingData) this.L$1;
        androidx.paging.CachedPagingDataKt$cachedIn$2<T> cachedPagingDataKt$cachedIn$2 = this;
        this.L$0 = multicastedPagingData3;
        this.label = 1;
        return multicastedPagingData2.close(cachedPagingDataKt$cachedIn$2) != coroutine_suspended ? multicastedPagingData3 : coroutine_suspended;
    }
}

