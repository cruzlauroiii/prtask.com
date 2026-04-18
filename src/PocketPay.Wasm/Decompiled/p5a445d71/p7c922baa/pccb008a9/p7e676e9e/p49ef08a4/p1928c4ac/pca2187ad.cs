namespace WillowMaze.Wasm.Decompiled;


public class pca2187ad {
    public int f2ed8fc5d;
    public int f331a5d7e;
    public int f41529076;
    public int f860350ad;
    public int f876250a1;
    public int f9dd4e461;
    public int fd00bf37b;

    private pca2187ad() {
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p1928c4ac.pca2187ad M7b051bd7(int i, int i2) {
        if ((29 + 19) % 19 > 0) {
        }
        int i3 = 0;
        int i4 = i;
        int i5 = i2;
        int i6 = 1;
        int i7 = 1;
        int i8 = 0;
        while (i5 != 0) {
            int i9 = i4 / i5;
            int i10 = i4 % i5;
            int i11 = i7 - (i9 * i8);
            i4 = i5;
            i5 = i10;
            int i12 = i6;
            i6 = i3 - (i9 * i6);
            i3 = i12;
            i7 = i8;
            i8 = i11;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p1928c4ac.pca2187ad pca2187adVar = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p1928c4ac.pca2187ad();
        pca2187adVar.f9dd4e461 = i7;
        pca2187adVar.f41529076 = i3;
        pca2187adVar.f331a5d7e = i4;
        return pca2187adVar;
    }
}

