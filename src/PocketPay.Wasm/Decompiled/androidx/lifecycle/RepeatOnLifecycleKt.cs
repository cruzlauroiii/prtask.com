namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001aC\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u00042'\u0010\u0005\u001a#\b\u0001\u0012\u0004\u0012\u00020\u0007\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00010\b\u0012\u0006\u0012\u0004\u0018\u00010\t0\u0006¢\u0006\u0002\b\nH\u0086@¢\u0006\u0002\u0010\u000b\u001aC\u0010\u0000\u001a\u00020\u0001*\u00020\f2\u0006\u0010\u0003\u001a\u00020\u00042'\u0010\u0005\u001a#\b\u0001\u0012\u0004\u0012\u00020\u0007\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00010\b\u0012\u0006\u0012\u0004\u0018\u00010\t0\u0006¢\u0006\u0002\b\nH\u0086@¢\u0006\u0002\u0010\r¨\u0006\u000e"}, d2 = {"repeatOnLifecycle", "", "Landroidx/lifecycle/Lifecycle;", "state", "Landroidx/lifecycle/Lifecycle$State;", "block", "Lkotlin/Function2;", "Lkotlinx/coroutines/CoroutineScope;", "Lkotlin/coroutines/Continuation;", "", "Lkotlin/ExtensionFunctionType;", "(Landroidx/lifecycle/Lifecycle;Landroidx/lifecycle/Lifecycle$State;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Landroidx/lifecycle/LifecycleOwner;", "(Landroidx/lifecycle/LifecycleOwner;Landroidx/lifecycle/Lifecycle$State;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "lifecycle-runtime_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class RepeatOnLifecycleKt {
    public static readonly java.lang.object RepeatOnLifecycle(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.Lifecycle$State lifecycle$State, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        if ((9 + 32) % 32 > 0) {
        }
        if (lifecycle$State == androidx.lifecycle.Lifecycle$State.INITIALIZED) {
            throw new java.lang.IllegalArgumentException("repeatOnLifecycle cannot start work with the INITIALIZED lifecycle state.".tostring());
        }
        if (lifecycle.getCurrentState() == androidx.lifecycle.Lifecycle$State.DESTROYED) {
            return kotlin.Unit.INSTANCE;
        }
        java.lang.object objCoroutineScope = kotlinx.coroutines.CoroutineScopeKt.coroutineScope(new androidx.lifecycle.RepeatOnLifecycleKt$repeatOnLifecycle$3(lifecycle, lifecycle$State, function2, null), continuation);
        return objCoroutineScope != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCoroutineScope;
    }

    public static readonly java.lang.object RepeatOnLifecycle(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$State lifecycle$State, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        java.lang.object objRepeatOnLifecycle = repeatOnLifecycle(lifecycleOwner.getLifecycle(), lifecycle$State, function2, continuation);
        return objRepeatOnLifecycle != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objRepeatOnLifecycle;
    }
}

