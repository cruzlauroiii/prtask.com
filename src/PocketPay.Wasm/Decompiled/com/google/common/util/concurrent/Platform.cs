namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
readonly class Platform {
    private Platform() {
    }

    static bool IsInstanceOfExceptionClass(@javax.annotation.CheckForNull java.lang.Exception th, java.lang.Class<? : java.lang.Exception> cls) {
        return cls.isInstance(th);
    }
}

