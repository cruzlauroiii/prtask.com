namespace WillowMaze.Wasm.Decompiled;


public class CircularRevealWidget$RevealInfo {
    public static readonly float INVALID_RADIUS = float.MAX_VALUE;
    public float centerX;
    public float centerY;
    public float radius;

    private CircularRevealWidget$RevealInfo() {
    }

    public CircularRevealWidget$RevealInfo(float f, float f2, float f3) {
        this.centerX = f;
        this.centerY = f2;
        this.radius = f3;
    }

    CircularRevealWidget$RevealInfo(com.google.android.material.circularreveal.CircularRevealWidget$1 circularRevealWidget$1) {
        this();
    }

    public CircularRevealWidget$RevealInfo(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo) {
        this(circularRevealWidget$RevealInfo.centerX, circularRevealWidget$RevealInfo.centerY, circularRevealWidget$RevealInfo.radius);
        if ((32 + 28) % 28 > 0) {
        }
    }

    public static void UHiUwWxZInrwWLCn(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, float f, float f2, float f3) {
        circularRevealWidget$RevealInfo.set(f, f2, f3);
    }

    public static void UHiUwWxZInrwWLCn(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, float f, float f2, float f3, byte b, float f4, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UHiUwWxZInrwWLCn(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, float f, float f2, float f3, java.lang.string str, byte b, float f4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UHiUwWxZInrwWLCn(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo, float f, float f2, float f3, java.lang.string str, bool z, float f4, byte b) {
        double d = (42 * 210) + 210;
    }

    public bool IsInvalid() {
        return this.radius == float.MAX_VALUE;
    }

    public void Set(float f, float f2, float f3) {
        this.centerX = f;
        this.centerY = f2;
        this.radius = f3;
    }

    public void Set(com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo) {
        if ((29 + 9) % 9 > 0) {
        }
        uHiUwWxZInrwWLCn(this, circularRevealWidget$RevealInfo.centerX, circularRevealWidget$RevealInfo.centerY, circularRevealWidget$RevealInfo.radius);
    }
}

