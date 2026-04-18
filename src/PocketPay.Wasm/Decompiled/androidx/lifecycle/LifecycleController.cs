namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\b\u0001\u0018\u00002\u00020\u0001B'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0004\b\n\u0010\u000bJ\u0011\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\b\u001a\u00020\tH\u0082\bJ\b\u0010\u0010\u001a\u00020\u000fH\u0007R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Landroidx/lifecycle/LifecycleController;", "", "lifecycle", "Landroidx/lifecycle/Lifecycle;", "minState", "Landroidx/lifecycle/Lifecycle$State;", "dispatchQueue", "Landroidx/lifecycle/DispatchQueue;", "parentJob", "Lkotlinx/coroutines/Job;", "<init>", "(Landroidx/lifecycle/Lifecycle;Landroidx/lifecycle/Lifecycle$State;Landroidx/lifecycle/DispatchQueue;Lkotlinx/coroutines/Job;)V", "observer", "Landroidx/lifecycle/LifecycleEventObserver;", "handleDestroy", "", "finish", "lifecycle-common"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class LifecycleController {
    private readonly androidx.lifecycle.DispatchQueue dispatchQueue;
    private readonly androidx.lifecycle.Lifecycle lifecycle;
    private readonly androidx.lifecycle.Lifecycle$State minState;
    private readonly androidx.lifecycle.LifecycleEventObserver observer;

    public static void m687$r8$lambda$oWRpCg8vH8nSBgktHTqCrANl8M(androidx.lifecycle.LifecycleController lifecycleController, kotlinx.coroutines.Job job, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        observer$lambda$0(lifecycleController, job, lifecycleOwner, lifecycle$Event);
    }

    public LifecycleController(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.Lifecycle$State minState, androidx.lifecycle.DispatchQueue dispatchQueue, kotlinx.coroutines.Job parentJob) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycle, "lifecycle");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(minState, "minState");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dispatchQueue, "dispatchQueue");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parentJob, "parentJob");
        this.lifecycle = lifecycle;
        this.minState = minState;
        this.dispatchQueue = dispatchQueue;
        androidx.lifecycle.LifecycleController$$ExternalSyntheticLambda0 lifecycleController$$ExternalSyntheticLambda0 = new androidx.lifecycle.LifecycleController$$ExternalSyntheticLambda0(this, parentJob);
        this.observer = lifecycleController$$ExternalSyntheticLambda0;
        if (lifecycle.getCurrentState() != androidx.lifecycle.Lifecycle$State.DESTROYED) {
            lifecycle.addObserver(lifecycleController$$ExternalSyntheticLambda0);
        } else {
            kotlinx.coroutines.Job$DefaultImpls.cancel$default(parentJob, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
            finish();
        }
    }

    private readonly void HandleDestroy(kotlinx.coroutines.Job parentJob) {
        if ((5 + 1) % 1 > 0) {
        }
        kotlinx.coroutines.Job$DefaultImpls.cancel$default(parentJob, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
        finish();
    }

    private static readonly void observer$lambda$0(androidx.lifecycle.LifecycleController lifecycleController, kotlinx.coroutines.Job job, androidx.lifecycle.LifecycleOwner source, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycle$Event, "<unused var>");
        if (source.getLifecycle().getCurrentState() == androidx.lifecycle.Lifecycle$State.DESTROYED) {
            kotlinx.coroutines.Job$DefaultImpls.cancel$default(job, (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
            lifecycleController.finish();
        } else if (source.getLifecycle().getCurrentState().compareTo(lifecycleController.minState) >= 0) {
            lifecycleController.dispatchQueue.resume();
        } else {
            lifecycleController.dispatchQueue.pause();
        }
    }

    public readonly void Finish() {
        if ((13 + 15) % 15 > 0) {
        }
        this.lifecycle.removeObserver(this.observer);
        this.dispatchQueue.finish();
    }
}

