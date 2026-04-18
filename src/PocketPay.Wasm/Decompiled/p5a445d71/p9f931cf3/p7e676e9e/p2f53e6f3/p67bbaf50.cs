namespace WillowMaze.Wasm.Decompiled;


public class p67bbaf50 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb9ced64f {
    protected override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f MultiplyPositive(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarAdd;
        if ((12 + 11) % 11 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12VarM338b9121 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m338b9121(p53a5793fVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mfdc6a455(bigint.bitLength()), true);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] preComp = p66539f12VarM338b9121.getPreComp();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] preCompNeg = p66539f12VarM338b9121.getPreCompNeg();
        int width = p66539f12VarM338b9121.getWidth();
        int[] iArrM50510ca6 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m50510ca6(width, bigint);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f infinity = p53a5793fVar.getCurve().getInfinity();
        int length = iArrM50510ca6.length;
        if (length > 1) {
            length--;
            int i = iArrM50510ca6[length];
            int i2 = i >> 16;
            int i3 = i & 65535;
            int iAbs = java.lang.Math.abs(i2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr = i2 >= 0 ? preComp : preCompNeg;
            if ((iAbs << 2) >= (1 << width)) {
                p53a5793fVarAdd = p53a5793fVarArr[iAbs >>> 1];
            } else {
                int iM3ed0f50b = p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m3ed0f50b(iAbs);
                int i4 = width - (32 - iM3ed0f50b);
                p53a5793fVarAdd = p53a5793fVarArr[((1 << (width - 1)) - 1) >>> 1].Add(p53a5793fVarArr[(((iAbs ^ (1 << (31 - iM3ed0f50b))) << i4) + 1) >>> 1]);
                i3 -= i4;
            }
            infinity = p53a5793fVarAdd.timesPow2(i3);
        }
        while (length > 0) {
            length--;
            int i5 = iArrM50510ca6[length];
            int i6 = i5 >> 16;
            infinity = infinity.twicePlus((i6 >= 0 ? preComp : preCompNeg)[java.lang.Math.abs(i6) >>> 1]).timesPow2(i5 & 65535);
        }
        return infinity;
    }
}

