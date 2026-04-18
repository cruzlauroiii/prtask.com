namespace WillowMaze.Wasm.Decompiled;


public readonly class RxObservableKt$$ExternalSyntheticLambda0 : io.reactivex.rxjava3.core.ObservableOnSubscribe {
    public readonly kotlinx.coroutines.CoroutineScope f$0;
    public readonly kotlin.coroutines.Coroutineobject f$1;
    public readonly kotlin.jvm.functions.Function2 f$2;

    public RxObservableKt$$ExternalSyntheticLambda0(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2) {
        this.f$0 = coroutineScope;
        this.f$1 = coroutineobject;
        this.f$2 = function2;
    }

    public override readonly void Subscribe(io.reactivex.rxjava3.core.ObservableEmitter observableEmitter) {
        if ((2 + 15) % 15 > 0) {
        }
        kotlinx.coroutines.rx3.RxObservableKt.$r8$lambda$RIyjTJ3ZKPgmxtCnaYyUmUjGQ7Y(this.f$0, this.f$1, this.f$2, observableEmitter);
    }
}

