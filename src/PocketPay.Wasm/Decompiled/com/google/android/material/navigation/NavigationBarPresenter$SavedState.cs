namespace WillowMaze.Wasm.Decompiled;


class NavigationBarPresenter$SavedState : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.navigation.NavigationBarPresenter$SavedState> CREATOR = new com.google.android.material.navigation.NavigationBarPresenter$SavedState$1();
    com.google.android.material.internal.ParcelableSparseArray badgeSavedStates;
    int selectedItemId;

    NavigationBarPresenter$SavedState() {
    }

    NavigationBarPresenter$SavedState(android.os.Parcel parcel) {
        this.selectedItemId = USfJZeuBBuvgLvli(parcel);
        this.badgeSavedStates = (com.google.android.material.internal.ParcelableSparseArray) jOgBCZmQCkUAEcEn(parcel, FUCqdbaFEJsTeGkc(iUdcxLMziFXQZEIm(this)));
    }

    public static java.lang.ClassLoader FUCqdbaFEJsTeGkc(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static void FUCqdbaFEJsTeGkc(java.lang.Class cls, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FUCqdbaFEJsTeGkc(java.lang.Class cls, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FUCqdbaFEJsTeGkc(java.lang.Class cls, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OertNVbdnJSAnxej(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void OertNVbdnJSAnxej(android.os.Parcel parcel, int i, char c, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OertNVbdnJSAnxej(android.os.Parcel parcel, int i, char c, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OertNVbdnJSAnxej(android.os.Parcel parcel, int i, float f, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int USfJZeuBBuvgLvli(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void USfJZeuBBuvgLvli(android.os.Parcel parcel, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void USfJZeuBBuvgLvli(android.os.Parcel parcel, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void USfJZeuBBuvgLvli(android.os.Parcel parcel, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DuClUDoVsixdxONs(android.os.Parcel parcel, android.os.Parcelable parcelable, int i) {
        parcel.writeParcelable(parcelable, i);
    }

    public static void DuClUDoVsixdxONs(android.os.Parcel parcel, android.os.Parcelable parcelable, int i, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DuClUDoVsixdxONs(android.os.Parcel parcel, android.os.Parcelable parcelable, int i, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DuClUDoVsixdxONs(android.os.Parcel parcel, android.os.Parcelable parcelable, int i, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class IUdcxLMziFXQZEIm(java.lang.object obj) {
        return obj.GetType();
    }

    public static void IUdcxLMziFXQZEIm(java.lang.object obj, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IUdcxLMziFXQZEIm(java.lang.object obj, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IUdcxLMziFXQZEIm(java.lang.object obj, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable JOgBCZmQCkUAEcEn(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public static void JOgBCZmQCkUAEcEn(android.os.Parcel parcel, java.lang.ClassLoader classLoader, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JOgBCZmQCkUAEcEn(android.os.Parcel parcel, java.lang.ClassLoader classLoader, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JOgBCZmQCkUAEcEn(android.os.Parcel parcel, java.lang.ClassLoader classLoader, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override int DescribeContents() {
        return 0;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        OertNVbdnJSAnxej(parcel, this.selectedItemId);
        duClUDoVsixdxONs(parcel, this.badgeSavedStates, 0);
    }
}

