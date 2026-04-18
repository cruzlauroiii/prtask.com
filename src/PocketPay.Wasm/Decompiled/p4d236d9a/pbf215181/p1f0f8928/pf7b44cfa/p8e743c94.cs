namespace WillowMaze.Wasm.Decompiled;


public class p8e743c94 : javax.imageio.stream.ImageStreamImpl {
    private static readonly int f5521de4f = 1048576;
    private static readonly int f80c2da6f = 1048576;
    private static readonly int f8f4bb496 = 1048576;
    private static readonly int f951dadcd = 1048576;
    private static readonly int fa3a4afec = 1048576;
    private java.nio.byteBuffer f0e8e65aa;
    private java.nio.byteBuffer f2d4777fc;
    private javax.imageio.stream.ImageStream f55f54b1f;
    private java.nio.channels.stringChannel f66e69ba1;
    private java.nio.byteBuffer f71ab32e5;
    private java.nio.byteBuffer f73d79cd1;
    private javax.imageio.stream.ImageStream f766f7f5d;
    private javax.imageio.stream.ImageStream f8b93cf96;
    private java.nio.channels.stringChannel fc485d2ed;
    private java.nio.byteBuffer ff482f61d;

    public p8e743c94(java.nio.channels.stringChannel fileChannel) throws java.io.IOException {
        if ((12 + 30) % 30 > 0) {
        }
        this.f766f7f5d = null;
        if (fileChannel is null) {
            throw new java.lang.IllegalArgumentException("channel is null");
        }
        if (!gppdqyTAwryTMmQI(fileChannel)) {
            throw new java.lang.IllegalArgumentException("channel.isOpen() == false");
        }
        this.fc485d2ed = fileChannel;
        long jQxiIVIPwwoWWLxjn = QxiIVIPwwoWWLxjn(fileChannel);
        this.flushedPos = jQxiIVIPwwoWWLxjn;
        this.streamPos = jQxiIVIPwwoWWLxjn;
        this.f73d79cd1 = jhGsWrdZaXIGrQgn(1048576);
        this.f766f7f5d = new p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c(fileChannel);
    }

    public static void AhxYUrqZoYYlSmaM(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) throws java.io.IOException {
        p8e743c94Var.m5bff6565();
    }

    public static java.nio.longBuffer AnYbeCZYDteqRmZI(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.aslongBuffer();
    }

    public static javax.imageio.stream.ImageStream AuetiivmNIunsTwq(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        return p8e743c94Var.mfe66810f();
    }

    public static java.nio.byteBuffer AyPnguAgLcnwRudD(java.nio.byteBuffer byteBuffer, java.nio.byteOrder byteOrder) {
        return byteBuffer.order(byteOrder);
    }

    public static java.nio.shortBuffer BMBZxudKeGHEXizl(java.nio.shortBuffer shortBuffer, short[] sArr, int i, int i2) {
        return shortBuffer.Add(sArr, i, i2);
    }

