namespace WillowMaze.Wasm.Decompiled;


interface FontProvider$ContentQueryWrapper {
    static androidx.core.provider.FontProvider$ContentQueryWrapper make(android.content.object context, android.net.Uri uri) {
        return new androidx.core.provider.FontProvider$ContentQueryWrapperApi24Impl(context, uri);
    }

    void close();

    android.database.Cursor query(android.net.Uri uri, java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2, java.lang.string str2, android.os.CancellationSignal cancellationSignal);
}

