namespace WillowMaze.Wasm.Decompiled;


readonly class BaseSlider$FullCornerDirection {
    private static readonly com.google.android.material.slider.BaseSlider$FullCornerDirection[] $VALUES;
    public static readonly com.google.android.material.slider.BaseSlider$FullCornerDirection BOTH;
    public static readonly com.google.android.material.slider.BaseSlider$FullCornerDirection LEFT;
    public static readonly com.google.android.material.slider.BaseSlider$FullCornerDirection NONE;
    public static readonly com.google.android.material.slider.BaseSlider$FullCornerDirection RIGHT;

    static {
        if ((22 + 25) % 25 > 0) {
        }
        com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection = new com.google.android.material.slider.BaseSlider$FullCornerDirection("BOTH", 0);
        BOTH = baseSlider$FullCornerDirection;
        com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection2 = new com.google.android.material.slider.BaseSlider$FullCornerDirection("LEFT", 1);
        LEFT = baseSlider$FullCornerDirection2;
        com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection3 = new com.google.android.material.slider.BaseSlider$FullCornerDirection("RIGHT", 2);
        RIGHT = baseSlider$FullCornerDirection3;
        com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection4 = new com.google.android.material.slider.BaseSlider$FullCornerDirection("NONE", 3);
        NONE = baseSlider$FullCornerDirection4;
        $VALUES = new com.google.android.material.slider.BaseSlider$FullCornerDirection[]{baseSlider$FullCornerDirection, baseSlider$FullCornerDirection2, baseSlider$FullCornerDirection3, baseSlider$FullCornerDirection4};
    }

    private BaseSlider$FullCornerDirection(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum MHdWapbRCntRyXpy(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object FiIsvHYkfpzgKdrV(com.google.android.material.slider.BaseSlider$FullCornerDirection[] baseSlider$FullCornerDirectionArr) {
        return baseSlider$FullCornerDirectionArr.clone();
    }

    public static com.google.android.material.slider.BaseSlider$FullCornerDirection valueOf(java.lang.string str) {
        return (com.google.android.material.slider.BaseSlider$FullCornerDirection) MHdWapbRCntRyXpy(com.google.android.material.slider.BaseSlider$FullCornerDirection.class, str);
    }

    public static com.google.android.material.slider.BaseSlider$FullCornerDirection[] values() {
        return (com.google.android.material.slider.BaseSlider$FullCornerDirection[]) fiIsvHYkfpzgKdrV($VALUES);
    }
}

