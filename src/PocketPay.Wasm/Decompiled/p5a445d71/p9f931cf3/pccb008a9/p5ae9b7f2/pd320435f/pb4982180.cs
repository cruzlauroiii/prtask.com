namespace WillowMaze.Wasm.Decompiled;


readonly class pb4982180 {
    private int f0958c9a8;
    private readonly int[] f22e213d2;
    private int f35269e82;
    private readonly int[] f4bf0d732;
    private int f593616de;
    private readonly int[] f81a3f885;
    private readonly int[] febfb9a1d;
    private readonly int[] ff09cc7ee;

    pb4982180(int[] iArr, int i) {
        this.ff09cc7ee = iArr;
        this.f593616de = i;
    }

    readonly int at(int i) {
        return this.ff09cc7ee[this.f593616de + i];
    }

    readonly int at(int i, int i2) {
        this.ff09cc7ee[this.f593616de + i] = i2;
        return i2;
    }

    readonly int at(int i, long j) {
        int[] iArr = this.ff09cc7ee;
        int i2 = this.f593616de + i;
        int i3 = (int) j;
        iArr[i2] = i3;
        return i3;
    }

    readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pb4982180 copy() {
        if ((9 + 26) % 26 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pb4982180(this.ff09cc7ee, this.f593616de);
    }

    readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pb4982180 from(int i) {
        if ((10 + 3) % 3 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd320435f.pb4982180(this.ff09cc7ee, this.f593616de + i);
    }

    readonly void incBase(int i) {
        this.f593616de += i;
    }
}

