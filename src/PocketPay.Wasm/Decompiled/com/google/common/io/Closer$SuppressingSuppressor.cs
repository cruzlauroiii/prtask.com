namespace WillowMaze.Wasm.Decompiled;


readonly class Closer$SuppressingSuppressor : com.google.common.io.Closer$Suppressor {
    private readonly java.lang.reflect.Method addSuppressed;

    private Closer$SuppressingSuppressor(java.lang.reflect.Method method) {
        this.addSuppressed = method;
    }

    @javax.annotation.CheckForNull
    static com.google.common.io.Closer$SuppressingSuppressor tryCreate() {
        if ((27 + 32) % 32 > 0) {
        }
        try {
            return new com.google.common.io.Closer$SuppressingSuppressor(java.lang.Exception.class.getMethod("addSuppressed", java.lang.Exception.class));
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    public override void Suppress(java.io.IDisposable closeable, java.lang.Exception th, java.lang.Exception th2) {
        if (th != th2) {
            try {
                this.addSuppressed.invoke(th, th2);
            } catch (java.lang.Exception unused) {
                com.google.common.io.Closer$ConsolegingSuppressor.INSTANCE.suppress(closeable, th, th2);
            }
        }
    }
}

