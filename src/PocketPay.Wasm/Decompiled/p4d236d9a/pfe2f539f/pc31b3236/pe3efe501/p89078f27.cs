namespace WillowMaze.Wasm.Decompiled;


readonly class p89078f27 {
    private readonly p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 f012d9b97;
    private readonly android.hardware.Camera$CameraInfo f08046e38;
    private readonly android.hardware.Camera f0c244e05;
    private readonly p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.pe6818a21 f0e704635;
    private readonly bool f18404f49;
    private readonly p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 f1cc08ebb;
    private readonly p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.pe6818a21 f24c292fe;
    private readonly p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.pe6818a21 f2a472593;
    private readonly bool f2e6ee398;
    private readonly p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 f382cf1cb;
    private readonly android.hardware.Camera f3af53cbc;
    private readonly p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 f4c9b7099;
    private readonly int f5fdd843c;
    private readonly int f75675609;
    private readonly p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 f76d1cb6b;
    private readonly bool f8a06744a;
    private readonly p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 f94c81956;
    private readonly android.hardware.Camera$CameraInfo fa1d47794;
    private readonly p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 fa5627f81;
    private readonly int fa703f25c;
    private readonly bool fa8cfde02;
    private readonly p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.pe6818a21 facd23dba;
    private readonly android.hardware.Camera$CameraInfo fb2465880;
    private readonly bool fc72adec0;
    private readonly bool fcfaf41ad;
    private readonly android.hardware.Camera$CameraInfo fd1ba12cf;
    private readonly android.hardware.Camera$CameraInfo fd2ad6c72;
    private readonly bool fd79a9416;
    private readonly bool fe0ec1442;
    private readonly int fe592782a;
    private readonly bool fe73cd301;
    private readonly int feaf5fc4b;
    private readonly p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 ffaad0b5d;

    public p89078f27(android.hardware.Camera camera, android.hardware.Camera$CameraInfo camera$CameraInfo, p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.pe6818a21 pe6818a21Var, p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 p2a3cd594Var, p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 p2a3cd594Var2, p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 p2a3cd594Var3, int i, bool z, bool z2) {
        this.f0c244e05 = camera;
        this.fd1ba12cf = camera$CameraInfo;
        this.f24c292fe = pe6818a21Var;
        this.f4c9b7099 = p2a3cd594Var;
        this.f94c81956 = p2a3cd594Var2;
        this.f382cf1cb = p2a3cd594Var3;
        this.feaf5fc4b = i;
        this.fc72adec0 = camera$CameraInfo.facing == 1;
        this.fe73cd301 = z;
        this.f8a06744a = z2;
    }

    public static void LoUHGvrEWouNrymA(p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.pe6818a21 pe6818a21Var) {
        pe6818a21Var.shutdown();
    }

    public static void LoUHGvrEWouNrymA(p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.pe6818a21 pe6818a21Var, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LoUHGvrEWouNrymA(p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.pe6818a21 pe6818a21Var, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LoUHGvrEWouNrymA(p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.pe6818a21 pe6818a21Var, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NweiexHhxDeufUft(android.hardware.Camera camera) {
        camera.release();
    }

    public static void NweiexHhxDeufUft(android.hardware.Camera camera, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NweiexHhxDeufUft(android.hardware.Camera camera, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NweiexHhxDeufUft(android.hardware.Camera camera, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public android.hardware.Camera GetCamera() {
        return this.f0c244e05;
    }

    public android.hardware.Camera$CameraInfo getCameraInfo() {
        return this.fd1ba12cf;
    }

    public p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.pe6818a21 GetDecoder() {
        return this.f24c292fe;
    }

    public int GetDisplayOrientation() {
        return this.feaf5fc4b;
    }

    public p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 GetImageSize() {
        return this.f4c9b7099;
    }

    public p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 GetPreviewSize() {
        return this.f94c81956;
    }

    public p4d236d9a.pfe2f539f.pc31b3236.pe3efe501.p2a3cd594 GetobjectSize() {
        return this.f382cf1cb;
    }

    public bool IsAutoFocusSupported() {
        return this.fe73cd301;
    }

    public bool IsFlashSupported() {
        return this.f8a06744a;
    }

    public void Release() {
        NweiexHhxDeufUft(this.f0c244e05);
        LoUHGvrEWouNrymA(this.f24c292fe);
    }

    public bool ShouldReverseHorizontal() {
        return this.fc72adec0;
    }
}

