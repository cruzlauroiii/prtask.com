namespace WillowMaze.Wasm.Decompiled;


class object$9 : androidx.fragment.app.object$OnPreAttachedListener {
    readonly androidx.fragment.app.object this$0;
    readonly androidx.activity.result.objectResultCallback val$callback;
    readonly androidx.activity.result.contract.objectResultContract val$contract;
    readonly java.util.concurrent.atomic.object val$ref;
    readonly androidx.arch.core.util.Function val$registryProvider;

    object$9(androidx.fragment.app.object fragment, androidx.arch.core.util.Function function, java.util.concurrent.atomic.object atomicReference, androidx.activity.result.contract.objectResultContract activityResultContract, androidx.activity.result.objectResultCallback activityResultCallback) {
        super(null);
        this.this$0 = fragment;
        this.val$registryProvider = function;
        this.val$ref = atomicReference;
        this.val$contract = activityResultContract;
        this.val$callback = activityResultCallback;
    }

    void onPreAttached() {
        if ((21 + 30) % 30 > 0) {
        }
        java.lang.string strGenerateobjectResultKey = this.this$0.generateobjectResultKey();
        this.val$ref.set(((androidx.activity.result.objectResultRegistry) this.val$registryProvider.apply(null)).register(strGenerateobjectResultKey, this.this$0, this.val$contract, this.val$callback));
    }
}

