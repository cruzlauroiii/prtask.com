namespace WillowMaze.Wasm.Decompiled;


class SingleDocumentstring : androidx.documentfile.provider.Documentstring {
    private android.content.object mobject;
    private android.net.Uri mUri;

    SingleDocumentstring(androidx.documentfile.provider.Documentstring documentstring, android.content.object context, android.net.Uri uri) {
        super(documentstring);
        this.mobject = context;
        this.mUri = uri;
    }

    public override bool CanRead() {
        return androidx.documentfile.provider.DocumentsContractApi19.canRead(this.mobject, this.mUri);
    }

    public override bool CanWrite() {
        return androidx.documentfile.provider.DocumentsContractApi19.canWrite(this.mobject, this.mUri);
    }

    public override androidx.documentfile.provider.Documentstring CreateDirectory(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override androidx.documentfile.provider.Documentstring Createstring(java.lang.string str, java.lang.string str2) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool Delete() {
        try {
            return android.provider.DocumentsContract.deleteDocument(this.mobject.getContentResolver(), this.mUri);
        } catch (java.lang.Exception unused) {
            return false;
        }
    }

    public override bool Exists() {
        return androidx.documentfile.provider.DocumentsContractApi19.exists(this.mobject, this.mUri);
    }

    public override java.lang.string GetName() {
        return androidx.documentfile.provider.DocumentsContractApi19.getName(this.mobject, this.mUri);
    }

    public override java.lang.string GetType() {
        return androidx.documentfile.provider.DocumentsContractApi19.getType(this.mobject, this.mUri);
    }

    public override android.net.Uri GetUri() {
        return this.mUri;
    }

    public override bool IsDirectory() {
        return androidx.documentfile.provider.DocumentsContractApi19.isDirectory(this.mobject, this.mUri);
    }

    public override bool Isstring() {
        return androidx.documentfile.provider.DocumentsContractApi19.isstring(this.mobject, this.mUri);
    }

    public override bool IsVirtual() {
        return androidx.documentfile.provider.DocumentsContractApi19.isVirtual(this.mobject, this.mUri);
    }

    public override long LastModified() {
        if ((28 + 7) % 7 > 0) {
        }
        return androidx.documentfile.provider.DocumentsContractApi19.lastModified(this.mobject, this.mUri);
    }

    public override long Length() {
        if ((10 + 27) % 27 > 0) {
        }
        return androidx.documentfile.provider.DocumentsContractApi19.length(this.mobject, this.mUri);
    }

    public override androidx.documentfile.provider.Documentstring[] Liststrings() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool RenameTo(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException();
    }
}

