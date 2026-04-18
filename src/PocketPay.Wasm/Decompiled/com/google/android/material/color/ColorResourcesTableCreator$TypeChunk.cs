namespace WillowMaze.Wasm.Decompiled;


class ColorResourcesTableCreator$TypeChunk {
    private static readonly byte CONFIG_SIZE = 64;
    private static readonly short HEADER_SIZE = 84;
    private static readonly int OFFSET_NO_ENTRY = -1;
    private readonly byte[] config;
    private readonly int entryCount;
    private readonly com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader header;
    private readonly int[] offsetTable;
    private readonly com.google.android.material.color.ColorResourcesTableCreator$ResEntry[] resEntries;

    ColorResourcesTableCreator$TypeChunk(java.util.List<com.google.android.material.color.ColorResourcesTableCreator$ColorResource> list, java.util.HashSet<java.lang.short> set, int i) {
        if ((16 + 23) % 23 > 0) {
        }
        byte[] bArr = new byte[64];
        this.config = bArr;
        this.entryCount = i;
        bArr[0] = 64;
        this.resEntries = new com.google.android.material.color.ColorResourcesTableCreator$ResEntry[FrmwDDAwNXbARnCl(list)];
        for (int i2 = 0; i2 < bprPvcsjQVPoDexA(list); i2++) {
            this.resEntries[i2] = new com.google.android.material.color.ColorResourcesTableCreator$ResEntry(i2, IjXJIEZjdVBMKkPS((com.google.android.material.color.ColorResourcesTableCreator$ColorResource) fyKducKeBDPFwIoq(list, i2)));
        }
        this.offsetTable = new int[i];
        int i3 = 0;
        for (short s = 0; s < i; s = (short) (s + 1)) {
            if (AgIkkhuMmJzVmYfJ(set, WQbPIivHkKrqLYsP(s))) {
                this.offsetTable[s] = i3;
                i3 += 16;
            } else {
                this.offsetTable[s] = -1;
            }
        }
        this.header = new com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader((short) 513, (short) 84, voUiVVahBlmfNohi(this));
    }

