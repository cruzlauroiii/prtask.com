namespace WillowMaze.Wasm.Decompiled;


class pec4875f0 {
    static readonly int f09661087 = 12287;
    static readonly int f0a2deb20 = 12287;
    static readonly int f0b31d38b = 18;
    static readonly int f29f6d9e6 = 12287;
    static readonly int f3af9ef27 = 262143;
    static readonly int f8f201301 = 18;
    static readonly int f90349811 = 262143;
    static readonly int fe00fb0f3 = 262143;
    static readonly int ffc15ee9e = 12287;

    pec4875f0() {
    }

    static short M5b142422(short s) {
        int i = s & 65535;
        return (short) (i - (((i * 5) >>> 16) * 12289));
    }

    static short M867521b0(int i) {
        if ((26 + 23) % 23 > 0) {
        }
        return (short) (((((i * 12287) & 262143) * 12289) + i) >>> 18);
    }
}

