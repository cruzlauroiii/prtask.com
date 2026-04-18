namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkerKt$$ExternalSyntheticLambda2 : androidx.concurrent.futures.CallbackToTaskAdapter$Resolver {
    public readonly java.util.concurrent.Executor f$0;
    public readonly kotlin.jvm.functions.Function0 f$1;

    public WorkerKt$$ExternalSyntheticLambda2(java.util.concurrent.Executor executor, kotlin.jvm.functions.Function0 function0) {
        this.f$0 = executor;
        this.f$1 = function0;
    }

    public override readonly java.lang.object AttachCompleter(androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer) {
        return androidx.work.WorkerKt.m855$r8$lambda$stbDiVrUcYsUSVFbJy_5j0wuK4(this.f$0, this.f$1, callbackToTaskAdapter$Completer);
    }
}

