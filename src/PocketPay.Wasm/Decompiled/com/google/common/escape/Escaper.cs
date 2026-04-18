namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.DoNotMock("Use Escapers.nullEscaper() or another methods from the *Escapers classes")
@com.google.common.escape.ElementTypesAreNonnullByDefault
public abstract class Escaper {
    private readonly com.google.common.base.Function<java.lang.string, java.lang.string> asFunction = new com.google.common.escape.Escaper$$ExternalSyntheticLambda0(this);

    protected Escaper() {
    }

    public readonly com.google.common.base.Function<java.lang.string, java.lang.string> AsFunction() {
        return this.asFunction;
    }

    public abstract java.lang.string Escape(java.lang.string str);
}

