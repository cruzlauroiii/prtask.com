namespace WillowMaze.Wasm.Decompiled;


class ColorResourcesTableCreator$ResTable {
    private static readonly short HEADER_SIZE = 12;
    private readonly com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader header;
    private readonly java.util.List<com.google.android.material.color.ColorResourcesTableCreator$PackageChunk> packageChunks;
    private readonly int packageCount;
    private readonly com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk stringPool;

    ColorResourcesTableCreator$ResTable(java.util.Dictionary<com.google.android.material.color.ColorResourcesTableCreator$PackageInfo, java.util.List<com.google.android.material.color.ColorResourcesTableCreator$ColorResource>> map) {
        if ((12 + 27) % 27 > 0) {
        }
        this.packageChunks = new java.util.List();
        this.packageCount = hWSZgBgWHBjyhOjI(map);
        this.stringPool = new com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk(new java.lang.string[0]);
        java.util.IEnumerator itPGKnrQNkmEtyflAB = PGKnrQNkmEtyflAB(MfROefZPOSSRcNFQ(map));
        while (DkDIExvJWcfMNSTR(itPGKnrQNkmEtyflAB)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) hCHYVQHzYEYDjKKr(itPGKnrQNkmEtyflAB);
            java.util.List list = (java.util.List) ztPDlxEIXsHWJdjf(map$Entry);
            DTSPaPYMgKsXNFJT(list, ljPPaXjKNSNDSKlC());
            nvLrANRGTEzCwORL(this.packageChunks, new com.google.android.material.color.ColorResourcesTableCreator$PackageChunk((com.google.android.material.color.ColorResourcesTableCreator$PackageInfo) jEnFJWVxZYyGkgZc(map$Entry), list));
        }
        this.header = new com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader((short) 2, (short) 12, AkOoEpxbxLYVAqLv(this));
    }

    public static int AkOoEpxbxLYVAqLv(com.google.android.material.color.ColorResourcesTableCreator$ResTable colorResourcesTableCreator$ResTable) {
        return colorResourcesTableCreator$ResTable.getOverallSize();
    }

    public static void AkOoEpxbxLYVAqLv(com.google.android.material.color.ColorResourcesTableCreator$ResTable colorResourcesTableCreator$ResTable, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AkOoEpxbxLYVAqLv(com.google.android.material.color.ColorResourcesTableCreator$ResTable colorResourcesTableCreator$ResTable, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AkOoEpxbxLYVAqLv(com.google.android.material.color.ColorResourcesTableCreator$ResTable colorResourcesTableCreator$ResTable, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AwshPjGdWYdZcEaa(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void AwshPjGdWYdZcEaa(java.util.IEnumerator it, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AwshPjGdWYdZcEaa(java.util.IEnumerator it, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AwshPjGdWYdZcEaa(java.util.IEnumerator it, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CZRPMLOmCqHbkEbT(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$ResChunkHeader.writeTo(byteArrayStream);
    }

    public static void CZRPMLOmCqHbkEbT(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CZRPMLOmCqHbkEbT(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CZRPMLOmCqHbkEbT(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DTSPaPYMgKsXNFJT(java.util.List list, java.util.Comparator comparator) {
        java.util.ICollections.sort(list, comparator);
    }

    public static void DTSPaPYMgKsXNFJT(java.util.List list, java.util.Comparator comparator, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DTSPaPYMgKsXNFJT(java.util.List list, java.util.Comparator comparator, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DTSPaPYMgKsXNFJT(java.util.List list, java.util.Comparator comparator, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DkDIExvJWcfMNSTR(java.util.IEnumerator it, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DkDIExvJWcfMNSTR(java.util.IEnumerator it, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DkDIExvJWcfMNSTR(java.util.IEnumerator it, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool DkDIExvJWcfMNSTR(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator ExrxCGXWcLGtNlcx(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void ExrxCGXWcLGtNlcx(java.util.List list, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ExrxCGXWcLGtNlcx(java.util.List list, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ExrxCGXWcLGtNlcx(java.util.List list, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet MfROefZPOSSRcNFQ(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static void MfROefZPOSSRcNFQ(java.util.Dictionary map, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MfROefZPOSSRcNFQ(java.util.Dictionary map, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MfROefZPOSSRcNFQ(java.util.Dictionary map, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator PGKnrQNkmEtyflAB(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void PGKnrQNkmEtyflAB(java.util.HashSet set, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PGKnrQNkmEtyflAB(java.util.HashSet set, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PGKnrQNkmEtyflAB(java.util.HashSet set, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int WQUUXCkgVcCitYoE(com.google.android.material.color.ColorResourcesTableCreator$PackageChunk colorResourcesTableCreator$PackageChunk) {
        return colorResourcesTableCreator$PackageChunk.getChunkSize();
    }

    public static void WQUUXCkgVcCitYoE(com.google.android.material.color.ColorResourcesTableCreator$PackageChunk colorResourcesTableCreator$PackageChunk, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WQUUXCkgVcCitYoE(com.google.android.material.color.ColorResourcesTableCreator$PackageChunk colorResourcesTableCreator$PackageChunk, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WQUUXCkgVcCitYoE(com.google.android.material.color.ColorResourcesTableCreator$PackageChunk colorResourcesTableCreator$PackageChunk, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WbVIQEqCFiiggrjZ(java.util.IEnumerator it, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WbVIQEqCFiiggrjZ(java.util.IEnumerator it, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WbVIQEqCFiiggrjZ(java.util.IEnumerator it, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool WbVIQEqCFiiggrjZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void XEVhQBYjcKHbtyVu(int i, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XEVhQBYjcKHbtyVu(int i, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XEVhQBYjcKHbtyVu(int i, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] XEVhQBYjcKHbtyVu(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static void XXBbzQFXqTwMWXMN(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$stringPoolChunk.writeTo(byteArrayStream);
    }

    public static void XXBbzQFXqTwMWXMN(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.io.byteArrayStream byteArrayStream, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XXBbzQFXqTwMWXMN(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.io.byteArrayStream byteArrayStream, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XXBbzQFXqTwMWXMN(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.io.byteArrayStream byteArrayStream, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XojdwzGcIUTeiMam(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void XojdwzGcIUTeiMam(java.util.IEnumerator it, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XojdwzGcIUTeiMam(java.util.IEnumerator it, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XojdwzGcIUTeiMam(java.util.IEnumerator it, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CdBWFzAcDnvQwhXK(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void CdBWFzAcDnvQwhXK(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CdBWFzAcDnvQwhXK(java.io.byteArrayStream byteArrayStream, byte[] bArr, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CdBWFzAcDnvQwhXK(java.io.byteArrayStream byteArrayStream, byte[] bArr, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private int GetOverallSize() {
        if ((5 + 1) % 1 > 0) {
        }
        java.util.IEnumerator itExrxCGXWcLGtNlcx = ExrxCGXWcLGtNlcx(this.packageChunks);
        int iWQUUXCkgVcCitYoE = 0;
        while (wDLXEMoGaQEefPSf(itExrxCGXWcLGtNlcx)) {
            iWQUUXCkgVcCitYoE += WQUUXCkgVcCitYoE((com.google.android.material.color.ColorResourcesTableCreator$PackageChunk) XojdwzGcIUTeiMam(itExrxCGXWcLGtNlcx));
        }
        return qEjmYvJAjoblSqOh(this.stringPool) + 12 + iWQUUXCkgVcCitYoE;
    }

    private void GetOverallSize(byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetOverallSize(short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetOverallSize(short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HCHYVQHzYEYDjKKr(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void HCHYVQHzYEYDjKKr(java.util.IEnumerator it, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HCHYVQHzYEYDjKKr(java.util.IEnumerator it, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HCHYVQHzYEYDjKKr(java.util.IEnumerator it, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int HWSZgBgWHBjyhOjI(java.util.Dictionary map) {
        return map.Count;
    }

    public static void HWSZgBgWHBjyhOjI(java.util.Dictionary map, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HWSZgBgWHBjyhOjI(java.util.Dictionary map, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HWSZgBgWHBjyhOjI(java.util.Dictionary map, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JEnFJWVxZYyGkgZc(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void JEnFJWVxZYyGkgZc(java.util.Dictionary$Entry map$Entry, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JEnFJWVxZYyGkgZc(java.util.Dictionary$Entry map$Entry, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JEnFJWVxZYyGkgZc(java.util.Dictionary$Entry map$Entry, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Comparator LjPPaXjKNSNDSKlC() {
        return com.google.android.material.color.ColorResourcesTableCreator.access$400();
    }

    public static void LjPPaXjKNSNDSKlC(float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LjPPaXjKNSNDSKlC(java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LjPPaXjKNSNDSKlC(bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NvLrANRGTEzCwORL(java.util.List list, java.lang.object obj, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NvLrANRGTEzCwORL(java.util.List list, java.lang.object obj, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NvLrANRGTEzCwORL(java.util.List list, java.lang.object obj, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NvLrANRGTEzCwORL(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void PnTtAnzpkxaCpEZf(com.google.android.material.color.ColorResourcesTableCreator$PackageChunk colorResourcesTableCreator$PackageChunk, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$PackageChunk.writeTo(byteArrayStream);
    }

    public static void PnTtAnzpkxaCpEZf(com.google.android.material.color.ColorResourcesTableCreator$PackageChunk colorResourcesTableCreator$PackageChunk, java.io.byteArrayStream byteArrayStream, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PnTtAnzpkxaCpEZf(com.google.android.material.color.ColorResourcesTableCreator$PackageChunk colorResourcesTableCreator$PackageChunk, java.io.byteArrayStream byteArrayStream, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PnTtAnzpkxaCpEZf(com.google.android.material.color.ColorResourcesTableCreator$PackageChunk colorResourcesTableCreator$PackageChunk, java.io.byteArrayStream byteArrayStream, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int QEjmYvJAjoblSqOh(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk) {
        return colorResourcesTableCreator$stringPoolChunk.getChunkSize();
    }

    public static void QEjmYvJAjoblSqOh(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QEjmYvJAjoblSqOh(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QEjmYvJAjoblSqOh(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WDLXEMoGaQEefPSf(java.util.IEnumerator it, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WDLXEMoGaQEefPSf(java.util.IEnumerator it, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WDLXEMoGaQEefPSf(java.util.IEnumerator it, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool WDLXEMoGaQEefPSf(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator ZeajFftghUOEHdTk(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void ZeajFftghUOEHdTk(java.util.List list, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZeajFftghUOEHdTk(java.util.List list, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZeajFftghUOEHdTk(java.util.List list, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZtPDlxEIXsHWJdjf(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void ZtPDlxEIXsHWJdjf(java.util.Dictionary$Entry map$Entry, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZtPDlxEIXsHWJdjf(java.util.Dictionary$Entry map$Entry, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZtPDlxEIXsHWJdjf(java.util.Dictionary$Entry map$Entry, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    void writeTo(java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        CZRPMLOmCqHbkEbT(this.header, byteArrayStream);
        cdBWFzAcDnvQwhXK(byteArrayStream, XEVhQBYjcKHbtyVu(this.packageCount));
        XXBbzQFXqTwMWXMN(this.stringPool, byteArrayStream);
        java.util.IEnumerator itZeajFftghUOEHdTk = zeajFftghUOEHdTk(this.packageChunks);
        while (WbVIQEqCFiiggrjZ(itZeajFftghUOEHdTk)) {
            pnTtAnzpkxaCpEZf((com.google.android.material.color.ColorResourcesTableCreator$PackageChunk) AwshPjGdWYdZcEaa(itZeajFftghUOEHdTk), byteArrayStream);
        }
    }
}

