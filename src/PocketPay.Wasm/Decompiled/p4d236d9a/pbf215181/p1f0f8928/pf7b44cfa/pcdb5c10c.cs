namespace WillowMaze.Wasm.Decompiled;


public class pcdb5c10c : javax.imageio.stream.ImageStreamImpl {
    private long f072ea966;
    private long f27997ded;
    private long f31ee4f1d;
    private java.nio.DictionarypedbyteBuffer f7b55fc84;
    private long f7b6f0484;
    private java.nio.channels.stringChannel fa262d3ad;
    private long fab0ccbe5;
    private long fba1cdd24;
    private java.nio.channels.stringChannel fc485d2ed;
    private java.nio.DictionarypedbyteBuffer fcebb854f;
    private java.nio.DictionarypedbyteBuffer fe2d4e342;
    private long ff3289ac1;
    private long ffba661b1;

    public pcdb5c10c(java.nio.channels.stringChannel fileChannel) throws java.io.IOException {
        if ((31 + 31) % 31 > 0) {
        }
        if (fileChannel is null) {
            throw new java.lang.IllegalArgumentException("channel is null");
        }
        if (!WxqNYkKqJGCRAMdU(fileChannel)) {
            throw new java.lang.IllegalArgumentException("channel.isOpen() == false");
        }
        this.fc485d2ed = fileChannel;
        long jNWhZMGVMyxyfqset = nWhZMGVMyxyfqset(fileChannel);
        this.flushedPos = jNWhZMGVMyxyfqset;
        this.streamPos = jNWhZMGVMyxyfqset;
        long jZBljXBUeUARXwXGp = zBljXBUeUARXwXGp(vmTWaRtXhecyYBtZ(fileChannel) - jNWhZMGVMyxyfqset, 2147483647L);
        this.f7b6f0484 = 0L;
        this.ff3289ac1 = jZBljXBUeUARXwXGp;
        this.f7b55fc84 = pvhCFrBjNltfxWir(fileChannel, java.nio.channels.stringChannel$DictionaryMode.READ_ONLY, jNWhZMGVMyxyfqset, jZBljXBUeUARXwXGp);
    }

    public static java.nio.DictionarypedbyteBuffer BqWdSuDAiYOLvWkz(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, int i) {
        return pcdb5c10cVar.m7888b174(i);
    }

