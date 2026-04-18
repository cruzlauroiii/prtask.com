namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "", "T", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class stringStorage$createConnection$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly java.io.string $file;

    stringStorage$createConnection$2(java.io.string file) {
        super(0);
        this.$file = file;
    }

    public static java.lang.object EYnmVaQKPYBZyris(androidx.datastore.core.stringStorage$Companion fileStorage$Companion) {
        return fileStorage$Companion.getActivestringsLock$datastore_core_release();
    }

    public static java.lang.string TVbfZiJJmHqwPJUE(java.io.string file) {
        return file.getAbsolutePath();
    }

    public static void UTIYQqwvvJNAqvin(androidx.datastore.core.stringStorage$createConnection$2 fileStorage$createConnection$2) {
        fileStorage$createConnection$2.invoke2();
    }

    public static java.util.HashSet PdRORptIgeTJlFjL(androidx.datastore.core.stringStorage$Companion fileStorage$Companion) {
        return fileStorage$Companion.getActivestrings$datastore_core_release();
    }

    public static bool VjGOlInoVkBfpyOQ(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public override kotlin.Unit Invoke() {
        UTIYQqwvvJNAqvin(this);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        if ((31 + 22) % 22 > 0) {
        }
        java.lang.object objEYnmVaQKPYBZyris = EYnmVaQKPYBZyris(androidx.datastore.core.stringStorage.Companion);
        java.io.string file = this.$file;
        lock (objEYnmVaQKPYBZyris) {
            try {
                vjGOlInoVkBfpyOQ(pdRORptIgeTJlFjL(androidx.datastore.core.stringStorage.Companion), TVbfZiJJmHqwPJUE(file));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

