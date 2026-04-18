namespace WillowMaze.Wasm.Decompiled;


class BottomAppBar$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.bottomappbar.BottomAppBar$SavedState> CREATOR = new com.google.android.material.bottomappbar.BottomAppBar$SavedState$1();
    int fabAlignmentMode;
    bool fabAttached;

    public BottomAppBar$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        this.fabAlignmentMode = tZlIEeHZIVJBgvGp(parcel);
        this.fabAttached = EzSQADBCyZSQgzDh(parcel) != 0;
    }

    public BottomAppBar$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public static int EzSQADBCyZSQgzDh(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void EzSQADBCyZSQgzDh(android.os.Parcel parcel, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EzSQADBCyZSQgzDh(android.os.Parcel parcel, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EzSQADBCyZSQgzDh(android.os.Parcel parcel, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JtLImMMOTYCGaghh(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void JtLImMMOTYCGaghh(android.os.Parcel parcel, int i, int i2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JtLImMMOTYCGaghh(android.os.Parcel parcel, int i, short s, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JtLImMMOTYCGaghh(android.os.Parcel parcel, int i, short s, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ROlPvwfsWucsMCTP(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static void ROlPvwfsWucsMCTP(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ROlPvwfsWucsMCTP(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ROlPvwfsWucsMCTP(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IEwVvdPeTljevsnx(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void IEwVvdPeTljevsnx(android.os.Parcel parcel, int i, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IEwVvdPeTljevsnx(android.os.Parcel parcel, int i, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IEwVvdPeTljevsnx(android.os.Parcel parcel, int i, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int TZlIEeHZIVJBgvGp(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void TZlIEeHZIVJBgvGp(android.os.Parcel parcel, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TZlIEeHZIVJBgvGp(android.os.Parcel parcel, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TZlIEeHZIVJBgvGp(android.os.Parcel parcel, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        ROlPvwfsWucsMCTP(this, parcel, i);
        JtLImMMOTYCGaghh(parcel, this.fabAlignmentMode);
        iEwVvdPeTljevsnx(parcel, this.fabAttached ? 1 : 0);
    }
}

