namespace WillowMaze.Wasm.Decompiled;


class SideSheetBehavior$SavedState$1 : android.os.Parcelable$ClassLoaderCreator<com.google.android.material.sidesheet.SideSheetBehavior$SavedState> {
    SideSheetBehavior$SavedState$1() {
    }

    public static com.google.android.material.sidesheet.SideSheetBehavior$SavedState[] MHrsnJhZiJhKUgxh(com.google.android.material.sidesheet.SideSheetBehavior$SavedState$1 sideSheetBehavior$SavedState$1, int i) {
        return sideSheetBehavior$SavedState$1.newArray(i);
    }

    public static com.google.android.material.sidesheet.SideSheetBehavior$SavedState XzZSfabFYxgCOVyA(com.google.android.material.sidesheet.SideSheetBehavior$SavedState$1 sideSheetBehavior$SavedState$1, android.os.Parcel parcel) {
        return sideSheetBehavior$SavedState$1.createFromParcel(parcel);
    }

    public static com.google.android.material.sidesheet.SideSheetBehavior$SavedState aHTuLeEpshVTwxSh(com.google.android.material.sidesheet.SideSheetBehavior$SavedState$1 sideSheetBehavior$SavedState$1, android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return sideSheetBehavior$SavedState$1.createFromParcel(parcel, classLoader);
    }

    public com.google.android.material.sidesheet.SideSheetBehavior$SavedState createFromParcel(android.os.Parcel parcel) {
        return new com.google.android.material.sidesheet.SideSheetBehavior$SavedState(parcel, (java.lang.ClassLoader) null);
    }

    public com.google.android.material.sidesheet.SideSheetBehavior$SavedState createFromParcel(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return new com.google.android.material.sidesheet.SideSheetBehavior$SavedState(parcel, classLoader);
    }

    public override java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        return XzZSfabFYxgCOVyA(this, parcel);
    }

    public com.google.android.material.sidesheet.SideSheetBehavior$SavedState createFromParcel(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return aHTuLeEpshVTwxSh(this, parcel, classLoader);
    }

    public com.google.android.material.sidesheet.SideSheetBehavior$SavedState[] newArray(int i) {
        return new com.google.android.material.sidesheet.SideSheetBehavior$SavedState[i];
    }

    public override java.lang.object[] NewArray(int i) {
        return MHrsnJhZiJhKUgxh(this, i);
    }
}

