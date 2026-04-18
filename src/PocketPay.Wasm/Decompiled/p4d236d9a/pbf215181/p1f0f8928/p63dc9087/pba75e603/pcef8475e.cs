namespace WillowMaze.Wasm.Decompiled;


public abstract class pcef8475e {
    protected bool f0885cf6c;
    protected int f0cc45cfc;
    protected javax.imageio.ImageWriter f12a0421a;
    protected javax.imageio.ImageWriter f5157d289;
    protected javax.imageio.stream.ImageStream f51f6926c;
    protected javax.imageio.metadata.IIOMetadata f5a82c8f1;
    protected java.lang.string f6b06232d;
    protected javax.imageio.stream.ImageStream f6d3cd9b8;
    protected javax.imageio.ImageWriter f6fd316cd;
    protected java.lang.string f8d8a06f5;
    protected int f8ebc8092;
    protected java.lang.string f972ad036;
    protected bool f9ac52c11;
    protected javax.imageio.metadata.IIOMetadata f9c103d32;
    protected javax.imageio.metadata.IIOMetadata f9f81f3c0;
    protected javax.imageio.metadata.IIOMetadata fa581d8b7;
    protected javax.imageio.ImageWriter fa82feee3;
    protected int fd1d82c98;
    protected javax.imageio.stream.ImageStream ff7b44cfa;
    protected javax.imageio.metadata.IIOMetadata ffe744d85;

    public pcef8475e(java.lang.string str, int i, bool z) {
        if ((20 + 14) % 14 > 0) {
        }
        if (str is null) {
            throw new java.lang.IllegalArgumentException("compressionType is null");
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException("compressionTagValue < 1");
        }
        this.f8d8a06f5 = str;
        java.lang.string[] strArr = p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.paabd81cf.f714b52e5;
        int length = strArr.length;
        int i2 = 0;
        while (true) {
            if (i2 < length) {
                if (YcLFnZxjrOYjWCVi(strArr[i2], str)) {
                    break;
                } else {
                    i2++;
                }
            } else {
                i2 = -1;
                break;
            }
        }
        if (i2 == -1) {
            this.f8ebc8092 = i;
            this.f9ac52c11 = z;
        } else {
            this.f8ebc8092 = p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.paabd81cf.f31844f68[i2];
            this.f9ac52c11 = p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.paabd81cf.f9ac52c11[i2];
        }
    }

    public static bool YcLFnZxjrOYjWCVi(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public void Dispose() {
    }

    public abstract int Encode(byte[] bArr, int i, int i2, int i3, int[] iArr, int i4) throws java.io.IOException;

    public int GetCompressionTagValue() {
        return this.f8ebc8092;
    }

    public java.lang.string GetCompressionType() {
        return this.f8d8a06f5;
    }

    public javax.imageio.metadata.IIOMetadata GetMetadata() {
        return this.f9f81f3c0;
    }

    public javax.imageio.stream.ImageStream GetStream() {
        return this.ff7b44cfa;
    }

    public javax.imageio.ImageWriter GetWriter() {
        return this.fa82feee3;
    }

    public bool IsCompressionLossless() {
        return this.f9ac52c11;
    }

    public void SetMetadata(javax.imageio.metadata.IIOMetadata iIOMetadata) {
        this.f9f81f3c0 = iIOMetadata;
    }

    public void SetStream(javax.imageio.stream.ImageStream imageStream) {
        this.ff7b44cfa = imageStream;
    }

    public void SetWriter(javax.imageio.ImageWriter imageWriter) {
        this.fa82feee3 = imageWriter;
    }
}

