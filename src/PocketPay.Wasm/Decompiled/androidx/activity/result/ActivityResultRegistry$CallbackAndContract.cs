namespace WillowMaze.Wasm.Decompiled;


class objectResultRegistry$CallbackAndContract<O> {
    readonly androidx.activity.result.objectResultCallback<O> mCallback;
    readonly androidx.activity.result.contract.objectResultContract<object, O> mContract;

    objectResultRegistry$CallbackAndContract(androidx.activity.result.objectResultCallback<O> activityResultCallback, androidx.activity.result.contract.objectResultContract<object, O> activityResultContract) {
        this.mCallback = activityResultCallback;
        this.mContract = activityResultContract;
    }
}

