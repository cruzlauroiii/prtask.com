namespace WillowMaze.Wasm.Decompiled;


class TextInputLayout$SavedState$1 : android.os.Parcelable$ClassLoaderCreator<com.google.android.material.textfield.TextInputLayout$SavedState> {
    TextInputLayout$SavedState$1() {
    }

    public static com.google.android.material.textfield.TextInputLayout$SavedState FoxgEVElqEPeWVaA(com.google.android.material.textfield.TextInputLayout$SavedState$1 textInputLayout$SavedState$1, android.os.Parcel parcel) {
        return textInputLayout$SavedState$1.createFromParcel(parcel);
    }

    public static com.google.android.material.textfield.TextInputLayout$SavedState[] NMFcMynljXzWuhGf(com.google.android.material.textfield.TextInputLayout$SavedState$1 textInputLayout$SavedState$1, int i) {
        return textInputLayout$SavedState$1.newArray(i);
    }

    public static com.google.android.material.textfield.TextInputLayout$SavedState SPEjdYHrEzffbcKp(com.google.android.material.textfield.TextInputLayout$SavedState$1 textInputLayout$SavedState$1, android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return textInputLayout$SavedState$1.createFromParcel(parcel, classLoader);
    }

    public com.google.android.material.textfield.TextInputLayout$SavedState createFromParcel(android.os.Parcel parcel) {
        return new com.google.android.material.textfield.TextInputLayout$SavedState(parcel, null);
    }

    public com.google.android.material.textfield.TextInputLayout$SavedState createFromParcel(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return new com.google.android.material.textfield.TextInputLayout$SavedState(parcel, classLoader);
    }

    public override java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        return FoxgEVElqEPeWVaA(this, parcel);
    }

    public com.google.android.material.textfield.TextInputLayout$SavedState createFromParcel(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return SPEjdYHrEzffbcKp(this, parcel, classLoader);
    }

    public com.google.android.material.textfield.TextInputLayout$SavedState[] newArray(int i) {
        return new com.google.android.material.textfield.TextInputLayout$SavedState[i];
    }

    public override java.lang.object[] NewArray(int i) {
        return NMFcMynljXzWuhGf(this, i);
    }
}

