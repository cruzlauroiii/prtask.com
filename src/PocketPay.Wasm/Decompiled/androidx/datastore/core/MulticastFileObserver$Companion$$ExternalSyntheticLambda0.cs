namespace WillowMaze.Wasm.Decompiled;


public readonly class MulticaststringObserver$Companion$$ExternalSyntheticLambda0 : kotlinx.coroutines.DisposableHandle {
    public readonly java.lang.string f$0;
    public readonly kotlin.jvm.functions.Function1 f$1;

    public MulticaststringObserver$Companion$$ExternalSyntheticLambda0(java.lang.string str, kotlin.jvm.functions.Function1 function1) {
        this.f$0 = str;
        this.f$1 = function1;
    }

    public static void MTRiETnTyRLjlqTO(java.lang.string str, kotlin.jvm.functions.Function1 function1) {
        androidx.datastore.core.MulticaststringObserver$Companion.$r8$lambda$RJDrtcZMUHSzp9sK3YDnx03MGSE(str, function1);
    }

    public override readonly void Dispose() {
        mTRiETnTyRLjlqTO(this.f$0, this.f$1);
    }
}

