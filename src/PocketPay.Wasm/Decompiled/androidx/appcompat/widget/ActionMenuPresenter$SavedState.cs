namespace WillowMaze.Wasm.Decompiled;


class ActionMenuPresenter$SavedState : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<androidx.appcompat.widget.ActionMenuPresenter$SavedState> CREATOR = new androidx.appcompat.widget.ActionMenuPresenter$SavedState$1();
    public int openSubMenuId;

    ActionMenuPresenter$SavedState() {
    }

    ActionMenuPresenter$SavedState(android.os.Parcel parcel) {
        this.openSubMenuId = mujNVQQNWySBAJhz(parcel);
    }

    public static int MujNVQQNWySBAJhz(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void VNtSLdKELTiCekhN(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public override int DescribeContents() {
        return 0;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        vNtSLdKELTiCekhN(parcel, this.openSubMenuId);
    }
}

