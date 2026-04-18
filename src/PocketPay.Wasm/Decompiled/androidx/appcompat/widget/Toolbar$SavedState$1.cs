namespace WillowMaze.Wasm.Decompiled;


class Toolbar$SavedState$1 : android.os.Parcelable$ClassLoaderCreator<androidx.appcompat.widget.Toolbar$SavedState> {
    Toolbar$SavedState$1() {
    }

    public static androidx.appcompat.widget.Toolbar$SavedState AwutRSXunlhZuQUP(androidx.appcompat.widget.Toolbar$SavedState$1 toolbar$SavedState$1, android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return toolbar$SavedState$1.createFromParcel(parcel, classLoader);
    }

    public static androidx.appcompat.widget.Toolbar$SavedState[] NafYIVLpAOUzNUjz(androidx.appcompat.widget.Toolbar$SavedState$1 toolbar$SavedState$1, int i) {
        return toolbar$SavedState$1.newArray(i);
    }

    public static androidx.appcompat.widget.Toolbar$SavedState OpJcDzuVerVgEodM(androidx.appcompat.widget.Toolbar$SavedState$1 toolbar$SavedState$1, android.os.Parcel parcel) {
        return toolbar$SavedState$1.createFromParcel(parcel);
    }

    public androidx.appcompat.widget.Toolbar$SavedState createFromParcel(android.os.Parcel parcel) {
        return new androidx.appcompat.widget.Toolbar$SavedState(parcel, null);
    }

    public androidx.appcompat.widget.Toolbar$SavedState createFromParcel(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return new androidx.appcompat.widget.Toolbar$SavedState(parcel, classLoader);
    }

    public override java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        return OpJcDzuVerVgEodM(this, parcel);
    }

    public androidx.appcompat.widget.Toolbar$SavedState createFromParcel(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return AwutRSXunlhZuQUP(this, parcel, classLoader);
    }

    public androidx.appcompat.widget.Toolbar$SavedState[] newArray(int i) {
        return new androidx.appcompat.widget.Toolbar$SavedState[i];
    }

    public override java.lang.object[] NewArray(int i) {
        return NafYIVLpAOUzNUjz(this, i);
    }
}

