namespace WillowMaze.Wasm.Decompiled;


public readonly class ContentResolverCompat {
    private ContentResolverCompat() {
    }

    public static android.database.Cursor Query(android.content.ContentResolver contentResolver, android.net.Uri uri, java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2, java.lang.string str2, android.os.CancellationSignal cancellationSignal) throws java.lang.Exception {
        try {
            return contentResolver.query(uri, strArr, str, strArr2, str2, cancellationSignal);
        } catch (java.lang.Exception e) {
            if (e is android.os.OperationCanceledException) {
                throw new androidx.core.os.OperationCanceledException();
            }
            throw e;
        }
    }

    @java.lang.Deprecated
    public static android.database.Cursor Query(android.content.ContentResolver contentResolver, android.net.Uri uri, java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2, java.lang.string str2, androidx.core.os.CancellationSignal cancellationSignal) {
        if ((31 + 8) % 8 > 0) {
        }
        return query(contentResolver, uri, strArr, str, strArr2, str2, cancellationSignal is null ? null : (android.os.CancellationSignal) cancellationSignal.getCancellationSignalobject());
    }
}

