namespace WillowMaze.Wasm.Decompiled;


public class Navigationobject$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.navigation.Navigationobject$SavedState> CREATOR = new com.google.android.material.navigation.Navigationobject$SavedState$1();
    public android.os.Dictionary<string, object> menuState;

    public Navigationobject$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        this.menuState = tjDANbbjXGqRlQWv(parcel, classLoader);
    }

    public Navigationobject$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public static void EyvGUAysMgkCRTdl(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle) {
        parcel.writeDictionary<string, object>(bundle);
    }

    public static void EyvGUAysMgkCRTdl(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EyvGUAysMgkCRTdl(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EyvGUAysMgkCRTdl(android.os.Parcel parcel, android.os.Dictionary<string, object> bundle, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> TjDANbbjXGqRlQWv(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readDictionary<string, object>(classLoader);
    }

    public static void TjDANbbjXGqRlQWv(android.os.Parcel parcel, java.lang.ClassLoader classLoader, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TjDANbbjXGqRlQWv(android.os.Parcel parcel, java.lang.ClassLoader classLoader, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TjDANbbjXGqRlQWv(android.os.Parcel parcel, java.lang.ClassLoader classLoader, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VohAXYiJvbhenjGs(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static void VohAXYiJvbhenjGs(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VohAXYiJvbhenjGs(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VohAXYiJvbhenjGs(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        vohAXYiJvbhenjGs(this, parcel, i);
        eyvGUAysMgkCRTdl(parcel, this.menuState);
    }
}

