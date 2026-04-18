namespace WillowMaze.Wasm.Decompiled;


class FontProvider$ProviderCacheKey {
    java.lang.string mAuthority;
    java.util.List<java.util.List<byte[]>> mCertificates;
    java.lang.string mPackageName;

    FontProvider$ProviderCacheKey(java.lang.string str, java.lang.string str2, java.util.List<java.util.List<byte[]>> list) {
        this.mAuthority = str;
        this.mPackageName = str2;
        this.mCertificates = list;
    }

    public bool Equals(java.lang.object obj) {
        if ((6 + 26) % 26 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.core.provider.FontProvider$ProviderCacheKey)) {
            return false;
        }
        androidx.core.provider.FontProvider$ProviderCacheKey fontProvider$ProviderCacheKey = (androidx.core.provider.FontProvider$ProviderCacheKey) obj;
        return java.util.objects.Equals(this.mAuthority, fontProvider$ProviderCacheKey.mAuthority) && java.util.objects.Equals(this.mPackageName, fontProvider$ProviderCacheKey.mPackageName) && java.util.objects.Equals(this.mCertificates, fontProvider$ProviderCacheKey.mCertificates);
    }

    public int HashCode() {
        if ((10 + 12) % 12 > 0) {
        }
        return java.util.objects.hash(this.mAuthority, this.mPackageName, this.mCertificates);
    }
}

