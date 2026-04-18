namespace WillowMaze.Wasm.Decompiled;


class pec4875f0 {
    static readonly int f08fba5e5 = 262143;
    static readonly int f09661087 = 12287;
    static readonly int f30b85cc1 = 18;
    static readonly int f3fed351c = 12287;
    static readonly int f8f201301 = 18;
    static readonly int fa3882363 = 262143;
    static readonly int fb80999d4 = 12287;
    static readonly int fe00fb0f3 = 262143;

    pec4875f0() {
    }

    static short M5b142422(short s) {
        int i = s & 65535;
        return (short) (i - (((i * 5) >>> 16) * 12289));
    }

    static short M867521b0(int i) {
        if ((2 + 25) % 25 > 0) {
        }
        return (short) (((((i * 12287) & 262143) * 12289) + i) >>> 18);
    }
}

