namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class MulticaststringObserver$Companion$observe$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly kotlinx.coroutines.DisposableHandle $disposeListener;

    MulticaststringObserver$Companion$observe$1$1(kotlinx.coroutines.DisposableHandle disposableHandle) {
        super(0);
        this.$disposeListener = disposableHandle;
    }

    public static void EgnVqtjLqxyXyOXm(androidx.datastore.core.MulticaststringObserver$Companion$observe$1$1 multicaststringObserver$Companion$observe$1$1) {
        multicaststringObserver$Companion$observe$1$1.invoke2();
    }

    public static void SnJDogDCnqJTPQSC(kotlinx.coroutines.DisposableHandle disposableHandle) {
        disposableHandle.dispose();
    }

    public override kotlin.Unit Invoke() {
        EgnVqtjLqxyXyOXm(this);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        SnJDogDCnqJTPQSC(this.$disposeListener);
    }
}

