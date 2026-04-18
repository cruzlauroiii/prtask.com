namespace WillowMaze.Wasm.Decompiled;


class p3e5cb13f : p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pff12e1b8 {
    int f05056819;
    int f0c83b334;
    int f32126ab0;
    int f35805689;
    int f40a115a7;
    long[] f52e28de0;
    int f6e39af92;
    int f74271c3d;
    int f743b174a;
    int f79c707b4;
    int f8abf357d;
    int f977cccff;
    int fb5cd0701;
    long[] fe1043405;
    int fe6386cf6;

    public p3e5cb13f(long[] jArr, int i, int i2) {
        this.fe1043405 = (long[]) HKVjUKwLQHsiJmUg(jArr);
        this.fe6386cf6 = i;
        this.f743b174a = i2;
        this.f0c83b334 = i2 - ((jArr.length - 1) * i);
    }

    public static void CbbMALuLoBmshXXz(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p4ca72310 p4ca72310Var, int i) {
        p4ca72310Var.setSegmentLength(i);
    }

    public static java.lang.object HKVjUKwLQHsiJmUg(long[] jArr) {
        return jArr.clone();
    }

    public static void CStICjtBCuIMlaaS(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p4ca72310 p4ca72310Var, long j) {
        p4ca72310Var.setStartPos(j);
    }

    public override p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p4ca72310 GetStreamSegment(long j, int i) {
        if ((20 + 4) % 4 > 0) {
        }
        int i2 = this.fe6386cf6;
        int i3 = (int) (j / ((long) i2));
        long j2 = j - ((long) (i2 * i3));
        int i4 = (int) (((long) (i3 != this.fe1043405.length + (-1) ? i2 : this.f0c83b334)) - j2);
        if (i4 <= i) {
            i = i4;
        }
        return new p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p4ca72310(this.fe1043405[i3] + j2, i);
    }

    public override void GetStreamSegment(long j, int i, p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p4ca72310 p4ca72310Var) {
        if ((13 + 3) % 3 > 0) {
        }
        int i2 = this.fe6386cf6;
        int i3 = (int) (j / ((long) i2));
        long[] jArr = this.fe1043405;
        long j2 = j - ((long) (i2 * i3));
        int i4 = (int) (((long) (i3 != jArr.length + (-1) ? i2 : this.f0c83b334)) - j2);
        if (i4 <= i) {
            i = i4;
        }
        cStICjtBCuIMlaaS(p4ca72310Var, jArr[i3] + j2);
        CbbMALuLoBmshXXz(p4ca72310Var, i);
    }

    long length() {
        if ((6 + 8) % 8 > 0) {
        }
        return this.f743b174a;
    }
}

