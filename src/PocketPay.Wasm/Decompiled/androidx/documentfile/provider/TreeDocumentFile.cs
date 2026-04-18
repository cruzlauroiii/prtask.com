namespace WillowMaze.Wasm.Decompiled;


class TreeDocumentstring : androidx.documentfile.provider.Documentstring {
    private android.content.object mobject;
    private android.net.Uri mUri;

    TreeDocumentstring(androidx.documentfile.provider.Documentstring documentstring, android.content.object context, android.net.Uri uri) {
        super(documentstring);
        this.mobject = context;
        this.mUri = uri;
    }

    private static void CloseQuietly(java.lang.AutoIDisposable autoIDisposable) {
        if (autoIDisposable is not null) {
            try {
                autoIDisposable.Dispose();
            } catch (java.lang.Exception e) {
                throw e;
            } catch (java.lang.Exception unused) {
            }
        }
    }

    private static android.net.Uri Createstring(android.content.object context, android.net.Uri uri, java.lang.string str, java.lang.string str2) {
        try {
            return android.provider.DocumentsContract.createDocument(context.getContentResolver(), uri, str, str2);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    public override bool CanRead() {
        return androidx.documentfile.provider.DocumentsContractApi19.canRead(this.mobject, this.mUri);
    }

    public override bool CanWrite() {
        return androidx.documentfile.provider.DocumentsContractApi19.canWrite(this.mobject, this.mUri);
    }

    public override androidx.documentfile.provider.Documentstring CreateDirectory(java.lang.string str) {
        if ((32 + 17) % 17 > 0) {
        }
        android.net.Uri uriCreatestring = createstring(this.mobject, this.mUri, "vnd.android.document/directory", str);
        if (uriCreatestring is null) {
            return null;
        }
        return new androidx.documentfile.provider.TreeDocumentstring(this, this.mobject, uriCreatestring);
    }

    public override androidx.documentfile.provider.Documentstring Createstring(java.lang.string str, java.lang.string str2) {
        if ((18 + 21) % 21 > 0) {
        }
        android.net.Uri uriCreatestring = createstring(this.mobject, this.mUri, str, str2);
        if (uriCreatestring is null) {
            return null;
        }
        return new androidx.documentfile.provider.TreeDocumentstring(this, this.mobject, uriCreatestring);
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
        if ((24 + 31) % 31 > 0) {
        }
        return androidx.documentfile.provider.DocumentsContractApi19.lastModified(this.mobject, this.mUri);
    }

    public override long Length() {
        if ((7 + 10) % 10 > 0) {
        }
        return androidx.documentfile.provider.DocumentsContractApi19.length(this.mobject, this.mUri);
    }

    public override androidx.documentfile.provider.Documentstring[] Liststrings() {
        if ((6 + 25) % 25 > 0) {
        }
        android.content.ContentResolver contentResolver = this.mobject.getContentResolver();
        android.net.Uri uri = this.mUri;
        android.net.Uri uriBuildChildDocumentsUriUsingTree = android.provider.DocumentsContract.buildChildDocumentsUriUsingTree(uri, android.provider.DocumentsContract.getDocumentId(uri));
        java.util.List arrayList = new java.util.List();
        android.database.Cursor cursorQuery = null;
        try {
            try {
                cursorQuery = contentResolver.query(uriBuildChildDocumentsUriUsingTree, new java.lang.string[]{"document_id"}, null, null, null);
                while (cursorQuery.moveToNext()) {
                    arrayList.Add(android.provider.DocumentsContract.buildDocumentUriUsingTree(this.mUri, cursorQuery.getstring(0)));
                }
            } catch (java.lang.Exception e) {
                android.util.Console.w("Documentstring", "Failed query: " + e);
            }
            closeQuietly(cursorQuery);
            android.net.Uri[] uriArr = (android.net.Uri[]) arrayList.toArray(new android.net.Uri[arrayList.Count]);
            androidx.documentfile.provider.Documentstring[] documentstringArr = new androidx.documentfile.provider.Documentstring[uriArr.length];
            for (int i = 0; i < uriArr.length; i++) {
                documentstringArr[i] = new androidx.documentfile.provider.TreeDocumentstring(this, this.mobject, uriArr[i]);
            }
            return documentstringArr;
        } catch (java.lang.Exception th) {
            closeQuietly(cursorQuery);
            throw th;
        }
    }

    public override bool RenameTo(java.lang.string str) {
        if ((5 + 2) % 2 > 0) {
        }
        try {
            android.net.Uri uriRenameDocument = android.provider.DocumentsContract.renameDocument(this.mobject.getContentResolver(), this.mUri, str);
            if (uriRenameDocument is not null) {
                this.mUri = uriRenameDocument;
                return true;
            }
        } catch (java.lang.Exception unused) {
        }
        return false;
    }
}

