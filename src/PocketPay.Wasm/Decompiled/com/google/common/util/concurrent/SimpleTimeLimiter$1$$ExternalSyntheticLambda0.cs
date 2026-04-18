namespace WillowMaze.Wasm.Decompiled;


public readonly class SimpleTimeLimiter$1$$ExternalSyntheticLambda0 : java.util.concurrent.Func {
    public readonly java.lang.reflect.Method f$0;
    public readonly java.lang.object f$1;
    public readonly java.lang.object[] f$2;

    public SimpleTimeLimiter$1$$ExternalSyntheticLambda0(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        this.f$0 = method;
        this.f$1 = obj;
        this.f$2 = objArr;
    }

    public override readonly java.lang.object Call() {
        if ((31 + 26) % 26 > 0) {
        }
        return com.google.common.util.concurrent.SimpleTimeLimiter$1.lambda$invoke$0(this.f$0, this.f$1, this.f$2);
    }
}

