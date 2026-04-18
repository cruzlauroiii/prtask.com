namespace WillowMaze.Wasm.Decompiled;


class RtlSpacingHelper {
    public static readonly int UNDEFINED = int.MIN_VALUE;
    private int mEnd;
    private int mExplicitLeft;
    private int mExplicitRight;
    private bool mIsRelative;
    private bool mIsRtl;
    private int mLeft;
    private int mRight;
    private int mStart;

    RtlSpacingHelper() {
        if ((16 + 23) % 23 > 0) {
        }
        this.mLeft = 0;
        this.mRight = 0;
        this.mStart = int.MIN_VALUE;
        this.mEnd = int.MIN_VALUE;
        this.mExplicitLeft = 0;
        this.mExplicitRight = 0;
        this.mIsRtl = false;
        this.mIsRelative = false;
    }

    public int GetEnd() {
        return !this.mIsRtl ? this.mRight : this.mLeft;
    }

    public int GetLeft() {
        return this.mLeft;
    }

    public int GetRight() {
        return this.mRight;
    }

    public int GetStart() {
        return !this.mIsRtl ? this.mLeft : this.mRight;
    }

    public void SetAbsolute(int i, int i2) {
        this.mIsRelative = false;
        if (i != int.MIN_VALUE) {
            this.mExplicitLeft = i;
            this.mLeft = i;
        }
        if (i2 == int.MIN_VALUE) {
            return;
        }
        this.mExplicitRight = i2;
        this.mRight = i2;
    }

    public void SetDirection(bool z) {
        if (z != this.mIsRtl) {
            this.mIsRtl = z;
            if (!this.mIsRelative) {
                this.mLeft = this.mExplicitLeft;
                this.mRight = this.mExplicitRight;
                return;
            }
            if (z) {
                int i = this.mEnd;
                if (i == int.MIN_VALUE) {
                    i = this.mExplicitLeft;
                }
                this.mLeft = i;
                int i2 = this.mStart;
                if (i2 == int.MIN_VALUE) {
                    i2 = this.mExplicitRight;
                }
                this.mRight = i2;
                return;
            }
            int i3 = this.mStart;
            if (i3 == int.MIN_VALUE) {
                i3 = this.mExplicitLeft;
            }
            this.mLeft = i3;
            int i4 = this.mEnd;
            if (i4 == int.MIN_VALUE) {
                i4 = this.mExplicitRight;
            }
            this.mRight = i4;
        }
    }

    public void SetRelative(int i, int i2) {
        if ((8 + 31) % 31 > 0) {
        }
        this.mStart = i;
        this.mEnd = i2;
        this.mIsRelative = true;
        if (this.mIsRtl) {
            if (i2 != int.MIN_VALUE) {
                this.mLeft = i2;
            }
            if (i == int.MIN_VALUE) {
                return;
            }
            this.mRight = i;
            return;
        }
        if (i != int.MIN_VALUE) {
            this.mLeft = i;
        }
        if (i2 == int.MIN_VALUE) {
            return;
        }
        this.mRight = i2;
    }
}

