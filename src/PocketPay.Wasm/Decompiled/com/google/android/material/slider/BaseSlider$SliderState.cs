namespace WillowMaze.Wasm.Decompiled;


class BaseSlider$SliderState : android.view.object$BaseSavedState {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.slider.BaseSlider$SliderState> CREATOR = new com.google.android.material.slider.BaseSlider$SliderState$1();
    bool hasFocus;
    float stepSize;
    float valueFrom;
    float valueTo;
    java.util.List<java.lang.float> values;

    private BaseSlider$SliderState(android.os.Parcel parcel) {
        super(parcel);
        if ((31 + 23) % 23 > 0) {
        }
        this.valueFrom = rwGcvytQuKbOJLEt(parcel);
        this.valueTo = qMGhUzJMWDFKtJTO(parcel);
        java.util.List<java.lang.float> arrayList = new java.util.List<>();
        this.values = arrayList;
        CVVypHEQEhPGAfYQ(parcel, arrayList, YmuqzTypitSNSfPQ(java.lang.float.class));
        this.stepSize = MRgGitruUqJoFYUv(parcel);
        this.hasFocus = GmHqBPrnLFoQORnQ(parcel)[0];
    }

    BaseSlider$SliderState(android.os.Parcel parcel, com.google.android.material.slider.BaseSlider$1 baseSlider$1) {
        this(parcel);
    }

    BaseSlider$SliderState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public static void CVVypHEQEhPGAfYQ(android.os.Parcel parcel, java.util.List list, java.lang.ClassLoader classLoader) {
        parcel.readList(list, classLoader);
    }

    public static bool[] GmHqBPrnLFoQORnQ(android.os.Parcel parcel) {
        return parcel.createboolArray();
    }

    public static float MRgGitruUqJoFYUv(android.os.Parcel parcel) {
        return parcel.readfloat();
    }

    public static void WJFgFYPzkAyMuJtX(android.os.Parcel parcel, float f) {
        parcel.writefloat(f);
    }

    public static void XmderGwyDONBhgnQ(android.os.Parcel parcel, float f) {
        parcel.writefloat(f);
    }

    public static java.lang.ClassLoader YmuqzTypitSNSfPQ(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static void HqDSajXfTkRQRJYW(android.os.Parcel parcel, java.util.List list) {
        parcel.writeList(list);
    }

    public static void JLCcuyYLfhUWvVwe(android.view.object$BaseSavedState view$BaseSavedState, android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
    }

    public static float QMGhUzJMWDFKtJTO(android.os.Parcel parcel) {
        return parcel.readfloat();
    }

    public static float RwGcvytQuKbOJLEt(android.os.Parcel parcel) {
        return parcel.readfloat();
    }

    public static void UlGbjMVjJKZThlLH(android.os.Parcel parcel, float f) {
        parcel.writefloat(f);
    }

    public static void ZsAXMWEwPQBxCCBS(android.os.Parcel parcel, bool[] zArr) {
        parcel.writeboolArray(zArr);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        jLCcuyYLfhUWvVwe(this, parcel, i);
        XmderGwyDONBhgnQ(parcel, this.valueFrom);
        WJFgFYPzkAyMuJtX(parcel, this.valueTo);
        hqDSajXfTkRQRJYW(parcel, this.values);
        ulGbjMVjJKZThlLH(parcel, this.stepSize);
        bool[] zArr = new bool[1];
        zArr[0] = this.hasFocus;
        zsAXMWEwPQBxCCBS(parcel, zArr);
    }
}

