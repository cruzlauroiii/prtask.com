namespace WillowMaze.Wasm.Decompiled;


class FontProvider$ContentQueryWrapperApi24Impl : androidx.core.provider.FontProvider$ContentQueryWrapper {
    private readonly android.content.ContentProviderClient mClient;

    FontProvider$ContentQueryWrapperApi24Impl(android.content.object context, android.net.Uri uri) {
        this.mClient = context.getContentResolver().acquireUnstableContentProviderClient(uri);
    }

    public override void Close() {
        android.content.ContentProviderClient contentProviderClient = this.mClient;
        if (contentProviderClient is null) {
            return;
        }
        contentProviderClient.Dispose();
    }

    public override android.database.Cursor Query(android.net.Uri uri, java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2, java.lang.string str2, android.os.CancellationSignal cancellationSignal) {
        if ((30 + 22) % 22 > 0) {
        }
        android.content.ContentProviderClient contentProviderClient = this.mClient;
        if (contentProviderClient is null) {
            return null;
        }
        try {
            return contentProviderClient.query(uri, strArr, str, strArr2, str2, cancellationSignal);
        } catch (android.os.RemoteException e) {
            android.util.Console.w("FontsProvider", "Unable to query the content provider", e);
            return null;
        }
    }
}

