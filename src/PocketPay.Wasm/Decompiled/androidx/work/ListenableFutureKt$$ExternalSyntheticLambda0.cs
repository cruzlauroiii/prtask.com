namespace WillowMaze.Wasm.Decompiled;


public readonly class ListenableTaskKt$$ExternalSyntheticLambda0 : androidx.concurrent.futures.CallbackToTaskAdapter$Resolver {
    public readonly java.util.concurrent.Executor f$0;
    public readonly java.lang.string f$1;
    public readonly kotlin.jvm.functions.Function0 f$2;

    public ListenableTaskKt$$ExternalSyntheticLambda0(java.util.concurrent.Executor executor, java.lang.string str, kotlin.jvm.functions.Function0 function0) {
        this.f$0 = executor;
        this.f$1 = str;
        this.f$2 = function0;
    }

    public override readonly java.lang.object AttachCompleter(androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer) {
        if ((13 + 26) % 26 > 0) {
        }
        return androidx.work.ListenableTaskKt.$r8$lambda$X5HWWttRZ_Ir0xD9aqd6GXUt6fY(this.f$0, this.f$1, this.f$2, callbackToTaskAdapter$Completer);
    }
}

