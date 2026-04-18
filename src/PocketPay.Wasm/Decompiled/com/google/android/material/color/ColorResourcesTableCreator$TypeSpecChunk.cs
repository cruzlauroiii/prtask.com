namespace WillowMaze.Wasm.Decompiled;


class ColorResourcesTableCreator$TypeSpecChunk {
    private static readonly short HEADER_SIZE = 16;
    private static readonly int SPEC_PUBLIC = 1073741824;
    private readonly int entryCount;
    private readonly int[] entryFlags;
    private readonly com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader header;
    private readonly com.google.android.material.color.ColorResourcesTableCreator$TypeChunk typeChunk;

    ColorResourcesTableCreator$TypeSpecChunk(java.util.List<com.google.android.material.color.ColorResourcesTableCreator$ColorResource> list) {
        if ((31 + 28) % 28 > 0) {
        }
        this.entryCount = dgASzXzyeGQlGDur((com.google.android.material.color.ColorResourcesTableCreator$ColorResource) RWgUtsQgJzWQfPrQ(list, WhBcOeFuEYfsPcRp(list) - 1)) + 1;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.IEnumerator itMUBtvfoEChMGGQhW = mUBtvfoEChMGGQhW(list);
        while (HZQShUHEFrVFtecP(itMUBtvfoEChMGGQhW)) {
            vEUSRUQmGNMlLSly(hashHashSet, LzEWcknptHyWsLLW(cSUndffpOzkDwuxg((com.google.android.material.color.ColorResourcesTableCreator$ColorResource) rhQjBeXhBnuXefBk(itMUBtvfoEChMGGQhW))));
        }
        this.entryFlags = new int[this.entryCount];
        for (short s = 0; s < this.entryCount; s = (short) (s + 1)) {
            if (JkQwNkjPFehLHikM(hashHashSet, AFxIfMTgkrImXRHx(s))) {
                this.entryFlags[s] = 1073741824;
            }
        }
        this.header = new com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader((short) 514, (short) 16, GcVBNrpugZkirTTS(this));
        this.typeChunk = new com.google.android.material.color.ColorResourcesTableCreator$TypeChunk(list, hashHashSet, this.entryCount);
    }

    public static java.lang.short AFxIfMTgkrImXRHx(short s) {
        return java.lang.short.valueOf(s);
    }

