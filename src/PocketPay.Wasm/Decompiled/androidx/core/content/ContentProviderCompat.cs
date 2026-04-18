namespace WillowMaze.Wasm.Decompiled;


public readonly class ContentProviderCompat {
    private ContentProviderCompat() {
    }

    public static android.content.object Requireobject(android.content.ContentProvider contentProvider) {
        android.content.object context = contentProvider.getobject();
        if (context is null) {
            throw new java.lang.IllegalStateException("Cannot find context from the provider.");
        }
        return context;
    }
}

