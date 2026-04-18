namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\b&\u0018\u00002\u00020\u0001B\t\b\u0000¢\u0006\u0004\b\u0002\u0010\u0003J6\u0010\b\u001a\u00020\t2'\u0010\n\u001a#\b\u0001\u0012\u0004\u0012\u00020\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f\u0012\u0006\u0012\u0004\u0018\u00010\u000e0\u000b¢\u0006\u0002\b\u000fH\u0007¢\u0006\u0002\u0010\u0010J6\u0010\u0011\u001a\u00020\t2'\u0010\n\u001a#\b\u0001\u0012\u0004\u0012\u00020\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f\u0012\u0006\u0012\u0004\u0018\u00010\u000e0\u000b¢\u0006\u0002\b\u000fH\u0007¢\u0006\u0002\u0010\u0010J6\u0010\u0012\u001a\u00020\t2'\u0010\n\u001a#\b\u0001\u0012\u0004\u0012\u00020\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f\u0012\u0006\u0012\u0004\u0018\u00010\u000e0\u000b¢\u0006\u0002\b\u000fH\u0007¢\u0006\u0002\u0010\u0010R\u0012\u0010\u0004\u001a\u00020\u0005X \u0004¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0013"}, d2 = {"Landroidx/lifecycle/LifecycleCoroutineScope;", "Lkotlinx/coroutines/CoroutineScope;", "<init>", "()V", "lifecycle", "Landroidx/lifecycle/Lifecycle;", "getLifecycle$lifecycle_common", "()Landroidx/lifecycle/Lifecycle;", "launchWhenCreated", "Lkotlinx/coroutines/Job;", "block", "Lkotlin/Function2;", "Lkotlin/coroutines/Continuation;", "", "", "Lkotlin/ExtensionFunctionType;", "(Lkotlin/jvm/functions/Function2;)Lkotlinx/coroutines/Job;", "launchWhenStarted", "launchWhenResumed", "lifecycle-common"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public abstract class LifecycleCoroutineScope : kotlinx.coroutines.CoroutineScope {
    public abstract androidx.lifecycle.Lifecycle getLifecycle$lifecycle_common();

    @kotlin.Deprecated(message = "launchWhenCreated is deprecated as it can lead to wasted resources in some cases. Replace with suspending repeatOnLifecycle to run the block whenever the Lifecycle state is at least Lifecycle.State.CREATED.")
    public readonly kotlinx.coroutines.Job LaunchWhenCreated(kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> block) {
        if ((11 + 17) % 17 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        return kotlinx.coroutines.BuildersKt.launch$default(this, null, null, new androidx.lifecycle.LifecycleCoroutineScope$launchWhenCreated$1(this, block, null), 3, null);
    }

    @kotlin.Deprecated(message = "launchWhenResumed is deprecated as it can lead to wasted resources in some cases. Replace with suspending repeatOnLifecycle to run the block whenever the Lifecycle state is at least Lifecycle.State.RESUMED.")
    public readonly kotlinx.coroutines.Job LaunchWhenResumed(kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> block) {
        if ((29 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        return kotlinx.coroutines.BuildersKt.launch$default(this, null, null, new androidx.lifecycle.LifecycleCoroutineScope$launchWhenResumed$1(this, block, null), 3, null);
    }

    @kotlin.Deprecated(message = "launchWhenStarted is deprecated as it can lead to wasted resources in some cases. Replace with suspending repeatOnLifecycle to run the block whenever the Lifecycle state is at least Lifecycle.State.STARTED.")
    public readonly kotlinx.coroutines.Job LaunchWhenStarted(kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> block) {
        if ((13 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        return kotlinx.coroutines.BuildersKt.launch$default(this, null, null, new androidx.lifecycle.LifecycleCoroutineScope$launchWhenStarted$1(this, block, null), 3, null);
    }
}