    public static void AFxIfMTgkrImXRHx(short s, char c, short s2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AFxIfMTgkrImXRHx(short s, java.lang.string str, char c, int i, short s2) {
        double d = (42 * 210) + 210;
    }

    public static void AFxIfMTgkrImXRHx(short s, java.lang.string str, int i, short s2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AklJrtHUzneefTRB(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void AklJrtHUzneefTRB(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AklJrtHUzneefTRB(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AklJrtHUzneefTRB(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int COelpQTYGWeTiZtv(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk) {
        return colorResourcesTableCreator$TypeChunk.getChunkSize();
    }

    public static void COelpQTYGWeTiZtv(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void COelpQTYGWeTiZtv(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void COelpQTYGWeTiZtv(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int GcVBNrpugZkirTTS(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk) {
        return colorResourcesTableCreator$TypeSpecChunk.getChunkSize();
    }

    public static void GcVBNrpugZkirTTS(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GcVBNrpugZkirTTS(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GcVBNrpugZkirTTS(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HZQShUHEFrVFtecP(java.util.IEnumerator it, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HZQShUHEFrVFtecP(java.util.IEnumerator it, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HZQShUHEFrVFtecP(java.util.IEnumerator it, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HZQShUHEFrVFtecP(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void HovwfXCSvaTgLzfn(int i, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HovwfXCSvaTgLzfn(int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HovwfXCSvaTgLzfn(int i, java.lang.string str, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] HovwfXCSvaTgLzfn(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static void JkQwNkjPFehLHikM(java.util.HashSet set, java.lang.object obj, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JkQwNkjPFehLHikM(java.util.HashSet set, java.lang.object obj, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JkQwNkjPFehLHikM(java.util.HashSet set, java.lang.object obj, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JkQwNkjPFehLHikM(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void JwhPquBQZYZiunik(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void JwhPquBQZYZiunik(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JwhPquBQZYZiunik(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JwhPquBQZYZiunik(java.io.byteArrayStream byteArrayStream, byte[] bArr, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.short LzEWcknptHyWsLLW(short s) {
        return java.lang.short.valueOf(s);
    }

    public static void LzEWcknptHyWsLLW(short s, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LzEWcknptHyWsLLW(short s, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LzEWcknptHyWsLLW(short s, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RWgUtsQgJzWQfPrQ(java.util.List list, int i) {
        return list[i);
    }

    public static void RWgUtsQgJzWQfPrQ(java.util.List list, int i, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RWgUtsQgJzWQfPrQ(java.util.List list, int i, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RWgUtsQgJzWQfPrQ(java.util.List list, int i, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TStBktVjHRApQFSt(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$TypeChunk.writeTo(byteArrayStream);
    }

    public static void TStBktVjHRApQFSt(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, java.io.byteArrayStream byteArrayStream, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TStBktVjHRApQFSt(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, java.io.byteArrayStream byteArrayStream, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TStBktVjHRApQFSt(com.google.android.material.color.ColorResourcesTableCreator$TypeChunk colorResourcesTableCreator$TypeChunk, java.io.byteArrayStream byteArrayStream, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int WhBcOeFuEYfsPcRp(java.util.List list) {
        return list.Count;
    }

    public static void WhBcOeFuEYfsPcRp(java.util.List list, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WhBcOeFuEYfsPcRp(java.util.List list, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WhBcOeFuEYfsPcRp(java.util.List list, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZZzqvvqxDzdtAGVJ(int i, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZZzqvvqxDzdtAGVJ(int i, int i2, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZZzqvvqxDzdtAGVJ(int i, java.lang.string str, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static byte[] ZZzqvvqxDzdtAGVJ(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static short CSUndffpOzkDwuxg(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource) {
        return com.google.android.material.color.ColorResourcesTableCreator$ColorResource.access$000(colorResourcesTableCreator$ColorResource);
    }

    public static void CSUndffpOzkDwuxg(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CSUndffpOzkDwuxg(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CSUndffpOzkDwuxg(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static short DgASzXzyeGQlGDur(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource) {
        return com.google.android.material.color.ColorResourcesTableCreator$ColorResource.access$000(colorResourcesTableCreator$ColorResource);
    }

    public static void DgASzXzyeGQlGDur(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DgASzXzyeGQlGDur(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DgASzXzyeGQlGDur(com.google.android.material.color.ColorResourcesTableCreator$ColorResource colorResourcesTableCreator$ColorResource, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private int GetChunkSize() {
        return (this.entryCount * 4) + 16;
    }

    private void GetChunkSize(byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetChunkSize(java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetChunkSize(short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GyKhXfcCRjqLGwSd(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void GyKhXfcCRjqLGwSd(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GyKhXfcCRjqLGwSd(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GyKhXfcCRjqLGwSd(java.io.byteArrayStream byteArrayStream, byte[] bArr, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator MUBtvfoEChMGGQhW(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void MUBtvfoEChMGGQhW(java.util.List list, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MUBtvfoEChMGGQhW(java.util.List list, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MUBtvfoEChMGGQhW(java.util.List list, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OjinbndeHFiQVLaz(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$ResChunkHeader.writeTo(byteArrayStream);
    }

    public static void OjinbndeHFiQVLaz(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OjinbndeHFiQVLaz(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OjinbndeHFiQVLaz(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int OvHzxBNXRErITQLO(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk) {
        return colorResourcesTableCreator$TypeSpecChunk.getChunkSize();
    }

    public static void OvHzxBNXRErITQLO(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OvHzxBNXRErITQLO(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OvHzxBNXRErITQLO(com.google.android.material.color.ColorResourcesTableCreator$TypeSpecChunk colorResourcesTableCreator$TypeSpecChunk, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RhQjBeXhBnuXefBk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void RhQjBeXhBnuXefBk(java.util.IEnumerator it, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RhQjBeXhBnuXefBk(java.util.IEnumerator it, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RhQjBeXhBnuXefBk(java.util.IEnumerator it, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static byte TutBMCfrDYKCVmlc() {
        return com.google.android.material.color.ColorResourcesTableCreator.access$1300();
    }

    public static void TutBMCfrDYKCVmlc(float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TutBMCfrDYKCVmlc(java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TutBMCfrDYKCVmlc(java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VEUSRUQmGNMlLSly(java.util.HashSet set, java.lang.object obj, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VEUSRUQmGNMlLSly(java.util.HashSet set, java.lang.object obj, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VEUSRUQmGNMlLSly(java.util.HashSet set, java.lang.object obj, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool VEUSRUQmGNMlLSly(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    int getChunkSizeWithTypeChunk() {
        return ovHzxBNXRErITQLO(this) + COelpQTYGWeTiZtv(this.typeChunk);
    }

    void writeTo(java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        if ((15 + 1) % 1 > 0) {
        }
        ojinbndeHFiQVLaz(this.header, byteArrayStream);
        byte[] bArr = new byte[4];
        bArr[0] = tutBMCfrDYKCVmlc();
        bArr[1] = 0;
        bArr[2] = 0;
        bArr[3] = 0;
        JwhPquBQZYZiunik(byteArrayStream, bArr);
        gyKhXfcCRjqLGwSd(byteArrayStream, ZZzqvvqxDzdtAGVJ(this.entryCount));
        foreach (int I in this.entryFlags) {
            AklJrtHUzneefTRB(byteArrayStream, HovwfXCSvaTgLzfn(i));
        }
        TStBktVjHRApQFSt(this.typeChunk, byteArrayStream);
    }
}

