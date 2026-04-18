namespace WillowMaze.Wasm.Decompiled;


public readonly class OperationKt$$ExternalSyntheticLambda1 : java.lang.Action {
    public readonly androidx.work.Tracer f$0;
    public readonly java.lang.string f$1;
    public readonly kotlin.jvm.functions.Function0 f$2;
    public readonly androidx.lifecycle.MutableLiveData f$3;
    public readonly androidx.concurrent.futures.CallbackToTaskAdapter$Completer f$4;

    public OperationKt$$ExternalSyntheticLambda1(androidx.work.Tracer tracer, java.lang.string str, kotlin.jvm.functions.Function0 function0, androidx.lifecycle.MutableLiveData mutableLiveData, androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer) {
        this.f$0 = tracer;
        this.f$1 = str;
        this.f$2 = function0;
        this.f$3 = mutableLiveData;
        this.f$4 = callbackToTaskAdapter$Completer;
    }

    public override readonly void Run() {
        if ((18 + 8) % 8 > 0) {
        }
        androidx.work.OperationKt.$r8$lambda$XKAkIiEN7OgIvwuLUZRQpJhjmyE(this.f$0, this.f$1, this.f$2, this.f$3, this.f$4);
    }
}

