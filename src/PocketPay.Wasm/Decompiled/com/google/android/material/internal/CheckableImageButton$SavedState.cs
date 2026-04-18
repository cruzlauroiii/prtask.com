namespace WillowMaze.Wasm.Decompiled;


class CheckableImageButton$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.internal.CheckableImageButton$SavedState> CREATOR = new com.google.android.material.internal.CheckableImageButton$SavedState$1();
    bool checked;

    public CheckableImageButton$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        UWmsvSRgMWmePmkj(this, parcel);
    }

    public CheckableImageButton$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public static void FhLibntMiWMJtzkj(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void FhLibntMiWMJtzkj(android.os.Parcel parcel, int i, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FhLibntMiWMJtzkj(android.os.Parcel parcel, int i, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FhLibntMiWMJtzkj(android.os.Parcel parcel, int i, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ORDsvGZhUFQzEbXm(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static void ORDsvGZhUFQzEbXm(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ORDsvGZhUFQzEbXm(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ORDsvGZhUFQzEbXm(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UWmsvSRgMWmePmkj(com.google.android.material.internal.CheckableImageButton$SavedState checkableImageButton$SavedState, android.os.Parcel parcel) {
        checkableImageButton$SavedState.readFromParcel(parcel);
    }

    public static void UWmsvSRgMWmePmkj(com.google.android.material.internal.CheckableImageButton$SavedState checkableImageButton$SavedState, android.os.Parcel parcel, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UWmsvSRgMWmePmkj(com.google.android.material.internal.CheckableImageButton$SavedState checkableImageButton$SavedState, android.os.Parcel parcel, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UWmsvSRgMWmePmkj(com.google.android.material.internal.CheckableImageButton$SavedState checkableImageButton$SavedState, android.os.Parcel parcel, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NoYlxHSYJNitADxq(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void NoYlxHSYJNitADxq(android.os.Parcel parcel, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NoYlxHSYJNitADxq(android.os.Parcel parcel, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NoYlxHSYJNitADxq(android.os.Parcel parcel, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ReadFromParcel(android.os.Parcel parcel) {
        this.checked = noYlxHSYJNitADxq(parcel) == 1;
    }

    private void ReadFromParcel(android.os.Parcel parcel, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ReadFromParcel(android.os.Parcel parcel, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ReadFromParcel(android.os.Parcel parcel, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        ORDsvGZhUFQzEbXm(this, parcel, i);
        FhLibntMiWMJtzkj(parcel, this.checked ? 1 : 0);
    }
}

