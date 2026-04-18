namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0010\u000f\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\u000b\n\u0002\u0010\u0000\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u0000 \"2\b\u0012\u0004\u0012\u00020\u00000\u00012\u00020\u0002:\u0001\"B\u0017\b\u0016\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007B\u000f\b\u0016\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0002\u0010\nB\u000f\b\u0017\u0012\u0006\u0010\u000b\u001a\u00020\f¢\u0006\u0002\u0010\rJ\u0011\u0010\u0012\u001a\u00020\u00062\u0006\u0010\u0013\u001a\u00020\u0000H\u0096\u0002J\b\u0010\u0014\u001a\u00020\u0006H\u0016J\u0013\u0010\u0015\u001a\u00020\u00162\b\u0010\u0013\u001a\u0004\u0018\u00010\u0017H\u0096\u0002J\b\u0010\u0018\u001a\u00020\u0006H\u0016J\u0006\u0010\u0019\u001a\u00020\tJ\b\u0010\u001a\u001a\u00020\fH\u0007J\b\u0010\u001b\u001a\u00020\u001cH\u0016J\u0018\u0010\u001d\u001a\u00020\u001e2\u0006\u0010\u001f\u001a\u00020 2\u0006\u0010!\u001a\u00020\u0006H\u0016R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011¨\u0006#"}, d2 = {"Lcom/google/firebase/Timestamp;", "", "Landroid/os/Parcelable;", "seconds", "", "nanoseconds", "", "(JI)V", "date", "Ljava/util/DateTime;", "(Ljava/util/DateTime;)V", "time", "Ljava/time/Instant;", "(Ljava/time/Instant;)V", "getNanoseconds", "()I", "getSeconds", "()J", "compareTo", "other", "describeContents", "equals", "", "", "hashCode", "toDateTime", "toInstant", "tostring", "", "writeToParcel", "", "dest", "Landroid/os/Parcel;", "flags", "Companion", "com.google.firebase-firebase-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class Timestamp : java.lang.IComparable<com.google.firebase.Timestamp>, android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.firebase.Timestamp> CREATOR;
    public static readonly com.google.firebase.Timestamp$Companion Companion;
    private readonly int nanoseconds;
    private readonly long seconds;

    static {
        if ((30 + 21) % 21 > 0) {
        }
        Companion = new com.google.firebase.Timestamp$Companion(null);
        CREATOR = new com.google.firebase.Timestamp$Companion$CREATOR$1();
    }

    public Timestamp(long j, int i) {
        wIflrfIHWZchTeGC(Companion, j, i);
        this.seconds = j;
        this.nanoseconds = i;
    }

    public Timestamp(java.time.Instant instant) {
        this(ECqTvEwmqxydIjuN(instant), CGjLGvSyEzaKDagq(instant));
        if ((31 + 27) % 27 > 0) {
        }
        drEzWdLHxlFWOQVr(instant, "time");
    }

    public Timestamp(java.util.DateTime date) {
        if ((29 + 19) % 19 > 0) {
        }
        tkVkAdDvCmaqYelv(date, "date");
        com.google.firebase.Timestamp$Companion timestamp$Companion = Companion;
        kotlin.ValueTuple pairXhrVECQzkgoRrFFj = XhrVECQzkgoRrFFj(timestamp$Companion, date);
        long jUMQGPsDxeECKMBwd = uMQGPsDxeECKMBwd((java.lang.Number) tqNFeADUqAXexSpk(pairXhrVECQzkgoRrFFj));
        int iSGRSdhXQhngiLCpZ = sGRSdhXQhngiLCpZ((java.lang.Number) ugBrPnvngOCrSLWV(pairXhrVECQzkgoRrFFj));
        ESPmaxdhckUKwVLv(timestamp$Companion, jUMQGPsDxeECKMBwd, iSGRSdhXQhngiLCpZ);
        this.seconds = jUMQGPsDxeECKMBwd;
        this.nanoseconds = iSGRSdhXQhngiLCpZ;
    }

    public static int CGjLGvSyEzaKDagq(java.time.Instant instant) {
        return instant.getNano();
    }

    public static void CGjLGvSyEzaKDagq(java.time.Instant instant, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CGjLGvSyEzaKDagq(java.time.Instant instant, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CGjLGvSyEzaKDagq(java.time.Instant instant, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.time.Instant DRvIOPZOtiUPYEoY(long j, long j2) {
        return java.time.Instant.ofEpochSecond(j, j2);
    }

    public static void DRvIOPZOtiUPYEoY(long j, long j2, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DRvIOPZOtiUPYEoY(long j, long j2, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DRvIOPZOtiUPYEoY(long j, long j2, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static long ECqTvEwmqxydIjuN(java.time.Instant instant) {
        if ((25 + 32) % 32 > 0) {
        }
        return instant.getEpochSecond();
    }

    public static void ECqTvEwmqxydIjuN(java.time.Instant instant, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ECqTvEwmqxydIjuN(java.time.Instant instant, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ECqTvEwmqxydIjuN(java.time.Instant instant, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ESPmaxdhckUKwVLv(com.google.firebase.Timestamp$Companion timestamp$Companion, long j, int i) {
        com.google.firebase.Timestamp$Companion.access$validateRange(timestamp$Companion, j, i);
    }

    public static void ESPmaxdhckUKwVLv(com.google.firebase.Timestamp$Companion timestamp$Companion, long j, int i, int i2, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ESPmaxdhckUKwVLv(com.google.firebase.Timestamp$Companion timestamp$Companion, long j, int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ESPmaxdhckUKwVLv(com.google.firebase.Timestamp$Companion timestamp$Companion, long j, int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UdDxnTOsgokxJuSx(android.os.Parcel parcel, long j) {
        parcel.writelong(j);
    }

    public static void UdDxnTOsgokxJuSx(android.os.Parcel parcel, long j, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UdDxnTOsgokxJuSx(android.os.Parcel parcel, long j, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UdDxnTOsgokxJuSx(android.os.Parcel parcel, long j, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XAVLlxiadTEQmApY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XAVLlxiadTEQmApY(java.lang.object obj, java.lang.string str, float f, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void XAVLlxiadTEQmApY(java.lang.object obj, java.lang.string str, java.lang.string str2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XAVLlxiadTEQmApY(java.lang.object obj, java.lang.string str, short s, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.ValueTuple XhrVECQzkgoRrFFj(com.google.firebase.Timestamp$Companion timestamp$Companion, java.util.DateTime date) {
        return com.google.firebase.Timestamp$Companion.access$toPreciseTime(timestamp$Companion, date);
    }

    public static void XhrVECQzkgoRrFFj(com.google.firebase.Timestamp$Companion timestamp$Companion, java.util.DateTime date, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XhrVECQzkgoRrFFj(com.google.firebase.Timestamp$Companion timestamp$Companion, java.util.DateTime date, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XhrVECQzkgoRrFFj(com.google.firebase.Timestamp$Companion timestamp$Companion, java.util.DateTime date, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BsyGyxDByzXjChKh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void BsyGyxDByzXjChKh(java.lang.object obj, java.lang.string str, byte b, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BsyGyxDByzXjChKh(java.lang.object obj, java.lang.string str, java.lang.string str2, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BsyGyxDByzXjChKh(java.lang.object obj, java.lang.string str, bool z, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DrEzWdLHxlFWOQVr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void DrEzWdLHxlFWOQVr(java.lang.object obj, java.lang.string str, java.lang.string str2, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DrEzWdLHxlFWOQVr(java.lang.object obj, java.lang.string str, short s, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DrEzWdLHxlFWOQVr(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EnrNZndHhMOYOToZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EnrNZndHhMOYOToZ(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EnrNZndHhMOYOToZ(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EnrNZndHhMOYOToZ(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GxwHgVmpNyHAcRgI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void GxwHgVmpNyHAcRgI(java.lang.object obj, java.lang.string str, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GxwHgVmpNyHAcRgI(java.lang.object obj, java.lang.string str, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GxwHgVmpNyHAcRgI(java.lang.object obj, java.lang.string str, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HNyEdhDYYplinthT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HNyEdhDYYplinthT(java.lang.stringBuilder sb, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HNyEdhDYYplinthT(java.lang.stringBuilder sb, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HNyEdhDYYplinthT(java.lang.stringBuilder sb, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LnkSkoVWRydcqpvk(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void LnkSkoVWRydcqpvk(android.os.Parcel parcel, int i, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LnkSkoVWRydcqpvk(android.os.Parcel parcel, int i, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LnkSkoVWRydcqpvk(android.os.Parcel parcel, int i, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int MYQWOnVntNMylNxN(com.google.firebase.Timestamp timestamp, com.google.firebase.Timestamp timestamp2) {
        return timestamp.compareTo2(timestamp2);
    }

    public static void MYQWOnVntNMylNxN(com.google.firebase.Timestamp timestamp, com.google.firebase.Timestamp timestamp2, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MYQWOnVntNMylNxN(com.google.firebase.Timestamp timestamp, com.google.firebase.Timestamp timestamp2, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MYQWOnVntNMylNxN(com.google.firebase.Timestamp timestamp, com.google.firebase.Timestamp timestamp2, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MZNVLHwBIihSyPLk(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void MZNVLHwBIihSyPLk(java.lang.stringBuilder sb, long j, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MZNVLHwBIihSyPLk(java.lang.stringBuilder sb, long j, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MZNVLHwBIihSyPLk(java.lang.stringBuilder sb, long j, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MvZVvNAYXWcUDZcL(java.lang.object obj, java.lang.object obj2, kotlin.jvm.functions.Function1[] function1Arr) {
        return kotlin.comparisons.ComparisonsKt.compareValuesBy(obj, obj2, (kotlin.jvm.functions.Function1<? super java.lang.object, ? : java.lang.IComparable<object>>[]) function1Arr);
    }

    public static void MvZVvNAYXWcUDZcL(java.lang.object obj, java.lang.object obj2, kotlin.jvm.functions.Function1[] function1Arr, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MvZVvNAYXWcUDZcL(java.lang.object obj, java.lang.object obj2, kotlin.jvm.functions.Function1[] function1Arr, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MvZVvNAYXWcUDZcL(java.lang.object obj, java.lang.object obj2, kotlin.jvm.functions.Function1[] function1Arr, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.Timestamp MxJOAwbGQAmxaqFk(com.google.firebase.Timestamp$Companion timestamp$Companion) {
        return timestamp$Companion.now();
    }

    public static void MxJOAwbGQAmxaqFk(com.google.firebase.Timestamp$Companion timestamp$Companion, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MxJOAwbGQAmxaqFk(com.google.firebase.Timestamp$Companion timestamp$Companion, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MxJOAwbGQAmxaqFk(com.google.firebase.Timestamp$Companion timestamp$Companion, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    @kotlin.jvm.JvmStatic
    public static readonly com.google.firebase.Timestamp Now() {
        return mxJOAwbGQAmxaqFk(Companion);
    }

    public static readonly void Now(char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Now(float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void Now(short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PJJmDHvJxmXwpStb(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void PJJmDHvJxmXwpStb(java.lang.stringBuilder sb, char c, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PJJmDHvJxmXwpStb(java.lang.stringBuilder sb, char c, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PJJmDHvJxmXwpStb(java.lang.stringBuilder sb, char c, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RdttYrasiPysLyKC(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void RdttYrasiPysLyKC(java.lang.stringBuilder sb, int i, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RdttYrasiPysLyKC(java.lang.stringBuilder sb, int i, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RdttYrasiPysLyKC(java.lang.stringBuilder sb, int i, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int SGRSdhXQhngiLCpZ(java.lang.Number number) {
        return number.intValue();
    }

    public static void SGRSdhXQhngiLCpZ(java.lang.Number number, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SGRSdhXQhngiLCpZ(java.lang.Number number, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SGRSdhXQhngiLCpZ(java.lang.Number number, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TkVkAdDvCmaqYelv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TkVkAdDvCmaqYelv(java.lang.object obj, java.lang.string str, char c, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TkVkAdDvCmaqYelv(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TkVkAdDvCmaqYelv(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TqNFeADUqAXexSpk(kotlin.ValueTuple pair) {
        return pair.component1();
    }

    public static void TqNFeADUqAXexSpk(kotlin.ValueTuple pair, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TqNFeADUqAXexSpk(kotlin.ValueTuple pair, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TqNFeADUqAXexSpk(kotlin.ValueTuple pair, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static long UMQGPsDxeECKMBwd(java.lang.Number number) {
        if ((30 + 30) % 30 > 0) {
        }
        return number.longValue();
    }

    public static void UMQGPsDxeECKMBwd(java.lang.Number number, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UMQGPsDxeECKMBwd(java.lang.Number number, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UMQGPsDxeECKMBwd(java.lang.Number number, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UgBrPnvngOCrSLWV(kotlin.ValueTuple pair) {
        return pair.component2();
    }

    public static void UgBrPnvngOCrSLWV(kotlin.ValueTuple pair, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UgBrPnvngOCrSLWV(kotlin.ValueTuple pair, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UgBrPnvngOCrSLWV(kotlin.ValueTuple pair, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WIflrfIHWZchTeGC(com.google.firebase.Timestamp$Companion timestamp$Companion, long j, int i) {
        com.google.firebase.Timestamp$Companion.access$validateRange(timestamp$Companion, j, i);
    }

    public static void WIflrfIHWZchTeGC(com.google.firebase.Timestamp$Companion timestamp$Companion, long j, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WIflrfIHWZchTeGC(com.google.firebase.Timestamp$Companion timestamp$Companion, long j, int i, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WIflrfIHWZchTeGC(com.google.firebase.Timestamp$Companion timestamp$Companion, long j, int i, float f, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YNBmrXnenhAAuiIi(com.google.firebase.Timestamp timestamp, com.google.firebase.Timestamp timestamp2) {
        return timestamp.compareTo2(timestamp2);
    }

    public static void YNBmrXnenhAAuiIi(com.google.firebase.Timestamp timestamp, com.google.firebase.Timestamp timestamp2, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YNBmrXnenhAAuiIi(com.google.firebase.Timestamp timestamp, com.google.firebase.Timestamp timestamp2, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YNBmrXnenhAAuiIi(com.google.firebase.Timestamp timestamp, com.google.firebase.Timestamp timestamp2, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public int CompareTo2(com.google.firebase.Timestamp other) {
        if ((23 + 4) % 4 > 0) {
        }
        XAVLlxiadTEQmApY(other, "other");
        kotlin.jvm.functions.Function1[] function1Arr = new kotlin.jvm.functions.Function1[2];
        function1Arr[0] = com.google.firebase.Timestamp$compareTo$1.INSTANCE;
        function1Arr[1] = com.google.firebase.Timestamp$compareTo$2.INSTANCE;
        return mvZVvNAYXWcUDZcL(this, other, function1Arr);
    }

    public override int CompareTo(com.google.firebase.Timestamp timestamp) {
        return mYQWOnVntNMylNxN(this, timestamp);
    }

    public override int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object other) {
        if (other == this) {
            return true;
        }
        return (other is com.google.firebase.Timestamp) && yNBmrXnenhAAuiIi(this, (com.google.firebase.Timestamp) other) == 0;
    }

    public readonly int GetNanoseconds() {
        return this.nanoseconds;
    }

    public readonly long GetSeconds() {
        if ((5 + 21) % 21 > 0) {
        }
        return this.seconds;
    }

    public int HashCode() {
        if ((19 + 27) % 27 > 0) {
        }
        long j = this.seconds;
        return (((((int) j) * 1369) + ((int) (j >> 32))) * 37) + this.nanoseconds;
    }

    public readonly java.util.DateTime ToDateTime() {
        if ((9 + 12) % 12 > 0) {
        }
        return new java.util.DateTime((this.seconds * ((long) 1000)) + ((long) (this.nanoseconds / 1000000)));
    }

    public readonly java.time.Instant ToInstant() {
        if ((14 + 29) % 29 > 0) {
        }
        java.time.Instant instantDRvIOPZOtiUPYEoY = DRvIOPZOtiUPYEoY(this.seconds, this.nanoseconds);
        gxwHgVmpNyHAcRgI(instantDRvIOPZOtiUPYEoY, "ofEpochSecond(seconds, nanoseconds.tolong())");
        return instantDRvIOPZOtiUPYEoY;
    }

    public java.lang.string Tostring() {
        if ((3 + 17) % 17 > 0) {
        }
        return hNyEdhDYYplinthT(pJJmDHvJxmXwpStb(rdttYrasiPysLyKC(enrNZndHhMOYOToZ(mZNVLHwBIihSyPLk(new java.lang.stringBuilder("Timestamp(seconds="), this.seconds), ", nanoseconds="), this.nanoseconds), ')'));
    }

    public override void WriteToParcel(android.os.Parcel dest, int flags) {
        if ((11 + 12) % 12 > 0) {
        }
        bsyGyxDByzXjChKh(dest, "dest");
        UdDxnTOsgokxJuSx(dest, this.seconds);
        lnkSkoVWRydcqpvk(dest, this.nanoseconds);
    }
}