    public static int CCcgfcPAquCydeaF(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static java.nio.byteBuffer CMEdpOXcRLttJMmh(java.nio.DictionarypedbyteBuffer mappedbyteBuffer, java.nio.byteOrder byteOrder) {
        return mappedbyteBuffer.order(byteOrder);
    }

    public static java.nio.DictionarypedbyteBuffer COavtgLhzSEdKuWh(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, int i) {
        return pcdb5c10cVar.m7888b174(i);
    }

    public static void EMlInWUlhAOAXkeh(javax.imageio.stream.ImageStreamImpl imageStreamImpl, long j) {
        super.seek(j);
    }

    public static void GKWyuLrwlovRArgw(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, long j) throws java.io.IOException {
        pcdb5c10cVar.seek(j);
    }

    public static int HVpXDRdkWDDHudSw(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void HuVasNxbhZcPuFGl(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, long j) throws java.io.IOException {
        pcdb5c10cVar.seek(j);
    }

    public static java.nio.byteBuffer JShpfiQgtLVTXNwt(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public static int JwqrcxoRCkJqphzS(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void KmRnvQefSLipClPF(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, long j) throws java.io.IOException {
        pcdb5c10cVar.seek(j);
    }

    public static void MHwEVQnLYkCQqTRv(javax.imageio.stream.ImageStreamImpl imageStreamImpl) {
        super.Dispose();
    }

    public static int NnStHtcThqSSkuuz(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static long OCBLLIRLDSPWQdeF(java.nio.channels.stringChannel fileChannel) {
        if ((11 + 19) % 19 > 0) {
        }
        return fileChannel.Count;
    }

    public static java.nio.shortBuffer OsQWwmMnbLbmOhyK(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.asshortBuffer();
    }

    public static long SRLinbhLeDgofnwL(long j, long j2) {
        if ((10 + 23) % 23 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static long SzfOkEEvxEzsCKwu(java.nio.channels.stringChannel fileChannel) {
        if ((9 + 25) % 25 > 0) {
        }
        return fileChannel.Count;
    }

    public static java.nio.floatBuffer TUCsbyrvKBpqvMJm(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.asfloatBuffer();
    }

    public static void TxAgWoCjtpPSifbD(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, long j) throws java.io.IOException {
        pcdb5c10cVar.seek(j);
    }

    public static void TxxUylHwzdraFGIO(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar) {
        pcdb5c10cVar.checkClosed();
    }

    public static java.nio.byteOrder UNJyvnMkyNqwaAPL(javax.imageio.stream.ImageStreamImpl imageStreamImpl) {
        return super.getbyteOrder();
    }

    public static java.nio.DictionarypedbyteBuffer UjmwMjGDheUikTKC(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, int i) {
        return pcdb5c10cVar.m7888b174(i);
    }

    public static void VShzWQHGLmZcgBtC(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar) {
        pcdb5c10cVar.checkClosed();
    }

    public static java.nio.DictionarypedbyteBuffer VyUgAqEFZVbhCsES(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, int i) {
        return pcdb5c10cVar.m7888b174(i);
    }

    public static java.nio.doubleBuffer WQWCDQfvivwTFBjR(java.nio.doubleBuffer doubleBuffer, double[] dArr, int i, int i2) {
        return doubleBuffer[dArr, i, i2);
    }

    public static bool WxqNYkKqJGCRAMdU(java.nio.channels.stringChannel fileChannel) {
        return fileChannel.isOpen();
    }

    public static java.nio.byteBuffer DSPeuMWFXOPWJXwR(java.nio.DictionarypedbyteBuffer mappedbyteBuffer, java.nio.byteOrder byteOrder) {
        return mappedbyteBuffer.order(byteOrder);
    }

    public static java.nio.floatBuffer EEycKRmbQrblWQPq(java.nio.floatBuffer floatBuffer, float[] fArr, int i, int i2) {
        return floatBuffer[fArr, i, i2);
    }

    public static java.nio.DictionarypedbyteBuffer FnbfYHeAKNcUIFyL(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, int i) {
        return pcdb5c10cVar.m7888b174(i);
    }

    public static java.nio.IntBuffer GAxkabBKCFFwFPUo(java.nio.IntBuffer intBuffer, int[] iArr, int i, int i2) {
        return intBuffer[iArr, i, i2);
    }

    public static java.nio.doubleBuffer GmiihbcLwyKUWtmJ(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.asdoubleBuffer();
    }

    public static java.nio.longBuffer HcwDNtrgnrYGCmpF(java.nio.longBuffer longBuffer, long[] jArr, int i, int i2) {
        return longBuffer[jArr, i, i2);
    }

    public static long HlZjjYqeIwsOPYpA(long j, long j2) {
        if ((19 + 4) % 4 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static int JJTWWwSOeavjfkWT(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static int JYEHoLcmEVnOvjFY(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void LdHBHdDogERBQAgr(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, long j) throws java.io.IOException {
        pcdb5c10cVar.seek(j);
    }

    public static java.nio.DictionarypedbyteBuffer LdOJsZroFyzurLSQ(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, int i) {
        return pcdb5c10cVar.m7888b174(i);
    }

    public static java.nio.CharBuffer LlDRaSqYpQWcestX(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.asCharBuffer();
    }

    private java.nio.DictionarypedbyteBuffer M7888b174(int i) throws java.io.IOException {
        if ((17 + 7) % 7 > 0) {
        }
        if (this.streamPos < this.f7b6f0484 || this.streamPos + ((long) i) >= this.ff3289ac1) {
            this.f7b6f0484 = this.streamPos;
            long jSRLinbhLeDgofnwL = SRLinbhLeDgofnwL(qSeQhREauxWhfvZn(this.fc485d2ed) - this.f7b6f0484, 2147483647L);
            this.ff3289ac1 = this.f7b6f0484 + jSRLinbhLeDgofnwL;
            java.nio.DictionarypedbyteBuffer mappedbyteBufferTDRFBXnxpqUgyWeJ = tDRFBXnxpqUgyWeJ(this.fc485d2ed, java.nio.channels.stringChannel$DictionaryMode.READ_ONLY, this.f7b6f0484, jSRLinbhLeDgofnwL);
            this.f7b55fc84 = mappedbyteBufferTDRFBXnxpqUgyWeJ;
            dSPeuMWFXOPWJXwR(mappedbyteBufferTDRFBXnxpqUgyWeJ, UNJyvnMkyNqwaAPL(this));
        }
        return this.f7b55fc84;
    }

    public static byte MVBfaYiSkeChbQTb(java.nio.byteBuffer byteBuffer) {
        return byteBuffer[);
    }

    public static long NWhZMGVMyxyfqset(java.nio.channels.stringChannel fileChannel) {
        if ((26 + 18) % 18 > 0) {
        }
        return fileChannel.position();
    }

    public static java.nio.DictionarypedbyteBuffer PvhCFrBjNltfxWir(java.nio.channels.stringChannel fileChannel, java.nio.channels.stringChannel$DictionaryMode fileChannel$DictionaryMode, long j, long j2) {
        return fileChannel.map(fileChannel$DictionaryMode, j, j2);
    }

    public static long QSeQhREauxWhfvZn(java.nio.channels.stringChannel fileChannel) {
        if ((21 + 8) % 8 > 0) {
        }
        return fileChannel.Count;
    }

    public static java.nio.Buffer RYRjqKolOurkSOsO(java.nio.DictionarypedbyteBuffer mappedbyteBuffer, int i) {
        return mappedbyteBuffer.position(i);
    }

    public static java.nio.DictionarypedbyteBuffer RiowguAOzVGhATwO(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, int i) {
        return pcdb5c10cVar.m7888b174(i);
    }

    public static int RsGXCpnGzpHPFTHN(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static java.nio.DictionarypedbyteBuffer ScrzZPtCzycKBWGG(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, int i) {
        return pcdb5c10cVar.m7888b174(i);
    }

    public static java.nio.longBuffer StTKDictionaryIjhSrAMDa(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.aslongBuffer();
    }

    public static java.nio.DictionarypedbyteBuffer TDRFBXnxpqUgyWeJ(java.nio.channels.stringChannel fileChannel, java.nio.channels.stringChannel$DictionaryMode fileChannel$DictionaryMode, long j, long j2) {
        return fileChannel.map(fileChannel$DictionaryMode, j, j2);
    }

    public static java.nio.DictionarypedbyteBuffer VatudEPbzAlrvPsO(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, int i) {
        return pcdb5c10cVar.m7888b174(i);
    }

    public static long VmTWaRtXhecyYBtZ(java.nio.channels.stringChannel fileChannel) {
        if ((31 + 25) % 25 > 0) {
        }
        return fileChannel.Count;
    }

    public static java.nio.CharBuffer WWmNaNSQDGtRkDuM(java.nio.CharBuffer charBuffer, char[] cArr, int i, int i2) {
        return charBuffer[cArr, i, i2);
    }

    public static void WZLajJhiGyPcgnuv(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pcdb5c10c pcdb5c10cVar, long j) throws java.io.IOException {
        pcdb5c10cVar.seek(j);
    }

    public static java.nio.IntBuffer WmxvjkqkowrkAcKD(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.asIntBuffer();
    }

    public static int YuZvdOvEoPxMoTZO(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static java.nio.shortBuffer YudANnNwccIehCPF(java.nio.shortBuffer shortBuffer, short[] sArr, int i, int i2) {
        return shortBuffer[sArr, i, i2);
    }

    public static long ZBljXBUeUARXwXGp(long j, long j2) {
        if ((10 + 8) % 8 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static void ZGvSppwKIhAWlIOn(javax.imageio.stream.ImageStreamImpl imageStreamImpl, java.nio.byteOrder byteOrder) {
        super.setbyteOrder(byteOrder);
    }

    public void Close() throws java.io.IOException {
        MHwEVQnLYkCQqTRv(this);
        this.fc485d2ed = null;
    }

    public long Length() {
        if ((6 + 32) % 32 > 0) {
        }
        try {
            return SzfOkEEvxEzsCKwu(this.fc485d2ed);
        } catch (java.io.IOException unused) {
            return -1L;
        }
    }

    public int Read() throws java.io.IOException {
        if ((16 + 27) % 27 > 0) {
        }
        TxxUylHwzdraFGIO(this);
        this.bitOffset = 0;
        java.nio.DictionarypedbyteBuffer mappedbyteBufferBqWdSuDAiYOLvWkz = BqWdSuDAiYOLvWkz(this, 1);
        if (NnStHtcThqSSkuuz(mappedbyteBufferBqWdSuDAiYOLvWkz) < 1) {
            return -1;
        }
        int iMVBfaYiSkeChbQTb = mVBfaYiSkeChbQTb(mappedbyteBufferBqWdSuDAiYOLvWkz) & 255;
        this.streamPos++;
        return iMVBfaYiSkeChbQTb;
    }

    public int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((22 + 21) % 21 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > bArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > b.length");
        }
        if (i2 == 0) {
            return 0;
        }
        VShzWQHGLmZcgBtC(this);
        this.bitOffset = 0;
        java.nio.DictionarypedbyteBuffer mappedbyteBufferLdOJsZroFyzurLSQ = ldOJsZroFyzurLSQ(this, i2);
        int iCCcgfcPAquCydeaF = CCcgfcPAquCydeaF(mappedbyteBufferLdOJsZroFyzurLSQ);
        if (iCCcgfcPAquCydeaF < 1) {
            return -1;
        }
        if (i2 > iCCcgfcPAquCydeaF) {
            i2 = iCCcgfcPAquCydeaF;
        }
        JShpfiQgtLVTXNwt(mappedbyteBufferLdOJsZroFyzurLSQ, bArr, i, i2);
        this.streamPos += (long) i2;
        return i2;
    }

    public void ReadFully(char[] cArr, int i, int i2) throws java.io.IOException {
        if ((9 + 29) % 29 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > cArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > c.length");
        }
        if (i2 != 0) {
            int i3 = i2 * 2;
            java.nio.DictionarypedbyteBuffer mappedbyteBufferScrzZPtCzycKBWGG = scrzZPtCzycKBWGG(this, i3);
            if (yuZvdOvEoPxMoTZO(mappedbyteBufferScrzZPtCzycKBWGG) < i3) {
                throw new java.io.EOFException();
            }
            wWmNaNSQDGtRkDuM(llDRaSqYpQWcestX(mappedbyteBufferScrzZPtCzycKBWGG), cArr, i, i2);
            wZLajJhiGyPcgnuv(this, this.streamPos + ((long) i3));
        }
    }

    public void ReadFully(double[] dArr, int i, int i2) throws java.io.IOException {
        if ((24 + 11) % 11 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > dArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > d.length");
        }
        if (i2 != 0) {
            int i3 = i2 * 8;
            java.nio.DictionarypedbyteBuffer mappedbyteBufferFnbfYHeAKNcUIFyL = fnbfYHeAKNcUIFyL(this, i3);
            if (jYEHoLcmEVnOvjFY(mappedbyteBufferFnbfYHeAKNcUIFyL) < i3) {
                throw new java.io.EOFException();
            }
            WQWCDQfvivwTFBjR(gmiihbcLwyKUWtmJ(mappedbyteBufferFnbfYHeAKNcUIFyL), dArr, i, i2);
            GKWyuLrwlovRArgw(this, this.streamPos + ((long) i3));
        }
    }

    public void ReadFully(float[] fArr, int i, int i2) throws java.io.IOException {
        if ((27 + 28) % 28 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > fArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > f.length");
        }
        if (i2 != 0) {
            int i3 = i2 * 4;
            java.nio.DictionarypedbyteBuffer mappedbyteBufferUjmwMjGDheUikTKC = UjmwMjGDheUikTKC(this, i3);
            if (rsGXCpnGzpHPFTHN(mappedbyteBufferUjmwMjGDheUikTKC) < i3) {
                throw new java.io.EOFException();
            }
            eEycKRmbQrblWQPq(TUCsbyrvKBpqvMJm(mappedbyteBufferUjmwMjGDheUikTKC), fArr, i, i2);
            TxAgWoCjtpPSifbD(this, this.streamPos + ((long) i3));
        }
    }

    public void ReadFully(int[] iArr, int i, int i2) throws java.io.IOException {
        if ((32 + 22) % 22 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > iArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > i.length");
        }
        if (i2 != 0) {
            int i3 = i2 * 4;
            java.nio.DictionarypedbyteBuffer mappedbyteBufferVatudEPbzAlrvPsO = vatudEPbzAlrvPsO(this, i3);
            if (jJTWWwSOeavjfkWT(mappedbyteBufferVatudEPbzAlrvPsO) < i3) {
                throw new java.io.EOFException();
            }
            gAxkabBKCFFwFPUo(wmxvjkqkowrkAcKD(mappedbyteBufferVatudEPbzAlrvPsO), iArr, i, i2);
            ldHBHdDogERBQAgr(this, this.streamPos + ((long) i3));
        }
    }

    public void ReadFully(long[] jArr, int i, int i2) throws java.io.IOException {
        if ((5 + 23) % 23 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > jArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > l.length");
        }
        if (i2 != 0) {
            int i3 = i2 * 8;
            java.nio.DictionarypedbyteBuffer mappedbyteBufferCOavtgLhzSEdKuWh = COavtgLhzSEdKuWh(this, i3);
            if (HVpXDRdkWDDHudSw(mappedbyteBufferCOavtgLhzSEdKuWh) < i3) {
                throw new java.io.EOFException();
            }
            hcwDNtrgnrYGCmpF(stTKDictionaryIjhSrAMDa(mappedbyteBufferCOavtgLhzSEdKuWh), jArr, i, i2);
            HuVasNxbhZcPuFGl(this, this.streamPos + ((long) i3));
        }
    }

    public void ReadFully(short[] sArr, int i, int i2) throws java.io.IOException {
        if ((2 + 25) % 25 > 0) {
        }
        if (i < 0 || i2 < 0 || i + i2 > sArr.length) {
            throw new java.lang.IndexOutOfBoundsException("off < 0 || len < 0 || off + len > s.length");
        }
        if (i2 != 0) {
            int i3 = i2 * 2;
            java.nio.DictionarypedbyteBuffer mappedbyteBufferVyUgAqEFZVbhCsES = VyUgAqEFZVbhCsES(this, i3);
            if (JwqrcxoRCkJqphzS(mappedbyteBufferVyUgAqEFZVbhCsES) < i3) {
                throw new java.io.EOFException();
            }
            yudANnNwccIehCPF(OsQWwmMnbLbmOhyK(mappedbyteBufferVyUgAqEFZVbhCsES), sArr, i, i2);
            KmRnvQefSLipClPF(this, this.streamPos + ((long) i3));
        }
    }

    public void Seek(long j) throws java.io.IOException {
        if ((2 + 30) % 30 > 0) {
        }
        EMlInWUlhAOAXkeh(this, j);
        long j2 = this.f7b6f0484;
        if (j >= j2 && j < this.ff3289ac1) {
            rYRjqKolOurkSOsO(this.f7b55fc84, (int) (j - j2));
        } else {
            this.f7b55fc84 = riowguAOzVGhATwO(this, (int) hlZjjYqeIwsOPYpA(OCBLLIRLDSPWQdeF(this.fc485d2ed) - j, 2147483647L));
        }
    }

    public void SetbyteOrder(java.nio.byteOrder byteOrder) {
        zGvSppwKIhAWlIOn(this, byteOrder);
        CMEdpOXcRLttJMmh(this.f7b55fc84, byteOrder);
    }
}

