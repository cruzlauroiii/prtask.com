namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class CodedStreamWriter : androidx.datastore.preferences.protobuf.Writer {
    private readonly androidx.datastore.preferences.protobuf.CodedStream output;

    private CodedStreamWriter(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        androidx.datastore.preferences.protobuf.CodedStream codedStream2 = (androidx.datastore.preferences.protobuf.CodedStream) nWMHpWsnjHNfFrti(codedStream, "output");
        this.output = codedStream2;
        codedStream2.wrapper = this;
    }

    public static long ABXcMJIIAViuaeZr(java.lang.long l) {
        if ((4 + 23) % 23 > 0) {
        }
        return l.longValue();
    }

    public static void AGHpDjyTQXRpYonT(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeEnum(i, i2);
    }

    public static int AaRuuyCywUsGYxQz(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static void AcWLahuboayWwKvB(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static java.lang.bool AgfIGTbQxFFWFyVb(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void BaHUYHuXMlYZHnyD(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeFixed64NoTag(j);
    }

    public static int BeLAWNiQSUcKfOBn(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object BgZQzaJBRThnTNcz(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.long BiPdkkypBDeQlemr(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void BkorWarCwtenlLpg(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, double d) throws java.io.IOException {
        codedStream.writedouble(i, d);
    }

    public static java.lang.object BtxCOoSDkKiCctxs(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void BxIIMUCzupghzVCg(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeSFixed64(i, j);
    }

    public static int CFIVYpUEkAafhTfs(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static int CKxsuepXMwQfscSK(androidx.datastore.preferences.protobuf.floatList floatList) {
        return floatList.Count;
    }

    public static void CNrBGlyUpfYLFZGe(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int COHfudvtGPqmBJvP(androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.lang.object obj, java.lang.object obj2) {
        return androidx.datastore.preferences.protobuf.DictionaryEntryLite.computeSerializedSize(mapEntryLite$Metadata, obj, obj2);
    }

    public static void CTBRAkUEqVSTxstC(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, bool z) throws java.io.IOException {
        codedStream.writeBool(i, z);
    }

    public static int CeObrFTLcZoUEjDF(bool z) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeBoolSizeNoTag(z);
    }

    public static void CkqHGzIAfiaZXbpB(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int CqoFbxMBrxFuLarR(long j) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeSFixed64SizeNoTag(j);
    }

    public static java.lang.object CsbvakjETORmaIXS(java.util.List list, int i) {
        return list[i);
    }

    public static int DGRoXznDxIZTwYsD(java.util.List list) {
        return list.Count;
    }

    public static void DIRWAeXNmbLLxefg(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeSInt64(i, j);
    }

    public static long DOSXcEipQtQkDLgE(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((1 + 16) % 16 > 0) {
        }
        return longList.getlong(i);
    }

    public static void DRBNWYTjHWrtmolW(androidx.datastore.preferences.protobuf.CodedStream codedStream, float f) throws java.io.IOException {
        codedStream.writefloatNoTag(f);
    }

    public static java.lang.long DVfVYlIKDBusOikK(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void DWUnBogAiCVhhxLD(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeSFixed64(i, j);
    }

    public static int DgwpSejDxsGvSMYN(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object DinLGZEkawTEiihL(java.util.List list, int i) {
        return list[i);
    }

    public static java.util.HashSet DmnGqFanoldtCQBE(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static void DwCGhPMuTlbFASxY(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeSInt64NoTag(j);
    }

    public static java.lang.object DwlLMMjGEsEmLURC(java.util.List list, int i) {
        return list[i);
    }

    public static int DydZOGUDZLOUgwpM(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static java.lang.object DzKUTGiTmDFOMUpd(java.util.List list, int i) {
        return list[i);
    }

    public static void DzTXNGZZYvbpcyIE(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        codedStreamWriter.writeInt32ListInternal(i, intList, z);
    }

    public static int ECcxigXCYwQcNJCJ(androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.lang.object obj, java.lang.object obj2) {
        return androidx.datastore.preferences.protobuf.DictionaryEntryLite.computeSerializedSize(mapEntryLite$Metadata, obj, obj2);
    }

    public static int EIUQnQKliClcHKOS(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeSFixed32SizeNoTag(i);
    }

    public static long EkEtcnkzBNxUjLdc(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((1 + 31) % 31 > 0) {
        }
        return longList.getlong(i);
    }

    public static int ErgYnnMRVLWuIGeq(java.util.List list) {
        return list.Count;
    }

    public static int EvSUJVcSqCjqxStP(java.util.List list) {
        return list.Count;
    }

    public static void FDkufoiqrcOMKPvL(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeEnumNoTag(i);
    }

    public static int FYtVLMwmyZnTqkct(java.util.List list) {
        return list.Count;
    }

    public static double FdAhdsdywNDCernp(androidx.datastore.preferences.protobuf.doubleList doubleList, int i) {
        if ((2 + 8) % 8 > 0) {
        }
        return doubleList.getdouble(i);
    }

    public static void FjemjRymkRskmDqo(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        codedStreamWriter.writeFixed32ListInternal(i, intList, z);
    }

    public static int FmFyQBawYURnxrPM(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeInt32SizeNoTag(i);
    }

    public static void FmcWQTxJCRysFHTO(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void FunPXdmRqgSIHSkK(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeFixed32NoTag(i);
    }

    public static java.lang.object FxBXwluXIJJVJNAV(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object GJXMTBImMJhgMhrz(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object GKpoLTBakmbcArTw(java.util.List list, int i) {
        return list[i);
    }

    public static int GMLTSZKbpEWThoop(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeEnumSizeNoTag(i);
    }

    public static int GSRhIHcwVyrAyrqG(java.lang.int num) {
        return num.intValue();
    }

    public static int GTBitWZprmsEtzqr(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int GurFodrIZTTeKkUr(java.lang.int num) {
        return num.intValue();
    }

    public static int GyKvjucgFqENKkkH(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int HGbapAshNVVIyEZE(java.util.List list) {
        return list.Count;
    }

    public static void HJLvFUubNDWyZkuY(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writeSFixed64ListInternal(i, (java.util.List<java.lang.long>) list, z);
    }

    public static long HPqKzVIIyGKUjTqe(java.lang.long l) {
        if ((22 + 23) % 23 > 0) {
        }
        return l.longValue();
    }

    public static void HTxGjQjxvwiuKnXv(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void HdmIsHZYguLJOGPU(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, java.lang.string str) throws java.io.IOException {
        codedStream.writestring(i, str);
    }

    public static bool HeUcajSxlnNzQRel(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.isSerializationDeterministic();
    }

    public static java.lang.object HotWSoaAZWNANgdL(java.util.List list, int i) {
        return list[i);
    }

    public static long HuCsIAdWxDFoJcZd(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((31 + 13) % 13 > 0) {
        }
        return longList.getlong(i);
    }

    public static long HxoWDsinTDwqxAOZ(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((29 + 27) % 27 > 0) {
        }
        return longList.getlong(i);
    }

    public static void HzrLElXdvqPSxEqR(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        codedStreamWriter.writeMessage(i, obj, schema);
    }

    public static long IClQbsPjcqdkGQLI(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((3 + 10) % 10 > 0) {
        }
        return longList.getlong(i);
    }

    public static java.lang.object IEIIjPkJRArGKdTi(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void IJamiNCmADpbbgqx(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void INbroQoDjvbcmoIT(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.lang.object obj, java.lang.object obj2) throws java.io.IOException {
        androidx.datastore.preferences.protobuf.DictionaryEntryLite.writeTo(codedStream, mapEntryLite$Metadata, obj, obj2);
    }

    public static void IOOZAsOZUbBvCLLA(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static java.lang.object IPvmqnlGiouyZpIY(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object ISKYyHZdZQlPgipD(java.util.List list, int i) {
        return list[i);
    }

    public static void IfjOiXhwCdFhRVgq(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int InOwTBAzskmBYPDs(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object IuiGJnEhhLFMOGRQ(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void JHveYbBaisesJTPx(androidx.datastore.preferences.protobuf.CodedStream codedStream, bool z) throws java.io.IOException {
        codedStream.writeBoolNoTag(z);
    }

    public static int JKHtLEBhaGyHTVxV(java.util.List list) {
        return list.Count;
    }

    public static void JOdaojDVYlVKYCNE(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeInt32(i, i2);
    }

    public static void JSQEGizuRrmhAcYN(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream.writeRawMessageHashSetExtension(i, bytestring);
    }

    public static java.lang.object JVdQDgJmMtSfcjUI(java.util.List list, int i) {
        return list[i);
    }

    public static int JcKBGIbjqGcwbEtx(java.lang.int num) {
        return num.intValue();
    }

    public static int JhIdrVsOqyraMWoB(long j) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeSInt64SizeNoTag(j);
    }

    public static int JoxUoEkbIjYwoEoM(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static void JtGjhnXOrrfcldbq(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, double d) throws java.io.IOException {
        codedStream.writedouble(i, d);
    }

    public static void KEwJlMPUdrSQGXlg(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeInt64(i, j);
    }

    public static double KPeLTKYteghWghiL(java.lang.double d) {
        if ((21 + 29) % 29 > 0) {
        }
        return d.doubleValue();
    }

    public static java.lang.object KYFQSkyTxnqFSbaP(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object KqsZpGwGABgmBaVO(java.util.List list, int i) {
        return list[i);
    }

    public static int KssCVitVXXsZBjtX(long j) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeFixed64SizeNoTag(j);
    }

    public static void KtjGrougsAxACIom(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeUInt32(i, i2);
    }

    public static int LDgMSbFSosMVrJiM(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeSInt32SizeNoTag(i);
    }

    public static void LIOrJCCPUEyeNOMv(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        codedStreamWriter.writeSFixed32ListInternal(i, intList, z);
    }

    public static java.lang.object LNwSQLuyQSHghsKD(java.util.List list, int i) {
        return list[i);
    }

    public static int LRnwgGvhBbvnjctz(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static void LaxuyTNoGICLqhSB(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static long LjYRfptCYJuzvbGK(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((15 + 23) % 23 > 0) {
        }
        return longList.getlong(i);
    }

    public static java.lang.object LtJjcMdVgLpDtYAk(androidx.datastore.preferences.protobuf.LazystringList lazystringList, int i) {
        return lazystringList.getRaw(i);
    }

    public static int LuFlZAMXfIGFHsYA(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeEnumSizeNoTag(i);
    }

    public static int LvxIMXjYzBgYWcQg(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void LyVSPWPwAQhfhEPE(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeUInt64(i, j);
    }

    public static int MATSiNuaNFueCcIn(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static int MIXevlPbVdpdEJru(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object MVlwhEASjTTItmff(java.util.List list, int i) {
        return list[i);
    }

    public static float MZCnhVjbmZDeyCEy(java.lang.float f) {
        return f.floatValue();
    }

    public static void MbTMROUlYkHTiNkV(androidx.datastore.preferences.protobuf.CodedStream codedStream, bool z) throws java.io.IOException {
        codedStream.writeBoolNoTag(z);
    }

    public static void MjtriqxAjgGdogjb(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeSInt64(i, j);
    }

    public static int MuwqfTBMIzsaSyVC(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int NGaxXACyLkhlFOmB(java.util.List list) {
        return list.Count;
    }

    public static void NKwTaxZNUYyzkLRl(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int NLGFMMgwCUgsruHT(java.lang.int num) {
        return num.intValue();
    }

    public static java.util.IEnumerator NMYymtmZtiNfEPgz(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool NNQiaLUHGGZCldVK(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object NicvyRCtPeHHgNKF(java.util.List list, int i) {
        return list[i);
    }

    public static long NjWepYCoDTvZuzFH(java.lang.long l) {
        if ((19 + 22) % 22 > 0) {
        }
        return l.longValue();
    }

    public static int NmrTKGXPaTOWhaMU(double d) {
        return androidx.datastore.preferences.protobuf.CodedStream.computedoubleSizeNoTag(d);
    }

    public static int NoTMMmIrklaZSrlP(java.util.List list) {
        return list.Count;
    }

    public static int NpGgbzdLTdvEHHPt(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeSFixed32SizeNoTag(i);
    }

    public static void NtvbWRywqjkIsUgQ(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int NuLeRZqBkcEDJNgd(java.util.List list) {
        return list.Count;
    }

    public static void NvFnGWDdnNAeBeVO(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        codedStreamWriter.writeUInt32ListInternal(i, intList, z);
    }

    public static long NxmFOsonWGDPnYav(java.lang.long l) {
        if ((29 + 28) % 28 > 0) {
        }
        return l.longValue();
    }

    public static int OXNxoJSQHChjkGiM(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object OhWvwPwHwZUtcfMC(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.int OuBURUOZxyLIinub(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int OxiwryEjJMbyHWVE(androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType) {
        return wireFormat$FieldType.ordinal();
    }

    public static int PDlMZpIvAvYUNVuy(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static int PDlTwFjxDmZiiklV(java.util.List list) {
        return list.Count;
    }

    public static int PNACSyrqfZqHaDVv(java.util.List list) {
        return list.Count;
    }

    public static int PRFQpedPtmRmqHJr(long j) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeInt64SizeNoTag(j);
    }

    public static int PWGZHNCZEYBFSOZV(java.util.List list) {
        return list.Count;
    }

    public static int PZUoaYPCKxROuqdE(java.util.List list) {
        return list.Count;
    }

    public static int PfZIBjKexGCZXFJO(androidx.datastore.preferences.protobuf.boolList boolList) {
        return boolList.Count;
    }

    public static void PkCqOJEsKrSCXOVU(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int PkUSTXIbujQjPKoH(java.util.List list) {
        return list.Count;
    }

    public static float PukZepFrJEMhrruL(androidx.datastore.preferences.protobuf.floatList floatList, int i) {
        return floatList.getfloat(i);
    }

    public static int PzgMVbTXeSOxBucX(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static void QCnDpVRySJEtPOEl(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int QJAgnfwRRlKQTXcY(java.util.List list) {
        return list.Count;
    }

    public static void QTGWYVZQZXZxCHjF(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.lang.object obj, java.lang.object obj2) throws java.io.IOException {
        androidx.datastore.preferences.protobuf.DictionaryEntryLite.writeTo(codedStream, mapEntryLite$Metadata, obj, obj2);
    }

    public static void QanbgVgVpVYmojKd(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writeFixed64ListInternal(i, (java.util.List<java.lang.long>) list, z);
    }

    public static java.lang.object QchYIBXPyTPgqjkr(java.util.List list, int i) {
        return list[i);
    }

    public static int QhGJrRKhxBWMpbHB(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void QhMRTsqhVYNfalsV(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static void QiEbtxjFoGDNgixy(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, bool z) throws java.io.IOException {
        codedStream.writeBool(i, z);
    }

    public static void QiRjoIWPYIRMkFLf(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, java.lang.string str) throws java.io.IOException {
        codedStream.writestring(i, str);
    }

    public static void QjEUulBvaHCsQRij(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, float f) throws java.io.IOException {
        codedStream.writefloat(i, f);
    }

    public static int QrAiryCZOaxEEoAB(java.util.List list) {
        return list.Count;
    }

    public static bool QvlRrjuFqNUjSwGk(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        return boolList.getbool(i);
    }

    public static bool QzAYoCWbWzVbDaJS(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static int RGCDwLdqwjiXmeSn(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int RPDcPixVGZyjpFnN(java.util.List list) {
        return list.Count;
    }

    public static void RPLIZmKZZcVOVAVp(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeUInt64(i, j);
    }

    public static int RaNDvBAzbDBNBTpj(long j) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeSFixed64SizeNoTag(j);
    }

    public static float RdwYjcTeksiHpjpW(androidx.datastore.preferences.protobuf.floatList floatList, int i) {
        return floatList.getfloat(i);
    }

    public static int RfnekGmFdOIfjwTd(java.util.List list) {
        return list.Count;
    }

    public static void RhsPMhQWTjxJFZmZ(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.lang.object obj, java.lang.object obj2) throws java.io.IOException {
        androidx.datastore.preferences.protobuf.DictionaryEntryLite.writeTo(codedStream, mapEntryLite$Metadata, obj, obj2);
    }

    public static void RjsjvmspxdogwSbc(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static float RzUggtxJRfpDXfpu(java.lang.float f) {
        return f.floatValue();
    }

    public static int SALqCrAlYazEbzIa(java.util.List list) {
        return list.Count;
    }

    public static void SIOTFudZxRLROUPj(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeSInt32(i, i2);
    }

    public static int SJTWrBwNAxLlEcfw(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void SWvWBKKrEgBRUpsX(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeFixed64(i, j);
    }

    public static int SbcMHeLLMkhsqtKa(java.util.List list) {
        return list.Count;
    }

    public static void SpZCtFjpcBmNDLmN(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeSFixed32NoTag(i);
    }

    public static void SrHqLgAQwvEaDMcV(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeFixed32(i, i2);
    }

    public static long StvwdBWjnZcbEvYt(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((27 + 17) % 17 > 0) {
        }
        return longList.getlong(i);
    }

    public static int SuvvQvzQSjdGOiyi(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int SuwpDnWlfXQWZzIS(java.util.List list) {
        return list.Count;
    }

    public static void TBHOdZBhbuZcgZnF(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, double d) throws java.io.IOException {
        codedStream.writedouble(i, d);
    }

    public static void THpsXMlNwmpnEgsH(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeSInt64(i, j);
    }

    public static java.lang.object TIOYorWTqKfkPyRc(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static long TbqjgjtDkjZtDBoo(java.lang.long l) {
        if ((19 + 25) % 25 > 0) {
        }
        return l.longValue();
    }

    public static int TeFsjXaAKMqHwCud(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static long TfZjknlNkoDRDZIl(java.lang.long l) {
        if ((6 + 2) % 2 > 0) {
        }
        return l.longValue();
    }

    public static int TfsJrqDRLZHtxynn(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static int ThFBokGpUMhFdlzo(java.util.List list) {
        return list.Count;
    }

    public static void TpHRbGbnJxzDFnnj(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int TqRGwguxBULUMERn(java.lang.int num) {
        return num.intValue();
    }

    public static void TukpDXFQgMguVfQh(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        codedStreamWriter.writeFixed64ListInternal(i, longList, z);
    }

    public static java.lang.object TusmiAADgfHytJFL(java.util.List list, int i) {
        return list[i);
    }

    public static int TxGcslLktcjvCdzL(java.util.List list) {
        return list.Count;
    }

    public static void TxNfbhqrxRnbaPUh(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static java.lang.bool TytSCexrrukEiXXA(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void TzOYMQWWnFUQvDbQ(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.lang.object obj) throws java.io.IOException {
        codedStreamWriter.writeMessage(i, obj);
    }

    public static long UKXrRFVRpuUNsXEn(java.lang.long l) {
        if ((2 + 32) % 32 > 0) {
        }
        return l.longValue();
    }

    public static void URkiMoWsyJABVKIh(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void UUgpKcSjzXKkcpAD(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static java.util.HashSet UWhjBJfMpMMqqjnH(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static int UaqjqidAMnNRFgtM(java.lang.int num) {
        return num.intValue();
    }

    public static bool UdXAhUkJEwPedGiP(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void UgVpixEJUxqbcAcQ(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        codedStreamWriter.writeSFixed64ListInternal(i, longList, z);
    }

    public static void UifuYFIOjtvvRfiw(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void UoTRdJDEqJwBMOpr(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static java.util.HashSet UoUsqaokCvErJusH(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static int UoyGXpIXcKmBeEpR(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeInt32SizeNoTag(i);
    }

    public static java.lang.object UvWVwajfzEXBgKwD(java.util.List list, int i) {
        return list[i);
    }

    public static int VBTWXOiRZxQbAbwu(java.util.List list) {
        return list.Count;
    }

    public static int VJvonEUUmIZgIjIY(androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.lang.object obj, java.lang.object obj2) {
        return androidx.datastore.preferences.protobuf.DictionaryEntryLite.computeSerializedSize(mapEntryLite$Metadata, obj, obj2);
    }

    public static int VMeMglRXgBrPqmvB(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static void VTcqvTtmtfocMNyi(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void VUbSIpdkAFauENMF(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static long VXLnhxfDYQcxgDUE(java.lang.long l) {
        if ((1 + 22) % 22 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.object VkZCrZOudnIHVoGZ(java.util.List list, int i) {
        return list[i);
    }

    public static int VowvEFjTPVziLazF(java.util.Dictionary map) {
        return map.Count;
    }

    public static java.lang.object WBGfvNOyvDZXRiww(java.util.List list, int i) {
        return list[i);
    }

    public static void WUcAToSTRQlKuJOe(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.lang.object obj, java.lang.object obj2) throws java.io.IOException {
        androidx.datastore.preferences.protobuf.DictionaryEntryLite.writeTo(codedStream, mapEntryLite$Metadata, obj, obj2);
    }

    public static void WXlMaXnVDnAUGRSJ(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeEnumNoTag(i);
    }

    public static long WlDJoBTIscPQDGZb(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((12 + 19) % 19 > 0) {
        }
        return longList.getlong(i);
    }

    public static void WmUltdSYbUlwvMQF(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, bool z, java.lang.object obj, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata) throws java.io.IOException {
        codedStreamWriter.writeDeterministicboolDictionaryEntry(i, z, obj, mapEntryLite$Metadata);
    }

    public static void WtbeknFYtYKQwNKT(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeEnum(i, i2);
    }

    public static int WurvDIUnwSBgrcvV(androidx.datastore.preferences.protobuf.floatList floatList) {
        return floatList.Count;
    }

    public static int WzspPUuwrvDfcyUu(double d) {
        return androidx.datastore.preferences.protobuf.CodedStream.computedoubleSizeNoTag(d);
    }

    public static int XBRsUjWwoUVLKIlt(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static void XHDYBsYZgtphekOg(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int XPnFPDlHMwojFXbv(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static java.lang.object XXAnetkjdTRoVJLY(java.util.List list, int i) {
        return list[i);
    }

    public static void XdFAAwwrRkBWsRZD(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeInt32NoTag(i);
    }

    public static int XfrQtcbJuFNQnltp(androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.lang.object obj, java.lang.object obj2) {
        return androidx.datastore.preferences.protobuf.DictionaryEntryLite.computeSerializedSize(mapEntryLite$Metadata, obj, obj2);
    }

    public static void XmQzLjOOovEbtKac(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeInt64NoTag(j);
    }

    public static long XnwcvNlOjHQLkrDX(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((6 + 28) % 28 > 0) {
        }
        return longList.getlong(i);
    }

    public static java.lang.object XqWEIZNgDmRcmiWd(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static double XtIpLdszCcKiHqEp(androidx.datastore.preferences.protobuf.doubleList doubleList, int i) {
        if ((27 + 28) % 28 > 0) {
        }
        return doubleList.getdouble(i);
    }

    public static bool XxmLajCcYiFpCuqO(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        return boolList.getbool(i);
    }

    public static void XyrFaQYTZivmJpAB(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static void YMJBGrvscIjODxqr(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int YRfQvnXxcrYrBDGk(java.lang.int num) {
        return num.intValue();
    }

    public static int YUUvVnMTQdjlcdun(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static int YVbMSEgKuAjZFWJs(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static double YXCJhuPjCzsEVRUl(java.lang.double d) {
        if ((20 + 22) % 22 > 0) {
        }
        return d.doubleValue();
    }

    public static void YaXGbvXZvqoyDWQg(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeUInt32(i, i2);
    }

    public static void YkgoSkmqAMltQMdb(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int YlWwGhLPAyCmUAGB(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static int YpXpHbiOurTHlKEW(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static void YquOWKBZulzmqyzB(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeSInt32NoTag(i);
    }

    public static int YtRCVfqFSJrFsDER(java.util.List list) {
        return list.Count;
    }

    public static float YwTtwXhXXobsRbuX(java.lang.float f) {
        return f.floatValue();
    }

    public static void YxHhjjqlatWOmSkO(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeSFixed64NoTag(j);
    }

    public static java.lang.object ZBtOsoecUxVYmuHm(java.util.List list, int i) {
        return list[i);
    }

    public static int ZEpWzRzXHXlwgyLg(bool z) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeBoolSizeNoTag(z);
    }

    public static int ZHKtrnDIjROMVLRt(androidx.datastore.preferences.protobuf.doubleList doubleList) {
        return doubleList.Count;
    }

    public static void ZRJTSaxiltzmwFBF(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.floatList floatList, bool z) throws java.io.IOException {
        codedStreamWriter.writefloatListInternal(i, floatList, z);
    }

    public static java.lang.object ZWwCBBxAZkkiEsuE(java.util.List list, int i) {
        return list[i);
    }

    public static void ABibFKWoNVAeRZhC(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int AJQvfyNXhaTkgiYe(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.getTotalbytesWritten();
    }

    public static void AKteszsbBUuLSYRH(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void AVpXVCaXRxCtKDxA(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeInt32(i, i2);
    }

    public static int AYERWQrJNSXqnypE(long j) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeInt64SizeNoTag(j);
    }

    public static int BNANNPdPbdpyfgjD(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static void BPuphmjQAwQrODae(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeFixed32(i, i2);
    }

    public static int BTbfvLGTplKjyYfy(java.util.List list) {
        return list.Count;
    }

    public static int BXkqUvmnyVJSUSUU(java.lang.int num) {
        return num.intValue();
    }

    public static void BlDMPrhBixOAhVBH(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeSInt32(i, i2);
    }

    public static int BmtFQBzGNxmnbPlx(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object BsXGJtOfWRGASeCu(java.util.List list, int i) {
        return list[i);
    }

    public static void BwWEBSxPECfbBWVG(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeFixed64(i, j);
    }

    public static void BxOfGtiWQJjrWbUt(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static long BxRrHOEwKcfQwnUO(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((9 + 13) % 13 > 0) {
        }
        return longList.getlong(i);
    }

    public static void CGqAOFspoaEkeJYO(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream.writeMessage(i, messageLite);
    }

    public static int CHWaQUyEZYnJGVRt(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int COTaxFuQsTArLtwd(java.lang.int num) {
        return num.intValue();
    }

    public static int CRwTJWHNXBDGhDzv(java.util.List list) {
        return list.Count;
    }

    public static void CXUCkHKOlApNhoBz(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void CdcEsUFcdJlFIFuy(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writeUInt32ListInternal(i, (java.util.List<java.lang.int>) list, z);
    }

    public static void CmoxoqsrhSnmMosr(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static java.lang.object CyoxTFisfelGhkeO(java.util.List list, int i) {
        return list[i);
    }

    public static void DDNTYQAlZxLUqxYU(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeUInt64(i, j);
    }

    public static void DExjtEUaASpHpNcf(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int DGlXANmRkPCMJxRe(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static int DHitenbuIlWKjZxo(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static void DQSuJhBOFEoJXKnM(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeInt64(i, j);
    }

    public static void DbEzDbPjoTsfuCZx(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int DfMeXuCFpEwLkMHb(java.util.List list) {
        return list.Count;
    }

    public static void DiVJeAWAisiHBHyl(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        codedStreamWriter.writeSInt64ListInternal(i, longList, z);
    }

    public static void DrQAYbazLverMXco(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeFixed64(i, j);
    }

    public static void EDdYFGLazJtavUMe(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeSFixed32(i, i2);
    }

    public static void EDiuKJuSJcZixFhV(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int EKsilyKySFxFEOha(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void ENLlONpAJKTudWNL(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void ENmQNJgaoeXkjraC(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeSFixed32NoTag(i);
    }

    public static int EOotoVrTYirhcrXS(java.lang.int num) {
        return num.intValue();
    }

    public static void EPxWvsNzBqmFxsrG(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.lang.object obj) throws java.io.IOException {
        codedStreamWriter.writeLazystring(i, obj);
    }

    public static java.lang.object EQtxQMtqICWsKWBF(java.util.List list, int i) {
        return list[i);
    }

    public static void ERFvLwKsRqjkXZCD(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static java.lang.object EfTWVukUagvHWjqd(java.util.List list, int i) {
        return list[i);
    }

    public static void EjfycdkAYOUPPivw(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void EmARQTVvggUWQolp(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeFixed32(i, i2);
    }

    public static void EwHTJnvWIuKOIPIT(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.lang.object obj, java.lang.object obj2) throws java.io.IOException {
        androidx.datastore.preferences.protobuf.DictionaryEntryLite.writeTo(codedStream, mapEntryLite$Metadata, obj, obj2);
    }

    public static java.lang.object FAgZtxYVZkInclvi(java.util.List list, int i) {
        return list[i);
    }

    public static void FFrYhyNOcyPrQjJz(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static java.lang.object FFynrXLvnkyeszrM(java.util.List list, int i) {
        return list[i);
    }

    public static int FRytYoXbItLmpAab(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static bool FWtpPFHmNUIfREMj(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static int FhENlliEyPYTxpCp(java.lang.int num) {
        return num.intValue();
    }

    public static androidx.datastore.preferences.protobuf.CodedStreamWriter ForCodedOutput(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        return codedStream.wrapper is null ? new androidx.datastore.preferences.protobuf.CodedStreamWriter(codedStream) : codedStream.wrapper;
    }

    public static java.lang.object FrHTkSfqDMdHKAvN(java.util.IEnumerator it) {
        return it.Current;
    }

    public static long GETbsPSQDwAOYSsJ(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((30 + 5) % 5 > 0) {
        }
        return longList.getlong(i);
    }

    public static void GEbVMshMNluBjRIt(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void GIGScpnByJCuhIml(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.boolList boolList, bool z) throws java.io.IOException {
        codedStreamWriter.writeBoolListInternal(i, boolList, z);
    }

    public static long GPosXizpdFAzKhzb(java.lang.long l) {
        if ((23 + 10) % 10 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.object GTIxrOJkQqodUSbz(java.util.List list, int i) {
        return list[i);
    }

    public static void GYMSWQkBpVpGWJOa(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int GbhMfJmFFIwaiaFY(androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.lang.object obj, java.lang.object obj2) {
        return androidx.datastore.preferences.protobuf.DictionaryEntryLite.computeSerializedSize(mapEntryLite$Metadata, obj, obj2);
    }

    public static long GbkYglEtUEPAQyPy(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((23 + 24) % 24 > 0) {
        }
        return longList.getlong(i);
    }

    public static void GgzflrpeZMKiaZnP(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.util.Dictionary map) throws java.io.IOException {
        codedStreamWriter.writeDeterministicintDictionary(i, mapEntryLite$Metadata, map);
    }

    public static void GhEEWsexgRrbDUYP(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.lang.object obj) throws java.io.IOException {
        codedStreamWriter.writeGroup(i, obj);
    }

    public static int GhdHitIIHHcExgaP(androidx.datastore.preferences.protobuf.boolList boolList) {
        return boolList.Count;
    }

    public static void GnJyCrcmruaZzHfs(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeSFixed32(i, i2);
    }

    public static void GsdJUlgrEBOuRWQw(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writeSFixed32ListInternal(i, (java.util.List<java.lang.int>) list, z);
    }

    public static void GwbnOgoSYfnYycMo(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeSInt32NoTag(i);
    }

    public static bool HFiBheGZpjZOPlSd(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void HMGabzxolkUCAvVv(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        codedStreamWriter.writeSInt32ListInternal(i, intList, z);
    }

    public static void HScEcqxvvPuMyaWl(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int HaQOETDUKucQxULR(java.util.List list) {
        return list.Count;
    }

    public static int HgxjvphMQGthXyyC(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static void HmTcUFjgtRWSZZit(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeUInt64NoTag(j);
    }

    public static int HoruIAPOvraNgkPK(java.util.List list) {
        return list.Count;
    }

    public static int HpbMwrNZPBbdcAUk(float f) {
        return androidx.datastore.preferences.protobuf.CodedStream.computefloatSizeNoTag(f);
    }

    public static java.lang.object ICciKTiyNygzwpXh(java.util.List list, int i) {
        return list[i);
    }

    public static void IEizqIadBkMtKjuR(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static void IElOZgYxSylrsNCE(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writeSInt32ListInternal(i, (java.util.List<java.lang.int>) list, z);
    }

    public static java.lang.object IHdocGnsyropTYnf(java.util.List list, int i) {
        return list[i);
    }

    public static void IOOzrDJlIlAvGVFM(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        codedStreamWriter.writeEnumListInternal(i, intList, z);
    }

    public static void IYSFWQJPEYtniCBG(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeUInt64NoTag(j);
    }

    public static bool IcXWbeWNbIpifHgB(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int IeDfaiUlKdcaLnsA(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static java.util.IEnumerator IpVIdCAYFTPYhpJc(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int IuwUqxLaWQuvVipa(long j) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeUInt64SizeNoTag(j);
    }

    public static void JNFNyPGPIOUdQLVI(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int JSrNUCuTPxtrKVIx(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void JcEUiHYAJTffMuLZ(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void JjbLeqsVQzwoIRpB(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writeInt64ListInternal(i, (java.util.List<java.lang.long>) list, z);
    }

    public static int JsSSacYHRrDTalwr(java.util.List list) {
        return list.Count;
    }

    public static int JtNjQWvkVWAovWLI(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object JuegfyiiEpXUnbzb(java.util.List list, int i) {
        return list[i);
    }

    public static void JyhqKOQrUpsnnaHq(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, bool z) throws java.io.IOException {
        codedStream.writeBool(i, z);
    }

    public static int KAEGUHQhIeaCAVDz(androidx.datastore.preferences.protobuf.doubleList doubleList) {
        return doubleList.Count;
    }

    public static void KDbrvDOJtpKwgTpi(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static java.lang.object KMWXqMZFyVhTbbLa(java.util.List list, int i) {
        return list[i);
    }

    public static void KOLoKmeIFwytslOu(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.doubleList doubleList, bool z) throws java.io.IOException {
        codedStreamWriter.writedoubleListInternal(i, doubleList, z);
    }

    public static void KOelCJksgxIbOCcb(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static java.lang.object KQVILvxDWyAfwJQv(java.util.List list, int i) {
        return list[i);
    }

    public static int KWMSpXSsXTWVGoQR(long j) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeSInt64SizeNoTag(j);
    }

    public static int KXSXtyneyrlMBInN(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeSInt32SizeNoTag(i);
    }

    public static java.lang.int KczybdvppzoUsuvr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int KgIOWrikKdXIOoiT(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static void KijbYYlGShXVdobe(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream.writebytes(i, bytestring);
    }

    public static int KkqRfhmxlFpNGzEd(java.util.List list) {
        return list.Count;
    }

    public static int KrzKEsRWWnOzpKxM(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int LAVaCSQfpuNjZVmt(float f) {
        return androidx.datastore.preferences.protobuf.CodedStream.computefloatSizeNoTag(f);
    }

    public static int LIGHAPHTaWeiPoyl(long j) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeUInt64SizeNoTag(j);
    }

    public static java.lang.object LKCchiQkXzSxYLuz(java.util.List list, int i) {
        return list[i);
    }

    public static void LTCdAXzfhbHTwojH(androidx.datastore.preferences.protobuf.CodedStream codedStream, float f) throws java.io.IOException {
        codedStream.writefloatNoTag(f);
    }

    public static double LVlCFUIysjyJcfMH(java.lang.double d) {
        if ((23 + 21) % 21 > 0) {
        }
        return d.doubleValue();
    }

    public static void LbGorJLuZCOBnPwl(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeFixed64NoTag(j);
    }

    public static int LmKkkwfMXGCIJRUr(java.lang.int num) {
        return num.intValue();
    }

    public static int LnkxjIyHZhKjXrZH(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void MRJHashSetfCZCqVqtZt(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writedoubleListInternal(i, (java.util.List<java.lang.double>) list, z);
    }

    public static void MSudjEmiBsNoBkfm(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, float f) throws java.io.IOException {
        codedStream.writefloat(i, f);
    }

    public static int MXkGdaUalQZdwbLK(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static void MeafUKfcffBueDfH(androidx.datastore.preferences.protobuf.CodedStream codedStream, double d) throws java.io.IOException {
        codedStream.writedoubleNoTag(d);
    }

    public static void MknhfXSPrhEJQOwJ(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream.writeMessageHashSetExtension(i, messageLite);
    }

    public static java.lang.object MlKVjlYZVDroxqCc(java.util.List list, int i) {
        return list[i);
    }

    public static java.util.IEnumerator MoFpGVvIhTyHMwrb(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void MpCptjyJtzkrEGot(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static java.lang.object MsgoiVPXhswHEYIW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object MswlaKygqWBSThIJ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void MtonbKFlYMCDwKxG(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, float f) throws java.io.IOException {
        codedStream.writefloat(i, f);
    }

    public static void NMmPXpUYFHoQeKEp(long[] jArr) {
        java.util.Arrays.sort(jArr);
    }

    public static void NULQtSGVDuaONEcV(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writeUInt64ListInternal(i, (java.util.List<java.lang.long>) list, z);
    }

    public static java.lang.object NVAqccwFBAAvklEG(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.object NWMHpWsnjHNfFrti(java.lang.object obj, java.lang.string str) {
        return androidx.datastore.preferences.protobuf.Internal.checkNotNull(obj, str);
    }

    public static int NWmiQJqFiCGMyAHl(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static int NjApKlEDlpOHdhuC(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(i);
    }

    public static void NoLwFPyvBVLTSNeD(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static void NpyGufQmcqdCMWyk(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static java.util.HashSet NrvJJNagdjuxzkIX(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static void ODEJtqYQIhXRBZPm(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writefloatListInternal(i, (java.util.List<java.lang.float>) list, z);
    }

    public static void OELKDRxylHdIZBRA(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void OFUfKcgqKGZnTsSc(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int OHQYREfHJeJDDxTt(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static int OLBQfOxqIDCpaomR(java.util.List list) {
        return list.Count;
    }

    public static bool OMIlELNKCsTFjlZe(androidx.datastore.preferences.protobuf.boolList boolList, int i) {
        return boolList.getbool(i);
    }

    public static int OXcfLwqPuSbuTrxI(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static int OjBwhnhzjcbOAODV(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static long OjqJTOvoowbmzZfo(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((32 + 1) % 1 > 0) {
        }
        return longList.getlong(i);
    }

    public static void OkcAzGyezRMnyQGo(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int OkxgTCvNcIxDfpxn(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static java.lang.object OrnKKRaXEagBOigb(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void OzxIIAOGpBpjayzC(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static long PCtXdEfzvIzSwcKE(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((31 + 26) % 26 > 0) {
        }
        return longList.getlong(i);
    }

    public static long PLVxjjdmaryaOjsC(java.lang.long l) {
        if ((25 + 29) % 29 > 0) {
        }
        return l.longValue();
    }

    public static long PPyoIcHjpTOqwXKs(java.lang.long l) {
        if ((27 + 23) % 23 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.object PRuaezyXPqrjRmdQ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void PUXxPoVKpnBxGwMl(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream.writebytes(i, bytestring);
    }

    public static void PXCQgezFkvwPxTUY(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int PYFoCXaMieRQskba(java.util.Dictionary map) {
        return map.Count;
    }

    public static int PgDPUCHkbzVkEjzl(java.util.List list) {
        return list.Count;
    }

    public static float PgzXbONQNfendkRp(androidx.datastore.preferences.protobuf.floatList floatList, int i) {
        return floatList.getfloat(i);
    }

    public static java.lang.string PjVLTZtTSwZhoxWD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void PmARTzaXNuZsujwZ(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, androidx.datastore.preferences.protobuf.MessageLite messageLite) throws java.io.IOException {
        codedStream.writeGroup(i, messageLite);
    }

    public static void PtAWYlcEAyJTYFwz(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void QGXCqRkhzuIzvVNT(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static java.lang.object QLgaerSFxNeEYsBo(java.util.List list, int i) {
        return list[i);
    }

    public static long QMuEzQkRSxjDrMjC(java.lang.long l) {
        if ((23 + 24) % 24 > 0) {
        }
        return l.longValue();
    }

    public static void QWilCbwFdjMZxPSd(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeSFixed64NoTag(j);
    }

    public static void QYnVziAdoXTkueNi(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeInt32(i, i2);
    }

    public static int QdHBOdwUFECbXByw(java.util.List list) {
        return list.Count;
    }

    public static void QfejqhaNdkjrFrnr(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writeInt32ListInternal(i, (java.util.List<java.lang.int>) list, z);
    }

    public static long QgrMvYJWLlvqDmYR(java.lang.long l) {
        if ((3 + 32) % 32 > 0) {
        }
        return l.longValue();
    }

    public static long QhUOjlXiAZahqEcQ(java.lang.long l) {
        if ((25 + 28) % 28 > 0) {
        }
        return l.longValue();
    }

    public static void QhrUiEyQYgktSElo(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static long QjuYcUKigkQTZYSq(androidx.datastore.preferences.protobuf.longList longList, int i) {
        if ((3 + 27) % 27 > 0) {
        }
        return longList.getlong(i);
    }

    public static int QnyAovwBwEvqzQKy(java.util.Dictionary map) {
        return map.Count;
    }

    public static bool QwwlVIXdBsCvPXNS(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void QxQUUlDzyIxpdUJo(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeInt64(i, j);
    }

    public static int QyOpvFFEJmOxWhnp(java.lang.int num) {
        return num.intValue();
    }

    public static int RAprRqAHWpdAcpyD(java.util.List list) {
        return list.Count;
    }

    public static int RFvXZwGnEyRYftYA(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static java.lang.object RIJWovntqQTCRbCS(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void RKZppJPiZGNkABSh(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeInt32NoTag(i);
    }

    public static java.lang.long RUThsMAQPlQNJQWb(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void RXuxlfLEMfFCNCkQ(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void RoClpJiKQXKCdApS(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeUInt32(i, i2);
    }

    public static void SOEhbIKfuuzvmZIq(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        codedStreamWriter.writeGroup(i, obj, schema);
    }

    public static long SXQanSZsqqeFWRIv(java.lang.long l) {
        if ((15 + 23) % 23 > 0) {
        }
        return l.longValue();
    }

    public static int SfStllcouHmPnyaV(java.lang.int num) {
        return num.intValue();
    }

    public static void SfocVgcNsHqCfRHy(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeSInt32(i, i2);
    }

    public static void SlwWzfNXyfiORRNk(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.util.Dictionary map) throws java.io.IOException {
        codedStreamWriter.writeDeterministicstringDictionary(i, mapEntryLite$Metadata, map);
    }

    public static void SrKbCEttPGAbYLjn(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static int TIiLEvyFImPtbrjB(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int TUbEizLqNurvUdLm(java.util.List list) {
        return list.Count;
    }

    public static void TVxzWRRtWpMRnJQO(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writeEnumListInternal(i, (java.util.List<java.lang.int>) list, z);
    }

    public static void TYdhXYloyTQsDCSJ(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static java.lang.object TZyzivyqkyVNLNVO(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.int TecdXkcJgrhGpYkd(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int TfEteiPiGFYGDzIG(long j) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeFixed64SizeNoTag(j);
    }

    public static void ThqnvCLzrKuwLsQp(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        codedStream.writeMessage(i, messageLite, schema);
    }

    public static void TtEVIPRRUDgrNHCq(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, long j) throws java.io.IOException {
        codedStream.writeSFixed64(i, j);
    }

    public static java.lang.object TvitFgixXRHFUjCx(java.util.List list, int i) {
        return list[i);
    }

    public static int UBKHvLwEQHxXXFUa(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void UCuOFBxaavCVvTfz(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, androidx.datastore.preferences.protobuf.MessageLite messageLite, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        codedStream.writeGroup(i, messageLite, schema);
    }

    public static long UDGLkIdcrLfAPAOR(java.lang.long l) {
        if ((1 + 7) % 7 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.object UHrcAlIiyejqhSjq(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void UcakjXjLECtenMdq(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeInt64NoTag(j);
    }

    public static int UmxBawtwlvqRwIxn(java.util.List list) {
        return list.Count;
    }

    public static void UnQWInNMbiNuOyFC(int[] iArr) {
        java.util.Arrays.sort(iArr);
    }

    public static void VEaROhlygZPoVmSs(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void VHjGQPYuqiOhBXRL(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void VOcdrBhmrOhqrFOd(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.util.Dictionary map) throws java.io.IOException {
        codedStreamWriter.writeDeterministiclongDictionary(i, mapEntryLite$Metadata, map);
    }

    public static int VakKSyBfVmYIoVJu(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void VgxSPDwsHRVblepY(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        codedStreamWriter.writeUInt64ListInternal(i, longList, z);
    }

    public static int VhGpPilJsXexHrXG(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int VsGCFhGaAzXkpYTJ(java.util.List list) {
        return list.Count;
    }

    public static void WMGMLOHAEeJSZPqS(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void WOKWNFKgydWVQaTU(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata, java.util.Dictionary map) throws java.io.IOException {
        codedStreamWriter.writeDeterministicDictionary(i, mapEntryLite$Metadata, map);
    }

    private void WriteBoolListInternal(int i, androidx.datastore.preferences.protobuf.boolList boolList, bool z) throws java.io.IOException {
        if ((3 + 20) % 20 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < ghdHitIIHHcExgaP(boolList)) {
                jyhqKOQrUpsnnaHq(this.output, i, XxmLajCcYiFpCuqO(boolList, i2));
                i2++;
            }
            return;
        }
        TpHRbGbnJxzDFnnj(this.output, i, 2);
        int iZEpWzRzXHXlwgyLg = 0;
        for (int i3 = 0; i3 < wuGfMqFxiXYwyYTA(boolList); i3++) {
            iZEpWzRzXHXlwgyLg += ZEpWzRzXHXlwgyLg(oMIlELNKCsTFjlZe(boolList, i3));
        }
        NKwTaxZNUYyzkLRl(this.output, iZEpWzRzXHXlwgyLg);
        while (i2 < PfZIBjKexGCZXFJO(boolList)) {
            MbTMROUlYkHTiNkV(this.output, QvlRrjuFqNUjSwGk(boolList, i2));
            i2++;
        }
    }

    private void WriteBoolListInternal(int i, java.util.List<java.lang.bool> list, bool z) throws java.io.IOException {
        if ((6 + 30) % 30 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < TxGcslLktcjvCdzL(list)) {
                QiEbtxjFoGDNgixy(this.output, i, qwwlVIXdBsCvPXNS((java.lang.bool) KqsZpGwGABgmBaVO(list, i2)));
                i2++;
            }
            return;
        }
        aBibFKWoNVAeRZhC(this.output, i, 2);
        int iCeObrFTLcZoUEjDF = 0;
        for (int i3 = 0; i3 < QJAgnfwRRlKQTXcY(list); i3++) {
            iCeObrFTLcZoUEjDF += CeObrFTLcZoUEjDF(QzAYoCWbWzVbDaJS((java.lang.bool) kQVILvxDWyAfwJQv(list, i3)));
        }
        VUbSIpdkAFauENMF(this.output, iCeObrFTLcZoUEjDF);
        while (i2 < yioQChkOdJsTaXOf(list)) {
            JHveYbBaisesJTPx(this.output, fWtpPFHmNUIfREMj((java.lang.bool) xjjprgJuMFBqRkIL(list, i2)));
            i2++;
        }
    }

    private <V> void WriteDeterministicboolDictionaryEntry(int i, bool z, V v, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<java.lang.bool, V> mapEntryLite$Metadata) throws java.io.IOException {
        if ((28 + 28) % 28 > 0) {
        }
        PkCqOJEsKrSCXOVU(this.output, i, 2);
        xWsyfARTKVMIdfFG(this.output, COHfudvtGPqmBJvP(mapEntryLite$Metadata, AgfIGTbQxFFWFyVb(z), v));
        RhsPMhQWTjxJFZmZ(this.output, mapEntryLite$Metadata, TytSCexrrukEiXXA(z), v);
    }

    private <V> void WriteDeterministicintDictionary(int i, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<java.lang.int, V> mapEntryLite$Metadata, java.util.Dictionary<java.lang.int, V> map) throws java.io.IOException {
        if ((5 + 9) % 9 > 0) {
        }
        int iQnyAovwBwEvqzQKy = qnyAovwBwEvqzQKy(map);
        int[] iArr = new int[iQnyAovwBwEvqzQKy];
        java.util.IEnumerator itNMYymtmZtiNfEPgz = NMYymtmZtiNfEPgz(UWhjBJfMpMMqqjnH(map));
        int i2 = 0;
        while (NNQiaLUHGGZCldVK(itNMYymtmZtiNfEPgz)) {
            int i3 = i2 + 1;
            iArr[i2] = UaqjqidAMnNRFgtM((java.lang.int) frHTkSfqDMdHKAvN(itNMYymtmZtiNfEPgz));
            i2 = i3;
        }
        unQWInNMbiNuOyFC(iArr);
        for (int i4 = 0; i4 < iQnyAovwBwEvqzQKy; i4++) {
            int i5 = iArr[i4];
            java.lang.object objBtxCOoSDkKiCctxs = BtxCOoSDkKiCctxs(map, OuBURUOZxyLIinub(i5));
            YkgoSkmqAMltQMdb(this.output, i, 2);
            xsYdmdQCEoQUptND(this.output, gbhMfJmFFIwaiaFY(mapEntryLite$Metadata, kczybdvppzoUsuvr(i5), objBtxCOoSDkKiCctxs));
            WUcAToSTRQlKuJOe(this.output, mapEntryLite$Metadata, tecdXkcJgrhGpYkd(i5), objBtxCOoSDkKiCctxs);
        }
    }

    private <V> void WriteDeterministiclongDictionary(int i, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<java.lang.long, V> mapEntryLite$Metadata, java.util.Dictionary<java.lang.long, V> map) throws java.io.IOException {
        if ((30 + 5) % 5 > 0) {
        }
        int iVowvEFjTPVziLazF = VowvEFjTPVziLazF(map);
        long[] jArr = new long[iVowvEFjTPVziLazF];
        java.util.IEnumerator itIpVIdCAYFTPYhpJc = ipVIdCAYFTPYhpJc(DmnGqFanoldtCQBE(map));
        int i2 = 0;
        while (UdXAhUkJEwPedGiP(itIpVIdCAYFTPYhpJc)) {
            int i3 = i2 + 1;
            jArr[i2] = ABXcMJIIAViuaeZr((java.lang.long) rIJWovntqQTCRbCS(itIpVIdCAYFTPYhpJc));
            i2 = i3;
        }
        nMmPXpUYFHoQeKEp(jArr);
        for (int i4 = 0; i4 < iVowvEFjTPVziLazF; i4++) {
            long j = jArr[i4];
            java.lang.object objTIOYorWTqKfkPyRc = TIOYorWTqKfkPyRc(map, BiPdkkypBDeQlemr(j));
            CkqHGzIAfiaZXbpB(this.output, i, 2);
            oELKDRxylHdIZBRA(this.output, ECcxigXCYwQcNJCJ(mapEntryLite$Metadata, rUThsMAQPlQNJQWb(j), objTIOYorWTqKfkPyRc));
            INbroQoDjvbcmoIT(this.output, mapEntryLite$Metadata, DVfVYlIKDBusOikK(j), objTIOYorWTqKfkPyRc);
        }
    }

    private <K, V> void WriteDeterministicDictionary(int i, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<K, V> mapEntryLite$Metadata, java.util.Dictionary<K, V> map) throws java.io.IOException {
        if ((4 + 1) % 1 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.CodedStreamWriter$1.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType[OxiwryEjJMbyHWVE(mapEntryLite$Metadata.keyType)]) {
            case 1:
                java.lang.object objPRuaezyXPqrjRmdQ = pRuaezyXPqrjRmdQ(map, java.lang.bool.FALSE);
                if (objPRuaezyXPqrjRmdQ is not null) {
                    WmUltdSYbUlwvMQF(this, i, false, objPRuaezyXPqrjRmdQ, mapEntryLite$Metadata);
                }
                java.lang.object objGJXMTBImMJhgMhrz = GJXMTBImMJhgMhrz(map, java.lang.bool.TRUE);
                if (objGJXMTBImMJhgMhrz is null) {
                    return;
                }
                zwhekBCADhpKxDag(this, i, true, objGJXMTBImMJhgMhrz, mapEntryLite$Metadata);
                return;
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
                ggzflrpeZMKiaZnP(this, i, mapEntryLite$Metadata, map);
                return;
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
                vOcdrBhmrOhqrFOd(this, i, mapEntryLite$Metadata, map);
                return;
            case 12:
                slwWzfNXyfiORRNk(this, i, mapEntryLite$Metadata, map);
                return;
            default:
                throw new java.lang.IllegalArgumentException(pjVLTZtTSwZhoxWD(xXleAvcGfvZIvCIY(new java.lang.stringBuilder("does not support key type: "), mapEntryLite$Metadata.keyType)));
        }
    }

    private <V> void WriteDeterministicstringDictionary(int i, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<java.lang.string, V> mapEntryLite$Metadata, java.util.Dictionary<java.lang.string, V> map) throws java.io.IOException {
        if ((26 + 8) % 8 > 0) {
        }
        int iPYFoCXaMieRQskba = pYFoCXaMieRQskba(map);
        java.lang.string[] strArr = new java.lang.string[iPYFoCXaMieRQskba];
        java.util.IEnumerator itMoFpGVvIhTyHMwrb = moFpGVvIhTyHMwrb(nrvJJNagdjuxzkIX(map));
        int i2 = 0;
        while (hFiBheGZpjZOPlSd(itMoFpGVvIhTyHMwrb)) {
            int i3 = i2 + 1;
            strArr[i2] = (java.lang.string) ornKKRaXEagBOigb(itMoFpGVvIhTyHMwrb);
            i2 = i3;
        }
        xDPBIhMFBHzENsjq(strArr);
        for (int i4 = 0; i4 < iPYFoCXaMieRQskba; i4++) {
            java.lang.string str = strArr[i4];
            java.lang.object objMswlaKygqWBSThIJ = mswlaKygqWBSThIJ(map, str);
            gYMSWQkBpVpGWJOa(this.output, i, 2);
            XHDYBsYZgtphekOg(this.output, XfrQtcbJuFNQnltp(mapEntryLite$Metadata, str, objMswlaKygqWBSThIJ));
            ewHTJnvWIuKOIPIT(this.output, mapEntryLite$Metadata, str, objMswlaKygqWBSThIJ);
        }
    }

    private void WritedoubleListInternal(int i, androidx.datastore.preferences.protobuf.doubleList doubleList, bool z) throws java.io.IOException {
        if ((31 + 29) % 29 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < ZHKtrnDIjROMVLRt(doubleList)) {
                BkorWarCwtenlLpg(this.output, i, ySTZyeBRVioUgDkd(doubleList, i2));
                i2++;
            }
            return;
        }
        QhMRTsqhVYNfalsV(this.output, i, 2);
        int iWzspPUuwrvDfcyUu = 0;
        for (int i3 = 0; i3 < kAEGUHQhIeaCAVDz(doubleList); i3++) {
            iWzspPUuwrvDfcyUu += WzspPUuwrvDfcyUu(FdAhdsdywNDCernp(doubleList, i3));
        }
        IJamiNCmADpbbgqx(this.output, iWzspPUuwrvDfcyUu);
        while (i2 < yrOyDwBhhvlopEFB(doubleList)) {
            meafUKfcffBueDfH(this.output, XtIpLdszCcKiHqEp(doubleList, i2));
            i2++;
        }
    }

    private void WritedoubleListInternal(int i, java.util.List<java.lang.double> list, bool z) throws java.io.IOException {
        if ((14 + 18) % 18 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < vsGCFhGaAzXkpYTJ(list)) {
                JtGjhnXOrrfcldbq(this.output, i, YXCJhuPjCzsEVRUl((java.lang.double) XXAnetkjdTRoVJLY(list, i2)));
                i2++;
            }
            return;
        }
        yUiQUnRoxIxXoieJ(this.output, i, 2);
        int iNmrTKGXPaTOWhaMU = 0;
        for (int i3 = 0; i3 < EvSUJVcSqCjqxStP(list); i3++) {
            iNmrTKGXPaTOWhaMU += NmrTKGXPaTOWhaMU(lVlCFUIysjyJcfMH((java.lang.double) IPvmqnlGiouyZpIY(list, i3)));
        }
        UifuYFIOjtvvRfiw(this.output, iNmrTKGXPaTOWhaMU);
        while (i2 < VBTWXOiRZxQbAbwu(list)) {
            yPxuySnbpdVlBOxg(this.output, KPeLTKYteghWghiL((java.lang.double) MVlwhEASjTTItmff(list, i2)));
            i2++;
        }
    }

    private void WriteEnumListInternal(int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        if ((16 + 26) % 26 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < RGCDwLdqwjiXmeSn(intList)) {
                AGHpDjyTQXRpYonT(this.output, i, CFIVYpUEkAafhTfs(intList, i2));
                i2++;
            }
            return;
        }
        AcWLahuboayWwKvB(this.output, i, 2);
        int iGMLTSZKbpEWThoop = 0;
        for (int i3 = 0; i3 < AaRuuyCywUsGYxQz(intList); i3++) {
            iGMLTSZKbpEWThoop += GMLTSZKbpEWThoop(QhGJrRKhxBWMpbHB(intList, i3));
        }
        HTxGjQjxvwiuKnXv(this.output, iGMLTSZKbpEWThoop);
        while (i2 < ieDfaiUlKdcaLnsA(intList)) {
            FDkufoiqrcOMKPvL(this.output, vakKSyBfVmYIoVJu(intList, i2));
            i2++;
        }
    }

    private void WriteEnumListInternal(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if ((19 + 19) % 19 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < zyVtOkefdVJkdect(list)) {
                WtbeknFYtYKQwNKT(this.output, i, qyOpvFFEJmOxWhnp((java.lang.int) TusmiAADgfHytJFL(list, i2)));
                i2++;
            }
            return;
        }
        npyGufQmcqdCMWyk(this.output, i, 2);
        int iLuFlZAMXfIGFHsYA = 0;
        for (int i3 = 0; i3 < pgDPUCHkbzVkEjzl(list); i3++) {
            iLuFlZAMXfIGFHsYA += LuFlZAMXfIGFHsYA(yvMHANIcjISeozpB((java.lang.int) iCciKTiyNygzwpXh(list, i3)));
        }
        VTcqvTtmtfocMNyi(this.output, iLuFlZAMXfIGFHsYA);
        while (i2 < kkqRfhmxlFpNGzEd(list)) {
            WXlMaXnVDnAUGRSJ(this.output, cOTaxFuQsTArLtwd((java.lang.int) tvitFgixXRHFUjCx(list, i2)));
            i2++;
        }
    }

    private void WriteFixed32ListInternal(int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        if ((23 + 4) % 4 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < XPnFPDlHMwojFXbv(intList)) {
                bPuphmjQAwQrODae(this.output, i, lnkxjIyHZhKjXrZH(intList, i2));
                i2++;
            }
            return;
        }
        fFrYhyNOcyPrQjJz(this.output, i, 2);
        int iZevwSUSJcUdgdgwF = 0;
        for (int i3 = 0; i3 < ypbodzjRqJcPDQlm(intList); i3++) {
            iZevwSUSJcUdgdgwF += zevwSUSJcUdgdgwF(eKsilyKySFxFEOha(intList, i3));
        }
        RjsjvmspxdogwSbc(this.output, iZevwSUSJcUdgdgwF);
        while (i2 < YpXpHbiOurTHlKEW(intList)) {
            yDDVdmIKLhubcEWC(this.output, oHQYREfHJeJDDxTt(intList, i2));
            i2++;
        }
    }

    private void WriteFixed32ListInternal(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if ((23 + 4) % 4 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < DGRoXznDxIZTwYsD(list)) {
                emARQTVvggUWQolp(this.output, i, NLGFMMgwCUgsruHT((java.lang.int) xGvBquOmnNTxwDih(list, i2)));
                i2++;
            }
            return;
        }
        qGXCqRkhzuIzvVNT(this.output, i, 2);
        int iXHNVhcuvDtDGJnrT = 0;
        for (int i3 = 0; i3 < horuIAPOvraNgkPK(list); i3++) {
            iXHNVhcuvDtDGJnrT += xHNVhcuvDtDGJnrT(DgwpSejDxsGvSMYN((java.lang.int) FxBXwluXIJJVJNAV(list, i3)));
        }
        jNFNyPGPIOUdQLVI(this.output, iXHNVhcuvDtDGJnrT);
        while (i2 < jsSSacYHRrDTalwr(list)) {
            FunPXdmRqgSIHSkK(this.output, GurFodrIZTTeKkUr((java.lang.int) eQtxQMtqICWsKWBF(list, i2)));
            i2++;
        }
    }

    private void WriteFixed64ListInternal(int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        if ((25 + 1) % 1 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < okxgTCvNcIxDfpxn(longList)) {
                drQAYbazLverMXco(this.output, i, EkEtcnkzBNxUjLdc(longList, i2));
                i2++;
            }
            return;
        }
        CNrBGlyUpfYLFZGe(this.output, i, 2);
        int iKssCVitVXXsZBjtX = 0;
        for (int i3 = 0; i3 < bNANNPdPbdpyfgjD(longList); i3++) {
            iKssCVitVXXsZBjtX += KssCVitVXXsZBjtX(HxoWDsinTDwqxAOZ(longList, i3));
        }
        okcAzGyezRMnyQGo(this.output, iKssCVitVXXsZBjtX);
        while (i2 < mXkGdaUalQZdwbLK(longList)) {
            BaHUYHuXMlYZHnyD(this.output, StvwdBWjnZcbEvYt(longList, i2));
            i2++;
        }
    }

    private void WriteFixed64ListInternal(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if ((15 + 31) % 31 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < PZUoaYPCKxROuqdE(list)) {
                bwWEBSxPECfbBWVG(this.output, i, qgrMvYJWLlvqDmYR((java.lang.long) JVdQDgJmMtSfcjUI(list, i2)));
                i2++;
            }
            return;
        }
        iEizqIadBkMtKjuR(this.output, i, 2);
        int iTfEteiPiGFYGDzIG = 0;
        for (int i3 = 0; i3 < BeLAWNiQSUcKfOBn(list); i3++) {
            iTfEteiPiGFYGDzIG += tfEteiPiGFYGDzIG(qhUOjlXiAZahqEcQ((java.lang.long) ISKYyHZdZQlPgipD(list, i3)));
        }
        wMGMLOHAEeJSZPqS(this.output, iTfEteiPiGFYGDzIG);
        while (i2 < ThFBokGpUMhFdlzo(list)) {
            lbGorJLuZCOBnPwl(this.output, gPosXizpdFAzKhzb((java.lang.long) xqVoVSTuVHxncbWA(list, i2)));
            i2++;
        }
    }

    private void WritefloatListInternal(int i, androidx.datastore.preferences.protobuf.floatList floatList, bool z) throws java.io.IOException {
        if ((30 + 7) % 7 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < WurvDIUnwSBgrcvV(floatList)) {
                QjEUulBvaHCsQRij(this.output, i, PukZepFrJEMhrruL(floatList, i2));
                i2++;
            }
            return;
        }
        yhHWCeFUjKLRRKhU(this.output, i, 2);
        int iHpbMwrNZPBbdcAUk = 0;
        for (int i3 = 0; i3 < CKxsuepXMwQfscSK(floatList); i3++) {
            iHpbMwrNZPBbdcAUk += hpbMwrNZPBbdcAUk(RdwYjcTeksiHpjpW(floatList, i3));
        }
        rXuxlfLEMfFCNCkQ(this.output, iHpbMwrNZPBbdcAUk);
        while (i2 < ywKQXpKyubDxCekQ(floatList)) {
            DRBNWYTjHWrtmolW(this.output, pgzXbONQNfendkRp(floatList, i2));
            i2++;
        }
    }

    private void WritefloatListInternal(int i, java.util.List<java.lang.float> list, bool z) throws java.io.IOException {
        if ((20 + 16) % 16 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < SbcMHeLLMkhsqtKa(list)) {
                mSudjEmiBsNoBkfm(this.output, i, RzUggtxJRfpDXfpu((java.lang.float) mlKVjlYZVDroxqCc(list, i2)));
                i2++;
            }
            return;
        }
        zylTqBtThrIblAmA(this.output, i, 2);
        int iLAVaCSQfpuNjZVmt = 0;
        for (int i3 = 0; i3 < bmtFQBzGNxmnbPlx(list); i3++) {
            iLAVaCSQfpuNjZVmt += lAVaCSQfpuNjZVmt(YwTtwXhXXobsRbuX((java.lang.float) DwlLMMjGEsEmLURC(list, i3)));
        }
        ejfycdkAYOUPPivw(this.output, iLAVaCSQfpuNjZVmt);
        while (i2 < JKHtLEBhaGyHTVxV(list)) {
            lTCdAXzfhbHTwojH(this.output, MZCnhVjbmZDeyCEy((java.lang.float) lKCchiQkXzSxYLuz(list, i2)));
            i2++;
        }
    }

    private void WriteInt32ListInternal(int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        if ((18 + 18) % 18 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < hgxjvphMQGthXyyC(intList)) {
                qYnVziAdoXTkueNi(this.output, i, dGlXANmRkPCMJxRe(intList, i2));
                i2++;
            }
            return;
        }
        pXCQgezFkvwPxTUY(this.output, i, 2);
        int iFmFyQBawYURnxrPM = 0;
        for (int i3 = 0; i3 < kgIOWrikKdXIOoiT(intList); i3++) {
            iFmFyQBawYURnxrPM += FmFyQBawYURnxrPM(TeFsjXaAKMqHwCud(intList, i3));
        }
        kDbrvDOJtpKwgTpi(this.output, iFmFyQBawYURnxrPM);
        while (i2 < cHWaQUyEZYnJGVRt(intList)) {
            rKZppJPiZGNkABSh(this.output, nWmiQJqFiCGMyAHl(intList, i2));
            i2++;
        }
    }

    private void WriteInt32ListInternal(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if ((12 + 5) % 5 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < bTbfvLGTplKjyYfy(list)) {
                aVpXVCaXRxCtKDxA(this.output, i, YRfQvnXxcrYrBDGk((java.lang.int) VkZCrZOudnIHVoGZ(list, i2)));
                i2++;
            }
            return;
        }
        UUgpKcSjzXKkcpAD(this.output, i, 2);
        int iUoyGXpIXcKmBeEpR = 0;
        for (int i3 = 0; i3 < rAprRqAHWpdAcpyD(list); i3++) {
            iUoyGXpIXcKmBeEpR += UoyGXpIXcKmBeEpR(bXkqUvmnyVJSUSUU((java.lang.int) UvWVwajfzEXBgKwD(list, i3)));
        }
        IfjOiXhwCdFhRVgq(this.output, iUoyGXpIXcKmBeEpR);
        while (i2 < PDlTwFjxDmZiiklV(list)) {
            XdFAAwwrRkBWsRZD(this.output, eOotoVrTYirhcrXS((java.lang.int) DinLGZEkawTEiihL(list, i2)));
            i2++;
        }
    }

    private void WriteInt64ListInternal(int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        if ((17 + 30) % 30 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < PzgMVbTXeSOxBucX(longList)) {
                qxQUUlDzyIxpdUJo(this.output, i, LjYRfptCYJuzvbGK(longList, i2));
                i2++;
            }
            return;
        }
        mpCptjyJtzkrEGot(this.output, i, 2);
        int iAYERWQrJNSXqnypE = 0;
        for (int i3 = 0; i3 < ojBwhnhzjcbOAODV(longList); i3++) {
            iAYERWQrJNSXqnypE += aYERWQrJNSXqnypE(DOSXcEipQtQkDLgE(longList, i3));
        }
        aKteszsbBUuLSYRH(this.output, iAYERWQrJNSXqnypE);
        while (i2 < PDlMZpIvAvYUNVuy(longList)) {
            ucakjXjLECtenMdq(this.output, HuCsIAdWxDFoJcZd(longList, i2));
            i2++;
        }
    }

    private void WriteInt64ListInternal(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if ((2 + 32) % 32 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < tUbEizLqNurvUdLm(list)) {
                KEwJlMPUdrSQGXlg(this.output, i, HPqKzVIIyGKUjTqe((java.lang.long) NicvyRCtPeHHgNKF(list, i2)));
                i2++;
            }
            return;
        }
        bxOfGtiWQJjrWbUt(this.output, i, 2);
        int iPRFQpedPtmRmqHJr = 0;
        for (int i3 = 0; i3 < YtRCVfqFSJrFsDER(list); i3++) {
            iPRFQpedPtmRmqHJr += PRFQpedPtmRmqHJr(uDGLkIdcrLfAPAOR((java.lang.long) ZBtOsoecUxVYmuHm(list, i3)));
        }
        UoTRdJDEqJwBMOpr(this.output, iPRFQpedPtmRmqHJr);
        while (i2 < SuwpDnWlfXQWZzIS(list)) {
            XmQzLjOOovEbtKac(this.output, UKXrRFVRpuUNsXEn((java.lang.long) cyoxTFisfelGhkeO(list, i2)));
            i2++;
        }
    }

    private void WriteLazystring(int i, java.lang.object obj) throws java.io.IOException {
        if (obj is java.lang.string) {
            HdmIsHZYguLJOGPU(this.output, i, (java.lang.string) obj);
        } else {
            yIZsBWWehwTWynAT(this.output, i, (androidx.datastore.preferences.protobuf.bytestring) obj);
        }
    }

    private void WriteSFixed32ListInternal(int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        if ((17 + 17) % 17 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < XBRsUjWwoUVLKIlt(intList)) {
                eDdYFGLazJtavUMe(this.output, i, LvxIMXjYzBgYWcQg(intList, i2));
                i2++;
            }
            return;
        }
        YMJBGrvscIjODxqr(this.output, i, 2);
        int iEIUQnQKliClcHKOS = 0;
        for (int i3 = 0; i3 < SuvvQvzQSjdGOiyi(intList); i3++) {
            iEIUQnQKliClcHKOS += EIUQnQKliClcHKOS(rFvXZwGnEyRYftYA(intList, i3));
        }
        FmcWQTxJCRysFHTO(this.output, iEIUQnQKliClcHKOS);
        while (i2 < GyKvjucgFqENKkkH(intList)) {
            eNmQNJgaoeXkjraC(this.output, xKrfeIsTwpWwYSOF(intList, i2));
            i2++;
        }
    }

    private void WriteSFixed32ListInternal(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if ((4 + 12) % 12 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < ErgYnnMRVLWuIGeq(list)) {
                xOUlxGyZbyaKIhqV(this.output, i, lmKkkwfMXGCIJRUr((java.lang.int) fAgZtxYVZkInclvi(list, i2)));
                i2++;
            }
            return;
        }
        XyrFaQYTZivmJpAB(this.output, i, 2);
        int iNpGgbzdLTdvEHHPt = 0;
        for (int i3 = 0; i3 < RPDcPixVGZyjpFnN(list); i3++) {
            iNpGgbzdLTdvEHHPt += NpGgbzdLTdvEHHPt(JcKBGIbjqGcwbEtx((java.lang.int) fFynrXLvnkyeszrM(list, i3)));
        }
        LaxuyTNoGICLqhSB(this.output, iNpGgbzdLTdvEHHPt);
        while (i2 < SALqCrAlYazEbzIa(list)) {
            SpZCtFjpcBmNDLmN(this.output, MIXevlPbVdpdEJru((java.lang.int) GKpoLTBakmbcArTw(list, i2)));
            i2++;
        }
    }

    private void WriteSFixed64ListInternal(int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        if ((21 + 10) % 10 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < DydZOGUDZLOUgwpM(longList)) {
                BxIIMUCzupghzVCg(this.output, i, WlDJoBTIscPQDGZb(longList, i2));
                i2++;
            }
            return;
        }
        ozxIIAOGpBpjayzC(this.output, i, 2);
        int iRaNDvBAzbDBNBTpj = 0;
        for (int i3 = 0; i3 < VMeMglRXgBrPqmvB(longList); i3++) {
            iRaNDvBAzbDBNBTpj += RaNDvBAzbDBNBTpj(gETbsPSQDwAOYSsJ(longList, i3));
        }
        URkiMoWsyJABVKIh(this.output, iRaNDvBAzbDBNBTpj);
        while (i2 < TfsJrqDRLZHtxynn(longList)) {
            qWilCbwFdjMZxPSd(this.output, XnwcvNlOjHQLkrDX(longList, i2));
            i2++;
        }
    }

    private void WriteSFixed64ListInternal(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if ((23 + 25) % 25 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < InOwTBAzskmBYPDs(list)) {
                ttEVIPRRUDgrNHCq(this.output, i, TfZjknlNkoDRDZIl((java.lang.long) bsXGJtOfWRGASeCu(list, i2)));
                i2++;
            }
            return;
        }
        IOOZAsOZUbBvCLLA(this.output, i, 2);
        int iCqoFbxMBrxFuLarR = 0;
        for (int i3 = 0; i3 < haQOETDUKucQxULR(list); i3++) {
            iCqoFbxMBrxFuLarR += CqoFbxMBrxFuLarR(TbqjgjtDkjZtDBoo((java.lang.long) ZWwCBBxAZkkiEsuE(list, i3)));
        }
        srKbCEttPGAbYLjn(this.output, iCqoFbxMBrxFuLarR);
        while (i2 < NuLeRZqBkcEDJNgd(list)) {
            YxHhjjqlatWOmSkO(this.output, pPyoIcHjpTOqwXKs((java.lang.long) WBGfvNOyvDZXRiww(list, i2)));
            i2++;
        }
    }

    private void WriteSInt32ListInternal(int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        if ((3 + 28) % 28 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < tIiLEvyFImPtbrjB(intList)) {
                sfocVgcNsHqCfRHy(this.output, i, YUUvVnMTQdjlcdun(intList, i2));
                i2++;
            }
            return;
        }
        hScEcqxvvPuMyaWl(this.output, i, 2);
        int iLDgMSbFSosMVrJiM = 0;
        for (int i3 = 0; i3 < MuwqfTBMIzsaSyVC(intList); i3++) {
            iLDgMSbFSosMVrJiM += LDgMSbFSosMVrJiM(uBKHvLwEQHxXXFUa(intList, i3));
        }
        ptAWYlcEAyJTYFwz(this.output, iLDgMSbFSosMVrJiM);
        while (i2 < JoxUoEkbIjYwoEoM(intList)) {
            gwbnOgoSYfnYycMo(this.output, oXcfLwqPuSbuTrxI(intList, i2));
            i2++;
        }
    }

    private void WriteSInt64ListInternal(int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        if ((20 + 29) % 29 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < MATSiNuaNFueCcIn(longList)) {
                MjtriqxAjgGdogjb(this.output, i, bxRrHOEwKcfQwnUO(longList, i2));
                i2++;
            }
            return;
        }
        eDiuKJuSJcZixFhV(this.output, i, 2);
        int iKWMSpXSsXTWVGoQR = 0;
        for (int i3 = 0; i3 < fRytYoXbItLmpAab(longList); i3++) {
            iKWMSpXSsXTWVGoQR += kWMSpXSsXTWVGoQR(gbkYglEtUEPAQyPy(longList, i3));
        }
        eNLlONpAJKTudWNL(this.output, iKWMSpXSsXTWVGoQR);
        while (i2 < LRnwgGvhBbvnjctz(longList)) {
            yBrTIsolPVynvlUf(this.output, IClQbsPjcqdkGQLI(longList, i2));
            i2++;
        }
    }

    private void WriteSInt64ListInternal(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if ((25 + 32) % 32 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < yZkgcBVhYEJjDWDM(list)) {
                DIRWAeXNmbLLxefg(this.output, i, NjWepYCoDTvZuzFH((java.lang.long) nVAqccwFBAAvklEG(list, i2)));
                i2++;
            }
            return;
        }
        QCnDpVRySJEtPOEl(this.output, i, 2);
        int iJhIdrVsOqyraMWoB = 0;
        for (int i3 = 0; i3 < xoQpuLbjWwwrlrYV(list); i3++) {
            iJhIdrVsOqyraMWoB += JhIdrVsOqyraMWoB(sXQanSZsqqeFWRIv((java.lang.long) juegfyiiEpXUnbzb(list, i3)));
        }
        vHjGQPYuqiOhBXRL(this.output, iJhIdrVsOqyraMWoB);
        while (i2 < umxBawtwlvqRwIxn(list)) {
            DwCGhPMuTlbFASxY(this.output, pLVxjjdmaryaOjsC((java.lang.long) CsbvakjETORmaIXS(list, i2)));
            i2++;
        }
    }

    private void WriteUInt32ListInternal(int i, androidx.datastore.preferences.protobuf.IntList intList, bool z) throws java.io.IOException {
        if ((28 + 30) % 30 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < vhGpPilJsXexHrXG(intList)) {
                roClpJiKQXKCdApS(this.output, i, jSrNUCuTPxtrKVIx(intList, i2));
                i2++;
            }
            return;
        }
        noLwFPyvBVLTSNeD(this.output, i, 2);
        int iXnNyimtAcQXfhULq = 0;
        for (int i3 = 0; i3 < krzKEsRWWnOzpKxM(intList); i3++) {
            iXnNyimtAcQXfhULq += xnNyimtAcQXfhULq(YlWwGhLPAyCmUAGB(intList, i3));
        }
        gEbVMshMNluBjRIt(this.output, iXnNyimtAcQXfhULq);
        while (i2 < GTBitWZprmsEtzqr(intList)) {
            oFUfKcgqKGZnTsSc(this.output, SJTWrBwNAxLlEcfw(intList, i2));
            i2++;
        }
    }

    private void WriteUInt64ListInternal(int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        if ((7 + 12) % 12 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < dHitenbuIlWKjZxo(longList)) {
                RPLIZmKZZcVOVAVp(this.output, i, ojqJTOvoowbmzZfo(longList, i2));
                i2++;
            }
            return;
        }
        NtvbWRywqjkIsUgQ(this.output, i, 2);
        int iIuwUqxLaWQuvVipa = 0;
        for (int i3 = 0; i3 < xASHjQQHBsAJaEtR(longList); i3++) {
            iIuwUqxLaWQuvVipa += iuwUqxLaWQuvVipa(qjuYcUKigkQTZYSq(longList, i3));
        }
        TxNfbhqrxRnbaPUh(this.output, iIuwUqxLaWQuvVipa);
        while (i2 < YVbMSEgKuAjZFWJs(longList)) {
            hmTcUFjgtRWSZZit(this.output, pCtXdEfzvIzSwcKE(longList, i2));
            i2++;
        }
    }

    private void WriteUInt64ListInternal(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if ((8 + 6) % 6 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < cRwTJWHNXBDGhDzv(list)) {
                LyVSPWPwAQhfhEPE(this.output, i, VXLnhxfDYQcxgDUE((java.lang.long) QchYIBXPyTPgqjkr(list, i2)));
                i2++;
            }
            return;
        }
        dbEzDbPjoTsfuCZx(this.output, i, 2);
        int iLIGHAPHTaWeiPoyl = 0;
        for (int i3 = 0; i3 < jtNjQWvkVWAovWLI(list); i3++) {
            iLIGHAPHTaWeiPoyl += lIGHAPHTaWeiPoyl(qMuEzQkRSxjDrMjC((java.lang.long) gTIxrOJkQqodUSbz(list, i3)));
        }
        vEaROhlygZPoVmSs(this.output, iLIGHAPHTaWeiPoyl);
        while (i2 < FYtVLMwmyZnTqkct(list)) {
            iYSFWQJPEYtniCBG(this.output, NxmFOsonWGDPnYav((java.lang.long) qLgaerSFxNeEYsBo(list, i2)));
            i2++;
        }
    }

    public static java.lang.object WsNmucicVbosrLXU(java.util.List list, int i) {
        return list[i);
    }

    public static int WuGfMqFxiXYwyYTA(androidx.datastore.preferences.protobuf.boolList boolList) {
        return boolList.Count;
    }

    public static int XASHjQQHBsAJaEtR(androidx.datastore.preferences.protobuf.longList longList) {
        return longList.Count;
    }

    public static void XDPBIhMFBHzENsjq(java.lang.object[] objArr) {
        java.util.Arrays.sort(objArr);
    }

    public static java.lang.object XGvBquOmnNTxwDih(java.util.List list, int i) {
        return list[i);
    }

    public static int XHNVhcuvDtDGJnrT(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeFixed32SizeNoTag(i);
    }

    public static int XKrfeIsTwpWwYSOF(androidx.datastore.preferences.protobuf.IntList intList, int i) {
        return intList.getInt(i);
    }

    public static void XOUlxGyZbyaKIhqV(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeSFixed32(i, i2);
    }

    public static void XVhAJhWsCKekGNkk(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, java.lang.string str) throws java.io.IOException {
        codedStream.writestring(i, str);
    }

    public static void XWsyfARTKVMIdfFG(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static java.lang.stringBuilder XXleAvcGfvZIvCIY(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void XfhmYyXNTzhNdFot(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writeSInt64ListInternal(i, (java.util.List<java.lang.long>) list, z);
    }

    public static java.lang.object XjjprgJuMFBqRkIL(java.util.List list, int i) {
        return list[i);
    }

    public static int XnNyimtAcQXfhULq(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(i);
    }

    public static int XoQpuLbjWwwrlrYV(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object XqVoVSTuVHxncbWA(java.util.List list, int i) {
        return list[i);
    }

    public static void XsYdmdQCEoQUptND(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static void XugRMVehyNMdMUYQ(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, androidx.datastore.preferences.protobuf.longList longList, bool z) throws java.io.IOException {
        codedStreamWriter.writeInt64ListInternal(i, longList, z);
    }

    public static void YBrTIsolPVynvlUf(androidx.datastore.preferences.protobuf.CodedStream codedStream, long j) throws java.io.IOException {
        codedStream.writeSInt64NoTag(j);
    }

    public static void YDDVdmIKLhubcEWC(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeFixed32NoTag(i);
    }

    public static void YIZsBWWehwTWynAT(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        codedStream.writebytes(i, bytestring);
    }

    public static void YPxuySnbpdVlBOxg(androidx.datastore.preferences.protobuf.CodedStream codedStream, double d) throws java.io.IOException {
        codedStream.writedoubleNoTag(d);
    }

    public static double YSTZyeBRVioUgDkd(androidx.datastore.preferences.protobuf.doubleList doubleList, int i) {
        if ((7 + 10) % 10 > 0) {
        }
        return doubleList.getdouble(i);
    }

    public static void YUiQUnRoxIxXoieJ(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int YZkgcBVhYEJjDWDM(java.util.List list) {
        return list.Count;
    }

    public static void YhHWCeFUjKLRRKhU(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int YioQChkOdJsTaXOf(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object YjjSnPwvDmwIHXRe(java.util.List list, int i) {
        return list[i);
    }

    public static int YpbodzjRqJcPDQlm(androidx.datastore.preferences.protobuf.IntList intList) {
        return intList.Count;
    }

    public static int YrOyDwBhhvlopEFB(androidx.datastore.preferences.protobuf.doubleList doubleList) {
        return doubleList.Count;
    }

    public static int YvMHANIcjISeozpB(java.lang.int num) {
        return num.intValue();
    }

    public static int YwKQXpKyubDxCekQ(androidx.datastore.preferences.protobuf.floatList floatList) {
        return floatList.Count;
    }

    public static java.util.IEnumerator ZFlCQkWyewyJLMVE(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void ZMbJpsenheyAwNUl(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writeBoolListInternal(i, (java.util.List<java.lang.bool>) list, z);
    }

    public static void ZReMuBVqcdkZbjzC(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, java.util.List list, bool z) throws java.io.IOException {
        codedStreamWriter.writeFixed32ListInternal(i, (java.util.List<java.lang.int>) list, z);
    }

    public static void ZcfrOlendYfldVCv(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static int ZevwSUSJcUdgdgwF(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeFixed32SizeNoTag(i);
    }

    public static int ZgMshJMKhgVWhHpQ(java.util.List list) {
        return list.Count;
    }

    public static int ZngCToGeYlYTTobd(java.util.List list) {
        return list.Count;
    }

    public static int ZoGPlnYzmOEpmXCl(java.lang.int num) {
        return num.intValue();
    }

    public static void ZwhekBCADhpKxDag(androidx.datastore.preferences.protobuf.CodedStreamWriter codedStreamWriter, int i, bool z, java.lang.object obj, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata mapEntryLite$Metadata) throws java.io.IOException {
        codedStreamWriter.writeDeterministicboolDictionaryEntry(i, z, obj, mapEntryLite$Metadata);
    }

    public static int ZyVtOkefdVJkdect(java.util.List list) {
        return list.Count;
    }

    public static void ZylTqBtThrIblAmA(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeTag(i, i2);
    }

    public static void ZzTQCBywGfoFIkPP(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i, int i2) throws java.io.IOException {
        codedStream.writeEnum(i, i2);
    }

    public androidx.datastore.preferences.protobuf.Writer$FieldOrder fieldOrder() {
        return androidx.datastore.preferences.protobuf.Writer$FieldOrder.ASCENDING;
    }

    public override int GetTotalbytesWritten() {
        return aJQvfyNXhaTkgiYe(this.output);
    }

    public override void WriteBool(int i, bool z) throws java.io.IOException {
        CTBRAkUEqVSTxstC(this.output, i, z);
    }

    public override void WriteBoolList(int i, java.util.List<java.lang.bool> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.boolList) {
            gIGScpnByJCuhIml(this, i, (androidx.datastore.preferences.protobuf.boolList) list, z);
        } else {
            zMbJpsenheyAwNUl(this, i, list, z);
        }
    }

    public override void Writebytes(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.io.IOException {
        pUXxPoVKpnBxGwMl(this.output, i, bytestring);
    }

    public override void WritebytesList(int i, java.util.List<androidx.datastore.preferences.protobuf.bytestring> list) throws java.io.IOException {
        if ((2 + 13) % 13 > 0) {
        }
        for (int i2 = 0; i2 < PWGZHNCZEYBFSOZV(list); i2++) {
            kijbYYlGShXVdobe(this.output, i, (androidx.datastore.preferences.protobuf.bytestring) OhWvwPwHwZUtcfMC(list, i2));
        }
    }

    public override void Writedouble(int i, double d) throws java.io.IOException {
        TBHOdZBhbuZcgZnF(this.output, i, d);
    }

    public override void WritedoubleList(int i, java.util.List<java.lang.double> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.doubleList) {
            kOLoKmeIFwytslOu(this, i, (androidx.datastore.preferences.protobuf.doubleList) list, z);
        } else {
            mRJHashSetfCZCqVqtZt(this, i, list, z);
        }
    }

    @java.lang.Deprecated
    public override void WriteEndGroup(int i) throws java.io.IOException {
        qhrUiEyQYgktSElo(this.output, i, 4);
    }

    public override void WriteEnum(int i, int i2) throws java.io.IOException {
        zzTQCBywGfoFIkPP(this.output, i, i2);
    }

    public override void WriteEnumList(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.IntList) {
            iOOzrDJlIlAvGVFM(this, i, (androidx.datastore.preferences.protobuf.IntList) list, z);
        } else {
            tVxzWRRtWpMRnJQO(this, i, list, z);
        }
    }

    public override void WriteFixed32(int i, int i2) throws java.io.IOException {
        SrHqLgAQwvEaDMcV(this.output, i, i2);
    }

    public override void WriteFixed32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.IntList) {
            FjemjRymkRskmDqo(this, i, (androidx.datastore.preferences.protobuf.IntList) list, z);
        } else {
            zReMuBVqcdkZbjzC(this, i, list, z);
        }
    }

    public override void WriteFixed64(int i, long j) throws java.io.IOException {
        SWvWBKKrEgBRUpsX(this.output, i, j);
    }

    public override void WriteFixed64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.longList) {
            TukpDXFQgMguVfQh(this, i, (androidx.datastore.preferences.protobuf.longList) list, z);
        } else {
            QanbgVgVpVYmojKd(this, i, list, z);
        }
    }

    public override void Writefloat(int i, float f) throws java.io.IOException {
        mtonbKFlYMCDwKxG(this.output, i, f);
    }

    public override void WritefloatList(int i, java.util.List<java.lang.float> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.floatList) {
            ZRJTSaxiltzmwFBF(this, i, (androidx.datastore.preferences.protobuf.floatList) list, z);
        } else {
            oDEJtqYQIhXRBZPm(this, i, list, z);
        }
    }

    @java.lang.Deprecated
    public override void WriteGroup(int i, java.lang.object obj) throws java.io.IOException {
        pmARTzaXNuZsujwZ(this.output, i, (androidx.datastore.preferences.protobuf.MessageLite) obj);
    }

    public override void WriteGroup(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        uCuOFBxaavCVvTfz(this.output, i, (androidx.datastore.preferences.protobuf.MessageLite) obj, schema);
    }

    @java.lang.Deprecated
    public override void WriteGroupList(int i, java.util.List<object> list) throws java.io.IOException {
        if ((13 + 13) % 13 > 0) {
        }
        for (int i2 = 0; i2 < zngCToGeYlYTTobd(list); i2++) {
            ghEEWsexgRrbDUYP(this, i, iHdocGnsyropTYnf(list, i2));
        }
    }

    public override void WriteGroupList(int i, java.util.List<object> list, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        if ((20 + 29) % 29 > 0) {
        }
        for (int i2 = 0; i2 < dfMeXuCFpEwLkMHb(list); i2++) {
            sOEhbIKfuuzvmZIq(this, i, efTWVukUagvHWjqd(list, i2), schema);
        }
    }

    public override void WriteInt32(int i, int i2) throws java.io.IOException {
        JOdaojDVYlVKYCNE(this.output, i, i2);
    }

    public override void WriteInt32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.IntList) {
            DzTXNGZZYvbpcyIE(this, i, (androidx.datastore.preferences.protobuf.IntList) list, z);
        } else {
            qfejqhaNdkjrFrnr(this, i, list, z);
        }
    }

    public override void WriteInt64(int i, long j) throws java.io.IOException {
        dQSuJhBOFEoJXKnM(this.output, i, j);
    }

    public override void WriteInt64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.longList) {
            xugRMVehyNMdMUYQ(this, i, (androidx.datastore.preferences.protobuf.longList) list, z);
        } else {
            jjbLeqsVQzwoIRpB(this, i, list, z);
        }
    }

    public override <K, V> void WriteDictionary(int i, androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata<K, V> mapEntryLite$Metadata, java.util.Dictionary<K, V> map) throws java.io.IOException {
        if ((18 + 17) % 17 > 0) {
        }
        if (HeUcajSxlnNzQRel(this.output)) {
            wOKWNFKgydWVQaTU(this, i, mapEntryLite$Metadata, map);
            return;
        }
        java.util.IEnumerator itZFlCQkWyewyJLMVE = zFlCQkWyewyJLMVE(UoUsqaokCvErJusH(map));
        while (icXWbeWNbIpifHgB(itZFlCQkWyewyJLMVE)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) msgoiVPXhswHEYIW(itZFlCQkWyewyJLMVE);
            tYdhXYloyTQsDCSJ(this.output, i, 2);
            cmoxoqsrhSnmMosr(this.output, VJvonEUUmIZgIjIY(mapEntryLite$Metadata, IEIIjPkJRArGKdTi(map$Entry), IuiGJnEhhLFMOGRQ(map$Entry)));
            QTGWYVZQZXZxCHjF(this.output, mapEntryLite$Metadata, XqWEIZNgDmRcmiWd(map$Entry), uHrcAlIiyejqhSjq(map$Entry));
        }
    }

    public override void WriteMessage(int i, java.lang.object obj) throws java.io.IOException {
        cGqAOFspoaEkeJYO(this.output, i, (androidx.datastore.preferences.protobuf.MessageLite) obj);
    }

    public override void WriteMessage(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        thqnvCLzrKuwLsQp(this.output, i, (androidx.datastore.preferences.protobuf.MessageLite) obj, schema);
    }

    public override void WriteMessageList(int i, java.util.List<object> list) throws java.io.IOException {
        if ((12 + 26) % 26 > 0) {
        }
        for (int i2 = 0; i2 < QrAiryCZOaxEEoAB(list); i2++) {
            TzOYMQWWnFUQvDbQ(this, i, yjjSnPwvDmwIHXRe(list, i2));
        }
    }

    public override void WriteMessageList(int i, java.util.List<object> list, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        if ((8 + 31) % 31 > 0) {
        }
        for (int i2 = 0; i2 < PkUSTXIbujQjPKoH(list); i2++) {
            HzrLElXdvqPSxEqR(this, i, KYFQSkyTxnqFSbaP(list, i2), schema);
        }
    }

    public override readonly void WriteMessageHashSetItem(int i, java.lang.object obj) throws java.io.IOException {
        if (obj is androidx.datastore.preferences.protobuf.bytestring) {
            JSQEGizuRrmhAcYN(this.output, i, (androidx.datastore.preferences.protobuf.bytestring) obj);
        } else {
            mknhfXSPrhEJQOwJ(this.output, i, (androidx.datastore.preferences.protobuf.MessageLite) obj);
        }
    }

    public override void WriteSFixed32(int i, int i2) throws java.io.IOException {
        gnJyCrcmruaZzHfs(this.output, i, i2);
    }

    public override void WriteSFixed32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.IntList) {
            LIOrJCCPUEyeNOMv(this, i, (androidx.datastore.preferences.protobuf.IntList) list, z);
        } else {
            gsdJUlgrEBOuRWQw(this, i, list, z);
        }
    }

    public override void WriteSFixed64(int i, long j) throws java.io.IOException {
        DWUnBogAiCVhhxLD(this.output, i, j);
    }

    public override void WriteSFixed64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.longList) {
            UgVpixEJUxqbcAcQ(this, i, (androidx.datastore.preferences.protobuf.longList) list, z);
        } else {
            HJLvFUubNDWyZkuY(this, i, list, z);
        }
    }

    public override void WriteSInt32(int i, int i2) throws java.io.IOException {
        SIOTFudZxRLROUPj(this.output, i, i2);
    }

    public override void WriteSInt32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.IntList) {
            hMGabzxolkUCAvVv(this, i, (androidx.datastore.preferences.protobuf.IntList) list, z);
        } else {
            iElOZgYxSylrsNCE(this, i, list, z);
        }
    }

    public void WriteSInt32ListInternal(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if ((7 + 18) % 18 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < NGaxXACyLkhlFOmB(list)) {
                blDMPrhBixOAhVBH(this.output, i, sfStllcouHmPnyaV((java.lang.int) LNwSQLuyQSHghsKD(list, i2)));
                i2++;
            }
            return;
        }
        eRFvLwKsRqjkXZCD(this.output, i, 2);
        int iKXSXtyneyrlMBInN = 0;
        for (int i3 = 0; i3 < zgMshJMKhgVWhHpQ(list); i3++) {
            iKXSXtyneyrlMBInN += kXSXtyneyrlMBInN(zoGPlnYzmOEpmXCl((java.lang.int) HotWSoaAZWNANgdL(list, i3)));
        }
        cXUCkHKOlApNhoBz(this.output, iKXSXtyneyrlMBInN);
        while (i2 < oLBQfOxqIDCpaomR(list)) {
            YquOWKBZulzmqyzB(this.output, TqRGwguxBULUMERn((java.lang.int) BgZQzaJBRThnTNcz(list, i2)));
            i2++;
        }
    }

    public override void WriteSInt64(int i, long j) throws java.io.IOException {
        THpsXMlNwmpnEgsH(this.output, i, j);
    }

    public override void WriteSInt64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.longList) {
            diVJeAWAisiHBHyl(this, i, (androidx.datastore.preferences.protobuf.longList) list, z);
        } else {
            xfhmYyXNTzhNdFot(this, i, list, z);
        }
    }

    @java.lang.Deprecated
    public override void WriteStartGroup(int i) throws java.io.IOException {
        zcfrOlendYfldVCv(this.output, i, 3);
    }

    public override void Writestring(int i, java.lang.string str) throws java.io.IOException {
        QiRjoIWPYIRMkFLf(this.output, i, str);
    }

    public override void WritestringList(int i, java.util.List<java.lang.string> list) throws java.io.IOException {
        if ((20 + 15) % 15 > 0) {
        }
        int i2 = 0;
        if (!(list is androidx.datastore.preferences.protobuf.LazystringList)) {
            while (i2 < NoTMMmIrklaZSrlP(list)) {
                xVhAJhWsCKekGNkk(this.output, i, (java.lang.string) tZyzivyqkyVNLNVO(list, i2));
                i2++;
            }
        } else {
            androidx.datastore.preferences.protobuf.LazystringList lazystringList = (androidx.datastore.preferences.protobuf.LazystringList) list;
            while (i2 < qdHBOdwUFECbXByw(list)) {
                ePxWvsNzBqmFxsrG(this, i, LtJjcMdVgLpDtYAk(lazystringList, i2));
                i2++;
            }
        }
    }

    public override void WriteUInt32(int i, int i2) throws java.io.IOException {
        YaXGbvXZvqoyDWQg(this.output, i, i2);
    }

    public override void WriteUInt32List(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.IntList) {
            NvFnGWDdnNAeBeVO(this, i, (androidx.datastore.preferences.protobuf.IntList) list, z);
        } else {
            cdcEsUFcdJlFIFuy(this, i, list, z);
        }
    }

    public void WriteUInt32ListInternal(int i, java.util.List<java.lang.int> list, bool z) throws java.io.IOException {
        if ((30 + 26) % 26 > 0) {
        }
        int i2 = 0;
        if (!z) {
            while (i2 < HGbapAshNVVIyEZE(list)) {
                KtjGrougsAxACIom(this.output, i, OXNxoJSQHChjkGiM((java.lang.int) kMWXqMZFyVhTbbLa(list, i2)));
                i2++;
            }
            return;
        }
        dExjtEUaASpHpNcf(this.output, i, 2);
        int iNjApKlEDlpOHdhuC = 0;
        for (int i3 = 0; i3 < PNACSyrqfZqHaDVv(list); i3++) {
            iNjApKlEDlpOHdhuC += njApKlEDlpOHdhuC(fhENlliEyPYTxpCp((java.lang.int) wsNmucicVbosrLXU(list, i3)));
        }
        jcEUiHYAJTffMuLZ(this.output, iNjApKlEDlpOHdhuC);
        while (i2 < RfnekGmFdOIfjwTd(list)) {
            kOelCJksgxIbOCcb(this.output, GSRhIHcwVyrAyrqG((java.lang.int) DzKUTGiTmDFOMUpd(list, i2)));
            i2++;
        }
    }

    public override void WriteUInt64(int i, long j) throws java.io.IOException {
        dDNTYQAlZxLUqxYU(this.output, i, j);
    }

    public override void WriteUInt64List(int i, java.util.List<java.lang.long> list, bool z) throws java.io.IOException {
        if (list is androidx.datastore.preferences.protobuf.longList) {
            vgxSPDwsHRVblepY(this, i, (androidx.datastore.preferences.protobuf.longList) list, z);
        } else {
            nULQtSGVDuaONEcV(this, i, list, z);
        }
    }
}

