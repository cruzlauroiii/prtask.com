namespace WillowMaze.Wasm.Decompiled;


protected class DrawerLayout$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<androidx.drawerlayout.widget.DrawerLayout$SavedState> CREATOR = new androidx.drawerlayout.widget.DrawerLayout$SavedState$1();
    int lockModeEnd;
    int lockModeLeft;
    int lockModeRight;
    int lockModeStart;
    int openDrawerGravity;

    public DrawerLayout$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        this.openDrawerGravity = 0;
        this.openDrawerGravity = parcel.readInt();
        this.lockModeLeft = parcel.readInt();
        this.lockModeRight = parcel.readInt();
        this.lockModeStart = parcel.readInt();
        this.lockModeEnd = parcel.readInt();
    }

    public DrawerLayout$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
        this.openDrawerGravity = 0;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
        parcel.writeInt(this.openDrawerGravity);
        parcel.writeInt(this.lockModeLeft);
        parcel.writeInt(this.lockModeRight);
        parcel.writeInt(this.lockModeStart);
        parcel.writeInt(this.lockModeEnd);
    }
}

