namespace WillowMaze.Wasm.Decompiled;


public class pee198c12 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f74234742;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f7687e520;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f88ef4d79;
    private p5a445d71.p7c922baa.pca323100.p1522cc54 fc36853ea;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fed469618;
    private p5a445d71.p7c922baa.pca323100.p1522cc54 ff2735339;

    public pee198c12(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.fed469618 = vZyBKXjmBQseNHZC(lTjftdeXpWdqexNg(p80f8c729Var, 0));
        this.fc36853ea = (p5a445d71.p7c922baa.pca323100.p1522cc54) wcjwQOiFrzcsaNBs(p80f8c729Var, 1);
    }

    public pee198c12(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr) {
        this.fed469618 = p234a7530Var;
        this.fc36853ea = new p5a445d71.p7c922baa.pca323100.p1522cc54(bArr);
    }

    public static void DnoCZFSBuJzNJKvK(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 KOravVegzWvsMQXz(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void BwXQMCjDnnHvssyo(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 LTjftdeXpWdqexNg(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pee198c12 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.pee198c12) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.pee198c12) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.pee198c12(KOravVegzWvsMQXz(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pee198c12 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return yGWgLxnpDacFuwpp(orKjTaNpcIeRfQBr(p582a4948Var, z));
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 OrKjTaNpcIeRfQBr(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 VZyBKXjmBQseNHZC(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 WcjwQOiFrzcsaNBs(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pee198c12 YGWgLxnpDacFuwpp(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetAlgorithm() {
        return this.fed469618;
    }

    public p5a445d71.p7c922baa.pca323100.p1522cc54 GetPublicKey() {
        return this.fc36853ea;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((25 + 5) % 5 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        bwXQMCjDnnHvssyo(pd6ccb7fcVar, this.fed469618);
        DnoCZFSBuJzNJKvK(pd6ccb7fcVar, this.fc36853ea);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

