namespace WillowMaze.Wasm.Decompiled;


public class Toolbar$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<androidx.appcompat.widget.Toolbar$SavedState> CREATOR = new androidx.appcompat.widget.Toolbar$SavedState$1();
    int expandedMenuItemId;
    bool isOverflowOpen;

    public Toolbar$SavedState(android.os.Parcel parcel) {
        this(parcel, null);
    }

    public Toolbar$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        this.expandedMenuItemId = VOjGgOaYabaKNbKa(parcel);
        this.isOverflowOpen = yXCAREExTMHvQLah(parcel) != 0;
    }

    public Toolbar$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public static void BGHflPIuSliZUJAD(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void TachKewXtYBAwNOk(androidx.customview.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static int VOjGgOaYabaKNbKa(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void WRbuWlRIQLcwJhjW(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static int YXCAREExTMHvQLah(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        TachKewXtYBAwNOk(this, parcel, i);
        wRbuWlRIQLcwJhjW(parcel, this.expandedMenuItemId);
        BGHflPIuSliZUJAD(parcel, this.isOverflowOpen ? 1 : 0);
    }
}

