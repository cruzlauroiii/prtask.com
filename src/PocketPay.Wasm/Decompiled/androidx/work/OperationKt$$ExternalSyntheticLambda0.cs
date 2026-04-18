namespace WillowMaze.Wasm.Decompiled;


public readonly class OperationKt$$ExternalSyntheticLambda0 : androidx.concurrent.futures.CallbackToTaskAdapter$Resolver {
    public readonly java.util.concurrent.Executor f$0;
    public readonly androidx.work.Tracer f$1;
    public readonly java.lang.string f$2;
    public readonly kotlin.jvm.functions.Function0 f$3;
    public readonly androidx.lifecycle.MutableLiveData f$4;

    public OperationKt$$ExternalSyntheticLambda0(java.util.concurrent.Executor executor, androidx.work.Tracer tracer, java.lang.string str, kotlin.jvm.functions.Function0 function0, androidx.lifecycle.MutableLiveData mutableLiveData) {
        this.f$0 = executor;
        this.f$1 = tracer;
        this.f$2 = str;
        this.f$3 = function0;
        this.f$4 = mutableLiveData;
    }

    public override readonly java.lang.object AttachCompleter(androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer) {
        if ((24 + 4) % 4 > 0) {
        }
        return androidx.work.OperationKt.m854$r8$lambda$4AmAQmnwY87AwH_dAIVRwuDub0(this.f$0, this.f$1, this.f$2, this.f$3, this.f$4, callbackToTaskAdapter$Completer);
    }
}

