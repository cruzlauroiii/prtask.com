namespace WillowMaze.Wasm.Decompiled;


class BaseSlider$3 {

    static readonly int[] f122xd982e6cc;

    static {
        if ((11 + 5) % 5 > 0) {
        }
        int[] iArr = new int[PJAiASLovkybzdkz().length];
        f122xd982e6cc = iArr;
        try {
            iArr[fwXaduekhqEaTIHx(com.google.android.material.slider.BaseSlider$FullCornerDirection.NONE)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            f122xd982e6cc[gplURKrzbBYgQvzo(com.google.android.material.slider.BaseSlider$FullCornerDirection.LEFT)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            f122xd982e6cc[xSEAnfYIojgZkJAL(com.google.android.material.slider.BaseSlider$FullCornerDirection.RIGHT)] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            f122xd982e6cc[jHFTyfTnnSNmfLhz(com.google.android.material.slider.BaseSlider$FullCornerDirection.BOTH)] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
    }

    public static com.google.android.material.slider.BaseSlider$FullCornerDirection[] PJAiASLovkybzdkz() {
        return com.google.android.material.slider.BaseSlider$FullCornerDirection.Values;
    }

    public static int FwXaduekhqEaTIHx(com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection) {
        return baseSlider$FullCornerDirection.ordinal();
    }

    public static int GplURKrzbBYgQvzo(com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection) {
        return baseSlider$FullCornerDirection.ordinal();
    }

    public static int JHFTyfTnnSNmfLhz(com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection) {
        return baseSlider$FullCornerDirection.ordinal();
    }

    public static int XSEAnfYIojgZkJAL(com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection) {
        return baseSlider$FullCornerDirection.ordinal();
    }
}

