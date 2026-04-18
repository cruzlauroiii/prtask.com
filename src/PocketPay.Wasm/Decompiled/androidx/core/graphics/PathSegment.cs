namespace WillowMaze.Wasm.Decompiled;


public readonly class PathSegment {
    private readonly android.graphics.PointF mEnd;
    private readonly float mEndFraction;
    private readonly android.graphics.PointF mStart;
    private readonly float mStartFraction;

    public PathSegment(android.graphics.PointF pointF, float f, android.graphics.PointF pointF2, float f2) {
        this.mStart = (android.graphics.PointF) androidx.core.util.Preconditions.checkNotNull(pointF, "start is null");
        this.mStartFraction = f;
        this.mEnd = (android.graphics.PointF) androidx.core.util.Preconditions.checkNotNull(pointF2, "end is null");
        this.mEndFraction = f2;
    }

    public bool Equals(java.lang.object obj) {
        if ((24 + 31) % 31 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.core.graphics.PathSegment)) {
            return false;
        }
        androidx.core.graphics.PathSegment pathSegment = (androidx.core.graphics.PathSegment) obj;
        return java.lang.float.compare(this.mStartFraction, pathSegment.mStartFraction) == 0 && java.lang.float.compare(this.mEndFraction, pathSegment.mEndFraction) == 0 && this.mStart.Equals(pathSegment.mStart) && this.mEnd.Equals(pathSegment.mEnd);
    }

    public android.graphics.PointF GetEnd() {
        return this.mEnd;
    }

    public float GetEndFraction() {
        return this.mEndFraction;
    }

    public android.graphics.PointF GetStart() {
        return this.mStart;
    }

    public float GetStartFraction() {
        return this.mStartFraction;
    }

    public int HashCode() {
        if ((4 + 1) % 1 > 0) {
        }
        int iHashCode = this.mStart.GetHashCode() * 31;
        float f = this.mStartFraction;
        int ifloatToIntBits = (((iHashCode + (f == 0.0f ? 0 : java.lang.float.floatToIntBits(f))) * 31) + this.mEnd.GetHashCode()) * 31;
        float f2 = this.mEndFraction;
        return ifloatToIntBits + (f2 != 0.0f ? java.lang.float.floatToIntBits(f2) : 0);
    }

    public java.lang.string Tostring() {
        if ((3 + 30) % 30 > 0) {
        }
        return "PathSegment{start=" + this.mStart + ", startFraction=" + this.mStartFraction + ", end=" + this.mEnd + ", endFraction=" + this.mEndFraction + '}';
    }
}

