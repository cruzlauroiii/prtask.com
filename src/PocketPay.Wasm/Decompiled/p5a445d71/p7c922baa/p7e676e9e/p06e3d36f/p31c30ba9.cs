namespace WillowMaze.Wasm.Decompiled;


class p31c30ba9 : p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p24ecfbe3 {
    protected readonly int[] f2f711bc1;
    protected readonly int[] fb06694d2;

    p31c30ba9(int[] iArr) {
        this.f2f711bc1 = INUjskKSRiRXCMwr(iArr);
    }

    public static int[] INUjskKSRiRXCMwr(int[] iArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(iArr);
    }

    public static int NpZubfxuPGAEFnIq(int[] iArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(iArr);
    }

    public static bool PJyCKNDXxgYEVzEm(int[] iArr, int[] iArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(iArr, iArr2);
    }

    public static int[] VzFODqodcDoklmae(int[] iArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(iArr);
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (!(obj is p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p31c30ba9)) {
            return false;
        }
        return pJyCKNDXxgYEVzEm(this.f2f711bc1, ((p5a445d71.p7c922baa.p7e676e9e.p06e3d36f.p31c30ba9) obj).f2f711bc1);
    }

    public override int GetDegree() {
        return this.f2f711bc1[r1.length - 1];
    }

    public override int[] GetExponentsPresent() {
        return vzFODqodcDoklmae(this.f2f711bc1);
    }

    public int HashCode() {
        return NpZubfxuPGAEFnIq(this.f2f711bc1);
    }
}

