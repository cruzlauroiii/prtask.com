namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
abstract class BinaryWriter : androidx.datastore.preferences.protobuf.byteOutput : androidx.datastore.preferences.protobuf.Writer {
    public static readonly int DEFAULT_CHUNK_SIZE = 4096;
    private static readonly int MAP_KEY_NUMBER = 1;
    private static readonly int MAP_VALUE_NUMBER = 2;
    private readonly androidx.datastore.preferences.protobuf.BufferAllocator alloc;
    readonly java.util.ArrayQueue<androidx.datastore.preferences.protobuf.AllocatedBuffer> buffers;
    private readonly int chunkSize;
    int totalDonebytes;

    private BinaryWriter(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        if ((19 + 1) % 1 > 0) {
        }
        this.buffers = new java.util.ArrayQueue<>(4);
        if (i <= 0) {
            throw new java.lang.IllegalArgumentException("chunkSize must be > 0");
        }
        this.alloc = (androidx.datastore.preferences.protobuf.BufferAllocator) GLovsNmosgdUXzXx(bufferAllocator, "alloc");
        this.chunkSize = i;
    }

    BinaryWriter(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i, androidx.datastore.preferences.protobuf.BinaryWriter$1 binaryWriter$1) {
        this(bufferAllocator, i);
    }

