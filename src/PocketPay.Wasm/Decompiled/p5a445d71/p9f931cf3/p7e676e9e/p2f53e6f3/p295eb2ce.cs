namespace WillowMaze.Wasm.Decompiled;


public class p295eb2ce : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb9ced64f {
    static readonly java.lang.string f360b70c5 = com.decryptstringmanager.Decryptstring.decryptstring("3ad69ea1113f7d4405355054665fcade8edc591fb9b439e4f8aa8c31aac4a34f4d78c207");
    static readonly java.lang.string f57cc2ef6 = null;

    private static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97 m63ee8f8b(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97 p53a5793f_p7979ad97, byte[] bArr) {
        if ((26 + 24) % 24 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97 pa827ecfa_p7979ad97 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97) p53a5793f_p7979ad97.getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97[] preComp = ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p77beeb9e) pa827ecfa_p7979ad97.precompute(p53a5793f_p7979ad97, com.decryptstringmanager.Decryptstring.decryptstring("3fece015345a4b1816648db9292f8278940b7593563e9c580f1060d43fae5518b9580c14"), new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p295eb2ce$1(p53a5793f_p7979ad97, pa827ecfa_p7979ad97.getA().toBigint().byteValue()))).getPreComp();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97[] p53a5793f_p7979ad97Arr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97[preComp.length];
        for (int i = 0; i < preComp.length; i++) {
            p53a5793f_p7979ad97Arr[i] = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97) preComp[i].negate();
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97 p53a5793f_p7979ad972 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97) p53a5793f_p7979ad97.getCurve().getInfinity();
        int i2 = 0;
        for (int length = bArr.length - 1; length >= 0; length--) {
            i2++;
            byte b = bArr[length];
            if (b != 0) {
                p53a5793f_p7979ad972 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97) p53a5793f_p7979ad972.tauPow(i2).Add(b <= 0 ? p53a5793f_p7979ad97Arr[(-b) >>> 1] : preComp[b >>> 1]);
                i2 = 0;
            }
        }
        return i2 <= 0 ? p53a5793f_p7979ad972 : p53a5793f_p7979ad972.tauPow(i2);
    }

    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97 m7e1a3a84(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97 p53a5793f_p7979ad97, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pf9ae915b pf9ae915bVar, byte b, byte b2) {
        if ((11 + 24) % 24 > 0) {
        }
        return m63ee8f8b(p53a5793f_p7979ad97, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p485c63a4.me9144d2e(b2, pf9ae915bVar, (byte) 4, java.math.Bigint.valueOf(16L), p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p485c63a4.ma693439f(b2, 4), b != 0 ? p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p485c63a4.f8dbc2828 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p485c63a4.f3be08c60));
    }

    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f MultiplyPositive(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        if ((29 + 4) % 4 > 0) {
        }
        if (!(p53a5793fVar is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97)) {
            throw new java.lang.IllegalArgumentException("Only ECPoint.AbstractF2m can be used in WTauNafMultiplier");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97 p53a5793f_p7979ad97 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97) p53a5793fVar;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97 pa827ecfa_p7979ad97 = (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97) p53a5793f_p7979ad97.getCurve();
        int fieldSize = pa827ecfa_p7979ad97.getFieldSize();
        byte bbyteValue = pa827ecfa_p7979ad97.getA().toBigint().byteValue();
        byte bM6b8ff7b1 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p485c63a4.m6b8ff7b1(bbyteValue);
        return m7e1a3a84(p53a5793f_p7979ad97, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p485c63a4.md06cd05c(bigint, fieldSize, bbyteValue, pa827ecfa_p7979ad97.getSi(), bM6b8ff7b1, (byte) 10), bbyteValue, bM6b8ff7b1);
    }
}

