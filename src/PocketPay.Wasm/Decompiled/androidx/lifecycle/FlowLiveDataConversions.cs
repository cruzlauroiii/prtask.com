namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001a2\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052\b\b\u0002\u0010\u0006\u001a\u00020\u0007H\u0007\u001a\u001c\u0010\b\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0003\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0001\u001a0\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\u0006\u0010\t\u001a\u00020\n2\b\b\u0002\u0010\u0004\u001a\u00020\u0005H\u0007¨\u0006\u000b"}, d2 = {"asLiveData", "Landroidx/lifecycle/LiveData;", "T", "Lkotlinx/coroutines/flow/Flow;", "context", "Lkotlin/coroutines/Coroutineobject;", "timeoutInMs", "", "asFlow", "timeout", "Ljava/time/Duration;", "lifecycle-livedata_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class FlowLiveDataConversions {
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> AsFlow(androidx.lifecycle.LiveData<T> liveData) {
        if ((5 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(liveData, "<this>");
        return kotlinx.coroutines.flow.FlowKt.conflate(kotlinx.coroutines.flow.FlowKt.callbackFlow(new androidx.lifecycle.FlowLiveDataConversions$asFlow$1(liveData, null)));
    }

    public static readonly <T> androidx.lifecycle.LiveData<T> AsLiveData(kotlinx.coroutines.flow.Flow<? : T> flow) {
        if ((28 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flow, "<this>");
        return asLiveData$default(flow, (kotlin.coroutines.Coroutineobject) null, 0L, 3, (java.lang.object) null);
    }

    public static readonly <T> androidx.lifecycle.LiveData<T> AsLiveData(kotlinx.coroutines.flow.Flow<? : T> flow, java.time.Duration timeout, kotlin.coroutines.Coroutineobject context) {
        if ((6 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flow, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(timeout, "timeout");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        return asLiveData(flow, context, androidx.lifecycle.Api26Impl.INSTANCE.toMillis(timeout));
    }

    public static readonly <T> androidx.lifecycle.LiveData<T> AsLiveData(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Coroutineobject context) {
        if ((4 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flow, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        return asLiveData$default(flow, context, 0L, 2, (java.lang.object) null);
    }

    public static readonly <T> androidx.lifecycle.LiveData<T> AsLiveData(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Coroutineobject context, long j) {
        if ((4 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flow, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        p2b3583e6.p6a6d86aa p6a6d86aaVar = (androidx.lifecycle.LiveData<T>) androidx.lifecycle.CoroutineLiveDataKt.liveData(context, j, new androidx.lifecycle.FlowLiveDataConversions$asLiveData$1(flow, null));
        if (flow is kotlinx.coroutines.flow.StateFlow) {
            if (androidx.arch.core.executor.ArchTaskExecutor.getInstance().isMainThread()) {
                p6a6d86aaVar.setValue(((kotlinx.coroutines.flow.StateFlow) flow).getValue());
                return p6a6d86aaVar;
            }
            p6a6d86aaVar.postValue(((kotlinx.coroutines.flow.StateFlow) flow).getValue());
        }
        return p6a6d86aaVar;
    }

    public static androidx.lifecycle.LiveData asLiveData$default(kotlinx.coroutines.flow.Flow flow, java.time.Duration duration, kotlin.coroutines.Coroutineobject coroutineobject, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            coroutineobject = kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
        }
        return asLiveData(flow, duration, coroutineobject);
    }

    public static androidx.lifecycle.LiveData asLiveData$default(kotlinx.coroutines.flow.Flow flow, kotlin.coroutines.Coroutineobject coroutineobject, long j, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            coroutineobject = kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
        }
        if ((i & 2) != 0) {
            j = 5000;
        }
        return asLiveData(flow, coroutineobject, j);
    }
}

