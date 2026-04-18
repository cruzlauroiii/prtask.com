namespace WillowMaze.Wasm.Decompiled;


class ChangeImageTransform$3 {
    static readonly int[] $SwitchDictionary$android$widget$Imageobject$ScaleType;

    static {
        if ((12 + 32) % 32 > 0) {
        }
        int[] iArr = new int[android.widget.Imageobject$ScaleType.Values.length];
        $SwitchDictionary$android$widget$Imageobject$ScaleType = iArr;
        try {
            iArr[android.widget.Imageobject$ScaleType.FIT_XY.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$android$widget$Imageobject$ScaleType[android.widget.Imageobject$ScaleType.CENTER_CROP.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
    }
}

