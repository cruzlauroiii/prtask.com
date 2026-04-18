namespace WillowMaze.Wasm.Decompiled;


class ExtendableSavedState$1 : android.os.Parcelable$ClassLoaderCreator<com.google.android.material.stateful.ExtendableSavedState> {
    ExtendableSavedState$1() {
    }

    public static com.google.android.material.stateful.ExtendableSavedState FJgeUkvxJCottCXQ(com.google.android.material.stateful.ExtendableSavedState$1 extendableSavedState$1, android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return extendableSavedState$1.createFromParcel(parcel, classLoader);
    }

    public static com.google.android.material.stateful.ExtendableSavedState[] GlgAKHrTTLrHSucW(com.google.android.material.stateful.ExtendableSavedState$1 extendableSavedState$1, int i) {
        return extendableSavedState$1.newArray(i);
    }

    public static com.google.android.material.stateful.ExtendableSavedState HZFFMjyiyHdVzdty(com.google.android.material.stateful.ExtendableSavedState$1 extendableSavedState$1, android.os.Parcel parcel) {
        return extendableSavedState$1.createFromParcel(parcel);
    }

    public override com.google.android.material.stateful.ExtendableSavedState CreateFromParcel(android.os.Parcel parcel) {
        return new com.google.android.material.stateful.ExtendableSavedState(parcel, null, null);
    }

    public override com.google.android.material.stateful.ExtendableSavedState CreateFromParcel(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return new com.google.android.material.stateful.ExtendableSavedState(parcel, classLoader, null);
    }

    public override java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        return hZFFMjyiyHdVzdty(this, parcel);
    }

    public override com.google.android.material.stateful.ExtendableSavedState CreateFromParcel(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return FJgeUkvxJCottCXQ(this, parcel, classLoader);
    }

    public override com.google.android.material.stateful.ExtendableSavedState[] NewArray(int i) {
        return new com.google.android.material.stateful.ExtendableSavedState[i];
    }

    public override java.lang.object[] NewArray(int i) {
        return GlgAKHrTTLrHSucW(this, i);
    }
}

