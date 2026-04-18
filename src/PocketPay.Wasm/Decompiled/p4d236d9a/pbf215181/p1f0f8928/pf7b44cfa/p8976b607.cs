namespace WillowMaze.Wasm.Decompiled;


class p8976b607 : p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.pff12e1b8 {
    private int[] f15a97277;
    private long[] f31ffccce;
    private int[] f87f343ee;
    private int[] f912edf21;
    private int[] fc4b8a628;
    private int[] fd85fe88b;
    private long[] fe1043405;

    public p8976b607(long[] jArr, int[] iArr) {
        this.fe1043405 = (long[]) NOMyQcwMfRUvuVzz(jArr);
        this.f87f343ee = (int[]) sHlYSjRbIWdtYdkS(iArr);
    }

    public static java.lang.object NOMyQcwMfRUvuVzz(long[] jArr) {
        return jArr.clone();
    }

    public static int OvAajkagPcWXFDtU(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void PzCZSSlsBzolNqCe(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p4ca72310 p4ca72310Var, int i) {
        p4ca72310Var.setSegmentLength(i);
    }

    public static void QIVuvhQLnpOoCGDG(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p4ca72310 p4ca72310Var, long j) {
        p4ca72310Var.setStartPos(j);
    }

    public static void YJkGvHjMHifqrumd(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p4ca72310 p4ca72310Var, long j) {
        p4ca72310Var.setStartPos(j);
    }

    public static int FATuFrfhonrwdkZi(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.object SHlYSjRbIWdtYdkS(int[] iArr) {
        return iArr.clone();
    }

    public static void XHgaWNtYGAAQTXHI(p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p4ca72310 p4ca72310Var, int i) {
        p4ca72310Var.setSegmentLength(i);
    }

    public override p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p4ca72310 GetStreamSegment(long j, int i) {
        if ((11 + 18) % 18 > 0) {
        }
        int length = this.f87f343ee.length;
        for (int i2 = 0; i2 < length; i2++) {
            int i3 = this.f87f343ee[i2];
            long j2 = i3;
            if (j < j2) {
                return new p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p4ca72310(this.fe1043405[i2] + j, OvAajkagPcWXFDtU(i3 - ((int) j), i));
            }
            j -= j2;
        }
        return null;
    }

    public override void GetStreamSegment(long j, int i, p4d236d9a.pbf215181.p1f0f8928.pf7b44cfa.p4ca72310 p4ca72310Var) {
        if ((15 + 6) % 6 > 0) {
        }
        int length = this.f87f343ee.length;
        for (int i2 = 0; i2 < length; i2++) {
            int i3 = this.f87f343ee[i2];
            long j2 = i3;
            if (j < j2) {
                YJkGvHjMHifqrumd(p4ca72310Var, this.fe1043405[i2] + j);
                PzCZSSlsBzolNqCe(p4ca72310Var, fATuFrfhonrwdkZi(i3 - ((int) j), i));
                return;
            }
            j -= j2;
        }
        QIVuvhQLnpOoCGDG(p4ca72310Var, -1L);
        xHgaWNtYGAAQTXHI(p4ca72310Var, -1);
    }

    long length() {
        if ((29 + 32) % 32 > 0) {
        }
        int length = this.f87f343ee.length;
        long j = 0;
        for (int i = 0; i < length; i++) {
            j += (long) this.f87f343ee[i];
        }
        return j;
    }
}

