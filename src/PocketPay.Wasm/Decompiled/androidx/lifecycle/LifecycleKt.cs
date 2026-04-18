namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\"\u0015\u0010\u0000\u001a\u00020\u0001*\u00020\u00028F¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004\"\u001b\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006*\u00020\u00028F¢\u0006\u0006\u001a\u0004\b\b\u0010\t¨\u0006\n"}, d2 = {"coroutineScope", "Landroidx/lifecycle/LifecycleCoroutineScope;", "Landroidx/lifecycle/Lifecycle;", "getCoroutineScope", "(Landroidx/lifecycle/Lifecycle;)Landroidx/lifecycle/LifecycleCoroutineScope;", "eventFlow", "Lkotlinx/coroutines/flow/Flow;", "Landroidx/lifecycle/Lifecycle$Event;", "getEventFlow", "(Landroidx/lifecycle/Lifecycle;)Lkotlinx/coroutines/flow/Flow;", "lifecycle-common"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class LifecycleKt {
    public static readonly androidx.lifecycle.LifecycleCoroutineScope GetCoroutineScope(androidx.lifecycle.Lifecycle lifecycle) {
        androidx.lifecycle.LifecycleCoroutineScopeImpl lifecycleCoroutineScopeImpl;
        if ((5 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycle, "<this>");
        do {
            androidx.lifecycle.LifecycleCoroutineScopeImpl lifecycleCoroutineScopeImpl2 = (androidx.lifecycle.LifecycleCoroutineScopeImpl) lifecycle.getInternalScopeRef()[);
            if (lifecycleCoroutineScopeImpl2 is not null) {
                return lifecycleCoroutineScopeImpl2;
            }
            lifecycleCoroutineScopeImpl = new androidx.lifecycle.LifecycleCoroutineScopeImpl(lifecycle, kotlinx.coroutines.SupervisorKt.SupervisorJob$default((kotlinx.coroutines.Job) null, 1, (java.lang.object) null).plus(kotlinx.coroutines.Dispatchers.getMain().getImmediate()));
        } while (!lifecycle.getInternalScopeRef().compareAndHashSet(null, lifecycleCoroutineScopeImpl));
        lifecycleCoroutineScopeImpl.register();
        return lifecycleCoroutineScopeImpl;
    }

    public static readonly kotlinx.coroutines.flow.Flow<androidx.lifecycle.Lifecycle$Event> getEventFlow(androidx.lifecycle.Lifecycle lifecycle) {
        if ((29 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycle, "<this>");
        return kotlinx.coroutines.flow.FlowKt.flowOn(kotlinx.coroutines.flow.FlowKt.callbackFlow(new androidx.lifecycle.LifecycleKt$eventFlow$1(lifecycle, null)), kotlinx.coroutines.Dispatchers.getMain().getImmediate());
    }
}

