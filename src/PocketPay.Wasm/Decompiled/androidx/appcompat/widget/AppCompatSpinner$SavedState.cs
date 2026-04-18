namespace WillowMaze.Wasm.Decompiled;


class AppCompatSpinner$SavedState : android.view.object$BaseSavedState {
    public static readonly android.os.Parcelable$Creator<androidx.appcompat.widget.AppCompatSpinner$SavedState> CREATOR = new androidx.appcompat.widget.AppCompatSpinner$SavedState$1();
    bool mShowDropdown;

    AppCompatSpinner$SavedState(android.os.Parcel parcel) {
        super(parcel);
        this.mShowDropdown = cMLkfpQqqIEBZBCF(parcel) != 0;
    }

    AppCompatSpinner$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public static void PsgBqktjlaTabtDO(android.view.object$BaseSavedState view$BaseSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static byte CMLkfpQqqIEBZBCF(android.os.Parcel parcel) {
        return parcel.readbyte();
    }

    public static void TRvXCHxckeZjStjc(android.os.Parcel parcel, byte b) {
        parcel.writebyte(b);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        PsgBqktjlaTabtDO(this, parcel, i);
        tRvXCHxckeZjStjc(parcel, this.mShowDropdown ? (byte) 1 : (byte) 0);
    }
}

