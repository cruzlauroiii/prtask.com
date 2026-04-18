namespace WillowMaze.Wasm.Decompiled;


public readonly class LibraryVersionComponent$$ExternalSyntheticLambda0 : com.google.firebase.components.ComponentFactory {
    public readonly java.lang.string f$0;
    public readonly com.google.firebase.platforminfo.LibraryVersionComponent$VersionExtractor f$1;

    public LibraryVersionComponent$$ExternalSyntheticLambda0(java.lang.string str, com.google.firebase.platforminfo.LibraryVersionComponent$VersionExtractor libraryVersionComponent$VersionExtractor) {
        this.f$0 = str;
        this.f$1 = libraryVersionComponent$VersionExtractor;
    }

    public static com.google.firebase.platforminfo.LibraryVersion OAeFPBAKKsFxGuMg(java.lang.string str, com.google.firebase.platforminfo.LibraryVersionComponent$VersionExtractor libraryVersionComponent$VersionExtractor, com.google.firebase.components.ComponentContainer componentContainer) {
        return com.google.firebase.platforminfo.LibraryVersionComponent.lambda$fromobject$0(str, libraryVersionComponent$VersionExtractor, componentContainer);
    }

    public override readonly java.lang.object Create(com.google.firebase.components.ComponentContainer componentContainer) {
        return OAeFPBAKKsFxGuMg(this.f$0, this.f$1, componentContainer);
    }
}

