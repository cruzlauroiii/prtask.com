namespace WillowMaze.Wasm.Decompiled;


class SearchBar$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.search.SearchBar$SavedState> CREATOR = new com.google.android.material.search.SearchBar$SavedState$1();
    java.lang.string text;

    public SearchBar$SavedState(android.os.Parcel parcel) {
        this(parcel, null);
    }

    public SearchBar$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        this.text = aOXusYKseVqPdfeC(parcel);
    }

    public SearchBar$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public static java.lang.string AOXusYKseVqPdfeC(android.os.Parcel parcel) {
        return parcel.readstring();
    }

    public static void AOXusYKseVqPdfeC(android.os.Parcel parcel, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AOXusYKseVqPdfeC(android.os.Parcel parcel, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AOXusYKseVqPdfeC(android.os.Parcel parcel, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JEJCvAjNomcIOzPO(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static void JEJCvAjNomcIOzPO(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, byte b, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JEJCvAjNomcIOzPO(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, java.lang.string str, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JEJCvAjNomcIOzPO(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i, bool z, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QHnDcRFVLeSmHXcc(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public static void QHnDcRFVLeSmHXcc(android.os.Parcel parcel, java.lang.string str, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QHnDcRFVLeSmHXcc(android.os.Parcel parcel, java.lang.string str, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QHnDcRFVLeSmHXcc(android.os.Parcel parcel, java.lang.string str, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        jEJCvAjNomcIOzPO(this, parcel, i);
        qHnDcRFVLeSmHXcc(parcel, this.text);
    }
}

