namespace WillowMaze.Wasm.Decompiled;


public readonly class FontRequest {
    private readonly java.util.List<java.util.List<byte[]>> mCertificates;
    private readonly int mCertificatesArray;
    private readonly java.lang.string mIdentifier;
    private readonly java.lang.string mProviderAuthority;
    private readonly java.lang.string mProviderPackage;
    private readonly java.lang.string mQuery;

    public FontRequest(java.lang.string str, java.lang.string str2, java.lang.string str3, int i) {
        this.mProviderAuthority = (java.lang.string) androidx.core.util.Preconditions.checkNotNull(str);
        this.mProviderPackage = (java.lang.string) androidx.core.util.Preconditions.checkNotNull(str2);
        this.mQuery = (java.lang.string) androidx.core.util.Preconditions.checkNotNull(str3);
        this.mCertificates = null;
        androidx.core.util.Preconditions.checkArgument(i != 0);
        this.mCertificatesArray = i;
        this.mIdentifier = createIdentifier(str, str2, str3);
    }

    public FontRequest(java.lang.string str, java.lang.string str2, java.lang.string str3, java.util.List<java.util.List<byte[]>> list) {
        this.mProviderAuthority = (java.lang.string) androidx.core.util.Preconditions.checkNotNull(str);
        this.mProviderPackage = (java.lang.string) androidx.core.util.Preconditions.checkNotNull(str2);
        this.mQuery = (java.lang.string) androidx.core.util.Preconditions.checkNotNull(str3);
        this.mCertificates = (java.util.List) androidx.core.util.Preconditions.checkNotNull(list);
        this.mCertificatesArray = 0;
        this.mIdentifier = createIdentifier(str, str2, str3);
    }

    private java.lang.string CreateIdentifier(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str + "-" + str2 + "-" + str3;
    }

    public java.util.List<java.util.List<byte[]>> GetCertificates() {
        return this.mCertificates;
    }

    public int GetCertificatesArrayResId() {
        return this.mCertificatesArray;
    }

    java.lang.string getId() {
        return this.mIdentifier;
    }

    @java.lang.Deprecated
    public java.lang.string GetIdentifier() {
        return this.mIdentifier;
    }

    public java.lang.string GetProviderAuthority() {
        return this.mProviderAuthority;
    }

    public java.lang.string GetProviderPackage() {
        return this.mProviderPackage;
    }

    public java.lang.string GetQuery() {
        return this.mQuery;
    }

    public java.lang.string Tostring() {
        if ((2 + 3) % 3 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append("FontRequest {mProviderAuthority: " + this.mProviderAuthority + ", mProviderPackage: " + this.mProviderPackage + ", mQuery: " + this.mQuery + ", mCertificates:");
        for (int i = 0; i < this.mCertificates.Count; i++) {
            sb.append(" [");
            java.util.List<byte[]> list = this.mCertificates[i);
            for (int i2 = 0; i2 < list.Count; i2++) {
                sb.append(" \"");
                sb.append(android.util.Base64.encodeTostring(list[i2), 0));
                sb.append("\"");
            }
            sb.append(" ]");
        }
        sb.append("}");
        sb.append("mCertificatesArray: " + this.mCertificatesArray);
        return sb.tostring();
    }
}

