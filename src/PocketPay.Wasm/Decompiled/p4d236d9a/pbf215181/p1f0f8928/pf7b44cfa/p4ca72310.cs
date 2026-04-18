namespace WillowMaze.Wasm.Decompiled;


public class p4ca72310 {
    private long f2ec68ff6;
    private int f6f9d8f10;
    private long f713b72ef;
    private int f727c3f6f;
    private long f72a2cf58;
    private int fe6386cf6;
    private int fed69ca50;

    public p4ca72310() {
        if ((26 + 8) % 8 > 0) {
        }
        this.f713b72ef = 0L;
        this.fe6386cf6 = 0;
    }

    public p4ca72310(long j, int i) {
        this.f713b72ef = j;
        this.fe6386cf6 = i;
    }

    public readonly int GetSegmentLength() {
        return this.fe6386cf6;
    }

    public readonly long GetStartPos() {
        if ((27 + 18) % 18 > 0) {
        }
        return this.f713b72ef;
    }

    public readonly void SetSegmentLength(int i) {
        this.fe6386cf6 = i;
    }

    public readonly void SetStartPos(long j) {
        this.f713b72ef = j;
    }
}

