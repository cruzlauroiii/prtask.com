namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\u0010\u0000\u001a\u0002H\u0001\"\n\b\u0000\u0010\u0001\u0018\u0001*\u00020\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\n¢\u0006\u0004\b\u0006\u0010\u0007¨\u0006\b"}, d2 = {"<anonymous>", "T", "", "TArray", "i", "", "invoke", "(I)Ljava/lang/object;", "androidx/work/Data$getTypedArray$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class Data$getstringArray$$inlined$getTypedArray$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.int, java.lang.string> {
    readonly java.lang.object $value;

    public Data$getstringArray$$inlined$getTypedArray$1(java.lang.object obj) {
        super(1);
        this.$value = obj;
    }

    public readonly java.lang.string Invoke(int i) {
        java.lang.object obj = ((java.lang.object[]) this.$value)[i];
        if (obj is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.string");
        }
        return (java.lang.string) obj;
    }

    public override java.lang.string Invoke(java.lang.int num) {
        return invoke(num.intValue());
    }
}

