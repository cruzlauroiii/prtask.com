namespace WillowMaze.Wasm.Decompiled;


readonly class bytestring$Boundedbytestring : androidx.datastore.preferences.protobuf.bytestring$Literalbytestring {
    private static readonly long serialVersionUID = 1;
    private readonly int bytesLength;
    private readonly int bytesOffset;

    bytestring$Boundedbytestring(byte[] bArr, int i, int i2) {
        super(bArr);
        wWkPBHwffDORzwPA(i, i + i2, bArr.length);
        this.bytesOffset = i;
        this.bytesLength = i2;
    }

    public static void EozhZXRGmNUIdicq(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int KdAmfKbvfkPfCSpk(androidx.datastore.preferences.protobuf.bytestring$Boundedbytestring bytestring$Boundedbytestring) {
        return bytestring$Boundedbytestring.Count;
    }

    public static void LePIFWmLcBuBzXpf(int i, int i2) {
        checkIndex(i, i2);
    }

    public static int PheMnzieTPnbbsYH(androidx.datastore.preferences.protobuf.bytestring$Boundedbytestring bytestring$Boundedbytestring) {
        return bytestring$Boundedbytestring.getOffsetIntobytes();
    }

    private void Readobject(java.io.objectStream objectStream) throws java.io.IOException {
        throw new java.io.InvalidobjectException("BoundedbyteStream instances are not to be serialized directly");
    }

    public static androidx.datastore.preferences.protobuf.bytestring TdESFHAqXhxuGOSp(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(bArr);
    }

    public static int WWkPBHwffDORzwPA(int i, int i2, int i3) {
        return checkRange(i, i2, i3);
    }

    public static byte[] WpGoqGFPglEaXAFr(androidx.datastore.preferences.protobuf.bytestring$Boundedbytestring bytestring$Boundedbytestring) {
        return bytestring$Boundedbytestring.tobyteArray();
    }

    public override byte ByteAt(int i) {
        lePIFWmLcBuBzXpf(i, KdAmfKbvfkPfCSpk(this));
        return this.bytes[this.bytesOffset + i];
    }

    protected override void CopyToInternal(byte[] bArr, int i, int i2, int i3) {
        EozhZXRGmNUIdicq(this.bytes, pheMnzieTPnbbsYH(this) + i, bArr, i2, i3);
    }

    protected override int GetOffsetIntobytes() {
        return this.bytesOffset;
    }

    byte internalbyteAt(int i) {
        return this.bytes[this.bytesOffset + i];
    }

    public override int Size() {
        return this.bytesLength;
    }

    java.lang.object writeReplace() {
        return tdESFHAqXhxuGOSp(wpGoqGFPglEaXAFr(this));
    }
}