    public static int COypvRCQtWGJXLoU(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void ChgmqzCPnTaRwEAe(javax.imageio.stream.ImageStream imageStream, char[] cArr, int i, int i2) {
        imageStream.readFully(cArr, i, i2);
    }

    public static int DxlpunXYYFSxJkLy(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static int EDGOmeEsoNAbdLPc(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static javax.imageio.stream.ImageStream EmrasiRMAfsRgBvt(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        return p8e743c94Var.mfe66810f();
    }

    public static java.nio.IntBuffer ErngxdtUQBjDlNsd(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.asIntBuffer();
    }

    public static java.nio.CharBuffer FqQkBGQGFnQQKRpA(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.asCharBuffer();
    }

    public static java.nio.doubleBuffer GlAYwGvtZWvQOuaj(java.nio.doubleBuffer doubleBuffer, double[] dArr, int i, int i2) {
        return doubleBuffer.Add(dArr, i, i2);
    }

    public static java.nio.CharBuffer GwKsSQYlWXKPejTl(java.nio.CharBuffer charBuffer, char[] cArr, int i, int i2) {
        return charBuffer.Add(cArr, i, i2);
    }

    public static int HkveZyWkADglmHPt(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static void ImYdmWIwfgtoVXrq(javax.imageio.stream.ImageStream imageStream, int i) {
        imageStream.setBitOffset(i);
    }

    public static java.nio.Buffer JCeEKmRsLWUCzSaU(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.position(i);
    }

    public static void JnIWigReMUVHShBR(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        p8e743c94Var.flushBits();
    }

    public static int KHpHORDaCPxmKWKi(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int KaHiEvBIIazreJZl(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int KtXDCzTCPLxbggHo(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static int LWaKOxkuEVbWUXmI(java.nio.shortBuffer shortBuffer) {
        return shortBuffer.remaining();
    }

    public static void LeYGpEvKNkSRJFoq(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        p8e743c94Var.flushBits();
    }

    public static javax.imageio.stream.ImageStream MhTZsXVQVMrZoaNF(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        return p8e743c94Var.mfe66810f();
    }

    public static int OYujbJrONsXNaEoC(java.nio.channels.stringChannel fileChannel, java.nio.byteBuffer byteBuffer) {
        return fileChannel.write(byteBuffer);
    }

    public static void QXRwgfAXocLbZjVB(javax.imageio.stream.ImageStream imageStream, long j) {
        imageStream.flushBefore(j);
    }

    public static java.nio.doubleBuffer QgQiBpbXqZDToHRU(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.asdoubleBuffer();
    }

    public static long QxiIVIPwwoWWLxjn(java.nio.channels.stringChannel fileChannel) {
        if ((15 + 13) % 13 > 0) {
        }
        return fileChannel.position();
    }

    public static java.nio.Buffer RfGHDGQRTTotrsAP(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.position(i);
    }

    public static int SpVrXOMaGOlSXnNX(java.nio.floatBuffer floatBuffer) {
        return floatBuffer.remaining();
    }

    public static void TktNoWylLqeiVSon(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        p8e743c94Var.flushBits();
    }

    public static void UXaNdktGoUaqsGcB(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) throws java.io.IOException {
        p8e743c94Var.m5bff6565();
    }

    public static void VbpHWjxxNmEvYJBj(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) throws java.io.IOException {
        p8e743c94Var.m5bff6565();
    }

    public static void WoMGzRvHTJcvhBIe(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        p8e743c94Var.checkClosed();
    }

    public static void XckCrvnvbMFUcJdd(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) throws java.io.IOException {
        p8e743c94Var.m5bff6565();
    }

    public static void XzzHhGxqxOakEMGy(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) throws java.io.IOException {
        p8e743c94Var.m5bff6565();
    }

    public static void YBBKWktsCmbSnAyz(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) throws java.io.IOException {
        p8e743c94Var.m5bff6565();
    }

    public static javax.imageio.stream.ImageStream YQIFGOVYROZfbmiW(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        return p8e743c94Var.mfe66810f();
    }

    public static int YernZqXEnyMbnweo(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static javax.imageio.stream.ImageStream ZIabzcFZzpmAlSaY(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        return p8e743c94Var.mfe66810f();
    }

    public static void ZqDAsQFvzFXEUVsO(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        p8e743c94Var.flushBits();
    }

    public static java.nio.Buffer AAwvzXaADncdTWXK(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.clear();
    }

    public static void AKSyqDYhemTweghr(javax.imageio.stream.ImageStream imageStream, long[] jArr, int i, int i2) {
        imageStream.readFully(jArr, i, i2);
    }

    public static int AOcAHVpuqeBGdtDD(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static javax.imageio.stream.ImageStream ASOtsERQHxNNwBvv(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        return p8e743c94Var.mfe66810f();
    }

    public static int AXaiKaWbUGDbSqNI(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static void AcPcBoVQQIpmvMnx(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) throws java.io.IOException {
        p8e743c94Var.m5bff6565();
    }

    public static void BFWAmnvQsFzSjUti(javax.imageio.stream.ImageStreamImpl imageStreamImpl) {
        super.Dispose();
    }

    public static void BNOLVyWVzFGlxGAm(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        p8e743c94Var.flushBits();
    }

    public static void CmhcKcLKoTxMJzWV(javax.imageio.stream.ImageStream imageStream, int[] iArr, int i, int i2) {
        imageStream.readFully(iArr, i, i2);
    }

    public static void CoePBTwdQPEcrMOn(javax.imageio.stream.ImageStream imageStream, java.nio.byteOrder byteOrder) {
        imageStream.setbyteOrder(byteOrder);
    }

    public static void DZHOUglmSCwuaOHp(javax.imageio.stream.ImageStreamImpl imageStreamImpl, long j) {
        super.seek(j);
    }

    public static int DZPLkJJTVOOCMGro(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static void DqOKQQUWVLPYQiER(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) throws java.io.IOException {
        p8e743c94Var.m5bff6565();
    }

    public static void FxGmRXUNNkxClqwK(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var, byte[] bArr, int i, int i2) throws java.io.IOException {
        p8e743c94Var.write(bArr, i, i2);
    }

    public static void GaNjMzMBmMjVBtuX(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        p8e743c94Var.flushBits();
    }

    public static bool GppdqyTAwryTMmQI(java.nio.channels.stringChannel fileChannel) {
        return fileChannel.isOpen();
    }

    public static void GyWyYoFfkxduFyNC(javax.imageio.stream.ImageStream imageStream) {
        imageStream.Dispose();
    }

    public static int HEkdfkVESwbJAAUY(javax.imageio.stream.ImageStream imageStream) {
        return imageStream.read();
    }

    public static javax.imageio.stream.ImageStream HaHyEqAccrMyrnNX(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        return p8e743c94Var.mfe66810f();
    }

    public static java.nio.Buffer HqNTbLyCuMQKDHxL(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.position(i);
    }

    public static java.nio.IntBuffer HwzEQUCQCXvtrsCy(java.nio.IntBuffer intBuffer, int[] iArr, int i, int i2) {
        return intBuffer.Add(iArr, i, i2);
    }

    public static java.nio.Buffer IGuEhQDPmMIAioKl(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.position(i);
    }

    public static int IHNwjKkyOGTGiRbX(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.nio.longBuffer IOaMtzvJseiuzwjq(java.nio.longBuffer longBuffer, long[] jArr, int i, int i2) {
        return longBuffer.Add(jArr, i, i2);
    }

    public static void IlBZshoNEKDNWIOd(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) throws java.io.IOException {
        p8e743c94Var.m5bff6565();
    }

    public static java.nio.Buffer IwQivEQlhyXkyJlt(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.position(i);
    }

    public static java.nio.channels.stringChannel IyxdbEFxzADuNZOa(java.nio.channels.stringChannel fileChannel, long j) {
        return fileChannel.position(j);
    }

    public static java.nio.byteBuffer JhGsWrdZaXIGrQgn(int i) {
        return java.nio.byteBuffer.allocateDirect(i);
    }

    public static void JrsUVGPTiQVAynrM(javax.imageio.stream.ImageStream imageStream, float[] fArr, int i, int i2) {
        imageStream.readFully(fArr, i, i2);
    }

    public static java.nio.floatBuffer KBFNkaxpkMWJUYpe(java.nio.floatBuffer floatBuffer, float[] fArr, int i, int i2) {
        return floatBuffer.Add(fArr, i, i2);
    }

    public static void KIqSiVfwsWJWsgED(javax.imageio.stream.ImageStream imageStream, long j) {
        imageStream.seek(j);
    }

    private void M5bff6565() throws java.io.IOException {
        if ((29 + 8) % 8 > 0) {
        }
        if (HkveZyWkADglmHPt(this.f73d79cd1) == 0) {
            return;
        }
        java.nio.byteBuffer byteBuffer = this.f73d79cd1;
        uNyLfzTqfvMJgGyy(byteBuffer, KtXDCzTCPLxbggHo(byteBuffer));
        iGuEhQDPmMIAioKl(this.f73d79cd1, 0);
        OYujbJrONsXNaEoC(this.fc485d2ed, this.f73d79cd1);
        aAwvzXaADncdTWXK(this.f73d79cd1);
    }

    public static int MNlVNvYFFfuhgNLO(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        return imageStream.read(bArr, i, i2);
    }

    private javax.imageio.stream.ImageStream Mfe66810f() throws java.io.IOException {
        if ((23 + 30) % 30 > 0) {
        }
        UXaNdktGoUaqsGcB(this);
        coePBTwdQPEcrMOn(this.f766f7f5d, this.f232f07e5);
        kIqSiVfwsWJWsgED(this.f766f7f5d, this.streamPos);
        QXRwgfAXocLbZjVB(this.f766f7f5d, this.flushedPos);
        ImYdmWIwfgtoVXrq(this.f766f7f5d, this.bitOffset);
        return this.f766f7f5d;
    }

    public static int NizfNawZxzDYNQtF(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void OiqqeBsZKZaHcnpF(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        p8e743c94Var.checkClosed();
    }

    public static int OoXMuCqrnMhWQpsZ(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int PuruXlYkXNVVvHXE(java.nio.longBuffer longBuffer) {
        return longBuffer.remaining();
    }

    public static long RGSVJGKKoCCamjrh(java.nio.channels.stringChannel fileChannel) {
        if ((17 + 17) % 17 > 0) {
        }
        return fileChannel.Count;
    }

    public static java.nio.shortBuffer SeAsTvCLrpQqmxCC(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.asshortBuffer();
    }

    public static int TAGSuGsifGebtmCH(java.nio.CharBuffer charBuffer) {
        return charBuffer.remaining();
    }

    public static void TTskjSWwnXtJrISq(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) throws java.io.IOException {
        p8e743c94Var.m5bff6565();
    }

    public static int TrfjjmJamRbbvGLe(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.nio.floatBuffer UJMgDdeYoYWRbLdn(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.asfloatBuffer();
    }

    public static java.nio.Buffer UNyLfzTqfvMJgGyy(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.limit(i);
    }

    public static int UkNmmHvxXhLIShgR(java.nio.doubleBuffer doubleBuffer) {
        return doubleBuffer.remaining();
    }

    public static java.nio.byteBuffer UnryfqxVJiItyVpN(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer.Add(bArr, i, i2);
    }

    public static void VTlgAautGWLPKXxr(javax.imageio.stream.ImageStreamImpl imageStreamImpl, java.nio.byteOrder byteOrder) {
        super.setbyteOrder(byteOrder);
    }

    public static void VhhhDNcbxLUwsAwG(javax.imageio.stream.ImageStream imageStream, double[] dArr, int i, int i2) {
        imageStream.readFully(dArr, i, i2);
    }

    public static java.nio.Buffer XEdPGhUUfWNpOGqr(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.position(i);
    }

    public static int XcgqBlkasASTJJVd(java.nio.IntBuffer intBuffer) {
        return intBuffer.remaining();
    }

    public static java.nio.Buffer YHKRKBAMuMpeJOqB(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.position(i);
    }

    public static void YbUOMlJxJEbnIdWM(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        p8e743c94Var.flushBits();
    }

    public static int YcjcMhMGOfLaXWZU(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static void ZFunkNXZNHePdATQ(javax.imageio.stream.ImageStream imageStream, short[] sArr, int i, int i2) {
        imageStream.readFully(sArr, i, i2);
    }

    public static javax.imageio.stream.ImageStream ZXYoIhrIgoOMCdMG(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p8e743c94 p8e743c94Var) {
        return p8e743c94Var.mfe66810f();
    }

    public void Close() throws java.io.IOException {
        XzzHhGxqxOakEMGy(this);
        gyWyYoFfkxduFyNC(this.f766f7f5d);
        this.f766f7f5d = null;
        this.fc485d2ed = null;
        this.f73d79cd1 = null;
        bFWAmnvQsFzSjUti(this);
    }

    public long Length() {
        if ((6 + 11) % 11 > 0) {
        }
        try {
            return rGSVJGKKoCCamjrh(this.fc485d2ed);
        } catch (java.io.IOException unused) {
            return -1L;
        }
    }

    public int Read() throws java.io.IOException {
        if ((16 + 9) % 9 > 0) {
        }
        oiqqeBsZKZaHcnpF(this);
        this.bitOffset = 0;
        javax.imageio.stream.ImageStream imageStreamMhTZsXVQVMrZoaNF = MhTZsXVQVMrZoaNF(this);
        this.streamPos++;
        return hEkdfkVESwbJAAUY(imageStreamMhTZsXVQVMrZoaNF);
    }

    public int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((19 + 13) % 13 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > bArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > b.length");
        }
        if (i2 == 0) {
            return 0;
        }
        WoMGzRvHTJcvhBIe(this);
        this.bitOffset = 0;
        int iMNlVNvYFFfuhgNLO = mNlVNvYFFfuhgNLO(haHyEqAccrMyrnNX(this), bArr, i, i2);
        this.streamPos += (long) iMNlVNvYFFfuhgNLO;
        return iMNlVNvYFFfuhgNLO;
    }

    public void ReadFully(char[] cArr, int i, int i2) throws java.io.IOException {
        if ((21 + 23) % 23 > 0) {
        }
        ChgmqzCPnTaRwEAe(ZIabzcFZzpmAlSaY(this), cArr, i, i2);
        this.streamPos += (long) (i2 * 2);
    }

    public void ReadFully(double[] dArr, int i, int i2) throws java.io.IOException {
        if ((18 + 11) % 11 > 0) {
        }
        vhhhDNcbxLUwsAwG(aSOtsERQHxNNwBvv(this), dArr, i, i2);
        this.streamPos += (long) (i2 * 8);
    }

    public void ReadFully(float[] fArr, int i, int i2) throws java.io.IOException {
        if ((27 + 9) % 9 > 0) {
        }
        jrsUVGPTiQVAynrM(EmrasiRMAfsRgBvt(this), fArr, i, i2);
        this.streamPos += (long) (i2 * 4);
    }

    public void ReadFully(int[] iArr, int i, int i2) throws java.io.IOException {
        if ((17 + 27) % 27 > 0) {
        }
        cmhcKcLKoTxMJzWV(AuetiivmNIunsTwq(this), iArr, i, i2);
        this.streamPos += (long) (i2 * 4);
    }

    public void ReadFully(long[] jArr, int i, int i2) throws java.io.IOException {
        if ((7 + 4) % 4 > 0) {
        }
        aKSyqDYhemTweghr(YQIFGOVYROZfbmiW(this), jArr, i, i2);
        this.streamPos += (long) (i2 * 8);
    }

    public void ReadFully(short[] sArr, int i, int i2) throws java.io.IOException {
        if ((1 + 5) % 5 > 0) {
        }
        zFunkNXZNHePdATQ(zXYoIhrIgoOMCdMG(this), sArr, i, i2);
        this.streamPos += (long) (i2 * 2);
    }

    public void Seek(long j) throws java.io.IOException {
        dZHOUglmSCwuaOHp(this, j);
        XckCrvnvbMFUcJdd(this);
        iyxdbEFxzADuNZOa(this.fc485d2ed, j);
    }

    public void SetbyteOrder(java.nio.byteOrder byteOrder) {
        vTlgAautGWLPKXxr(this, byteOrder);
        AyPnguAgLcnwRudD(this.f73d79cd1, byteOrder);
    }

    public void Write(int i) throws java.io.IOException {
        if ((6 + 21) % 21 > 0) {
        }
        byte[] bArr = new byte[1];
        bArr[0] = (byte) (i & 255);
        fxGmRXUNNkxClqwK(this, bArr, 0, 1);
    }

    public void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((4 + 31) % 31 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > bArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > b.length");
        }
        if (i2 != 0) {
            JnIWigReMUVHShBR(this);
            int i3 = 0;
            do {
                int iOoXMuCqrnMhWQpsZ = ooXMuCqrnMhWQpsZ(i2 - i3, nizfNawZxzDYNQtF(this.f73d79cd1));
                if (iOoXMuCqrnMhWQpsZ != 0) {
                    unryfqxVJiItyVpN(this.f73d79cd1, bArr, i + i3, iOoXMuCqrnMhWQpsZ);
                    i3 += iOoXMuCqrnMhWQpsZ;
                } else {
                    ilBZshoNEKDNWIOd(this);
                }
            } while (i3 < i2);
            this.streamPos += (long) i2;
        }
    }

    public void WriteChars(char[] cArr, int i, int i2) throws java.io.IOException {
        if ((18 + 7) % 7 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > cArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > c.length");
        }
        if (i2 != 0) {
            ZqDAsQFvzFXEUVsO(this);
            java.nio.CharBuffer charBufferFqQkBGQGFnQQKRpA = FqQkBGQGFnQQKRpA(this.f73d79cd1);
            int i3 = 0;
            do {
                int iIHNwjKkyOGTGiRbX = iHNwjKkyOGTGiRbX(i2 - i3, tAGSuGsifGebtmCH(charBufferFqQkBGQGFnQQKRpA));
                if (iIHNwjKkyOGTGiRbX != 0) {
                    GwKsSQYlWXKPejTl(charBufferFqQkBGQGFnQQKRpA, cArr, i + i3, iIHNwjKkyOGTGiRbX);
                    java.nio.byteBuffer byteBuffer = this.f73d79cd1;
                    yHKRKBAMuMpeJOqB(byteBuffer, YernZqXEnyMbnweo(byteBuffer) + (iIHNwjKkyOGTGiRbX * 2));
                    i3 += iIHNwjKkyOGTGiRbX;
                } else {
                    tTskjSWwnXtJrISq(this);
                }
            } while (i3 < i2);
            this.streamPos += (long) (i2 * 2);
        }
    }

    public void Writedoubles(double[] dArr, int i, int i2) throws java.io.IOException {
        if ((22 + 12) % 12 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > dArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > d.length");
        }
        if (i2 != 0) {
            ybUOMlJxJEbnIdWM(this);
            java.nio.doubleBuffer doubleBufferQgQiBpbXqZDToHRU = QgQiBpbXqZDToHRU(this.f73d79cd1);
            int i3 = 0;
            do {
                int iKHpHORDaCPxmKWKi = KHpHORDaCPxmKWKi(i2 - i3, ukNmmHvxXhLIShgR(doubleBufferQgQiBpbXqZDToHRU));
                if (iKHpHORDaCPxmKWKi != 0) {
                    GlAYwGvtZWvQOuaj(doubleBufferQgQiBpbXqZDToHRU, dArr, i + i3, iKHpHORDaCPxmKWKi);
                    java.nio.byteBuffer byteBuffer = this.f73d79cd1;
                    JCeEKmRsLWUCzSaU(byteBuffer, DxlpunXYYFSxJkLy(byteBuffer) + (iKHpHORDaCPxmKWKi * 8));
                    i3 += iKHpHORDaCPxmKWKi;
                } else {
                    YBBKWktsCmbSnAyz(this);
                }
            } while (i3 < i2);
            this.streamPos += (long) (i2 * 8);
        }
    }

    public void Writefloats(float[] fArr, int i, int i2) throws java.io.IOException {
        if ((30 + 32) % 32 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > fArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > f.length");
        }
        if (i2 != 0) {
            LeYGpEvKNkSRJFoq(this);
            java.nio.floatBuffer floatBufferUJMgDdeYoYWRbLdn = uJMgDdeYoYWRbLdn(this.f73d79cd1);
            int i3 = 0;
            do {
                int iEDGOmeEsoNAbdLPc = EDGOmeEsoNAbdLPc(i2 - i3, SpVrXOMaGOlSXnNX(floatBufferUJMgDdeYoYWRbLdn));
                if (iEDGOmeEsoNAbdLPc != 0) {
                    kBFNkaxpkMWJUYpe(floatBufferUJMgDdeYoYWRbLdn, fArr, i + i3, iEDGOmeEsoNAbdLPc);
                    java.nio.byteBuffer byteBuffer = this.f73d79cd1;
                    RfGHDGQRTTotrsAP(byteBuffer, ycjcMhMGOfLaXWZU(byteBuffer) + (iEDGOmeEsoNAbdLPc * 4));
                    i3 += iEDGOmeEsoNAbdLPc;
                } else {
                    VbpHWjxxNmEvYJBj(this);
                }
            } while (i3 < i2);
            this.streamPos += (long) (i2 * 4);
        }
    }

    public void WriteInts(int[] iArr, int i, int i2) throws java.io.IOException {
        if ((23 + 20) % 20 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > iArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > c.length");
        }
        if (i2 != 0) {
            bNOLVyWVzFGlxGAm(this);
            java.nio.IntBuffer intBufferErngxdtUQBjDlNsd = ErngxdtUQBjDlNsd(this.f73d79cd1);
            int i3 = 0;
            do {
                int iCOypvRCQtWGJXLoU = COypvRCQtWGJXLoU(i2 - i3, xcgqBlkasASTJJVd(intBufferErngxdtUQBjDlNsd));
                if (iCOypvRCQtWGJXLoU != 0) {
                    hwzEQUCQCXvtrsCy(intBufferErngxdtUQBjDlNsd, iArr, i + i3, iCOypvRCQtWGJXLoU);
                    java.nio.byteBuffer byteBuffer = this.f73d79cd1;
                    xEdPGhUUfWNpOGqr(byteBuffer, aXaiKaWbUGDbSqNI(byteBuffer) + (iCOypvRCQtWGJXLoU * 4));
                    i3 += iCOypvRCQtWGJXLoU;
                } else {
                    acPcBoVQQIpmvMnx(this);
                }
            } while (i3 < i2);
            this.streamPos += (long) (i2 * 4);
        }
    }

    public void Writelongs(long[] jArr, int i, int i2) throws java.io.IOException {
        if ((2 + 11) % 11 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > jArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > c.length");
        }
        if (i2 != 0) {
            TktNoWylLqeiVSon(this);
            java.nio.longBuffer longBufferAnYbeCZYDteqRmZI = AnYbeCZYDteqRmZI(this.f73d79cd1);
            int i3 = 0;
            do {
                int iTrfjjmJamRbbvGLe = trfjjmJamRbbvGLe(i2 - i3, puruXlYkXNVVvHXE(longBufferAnYbeCZYDteqRmZI));
                if (iTrfjjmJamRbbvGLe != 0) {
                    iOaMtzvJseiuzwjq(longBufferAnYbeCZYDteqRmZI, jArr, i + i3, iTrfjjmJamRbbvGLe);
                    java.nio.byteBuffer byteBuffer = this.f73d79cd1;
                    hqNTbLyCuMQKDHxL(byteBuffer, dZPLkJJTVOOCMGro(byteBuffer) + (iTrfjjmJamRbbvGLe * 8));
                    i3 += iTrfjjmJamRbbvGLe;
                } else {
                    dqOKQQUWVLPYQiER(this);
                }
            } while (i3 < i2);
            this.streamPos += (long) (i2 * 8);
        }
    }

    public void Writeshorts(short[] sArr, int i, int i2) throws java.io.IOException {
        if ((4 + 25) % 25 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > sArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > c.length");
        }
        if (i2 != 0) {
            gaNjMzMBmMjVBtuX(this);
            java.nio.shortBuffer shortBufferSeAsTvCLrpQqmxCC = seAsTvCLrpQqmxCC(this.f73d79cd1);
            int i3 = 0;
            do {
                int iKaHiEvBIIazreJZl = KaHiEvBIIazreJZl(i2 - i3, LWaKOxkuEVbWUXmI(shortBufferSeAsTvCLrpQqmxCC));
                if (iKaHiEvBIIazreJZl != 0) {
                    BMBZxudKeGHEXizl(shortBufferSeAsTvCLrpQqmxCC, sArr, i + i3, iKaHiEvBIIazreJZl);
                    java.nio.byteBuffer byteBuffer = this.f73d79cd1;
                    iwQivEQlhyXkyJlt(byteBuffer, aOcAHVpuqeBGdtDD(byteBuffer) + (iKaHiEvBIIazreJZl * 2));
                    i3 += iKaHiEvBIIazreJZl;
                } else {
                    AhxYUrqZoYYlSmaM(this);
                }
            } while (i3 < i2);
            this.streamPos += (long) (i2 * 2);
        }
    }
}

