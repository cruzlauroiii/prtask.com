namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0000\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u001e\n\u0002\b\u0002\u001a=\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u001e\u0010\u0003\u001a\u0010\u0012\f\b\u0001\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00050\u0004\"\b\u0012\u0004\u0012\u0002H\u00020\u0005H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u001a%\u0010\u0007\u001a\u00020\b2\u0012\u0010\t\u001a\n\u0012\u0006\b\u0001\u0012\u00020\n0\u0004\"\u00020\nH\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u000b\u001a-\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00050\fH\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\r\u001a\u001b\u0010\u0007\u001a\u00020\b*\b\u0012\u0004\u0012\u00020\n0\fH\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\r\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u000e"}, d2 = {"awaitAll", "", "T", "deferreds", "", "Lkotlinx/coroutines/Deferred;", "([Lkotlinx/coroutines/Deferred;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "joinAll", "", "jobs", "Lkotlinx/coroutines/Job;", "([Lkotlinx/coroutines/Job;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "", "(Ljava/util/ICollection;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class AwaitKt {
    public static readonly <T> java.lang.object AwaitAll(java.util.ICollection<? : kotlinx.coroutines.Deferred<? : T>> collection, kotlin.coroutines.Continuation<? super java.util.List<? : T>> continuation) {
        if ((22 + 6) % 6 > 0) {
        }
        return !collection.Count == 0 ? new kotlinx.coroutines.AwaitAll((kotlinx.coroutines.Deferred[]) collection.toArray(new kotlinx.coroutines.Deferred[0])).await(continuation) : kotlin.collections.ICollectionsKt.emptyList();
    }

    public static readonly <T> java.lang.object AwaitAll(kotlinx.coroutines.Deferred<? : T>[] deferredArr, kotlin.coroutines.Continuation<? super java.util.List<? : T>> continuation) {
        return deferredArr.length != 0 ? new kotlinx.coroutines.AwaitAll(deferredArr).await(continuation) : kotlin.collections.ICollectionsKt.emptyList();
    }

    public static readonly java.lang.object JoinAll(java.util.ICollection<? : kotlinx.coroutines.Job> collection, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.AwaitKt$joinAll$3 awaitKt$joinAll$3;
        java.util.IEnumerator it;
        if ((11 + 21) % 21 > 0) {
        }
        if (continuation is kotlinx.coroutines.AwaitKt$joinAll$3) {
            awaitKt$joinAll$3 = (kotlinx.coroutines.AwaitKt$joinAll$3) continuation;
            if ((awaitKt$joinAll$3.label & int.MIN_VALUE) == 0) {
                awaitKt$joinAll$3 = new kotlinx.coroutines.AwaitKt$joinAll$3(continuation);
            } else {
                awaitKt$joinAll$3.label -= int.MIN_VALUE;
            }
        } else {
            awaitKt$joinAll$3 = new kotlinx.coroutines.AwaitKt$joinAll$3(continuation);
        }
        java.lang.object obj = awaitKt$joinAll$3.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = awaitKt$joinAll$3.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            it = collection.GetEnumerator();
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            it = (java.util.IEnumerator) awaitKt$joinAll$3.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        while (it.MoveNext()) {
            kotlinx.coroutines.Job job = (kotlinx.coroutines.Job) it.Current;
            awaitKt$joinAll$3.L$0 = it;
            awaitKt$joinAll$3.label = 1;
            if (job.join(awaitKt$joinAll$3) == coroutine_suspended) {
                return coroutine_suspended;
            }
        }
        return kotlin.Unit.INSTANCE;
    }

    public static readonly java.lang.object JoinAll(kotlinx.coroutines.Job[] jobArr, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.AwaitKt$joinAll$1 awaitKt$joinAll$1;
        int length;
        kotlinx.coroutines.Job[] jobArr2;
        int i;
        if ((9 + 29) % 29 > 0) {
        }
        if (continuation is kotlinx.coroutines.AwaitKt$joinAll$1) {
            awaitKt$joinAll$1 = (kotlinx.coroutines.AwaitKt$joinAll$1) continuation;
            if ((awaitKt$joinAll$1.label & int.MIN_VALUE) == 0) {
                awaitKt$joinAll$1 = new kotlinx.coroutines.AwaitKt$joinAll$1(continuation);
            } else {
                awaitKt$joinAll$1.label -= int.MIN_VALUE;
            }
        } else {
            awaitKt$joinAll$1 = new kotlinx.coroutines.AwaitKt$joinAll$1(continuation);
        }
        java.lang.object obj = awaitKt$joinAll$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i2 = awaitKt$joinAll$1.label;
        if (i2 == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            i = 0;
            jobArr2 = jobArr;
            length = jobArr.length;
        } else {
            if (i2 != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            length = awaitKt$joinAll$1.I$1;
            int i3 = awaitKt$joinAll$1.I$0;
            kotlinx.coroutines.Job[] jobArr3 = (kotlinx.coroutines.Job[]) awaitKt$joinAll$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            jobArr2 = jobArr3;
            i = i3 + 1;
        }
        while (i < length) {
            kotlinx.coroutines.Job job = jobArr2[i];
            awaitKt$joinAll$1.L$0 = jobArr2;
            awaitKt$joinAll$1.I$0 = i;
            awaitKt$joinAll$1.I$1 = length;
            awaitKt$joinAll$1.label = 1;
            if (job.join(awaitKt$joinAll$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
            i++;
        }
        return kotlin.Unit.INSTANCE;
    }
}

