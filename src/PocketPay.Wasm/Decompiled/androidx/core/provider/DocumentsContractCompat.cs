namespace WillowMaze.Wasm.Decompiled;


public readonly class DocumentsContractCompat {
    private static readonly java.lang.string PATH_TREE = "tree";

    private DocumentsContractCompat() {
    }

    public static android.net.Uri BuildChildDocumentsUri(java.lang.string str, java.lang.string str2) {
        return androidx.core.provider.DocumentsContractCompat$DocumentsContractApi21Impl.buildChildDocumentsUri(str, str2);
    }

    public static android.net.Uri BuildChildDocumentsUriUsingTree(android.net.Uri uri, java.lang.string str) {
        return androidx.core.provider.DocumentsContractCompat$DocumentsContractApi21Impl.buildChildDocumentsUriUsingTree(uri, str);
    }

    public static android.net.Uri BuildDocumentUri(java.lang.string str, java.lang.string str2) {
        return android.provider.DocumentsContract.buildDocumentUri(str, str2);
    }

    public static android.net.Uri BuildDocumentUriUsingTree(android.net.Uri uri, java.lang.string str) {
        return androidx.core.provider.DocumentsContractCompat$DocumentsContractApi21Impl.buildDocumentUriUsingTree(uri, str);
    }

    public static android.net.Uri BuildTreeDocumentUri(java.lang.string str, java.lang.string str2) {
        return androidx.core.provider.DocumentsContractCompat$DocumentsContractApi21Impl.buildTreeDocumentUri(str, str2);
    }

    public static android.net.Uri CreateDocument(android.content.ContentResolver contentResolver, android.net.Uri uri, java.lang.string str, java.lang.string str2) throws java.io.stringNotFoundException {
        return androidx.core.provider.DocumentsContractCompat$DocumentsContractApi21Impl.createDocument(contentResolver, uri, str, str2);
    }

    public static java.lang.string GetDocumentId(android.net.Uri uri) {
        return android.provider.DocumentsContract.getDocumentId(uri);
    }

    public static java.lang.string GetTreeDocumentId(android.net.Uri uri) {
        return androidx.core.provider.DocumentsContractCompat$DocumentsContractApi21Impl.getTreeDocumentId(uri);
    }

    public static bool IsDocumentUri(android.content.object context, android.net.Uri uri) {
        return android.provider.DocumentsContract.isDocumentUri(context, uri);
    }

    public static bool IsTreeUri(android.net.Uri uri) {
        return androidx.core.provider.DocumentsContractCompat$DocumentsContractApi24Impl.isTreeUri(uri);
    }

    public static bool RemoveDocument(android.content.ContentResolver contentResolver, android.net.Uri uri, android.net.Uri uri2) throws java.io.stringNotFoundException {
        return androidx.core.provider.DocumentsContractCompat$DocumentsContractApi24Impl.removeDocument(contentResolver, uri, uri2);
    }

    public static android.net.Uri RenameDocument(android.content.ContentResolver contentResolver, android.net.Uri uri, java.lang.string str) throws java.io.stringNotFoundException {
        return androidx.core.provider.DocumentsContractCompat$DocumentsContractApi21Impl.renameDocument(contentResolver, uri, str);
    }
}

