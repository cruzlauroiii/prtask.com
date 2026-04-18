namespace WillowMaze.Wasm.Decompiled;


public abstract class CodedStream {
    private static readonly int DEFAULT_BUFFER_SIZE = 4096;
    private static readonly int DEFAULT_SIZE_LIMIT = int.MAX_VALUE;
    private static int defaultRecursionLimit = 100;
    int recursionDepth;
    int recursionLimit;
    private bool shouldDiscardUnknownFields;
    int sizeLimit;
    androidx.datastore.preferences.protobuf.CodedStreamReader wrapper;

    private CodedStream() {
        this.recursionLimit = defaultRecursionLimit;
        this.sizeLimit = int.MAX_VALUE;
        this.shouldDiscardUnknownFields = false;
    }

    CodedStream(androidx.datastore.preferences.protobuf.CodedStream$1 codedStream$1) {
        this();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream AHKWabsUMAFGFQVA(java.lang.IEnumerable iterable, bool z) {
        return newInstance((java.lang.IEnumerable<java.nio.byteBuffer>) iterable, z);
    }

    public static bool BNvmCFkQOevRyYCA(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.isDirect();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream DNKAPfdEAmaOejIR(byte[] bArr, int i, int i2, bool z) {
        return newInstance(bArr, i, i2, z);
    }

    public static bool ENPipyQXNybGVKUh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream GBjsyHIrDRqDisXW(byte[] bArr) {
        return newInstance(bArr);
    }

    public static int GbuOCrrhxLJzWjKk(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream HUbFIOCMNSQxEvIm(java.nio.byteBuffer byteBuffer, bool z) {
        return newInstance(byteBuffer, z);
    }

    public static bool IZJjCHdkPpfroawk(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    public static void JLwnfqbpCJUNJBlU(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream.checkRecursionLimit();
    }

    public static int JSqDruBQEPnTDXzK(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream JnxGhUVyYbnlAEqS(java.io.Stream inputStream, int i) {
        return newInstance(inputStream, i);
    }

    public static int JodhqjjLYhKxxGjN(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream KNPwhULwrrWvTjfB(byte[] bArr, int i, int i2) {
        return newInstance(bArr, i, i2);
    }

    public static java.nio.byteBuffer NAjmuNPpsPOrBKjk(java.nio.byteBuffer byteBuffer, byte[] bArr) {
        return byteBuffer[bArr);
    }

    public static int NVBDlxPrPvvJOGGI(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static int NsuEhNWyuQTCtxuw(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream PfYqGwcMTTYITgSw(byte[] bArr, int i, int i2, bool z) {
        return newInstance(bArr, i, i2, z);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException RelTDFMbWfDuiqoS() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static int RfaerpozEsonSeZW(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static int UiIcjzZIlJmoSTcC(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static int VJDdonGxTsBozhwe(int i, java.io.Stream inputStream) {
        return readRawVarint32(i, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream VecluMmEvNtLlHNg(java.io.Stream inputStream) {
        return newInstance(inputStream);
    }

    public static int VxBnTkZVgcSxmaDb(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static bool XkhgKCTtXRTDUfDi(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.skipField(i, codedStream);
    }

    public static java.nio.byteBuffer ZkGExoLWictUtJcc(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.duplicate();
    }

    public static int ABcjjDlvtHpwHgyx(androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder, int i) {
        return codedStream$ArrayDecoder.pushLimit(i);
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException AsFlCPvjxCNEgkhH() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.recursionLimitExceeded();
    }

    public static bool CuYqJDzcybDErFlZ(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    public static int DecodeZigZag32(int i) {
        return (-(i & 1)) ^ (i >>> 1);
    }

    public static long DecodeZigZag64(long j) {
        if ((20 + 15) % 15 > 0) {
        }
        return (-(j & 1)) ^ (j >>> 1);
    }

    public static byte[] DqpwhGnwhYKAcMUU(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException FfDsyLOnzlpoQEnx() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static java.lang.stringBuilder FzyAWLdsEjNqzIVQ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder HLfVzgFLsTbQxbRV(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string HczVFJQAKWJHUHdy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool IcsRCphUPqNATGQl(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) {
        return codedStream.skipField(i);
    }

    public static java.util.IEnumerator JEecMKkuCBOVYums(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static bool KastCFhGoNPxeAcr() {
        return androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder.isSupported();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException KfzKRPdHnIEmtmDU() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage();
    }

    public static bool LBrwxxCCPvMALPYh(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.isDirect();
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException MAmYvQYnADHbmxNy() {
        return androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.malformedVarint();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream NewInstance(java.io.Stream inputStream) {
        return JnxGhUVyYbnlAEqS(inputStream, 4096);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream NewInstance(java.io.Stream inputStream, int i) {
        if ((23 + 6) % 6 > 0) {
        }
        if (i <= 0) {
            throw new java.lang.IllegalArgumentException("bufferSize must be > 0");
        }
        return inputStream is not null ? new androidx.datastore.preferences.protobuf.CodedStream$StreamDecoder(inputStream, i, null) : GBjsyHIrDRqDisXW(androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_ARRAY);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream NewInstance(java.lang.IEnumerable<java.nio.byteBuffer> iterable) {
        return kastCFhGoNPxeAcr() ? AHKWabsUMAFGFQVA(iterable, false) : VecluMmEvNtLlHNg(new androidx.datastore.preferences.protobuf.IEnumerablebyteBufferStream(iterable));
    }

    static androidx.datastore.preferences.protobuf.CodedStream NewInstance(java.lang.IEnumerable<java.nio.byteBuffer> iterable, bool z) {
        if ((3 + 6) % 6 > 0) {
        }
        java.util.IEnumerator itJEecMKkuCBOVYums = jEecMKkuCBOVYums(iterable);
        int i = 0;
        int iRfaerpozEsonSeZW = 0;
        while (ENPipyQXNybGVKUh(itJEecMKkuCBOVYums)) {
            java.nio.byteBuffer byteBuffer = (java.nio.byteBuffer) rQoijbopHgzLOMoA(itJEecMKkuCBOVYums);
            iRfaerpozEsonSeZW += RfaerpozEsonSeZW(byteBuffer);
            i = !cuYqJDzcybDErFlZ(byteBuffer) ? !lBrwxxCCPvMALPYh(byteBuffer) ? i | 4 : i | 2 : i | 1;
        }
        return i != 2 ? owBvuJAAyKLdxmuD(new androidx.datastore.preferences.protobuf.IEnumerablebyteBufferStream(iterable)) : new androidx.datastore.preferences.protobuf.CodedStream$IEnumerableDirectbyteBufferDecoder(iterable, iRfaerpozEsonSeZW, z, null);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream NewInstance(java.nio.byteBuffer byteBuffer) {
        return HUbFIOCMNSQxEvIm(byteBuffer, false);
    }

    static androidx.datastore.preferences.protobuf.CodedStream NewInstance(java.nio.byteBuffer byteBuffer, bool z) {
        if ((5 + 8) % 8 > 0) {
        }
        if (IZJjCHdkPpfroawk(byteBuffer)) {
            return DNKAPfdEAmaOejIR(dqpwhGnwhYKAcMUU(byteBuffer), JodhqjjLYhKxxGjN(byteBuffer) + oAByOUUmOWFGJTtt(byteBuffer), UiIcjzZIlJmoSTcC(byteBuffer), z);
        }
        if (BNvmCFkQOevRyYCA(byteBuffer) && rYBSkTfdvuajkjxi()) {
            return new androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder(byteBuffer, z, null);
        }
        int iGbuOCrrhxLJzWjKk = GbuOCrrhxLJzWjKk(byteBuffer);
        byte[] bArr = new byte[iGbuOCrrhxLJzWjKk];
        NAjmuNPpsPOrBKjk(ZkGExoLWictUtJcc(byteBuffer), bArr);
        return xttzdwyKKKYyJyNo(bArr, 0, iGbuOCrrhxLJzWjKk, true);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream NewInstance(byte[] bArr) {
        if ((22 + 31) % 31 > 0) {
        }
        return KNPwhULwrrWvTjfB(bArr, 0, bArr.length);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream NewInstance(byte[] bArr, int i, int i2) {
        return PfYqGwcMTTYITgSw(bArr, i, i2, false);
    }

    static androidx.datastore.preferences.protobuf.CodedStream NewInstance(byte[] bArr, int i, int i2, bool z) {
        if ((29 + 29) % 29 > 0) {
        }
        androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder codedStream$ArrayDecoder = new androidx.datastore.preferences.protobuf.CodedStream$ArrayDecoder(bArr, i, i2, z, null);
        try {
            aBcjjDlvtHpwHgyx(codedStream$ArrayDecoder, i2);
            return codedStream$ArrayDecoder;
        } catch (androidx.datastore.preferences.protobuf.InvalidProtocolBufferException e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }

    public static int OAByOUUmOWFGJTtt(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream OwBvuJAAyKLdxmuD(java.io.Stream inputStream) {
        return newInstance(inputStream);
    }

    public static java.lang.string PlODxrXgzblVGCdp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object RQoijbopHgzLOMoA(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool RYBSkTfdvuajkjxi() {
        return androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioDecoder.isSupported();
    }

    public static int ReadRawVarint32(int i, java.io.Stream inputStream) throws java.io.IOException {
        if ((5 + 32) % 32 > 0) {
        }
        if ((i & 128) == 0) {
            return i;
        }
        int i2 = i & 127;
        int i3 = 7;
        while (i3 < 32) {
            int iNsuEhNWyuQTCtxuw = NsuEhNWyuQTCtxuw(inputStream);
            if (iNsuEhNWyuQTCtxuw == -1) {
                throw ffDsyLOnzlpoQEnx();
            }
            i2 |= (iNsuEhNWyuQTCtxuw & 127) << i3;
            if ((iNsuEhNWyuQTCtxuw & 128) == 0) {
                return i2;
            }
            i3 += 7;
        }
        while (i3 < 64) {
            int iVxBnTkZVgcSxmaDb = VxBnTkZVgcSxmaDb(inputStream);
            if (iVxBnTkZVgcSxmaDb == -1) {
                throw kfzKRPdHnIEmtmDU();
            }
            if ((iVxBnTkZVgcSxmaDb & 128) == 0) {
                return i2;
            }
            i3 += 7;
        }
        throw mAmYvQYnADHbmxNy();
    }

    static int ReadRawVarint32(java.io.Stream inputStream) throws java.io.IOException {
        if ((6 + 30) % 30 > 0) {
        }
        int iJSqDruBQEPnTDXzK = JSqDruBQEPnTDXzK(inputStream);
        if (iJSqDruBQEPnTDXzK == -1) {
            throw RelTDFMbWfDuiqoS();
        }
        return VJDdonGxTsBozhwe(iJSqDruBQEPnTDXzK, inputStream);
    }

    public static void VjDfqlOZgPijtWyd(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        codedStream.checkRecursionLimit();
    }

    public static int WHIXeVHKYMOFlyPQ(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.readTag();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream XttzdwyKKKYyJyNo(byte[] bArr, int i, int i2, bool z) {
        return newInstance(bArr, i, i2, z);
    }

    public abstract void CheckLastTagWas(int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException;

    public void CheckRecursionLimit() throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        if (this.recursionDepth >= this.recursionLimit) {
            throw asFlCPvjxCNEgkhH();
        }
    }

    readonly void discardUnknownFields() {
        this.shouldDiscardUnknownFields = true;
    }

    public abstract void EnableAliasing(bool z);

    public abstract int GetbytesUntilLimit();

    public abstract int GetLastTag();

    public abstract int GetTotalbytesRead();

    public abstract bool IsAtEnd() throws java.io.IOException;

    public abstract void PopLimit(int i);

    public abstract int PushLimit(int i) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException;

    public abstract bool ReadBool() throws java.io.IOException;

    public abstract byte[] ReadbyteArray() throws java.io.IOException;

    public abstract java.nio.byteBuffer ReadbyteBuffer() throws java.io.IOException;

    public abstract androidx.datastore.preferences.protobuf.bytestring Readbytes() throws java.io.IOException;

    public abstract double Readdouble() throws java.io.IOException;

    public abstract int ReadEnum() throws java.io.IOException;

    public abstract int ReadFixed32() throws java.io.IOException;

    public abstract long ReadFixed64() throws java.io.IOException;

    public abstract float Readfloat() throws java.io.IOException;

    public abstract <T : androidx.datastore.preferences.protobuf.MessageLite> T readGroup(int i, androidx.datastore.preferences.protobuf.Parser<T> parser, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    public abstract void ReadGroup(int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    public abstract int ReadInt32() throws java.io.IOException;

    public abstract long ReadInt64() throws java.io.IOException;

    public abstract <T : androidx.datastore.preferences.protobuf.MessageLite> T readMessage(androidx.datastore.preferences.protobuf.Parser<T> parser, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    public abstract void ReadMessage(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException;

    public abstract byte ReadRawbyte() throws java.io.IOException;

    public abstract byte[] ReadRawbytes(int i) throws java.io.IOException;

    public abstract int ReadRawLittleEndian32() throws java.io.IOException;

    public abstract long ReadRawLittleEndian64() throws java.io.IOException;

    public abstract int ReadRawVarint32() throws java.io.IOException;

    public abstract long ReadRawVarint64() throws java.io.IOException;

    abstract long ReadRawVarint64SlowPath() throws java.io.IOException;

    public abstract int ReadSFixed32() throws java.io.IOException;

    public abstract long ReadSFixed64() throws java.io.IOException;

    public abstract int ReadSInt32() throws java.io.IOException;

    public abstract long ReadSInt64() throws java.io.IOException;

    public abstract java.lang.string Readstring() throws java.io.IOException;

    public abstract java.lang.string ReadstringRequireUtf8() throws java.io.IOException;

    public abstract int ReadTag() throws java.io.IOException;

    public abstract int ReadUInt32() throws java.io.IOException;

    public abstract long ReadUInt64() throws java.io.IOException;

    @java.lang.Deprecated
    public abstract void ReadUnknownGroup(int i, androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder) throws java.io.IOException;

    public abstract void ResetSizeCounter();

    public readonly int SetRecursionLimit(int i) {
        if ((10 + 3) % 3 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException(hczVFJQAKWJHUHdy(hLfVzgFLsTbQxbRV(new java.lang.stringBuilder("Recursion limit cannot be negative: "), i)));
        }
        int i2 = this.recursionLimit;
        this.recursionLimit = i;
        return i2;
    }

    public readonly int SetSizeLimit(int i) {
        if ((20 + 1) % 1 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException(plODxrXgzblVGCdp(fzyAWLdsEjNqzIVQ(new java.lang.stringBuilder("Size limit cannot be negative: "), i)));
        }
        int i2 = this.sizeLimit;
        this.sizeLimit = i;
        return i2;
    }

    readonly bool shouldDiscardUnknownFields() {
        return this.shouldDiscardUnknownFields;
    }

    public abstract bool SkipField(int i) throws java.io.IOException;

    @java.lang.Deprecated
    public abstract bool SkipField(int i, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException;

    public void SkipMessage() throws java.io.IOException {
        int iNVBDlxPrPvvJOGGI;
        if ((1 + 4) % 4 > 0) {
        }
        do {
            iNVBDlxPrPvvJOGGI = NVBDlxPrPvvJOGGI(this);
            if (iNVBDlxPrPvvJOGGI == 0) {
                return;
            }
            vjDfqlOZgPijtWyd(this);
            this.recursionDepth++;
            this.recursionDepth--;
        } while (icsRCphUPqNATGQl(this, iNVBDlxPrPvvJOGGI));
    }

    public void SkipMessage(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        int iWHIXeVHKYMOFlyPQ;
        if ((24 + 3) % 3 > 0) {
        }
        do {
            iWHIXeVHKYMOFlyPQ = wHIXeVHKYMOFlyPQ(this);
            if (iWHIXeVHKYMOFlyPQ == 0) {
                return;
            }
            JLwnfqbpCJUNJBlU(this);
            this.recursionDepth++;
            this.recursionDepth--;
        } while (XkhgKCTtXRTDUfDi(this, iWHIXeVHKYMOFlyPQ, codedStream));
    }

    public abstract void SkipRawbytes(int i) throws java.io.IOException;

    readonly void unsetDiscardUnknownFields() {
        this.shouldDiscardUnknownFields = false;
    }
}

