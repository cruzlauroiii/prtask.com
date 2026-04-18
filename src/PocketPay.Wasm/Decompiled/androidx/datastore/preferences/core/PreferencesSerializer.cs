namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\bÆ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0003J \u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fH\u0002J\u0010\u0010\u0010\u001a\u00020\r2\u0006\u0010\f\u001a\u00020\u0011H\u0002J\u0016\u0010\u0012\u001a\u00020\u00022\u0006\u0010\u0013\u001a\u00020\u0014H\u0096@¢\u0006\u0002\u0010\u0015J\u001e\u0010\u0016\u001a\u00020\n2\u0006\u0010\u0017\u001a\u00020\u00022\u0006\u0010\u0018\u001a\u00020\u0019H\u0096@¢\u0006\u0002\u0010\u001aR\u0014\u0010\u0004\u001a\u00020\u00028VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0006R\u000e\u0010\u0007\u001a\u00020\bX\u0080T¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Landroidx/datastore/preferences/core/PreferencesSerializer;", "Landroidx/datastore/core/okio/OkioSerializer;", "Landroidx/datastore/preferences/core/Preferences;", "()V", "defaultValue", "getDefaultValue", "()Landroidx/datastore/preferences/core/Preferences;", "fileExtension", "", "addProtoEntryToPreferences", "", "name", "value", "Landroidx/datastore/preferences/PreferencesProto$Value;", "mutablePreferences", "Landroidx/datastore/preferences/core/MutablePreferences;", "getValueProto", "", "readFrom", "source", "Lp38cb8f46/pcc81e3f6;", "(Lp38cb8f46/pcc81e3f6;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "writeTo", "t", "sink", "Lp38cb8f46/p08d84bc6;", "(Landroidx/datastore/preferences/core/Preferences;Lp38cb8f46/p08d84bc6;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-preferences-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PreferencesSerializer : androidx.datastore.core.okio.OkioSerializer<androidx.datastore.preferences.core.Preferences> {
    public static readonly androidx.datastore.preferences.core.PreferencesSerializer INSTANCE = new androidx.datastore.preferences.core.PreferencesSerializer();
    public static readonly java.lang.string fileExtension = "preferences_pb";

    private PreferencesSerializer() {
    }

    public static void AZlGAVehqEHKUAcX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static androidx.datastore.preferences.PreferencesProto$stringHashSet$Builder AkUMqmhunuZCAUAv() {
        return androidx.datastore.preferences.PreferencesProto$stringHashSet.newBuilder();
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder AovaseSOkeqXeTBY(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return preferencesProto$Value$Builder.setbytes(bytestring);
    }

    public static void AzXewPXlowojsjfh(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static androidx.datastore.preferences.core.Preferences$Key AznyMZLyfTXgjVlc(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.stringKey(str);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite BNsTSGXzAahIOzxa(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder) {
        return preferencesProto$Value$Builder.build();
    }

    public static java.util.IEnumerator BYzXYPhJQFrBWHeN(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite DPZhsZfnOsPQEbmO(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder) {
        return preferencesProto$Value$Builder.build();
    }

    public static bool EQzfCzaYCHJpjaHk(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string EsQsiiAAEwWpvJok(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FDoUVYYTXmJcrufL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static androidx.datastore.preferences.core.MutablePreferences GNFIgKuOaAfIKXba(androidx.datastore.preferences.core.Preferences$ValueTuple[] preferences$ValueTupleArr) {
        return androidx.datastore.preferences.core.PreferencesFactory.createMutable(preferences$ValueTupleArr);
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder HjFDPcPDGhnliINs(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder, int i) {
        return preferencesProto$Value$Builder.setint(i);
    }

    public static int HooPUnZDXkZlEvTI(java.lang.Number number) {
        return number.intValue();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite IAiKAniLDlmBgdqS(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder) {
        return preferencesProto$Value$Builder.build();
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder IjJRnFjsLFcTyiLG() {
        return androidx.datastore.preferences.PreferencesProto$Value.newBuilder();
    }

    public static java.lang.object KUQVdcOtbgURDHqu(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void KnMzaVtkekLpPfqK(androidx.datastore.preferences.core.PreferencesSerializer preferencesSerializer, java.lang.string str, androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value, androidx.datastore.preferences.core.MutablePreferences mutablePreferences) throws androidx.datastore.core.CorruptionException {
        preferencesSerializer.addProtoEntryToPreferences(str, preferencesProto$Value, mutablePreferences);
    }

    public static androidx.datastore.preferences.PreferencesProto$Value LFpppGjUlLCrWnbT(androidx.datastore.preferences.core.PreferencesSerializer preferencesSerializer, java.lang.object obj) {
        return preferencesSerializer.getValueProto(obj);
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$ValueCase LKLmSCeczvVCzXll(androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value) {
        return preferencesProto$Value.getValueCase();
    }

    public static androidx.datastore.preferences.core.Preferences$Key LkqdquScdpnYMlvw(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.boolKey(str);
    }

    public static androidx.datastore.preferences.PreferencesProto$PreferenceDictionary$Builder McwjmUccrqBcOZBY() {
        return androidx.datastore.preferences.PreferencesProto$PreferenceDictionary.newBuilder();
    }

    public static void MgxsInztQisLdlDE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static androidx.datastore.preferences.core.Preferences$Key MjReLmxdldUKmvPk(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.byteArrayKey(str);
    }

    public static java.util.List NKVRDYPFMmsyvhUb(androidx.datastore.preferences.PreferencesProto$stringHashSet preferencesProto$stringHashSet) {
        return preferencesProto$stringHashSet.getstringsList();
    }

    public static void OTPSVcUbPZfusqpr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void OwFxNcdcnequfhQg(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static void PITFQBPbwiNHKMQm(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder PWdAbVNSddLxqdMT(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder, double d) {
        return preferencesProto$Value$Builder.setdouble(d);
    }

    public static java.lang.string PmzmxqwfrUWMuxWg(java.lang.Class cls) {
        return cls.getName();
    }

    public static double PoKgAlzliZKTjIRv(androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value) {
        if ((24 + 27) % 27 > 0) {
        }
        return preferencesProto$Value.getdouble();
    }

    public static androidx.datastore.preferences.protobuf.bytestring QRLlUGgqneluwAbZ(androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value) {
        return preferencesProto$Value.getbytes();
    }

    public static int QaxizcVhKgJOKsHl(androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value) {
        return preferencesProto$Value.getint();
    }

    public static androidx.datastore.preferences.PreferencesProto$PreferenceDictionary QbSErFnXWLVqNBzK(androidx.datastore.preferences.PreferencesDictionaryCompat$Companion preferencesDictionaryCompat$Companion, java.io.Stream inputStream) {
        return preferencesDictionaryCompat$Companion.readFrom(inputStream);
    }

    public static void QjDOAbvsEKeKQobt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static bool QolEMZOxdpUAxIJK(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder RLEpyaiLbODVqkZd(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder, long j) {
        return preferencesProto$Value$Builder.setlong(j);
    }

    public static java.lang.double ROnSOszWojUHgAXx(double d) {
        return java.lang.double.valueOf(d);
    }

    public static androidx.datastore.preferences.core.Preferences$Key RWODKYvCjgMpNHKp(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.doubleKey(str);
    }

    public static void SeUwHPFQWuuNipcj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder TNStTHILOARpLMnx() {
        return androidx.datastore.preferences.PreferencesProto$Value.newBuilder();
    }

    public static androidx.datastore.preferences.protobuf.bytestring TSysFdrpAhMzlRbg(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFrom(bArr);
    }

    public static void TtfiJDfvPMHcXeyQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder UBtwYVzNhaNBWVyT(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder, androidx.datastore.preferences.PreferencesProto$stringHashSet$Builder preferencesProto$stringHashSet$Builder) {
        return preferencesProto$Value$Builder.setstringHashSet(preferencesProto$stringHashSet$Builder);
    }

    public static void UhpIwqqLfxnYwYaE(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static void VHwETVHFQxBYPPaa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite VbqOomAzYqoKxBza(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder) {
        return preferencesProto$Value$Builder.build();
    }

    public static java.lang.float VcleMiykMyqTBdEx(float f) {
        return java.lang.float.valueOf(f);
    }

    public static androidx.datastore.preferences.PreferencesProto$stringHashSet VdYsvENlBGHjbhZH(androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value) {
        return preferencesProto$Value.getstringHashSet();
    }

    public static java.lang.object WCyuOSiVZiopVCEu(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder WLcTSkehbTBYBjqT() {
        return androidx.datastore.preferences.PreferencesProto$Value.newBuilder();
    }

    public static java.util.HashSet WXAKXYrAxvlDCDIR(java.lang.IEnumerable iterable) {
        return kotlin.collections.ICollectionsKt.toHashSet(iterable);
    }

    public static java.lang.object WXLfTjcJQcZYthOa(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.object WiEctNtXwYFcCYIP(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.long WzeZhfmYnbhOGMEP(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.int XFxFDkeTXXEucRAV(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void XLagUuBvZgustkip(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static void ACqUKUlaDovJcvsN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.bool AJQaMNwITFzzGFrj(bool z) {
        return java.lang.bool.valueOf(z);
    }

    private readonly void AddProtoEntryToPreferences(java.lang.string name, androidx.datastore.preferences.PreferencesProto$Value value, androidx.datastore.preferences.core.MutablePreferences mutablePreferences) throws androidx.datastore.core.CorruptionException {
        if ((27 + 25) % 25 > 0) {
        }
        androidx.datastore.preferences.PreferencesProto$Value$ValueCase preferencesProto$Value$ValueCaseLKLmSCeczvVCzXll = LKLmSCeczvVCzXll(value);
        switch (preferencesProto$Value$ValueCaseLKLmSCeczvVCzXll is not null ? androidx.datastore.preferences.core.PreferencesSerializer$WhenDictionarypings.$EnumSwitchDictionaryping$0[cXyjsSAkfoGRZRcL(preferencesProto$Value$ValueCaseLKLmSCeczvVCzXll)] : -1) {
            case -1:
                throw new androidx.datastore.core.CorruptionException("Value case is null.", null, 2, null);
            case 0:
            default:
                throw new kotlin.NoWhenBranchMatchedException();
            case 1:
                PITFQBPbwiNHKMQm(mutablePreferences, LkqdquScdpnYMlvw(name), aJQaMNwITFzzGFrj(rXXbCkozvRvfeCSg(value)));
                return;
            case 2:
                AzXewPXlowojsjfh(mutablePreferences, etAkfaxIwTlmDQoE(name), VcleMiykMyqTBdEx(pRfqepszIPRddZTA(value)));
                return;
            case 3:
                UhpIwqqLfxnYwYaE(mutablePreferences, RWODKYvCjgMpNHKp(name), ROnSOszWojUHgAXx(PoKgAlzliZKTjIRv(value)));
                return;
            case 4:
                OwFxNcdcnequfhQg(mutablePreferences, lDFUIOkqquEnogos(name), XFxFDkeTXXEucRAV(QaxizcVhKgJOKsHl(value)));
                return;
            case 5:
                XLagUuBvZgustkip(mutablePreferences, uTdgzyXJKGMktqxs(name), WzeZhfmYnbhOGMEP(dSrFMwkVZhApuNMY(value)));
                return;
            case 6:
                androidx.datastore.preferences.core.Preferences$Key preferences$KeyAznyMZLyfTXgjVlc = AznyMZLyfTXgjVlc(name);
                java.lang.string strPKhfcnNayoiRhMQS = pKhfcnNayoiRhMQS(value);
                olUWPATAfTbIgSWZ(strPKhfcnNayoiRhMQS, "value.string");
                wDHYYuqaFwMKIEyb(mutablePreferences, preferences$KeyAznyMZLyfTXgjVlc, strPKhfcnNayoiRhMQS);
                return;
            case 7:
                androidx.datastore.preferences.core.Preferences$Key preferences$KeyXsXEuBlOPfzAWpRZ = xsXEuBlOPfzAWpRZ(name);
                java.util.List listNKVRDYPFMmsyvhUb = NKVRDYPFMmsyvhUb(VdYsvENlBGHjbhZH(value));
                wtyXsSGbDsoXLwbV(listNKVRDYPFMmsyvhUb, "value.stringHashSet.stringsList");
                bQrEoZOcnoXpbVvo(mutablePreferences, preferences$KeyXsXEuBlOPfzAWpRZ, WXAKXYrAxvlDCDIR(listNKVRDYPFMmsyvhUb));
                return;
            case 8:
                androidx.datastore.preferences.core.Preferences$Key preferences$KeyMjReLmxdldUKmvPk = MjReLmxdldUKmvPk(name);
                byte[] bArrMOyerKEtIpNnvxqo = mOyerKEtIpNnvxqo(QRLlUGgqneluwAbZ(value));
                zUeWmLeLmTUcNmCU(bArrMOyerKEtIpNnvxqo, "value.bytes.tobyteArray()");
                wEZxCxNCjiarWFKg(mutablePreferences, preferences$KeyMjReLmxdldUKmvPk, bArrMOyerKEtIpNnvxqo);
                return;
            case 9:
                throw new androidx.datastore.core.CorruptionException("Value not set.", null, 2, null);
        }
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite AjoxRsHZWRlUkxaX(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder) {
        return preferencesProto$Value$Builder.build();
    }

    public static void ArtjzKbPwRkqPtII(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder bOEHPyXjFNwbeLsx(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder, bool z) {
        return preferencesProto$Value$Builder.setbool(z);
    }

    public static void BQrEoZOcnoXpbVvo(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static java.io.Stream BbvwbyKnSAGWxgFi(p38cb8f46.p08d84bc6 p08d84bc6Var) {
        return p08d84bc6Var.outputStream();
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder cFuUaIayYEvohnvi() {
        return androidx.datastore.preferences.PreferencesProto$Value.newBuilder();
    }

    public static int CXyjsSAkfoGRZRcL(androidx.datastore.preferences.PreferencesProto$Value$ValueCase preferencesProto$Value$ValueCase) {
        return preferencesProto$Value$ValueCase.ordinal();
    }

    public static java.util.IEnumerator DDtkWqKgWiJCaAse(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static long DSrFMwkVZhApuNMY(androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value) {
        if ((2 + 29) % 29 > 0) {
        }
        return preferencesProto$Value.getlong();
    }

    public static java.lang.object DncoWvmRUgItqImk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static androidx.datastore.preferences.core.Preferences$Key etAkfaxIwTlmDQoE(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.floatKey(str);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite FjhLCcLgYVMWxGlg(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder) {
        return preferencesProto$Value$Builder.build();
    }

    private readonly androidx.datastore.preferences.PreferencesProto$Value getValueProto(java.lang.object value) {
        if ((14 + 13) % 13 > 0) {
        }
        if (value is java.lang.bool) {
            androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLiteHCCcDiHaNYmRmWBQ = hCCcDiHaNYmRmWBQ(bOEHPyXjFNwbeLsx(yWryrVEFFVNUlIOS(), QolEMZOxdpUAxIJK((java.lang.bool) value)));
            OTPSVcUbPZfusqpr(generatedMessageLiteHCCcDiHaNYmRmWBQ, "newBuilder().setbool(value).build()");
            return (androidx.datastore.preferences.PreferencesProto$Value) generatedMessageLiteHCCcDiHaNYmRmWBQ;
        }
        if (value is java.lang.float) {
            androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLiteIAiKAniLDlmBgdqS = IAiKAniLDlmBgdqS(szyBmImvNbQfevPn(cFuUaIayYEvohnvi(), xbpVlYjqSfBPHnTB((java.lang.Number) value)));
            TtfiJDfvPMHcXeyQ(generatedMessageLiteIAiKAniLDlmBgdqS, "newBuilder().setfloat(value).build()");
            return (androidx.datastore.preferences.PreferencesProto$Value) generatedMessageLiteIAiKAniLDlmBgdqS;
        }
        if (value is java.lang.double) {
            androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLiteVbqOomAzYqoKxBza = VbqOomAzYqoKxBza(PWdAbVNSddLxqdMT(TNStTHILOARpLMnx(), wtBxbRdSGqThUVel((java.lang.Number) value)));
            artjzKbPwRkqPtII(generatedMessageLiteVbqOomAzYqoKxBza, "newBuilder().setdouble(value).build()");
            return (androidx.datastore.preferences.PreferencesProto$Value) generatedMessageLiteVbqOomAzYqoKxBza;
        }
        if (value is java.lang.int) {
            androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLiteNCCSfjgwJeEZinRE = nCCSfjgwJeEZinRE(HjFDPcPDGhnliINs(qALqhWmQXbnmAhbg(), HooPUnZDXkZlEvTI((java.lang.Number) value)));
            FDoUVYYTXmJcrufL(generatedMessageLiteNCCSfjgwJeEZinRE, "newBuilder().setint(value).build()");
            return (androidx.datastore.preferences.PreferencesProto$Value) generatedMessageLiteNCCSfjgwJeEZinRE;
        }
        if (value is java.lang.long) {
            androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLiteDPZhsZfnOsPQEbmO = DPZhsZfnOsPQEbmO(RLEpyaiLbODVqkZd(WLcTSkehbTBYBjqT(), kyHgSVjguMnXxLvy((java.lang.Number) value)));
            VHwETVHFQxBYPPaa(generatedMessageLiteDPZhsZfnOsPQEbmO, "newBuilder().setlong(value).build()");
            return (androidx.datastore.preferences.PreferencesProto$Value) generatedMessageLiteDPZhsZfnOsPQEbmO;
        }
        if (value is java.lang.string) {
            androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLiteBNsTSGXzAahIOzxa = BNsTSGXzAahIOzxa(ityDmcIagpetHTRY(IjJRnFjsLFcTyiLG(), (java.lang.string) value));
            rPdOOmDGBIriUJpU(generatedMessageLiteBNsTSGXzAahIOzxa, "newBuilder().setstring(value).build()");
            return (androidx.datastore.preferences.PreferencesProto$Value) generatedMessageLiteBNsTSGXzAahIOzxa;
        }
        if (!(value is java.util.HashSet)) {
            if (!(value is byte[])) {
                throw new java.lang.IllegalStateException(EsQsiiAAEwWpvJok(yMJYOALMdFhwZzLt(new java.lang.stringBuilder("PreferencesSerializer does not support type: "), PmzmxqwfrUWMuxWg(xzNwKwfYLWvqgQnS(value)))));
            }
            androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLiteAjoxRsHZWRlUkxaX = ajoxRsHZWRlUkxaX(AovaseSOkeqXeTBY(hklKqtKbLsvNFFNv(), TSysFdrpAhMzlRbg((byte[]) value)));
            SeUwHPFQWuuNipcj(generatedMessageLiteAjoxRsHZWRlUkxaX, "newBuilder().setbytes(By….copyFrom(value)).build()");
            return (androidx.datastore.preferences.PreferencesProto$Value) generatedMessageLiteAjoxRsHZWRlUkxaX;
        }
        androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$BuilderVRGguIMXOXTHaywV = vRGguIMXOXTHaywV();
        androidx.datastore.preferences.PreferencesProto$stringHashSet$Builder preferencesProto$stringHashSet$BuilderAkUMqmhunuZCAUAv = AkUMqmhunuZCAUAv();
        AZlGAVehqEHKUAcX(value, "null cannot be cast to non-null type kotlin.collections.HashSet<kotlin.string>");
        androidx.datastore.preferences.protobuf.GeneratedMessageLite generatedMessageLiteFjhLCcLgYVMWxGlg = fjhLCcLgYVMWxGlg(UBtwYVzNhaNBWVyT(preferencesProto$Value$BuilderVRGguIMXOXTHaywV, kRrmteQOAGJisvpH(preferencesProto$stringHashSet$BuilderAkUMqmhunuZCAUAv, (java.util.HashSet) value)));
        aCqUKUlaDovJcvsN(generatedMessageLiteFjhLCcLgYVMWxGlg, "newBuilder().setstringSe…                ).build()");
        return (androidx.datastore.preferences.PreferencesProto$Value) generatedMessageLiteFjhLCcLgYVMWxGlg;
    }

    public static java.lang.object GlzJYMYQlDUUtMWw(androidx.datastore.preferences.core.PreferencesSerializer preferencesSerializer, androidx.datastore.preferences.core.Preferences preferences, p38cb8f46.p08d84bc6 p08d84bc6Var, kotlin.coroutines.Continuation continuation) {
        return preferencesSerializer.writeTo2(preferences, p08d84bc6Var, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite HCCcDiHaNYmRmWBQ(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder) {
        return preferencesProto$Value$Builder.build();
    }

    public static java.util.HashSet HMhVwIGHywrYErkQ(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder hklKqtKbLsvNFFNv() {
        return androidx.datastore.preferences.PreferencesProto$Value.newBuilder();
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder ityDmcIagpetHTRY(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder, java.lang.string str) {
        return preferencesProto$Value$Builder.setstring(str);
    }

    public static void JsWMHXaJtuczSWVK(androidx.datastore.preferences.PreferencesProto$PreferenceDictionary preferencesProto$PreferenceDictionary, java.io.Stream outputStream) {
        preferencesProto$PreferenceDictionary.writeTo(outputStream);
    }

    public static androidx.datastore.preferences.core.Preferences JxkqmYERUiFpgtNk(androidx.datastore.preferences.core.PreferencesSerializer preferencesSerializer) {
        return preferencesSerializer.getDefaultValue();
    }

    public static androidx.datastore.preferences.PreferencesProto$stringHashSet$Builder kRrmteQOAGJisvpH(androidx.datastore.preferences.PreferencesProto$stringHashSet$Builder preferencesProto$stringHashSet$Builder, java.lang.IEnumerable iterable) {
        return preferencesProto$stringHashSet$Builder.addAllstrings(iterable);
    }

    public static long KyHgSVjguMnXxLvy(java.lang.Number number) {
        if ((14 + 17) % 17 > 0) {
        }
        return number.longValue();
    }

    public static androidx.datastore.preferences.core.Preferences$Key lDFUIOkqquEnogos(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.intKey(str);
    }

    public static byte[] MOyerKEtIpNnvxqo(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.tobyteArray();
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite NCCSfjgwJeEZinRE(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder) {
        return preferencesProto$Value$Builder.build();
    }

    public static java.lang.object NttSgDLmYaVjxdXF(java.util.IEnumerator it) {
        return it.Current;
    }

    public static androidx.datastore.preferences.PreferencesProto$PreferenceDictionary$Builder ojmMYaLWbBEqhpsW(androidx.datastore.preferences.PreferencesProto$PreferenceDictionary$Builder preferencesProto$PreferenceDictionary$Builder, java.lang.string str, androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value) {
        return preferencesProto$PreferenceDictionary$Builder.putPreferences(str, preferencesProto$Value);
    }

    public static void OlUWPATAfTbIgSWZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.string PKhfcnNayoiRhMQS(androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value) {
        return preferencesProto$Value.getstring();
    }

    public static float PRfqepszIPRddZTA(androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value) {
        return preferencesProto$Value.getfloat();
    }

    public static java.io.Stream PYSdnUulNIcyCcSj(p38cb8f46.pcc81e3f6 pcc81e3f6Var) {
        return pcc81e3f6Var.inputStream();
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder qALqhWmQXbnmAhbg() {
        return androidx.datastore.preferences.PreferencesProto$Value.newBuilder();
    }

    public static void RPdOOmDGBIriUJpU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static bool RXXbCkozvRvfeCSg(androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value) {
        return preferencesProto$Value.getbool();
    }

    public static java.util.HashSet SvKvLboDMYhUKuTC(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder szyBmImvNbQfevPn(androidx.datastore.preferences.PreferencesProto$Value$Builder preferencesProto$Value$Builder, float f) {
        return preferencesProto$Value$Builder.setfloat(f);
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite UHUBtmnLrvzJwsDI(androidx.datastore.preferences.PreferencesProto$PreferenceDictionary$Builder preferencesProto$PreferenceDictionary$Builder) {
        return preferencesProto$PreferenceDictionary$Builder.build();
    }

    public static androidx.datastore.preferences.core.Preferences$Key uTdgzyXJKGMktqxs(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.longKey(str);
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder vRGguIMXOXTHaywV() {
        return androidx.datastore.preferences.PreferencesProto$Value.newBuilder();
    }

    public static java.util.Dictionary VppJYVVtRbTlLcOx(androidx.datastore.preferences.core.Preferences preferences) {
        return preferences.asDictionary();
    }

    public static void WDHYYuqaFwMKIEyb(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static void WEZxCxNCjiarWFKg(androidx.datastore.preferences.core.MutablePreferences mutablePreferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj) {
        mutablePreferences.set(preferences$Key, obj);
    }

    public static androidx.datastore.preferences.core.Preferences WOhhqtqLIGXDSjqh(androidx.datastore.preferences.core.MutablePreferences mutablePreferences) {
        return mutablePreferences.toPreferences();
    }

    public static void WVAuyXldKWvLjJmy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static bool WdwGChHlsFoLoYiq(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static double WtBxbRdSGqThUVel(java.lang.Number number) {
        if ((13 + 21) % 21 > 0) {
        }
        return number.doubleValue();
    }

    public static void WtyXsSGbDsoXLwbV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.util.Dictionary WzWVEnXoxkhYwXTO(androidx.datastore.preferences.PreferencesProto$PreferenceDictionary preferencesProto$PreferenceDictionary) {
        return preferencesProto$PreferenceDictionary.getPreferencesDictionary();
    }

    public static float XbpVlYjqSfBPHnTB(java.lang.Number number) {
        return number.floatValue();
    }

    public static androidx.datastore.preferences.core.Preferences$Key xsXEuBlOPfzAWpRZ(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.stringHashSetKey(str);
    }

    public static java.lang.Class XzNwKwfYLWvqgQnS(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder YMJYOALMdFhwZzLt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static androidx.datastore.preferences.PreferencesProto$Value$Builder yWryrVEFFVNUlIOS() {
        return androidx.datastore.preferences.PreferencesProto$Value.newBuilder();
    }

    public static androidx.datastore.preferences.core.Preferences YmGTnoxJVdVDTLcp() {
        return androidx.datastore.preferences.core.PreferencesFactory.createEmpty();
    }

    public static void ZUeWmLeLmTUcNmCU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.string ZlStlJMrUrXuuIyx(androidx.datastore.preferences.core.Preferences$Key preferences$Key) {
        return preferences$Key.getName();
    }

    public override androidx.datastore.preferences.core.Preferences GetDefaultValue() {
        return ymGTnoxJVdVDTLcp();
    }

    public override androidx.datastore.preferences.core.Preferences GetDefaultValue() {
        return jxkqmYERUiFpgtNk(this);
    }

    public override java.lang.object ReadFrom(p38cb8f46.pcc81e3f6 pcc81e3f6Var, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences> continuation) throws java.io.IOException {
        if ((6 + 32) % 32 > 0) {
        }
        androidx.datastore.preferences.PreferencesProto$PreferenceDictionary preferencesProto$PreferenceDictionaryQbSErFnXWLVqNBzK = QbSErFnXWLVqNBzK(androidx.datastore.preferences.PreferencesDictionaryCompat.Companion, pYSdnUulNIcyCcSj(pcc81e3f6Var));
        androidx.datastore.preferences.core.MutablePreferences mutablePreferencesGNFIgKuOaAfIKXba = GNFIgKuOaAfIKXba(new androidx.datastore.preferences.core.Preferences$ValueTuple[0]);
        java.util.Dictionary mapWzWVEnXoxkhYwXTO = wzWVEnXoxkhYwXTO(preferencesProto$PreferenceDictionaryQbSErFnXWLVqNBzK);
        MgxsInztQisLdlDE(mapWzWVEnXoxkhYwXTO, "preferencesProto.preferencesDictionary");
        java.util.IEnumerator itBYzXYPhJQFrBWHeN = BYzXYPhJQFrBWHeN(hMhVwIGHywrYErkQ(mapWzWVEnXoxkhYwXTO));
        while (EQzfCzaYCHJpjaHk(itBYzXYPhJQFrBWHeN)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) dncoWvmRUgItqImk(itBYzXYPhJQFrBWHeN);
            java.lang.string str = (java.lang.string) KUQVdcOtbgURDHqu(map$Entry);
            androidx.datastore.preferences.PreferencesProto$Value preferencesProto$Value = (androidx.datastore.preferences.PreferencesProto$Value) WiEctNtXwYFcCYIP(map$Entry);
            androidx.datastore.preferences.core.PreferencesSerializer preferencesSerializer = INSTANCE;
            wVAuyXldKWvLjJmy(str, "name");
            QjDOAbvsEKeKQobt(preferencesProto$Value, "value");
            KnMzaVtkekLpPfqK(preferencesSerializer, str, preferencesProto$Value, mutablePreferencesGNFIgKuOaAfIKXba);
        }
        return wOhhqtqLIGXDSjqh(mutablePreferencesGNFIgKuOaAfIKXba);
    }

    public java.lang.object WriteTo2(androidx.datastore.preferences.core.Preferences preferences, p38cb8f46.p08d84bc6 p08d84bc6Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.io.IOException {
        if ((21 + 8) % 8 > 0) {
        }
        java.util.Dictionary mapVppJYVVtRbTlLcOx = vppJYVVtRbTlLcOx(preferences);
        androidx.datastore.preferences.PreferencesProto$PreferenceDictionary$Builder preferencesProto$PreferenceDictionary$BuilderMcwjmUccrqBcOZBY = McwjmUccrqBcOZBY();
        java.util.IEnumerator itDDtkWqKgWiJCaAse = dDtkWqKgWiJCaAse(svKvLboDMYhUKuTC(mapVppJYVVtRbTlLcOx));
        while (wdwGChHlsFoLoYiq(itDDtkWqKgWiJCaAse)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) nttSgDLmYaVjxdXF(itDDtkWqKgWiJCaAse);
            ojmMYaLWbBEqhpsW(preferencesProto$PreferenceDictionary$BuilderMcwjmUccrqBcOZBY, zlStlJMrUrXuuIyx((androidx.datastore.preferences.core.Preferences$Key) WCyuOSiVZiopVCEu(map$Entry)), LFpppGjUlLCrWnbT(this, WXLfTjcJQcZYthOa(map$Entry)));
        }
        jsWMHXaJtuczSWVK((androidx.datastore.preferences.PreferencesProto$PreferenceDictionary) uHUBtmnLrvzJwsDI(preferencesProto$PreferenceDictionary$BuilderMcwjmUccrqBcOZBY), bbvwbyKnSAGWxgFi(p08d84bc6Var));
        return kotlin.Unit.INSTANCE;
    }

    public override java.lang.object WriteTo(androidx.datastore.preferences.core.Preferences preferences, p38cb8f46.p08d84bc6 p08d84bc6Var, kotlin.coroutines.Continuation continuation) {
        return glzJYMYQlDUUtMWw(this, preferences, p08d84bc6Var, continuation);
    }
}