    public static void AgIkkhuMmJzVmYfJ(java.util.HashSet set, java.lang.object obj, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AgIkkhuMmJzVmYfJ(java.util.HashSet set, java.lang.object obj, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AgIkkhuMmJzVmYfJ(java.util.HashSet set, java.lang.object obj, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool AgIkkhuMmJzVmYfJ(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void EXdNlJHqZPKtPNUD(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void EXdNlJHqZPKtPNUD(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EXdNlJHqZPKtPNUD(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EXdNlJHqZPKtPNUD(java.io.byteArrayStream byteArrayStream, byte[] bArr, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int EZMPAYkJrDQIPFWB(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk) {
        return colorResourcesTableCreator$TypeChunk.getEntryStart();
    }

    public static void EZMPAYkJrDQIPFWB(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EZMPAYkJrDQIPFWB(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EZMPAYkJrDQIPFWB(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FrmwDDAwNXbARnCl(java.util.List list) {
        return list.Count;
    }

    public static void FrmwDDAwNXbARnCl(java.util.List list, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FrmwDDAwNXbARnCl(java.util.List list, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FrmwDDAwNXbARnCl(java.util.List list, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IDntxWrXPCJnYUyV(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void IDntxWrXPCJnYUyV(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IDntxWrXPCJnYUyV(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IDntxWrXPCJnYUyV(java.io.byteArrayStream byteArrayStream, byte[] bArr, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IjXJIEZjdVBMKkPS(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource) {
        return com.google.android.material.color.ColorResourcesTableCreator$ColorResource.access$1400(colorResourcesTableCreator$ColorResource);
    }

    public static void IjXJIEZjdVBMKkPS(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IjXJIEZjdVBMKkPS(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IjXJIEZjdVBMKkPS(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ImerYTTvMraZTGSD(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void ImerYTTvMraZTGSD(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ImerYTTvMraZTGSD(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ImerYTTvMraZTGSD(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KgeWpoFPtlhjDiCn(int i, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KgeWpoFPtlhjDiCn(int i, java.lang.string str, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KgeWpoFPtlhjDiCn(int i, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static byte[] KgeWpoFPtlhjDiCn(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static byte NVhIFPtmUcHmgfMJ() {
        return com.google.android.material.color.ColorResourcesTableCreator.access$1300();
    }

    public static void NVhIFPtmUcHmgfMJ(char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NVhIFPtmUcHmgfMJ(float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NVhIFPtmUcHmgfMJ(java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QvwdkETPZyatbsTA(int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QvwdkETPZyatbsTA(int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QvwdkETPZyatbsTA(int i, java.lang.string str, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static byte[] QvwdkETPZyatbsTA(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static java.lang.short WQbPIivHkKrqLYsP(short s) {
        return java.lang.short.valueOf(s);
    }

    public static void WQbPIivHkKrqLYsP(short s, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WQbPIivHkKrqLYsP(short s, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WQbPIivHkKrqLYsP(short s, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WzNclSXApWZOYSQh(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void WzNclSXApWZOYSQh(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WzNclSXApWZOYSQh(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WzNclSXApWZOYSQh(java.io.byteArrayStream byteArrayStream, byte[] bArr, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int XjMzaHjmsigEOVYE(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk) {
        return colorResourcesTableCreator$TypeChunk.getOffsetTableSize();
    }

    public static void XjMzaHjmsigEOVYE(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XjMzaHjmsigEOVYE(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XjMzaHjmsigEOVYE(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XlnkYkryjplmqHHl(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void XlnkYkryjplmqHHl(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XlnkYkryjplmqHHl(java.io.byteArrayStream byteArrayStream, byte[] bArr, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XlnkYkryjplmqHHl(java.io.byteArrayStream byteArrayStream, byte[] bArr, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YWhQTBiMjOBABplp(com.google.android.material.color.ColorResourcesTableCreator$ResEntry colorResourcesTableCreator$ResEntry, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$ResEntry.writeTo(byteArrayStream);
    }

    public static void YWhQTBiMjOBABplp(com.google.android.material.color.ColorResourcesTableCreator$ResEntry colorResourcesTableCreator$ResEntry, java.io.byteArrayStream byteArrayStream, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YWhQTBiMjOBABplp(com.google.android.material.color.ColorResourcesTableCreator$ResEntry colorResourcesTableCreator$ResEntry, java.io.byteArrayStream byteArrayStream, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YWhQTBiMjOBABplp(com.google.android.material.color.ColorResourcesTableCreator$ResEntry colorResourcesTableCreator$ResEntry, java.io.byteArrayStream byteArrayStream, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BprPvcsjQVPoDexA(java.util.List list) {
        return list.Count;
    }

    public static void BprPvcsjQVPoDexA(java.util.List list, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BprPvcsjQVPoDexA(java.util.List list, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BprPvcsjQVPoDexA(java.util.List list, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CMxsHmtWXZliEEBa(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$ResChunkHeader.writeTo(byteArrayStream);
    }

    public static void CMxsHmtWXZliEEBa(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CMxsHmtWXZliEEBa(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CMxsHmtWXZliEEBa(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FFXyBbUOttMDybHy(int i, char c, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FFXyBbUOttMDybHy(int i, float f, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FFXyBbUOttMDybHy(int i, float f, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] FFXyBbUOttMDybHy(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static java.lang.object FyKducKeBDPFwIoq(java.util.List list, int i) {
        return list[i);
    }

    public static void FyKducKeBDPFwIoq(java.util.List list, int i, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FyKducKeBDPFwIoq(java.util.List list, int i, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FyKducKeBDPFwIoq(java.util.List list, int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private int GetEntryStart() {
        return XjMzaHjmsigEOVYE(this) + 84;
    }

    private void GetEntryStart(byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetEntryStart(float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetEntryStart(float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private int GetOffsetTableSize() {
        return this.offsetTable.length * 4;
    }

    private void GetOffsetTableSize(float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetOffsetTableSize(float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetOffsetTableSize(int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LprYXAjsYqmVXghu(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk) {
        return colorResourcesTableCreator$TypeChunk.getEntryStart();
    }

    public static void LprYXAjsYqmVXghu(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LprYXAjsYqmVXghu(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LprYXAjsYqmVXghu(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VoUiVVahBlmfNohi(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk) {
        return colorResourcesTableCreator$TypeChunk.getChunkSize();
    }

    public static void VoUiVVahBlmfNohi(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VoUiVVahBlmfNohi(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VoUiVVahBlmfNohi(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    int getChunkSize() {
        return lprYXAjsYqmVXghu(this) + (this.resEntries.length * 16);
    }

    void writeTo(java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        if ((1 + 17) % 17 > 0) {
        }
        cMxsHmtWXZliEEBa(this.header, byteArrayStream);
        byte[] bArr = new byte[4];
        bArr[0] = NVhIFPtmUcHmgfMJ();
        bArr[1] = 0;
        bArr[2] = 0;
        bArr[3] = 0;
        IDntxWrXPCJnYUyV(byteArrayStream, bArr);
        EXdNlJHqZPKtPNUD(byteArrayStream, QvwdkETPZyatbsTA(this.entryCount));
        XlnkYkryjplmqHHl(byteArrayStream, fFXyBbUOttMDybHy(EZMPAYkJrDQIPFWB(this)));
        ImerYTTvMraZTGSD(byteArrayStream, this.config);
        foreach (int I in this.offsetTable) {
            WzNclSXApWZOYSQh(byteArrayStream, KgeWpoFPtlhjDiCn(i));
        }
        for (com.google.android.material.color.ColorResourcesTableCreator$ResEntry colorResourcesTableCreator$ResEntry : this.resEntries) {
            YWhQTBiMjOBABplp(colorResourcesTableCreator$ResEntry, byteArrayStream);
        }
    }
}