    public static void APzhWUisoixpVqHV(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static void AScRFdriZIijLxbI(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writeUInt32List_Internal(i, (java.util.List<java.lang.int>) list, z);
    }

    public static int AYTXCUctVmSqDzqK(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static void AlVQNxiuCjzCaobN(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, long j) {
        binaryWriter.writeFixed64(j);
    }

    public static int BAVShfrzUnRtzrmz(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void BBRuOFaXIJZptRlE(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static int BDdjeQKPqxmkljQb(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int BjmvGWcpldAgVeuN(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void BqMktKyCtazCijkX(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeUInt32(i, i2);
    }

    public static int BvbyYHXSLTrPVqYT(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static int BxiJmywkhfpUAXHt(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static void CBhyxSuCiZiIKrnq(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static long CDlnFCWKuWEpWkXi(double d) {
        if ((30 + 4) % 4 > 0) {
        }
        return java.lang.double.doubleToRawlongBits(d);
    }

    public static float CLcCEDFeMgaqjsZr(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.object CMrGmXRyxVPFelIK(java.util.List list, int i) {
        return list[i);
    }

    public static int CgHBPUyyeWbIKdbA(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static int CgkfluHOyXsKSBUG(java.util.List list) {
        return list.Count;
    }

    public static int CwccDiBTVIWodUVT(java.util.List list) {
        return list.Count;
    }

    public static void DVJvkYjadAxbCXXR(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, long j) {
        binaryWriter.writeFixed64(i, j);
    }

    public static void DvGAHSWaPFKZeZRm(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static long EFwObHIIjyLArnVw(java.lang.long l) {
        if ((12 + 24) % 24 > 0) {
        }
        return l.longValue();
    }

    public static void EHHPVgBNJiVZFWrR(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writeFixed64List_Internal(i, (java.util.List<java.lang.long>) list, z);
    }

    public static int EUHnGvNZKyWrngsa(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void EUrenugBqAYswxEj(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static int EitNKBszkINlRvtr(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void EjPyVFCUSeHvTMCl(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static void EpzSMqfAxYbeoLFj(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writeInt32List(i, list, z);
    }

    public static void EtnzcybpOTuoiVmU(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static int EvFScDqnnghOGNlq(java.util.List list) {
        return list.Count;
    }

    public static int FZsGpVDWKPRMZFwI(java.util.List list) {
        return list.Count;
    }

    public static void GKYpLaLgcTyYwFGq(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static java.lang.object GLovsNmosgdUXzXx(java.lang.object obj, java.lang.string str) {
        return androidx.datastore.preferences.protobuf.Internal.checkNotNull(obj, str);
    }

    public static int GMrtioSqkQqFAMbb(java.util.List list) {
        return list.Count;
    }

    public static void GVdYIjVLuiheqaMS(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        binaryWriter.writeSInt32List_Internal(i, intList, z);
    }

    public static int GeGUsycnAhghIjBG(java.lang.int num) {
        return num.intValue();
    }

    public static void HFVmUPYPnJlZspXD(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeFixed32(i);
    }

    public static void HIlmoSWUNHcMMHIF(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, long j) {
        binaryWriter.writeSInt64(i, j);
    }

    public static void HMnImMBRFvhrqNGU(androidx.datastore.preferences.protobuf.Writer writer, int i, int i2) throws java.io.IOException {
        writer.writeUInt32(i, i2);
    }

    public static long HiFXasDMjaFoXXCQ(java.lang.long l) {
        if ((27 + 30) % 30 > 0) {
        }
        return l.longValue();
    }

    public static long ICfXTxKEwoLNauxv(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((6 + 31) % 31 > 0) {
        }
        return longList.getlong(i);
    }

    public static java.lang.string IEARioDxatHWijHq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object ILFtphwBjLDOIcJo(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object IRnxivOAtcESbFZQ(java.util.List list, int i) {
        return list[i);
    }

    public static int ISKvMCThupbIHMZX(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static void IZHrIdTtwqnVwEEv(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, bool z) {
        binaryWriter.writeBool(z);
    }

    public static int IdpIyCTHuwSgrtkb(java.lang.int num) {
        return num.intValue();
    }

    public static double InQQnwKibTXJyNVg(androidx.datastore.preferences.protobuf.doubleList doubleList, int i) {
        if ((25 + 25) % 25 > 0) {
        }
        return doubleList.getdouble(i);
    }

    public static int IpVyBXAeBuTdvmqh(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static int IuzoiUTPqaLIMtBN(java.util.List list) {
        return list.Count;
    }

    public static void IwkmUAlfjrxzSBdQ(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, bool z) {
        binaryWriter.writeBool(z);
    }

    public static int JIezhVuxCLUySOaG(java.util.List list) {
        return list.Count;
    }

    public static int JOgZPaDPqmdCamtG(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static int JVKOalMXjZgZJcEL(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void JjNGiTDXqIVYgLti(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeFixed32(i, i2);
    }

    public static java.lang.object JkaVJcloenuzgAie(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object JvznuaRynhzOfagD(java.util.List list, int i) {
        return list[i);
    }

    public static void JzmcvKCWIdSFQQnR(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static int KAlFDZRBhQVCqHdV(java.util.List list) {
        return list.Count;
    }

    public static void KJkSZKfsUlFhPQBJ(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, long j) {
        binaryWriter.writeVarint64(j);
    }

    public static int KOsiOJbrAewssoNG(androidx.datastore.preferences.protobuf.floatList floatList) {
        return floatList.Count;
    }

    public static int KQECUkjKBpMUBxmz(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void KVxJByoGPhuviTlx(androidx.datastore.preferences.protobuf.Writer writer, int i, java.lang.string str) throws java.io.IOException {
        writer.writestring(i, str);
    }

    public static void KgtOHcueQyANokit(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static void KnsNlojBTDCBwIlY(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, long j) {
        binaryWriter.writeUInt64(i, j);
    }

    public static void KsjIevQvwaZjgedw(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writeBoolList_Internal(i, (java.util.List<java.lang.bool>) list, z);
    }

    public static int KtxtNjOQsQlPKenb(java.util.List list) {
        return list.Count;
    }

    public static int KuarGavBiKOcvTTM(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int KwDttceIMEnJBoOa(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static long KziKAGxmWsCqtNpC(java.lang.long l) {
        if ((10 + 1) % 1 > 0) {
        }
        return l.longValue();
    }

    public static int LBZdTMLEzZVfUJTT(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void LGqQNaiRxebCsiLi(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeFixed32(i);
    }

    public static int LIeaPtDErAnJDDcn(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static int LJcFidRtTsDHjKqe(java.util.List list) {
        return list.Count;
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer LKMmHLRkuoiDXWQh(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return bufferAllocator.allocateDirectBuffer(i);
    }

    public static void LMMjbocHrCgBmgXR(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static int LMsKOsuayhnjSupb(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void LPszRSEieUuGksyQ(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, long j) {
        binaryWriter.writeFixed64(i, j);
    }

    public static void LQjaPPEEQgnGcKOx(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static void LaLVWApwdMQibFyL(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static void LlPJhqqjqFPCjmfE(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static void MHWfGqCBAowlIgFd(androidx.datastore.preferences.protobuf.Writer writer, int i, bool z) throws java.io.IOException {
        writer.writeBool(i, z);
    }

    public static int MOjLDwOYVRpaWwIW(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void MPjQImbLlGLkCgZE(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static void MTYkNKUCDLVxKAJP(androidx.datastore.preferences.protobuf.Writer writer, int i, long j) throws java.io.IOException {
        writer.writeSFixed64(i, j);
    }

    public static int MTkNtvAKtGwNfSRG(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void MUAYbAaXqTnThISe(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static long MhFQtycehAbsmNEf(java.lang.long l) {
        if ((19 + 19) % 19 > 0) {
        }
        return l.longValue();
    }

    public static bool MrIAXRMKphIZtgAo() {
        return isUnsafeDirectSupported();
    }

    public static double MseqsyEyXHihhQbP(java.lang.double d) {
        if ((13 + 29) % 29 > 0) {
        }
        return d.doubleValue();
    }

    public static void NEIofkKgTZJQrWSB(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.lang.string str) {
        binaryWriter.writestring(i, str);
    }

    public static int NWOPXSxvICfELbqx(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static void NZfWtVuyZicBBypv(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeUInt32(i, i2);
    }

    public static void NeivznNSLPgyYqvx(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.lang.object obj) {
        binaryWriter.writeGroup(i, obj);
    }

    public static int NlrqbLNDlqLnnzsD(java.util.List list) {
        return list.Count;
    }

    public static androidx.datastore.preferences.protobuf.BinaryWriter NmUuGLVWUTPejrUJ(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return newDirectInstance(bufferAllocator, i);
    }

    public static void NsINQGJvsxValyuL(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static int NxrHghXoAbDEpBwl(java.util.List list) {
        return list.Count;
    }

    public static int NzXoxMhgIybNueMe(androidx.datastore.preferences.protobuf.floatList floatList) {
        return floatList.Count;
    }

    public static void OIKdOzsrJEnpcXdF(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static long OQIcmXlUrbgdJmdG(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((6 + 14) % 14 > 0) {
        }
        return longList.getlong(i);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer OchkYBCkgsCLhGze(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return bufferAllocator.allocateDirectBuffer(i);
    }

    public static int OcmXUzccErbeBzXd(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void OpBoizaEIoUQeBEh(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writeUInt64List(i, list, z);
    }

    public static int OqekpktQZSKHDdex(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static java.lang.object OxCBLySBMWnEgVgN(java.util.List list, int i) {
        return list[i);
    }

    public static void PMFRvwjlipXoHhOk(androidx.datastore.preferences.protobuf.Writer writer, int i, androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, java.lang.object obj) throws java.io.IOException {
        writeDictionaryEntryField(writer, i, wireFormat$FieldType, obj);
    }

    public static void PVjttNzUZOjPBgIm(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static int PZyTJSGIqPTndhCd(androidx.datastore.preferences.protobuf.doubleList doubleList) {
        return doubleList.Count;
    }

    public static void PbJfyFPvMbQLiobE(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) {
        binaryWriter.writeMessage(i, obj, schema);
    }

    public static int PcycjtRBRZWzFeLc(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void PkttmtbxDEwJUwdz(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        binaryWriter.writeFixed64List_Internal(i, longList, z);
    }

    public static long PuGPqKkIkTdQslAa(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((29 + 8) % 8 > 0) {
        }
        return longList.getlong(i);
    }

    public static java.lang.object PvjmNvpAFcikWvKU(java.util.List list, int i) {
        return list[i);
    }

    public static void PxNvUkJHvKjPJfZj(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static double QBuFGAnKZweOgWcs(java.lang.double d) {
        if ((5 + 30) % 30 > 0) {
        }
        return d.doubleValue();
    }

    public static void QEjFPzozkvMnswSl(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static int QFQjuMbpyeVIFdWg(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static int QMQdMjiPCsxAyLVI(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void QXabDLHPUYyGRbdn(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        binaryWriter.writebytes(i, bytestring);
    }

    public static void QjvmJeFYfSfSOPSz(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeFixed32(i, i2);
    }

    public static int QmLjYafDhPMIkQxQ(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static androidx.datastore.preferences.protobuf.BinaryWriter RBuoAtOOEwBiHtQo(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return newHeapInstance(bufferAllocator, i);
    }

    public static int RKSgVkwtrxOiXZvM(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static int RLWhTfnoBtKMznMF(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void RObNhnauiDnVaXeD(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, long j) {
        binaryWriter.writeFixed64(j);
    }

    public static androidx.datastore.preferences.protobuf.BinaryWriter RUPxMxBKFulhrsps(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return newUnsafeHeapInstance(bufferAllocator, i);
    }

    public static androidx.datastore.preferences.protobuf.BinaryWriter RVWljMmIIdssNcyk(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return newUnsafeDirectInstance(bufferAllocator, i);
    }

    public static long RhBziLxoFWsKmuny(double d) {
        if ((3 + 28) % 28 > 0) {
        }
        return java.lang.double.doubleToRawlongBits(d);
    }

    public static int RjfNXAWTxntVzGpe(java.lang.int num) {
        return num.intValue();
    }

    public static void RpStZGAOOZnegAcb(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static void RqhdOUHdDbVzehOO(androidx.datastore.preferences.protobuf.Writer writer, int i, long j) throws java.io.IOException {
        writer.writeFixed64(i, j);
    }

    public static void RyrzTrzTtBRwiVTY(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeFixed32(i);
    }

    public static androidx.datastore.preferences.protobuf.BinaryWriter SFHdbSFTgIIuJfax(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return newSafeDirectInstance(bufferAllocator, i);
    }

    public static void SPCvLObBOuzkWutK(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeFixed32(i);
    }

    public static double SVlBkTTlljwNdTDj(java.lang.double d) {
        if ((15 + 30) % 30 > 0) {
        }
        return d.doubleValue();
    }

    public static void SaJSAMMsrfAYfjQg(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, long j) {
        binaryWriter.writeFixed64(j);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer ToGuDscJuoUEsmUI(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return bufferAllocator.allocateHeapBuffer(i);
    }

    public static void TsRUPkjjCjgqBszq(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static int TxVvVBKRmlyWuJwr(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int UGreeTjKwgYJJkej(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static java.lang.object UIcFGpwIMutrVaib(java.util.List list, int i) {
        return list[i);
    }

    public static void UNoeuwkgeZrWPvRf(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writeUInt64List_Internal(i, (java.util.List<java.lang.long>) list, z);
    }

    public static int UWYfUmPmgbcvHtno(androidx.datastore.preferences.protobuf.boolList boolList) {
        return boolList.Count;
    }

    public static java.lang.object UcqbvJtxnEXPnjGK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int UnfAWljxFfuCRgBH(java.util.List list) {
        return list.Count;
    }

    public static bool VCuCTeymjfihcitI(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        return boolList.getbool(i);
    }

    public static float VSTiXjNMtfQaYDLV(androidx.datastore.preferences.protobuf.floatList floatList, int i) {
        return floatList.getfloat(i);
    }

    public static void VSjZMKMWdhEbkbWY(androidx.datastore.preferences.protobuf.Writer writer, int i, float f) throws java.io.IOException {
        writer.writefloat(i, f);
    }

    public static long VbAEFindKXQoaWrh(java.lang.long l) {
        if ((20 + 24) % 24 > 0) {
        }
        return l.longValue();
    }

    public static int VhTeZJwiHWpWyTNG(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static void VmRmPXMPOoHhUmCe(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static void VpRfwCBNsZecAljH(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static int VqhidjwhrKthXNbX(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void VtokLPiKdgqNVkqH(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.floatList floatList, bool z) throws java.io.IOException {
        binaryWriter.writefloatList_Internal(i, floatList, z);
    }

    public static float WGAElTLrYgEMyAbu(androidx.datastore.preferences.protobuf.floatList floatList, int i) {
        return floatList.getfloat(i);
    }

    public static bool WIZctToeoWgMxFUe(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static int WRrzNptMSrnyrAqG(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void WglmNWQwzAHEsFtV(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writedoubleList_Internal(i, (java.util.List<java.lang.double>) list, z);
    }

    public static int WmQWFYdekHyATIvg(float f) {
        return java.lang.float.floatToRawIntBits(f);
    }

    public static void WnHsUwBUWCzUzrHg(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        binaryWriter.writeFixed32List_Internal(i, intList, z);
    }

    public static void XHFuymvfjnWBMVdS(androidx.datastore.preferences.protobuf.Writer writer, int i, long j) throws java.io.IOException {
        writer.writeSInt64(i, j);
    }

    public static int XLiyBwCEWcRXOSnw(java.lang.int num) {
        return num.intValue();
    }

    public static int XXBfuPHLRqiiHIOw(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static long XgBCFnjyARPwvjkq(java.lang.long l) {
        if ((15 + 5) % 5 > 0) {
        }
        return l.longValue();
    }

    public static void YAOcWqmYwTphEhOL(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.boolList boolList, bool z) throws java.io.IOException {
        binaryWriter.writeBoolList_Internal(i, boolList, z);
    }

    public static int YGRsrxpsWMaOizAw(androidx.datastore.preferences.protobuf.boolList boolList) {
        return boolList.Count;
    }

    public static void YJyFxZbjksAazlUM(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeSInt32(i, i2);
    }

    public static void YRnvAGlmwKOydApI(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static int YVKAWKnjTpShhoiW(androidx.datastore.preferences.protobuf.floatList floatList) {
        return floatList.Count;
    }

    public static int YiIWiJiKjyblAtZb(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void YmrYCpcdeKrbWMIP(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static java.lang.object YolAxMIdzQBHQlZy(java.util.List list, int i) {
        return list[i);
    }

    public static int YqRpfGBohgsIljzD(java.lang.int num) {
        return num.intValue();
    }

    public static void YsSeqAJydktlPrZv(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, long j) {
        binaryWriter.writeSInt64(i, j);
    }

    public static void YtOQEMnKXASLTJci(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, long j) {
        binaryWriter.writeVarint64(j);
    }

    public static int YyFeWJBInIlSbWxO(java.util.List list) {
        return list.Count;
    }

    public static int YynKCHNAuXtkGgKR(java.lang.int num) {
        return num.intValue();
    }

    public static void ZGFBbRIPaRAgmtBI(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeUInt32(i, i2);
    }

    public static int ZKRocoAFlGhPdoNc(java.util.List list) {
        return list.Count;
    }

    public static long ZPUACZrgxIjwuOnc(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((21 + 11) % 11 > 0) {
        }
        return longList.getlong(i);
    }

    public static void ZTFEjuhUOZXUCoPc(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, long j) {
        binaryWriter.writeUInt64(i, j);
    }

    public static int ZTLCoSTQOVyBgLVu(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object ZcaawvIYZjoidFhj(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static int ZeAIiScfuuxyZAPT(java.util.List list) {
        return list.Count;
    }

    public static void ZlkkJVMuYBslgysc(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static void ZqXbjZOFKsabFZoQ(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writeFixed32List(i, list, z);
    }

    public static int AACNPJGHybSezmpv(java.util.List list) {
        return list.Count;
    }

    public static int AGHvATrDRFdOJUZs(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void AHwjJlqLMcVBzADv(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeSInt32(i);
    }

    public static java.lang.object AIyxHmOMjidEWNhN(java.util.List list, int i) {
        return list[i);
    }

    public static void ALFfXFdzKrYtQVWw(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, long j) {
        binaryWriter.writeUInt64(i, j);
    }

    public static int AZvsMeWnHEBpNaum(java.lang.int num) {
        return num.intValue();
    }

    static byte access$200(long j) {
        return uwpJQDeGmtsiZqWV(j);
    }

    public static bool AknVnTXWTkXTXMlx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int AlLQCuFuYYaIveYb(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static int AtpTfrjJGDTruRaB(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.stringBuilder AvvsqAMFzbSLHbRd(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int AwbnkUjMstLdazUX(java.util.List list) {
        return list.Count;
    }

    public static int BEhZEDcWcvdfPnIU(java.lang.int num) {
        return num.intValue();
    }

    public static java.util.HashSet BHJwPsjeOejuBDuw(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static void BMPnrqOXfkgXBaOD(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.lang.string str) {
        binaryWriter.writestring(i, str);
    }

    public static void BSKpGDyEzCeOkVms(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static int BYULkgvlxjMsHxne(java.util.List list) {
        return list.Count;
    }

    public static void BcvLQbQUvEwZhXfC(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static void BfJJjJyUTEvhMEnt(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, long j) {
        binaryWriter.writeFixed64(i, j);
    }

    public static int BqqOofkmZiREHsBS(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void BrNcQPGkSBanQqqP(androidx.datastore.preferences.protobuf.Writer writer, int i, int i2) throws java.io.IOException {
        writer.writeSInt32(i, i2);
    }

    public static int BsVXOleNGldIHmcE(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void BwlCNQdFxXdXRcNe(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, bool z) {
        binaryWriter.writeBool(i, z);
    }

    public static void CAVAPgsseVcZKsXX(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeInt32(i, i2);
    }

    public static int CArVvWyJEYcvpJDx(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static int CBMcZvOAHpGitYdT(java.lang.int num) {
        return num.intValue();
    }

    public static bool CHZPLSHZbceetBcM() {
        return androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeDirectWriter.access$000();
    }

    public static void COsJNMJzeEVrnzZs(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writeSInt32List_Internal(i, (java.util.List<java.lang.int>) list, z);
    }

    public static void CkNDofTSnOubYVNk(androidx.datastore.preferences.protobuf.Writer writer, int i, int i2) throws java.io.IOException {
        writer.writeEnum(i, i2);
    }

    private static byte ComputeUInt64SizeNoTag(long j) {
        byte b;
        if ((19 + 2) % 2 > 0) {
        }
        if (((-128) & j) == 0) {
            return (byte) 1;
        }
        if (j < 0) {
            return (byte) 10;
        }
        if (((-34359738368L) & j) == 0) {
            b = 2;
        } else {
            b = (byte) 6;
            j >>>= 28;
        }
        if (((-2097152) & j) != 0) {
            b = (byte) (b + 2);
            j >>>= 14;
        }
        return (j & (-16384)) == 0 ? b : (byte) (b + 1);
    }

    public static int DBwqNplNSkRItNfO(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void DEJPBjSOlLJHQQkF(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.lang.object obj) throws java.io.IOException {
        binaryWriter.writeLazystring(i, obj);
    }

    public static int DEZlkLDDauJBiYgX(java.util.List list) {
        return list.Count;
    }

    public static void DLFPlLtzfHFZFfva(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.lang.object obj) {
        binaryWriter.writeMessage(i, obj);
    }

    public static java.lang.object DRAtQyeRgACAnXYf(androidx.datastore.preferences.protobuf.LazystringList lazystringList, int i) {
        return lazystringList.getRaw(i);
    }

    public static void DWAYmKCmgNLlgDYG(androidx.datastore.preferences.protobuf.Writer writer, int i, java.lang.object obj) throws java.io.IOException {
        writer.writeMessage(i, obj);
    }

    public static long DYIuFyzksGDYbuGr(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((4 + 26) % 26 > 0) {
        }
        return longList.getlong(i);
    }

    public static androidx.datastore.preferences.protobuf.BinaryWriter DhszxNERQlFpImNX(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return newSafeHeapInstance(bufferAllocator, i);
    }

    public static void DlViZMRoPnXkUTKK(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        binaryWriter.writeSInt64List_Internal(i, longList, z);
    }

    public static void DmGLKfiOYiTdgorr(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static void DprRIwfyTKIbmHHl(androidx.datastore.preferences.protobuf.Writer writer, int i, int i2) throws java.io.IOException {
        writer.writeFixed32(i, i2);
    }

    public static java.lang.object DrnlukJCoDVqIUdA(java.util.List list, int i) {
        return list[i);
    }

    public static int EHZKZflPCAknyafw(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static java.lang.object ELCEIFImRALMJFzz(java.util.List list, int i) {
        return list[i);
    }

    public static java.util.IEnumerator EiFPCRtqkNOpZhYp(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int FDZEGRmzRctKJYMm(java.lang.int num) {
        return num.intValue();
    }

    public static int FKRxNYqhIJELnMbN(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object FQLGABHwINaEuKEQ(java.util.List list, int i) {
        return list[i);
    }

    public static void FXPUJYnMXYgKbydt(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.lang.object obj) {
        binaryWriter.writeMessage(i, obj);
    }

    public static void FcMOcgIiGQbXePtW(androidx.datastore.preferences.protobuf.Writer writer, int i, long j) throws java.io.IOException {
        writer.writeUInt64(i, j);
    }

    public static int FdTFiUEqcvkCXRuD(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object FihMCyktTQTTXVRb(java.util.List list, int i) {
        return list[i);
    }

    public static void FplSxMtMWrdNVdeJ(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        binaryWriter.writebytes(i, bytestring);
    }

    public static int FtnBgUNQkgpFujCF(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object GAYbHHpBXRBCezCY(java.util.List list, int i) {
        return list[i);
    }

    public static int GNkMSrfyMjHoixbK(java.util.List list) {
        return list.Count;
    }

    public static int GSEZVKcqiVRXmOta(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static int GZBXbmvjbRYjHhXC(java.util.List list) {
        return list.Count;
    }

    public static void GfsfqTjWOFeMTtlB(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static int GnaxtPuPMfNPthMf(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void GreximDKCxHAtBOr(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeInt32(i);
    }

    public static void GroznvFjSEGIxXOQ(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static java.lang.object HFAqtoEYZoWolIwe(java.util.List list, int i) {
        return list[i);
    }

    public static void HMBwnpcNgOVmeBTR(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        binaryWriter.writeInt32List_Internal(i, intList, z);
    }

    public static java.lang.object HUsMceiRuxXKBmTA(java.util.List list, int i) {
        return list[i);
    }

    public static void HXIggGucqVpcFOtK(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) {
        binaryWriter.writeGroup(i, obj, schema);
    }

    public static bool HXtyXQOsqJQlzIOE() {
        return isUnsafeHeapSupported();
    }

    public static void HvTpFRzseXRSzqHs(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static int HwpbvfrhAHDHaBSd(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static java.lang.object HzwxEziZGBudTzOw(java.util.List list, int i) {
        return list[i);
    }

    public static long IBdVKdjLUNzdTJUJ(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((26 + 21) % 21 > 0) {
        }
        return longList.getlong(i);
    }

    public static void IQJrWAyonYPFotMx(androidx.datastore.preferences.protobuf.Writer writer, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        writer.writebytes(i, bytestring);
    }

    public static int IXAMLAUEMSInVFSS(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void IfmBVABkVWJLDcUU(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static void ImYQfacRNiHpVYYE(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static long IomptECFvzvOxJHp(java.lang.long l) {
        if ((1 + 24) % 24 > 0) {
        }
        return l.longValue();
    }

    public static int IpDXAaEDanjLDLAu(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    static bool IsUnsafeDirectSupported() {
        return cHZPLSHZbceetBcM();
    }

    static bool IsUnsafeHeapSupported() {
        return kAGTNFqFEJSerkvn();
    }

    public static bool IsarYWMNIDharJkc() {
        return isUnsafeHeapSupported();
    }

    public static void IuZYSzksUtWbYcHJ(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static int JIgkuvqWaPLuzbLL(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static int JNJVWZphGNlgSDOi(java.util.List list) {
        return list.Count;
    }

    public static int JaUOYfpcLvzOHmBP(java.util.List list) {
        return list.Count;
    }

    public static void JjUcSIYIqkmxRUKW(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, long j) {
        binaryWriter.writeSInt64(j);
    }

    public static java.lang.object JpBglskcQtvwkYPn(java.util.List list, int i) {
        return list[i);
    }

    public static void JsfhKigDwhtktWqc(androidx.datastore.preferences.protobuf.Writer writer, int i, int i2) throws java.io.IOException {
        writer.writeInt32(i, i2);
    }

    public static void JvzgjqyRxNDmOTTN(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeFixed32(i, i2);
    }

    public static int KAAPAMlNnejRaCWy(java.util.List list) {
        return list.Count;
    }

    public static bool KAGTNFqFEJSerkvn() {
        return androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter.isSupported();
    }

    public static void KCYOnaHqeQPxcDZs(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static int KXkqdubEtjHRvBcN(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static void KbKIJOadRXEBewlN(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, long j) {
        binaryWriter.writeFixed64(i, j);
    }

    public static void KelEBclVhCCpXKXd(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, double d) throws java.io.IOException {
        binaryWriter.writedouble(i, d);
    }

    public static void KsvbSwLjEQIkdjVc(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        binaryWriter.writeUInt32List_Internal(i, intList, z);
    }

    public static int LDitIsoHwJSmbzSr(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static int LGmyCuYTjSFEvauq(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static bool LIJdmDwIFLLxaJMo() {
        return isUnsafeDirectSupported();
    }

    public static void LUDlQLpcggWKMnDR(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writefloatList_Internal(i, (java.util.List<java.lang.float>) list, z);
    }

    public static bool LWLdMJmtpeGdRLiA(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        return boolList.getbool(i);
    }

    public static int LtDiInhQZFFZkGAe(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static int LwFpVRjGfifGjkBt(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static int LzLkZEiPIzXjzIRz(java.lang.int num) {
        return num.intValue();
    }

    public static float MGTPHLzUPOWhgnqR(java.lang.float f) {
        return f.floatValue();
    }

    public static void MWVGvAZVwqYoEkgo(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static int MXNIoajoRIJZDNtW(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer MbRPfNfNcquOCIfx(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return bufferAllocator.allocateHeapBuffer(i);
    }

    public static void MczwdVnvYkWsQKlI(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static void MklWcfTlbQoNrWME(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writeFixed32List_Internal(i, (java.util.List<java.lang.int>) list, z);
    }

    public static void MoYPDxAKHcFbaYYw(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static void MqkQEyNJQtNScTsB(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static void MssMekudvYPbxFRG(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writeFixed64List(i, list, z);
    }

    public static void MzUNzryMlJLQihBI(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeSInt32(i, i2);
    }

    public static long NKfexHxIYUvFewzv(double d) {
        if ((17 + 7) % 7 > 0) {
        }
        return java.lang.double.doubleToRawlongBits(d);
    }

    public static void NLrpMrxvtHWZEdrN(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static int NRjnCKhVGAojgRKh(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static void NbbewRiAnTVGqFlt(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static androidx.datastore.preferences.protobuf.BinaryWriter NewDirectInstance(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator) {
        return NmUuGLVWUTPejrUJ(bufferAllocator, 4096);
    }

    public static androidx.datastore.preferences.protobuf.BinaryWriter NewDirectInstance(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return !lIJdmDwIFLLxaJMo() ? SFHdbSFTgIIuJfax(bufferAllocator, i) : RVWljMmIIdssNcyk(bufferAllocator, i);
    }

    public static androidx.datastore.preferences.protobuf.BinaryWriter NewHeapInstance(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator) {
        return RBuoAtOOEwBiHtQo(bufferAllocator, 4096);
    }

    public static androidx.datastore.preferences.protobuf.BinaryWriter NewHeapInstance(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return !isarYWMNIDharJkc() ? dhszxNERQlFpImNX(bufferAllocator, i) : RUPxMxBKFulhrsps(bufferAllocator, i);
    }

    static androidx.datastore.preferences.protobuf.BinaryWriter NewSafeDirectInstance(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return new androidx.datastore.preferences.protobuf.BinaryWriter$SafeDirectWriter(bufferAllocator, i);
    }

    static androidx.datastore.preferences.protobuf.BinaryWriter NewSafeHeapInstance(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        return new androidx.datastore.preferences.protobuf.BinaryWriter$SafeHeapWriter(bufferAllocator, i);
    }

    static androidx.datastore.preferences.protobuf.BinaryWriter NewUnsafeDirectInstance(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        if (MrIAXRMKphIZtgAo()) {
            return new androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeDirectWriter(bufferAllocator, i);
        }
        throw new java.lang.UnsupportedOperationException("Unsafe operations not supported");
    }

    static androidx.datastore.preferences.protobuf.BinaryWriter NewUnsafeHeapInstance(androidx.datastore.preferences.protobuf.BufferAllocator bufferAllocator, int i) {
        if (hXtyXQOsqJQlzIOE()) {
            return new androidx.datastore.preferences.protobuf.BinaryWriter$UnsafeHeapWriter(bufferAllocator, i);
        }
        throw new java.lang.UnsupportedOperationException("Unsafe operations not supported");
    }

    public static void NuRZQfLjdoDVnnVZ(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        binaryWriter.finishCurrentBuffer();
    }

    public static java.lang.object NwlAdTjwCEttTchs(java.util.List list, int i) {
        return list[i);
    }

    public static void OAOZUeZoNIjeXzbK(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeInt32(i, i2);
    }

    public static int ODLObGjEhlZnEYHH(java.util.List list) {
        return list.Count;
    }

    public static int OEUkQpdkuZmuDRsD(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void OFRTFxKQhSfAowtm(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static int OKsUfcTriAdsHhDP(androidx.datastore.preferences.protobuf.Internal$EnumLite internal$EnumLite) {
        return internal$EnumLite.getNumber();
    }

    public static void OdWknwqSKljsImDW(androidx.datastore.preferences.protobuf.Writer writer, int i, int i2) throws java.io.IOException {
        writer.writeSFixed32(i, i2);
    }

    public static int OsVfyoIeqgfUPXOf(androidx.datastore.preferences.protobuf.doubleList doubleList) {
        return doubleList.Count;
    }

    public static void OsakVeOKoiOjqlxU(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, float f) throws java.io.IOException {
        binaryWriter.writefloat(i, f);
    }

    public static int OvapYGkCvEGzmxYK(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static int OyDUukKNkVkEsixP(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void PCLkabWdeUcvzMEE(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static int PRvBFrTYHqoemFtE(androidx.datastore.preferences.protobuf.doubleList doubleList) {
        return doubleList.Count;
    }

    public static void PUDPowOPCmijqvyg(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writeSInt64List_Internal(i, (java.util.List<java.lang.long>) list, z);
    }

    public static void PXzoMWHvKekbewll(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeFixed32(i, i2);
    }

    public static int PYHOyivPoEVSqEIy(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static int PbGJUayqGOxSlsxj(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static int PgEyueNVnMwBthbL(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static void PnycCuejRcJcGSme(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static java.lang.object PpDyAdRWNOkakbUi(java.util.List list, int i) {
        return list[i);
    }

    public static void QYmAytQgBzLoPFdr(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.doubleList doubleList, bool z) throws java.io.IOException {
        binaryWriter.writedoubleList_Internal(i, doubleList, z);
    }

    public static void QvOrHOAVTpRLZPaN(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static void RAOyFvoFkFcQlKLv(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static void RENqtWTZELjFSEkG(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static int RKfylbKpmSwFcGxK(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static int RRmCYMWfyTWtyZna(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static long RVgVzVxLvwwtUknW(java.lang.long l) {
        if ((29 + 30) % 30 > 0) {
        }
        return l.longValue();
    }

    public static int RqAKkcnwXLefrFMm(java.util.List list) {
        return list.Count;
    }

    public static void SIlZdtWyBFTCyDrm(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static int SLLgbLdwFmCLIIOv(java.util.List list) {
        return list.Count;
    }

    public static int SeWDpRLBAlIBesXp(androidx.datastore.preferences.protobuf.boolList boolList) {
        return boolList.Count;
    }

    public static int SexszOvPuHYwELnb(float f) {
        return java.lang.float.floatToRawIntBits(f);
    }

    public static void ShebYMjtNwBUEqRD(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static void TOVcvjUMoIVUbJPd(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, long j) {
        binaryWriter.writeFixed64(j);
    }

    public static void TVpRpTXHLoEXUCVI(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static void TXajayQCWUNWcCxe(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static void TZtYTSNGdIeGxrse(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static int TbcCFtFHbDLOsUBZ(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static bool TgwXTaFfyqTIzrZM(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static int ThMAowXCdYlrOKpN(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static bool TkGKXaAlzcFLAZLM(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static int TlCumJLlRHnZTQXn(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static int TrRGUacekFGkFxuW(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static void TtEIovnxLXeBjFYe(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static java.lang.object TvitREgjPzsstRVm(java.util.List list, int i) {
        return list[i);
    }

    public static int TvktFVnTWSmMGrxM(java.util.List list) {
        return list.Count;
    }

    public static int TxpjxXOQSrmAqKIc(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static java.lang.object UCSDZgdxSJqDwlKJ(java.util.List list, int i) {
        return list[i);
    }

    public static void ULcgDDMAgXPsaxHX(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static long UNAThxdLslpMzdgC(java.lang.long l) {
        if ((31 + 32) % 32 > 0) {
        }
        return l.longValue();
    }

    public static void UVQdyKKwTobcFLVM(androidx.datastore.preferences.protobuf.Writer writer, int i, androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, java.lang.object obj) throws java.io.IOException {
        writeDictionaryEntryField(writer, i, wireFormat$FieldType, obj);
    }

    public static void UqcsBoPwrDkRZcWV(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static byte UwpJQDeGmtsiZqWV(long j) {
        return computeUInt64SizeNoTag(j);
    }

    public static long UxnmtmmQjCvLprte(java.lang.long l) {
        if ((26 + 13) % 13 > 0) {
        }
        return l.longValue();
    }

    public static void VLIYSRBtSgIBxKgM(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, float f) throws java.io.IOException {
        binaryWriter.writefloat(i, f);
    }

    public static void VLjiNAhffoEpBfqV(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        binaryWriter.writeInt32List_Internal(i, (java.util.List<java.lang.int>) list, z);
    }

    public static void VREAyGxQzJIHEhpJ(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeVarint32(i);
    }

    public static void VTOmqGJWfUdQOPqw(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, bool z) {
        binaryWriter.writeBool(i, z);
    }

    public static void VcdfRZDIArbyhgwp(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, long j) {
        binaryWriter.writeSInt64(j);
    }

    public static int VebWeSgjXjtBCPPn(float f) {
        return java.lang.float.floatToRawIntBits(f);
    }

    public static int VmVDjyhbobohNeHV(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void WHjOkEXftpbYxTbq(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeSInt32(i);
    }

    public static int WJJwWoThqJORAbSz(java.lang.int num) {
        return num.intValue();
    }

    public static long WMpiYbjzeEqzxdfs(java.lang.long l) {
        if ((26 + 14) % 14 > 0) {
        }
        return l.longValue();
    }

    public static void WQsHRDBInMZlQeJM(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static int WTqAqBVggwTZpxTN(java.util.List list) {
        return list.Count;
    }

    public static void WXPsWvGGttdeyJYj(androidx.datastore.preferences.protobuf.Writer writer, int i, double d) throws java.io.IOException {
        writer.writedouble(i, d);
    }

    public static void WZWWVffQminLgMPq(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static void WZfeMXRFxsNqpJAF(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        binaryWriter.writeUInt64List_Internal(i, longList, z);
    }

    public static void WZiQvaarMFVGgSWT(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        binaryWriter.writebytes(i, bytestring);
    }

    public static void WhflZrinIDzoIRiq(androidx.datastore.preferences.protobuf.Writer writer, int i, long j) throws java.io.IOException {
        writer.writeInt64(i, j);
    }

    public static java.lang.object WphRHuBeJlFNuMIJ(java.util.List list, int i) {
        return list[i);
    }

    private void WriteBoolListInternal(int i, androidx.datastore.preferences.protobuf.boolList boolList, bool z) throws java.io.IOException {
        if ((6 + 15) % 15 > 0) {
        }
        if (!z) {
            for (int iSeWDpRLBAlIBesXp = seWDpRLBAlIBesXp(boolList) - 1; iSeWDpRLBAlIBesXp >= 0; iSeWDpRLBAlIBesXp--) {
                bwlCNQdFxXdXRcNe(this, i, VCuCTeymjfihcitI(boolList, iSeWDpRLBAlIBesXp));
            }
            return;
        }
        xDiIGanHNbvVqgpy(this, UWYfUmPmgbcvHtno(boolList) + 10);
        int iKQECUkjKBpMUBxmz = KQECUkjKBpMUBxmz(this);
        for (int iYGRsrxpsWMaOizAw = YGRsrxpsWMaOizAw(boolList) - 1; iYGRsrxpsWMaOizAw >= 0; iYGRsrxpsWMaOizAw--) {
            IwkmUAlfjrxzSBdQ(this, lWLdMJmtpeGdRLiA(boolList, iYGRsrxpsWMaOizAw));
        }
        LMMjbocHrCgBmgXR(this, rKfylbKpmSwFcGxK(this) - iKQECUkjKBpMUBxmz);
        gfsfqTjWOFeMTtlB(this, i, 2);
    }

    private void WriteBoolListInternal(int i, java.util.List<java.lang.bool> list, bool z) throws java.io.IOException {
        if ((20 + 7) % 7 > 0) {
        }
        if (!z) {
            for (int iKAAPAMlNnejRaCWy = kAAPAMlNnejRaCWy(list) - 1; iKAAPAMlNnejRaCWy >= 0; iKAAPAMlNnejRaCWy--) {
                vTOmqGJWfUdQOPqw(this, i, tkGKXaAlzcFLAZLM((java.lang.bool) ppDyAdRWNOkakbUi(list, iKAAPAMlNnejRaCWy)));
            }
            return;
        }
        yLzYVgcLFNNeWhww(this, zCXsRMiuuMwLihEo(list) + 10);
        int iTxpjxXOQSrmAqKIc = txpjxXOQSrmAqKIc(this);
        for (int iFKRxNYqhIJELnMbN = fKRxNYqhIJELnMbN(list) - 1; iFKRxNYqhIJELnMbN >= 0; iFKRxNYqhIJELnMbN--) {
            IZHrIdTtwqnVwEEv(this, tgwXTaFfyqTIzrZM((java.lang.bool) YolAxMIdzQBHQlZy(list, iFKRxNYqhIJELnMbN)));
        }
        vREAyGxQzJIHEhpJ(this, EitNKBszkINlRvtr(this) - iTxpjxXOQSrmAqKIc);
        sIlZdtWyBFTCyDrm(this, i, 2);
    }

    private void WritedoubleListInternal(int i, androidx.datastore.preferences.protobuf.doubleList doubleList, bool z) throws java.io.IOException {
        if ((17 + 28) % 28 > 0) {
        }
        if (!z) {
            for (int iPRvBFrTYHqoemFtE = pRvBFrTYHqoemFtE(doubleList) - 1; iPRvBFrTYHqoemFtE >= 0; iPRvBFrTYHqoemFtE--) {
                kelEBclVhCCpXKXd(this, i, InQQnwKibTXJyNVg(doubleList, iPRvBFrTYHqoemFtE));
            }
            return;
        }
        pCLkabWdeUcvzMEE(this, (osVfyoIeqgfUPXOf(doubleList) * 8) + 10);
        int iThMAowXCdYlrOKpN = thMAowXCdYlrOKpN(this);
        for (int iPZyTJSGIqPTndhCd = PZyTJSGIqPTndhCd(doubleList) - 1; iPZyTJSGIqPTndhCd >= 0; iPZyTJSGIqPTndhCd--) {
            SaJSAMMsrfAYfjQg(this, RhBziLxoFWsKmuny(znvGsFssAiBbMnbi(doubleList, iPZyTJSGIqPTndhCd)));
        }
        PxNvUkJHvKjPJfZj(this, BvbyYHXSLTrPVqYT(this) - iThMAowXCdYlrOKpN);
        bSKpGDyEzCeOkVms(this, i, 2);
    }

    private void WritedoubleListInternal(int i, java.util.List<java.lang.double> list, bool z) throws java.io.IOException {
        if ((11 + 25) % 25 > 0) {
        }
        if (!z) {
            for (int iJaUOYfpcLvzOHmBP = jaUOYfpcLvzOHmBP(list) - 1; iJaUOYfpcLvzOHmBP >= 0; iJaUOYfpcLvzOHmBP--) {
                ycRwRJaFgBIjagNx(this, i, QBuFGAnKZweOgWcs((java.lang.double) JkaVJcloenuzgAie(list, iJaUOYfpcLvzOHmBP)));
            }
            return;
        }
        KgtOHcueQyANokit(this, (zzGDwfearMPYIfLF(list) * 8) + 10);
        int iLIeaPtDErAnJDDcn = LIeaPtDErAnJDDcn(this);
        for (int iWTqAqBVggwTZpxTN = wTqAqBVggwTZpxTN(list) - 1; iWTqAqBVggwTZpxTN >= 0; iWTqAqBVggwTZpxTN--) {
            tOVcvjUMoIVUbJPd(this, nKfexHxIYUvFewzv(SVlBkTTlljwNdTDj((java.lang.double) IRnxivOAtcESbFZQ(list, iWTqAqBVggwTZpxTN))));
        }
        shebYMjtNwBUEqRD(this, mXNIoajoRIJZDNtW(this) - iLIeaPtDErAnJDDcn);
        mczwdVnvYkWsQKlI(this, i, 2);
    }

    private void WriteFixed32ListInternal(int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        if ((2 + 26) % 26 > 0) {
        }
        if (!z) {
            for (int iNRjnCKhVGAojgRKh = nRjnCKhVGAojgRKh(intList) - 1; iNRjnCKhVGAojgRKh >= 0; iNRjnCKhVGAojgRKh--) {
                pXzoMWHvKekbewll(this, i, oEUkQpdkuZmuDRsD(intList, iNRjnCKhVGAojgRKh));
            }
            return;
        }
        uqcsBoPwrDkRZcWV(this, (UGreeTjKwgYJJkej(intList) * 4) + 10);
        int iYiIWiJiKjyblAtZb = YiIWiJiKjyblAtZb(this);
        for (int iBDdjeQKPqxmkljQb = BDdjeQKPqxmkljQb(intList) - 1; iBDdjeQKPqxmkljQb >= 0; iBDdjeQKPqxmkljQb--) {
            LGqQNaiRxebCsiLi(this, lDitIsoHwJSmbzSr(intList, iBDdjeQKPqxmkljQb));
        }
        LlPJhqqjqFPCjmfE(this, OcmXUzccErbeBzXd(this) - iYiIWiJiKjyblAtZb);
        moYPDxAKHcFbaYYw(this, i, 2);
    }

    private void WriteFixed32ListInternal(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if ((13 + 32) % 32 > 0) {
        }
        if (!z) {
            for (int iFZsGpVDWKPRMZFwI = FZsGpVDWKPRMZFwI(list) - 1; iFZsGpVDWKPRMZFwI >= 0; iFZsGpVDWKPRMZFwI--) {
                JjNGiTDXqIVYgLti(this, i, wJJwWoThqJORAbSz((java.lang.int) UIcFGpwIMutrVaib(list, iFZsGpVDWKPRMZFwI)));
            }
            return;
        }
        imYQfacRNiHpVYYE(this, (jNJVWZphGNlgSDOi(list) * 4) + 10);
        int iQFQjuMbpyeVIFdWg = QFQjuMbpyeVIFdWg(this);
        for (int iNlrqbLNDlqLnnzsD = NlrqbLNDlqLnnzsD(list) - 1; iNlrqbLNDlqLnnzsD >= 0; iNlrqbLNDlqLnnzsD--) {
            RyrzTrzTtBRwiVTY(this, fDZEGRmzRctKJYMm((java.lang.int) gAYbHHpBXRBCezCY(list, iNlrqbLNDlqLnnzsD)));
        }
        oFRTFxKQhSfAowtm(this, jIgkuvqWaPLuzbLL(this) - iQFQjuMbpyeVIFdWg);
        iuZYSzksUtWbYcHJ(this, i, 2);
    }

    private void WriteFixed64ListInternal(int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        if ((11 + 4) % 4 > 0) {
        }
        if (!z) {
            for (int iISKvMCThupbIHMZX = ISKvMCThupbIHMZX(longList) - 1; iISKvMCThupbIHMZX >= 0; iISKvMCThupbIHMZX--) {
                kbKIJOadRXEBewlN(this, i, iBdVKdjLUNzdTJUJ(longList, iISKvMCThupbIHMZX));
            }
            return;
        }
        ifmBVABkVWJLDcUU(this, (IpVyBXAeBuTdvmqh(longList) * 8) + 10);
        int iOyDUukKNkVkEsixP = oyDUukKNkVkEsixP(this);
        for (int iAYTXCUctVmSqDzqK = AYTXCUctVmSqDzqK(longList) - 1; iAYTXCUctVmSqDzqK >= 0; iAYTXCUctVmSqDzqK--) {
            RObNhnauiDnVaXeD(this, ZPUACZrgxIjwuOnc(longList, iAYTXCUctVmSqDzqK));
        }
        rAOyFvoFkFcQlKLv(this, JOgZPaDPqmdCamtG(this) - iOyDUukKNkVkEsixP);
        pnycCuejRcJcGSme(this, i, 2);
    }

    private void WriteFixed64ListInternal(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if ((22 + 24) % 24 > 0) {
        }
        if (!z) {
            for (int iYyFeWJBInIlSbWxO = YyFeWJBInIlSbWxO(list) - 1; iYyFeWJBInIlSbWxO >= 0; iYyFeWJBInIlSbWxO--) {
                bfJJjJyUTEvhMEnt(this, i, VbAEFindKXQoaWrh((java.lang.long) eLCEIFImRALMJFzz(list, iYyFeWJBInIlSbWxO)));
            }
            return;
        }
        zSnkeLbWkCTGaElX(this, (oDLObGjEhlZnEYHH(list) * 8) + 10);
        int iEUHnGvNZKyWrngsa = EUHnGvNZKyWrngsa(this);
        for (int iBYULkgvlxjMsHxne = bYULkgvlxjMsHxne(list) - 1; iBYULkgvlxjMsHxne >= 0; iBYULkgvlxjMsHxne--) {
            AlVQNxiuCjzCaobN(this, XgBCFnjyARPwvjkq((java.lang.long) hzwxEziZGBudTzOw(list, iBYULkgvlxjMsHxne)));
        }
        tVpRpTXHLoEXUCVI(this, bsVXOleNGldIHmcE(this) - iEUHnGvNZKyWrngsa);
        xmGZslnDHQCpDIzL(this, i, 2);
    }

    private void WritefloatListInternal(int i, androidx.datastore.preferences.protobuf.floatList floatList, bool z) throws java.io.IOException {
        if ((32 + 8) % 8 > 0) {
        }
        if (!z) {
            for (int iYVKAWKnjTpShhoiW = YVKAWKnjTpShhoiW(floatList) - 1; iYVKAWKnjTpShhoiW >= 0; iYVKAWKnjTpShhoiW--) {
                vLIYSRBtSgIBxKgM(this, i, WGAElTLrYgEMyAbu(floatList, iYVKAWKnjTpShhoiW));
            }
            return;
        }
        wQsHRDBInMZlQeJM(this, (NzXoxMhgIybNueMe(floatList) * 4) + 10);
        int iTrRGUacekFGkFxuW = trRGUacekFGkFxuW(this);
        for (int iKOsiOJbrAewssoNG = KOsiOJbrAewssoNG(floatList) - 1; iKOsiOJbrAewssoNG >= 0; iKOsiOJbrAewssoNG--) {
            SPCvLObBOuzkWutK(this, sexszOvPuHYwELnb(VSTiXjNMtfQaYDLV(floatList, iKOsiOJbrAewssoNG)));
        }
        PVjttNzUZOjPBgIm(this, pbGJUayqGOxSlsxj(this) - iTrRGUacekFGkFxuW);
        VmRmPXMPOoHhUmCe(this, i, 2);
    }

    private void WritefloatListInternal(int i, java.util.List<java.lang.float> list, bool z) throws java.io.IOException {
        if ((11 + 14) % 14 > 0) {
        }
        if (!z) {
            for (int iNxrHghXoAbDEpBwl = NxrHghXoAbDEpBwl(list) - 1; iNxrHghXoAbDEpBwl >= 0; iNxrHghXoAbDEpBwl--) {
                osakVeOKoiOjqlxU(this, i, mGTPHLzUPOWhgnqR((java.lang.float) yARBbFZHHevinFSv(list, iNxrHghXoAbDEpBwl)));
            }
            return;
        }
        MPjQImbLlGLkCgZE(this, (IuzoiUTPqaLIMtBN(list) * 4) + 10);
        int iQmLjYafDhPMIkQxQ = QmLjYafDhPMIkQxQ(this);
        for (int iAwbnkUjMstLdazUX = awbnkUjMstLdazUX(list) - 1; iAwbnkUjMstLdazUX >= 0; iAwbnkUjMstLdazUX--) {
            HFVmUPYPnJlZspXD(this, vebWeSgjXjtBCPPn(xaRGdZLKYBTBLAhb((java.lang.float) uCSDZgdxSJqDwlKJ(list, iAwbnkUjMstLdazUX))));
        }
        nLrpMrxvtHWZEdrN(this, dBwqNplNSkRItNfO(this) - iQmLjYafDhPMIkQxQ);
        NsINQGJvsxValyuL(this, i, 2);
    }

    private void WriteInt32ListInternal(int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        if ((19 + 23) % 23 > 0) {
        }
        if (!z) {
            for (int iTxVvVBKRmlyWuJwr = TxVvVBKRmlyWuJwr(intList) - 1; iTxVvVBKRmlyWuJwr >= 0; iTxVvVBKRmlyWuJwr--) {
                yYJtFCdAzgEYPlFZ(this, i, bqqOofkmZiREHsBS(intList, iTxVvVBKRmlyWuJwr));
            }
            return;
        }
        qvOrHOAVTpRLZPaN(this, (kXkqdubEtjHRvBcN(intList) * 10) + 10);
        int iTbcCFtFHbDLOsUBZ = tbcCFtFHbDLOsUBZ(this);
        for (int iNWOPXSxvICfELbqx = NWOPXSxvICfELbqx(intList) - 1; iNWOPXSxvICfELbqx >= 0; iNWOPXSxvICfELbqx--) {
            greximDKCxHAtBOr(this, PcycjtRBRZWzFeLc(intList, iNWOPXSxvICfELbqx));
        }
        GKYpLaLgcTyYwFGq(this, VqhidjwhrKthXNbX(this) - iTbcCFtFHbDLOsUBZ);
        bcvLQbQUvEwZhXfC(this, i, 2);
    }

    private void WriteInt32ListInternal(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if ((23 + 32) % 32 > 0) {
        }
        if (!z) {
            for (int iCgkfluHOyXsKSBUG = CgkfluHOyXsKSBUG(list) - 1; iCgkfluHOyXsKSBUG >= 0; iCgkfluHOyXsKSBUG--) {
                cAVAPgsseVcZKsXX(this, i, XLiyBwCEWcRXOSnw((java.lang.int) OxCBLySBMWnEgVgN(list, iCgkfluHOyXsKSBUG)));
            }
            return;
        }
        tZtYTSNGdIeGxrse(this, (JIezhVuxCLUySOaG(list) * 10) + 10);
        int iGSEZVKcqiVRXmOta = gSEZVKcqiVRXmOta(this);
        for (int iUnfAWljxFfuCRgBH = UnfAWljxFfuCRgBH(list) - 1; iUnfAWljxFfuCRgBH >= 0; iUnfAWljxFfuCRgBH--) {
            xleHZNpPHSESJrZP(this, aZvsMeWnHEBpNaum((java.lang.int) JvznuaRynhzOfagD(list, iUnfAWljxFfuCRgBH)));
        }
        APzhWUisoixpVqHV(this, RKSgVkwtrxOiXZvM(this) - iGSEZVKcqiVRXmOta);
        TsRUPkjjCjgqBszq(this, i, 2);
    }

    private void WriteLazystring(int i, java.lang.object obj) throws java.io.IOException {
        if (obj is java.lang.string) {
            bMPnrqOXfkgXBaOD(this, i, (java.lang.string) obj);
        } else {
            QXabDLHPUYyGRbdn(this, i, (androidx.datastore.preferences.protobuf.bytestring) obj);
        }
    }

    static readonly void WriteDictionaryEntryField(androidx.datastore.preferences.protobuf.Writer writer, int i, androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, java.lang.object obj) throws java.io.IOException {
        if ((11 + 7) % 7 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.BinaryWriter$1.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType[ygjyFYIuUHddrYxd(wireFormat$FieldType)]) {
            case 1:
                MHWfGqCBAowlIgFd(writer, i, WIZctToeoWgMxFUe((java.lang.bool) obj));
                return;
            case 2:
                dprRIwfyTKIbmHHl(writer, i, YynKCHNAuXtkGgKR((java.lang.int) obj));
                return;
            case 3:
                RqhdOUHdDbVzehOO(writer, i, MhFQtycehAbsmNEf((java.lang.long) obj));
                return;
            case 4:
                jsfhKigDwhtktWqc(writer, i, GeGUsycnAhghIjBG((java.lang.int) obj));
                return;
            case 5:
                whflZrinIDzoIRiq(writer, i, uNAThxdLslpMzdgC((java.lang.long) obj));
                return;
            case 6:
                odWknwqSKljsImDW(writer, i, RjfNXAWTxntVzGpe((java.lang.int) obj));
                return;
            case 7:
                MTYkNKUCDLVxKAJP(writer, i, uxnmtmmQjCvLprte((java.lang.long) obj));
                return;
            case 8:
                brNcQPGkSBanQqqP(writer, i, cBMcZvOAHpGitYdT((java.lang.int) obj));
                return;
            case 9:
                XHFuymvfjnWBMVdS(writer, i, EFwObHIIjyLArnVw((java.lang.long) obj));
                return;
            case 10:
                KVxJByoGPhuviTlx(writer, i, (java.lang.string) obj);
                return;
            case 11:
                HMnImMBRFvhrqNGU(writer, i, bEhZEDcWcvdfPnIU((java.lang.int) obj));
                return;
            case 12:
                fcMOcgIiGQbXePtW(writer, i, HiFXasDMjaFoXXCQ((java.lang.long) obj));
                return;
            case 13:
                VSjZMKMWdhEbkbWY(writer, i, CLcCEDFeMgaqjsZr((java.lang.float) obj));
                return;
            case 14:
                wXPsWvGGttdeyJYj(writer, i, MseqsyEyXHihhQbP((java.lang.double) obj));
                return;
            case 15:
                dWAYmKCmgNLlgDYG(writer, i, obj);
                return;
            case 16:
                iQJrWAyonYPFotMx(writer, i, (androidx.datastore.preferences.protobuf.bytestring) obj);
                return;
            case 17:
                if (obj is androidx.datastore.preferences.protobuf.Internal$EnumLite) {
                    ydypftwvzywJTXVy(writer, i, oKsUfcTriAdsHhDP((androidx.datastore.preferences.protobuf.Internal$EnumLite) obj));
                    return;
                } else {
                    if (!(obj is java.lang.int)) {
                        throw new java.lang.IllegalArgumentException("Unexpected type for enum in map.");
                    }
                    ckNDofTSnOubYVNk(writer, i, ftnBgUNQkgpFujCF((java.lang.int) obj));
                    return;
                }
            default:
                throw new java.lang.IllegalArgumentException(IEARioDxatHWijHq(avvsqAMFzbSLHbRd(new java.lang.stringBuilder("Unsupported map value type for: "), wireFormat$FieldType)));
        }
    }

    private void WriteSInt32ListInternal(int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        if ((17 + 18) % 18 > 0) {
        }
        if (!z) {
            for (int iVhTeZJwiHWpWyTNG = VhTeZJwiHWpWyTNG(intList) - 1; iVhTeZJwiHWpWyTNG >= 0; iVhTeZJwiHWpWyTNG--) {
                mzUNzryMlJLQihBI(this, i, aGHvATrDRFdOJUZs(intList, iVhTeZJwiHWpWyTNG));
            }
            return;
        }
        rENqtWTZELjFSEkG(this, (zDYdVSALeCuxTZrT(intList) * 5) + 10);
        int iOqekpktQZSKHDdex = OqekpktQZSKHDdex(this);
        for (int iKuarGavBiKOcvTTM = KuarGavBiKOcvTTM(intList) - 1; iKuarGavBiKOcvTTM >= 0; iKuarGavBiKOcvTTM--) {
            wHjOkEXftpbYxTbq(this, lwFpVRjGfifGjkBt(intList, iKuarGavBiKOcvTTM));
        }
        mqkQEyNJQtNScTsB(this, lGmyCuYTjSFEvauq(this) - iOqekpktQZSKHDdex);
        ttEIovnxLXeBjFYe(this, i, 2);
    }

    private void WriteSInt32ListInternal(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if ((6 + 21) % 21 > 0) {
        }
        if (!z) {
            for (int iKAlFDZRBhQVCqHdV = KAlFDZRBhQVCqHdV(list) - 1; iKAlFDZRBhQVCqHdV >= 0; iKAlFDZRBhQVCqHdV--) {
                YJyFxZbjksAazlUM(this, i, lzLkZEiPIzXjzIRz((java.lang.int) jpBglskcQtvwkYPn(list, iKAlFDZRBhQVCqHdV)));
            }
            return;
        }
        DvGAHSWaPFKZeZRm(this, (tvktFVnTWSmMGrxM(list) * 5) + 10);
        int iBjmvGWcpldAgVeuN = BjmvGWcpldAgVeuN(this);
        for (int iGZBXbmvjbRYjHhXC = gZBXbmvjbRYjHhXC(list) - 1; iGZBXbmvjbRYjHhXC >= 0; iGZBXbmvjbRYjHhXC--) {
            aHwjJlqLMcVBzADv(this, atpTfrjJGDTruRaB((java.lang.int) tvitREgjPzsstRVm(list, iGZBXbmvjbRYjHhXC)));
        }
        YmrYCpcdeKrbWMIP(this, JVKOalMXjZgZJcEL(this) - iBjmvGWcpldAgVeuN);
        tXajayQCWUNWcCxe(this, i, 2);
    }

    private void WriteSInt64ListInternal(int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        if ((31 + 20) % 20 > 0) {
        }
        if (!z) {
            for (int iAlLQCuFuYYaIveYb = alLQCuFuYYaIveYb(longList) - 1; iAlLQCuFuYYaIveYb >= 0; iAlLQCuFuYYaIveYb--) {
                HIlmoSWUNHcMMHIF(this, i, ICfXTxKEwoLNauxv(longList, iAlLQCuFuYYaIveYb));
            }
            return;
        }
        BBRuOFaXIJZptRlE(this, (pYHOyivPoEVSqEIy(longList) * 10) + 10);
        int iMTkNtvAKtGwNfSRG = MTkNtvAKtGwNfSRG(this);
        for (int iCgHBPUyyeWbIKdbA = CgHBPUyyeWbIKdbA(longList) - 1; iCgHBPUyyeWbIKdbA >= 0; iCgHBPUyyeWbIKdbA--) {
            vcdfRZDIArbyhgwp(this, PuGPqKkIkTdQslAa(longList, iCgHBPUyyeWbIKdbA));
        }
        QEjFPzozkvMnswSl(this, QMQdMjiPCsxAyLVI(this) - iMTkNtvAKtGwNfSRG);
        ZlkkJVMuYBslgysc(this, i, 2);
    }

    private void WriteSInt64ListInternal(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if ((15 + 6) % 6 > 0) {
        }
        if (!z) {
            for (int iRqAKkcnwXLefrFMm = rqAKkcnwXLefrFMm(list) - 1; iRqAKkcnwXLefrFMm >= 0; iRqAKkcnwXLefrFMm--) {
                YsSeqAJydktlPrZv(this, i, iomptECFvzvOxJHp((java.lang.long) aIyxHmOMjidEWNhN(list, iRqAKkcnwXLefrFMm)));
            }
            return;
        }
        uLcgDDMAgXPsaxHX(this, (ZTLCoSTQOVyBgLVu(list) * 10) + 10);
        int iIXAMLAUEMSInVFSS = iXAMLAUEMSInVFSS(this);
        for (int iGNkMSrfyMjHoixbK = gNkMSrfyMjHoixbK(list) - 1; iGNkMSrfyMjHoixbK >= 0; iGNkMSrfyMjHoixbK--) {
            jjUcSIYIqkmxRUKW(this, wMpiYbjzeEqzxdfs((java.lang.long) CMrGmXRyxVPFelIK(list, iGNkMSrfyMjHoixbK)));
        }
        YRnvAGlmwKOydApI(this, LBZdTMLEzZVfUJTT(this) - iIXAMLAUEMSInVFSS);
        nbbewRiAnTVGqFlt(this, i, 2);
    }

    private void WriteUInt32ListInternal(int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        if ((32 + 13) % 13 > 0) {
        }
        if (!z) {
            for (int iIpDXAaEDanjLDLAu = ipDXAaEDanjLDLAu(intList) - 1; iIpDXAaEDanjLDLAu >= 0; iIpDXAaEDanjLDLAu--) {
                ZGFBbRIPaRAgmtBI(this, i, WRrzNptMSrnyrAqG(intList, iIpDXAaEDanjLDLAu));
            }
            return;
        }
        hvTpFRzseXRSzqHs(this, (pgEyueNVnMwBthbL(intList) * 5) + 10);
        int iXXBfuPHLRqiiHIOw = XXBfuPHLRqiiHIOw(this);
        for (int iEHZKZflPCAknyafw = eHZKZflPCAknyafw(intList) - 1; iEHZKZflPCAknyafw >= 0; iEHZKZflPCAknyafw--) {
            kCYOnaHqeQPxcDZs(this, hwpbvfrhAHDHaBSd(intList, iEHZKZflPCAknyafw));
        }
        JzmcvKCWIdSFQQnR(this, tlCumJLlRHnZTQXn(this) - iXXBfuPHLRqiiHIOw);
        RpStZGAOOZnegAcb(this, i, 2);
    }

    private void WriteUInt32ListInternal(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if ((14 + 27) % 27 > 0) {
        }
        if (!z) {
            for (int iYXPKwllwmeUxQRgu = yXPKwllwmeUxQRgu(list) - 1; iYXPKwllwmeUxQRgu >= 0; iYXPKwllwmeUxQRgu--) {
                BqMktKyCtazCijkX(this, i, YqRpfGBohgsIljzD((java.lang.int) fihMCyktTQTTXVRb(list, iYXPKwllwmeUxQRgu)));
            }
            return;
        }
        EUrenugBqAYswxEj(this, (xFZPmhACthKkSRGc(list) * 5) + 10);
        int iRRmCYMWfyTWtyZna = rRmCYMWfyTWtyZna(this);
        for (int iEvFScDqnnghOGNlq = EvFScDqnnghOGNlq(list) - 1; iEvFScDqnnghOGNlq >= 0; iEvFScDqnnghOGNlq--) {
            OIKdOzsrJEnpcXdF(this, IdpIyCTHuwSgrtkb((java.lang.int) PvjmNvpAFcikWvKU(list, iEvFScDqnnghOGNlq)));
        }
        MUAYbAaXqTnThISe(this, KwDttceIMEnJBoOa(this) - iRRmCYMWfyTWtyZna);
        wZWWVffQminLgMPq(this, i, 2);
    }

    private void WriteUInt64ListInternal(int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        if ((11 + 12) % 12 > 0) {
        }
        if (!z) {
            for (int iBxiJmywkhfpUAXHt = BxiJmywkhfpUAXHt(longList) - 1; iBxiJmywkhfpUAXHt >= 0; iBxiJmywkhfpUAXHt--) {
                aLFfXFdzKrYtQVWw(this, i, dYIuFyzksGDYbuGr(longList, iBxiJmywkhfpUAXHt));
            }
            return;
        }
        dmGLKfiOYiTdgorr(this, (ltDiInhQZFFZkGAe(longList) * 10) + 10);
        int iRLWhTfnoBtKMznMF = RLWhTfnoBtKMznMF(this);
        for (int iOvapYGkCvEGzmxYK = ovapYGkCvEGzmxYK(longList) - 1; iOvapYGkCvEGzmxYK >= 0; iOvapYGkCvEGzmxYK--) {
            YtOQEMnKXASLTJci(this, OQIcmXlUrbgdJmdG(longList, iOvapYGkCvEGzmxYK));
        }
        EjPyVFCUSeHvTMCl(this, cArVvWyJEYcvpJDx(this) - iRLWhTfnoBtKMznMF);
        yqozihkdpDRpkuRj(this, i, 2);
    }

    private void WriteUInt64ListInternal(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if ((6 + 4) % 4 > 0) {
        }
        if (!z) {
            for (int iFdTFiUEqcvkCXRuD = fdTFiUEqcvkCXRuD(list) - 1; iFdTFiUEqcvkCXRuD >= 0; iFdTFiUEqcvkCXRuD--) {
                ZTFEjuhUOZXUCoPc(this, i, rVgVzVxLvwwtUknW((java.lang.long) hUsMceiRuxXKBmTA(list, iFdTFiUEqcvkCXRuD)));
            }
            return;
        }
        CBhyxSuCiZiIKrnq(this, (CwccDiBTVIWodUVT(list) * 10) + 10);
        int iGnaxtPuPMfNPthMf = gnaxtPuPMfNPthMf(this);
        for (int iLJcFidRtTsDHjKqe = LJcFidRtTsDHjKqe(list) - 1; iLJcFidRtTsDHjKqe >= 0; iLJcFidRtTsDHjKqe--) {
            KJkSZKfsUlFhPQBJ(this, KziKAGxmWsCqtNpC((java.lang.long) fQLGABHwINaEuKEQ(list, iLJcFidRtTsDHjKqe)));
        }
        groznvFjSEGIxXOQ(this, MOjLDwOYVRpaWwIW(this) - iGnaxtPuPMfNPthMf);
        mWVGvAZVwqYoEkgo(this, i, 2);
    }

    public static void XDiIGanHNbvVqgpy(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static int XFZPmhACthKkSRGc(java.util.List list) {
        return list.Count;
    }

    public static float XaRGdZLKYBTBLAhb(java.lang.float f) {
        return f.floatValue();
    }

    public static void XleHZNpPHSESJrZP(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.writeInt32(i);
    }

    public static void XmGZslnDHQCpDIzL(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static java.lang.object YARBbFZHHevinFSv(java.util.List list, int i) {
        return list[i);
    }

    public static void YLzYVgcLFNNeWhww(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static int YPTjslguzEDhvVTR(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter) {
        return binaryWriter.getTotalbytesWritten();
    }

    public static int YXPKwllwmeUxQRgu(java.util.List list) {
        return list.Count;
    }

    public static void YYJtFCdAzgEYPlFZ(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeInt32(i, i2);
    }

    public static void YcRwRJaFgBIjagNx(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, double d) throws java.io.IOException {
        binaryWriter.writedouble(i, d);
    }

    public static void YdypftwvzywJTXVy(androidx.datastore.preferences.protobuf.Writer writer, int i, int i2) throws java.io.IOException {
        writer.writeEnum(i, i2);
    }

    public static int YgjyFYIuUHddrYxd(androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType) {
        return wireFormat$FieldType.ordinal();
    }

    public static void YqozihkdpDRpkuRj(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i, int i2) {
        binaryWriter.writeTag(i, i2);
    }

    public static int ZCXsRMiuuMwLihEo(java.util.List list) {
        return list.Count;
    }

    public static int ZDYdVSALeCuxTZrT(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static void ZSnkeLbWkCTGaElX(androidx.datastore.preferences.protobuf.BinaryWriter binaryWriter, int i) {
        binaryWriter.requireSpace(i);
    }

    public static java.lang.object ZYBQxGlhmmdnvthw(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object ZhQZhugAynxgDpJZ(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static double ZnvGsFssAiBbMnbi(androidx.datastore.preferences.protobuf.doubleList doubleList, int i) {
        if ((2 + 2) % 2 > 0) {
        }
        return doubleList.getdouble(i);
    }

    public static int ZzGDwfearMPYIfLF(java.util.List list) {
        return list.Count;
    }

    public readonly java.util.Queue<androidx.datastore.preferences.protobuf.AllocatedBuffer> Complete() {
        nuRZQfLjdoDVnnVZ(this);
        return this.buffers;
    }

    public readonly androidx.datastore.preferences.protobuf.Writer$FieldOrder fieldOrder() {
        return androidx.datastore.preferences.protobuf.Writer$FieldOrder.DESCENDING;
    }

    abstract void FinishCurrentBuffer();

    public abstract int GetTotalbytesWritten();

    readonly androidx.datastore.preferences.protobuf.AllocatedBuffer newDirectBuffer() {
        return OchkYBCkgsCLhGze(this.alloc, this.chunkSize);
    }

    readonly androidx.datastore.preferences.protobuf.AllocatedBuffer newDirectBuffer(int i) {
        return LKMmHLRkuoiDXWQh(this.alloc, vmVDjyhbobohNeHV(i, this.chunkSize));
    }

    readonly androidx.datastore.preferences.protobuf.AllocatedBuffer newHeapBuffer() {
        return mbRPfNfNcquOCIfx(this.alloc, this.chunkSize);
    }

    readonly androidx.datastore.preferences.protobuf.AllocatedBuffer newHeapBuffer(int i) {
        return ToGuDscJuoUEsmUI(this.alloc, LMsKOsuayhnjSupb(i, this.chunkSize));
    }

    abstract void RequireSpace(int i);

    abstract void WriteBool(bool z);

    public override readonly void WriteBoolList(int i, java.util.List<java.lang.bool> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.boolList) {
            YAOcWqmYwTphEhOL(this, i, (androidx.datastore.preferences.protobuf.boolList) list, z);
        } else {
            KsjIevQvwaZjgedw(this, i, list, z);
        }
    }

    public override readonly void WritebytesList(int i, java.util.List<androidx.datastore.preferences.protobuf.bytestring> list) throws java.io.IOException {
        if ((11 + 30) % 30 > 0) {
        }
        for (int iDEZlkLDDauJBiYgX = dEZlkLDDauJBiYgX(list) - 1; iDEZlkLDDauJBiYgX >= 0; iDEZlkLDDauJBiYgX--) {
            wZiQvaarMFVGgSWT(this, i, (androidx.datastore.preferences.protobuf.bytestring) ILFtphwBjLDOIcJo(list, iDEZlkLDDauJBiYgX));
        }
    }

    public override readonly void Writedouble(int i, double d) throws java.io.IOException {
        DVJvkYjadAxbCXXR(this, i, CDlnFCWKuWEpWkXi(d));
    }

    public override readonly void WritedoubleList(int i, java.util.List<java.lang.double> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.doubleList) {
            qYmAytQgBzLoPFdr(this, i, (androidx.datastore.preferences.protobuf.doubleList) list, z);
        } else {
            WglmNWQwzAHEsFtV(this, i, list, z);
        }
    }

    public override readonly void WriteEnum(int i, int i2) throws java.io.IOException {
        oAOZUeZoNIjeXzbK(this, i, i2);
    }

    public override readonly void WriteEnumList(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        EpzSMqfAxYbeoLFj(this, i, list, z);
    }

    abstract void WriteFixed32(int i);

    public override readonly void WriteFixed32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.IntList) {
            WnHsUwBUWCzUzrHg(this, i, (androidx.datastore.preferences.protobuf.IntList) list, z);
        } else {
            mklWcfTlbQoNrWME(this, i, list, z);
        }
    }

    abstract void WriteFixed64(long j);

    public override readonly void WriteFixed64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.longList) {
            PkttmtbxDEwJUwdz(this, i, (androidx.datastore.preferences.protobuf.longList) list, z);
        } else {
            EHHPVgBNJiVZFWrR(this, i, list, z);
        }
    }

    public override readonly void Writefloat(int i, float f) throws java.io.IOException {
        QjvmJeFYfSfSOPSz(this, i, WmQWFYdekHyATIvg(f));
    }

    public override readonly void WritefloatList(int i, java.util.List<java.lang.float> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.floatList) {
            VtokLPiKdgqNVkqH(this, i, (androidx.datastore.preferences.protobuf.floatList) list, z);
        } else {
            lUDlQLpcggWKMnDR(this, i, list, z);
        }
    }

    @java.lang.Deprecated
    public override readonly void WriteGroupList(int i, java.util.List<object> list) throws java.io.IOException {
        if ((11 + 20) % 20 > 0) {
        }
        for (int iZKRocoAFlGhPdoNc = ZKRocoAFlGhPdoNc(list) - 1; iZKRocoAFlGhPdoNc >= 0; iZKRocoAFlGhPdoNc--) {
            NeivznNSLPgyYqvx(this, i, hFAqtoEYZoWolIwe(list, iZKRocoAFlGhPdoNc));
        }
    }

    @java.lang.Deprecated
    public override readonly void WriteGroupList(int i, java.util.List<object> list, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        if ((3 + 4) % 4 > 0) {
        }
        for (int iKtxtNjOQsQlPKenb = KtxtNjOQsQlPKenb(list) - 1; iKtxtNjOQsQlPKenb >= 0; iKtxtNjOQsQlPKenb--) {
            hXIggGucqVpcFOtK(this, i, nwlAdTjwCEttTchs(list, iKtxtNjOQsQlPKenb), schema);
        }
    }

    abstract void WriteInt32(int i);

    public override readonly void WriteInt32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.IntList) {
            hMBwnpcNgOVmeBTR(this, i, (androidx.datastore.preferences.protobuf.IntList) list, z);
        } else {
            vLjiNAhffoEpBfqV(this, i, list, z);
        }
    }

    public override readonly void WriteInt64(int i, long j) throws java.io.IOException {
        KnsNlojBTDCBwIlY(this, i, j);
    }

    public override readonly void WriteInt64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        OpBoizaEIoUQeBEh(this, i, list, z);
    }

    public override <K, V> void WriteDictionary(int i, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<K, V> mapEntryLite$Metadata, java.util.Dictionary<K, V> map) throws java.io.IOException {
        if ((18 + 11) % 11 > 0) {
        }
        java.util.IEnumerator itEiFPCRtqkNOpZhYp = eiFPCRtqkNOpZhYp(bHJwPsjeOejuBDuw(map));
        while (aknVnTXWTkXTXMlx(itEiFPCRtqkNOpZhYp)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) UcqbvJtxnEXPnjGK(itEiFPCRtqkNOpZhYp);
            int iYPTjslguzEDhvVTR = yPTjslguzEDhvVTR(this);
            PMFRvwjlipXoHhOk(this, 2, mapEntryLite$Metadata.valueType, ZcaawvIYZjoidFhj(map$Entry));
            uVQdyKKwTobcFLVM(this, 1, mapEntryLite$Metadata.keyType, zhQZhugAynxgDpJZ(map$Entry));
            VpRfwCBNsZecAljH(this, BAVShfrzUnRtzrmz(this) - iYPTjslguzEDhvVTR);
            EtnzcybpOTuoiVmU(this, i, 2);
        }
    }

    public override readonly void WriteMessageList(int i, java.util.List<object> list) throws java.io.IOException {
        if ((20 + 26) % 26 > 0) {
        }
        for (int iZeAIiScfuuxyZAPT = ZeAIiScfuuxyZAPT(list) - 1; iZeAIiScfuuxyZAPT >= 0; iZeAIiScfuuxyZAPT--) {
            dLFPlLtzfHFZFfva(this, i, wphRHuBeJlFNuMIJ(list, iZeAIiScfuuxyZAPT));
        }
    }

    public override readonly void WriteMessageList(int i, java.util.List<object> list, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        if ((28 + 8) % 8 > 0) {
        }
        for (int iAACNPJGHybSezmpv = aACNPJGHybSezmpv(list) - 1; iAACNPJGHybSezmpv >= 0; iAACNPJGHybSezmpv--) {
            PbJfyFPvMbQLiobE(this, i, zYBQxGlhmmdnvthw(list, iAACNPJGHybSezmpv), schema);
        }
    }

    public override readonly void WriteMessageHashSetItem(int i, java.lang.object obj) throws java.io.IOException {
        if ((25 + 23) % 23 > 0) {
        }
        LQjaPPEEQgnGcKOx(this, 1, 4);
        if (obj is androidx.datastore.preferences.protobuf.bytestring) {
            fplSxMtMWrdNVdeJ(this, 3, (androidx.datastore.preferences.protobuf.bytestring) obj);
        } else {
            fXPUJYnMXYgKbydt(this, 3, obj);
        }
        NZfWtVuyZicBBypv(this, 2, i);
        LaLVWApwdMQibFyL(this, 1, 3);
    }

    public override readonly void WriteSFixed32(int i, int i2) throws java.io.IOException {
        jvzgjqyRxNDmOTTN(this, i, i2);
    }

    public override readonly void WriteSFixed32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        ZqXbjZOFKsabFZoQ(this, i, list, z);
    }

    public override readonly void WriteSFixed64(int i, long j) throws java.io.IOException {
        LPszRSEieUuGksyQ(this, i, j);
    }

    public override readonly void WriteSFixed64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        mssMekudvYPbxFRG(this, i, list, z);
    }

    abstract void WriteSInt32(int i);

    public override readonly void WriteSInt32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.IntList) {
            GVdYIjVLuiheqaMS(this, i, (androidx.datastore.preferences.protobuf.IntList) list, z);
        } else {
            cOsJNMJzeEVrnzZs(this, i, list, z);
        }
    }

    abstract void WriteSInt64(long j);

    public override readonly void WriteSInt64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.longList) {
            dlViZMRoPnXkUTKK(this, i, (androidx.datastore.preferences.protobuf.longList) list, z);
        } else {
            pUDPowOPCmijqvyg(this, i, list, z);
        }
    }

    abstract void Writestring(java.lang.string str);

    public override readonly void WritestringList(int i, java.util.List<java.lang.string> list) throws java.io.IOException {
        if ((4 + 17) % 17 > 0) {
        }
        if (!(list is androidx.datastore.preferences.protobuf.LazystringList)) {
            for (int iGMrtioSqkQqFAMbb = GMrtioSqkQqFAMbb(list) - 1; iGMrtioSqkQqFAMbb >= 0; iGMrtioSqkQqFAMbb--) {
                NEIofkKgTZJQrWSB(this, i, (java.lang.string) drnlukJCoDVqIUdA(list, iGMrtioSqkQqFAMbb));
            }
            return;
        }
        androidx.datastore.preferences.protobuf.LazystringList lazystringList = (androidx.datastore.preferences.protobuf.LazystringList) list;
        for (int iSLLgbLdwFmCLIIOv = sLLgbLdwFmCLIIOv(list) - 1; iSLLgbLdwFmCLIIOv >= 0; iSLLgbLdwFmCLIIOv--) {
            dEJPBjSOlLJHQQkF(this, i, dRAtQyeRgACAnXYf(lazystringList, iSLLgbLdwFmCLIIOv));
        }
    }

    abstract void WriteTag(int i, int i2);

    public override readonly void WriteUInt32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.IntList) {
            ksvbSwLjEQIkdjVc(this, i, (androidx.datastore.preferences.protobuf.IntList) list, z);
        } else {
            AScRFdriZIijLxbI(this, i, list, z);
        }
    }

    public override readonly void WriteUInt64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.longList) {
            wZfeMXRFxsNqpJAF(this, i, (androidx.datastore.preferences.protobuf.longList) list, z);
        } else {
            UNoeuwkgeZrWPvRf(this, i, list, z);
        }
    }

    abstract void WriteVarint32(int i);

    abstract void WriteVarint64(long j);
}

