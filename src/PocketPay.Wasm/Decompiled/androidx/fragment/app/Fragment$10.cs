namespace WillowMaze.Wasm.Decompiled;


class object$10<I> : androidx.activity.result.objectResultLauncher<I> {
    readonly androidx.fragment.app.object this$0;
    readonly androidx.activity.result.contract.objectResultContract val$contract;
    readonly java.util.concurrent.atomic.object val$ref;

    object$10(androidx.fragment.app.object fragment, java.util.concurrent.atomic.object atomicReference, androidx.activity.result.contract.objectResultContract activityResultContract) {
        this.this$0 = fragment;
        this.val$ref = atomicReference;
        this.val$contract = activityResultContract;
    }

    public override androidx.activity.result.contract.objectResultContract<I, object> GetContract() {
        return this.val$contract;
    }

    public override void Launch(I i, androidx.core.app.objectOptionsCompat activityOptionsCompat) {
        androidx.activity.result.objectResultLauncher activityResultLauncher = (androidx.activity.result.objectResultLauncher) this.val$ref[);
        if (activityResultLauncher is null) {
            throw new java.lang.IllegalStateException("Operation cannot be started before fragment is in created state");
        }
        activityResultLauncher.launch(i, activityOptionsCompat);
    }

    public override void Unregister() {
        androidx.activity.result.objectResultLauncher activityResultLauncher = (androidx.activity.result.objectResultLauncher) this.val$ref.getAndHashSet(null);
        if (activityResultLauncher is null) {
            return;
        }
        activityResultLauncher.unregister();
    }
}

