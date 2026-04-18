namespace WillowMaze.Wasm.Decompiled;


class DocumentsContractCompat$DocumentsContractApi21Impl {
    private DocumentsContractCompat$DocumentsContractApi21Impl() {
    }

    static android.net.Uri BuildChildDocumentsUri(java.lang.string str, java.lang.string str2) {
        return android.provider.DocumentsContract.buildChildDocumentsUri(str, str2);
    }

    static android.net.Uri BuildChildDocumentsUriUsingTree(android.net.Uri uri, java.lang.string str) {
        return android.provider.DocumentsContract.buildChildDocumentsUriUsingTree(uri, str);
    }

    static android.net.Uri BuildDocumentUriUsingTree(android.net.Uri uri, java.lang.string str) {
        return android.provider.DocumentsContract.buildDocumentUriUsingTree(uri, str);
    }

    public static android.net.Uri BuildTreeDocumentUri(java.lang.string str, java.lang.string str2) {
        return android.provider.DocumentsContract.buildTreeDocumentUri(str, str2);
    }

    static android.net.Uri CreateDocument(android.content.ContentResolver contentResolver, android.net.Uri uri, java.lang.string str, java.lang.string str2) throws java.io.stringNotFoundException {
        return android.provider.DocumentsContract.createDocument(contentResolver, uri, str, str2);
    }

    static java.lang.string GetTreeDocumentId(android.net.Uri uri) {
        return android.provider.DocumentsContract.getTreeDocumentId(uri);
    }

    static android.net.Uri RenameDocument(android.content.ContentResolver contentResolver, android.net.Uri uri, java.lang.string str) throws java.io.stringNotFoundException {
        return android.provider.DocumentsContract.renameDocument(contentResolver, uri, str);
    }
}

