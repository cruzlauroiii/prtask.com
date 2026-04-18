namespace WillowMaze.Wasm.Decompiled;


protected class SideSheetBehavior$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.sidesheet.SideSheetBehavior$SavedState> CREATOR = new com.google.android.material.sidesheet.SideSheetBehavior$SavedState$1();
    readonly int state;

    public SideSheetBehavior$SavedState(android.os.Parcel parcel) {
        this(parcel, (java.lang.ClassLoader) null);
    }

    public SideSheetBehavior$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        this.state = mtcoFAltKrdXNmYs(parcel);
    }

    public SideSheetBehavior$SavedState(android.os.Parcelable parcelable, com.google.android.material.sidesheet.SideSheetBehavior<object> sideSheetBehavior) {
        super(parcelable);
        this.state = llkWLHSOTCbfQUtU(sideSheetBehavior);
    }

    public static void QNyXmEaIrnvXfntm(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static int LlkWLHSOTCbfQUtU(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return com.google.android.material.sidesheet.SideSheetBehavior.access$000(sideSheetBehavior);
    }

    public static int MtcoFAltKrdXNmYs(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void VeLZFIxLsguXcbxc(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        veLZFIxLsguXcbxc(this, parcel, i);
        QNyXmEaIrnvXfntm(parcel, this.state);
    }
}

