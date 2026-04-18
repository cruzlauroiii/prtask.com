namespace WillowMaze.Wasm.Decompiled;


public class p135c2791 : p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.pb9ced64f {
    public static int LIKpQLhcoyOGuWJR(java.math.Bigint bigint) {
        return bigint.bitLength();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f NvxnrqbrPaaXtkWJ(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.negate();
    }

    public static int WLIFZjAEBPZRJlUr(java.math.Bigint bigint) {
        return bigint.getLowestHashSetBit();
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f FxoVOhHjeTDIAmqF(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        return p53a5793fVar.normalize();
    }

    public static bool SnVgsjxHofcpmhbc(java.math.Bigint bigint, int i) {
        return bigint.testBit(i);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f WLpdKIMYWcLWUdMN(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, int i) {
        return p53a5793fVar.timesPow2(i);
    }

    public static p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f ZkVhxSIdNEpXbDqA(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2) {
        return p53a5793fVar.twicePlus(p53a5793fVar2);
    }

    protected override p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f MultiplyPositive(p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        if ((17 + 28) % 28 > 0) {
        }
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarFxoVOhHjeTDIAmqF = fxoVOhHjeTDIAmqF(p53a5793fVar);
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNvxnrqbrPaaXtkWJ = NvxnrqbrPaaXtkWJ(p53a5793fVarFxoVOhHjeTDIAmqF);
        int iLIKpQLhcoyOGuWJR = LIKpQLhcoyOGuWJR(bigint);
        int iWLIFZjAEBPZRJlUr = WLIFZjAEBPZRJlUr(bigint);
        p5a445d71.p7c922baa.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarZkVhxSIdNEpXbDqA = p53a5793fVarFxoVOhHjeTDIAmqF;
        while (true) {
            iLIKpQLhcoyOGuWJR--;
            if (iLIKpQLhcoyOGuWJR <= iWLIFZjAEBPZRJlUr) {
                return wLpdKIMYWcLWUdMN(p53a5793fVarZkVhxSIdNEpXbDqA, iWLIFZjAEBPZRJlUr);
            }
            p53a5793fVarZkVhxSIdNEpXbDqA = zkVhxSIdNEpXbDqA(p53a5793fVarZkVhxSIdNEpXbDqA, !snVgsjxHofcpmhbc(bigint, iLIKpQLhcoyOGuWJR) ? p53a5793fVarNvxnrqbrPaaXtkWJ : p53a5793fVarFxoVOhHjeTDIAmqF);
        }
    }
}

