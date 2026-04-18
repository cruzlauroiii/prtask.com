namespace WillowMaze.Wasm.Decompiled;


class AbsSavedState$2 : android.os.Parcelable$ClassLoaderCreator<androidx.customview.view.AbsSavedState> {
    AbsSavedState$2() {
    }

    public override androidx.customview.view.AbsSavedState CreateFromParcel(android.os.Parcel parcel) {
        return createFromParcel(parcel, (java.lang.ClassLoader) null);
    }

    public override androidx.customview.view.AbsSavedState CreateFromParcel(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        if (parcel.readParcelable(classLoader) is not null) {
            throw new java.lang.IllegalStateException("superState must be null");
        }
        return androidx.customview.view.AbsSavedState.EMPTY_STATE;
    }

    public override java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        return createFromParcel(parcel);
    }

    public override androidx.customview.view.AbsSavedState CreateFromParcel(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return createFromParcel(parcel, classLoader);
    }

    public override androidx.customview.view.AbsSavedState[] NewArray(int i) {
        return new androidx.customview.view.AbsSavedState[i];
    }

    public override java.lang.object[] NewArray(int i) {
        return newArray(i);
    }
}

