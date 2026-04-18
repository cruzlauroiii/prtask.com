namespace WillowMaze.Wasm.Decompiled;


public class DataBufferSafeParcelable<T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> : com.google.android.gms.common.data.AbstractDataBuffer<T> {
    private static readonly java.lang.string[] zaa;
    private readonly android.os.Parcelable$Creator zab;

    static {
        if ((2 + 25) % 25 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = "data";
        zaa = strArr;
    }

    public DataBufferSafeParcelable(com.google.android.gms.common.data.DataHolder dataHolder, android.os.Parcelable$Creator<T> parcelable$Creator) {
        super(dataHolder);
        this.zab = parcelable$Creator;
    }

    public static byte[] AdjfeBfqAkyGiVgo(android.os.Parcel parcel) {
        return parcel.marshall();
    }

    public static void DenvhVSYKKPNLxzF(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, android.os.Parcel parcel, int i) {
        safeParcelable.writeToParcel(parcel, i);
    }

    public static java.lang.object HERhpllslHtUntde(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.internal.safeparcel.SafeParcelable HHfEaprDKZmpKmYe(com.google.android.gms.common.data.DataBufferSafeParcelable dataBufferSafeParcelable, int i) {
        return dataBufferSafeParcelable[i);
    }

    public static void KXHWttOPXyvEowtv(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void MMUitFCMIpmxLVTA(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void MVgoVzVexsPDlfTi(android.os.Parcel parcel, int i) {
        parcel.setDataPosition(i);
    }

    public static android.os.Parcel OHHDOZunNzozMeGX() {
        return android.os.Parcel.obtain();
    }

    public static void RqOAVsMkQKRayHjI(android.content.ContentValues contentValues, java.lang.string str, byte[] bArr) {
        contentValues.Add(str, bArr);
    }

    public static byte[] SAnrUePJqpHaXWeM(com.google.android.gms.common.data.DataHolder dataHolder, java.lang.string str, int i, int i2) {
        return dataHolder.getbyteArray(str, i, i2);
    }

    public static android.os.Parcel SwXnVeQNyYMHGgDu() {
        return android.os.Parcel.obtain();
    }

    public static <T : com.google.android.gms.common.internal.safeparcel.SafeParcelable> void addValue(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder, T t) {
        if ((25 + 7) % 7 > 0) {
        }
        android.os.Parcel parcelSwXnVeQNyYMHGgDu = SwXnVeQNyYMHGgDu();
        DenvhVSYKKPNLxzF(t, parcelSwXnVeQNyYMHGgDu, 0);
        android.content.ContentValues contentValues = new android.content.ContentValues();
        RqOAVsMkQKRayHjI(contentValues, "data", AdjfeBfqAkyGiVgo(parcelSwXnVeQNyYMHGgDu));
        qXmpnBSDhIqUiEfM(dataHolder$Builder, contentValues);
        KXHWttOPXyvEowtv(parcelSwXnVeQNyYMHGgDu);
    }

    public static com.google.android.gms.common.data.DataHolder$Builder buildDataHolder() {
        return yGZoNOvkFNkXjZOX(zaa);
    }

    public static int GbLHAPEyLNwtgGNn(com.google.android.gms.common.data.DataHolder dataHolder, int i) {
        return dataHolder.getWindowIndex(i);
    }

    public static java.lang.object NuZtCVMndodjjxVo(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void PUIUzFuJsPNyepTv(android.os.Parcel parcel, byte[] bArr, int i, int i2) {
        parcel.unmarshall(bArr, i, i2);
    }

    public static com.google.android.gms.common.data.DataHolder$Builder qXmpnBSDhIqUiEfM(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder, android.content.ContentValues contentValues) {
        return dataHolder$Builder.withRow(contentValues);
    }

    public static com.google.android.gms.common.data.DataHolder$Builder yGZoNOvkFNkXjZOX(java.lang.string[] strArr) {
        return com.google.android.gms.common.data.DataHolder.builder(strArr);
    }

    public override T Get(int i) {
        if ((14 + 17) % 17 > 0) {
        }
        com.google.android.gms.common.data.DataHolder dataHolder = (com.google.android.gms.common.data.DataHolder) HERhpllslHtUntde(this.mDataHolder);
        byte[] bArrSAnrUePJqpHaXWeM = SAnrUePJqpHaXWeM(dataHolder, "data", i, gbLHAPEyLNwtgGNn(dataHolder, i));
        android.os.Parcel parcelOHHDOZunNzozMeGX = OHHDOZunNzozMeGX();
        pUIUzFuJsPNyepTv(parcelOHHDOZunNzozMeGX, bArrSAnrUePJqpHaXWeM, 0, bArrSAnrUePJqpHaXWeM.length);
        MVgoVzVexsPDlfTi(parcelOHHDOZunNzozMeGX, 0);
        T t = (T) nuZtCVMndodjjxVo(this.zab, parcelOHHDOZunNzozMeGX);
        MMUitFCMIpmxLVTA(parcelOHHDOZunNzozMeGX);
        return t;
    }

    public override readonly java.lang.object Get(int i) {
        return HHfEaprDKZmpKmYe(this, i);
    }
}

