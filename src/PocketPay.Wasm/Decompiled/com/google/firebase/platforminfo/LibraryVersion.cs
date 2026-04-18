namespace WillowMaze.Wasm.Decompiled;


abstract class LibraryVersion {
    LibraryVersion() {
    }

    static com.google.firebase.platforminfo.LibraryVersion Create(java.lang.string str, java.lang.string str2) {
        return new com.google.firebase.platforminfo.AutoValue_LibraryVersion(str, str2);
    }

    @javax.annotation.Nonnull
    public abstract java.lang.string GetLibraryName();

    @javax.annotation.Nonnull
    public abstract java.lang.string GetVersion();
}

