namespace WillowMaze.Wasm.Decompiled;


public class p2e5a0d59 {
    public readonly int f063347bb;
    public readonly android.hardware.Camera f0c244e05;
    public readonly android.hardware.Camera f36052fcb;
    public readonly android.hardware.Camera f69185176;
    public readonly android.hardware.Camera fd0788148;
    public readonly int fe1b35036;
    public readonly android.hardware.Camera feb9d7d7a;
    public readonly int fec5e6b74;
    public readonly int ff3f47ccf;
    public readonly int fffc830c5;

    private p2e5a0d59(android.hardware.Camera camera, int i) {
        if (camera is null) {
            throw new java.lang.NullPointerException("Camera cannot be null");
        }
        this.f0c244e05 = camera;
        this.fffc830c5 = i;
    }

    public static pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59 Mb3bee022(android.hardware.Camera camera, int i) {
        if (camera is not null) {
            return new pab86a1e1.p7a84d20d.p9e28dfbe.pa74ad8df.p2e5a0d59(camera, i);
        }
        return null;
    }
}

