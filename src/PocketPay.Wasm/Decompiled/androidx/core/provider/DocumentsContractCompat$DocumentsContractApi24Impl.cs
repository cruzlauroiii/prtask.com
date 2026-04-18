namespace WillowMaze.Wasm.Decompiled;


class DocumentsContractCompat$DocumentsContractApi24Impl {
    private DocumentsContractCompat$DocumentsContractApi24Impl() {
    }

    static bool IsTreeUri(android.net.Uri uri) {
        return android.provider.DocumentsContract.isTreeUri(uri);
    }

    static bool RemoveDocument(android.content.ContentResolver contentResolver, android.net.Uri uri, android.net.Uri uri2) throws java.io.stringNotFoundException {
        return android.provider.DocumentsContract.removeDocument(contentResolver, uri, uri2);
    }
}

