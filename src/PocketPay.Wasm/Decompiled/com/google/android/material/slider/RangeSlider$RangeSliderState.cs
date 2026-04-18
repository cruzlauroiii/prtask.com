namespace WillowMaze.Wasm.Decompiled;


class RangeSlider$RangeSliderState : android.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.slider.RangeSlider$RangeSliderState> CREATOR = new com.google.android.material.slider.RangeSlider$RangeSliderState$1();
    private float minSeparation;
    private int separationUnit;

    private RangeSlider$RangeSliderState(android.os.Parcel parcel) {
        super(RlxUVzjQUNqbHSRt(parcel, UCvdkHeCbyhaZowN(com.google.android.material.slider.RangeSlider$RangeSliderState.class)));
        this.minSeparation = DKUGkXWaDYGsRusn(parcel);
        this.separationUnit = FCRgiCiLTyhtnIbn(parcel);
    }

    RangeSlider$RangeSliderState(android.os.Parcel parcel, com.google.android.material.slider.RangeSlider$1 rangeSlider$1) {
        this(parcel);
    }

    RangeSlider$RangeSliderState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public static void AaeLrwtJklHJJpou(android.os.Parcel parcel, float f) {
        parcel.writefloat(f);
    }

    public static float DKUGkXWaDYGsRusn(android.os.Parcel parcel) {
        return parcel.readfloat();
    }

    public static int FCRgiCiLTyhtnIbn(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void JZNHXROVNsnDhrDn(android.view.AbsSavedState absSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static void OhQinCiuOplLmuek(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static android.os.Parcelable RlxUVzjQUNqbHSRt(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public static java.lang.ClassLoader UCvdkHeCbyhaZowN(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    static float access$000(com.google.android.material.slider.RangeSlider$RangeSliderState rangeSlider$RangeSliderState) {
        return rangeSlider$RangeSliderState.minSeparation;
    }

    static float access$002(com.google.android.material.slider.RangeSlider$RangeSliderState rangeSlider$RangeSliderState, float f) {
        rangeSlider$RangeSliderState.minSeparation = f;
        return f;
    }

    static int access$100(com.google.android.material.slider.RangeSlider$RangeSliderState rangeSlider$RangeSliderState) {
        return rangeSlider$RangeSliderState.separationUnit;
    }

    static int access$102(com.google.android.material.slider.RangeSlider$RangeSliderState rangeSlider$RangeSliderState, int i) {
        rangeSlider$RangeSliderState.separationUnit = i;
        return i;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        JZNHXROVNsnDhrDn(this, parcel, i);
        AaeLrwtJklHJJpou(parcel, this.minSeparation);
        OhQinCiuOplLmuek(parcel, this.separationUnit);
    }
}

