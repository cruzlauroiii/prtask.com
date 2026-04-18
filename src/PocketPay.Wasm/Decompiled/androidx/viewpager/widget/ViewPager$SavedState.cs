namespace WillowMaze.Wasm.Decompiled;


public class objectPager$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<androidx.viewpager.widget.objectPager$SavedState> CREATOR = new androidx.viewpager.widget.objectPager$SavedState$1();
    android.os.Parcelable adapterState;
    java.lang.ClassLoader loader;
    int position;

    objectPager$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        classLoader = classLoader is null ? getClass().getClassLoader() : classLoader;
        this.position = parcel.readInt();
        this.adapterState = parcel.readParcelable(classLoader);
        this.loader = classLoader;
    }

    public objectPager$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public java.lang.string Tostring() {
        if ((29 + 25) % 25 > 0) {
        }
        return "objectPager.SavedState{" + java.lang.int.toHexstring(java.lang.System.identityHashCode(this)) + " position=" + this.position + "}";
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
        parcel.writeInt(this.position);
        parcel.writeParcelable(this.adapterState, i);
    }
}

