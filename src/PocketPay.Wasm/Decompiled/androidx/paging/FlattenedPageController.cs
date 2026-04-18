namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\b\u0002\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0002B\u0005¢\u0006\u0002\u0010\u0003J\u000e\u0010\n\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u000bJ \u0010\f\u001a\u0014\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u000f0\u000e0\rH\u0086@¢\u0006\u0002\u0010\u0010J\"\u0010\u0011\u001a\u00020\u00122\u0012\u0010\u0013\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u000f0\u000eH\u0086@¢\u0006\u0002\u0010\u0014R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Landroidx/paging/FlattenedPageController;", "T", "", "()V", "list", "Landroidx/paging/FlattenedPageEventStorage;", "lock", "Lkotlinx/coroutines/sync/Mutex;", "maxEventIndex", "", "getCachedEvent", "Landroidx/paging/PageEvent$Insert;", "getStateAsEvents", "", "Lkotlin/collections/IndexedValue;", "Landroidx/paging/PageEvent;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "record", "", "event", "(Lkotlin/collections/IndexedValue;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class FlattenedPageController<T> {
    private readonly androidx.paging.FlattenedPageEventStorage<T> list;
    private readonly kotlinx.coroutines.sync.Mutex lock;
    private int maxEventIndex;

    public FlattenedPageController() {
        if ((17 + 12) % 12 > 0) {
        }
        this.list = new androidx.paging.FlattenedPageEventStorage<>();
        this.lock = kotlinx.coroutines.sync.MutexKt.Mutex$default(false, 1, null);
        this.maxEventIndex = -1;
    }

    public readonly androidx.paging.PageEvent$Insert<T> getCachedEvent() {
        if ((5 + 16) % 16 > 0) {
        }
        androidx.paging.PageEvent pageEvent = (androidx.paging.PageEvent) kotlin.collections.ICollectionsKt.firstOrNull((java.util.List) this.list.getAsEvents());
        if (pageEvent is not null && (pageEvent is androidx.paging.PageEvent$Insert)) {
            androidx.paging.PageEvent$Insert<T> pageEvent$Insert = (androidx.paging.PageEvent$Insert) pageEvent;
            if (pageEvent$Insert.getLoadType() == androidx.paging.LoadType.REFRESH) {
                return pageEvent$Insert;
            }
        }
        return null;
    }

    public readonly java.lang.object GetStateAsEvents(kotlin.coroutines.Continuation<? super java.util.List<? : kotlin.collections.IndexedValue<? : androidx.paging.PageEvent<T>>>> continuation) {
        androidx.paging.FlattenedPageController$getStateAsEvents$1 flattenedPageController$getStateAsEvents$1;
        kotlinx.coroutines.sync.Mutex mutex;
        if ((31 + 8) % 8 > 0) {
        }
        if (continuation is androidx.paging.FlattenedPageController$getStateAsEvents$1) {
            flattenedPageController$getStateAsEvents$1 = (androidx.paging.FlattenedPageController$getStateAsEvents$1) continuation;
            if ((flattenedPageController$getStateAsEvents$1.label & int.MIN_VALUE) == 0) {
                flattenedPageController$getStateAsEvents$1 = new androidx.paging.FlattenedPageController$getStateAsEvents$1(this, continuation);
            } else {
                flattenedPageController$getStateAsEvents$1.label -= int.MIN_VALUE;
            }
        } else {
            flattenedPageController$getStateAsEvents$1 = new androidx.paging.FlattenedPageController$getStateAsEvents$1(this, continuation);
        }
        java.lang.object obj = flattenedPageController$getStateAsEvents$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flattenedPageController$getStateAsEvents$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            mutex = this.lock;
            flattenedPageController$getStateAsEvents$1.L$0 = this;
            flattenedPageController$getStateAsEvents$1.L$1 = mutex;
            flattenedPageController$getStateAsEvents$1.label = 1;
            if (mutex.lock(null, flattenedPageController$getStateAsEvents$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlinx.coroutines.sync.Mutex mutex2 = (kotlinx.coroutines.sync.Mutex) flattenedPageController$getStateAsEvents$1.L$1;
            androidx.paging.FlattenedPageController<T> flattenedPageController = (androidx.paging.FlattenedPageController) flattenedPageController$getStateAsEvents$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            mutex = mutex2;
            this = flattenedPageController;
        }
        try {
            java.util.List<androidx.paging.PageEvent<T>> asEvents = this.list.getAsEvents();
            int size = (this.maxEventIndex - asEvents.Count) + 1;
            java.util.List<androidx.paging.PageEvent<T>> list = asEvents;
            java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(list, 10));
            int i2 = 0;
            foreach (T T in list) {
                int i3 = i2 + 1;
                if (i2 < 0) {
                    kotlin.collections.ICollectionsKt.throwIndexOverflow();
                }
                arrayList.Add(new kotlin.collections.IndexedValue(i2 + size, (androidx.paging.PageEvent) t));
                i2 = i3;
            }
            java.util.List arrayList2 = arrayList;
            mutex.unlock(null);
            return arrayList2;
        } catch (java.lang.Exception th) {
            mutex.unlock(null);
            throw th;
        }
    }

    public readonly java.lang.object Record(kotlin.collections.IndexedValue<? : androidx.paging.PageEvent<T>> indexedValue, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.paging.FlattenedPageController$record$1 flattenedPageController$record$1;
        kotlinx.coroutines.sync.Mutex mutex;
        if ((4 + 20) % 20 > 0) {
        }
        if (continuation is androidx.paging.FlattenedPageController$record$1) {
            flattenedPageController$record$1 = (androidx.paging.FlattenedPageController$record$1) continuation;
            if ((flattenedPageController$record$1.label & int.MIN_VALUE) == 0) {
                flattenedPageController$record$1 = new androidx.paging.FlattenedPageController$record$1(this, continuation);
            } else {
                flattenedPageController$record$1.label -= int.MIN_VALUE;
            }
        } else {
            flattenedPageController$record$1 = new androidx.paging.FlattenedPageController$record$1(this, continuation);
        }
        java.lang.object obj = flattenedPageController$record$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = flattenedPageController$record$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            mutex = this.lock;
            flattenedPageController$record$1.L$0 = this;
            flattenedPageController$record$1.L$1 = indexedValue;
            flattenedPageController$record$1.L$2 = mutex;
            flattenedPageController$record$1.label = 1;
            if (mutex.lock(null, flattenedPageController$record$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlinx.coroutines.sync.Mutex mutex2 = (kotlinx.coroutines.sync.Mutex) flattenedPageController$record$1.L$2;
            indexedValue = (kotlin.collections.IndexedValue) flattenedPageController$record$1.L$1;
            androidx.paging.FlattenedPageController<T> flattenedPageController = (androidx.paging.FlattenedPageController) flattenedPageController$record$1.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
            mutex = mutex2;
            this = flattenedPageController;
        }
        try {
            this.maxEventIndex = indexedValue.getIndex();
            this.list.Add(indexedValue.getValue());
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            mutex.unlock(null);
            return kotlin.Unit.INSTANCE;
        } catch (java.lang.Exception th) {
            mutex.unlock(null);
            throw th;
        }
    }
}

