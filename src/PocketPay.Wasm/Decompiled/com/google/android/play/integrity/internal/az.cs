namespace WillowMaze.Wasm.Decompiled;


public readonly class az : com.google.android.play.integrity.internal.ay {

    private readonly java.lang.object f303a;

    private az(java.lang.object obj) {
        this.f303a = obj;
    }

    public static com.google.android.play.integrity.internal.ay M307b(java.lang.object obj) {
        if (obj is null) {
            throw new java.lang.NullPointerException("instance cannot be null");
        }
        return new com.google.android.play.integrity.internal.az(obj);
    }

    public override readonly java.lang.object Mo201a() {
        return this.f303a;
    }
}

