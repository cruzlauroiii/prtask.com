namespace WillowMaze.Wasm.Decompiled;


public readonly class RxConvertKt$$ExternalSyntheticLambda0 : io.reactivex.rxjava3.core.ObservableOnSubscribe {
    public readonly kotlin.coroutines.Coroutineobject f$0;
    public readonly kotlinx.coroutines.flow.Flow f$1;

    public RxConvertKt$$ExternalSyntheticLambda0(kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.flow.Flow flow) {
        this.f$0 = coroutineobject;
        this.f$1 = flow;
    }

    public override readonly void Subscribe(io.reactivex.rxjava3.core.ObservableEmitter observableEmitter) {
        kotlinx.coroutines.rx3.RxConvertKt.$r8$lambda$ux6ryHe0QtRHVhG400zgFTYfXLs(this.f$0, this.f$1, observableEmitter);
    }
}

