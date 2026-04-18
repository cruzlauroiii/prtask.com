namespace WillowMaze.Wasm.Decompiled;


class Searchobject$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.search.Searchobject$SavedState> CREATOR = new com.google.android.material.search.Searchobject$SavedState$1();
    java.lang.string text;
    int visibility;

    public Searchobject$SavedState(android.os.Parcel parcel) {
        this(parcel, null);
    }

    public Searchobject$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        this.text = kIOEXNkNaYHKBLZl(parcel);
        this.visibility = uWMPaJsblOBPCJvP(parcel);
    }

    public Searchobject$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public static void FzdQqFOjangWYPeT(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static void FzdQqFOjangWYPeT(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, int i2, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FzdQqFOjangWYPeT(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FzdQqFOjangWYPeT(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, java.lang.string str, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KIOEXNkNaYHKBLZl(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void KIOEXNkNaYHKBLZl(android.os.Parcel parcel, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KIOEXNkNaYHKBLZl(android.os.Parcel parcel, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KIOEXNkNaYHKBLZl(android.os.Parcel parcel, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int UWMPaJsblOBPCJvP(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void UWMPaJsblOBPCJvP(android.os.Parcel parcel, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UWMPaJsblOBPCJvP(android.os.Parcel parcel, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UWMPaJsblOBPCJvP(android.os.Parcel parcel, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UyIFQoCagCiqZZXr(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void UyIFQoCagCiqZZXr(android.os.Parcel parcel, int i, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UyIFQoCagCiqZZXr(android.os.Parcel parcel, int i, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UyIFQoCagCiqZZXr(android.os.Parcel parcel, int i, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XQicVQWkEqsompSI(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static void XQicVQWkEqsompSI(android.os.Parcel parcel, java.lang.string str, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XQicVQWkEqsompSI(android.os.Parcel parcel, java.lang.string str, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XQicVQWkEqsompSI(android.os.Parcel parcel, java.lang.string str, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        fzdQqFOjangWYPeT(this, parcel, i);
        xQicVQWkEqsompSI(parcel, this.text);
        uyIFQoCagCiqZZXr(parcel, this.visibility);
    }
}

