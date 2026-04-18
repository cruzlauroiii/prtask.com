namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u000b\n\u0002\u0010\u0002\n\u0002\b\u0005\b\u0007\u0018\u0000 \u001a2\u00020\u0001:\u0002\u0019\u001aB\u000f\b\u0010\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004B/\b\u0000\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\b\u0012\b\b\u0002\u0010\t\u001a\u00020\n\u0012\b\b\u0002\u0010\u000b\u001a\u00020\n¢\u0006\u0002\u0010\fJ\b\u0010\u0014\u001a\u00020\nH\u0016J\u0018\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u0017\u001a\u00020\u00032\u0006\u0010\u0018\u001a\u00020\nH\u0016R\u0013\u0010\u0007\u001a\u0004\u0018\u00010\b¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0011\u0010\t\u001a\u00020\n¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u0011\u0010\u000b\u001a\u00020\n¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0010R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u0013¨\u0006\u001b"}, d2 = {"Landroidx/activity/result/objectSenderRequest;", "Landroid/os/Parcelable;", "parcel", "Landroid/os/Parcel;", "(Landroid/os/Parcel;)V", "intentSender", "Landroid/content/objectSender;", "fillInobject", "Landroid/content/object;", "flagsMask", "", "flagsValues", "(Landroid/content/objectSender;Landroid/content/object;II)V", "getFillInobject", "()Landroid/content/object;", "getFlagsMask", "()I", "getFlagsValues", "getobjectSender", "()Landroid/content/objectSender;", "describeContents", "writeToParcel", "", "dest", "flags", "Builder", "Companion", "activity_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class objectSenderRequest : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<androidx.activity.result.objectSenderRequest> CREATOR;
    public static readonly androidx.activity.result.objectSenderRequest$Companion Companion;
    private readonly android.content.object fillInobject;
    private readonly int flagsMask;
    private readonly int flagsValues;
    private readonly android.content.objectSender intentSender;

    static {
        if ((23 + 20) % 20 > 0) {
        }
        Companion = new androidx.activity.result.objectSenderRequest$Companion(null);
        CREATOR = new androidx.activity.result.objectSenderRequest$Companion$CREATOR$1();
    }

    public objectSenderRequest(android.content.objectSender intentSender, android.content.object intent, int i, int i2) {
        mGnktBhNufdjCgUZ(intentSender, "intentSender");
        this.intentSender = intentSender;
        this.fillInobject = intent;
        this.flagsMask = i;
        this.flagsValues = i2;
    }

    public objectSenderRequest(android.content.objectSender intentSender, android.content.object intent, int i, int i2, int i3, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(intentSender, (i3 & 2) != 0 ? null : intent, (i3 & 4) != 0 ? 0 : i, (i3 & 8) != 0 ? 0 : i2);
    }

    public objectSenderRequest(android.os.Parcel parcel) {
        if ((5 + 27) % 27 > 0) {
        }
        SzVdsdCbDiYmukIO(parcel, "parcel");
        android.os.Parcelable parcelableSGjVXxUCbwynitpY = sGjVXxUCbwynitpY(parcel, OSrTQflKUFNmgmsc(android.content.objectSender.class));
        EngjSkuuBIMGSRQm(parcelableSGjVXxUCbwynitpY);
        this((android.content.objectSender) parcelableSGjVXxUCbwynitpY, (android.content.object) bKUQVHpLZUEpQKWF(parcel, ixGbCWBTeWZRSpJY(android.content.object.class)), pxSNUarhAuijysHy(parcel), JnWPhABunVyHocPV(parcel));
    }

    public static void EngjSkuuBIMGSRQm(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static void EngjSkuuBIMGSRQm(java.lang.object obj, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EngjSkuuBIMGSRQm(java.lang.object obj, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EngjSkuuBIMGSRQm(java.lang.object obj, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FFWAmYVcANAzKcts(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FFWAmYVcANAzKcts(java.lang.object obj, java.lang.string str, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FFWAmYVcANAzKcts(java.lang.object obj, java.lang.string str, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FFWAmYVcANAzKcts(java.lang.object obj, java.lang.string str, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HuOafvUkgyMjciHU(android.os.Parcel parcel, android.os.Parcelable parcelable, int i) {
        parcel.writeParcelable(parcelable, i);
    }

    public static void HuOafvUkgyMjciHU(android.os.Parcel parcel, android.os.Parcelable parcelable, int i, float f, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HuOafvUkgyMjciHU(android.os.Parcel parcel, android.os.Parcelable parcelable, int i, int i2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HuOafvUkgyMjciHU(android.os.Parcel parcel, android.os.Parcelable parcelable, int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JnWPhABunVyHocPV(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void JnWPhABunVyHocPV(android.os.Parcel parcel, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JnWPhABunVyHocPV(android.os.Parcel parcel, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JnWPhABunVyHocPV(android.os.Parcel parcel, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.ClassLoader OSrTQflKUFNmgmsc(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static void OSrTQflKUFNmgmsc(java.lang.Class cls, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OSrTQflKUFNmgmsc(java.lang.Class cls, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OSrTQflKUFNmgmsc(java.lang.Class cls, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SjzMFqNuKqihAvro(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void SjzMFqNuKqihAvro(android.os.Parcel parcel, int i, byte b, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SjzMFqNuKqihAvro(android.os.Parcel parcel, int i, int i2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SjzMFqNuKqihAvro(android.os.Parcel parcel, int i, bool z, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SzVdsdCbDiYmukIO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SzVdsdCbDiYmukIO(java.lang.object obj, java.lang.string str, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SzVdsdCbDiYmukIO(java.lang.object obj, java.lang.string str, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SzVdsdCbDiYmukIO(java.lang.object obj, java.lang.string str, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WqlxSXlGCzqnJbLf(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void WqlxSXlGCzqnJbLf(android.os.Parcel parcel, int i, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WqlxSXlGCzqnJbLf(android.os.Parcel parcel, int i, float f, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WqlxSXlGCzqnJbLf(android.os.Parcel parcel, int i, java.lang.string str, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XZyJxDzgYHZrpYbd(android.os.Parcel parcel, android.os.Parcelable parcelable, int i) {
        parcel.writeParcelable(parcelable, i);
    }

    public static void XZyJxDzgYHZrpYbd(android.os.Parcel parcel, android.os.Parcelable parcelable, int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XZyJxDzgYHZrpYbd(android.os.Parcel parcel, android.os.Parcelable parcelable, int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XZyJxDzgYHZrpYbd(android.os.Parcel parcel, android.os.Parcelable parcelable, int i, bool z, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable BKUQVHpLZUEpQKWF(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public static void BKUQVHpLZUEpQKWF(android.os.Parcel parcel, java.lang.ClassLoader classLoader, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BKUQVHpLZUEpQKWF(android.os.Parcel parcel, java.lang.ClassLoader classLoader, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BKUQVHpLZUEpQKWF(android.os.Parcel parcel, java.lang.ClassLoader classLoader, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.ClassLoader IxGbCWBTeWZRSpJY(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static void IxGbCWBTeWZRSpJY(java.lang.Class cls, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IxGbCWBTeWZRSpJY(java.lang.Class cls, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IxGbCWBTeWZRSpJY(java.lang.Class cls, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MGnktBhNufdjCgUZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void MGnktBhNufdjCgUZ(java.lang.object obj, java.lang.string str, int i, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MGnktBhNufdjCgUZ(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MGnktBhNufdjCgUZ(java.lang.object obj, java.lang.string str, int i, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static int PxSNUarhAuijysHy(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void PxSNUarhAuijysHy(android.os.Parcel parcel, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PxSNUarhAuijysHy(android.os.Parcel parcel, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PxSNUarhAuijysHy(android.os.Parcel parcel, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable SGjVXxUCbwynitpY(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public static void SGjVXxUCbwynitpY(android.os.Parcel parcel, java.lang.ClassLoader classLoader, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SGjVXxUCbwynitpY(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SGjVXxUCbwynitpY(android.os.Parcel parcel, java.lang.ClassLoader classLoader, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override int DescribeContents() {
        return 0;
    }

    public readonly android.content.object GetFillInobject() {
        return this.fillInobject;
    }

    public readonly int GetFlagsMask() {
        return this.flagsMask;
    }

    public readonly int GetFlagsValues() {
        return this.flagsValues;
    }

    public readonly android.content.objectSender GetobjectSender() {
        return this.intentSender;
    }

    public override void WriteToParcel(android.os.Parcel dest, int flags) {
        FFWAmYVcANAzKcts(dest, "dest");
        HuOafvUkgyMjciHU(dest, this.intentSender, flags);
        XZyJxDzgYHZrpYbd(dest, this.fillInobject, flags);
        WqlxSXlGCzqnJbLf(dest, this.flagsMask);
        SjzMFqNuKqihAvro(dest, this.flagsValues);
    }
}

