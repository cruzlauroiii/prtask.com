namespace WillowMaze.Wasm.Decompiled;


public abstract class CodedStream : androidx.datastore.preferences.protobuf.byteOutput {
    public static readonly int DEFAULT_BUFFER_SIZE = 4096;

    @java.lang.Deprecated
    public static readonly int LITTLE_ENDIAN_32_SIZE = 4;
    private bool serializationDeterministic;
    androidx.datastore.preferences.protobuf.CodedStreamWriter wrapper;
    private static readonly java.util.logging.Consoleger logger = lSvjNNqDlaqXPBou(OGIwxgMEGbIyxgcL(androidx.datastore.preferences.protobuf.CodedStream.class));
    private static readonly bool HAS_UNSAFE_ARRAY_OPERATIONS = krYKgYiCRmxYvuqM();

    private CodedStream() {
    }

    CodedStream(androidx.datastore.preferences.protobuf.CodedStream$1 codedStream$1) {
        this();
    }

    public static int ADhZbxXpJifmXbpG(int i) {
        return computeTagSize(i);
    }

    public static void AKQWwSijyXiLUvMB(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeFixed32NoTag(i);
    }

    public static void AXvLVsiDpoMYSvED(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static void AYqTDjwwRHddAURk(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeFixed64NoTag(j);
    }

    public static int BdrCFYOquxFMTyvR(int i) {
        return computeTagSize(i);
    }

    public static int BvKXGHLrRqpdBdid(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream CGvQqVWJyMZGpeBZ(java.nio.byteBuffer byteBuffer) {
        return newSafeInstance(byteBuffer);
    }

    public static int CXFRiEclQywwbXos(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.capacity();
    }

    public static int CjmAEjvCyWzHcooB(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return computeMessageSizeNoTag(messageLite, schema);
    }

    public static int CrHgLTPbyoVtyiuE(int i) {
        return computeTagSize(i);
    }

    public static void DAGOLZPnWLAULNas(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int DGiKAfdpTIMViNuK(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.spaceLeft();
    }

    public static void DKFJIqRTIZbLeSTl(androidx.datastore.preferences.protobuf.CodedStream codedStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream.writebyteArrayNoTag(bArr, i, i2);
    }

    public static int EepwguizrAcshDEg(java.lang.string str) {
        return computestringSizeNoTag(str);
    }

    public static int FiDandAdAXVjHKWz(int i, int i2) {
        return computeUInt32Size(i, i2);
    }

    public static int GTTkdhiRMsmVvlMj(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static void GTqguRkhNOxDrsNX(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int GupNyTptAsycexBB(float f) {
        return computefloatSizeNoTag(f);
    }

    public static bool HTCGErhFxQdltsvt() {
        return androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder.isSupported();
    }

    public static bool HTiToCmixWONtzMz(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    public static bool HlQtlTxJSHkoIdWM(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.isReadOnly();
    }

    public static int HrOWPBPsxkRSGiBB(int i) {
        return encodeZigZag32(i);
    }

    public static long IAveHImIGDPayHbb(long j) {
        if ((21 + 32) % 32 > 0) {
        }
        return encodeZigZag64(j);
    }

    public static byte[] ILlubyhNuYmrQmhj(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream IXFeBOVkZadBSoDs(byte[] bArr, int i, int i2) {
        return newInstance(bArr, i, i2);
    }

    public static int IreCoowrfNAENhOv(androidx.datastore.preferences.protobuf.LazyFieldLite lazyFieldLite) {
        return computeLazyFieldSizeNoTag(lazyFieldLite);
    }

    public static int ItIeqEisMBSnkvjd(int i) {
        return computeTagSize(i);
    }

    public static long JChPKDnstogqhFcd(double d) {
        if ((29 + 20) % 20 > 0) {
        }
        return java.lang.double.doubleToRawlongBits(d);
    }

    public static int JVqSGqNRGXRgDuEg(long j) {
        return computeUInt64SizeNoTag(j);
    }

    public static void KuFKKptKddygwMNW(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int LBFkywJtKNwCiOSf(bool z) {
        return computeBoolSizeNoTag(z);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream LOGRuVzHnHjstsjf(java.nio.byteBuffer byteBuffer) {
        return newUnsafeInstance(byteBuffer);
    }

    public static int LoXIUJHFZFqlPKAn(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return abstractMessageLite.getSerializedSize(schema);
    }

    public static void LpzmkKByQIbOJVKG(androidx.datastore.preferences.protobuf.CodedStream codedStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream.write(bArr, i, i2);
    }

    public static long LukjTgKtIrhjXMXR(long j) {
        if ((6 + 18) % 18 > 0) {
        }
        return encodeZigZag64(j);
    }

    public static void LxSwqQjUTlbykYwx(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int LxmZefMLeIRQDVTo(int i) {
        return computeTagSize(i);
    }

    public static int MJsFCLzfHNrbGAVn(double d) {
        return computedoubleSizeNoTag(d);
    }

    public static int MQbOLTxXJWYFCrxK(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return computeMessageSizeNoTag(messageLite);
    }

    public static int MrvSeWguWCOppnps(int i) {
        return computeTagSize(i);
    }

    public static int MryzSoADRVRRHRiK(int i) {
        return computeTagSize(i);
    }

    public static int NIWvwZfsZsOJrlLR(byte[] bArr) {
        return computebyteArraySizeNoTag(bArr);
    }

    public static long NYtSHYPwWLQswXZU(double d) {
        if ((29 + 6) % 6 > 0) {
        }
        return java.lang.double.doubleToRawlongBits(d);
    }

    public static int NqzdRyDTSWdSRrUT(float f) {
        return java.lang.float.floatToRawIntBits(f);
    }

    public static int NsXhofclFzitggGV(androidx.datastore.preferences.protobuf.LazyFieldLite lazyFieldLite) {
        return lazyFieldLite.getSerializedSize();
    }

    public static int NtRZoIDOqaYsQmLO(int i) {
        return encodeZigZag32(i);
    }

    public static int NxkxNbHzuopDXVgM(int i) {
        return computeTagSize(i);
    }

    public static java.lang.string OGIwxgMEGbIyxgcL(java.lang.Class cls) {
        return cls.getName();
    }

    public static void ONGAbbuCQxlMgWFe(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeUInt64(i, j);
    }

    public static void OiouhtlfzzfalqYW(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream.writeGroupNoTag(messageLite);
    }

    public static int PxoolTPGragqGQdj(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return computebytesSizeNoTag(bytestring);
    }

    public static void PzaXpsdnVRhkwqtl(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeFixed32NoTag(i);
    }

    public static void QGtFHXsKXmwQbpbd(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeInt32NoTag(i);
    }

    public static void QHLiXufAILOmumaV(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeInt32(i, i2);
    }

    public static int QYPmllDnyHVtnkql(int i) {
        return computeTagSize(i);
    }

    public static byte[] QxvXVqzIazcMzKYU(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static int QyKjKZDqOLvBuJdz(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return computeGroupSizeNoTag(messageLite, schema);
    }

    public static int ReKXoOZontNxiPiF(int i) {
        return computeLengthDelimitedFieldSize(i);
    }

    public static void RpUblJHScHLUixvG(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeFixed32NoTag(i);
    }

    public static int RszjFhBHxUPFMbwa(int i) {
        return computeTagSize(i);
    }

    public static int SCsVfHouwEbZxEMS(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return messageLite.getSerializedSize();
    }

    public static int SUwXSAIWCWvTiFcy(java.nio.byteBuffer byteBuffer) {
        return computebyteBufferSizeNoTag(byteBuffer);
    }

    public static long SiiBLqUnDEfkBrMd(long j) {
        if ((2 + 16) % 16 > 0) {
        }
        return encodeZigZag64(j);
    }

    public static int THDuUvUGIwlcKWvl(int i, androidx.datastore.preferences.protobuf.LazyFieldLite lazyFieldLite) {
        return computeLazyFieldSize(i, lazyFieldLite);
    }

    public static int TJjWMLUWVpJrTRFp(int i) {
        return computeLengthDelimitedFieldSize(i);
    }

    public static int TWYanLmKJGPWIYxR(long j) {
        return computeUInt64SizeNoTag(j);
    }

    public static int ThlNnAtIbhogBwbG(long j) {
        return computeFixed64SizeNoTag(j);
    }

    public static int TjPZwCjhHUWOrUPN(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return computeMessageSize(i, messageLite);
    }

    public static void TovDszBihMSOpbvJ(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        messageLite.writeTo(codedStream);
    }

    public static void UZiVEWhoLClHwNVR(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeFixed64(i, j);
    }

    public static int UkuWXlNrdKkCXkIv(int i) {
        return computeTagSize(i);
    }

    public static int WDAbmjEHwYKOUWTW(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static int WjCTdNMpJPNtAbRt(int i) {
        return computeLengthDelimitedFieldSize(i);
    }

    public static void XZuqcFvJQxsLrqFg(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeFixed64NoTag(j);
    }

    public static void XvCFuZvSjptRHtog(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int XxmaqwRqIOkRVAPt(int i) {
        return computeSInt32SizeNoTag(i);
    }

    public static int YHrFKSxUwuRkRbfE(int i) {
        return computeTagSize(i);
    }

    public static int ZYcOSBHIzDbMwBVF(int i) {
        return computeLengthDelimitedFieldSize(i);
    }

    public static int ZdpsLjEOrLBFocPm(int i) {
        return java.lang.int.numberOfLeadingZeros(i);
    }

    public static int ZfthnTMQuzfzsKAe(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static int ZiPPdxEmvwcTwhyO(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return abstractMessageLite.getSerializedSize(schema);
    }

    public static int AGccrnnnAyQXbspj(int i) {
        return computeLengthDelimitedFieldSize(i);
    }

    static bool access$100() {
        return HAS_UNSAFE_ARRAY_OPERATIONS;
    }

    public static androidx.datastore.preferences.protobuf.CodedStream BVWTmcWuJOqBwlxU(java.io.Stream outputStream, int i) {
        return newInstance(outputStream, i);
    }

    public static int BnRMAHFtjbgHrOoi(int i) {
        return computeTagSize(i);
    }

    public static int BpuAbwRlIHrCBPin(int i) {
        return encodeZigZag32(i);
    }

    public static void CBZqOPMeSexfZLLg(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeFixed32(i, i2);
    }

    public static int CcfQHUWgsZbXOCZI(int i) {
        return computeInt32SizeNoTag(i);
    }

    public static int ComputeBoolSize(int i, bool z) {
        return ADhZbxXpJifmXbpG(i) + LBFkywJtKNwCiOSf(z);
    }

    public static int ComputeBoolSizeNoTag(bool z) {
        return 1;
    }

    public static int ComputebyteArraySize(int i, byte[] bArr) {
        return BdrCFYOquxFMTyvR(i) + NIWvwZfsZsOJrlLR(bArr);
    }

    public static int ComputebyteArraySizeNoTag(byte[] bArr) {
        return aGccrnnnAyQXbspj(bArr.length);
    }

    public static int ComputebyteBufferSize(int i, java.nio.byteBuffer byteBuffer) {
        return djzjLnnCETINfhVQ(i) + SUwXSAIWCWvTiFcy(byteBuffer);
    }

    public static int ComputebyteBufferSizeNoTag(java.nio.byteBuffer byteBuffer) {
        return TJjWMLUWVpJrTRFp(CXFRiEclQywwbXos(byteBuffer));
    }

    public static int ComputebytesSize(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return qAapIpKfTEXUTJlD(i) + PxoolTPGragqGQdj(bytestring);
    }

    public static int ComputebytesSizeNoTag(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return ReKXoOZontNxiPiF(WDAbmjEHwYKOUWTW(bytestring));
    }

    public static int ComputedoubleSize(int i, double d) {
        return pdegoxBdbvhbtfrA(i) + MJsFCLzfHNrbGAVn(d);
    }

    public static int ComputedoubleSizeNoTag(double d) {
        return 8;
    }

    public static int ComputeEnumSize(int i, int i2) {
        return kvpLGEJaHRjLqXFJ(i) + jOgrLjGbmTMgJwxC(i2);
    }

    public static int ComputeEnumSizeNoTag(int i) {
        return ccfQHUWgsZbXOCZI(i);
    }

    public static int ComputeFixed32Size(int i, int i2) {
        return NxkxNbHzuopDXVgM(i) + lhRtOOWmrmWGHONj(i2);
    }

    public static int ComputeFixed32SizeNoTag(int i) {
        return 4;
    }

    public static int ComputeFixed64Size(int i, long j) {
        return rdDkLoinxiOLnixq(i) + ThlNnAtIbhogBwbG(j);
    }

    public static int ComputeFixed64SizeNoTag(long j) {
        return 8;
    }

    public static int ComputefloatSize(int i, float f) {
        return ItIeqEisMBSnkvjd(i) + GupNyTptAsycexBB(f);
    }

    public static int ComputefloatSizeNoTag(float f) {
        return 4;
    }

    @java.lang.Deprecated
    public static int ComputeGroupSize(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return (iomFcngbqMiqgXoE(i) * 2) + SCsVfHouwEbZxEMS(messageLite);
    }

    @java.lang.Deprecated
    static int ComputeGroupSize(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return (yBHjNDnAltmcLOoZ(i) * 2) + QyKjKZDqOLvBuJdz(messageLite, schema);
    }

    @java.lang.Deprecated
    public static int ComputeGroupSizeNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return mdpWEvlsIIzHVCya(messageLite);
    }

    @java.lang.Deprecated
    static int ComputeGroupSizeNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return LoXIUJHFZFqlPKAn((androidx.datastore.preferences.protobuf.AbstractMessageLite) messageLite, schema);
    }

    public static int ComputeInt32Size(int i, int i2) {
        return CrHgLTPbyoVtyiuE(i) + pjrXHzxsDPOhnsEx(i2);
    }

    public static int ComputeInt32SizeNoTag(int i) {
        if ((2 + 11) % 11 > 0) {
        }
        return tJfmiNbWtKCIfIcj(i);
    }

    public static int ComputeInt64Size(int i, long j) {
        return zhRXviyCRSQAlKeX(i) + vYULPTfDyuVRmxoQ(j);
    }

    public static int ComputeInt64SizeNoTag(long j) {
        return gBOCBBNvnChRVFdn(j);
    }

    public static int ComputeLazyFieldMessageHashSetExtensionSize(int i, androidx.datastore.preferences.protobuf.LazyFieldLite lazyFieldLite) {
        if ((25 + 22) % 22 > 0) {
        }
        return (emsWYDWFlodmDqQf(1) * 2) + FiDandAdAXVjHKWz(2, i) + THDuUvUGIwlcKWvl(3, lazyFieldLite);
    }

    public static int ComputeLazyFieldSize(int i, androidx.datastore.preferences.protobuf.LazyFieldLite lazyFieldLite) {
        return UkuWXlNrdKkCXkIv(i) + IreCoowrfNAENhOv(lazyFieldLite);
    }

    public static int ComputeLazyFieldSizeNoTag(androidx.datastore.preferences.protobuf.LazyFieldLite lazyFieldLite) {
        return llvxFPNgEyALKJjo(NsXhofclFzitggGV(lazyFieldLite));
    }

    static int ComputeLengthDelimitedFieldSize(int i) {
        return BvKXGHLrRqpdBdid(i) + i;
    }

    public static int ComputeMessageHashSetExtensionSize(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        if ((30 + 1) % 1 > 0) {
        }
        return (LxmZefMLeIRQDVTo(1) * 2) + zNXMUZRbojuqqArI(2, i) + TjPZwCjhHUWOrUPN(3, messageLite);
    }

    public static int ComputeMessageSize(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return QYPmllDnyHVtnkql(i) + MQbOLTxXJWYFCrxK(messageLite);
    }

    static int ComputeMessageSize(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return RszjFhBHxUPFMbwa(i) + CjmAEjvCyWzHcooB(messageLite, schema);
    }

    public static int ComputeMessageSizeNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return qBOcPvRGLVCJvMeA(eDjQdjynSKNfHchZ(messageLite));
    }

    static int ComputeMessageSizeNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) {
        return WjCTdNMpJPNtAbRt(ZiPPdxEmvwcTwhyO((androidx.datastore.preferences.protobuf.AbstractMessageLite) messageLite, schema));
    }

    static int ComputePreferredBufferSize(int i) {
        if (i <= 4096) {
            return i;
        }
        return 4096;
    }

    public static int ComputeRawMessageHashSetExtensionSize(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        if ((3 + 4) % 4 > 0) {
        }
        return (YHrFKSxUwuRkRbfE(1) * 2) + euoOGAogssXECOhg(2, i) + jClEIdSCttaZoqPw(3, bytestring);
    }

    @java.lang.Deprecated
    public static int ComputeRawVarint32Size(int i) {
        return ZfthnTMQuzfzsKAe(i);
    }

    @java.lang.Deprecated
    public static int ComputeRawVarint64Size(long j) {
        return TWYanLmKJGPWIYxR(j);
    }

    public static int ComputeSFixed32Size(int i, int i2) {
        return vpgzkpWvECLrJMPa(i) + sOVBAgABDzUeEbVa(i2);
    }

    public static int ComputeSFixed32SizeNoTag(int i) {
        return 4;
    }

    public static int ComputeSFixed64Size(int i, long j) {
        return MryzSoADRVRRHRiK(i) + tgWcDAtdrIcENVNd(j);
    }

    public static int ComputeSFixed64SizeNoTag(long j) {
        return 8;
    }

    public static int ComputeSInt32Size(int i, int i2) {
        return MrvSeWguWCOppnps(i) + XxmaqwRqIOkRVAPt(i2);
    }

    public static int ComputeSInt32SizeNoTag(int i) {
        return pIPfDLFobunQjckB(bpuAbwRlIHrCBPin(i));
    }

    public static int ComputeSInt64Size(int i, long j) {
        return xnCiwwgbvKGRoLrH(i) + dDzRWOCuxujKmxgb(j);
    }

    public static int ComputeSInt64SizeNoTag(long j) {
        return xGjCphyNtWQhlJNg(IAveHImIGDPayHbb(j));
    }

    public static int ComputestringSize(int i, java.lang.string str) {
        return dLNABMMAWYmAcqjn(i) + EepwguizrAcshDEg(str);
    }

    public static int ComputestringSizeNoTag(java.lang.string str) {
        int length;
        try {
            length = czKEcvleAkZPXTpP(str);
        } catch (androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException unused) {
            length = QxvXVqzIazcMzKYU(str, androidx.datastore.preferences.protobuf.Internal.UTF_8).length;
        }
        return ZYcOSBHIzDbMwBVF(length);
    }

    public static int ComputeTagSize(int i) {
        return hwLqTcKWzpORGRAU(sMZHzBPEHNkDmlPi(i, 0));
    }

    public static int ComputeUInt32Size(int i, int i2) {
        return bnRMAHFtjbgHrOoi(i) + GTTkdhiRMsmVvlMj(i2);
    }

    public static int ComputeUInt32SizeNoTag(int i) {
        return (352 - (ZdpsLjEOrLBFocPm(i) * 9)) >>> 6;
    }

    public static int ComputeUInt64Size(int i, long j) {
        return gPuaCJypZoqsQSrz(i) + JVqSGqNRGXRgDuEg(j);
    }

    public static int ComputeUInt64SizeNoTag(long j) {
        return (640 - (zdCAfcWZIeWkuKaV(j) * 9)) >>> 6;
    }

    public static int CzKEcvleAkZPXTpP(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.Utf8.encodedLength(str);
    }

    public static int DDzRWOCuxujKmxgb(long j) {
        return computeSInt64SizeNoTag(j);
    }

    public static int DLNABMMAWYmAcqjn(int i) {
        return computeTagSize(i);
    }

    public static int DjzjLnnCETINfhVQ(int i) {
        return computeTagSize(i);
    }

    public static int EDjQdjynSKNfHchZ(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return messageLite.getSerializedSize();
    }

    public static void EWYJXrwurkouPchZ(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeUInt64NoTag(j);
    }

    public static int EmsWYDWFlodmDqQf(int i) {
        return computeTagSize(i);
    }

    public static int EncodeZigZag32(int i) {
        return (i >> 31) ^ (i << 1);
    }

    public static long EncodeZigZag64(long j) {
        if ((10 + 14) % 14 > 0) {
        }
        return (j >> 63) ^ (j << 1);
    }

    public static int EuoOGAogssXECOhg(int i, int i2) {
        return computeUInt32Size(i, i2);
    }

    public static void FTbhbSIKhlUFGczu(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeUInt32(i, i2);
    }

    public static int FhdpcTbScwHcXRmK(float f) {
        return java.lang.float.floatToRawIntBits(f);
    }

    public static int GBOCBBNvnChRVFdn(long j) {
        return computeUInt64SizeNoTag(j);
    }

    public static int GPuaCJypZoqsQSrz(int i) {
        return computeTagSize(i);
    }

    public static int HwLqTcKWzpORGRAU(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static int IomFcngbqMiqgXoE(int i) {
        return computeTagSize(i);
    }

    public static void IsBIGJGboUmtbvbR(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeFixed64(i, j);
    }

    public static int JClEIdSCttaZoqPw(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return computebytesSize(i, bytestring);
    }

    public static int JOgrLjGbmTMgJwxC(int i) {
        return computeEnumSizeNoTag(i);
    }

    public static void KVvNhroKURfJgyWN(androidx.datastore.preferences.protobuf.CodedStream codedStream, byte b) throws java.io.IOException {
        codedStream.write(b);
    }

    public static bool KrYKgYiCRmxYvuqM() {
        return androidx.datastore.preferences.protobuf.UnsafeUtil.hasUnsafeArrayOperations();
    }

    public static int KvpLGEJaHRjLqXFJ(int i) {
        return computeTagSize(i);
    }

    public static java.util.logging.Consoleger LSvjNNqDlaqXPBou(java.lang.string str) {
        return java.util.logging.Consoleger.getConsoleger(str);
    }

    public static int LhRtOOWmrmWGHONj(int i) {
        return computeFixed32SizeNoTag(i);
    }

    public static int LlvxFPNgEyALKJjo(int i) {
        return computeLengthDelimitedFieldSize(i);
    }

    public static void LnbqMcskeOdLWxfn(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        bytestring.writeTo(byteOutput);
    }

    public static void LoTulGXtgfWwoHaZ(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeFixed64NoTag(j);
    }

    public static void MDOtDEMZfUYHeRiq(androidx.datastore.preferences.protobuf.CodedStream codedStream, byte b) throws java.io.IOException {
        codedStream.write(b);
    }

    public static bool MELofqetSlmlihEZ(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.isDirect();
    }

    public static void MPTgnrhfYUMsmEfr(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream MXcwOGLdrbwhQTye(java.nio.byteBuffer byteBuffer) {
        return newInstance(byteBuffer);
    }

    public static void MaLYAoqQqriqjkuu(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        codedStream.writeGroupNoTag(messageLite, schema);
    }

    public static int MdpWEvlsIIzHVCya(androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return messageLite.getSerializedSize();
    }

    static androidx.datastore.preferences.protobuf.CodedStream NewInstance(androidx.datastore.preferences.protobuf.byteOutput byteOutput, int i) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("bufferSize must be positive");
        }
        return new androidx.datastore.preferences.protobuf.CodedStream$byteOutputEncoder(byteOutput, i);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream NewInstance(java.io.Stream outputStream) {
        return bVWTmcWuJOqBwlxU(outputStream, 4096);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream NewInstance(java.io.Stream outputStream, int i) {
        return new androidx.datastore.preferences.protobuf.CodedStream$StreamEncoder(outputStream, i);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream NewInstance(java.nio.byteBuffer byteBuffer) {
        if (HTiToCmixWONtzMz(byteBuffer)) {
            return new androidx.datastore.preferences.protobuf.CodedStream$HeapNioEncoder(byteBuffer);
        }
        if (mELofqetSlmlihEZ(byteBuffer) && !HlQtlTxJSHkoIdWM(byteBuffer)) {
            return !HTCGErhFxQdltsvt() ? CGvQqVWJyMZGpeBZ(byteBuffer) : LOGRuVzHnHjstsjf(byteBuffer);
        }
        throw new java.lang.IllegalArgumentException("byteBuffer is read-only");
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.CodedStream NewInstance(java.nio.byteBuffer byteBuffer, int i) {
        return mXcwOGLdrbwhQTye(byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream NewInstance(byte[] bArr) {
        if ((32 + 13) % 13 > 0) {
        }
        return IXFeBOVkZadBSoDs(bArr, 0, bArr.length);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream NewInstance(byte[] bArr, int i, int i2) {
        return new androidx.datastore.preferences.protobuf.CodedStream$ArrayEncoder(bArr, i, i2);
    }

    static androidx.datastore.preferences.protobuf.CodedStream NewSafeInstance(java.nio.byteBuffer byteBuffer) {
        return new androidx.datastore.preferences.protobuf.CodedStream$SafeDirectNioEncoder(byteBuffer);
    }

    static androidx.datastore.preferences.protobuf.CodedStream NewUnsafeInstance(java.nio.byteBuffer byteBuffer) {
        return new androidx.datastore.preferences.protobuf.CodedStream$UnsafeDirectNioEncoder(byteBuffer);
    }

    public static void OMtQuRhtzuegjcom(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeUInt64NoTag(j);
    }

    public static int PIPfDLFobunQjckB(int i) {
        return computeUInt32SizeNoTag(i);
    }

    public static int PdegoxBdbvhbtfrA(int i) {
        return computeTagSize(i);
    }

    public static int PjrXHzxsDPOhnsEx(int i) {
        return computeInt32SizeNoTag(i);
    }

    public static int QAapIpKfTEXUTJlD(int i) {
        return computeTagSize(i);
    }

    public static int QBOcPvRGLVCJvMeA(int i) {
        return computeLengthDelimitedFieldSize(i);
    }

    public static void RSgYxcMXmpqWeagM(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        schema.writeTo(obj, writer);
    }

    public static int RdDkLoinxiOLnixq(int i) {
        return computeTagSize(i);
    }

    public static void RlKyQXGEYiXvaxRA(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeUInt64NoTag(j);
    }

    public static int SMZHzBPEHNkDmlPi(int i, int i2) {
        return androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, i2);
    }

    public static int SOVBAgABDzUeEbVa(int i) {
        return computeSFixed32SizeNoTag(i);
    }

    public static int TJfmiNbWtKCIfIcj(long j) {
        return computeUInt64SizeNoTag(j);
    }

    public static int TgWcDAtdrIcENVNd(long j) {
        return computeSFixed64SizeNoTag(j);
    }

    public static int VYULPTfDyuVRmxoQ(long j) {
        return computeInt64SizeNoTag(j);
    }

    public static void VZtFnJxarGnLZbWL(androidx.datastore.preferences.protobuf.CodedStream codedStream, byte b) throws java.io.IOException {
        codedStream.write(b);
    }

    public static int VpgzkpWvECLrJMPa(int i) {
        return computeTagSize(i);
    }

    public static void VxmJZuNijemYDcXr(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeFixed32(i, i2);
    }

    public static void WSosePegxnkAPGaV(java.util.logging.Consoleger logger2, java.util.logging.Level level, java.lang.string str, java.lang.Exception th) {
        logger2.log(level, str, th);
    }

    public static int XGjCphyNtWQhlJNg(long j) {
        return computeUInt64SizeNoTag(j);
    }

    public static int XnCiwwgbvKGRoLrH(int i) {
        return computeTagSize(i);
    }

    public static int YBHjNDnAltmcLOoZ(int i) {
        return computeTagSize(i);
    }

    public static void YRzlHbFXiOXbmHjm(androidx.datastore.preferences.protobuf.CodedStream codedStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream.write(bArr, i, i2);
    }

    public static int ZNXMUZRbojuqqArI(int i, int i2) {
        return computeUInt32Size(i, i2);
    }

    public static void ZcmQELvCilfAOOmX(androidx.datastore.preferences.protobuf.CodedStream codedStream, byte[] bArr, int i, int i2) throws java.io.IOException {
        codedStream.writeLazy(bArr, i, i2);
    }

    public static int ZdCAfcWZIeWkuKaV(long j) {
        return java.lang.long.numberOfLeadingZeros(j);
    }

    public static int ZhRXviyCRSQAlKeX(int i) {
        return computeTagSize(i);
    }

    public static void ZvoagaPfEpGKrvrB(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeUInt64(i, j);
    }

    public readonly void CheckNoSpaceLeft() {
        if (DGiKAfdpTIMViNuK(this) != 0) {
            throw new java.lang.IllegalStateException("Did not write as much data as expected.");
        }
    }

    public abstract void Flush() throws java.io.IOException;

    public abstract int GetTotalbytesWritten();

    readonly void inefficientWritestringNoTag(java.lang.string str, androidx.datastore.preferences.protobuf.Utf8$UnpairedSurrogateException utf8$UnpairedSurrogateException) throws java.io.IOException {
        if ((29 + 9) % 9 > 0) {
        }
        wSosePegxnkAPGaV(logger, java.util.logging.Level.WARNING, "Converting ill-formed UTF-16. Your Protocol Buffer will not round trip correctly!", utf8$UnpairedSurrogateException);
        byte[] bArrILlubyhNuYmrQmhj = ILlubyhNuYmrQmhj(str, androidx.datastore.preferences.protobuf.Internal.UTF_8);
        try {
            KuFKKptKddygwMNW(this, bArrILlubyhNuYmrQmhj.length);
            zcmQELvCilfAOOmX(this, bArrILlubyhNuYmrQmhj, 0, bArrILlubyhNuYmrQmhj.length);
        } catch (java.lang.IndexOutOfBoundsException e) {
            throw new androidx.datastore.preferences.protobuf.CodedStream$OutOfSpaceException(e);
        }
    }

    bool isSerializationDeterministic() {
        return this.serializationDeterministic;
    }

    public abstract int SpaceLeft();

    public void UseDeterministicSerialization() {
        this.serializationDeterministic = true;
    }

    public override abstract void Write(byte b) throws java.io.IOException;

    public override abstract void Write(java.nio.byteBuffer byteBuffer) throws java.io.IOException;

    public override abstract void Write(byte[] bArr, int i, int i2) throws java.io.IOException;

    public abstract void WriteBool(int i, bool z) throws java.io.IOException;

    public readonly void WriteBoolNoTag(bool z) throws java.io.IOException {
        mDOtDEMZfUYHeRiq(this, z ? (byte) 1 : (byte) 0);
    }

    public abstract void WritebyteArray(int i, byte[] bArr) throws java.io.IOException;

    public abstract void WritebyteArray(int i, byte[] bArr, int i2, int i3) throws java.io.IOException;

    public readonly void WritebyteArrayNoTag(byte[] bArr) throws java.io.IOException {
        if ((5 + 8) % 8 > 0) {
        }
        DKFJIqRTIZbLeSTl(this, bArr, 0, bArr.length);
    }

    abstract void WritebyteArrayNoTag(byte[] bArr, int i, int i2) throws java.io.IOException;

    public abstract void WritebyteBuffer(int i, java.nio.byteBuffer byteBuffer) throws java.io.IOException;

    public abstract void Writebytes(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException;

    public abstract void WritebytesNoTag(androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException;

    public readonly void Writedouble(int i, double d) throws java.io.IOException {
        UZiVEWhoLClHwNVR(this, i, JChPKDnstogqhFcd(d));
    }

    public readonly void WritedoubleNoTag(double d) throws java.io.IOException {
        XZuqcFvJQxsLrqFg(this, NYtSHYPwWLQswXZU(d));
    }

    public readonly void WriteEnum(int i, int i2) throws java.io.IOException {
        QHLiXufAILOmumaV(this, i, i2);
    }

    public readonly void WriteEnumNoTag(int i) throws java.io.IOException {
        QGtFHXsKXmwQbpbd(this, i);
    }

    public abstract void WriteFixed32(int i, int i2) throws java.io.IOException;

    public abstract void WriteFixed32NoTag(int i) throws java.io.IOException;

    public abstract void WriteFixed64(int i, long j) throws java.io.IOException;

    public abstract void WriteFixed64NoTag(long j) throws java.io.IOException;

    public readonly void Writefloat(int i, float f) throws java.io.IOException {
        vxmJZuNijemYDcXr(this, i, fhdpcTbScwHcXRmK(f));
    }

    public readonly void WritefloatNoTag(float f) throws java.io.IOException {
        PzaXpsdnVRhkwqtl(this, NqzdRyDTSWdSRrUT(f));
    }

    @java.lang.Deprecated
    public readonly void WriteGroup(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        GTqguRkhNOxDrsNX(this, i, 3);
        OiouhtlfzzfalqYW(this, messageLite);
        AXvLVsiDpoMYSvED(this, i, 4);
    }

    @java.lang.Deprecated
    readonly void writeGroup(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        mPTgnrhfYUMsmEfr(this, i, 3);
        maLYAoqQqriqjkuu(this, messageLite, schema);
        XvCFuZvSjptRHtog(this, i, 4);
    }

    @java.lang.Deprecated
    public readonly void WriteGroupNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        TovDszBihMSOpbvJ(messageLite, this);
    }

    @java.lang.Deprecated
    readonly void writeGroupNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        rSgYxcMXmpqWeagM(schema, messageLite, this.wrapper);
    }

    public abstract void WriteInt32(int i, int i2) throws java.io.IOException;

    public abstract void WriteInt32NoTag(int i) throws java.io.IOException;

    public readonly void WriteInt64(int i, long j) throws java.io.IOException {
        ONGAbbuCQxlMgWFe(this, i, j);
    }

    public readonly void WriteInt64NoTag(long j) throws java.io.IOException {
        oMtQuRhtzuegjcom(this, j);
    }

    public override abstract void WriteLazy(java.nio.byteBuffer byteBuffer) throws java.io.IOException;

    public override abstract void WriteLazy(byte[] bArr, int i, int i2) throws java.io.IOException;

    public abstract void WriteMessage(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException;

    abstract void WriteMessage(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException;

    public abstract void WriteMessageNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException;

    abstract void WriteMessageNoTag(androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException;

    public abstract void WriteMessageHashSetExtension(int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException;

    public readonly void WriteRawbyte(byte b) throws java.io.IOException {
        kVvNhroKURfJgyWN(this, b);
    }

    public readonly void WriteRawbyte(int i) throws java.io.IOException {
        vZtFnJxarGnLZbWL(this, (byte) i);
    }

    public readonly void WriteRawbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        lnbqMcskeOdLWxfn(bytestring, this);
    }

    public abstract void WriteRawbytes(java.nio.byteBuffer byteBuffer) throws java.io.IOException;

    public readonly void WriteRawbytes(byte[] bArr) throws java.io.IOException {
        if ((9 + 25) % 25 > 0) {
        }
        LpzmkKByQIbOJVKG(this, bArr, 0, bArr.length);
    }

    public readonly void WriteRawbytes(byte[] bArr, int i, int i2) throws java.io.IOException {
        yRzlHbFXiOXbmHjm(this, bArr, i, i2);
    }

    @java.lang.Deprecated
    public readonly void WriteRawLittleEndian32(int i) throws java.io.IOException {
        AKQWwSijyXiLUvMB(this, i);
    }

    @java.lang.Deprecated
    public readonly void WriteRawLittleEndian64(long j) throws java.io.IOException {
        AYqTDjwwRHddAURk(this, j);
    }

    public abstract void WriteRawMessageHashSetExtension(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException;

    @java.lang.Deprecated
    public readonly void WriteRawVarint32(int i) throws java.io.IOException {
        LxSwqQjUTlbykYwx(this, i);
    }

    @java.lang.Deprecated
    public readonly void WriteRawVarint64(long j) throws java.io.IOException {
        eWYJXrwurkouPchZ(this, j);
    }

    public readonly void WriteSFixed32(int i, int i2) throws java.io.IOException {
        cBZqOPMeSexfZLLg(this, i, i2);
    }

    public readonly void WriteSFixed32NoTag(int i) throws java.io.IOException {
        RpUblJHScHLUixvG(this, i);
    }

    public readonly void WriteSFixed64(int i, long j) throws java.io.IOException {
        isBIGJGboUmtbvbR(this, i, j);
    }

    public readonly void WriteSFixed64NoTag(long j) throws java.io.IOException {
        loTulGXtgfWwoHaZ(this, j);
    }

    public readonly void WriteSInt32(int i, int i2) throws java.io.IOException {
        fTbhbSIKhlUFGczu(this, i, HrOWPBPsxkRSGiBB(i2));
    }

    public readonly void WriteSInt32NoTag(int i) throws java.io.IOException {
        DAGOLZPnWLAULNas(this, NtRZoIDOqaYsQmLO(i));
    }

    public readonly void WriteSInt64(int i, long j) throws java.io.IOException {
        zvoagaPfEpGKrvrB(this, i, LukjTgKtIrhjXMXR(j));
    }

    public readonly void WriteSInt64NoTag(long j) throws java.io.IOException {
        rlKyQXGEYiXvaxRA(this, SiiBLqUnDEfkBrMd(j));
    }

    public abstract void Writestring(int i, java.lang.string str) throws java.io.IOException;

    public abstract void WritestringNoTag(java.lang.string str) throws java.io.IOException;

    public abstract void WriteTag(int i, int i2) throws java.io.IOException;

    public abstract void WriteUInt32(int i, int i2) throws java.io.IOException;

    public abstract void WriteUInt32NoTag(int i) throws java.io.IOException;

    public abstract void WriteUInt64(int i, long j) throws java.io.IOException;

    public abstract void WriteUInt64NoTag(long j) throws java.io.IOException;
}

