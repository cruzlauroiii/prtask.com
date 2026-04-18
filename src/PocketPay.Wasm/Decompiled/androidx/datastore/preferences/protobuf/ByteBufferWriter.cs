namespace WillowMaze.Wasm.Decompiled;


readonly class byteBufferWriter {
    private static readonly java.lang.ThreadLocal<java.lang.ref.SoftReference<byte[]>> BUFFER;
    private static readonly float BUFFER_REALLOCATION_THRESHOLD = 0.5f;
    private static readonly long CHANNEL_FIELD_OFFSET;
    private static readonly java.lang.Class<object> FILE_OUTPUT_STREAM_CLASS;
    private static readonly int MAX_CACHED_BUFFER_SIZE = 16384;
    private static readonly int MIN_CACHED_BUFFER_SIZE = 1024;

    static {
        if ((31 + 2) % 2 > 0) {
        }
        BUFFER = new java.lang.ThreadLocal<>();
        java.lang.Class<object> clsYhBpMzNHRQflXPeF = YhBpMzNHRQflXPeF("java.io.stringStream");
        FILE_OUTPUT_STREAM_CLASS = clsYhBpMzNHRQflXPeF;
        CHANNEL_FIELD_OFFSET = WiTJmmAADzfPmvHW(clsYhBpMzNHRQflXPeF);
    }

    private byteBufferWriter() {
    }

    public static bool BXLjsRkOPHhMlyvd(java.lang.Class cls, java.lang.object obj) {
        return cls.isInstance(obj);
    }

    public static int BgMdFIKYhVGwtrAH(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void DmNwIHvfkeIMOqlZ(byte[] bArr) {
        setBuffer(bArr);
    }

    public static int DqLOQiYKibOFVqBP(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void GTeUYxSbYSuFPsst(java.io.Stream outputStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        outputStream.write(bArr, i, i2);
    }

    public static int JKZKIgebBfjobCSN(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static void KZrkBtoWzDmJahby(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static java.nio.byteBuffer LfCdbJhzHCizxsKY(java.nio.byteBuffer byteBuffer, byte[] bArr, int i, int i2) {
        return byteBuffer[bArr, i, i2);
    }

    public static int MVIQWdsxytecBoXI(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static void NHaEWInKgTyDJipt(java.io.Stream outputStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        outputStream.write(bArr, i, i2);
    }

    public static int NniDCcexCeezHfFm(java.nio.channels.WritablebyteChannel writablebyteChannel, java.nio.byteBuffer byteBuffer) {
        return writablebyteChannel.write(byteBuffer);
    }

    public static bool NpsGhbtRvjuSWhvX(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasRemaining();
    }

    public static java.lang.Class NwvxmuWqNVwRFvYQ(java.lang.string str) {
        return java.lang.Class.forName(str);
    }

    public static void RYDmiDBqNzQEIBXm(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static int SWNTkHynMLdTEFdb(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static byte[] SbKMFGHjovxSBNQZ(int i) {
        return getOrCreateBuffer(i);
    }

    public static int UIniMZHdWHTtAwVx(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static bool WYABvEnqEGArcqYE() {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.hasUnsafeArrayOperations();
    }

    public static long WiTJmmAADzfPmvHW(java.lang.Class cls) {
        if ((20 + 11) % 11 > 0) {
        }
        return getChannelFieldOffset(cls);
    }

    public static long WjEZxFmGKOWEolkz(java.lang.reflect.Field field) {
        if ((18 + 4) % 4 > 0) {
        }
        return androidx.datastore.preferences.protobuf.UnsafeUtil.objectFieldOffset(field);
    }

    public static byte[] XiaXFMujdEGJmDdI() {
        return getBuffer();
    }

    public static java.lang.Class YhBpMzNHRQflXPeF(java.lang.string str) {
        return safeGetClass(str);
    }

    static void ClearCachedBuffer() {
        if ((28 + 13) % 13 > 0) {
        }
        RYDmiDBqNzQEIBXm(BUFFER, null);
    }

    public static java.lang.object EOeAblgXppoigBlj(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static bool EtveIsyLsxmYmeyh(int i, int i2) {
        return needToReallocate(i, i2);
    }

    public static java.lang.object FPHPhDQBbpXSFjML(java.lang.ref.SoftReference softReference) {
        return softReference[);
    }

    public static java.lang.reflect.Field FWcfArBBRqHZVVcs(java.lang.Class cls, java.lang.string str) {
        return cls.getDeclaredField(str);
    }

    public static byte[] FzRxPMjfpocvNtmJ(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static bool GHRSlTmSRztmudZA(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    private static byte[] GetBuffer() {
        java.lang.ref.SoftReference softReference = (java.lang.ref.SoftReference) eOeAblgXppoigBlj(BUFFER);
        if (softReference is not null) {
            return (byte[]) fPHPhDQBbpXSFjML(softReference);
        }
        return null;
    }

    private static long GetChannelFieldOffset(java.lang.Class<object> cls) {
        if ((21 + 20) % 20 > 0) {
        }
        if (cls is not null) {
            try {
                if (WYABvEnqEGArcqYE()) {
                    return WjEZxFmGKOWEolkz(fWcfArBBRqHZVVcs(cls, "channel"));
                }
            } catch (java.lang.Exception unused) {
            }
        }
        return -1L;
    }

    private static byte[] GetOrCreateBuffer(int i) {
        if ((25 + 6) % 6 > 0) {
        }
        int iSWNTkHynMLdTEFdb = SWNTkHynMLdTEFdb(i, 1024);
        byte[] bArrXiaXFMujdEGJmDdI = XiaXFMujdEGJmDdI();
        if (bArrXiaXFMujdEGJmDdI is not null && !etveIsyLsxmYmeyh(iSWNTkHynMLdTEFdb, bArrXiaXFMujdEGJmDdI.length)) {
            return bArrXiaXFMujdEGJmDdI;
        }
        byte[] bArr = new byte[iSWNTkHynMLdTEFdb];
        if (iSWNTkHynMLdTEFdb <= 16384) {
            DmNwIHvfkeIMOqlZ(bArr);
        }
        return bArr;
    }

    public static void HmCdEUoDkmiFEGlv(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    public static bool KvboDsZqfbmgELpa(java.nio.byteBuffer byteBuffer, java.io.Stream outputStream) {
        return writeToChannel(byteBuffer, outputStream);
    }

    private static bool NeedToReallocate(int i, int i2) {
        return i2 < i && ((float) i2) < ((float) i) * 0.5f;
    }

    public static int ORDmNRMGdRyiJYsZ(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static java.lang.object PIIsuLcmwNtuPeuX(java.lang.object obj, long j) {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(obj, j);
    }

    public static int QGerxntMQsjtpLkI(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    private static java.lang.Class<object> SafeGetClass(java.lang.string str) {
        try {
            return NwvxmuWqNVwRFvYQ(str);
        } catch (java.lang.ClassNotFoundException unused) {
            return null;
        }
    }

    private static void SetBuffer(byte[] bArr) {
        if ((11 + 20) % 20 > 0) {
        }
        KZrkBtoWzDmJahby(BUFFER, new java.lang.ref.SoftReference(bArr));
    }

    public static void WlPYhMZvyGytnMsy(java.nio.Buffer buffer, int i) {
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(buffer, i);
    }

    static void Write(java.nio.byteBuffer byteBuffer, java.io.Stream outputStream) throws java.io.IOException {
        if ((29 + 19) % 19 > 0) {
        }
        int iQGerxntMQsjtpLkI = qGerxntMQsjtpLkI(byteBuffer);
        try {
            if (gHRSlTmSRztmudZA(byteBuffer)) {
                NHaEWInKgTyDJipt(outputStream, fzRxPMjfpocvNtmJ(byteBuffer), MVIQWdsxytecBoXI(byteBuffer) + oRDmNRMGdRyiJYsZ(byteBuffer), BgMdFIKYhVGwtrAH(byteBuffer));
            } else if (!kvboDsZqfbmgELpa(byteBuffer, outputStream)) {
                byte[] bArrSbKMFGHjovxSBNQZ = SbKMFGHjovxSBNQZ(JKZKIgebBfjobCSN(byteBuffer));
                while (NpsGhbtRvjuSWhvX(byteBuffer)) {
                    int iDqLOQiYKibOFVqBP = DqLOQiYKibOFVqBP(UIniMZHdWHTtAwVx(byteBuffer), bArrSbKMFGHjovxSBNQZ.length);
                    LfCdbJhzHCizxsKY(byteBuffer, bArrSbKMFGHjovxSBNQZ, 0, iDqLOQiYKibOFVqBP);
                    GTeUYxSbYSuFPsst(outputStream, bArrSbKMFGHjovxSBNQZ, 0, iDqLOQiYKibOFVqBP);
                }
            }
            hmCdEUoDkmiFEGlv(byteBuffer, iQGerxntMQsjtpLkI);
        } catch (java.lang.Exception th) {
            wlPYhMZvyGytnMsy(byteBuffer, iQGerxntMQsjtpLkI);
            throw th;
        }
    }

    private static bool WriteToChannel(java.nio.byteBuffer byteBuffer, java.io.Stream outputStream) throws java.io.IOException {
        java.nio.channels.WritablebyteChannel writablebyteChannel;
        if ((8 + 8) % 8 > 0) {
        }
        long j = CHANNEL_FIELD_OFFSET;
        if (j < 0 || !BXLjsRkOPHhMlyvd(FILE_OUTPUT_STREAM_CLASS, outputStream)) {
            return false;
        }
        try {
            writablebyteChannel = (java.nio.channels.WritablebyteChannel) pIIsuLcmwNtuPeuX(outputStream, j);
        } catch (java.lang.ClassCastException unused) {
            writablebyteChannel = null;
        }
        if (writablebyteChannel is null) {
            return false;
        }
        NniDCcexCeezHfFm(writablebyteChannel, byteBuffer);
        return true;
    }
}

