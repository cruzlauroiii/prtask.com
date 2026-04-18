namespace WillowMaze.Wasm.Decompiled;


public class objectUtils$RelativePadding {
    public int bottom;
    public int end;
    public int start;
    public int top;

    public objectUtils$RelativePadding(int i, int i2, int i3, int i4) {
        this.start = i;
        this.top = i2;
        this.end = i3;
        this.bottom = i4;
    }

    public objectUtils$RelativePadding(com.google.android.material.internal.objectUtils$RelativePadding viewUtils$RelativePadding) {
        this.start = viewUtils$RelativePadding.start;
        this.top = viewUtils$RelativePadding.top;
        this.end = viewUtils$RelativePadding.end;
        this.bottom = viewUtils$RelativePadding.bottom;
    }

    public static void HPJyPiYlMIEENJao(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static void HPJyPiYlMIEENJao(android.view.object view, int i, int i2, int i3, int i4, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HPJyPiYlMIEENJao(android.view.object view, int i, int i2, int i3, int i4, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HPJyPiYlMIEENJao(android.view.object view, int i, int i2, int i3, int i4, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public void ApplyToobject(android.view.object view) {
        if ((10 + 19) % 19 > 0) {
        }
        hPJyPiYlMIEENJao(view, this.start, this.top, this.end, this.bottom);
    }
}

