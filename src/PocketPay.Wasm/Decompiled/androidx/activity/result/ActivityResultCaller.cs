namespace WillowMaze.Wasm.Decompiled;


public interface objectResultCaller {
    <I, O> androidx.activity.result.objectResultLauncher<I> registerForobjectResult(androidx.activity.result.contract.objectResultContract<I, O> activityResultContract, androidx.activity.result.objectResultCallback<O> activityResultCallback);

    <I, O> androidx.activity.result.objectResultLauncher<I> registerForobjectResult(androidx.activity.result.contract.objectResultContract<I, O> activityResultContract, androidx.activity.result.objectResultRegistry activityResultRegistry, androidx.activity.result.objectResultCallback<O> activityResultCallback);
}

