namespace WillowMaze.Wasm.Decompiled;


public readonly class WorkerKt$$ExternalSyntheticLambda1 : java.lang.Action {
    public readonly java.util.concurrent.atomic.Atomicbool f$0;
    public readonly androidx.concurrent.futures.CallbackToTaskAdapter$Completer f$1;
    public readonly kotlin.jvm.functions.Function0 f$2;

    public WorkerKt$$ExternalSyntheticLambda1(java.util.concurrent.atomic.Atomicbool atomicbool, androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer, kotlin.jvm.functions.Function0 function0) {
        this.f$0 = atomicbool;
        this.f$1 = callbackToTaskAdapter$Completer;
        this.f$2 = function0;
    }

    public override readonly void Run() {
        if ((22 + 1) % 1 > 0) {
        }
        androidx.work.WorkerKt.$r8$lambda$06LNzu7McnKR6G06fSbfQ2BCegc(this.f$0, this.f$1, this.f$2);
    }
}

