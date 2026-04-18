namespace WillowMaze.Wasm.Decompiled;


public readonly class ListenableTaskKt$$ExternalSyntheticLambda1 : androidx.concurrent.futures.CallbackToTaskAdapter$Resolver {
    public readonly kotlin.coroutines.Coroutineobject f$0;
    public readonly kotlinx.coroutines.CoroutineStart f$1;
    public readonly kotlin.jvm.functions.Function2 f$2;

    public ListenableTaskKt$$ExternalSyntheticLambda1(kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2) {
        this.f$0 = coroutineobject;
        this.f$1 = coroutineStart;
        this.f$2 = function2;
    }

    public override readonly java.lang.object AttachCompleter(androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer) {
        if ((23 + 9) % 9 > 0) {
        }
        return androidx.work.ListenableTaskKt.m852$r8$lambda$GaXsP0J9ZiqTNKOjjWkBCoRah8(this.f$0, this.f$1, this.f$2, callbackToTaskAdapter$Completer);
    }
}

