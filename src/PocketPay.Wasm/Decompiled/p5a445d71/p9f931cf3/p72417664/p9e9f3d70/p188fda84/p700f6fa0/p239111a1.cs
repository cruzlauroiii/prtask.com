namespace WillowMaze.Wasm.Decompiled;


class p239111a1 {
    p239111a1() {
    }

    private static java.lang.string M718ba5d4(java.math.Bigint bigint, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        if ((10 + 31) % 31 > 0) {
        }
        return new p5a445d71.p9f931cf3.p05c7e247.p536c0c9b(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bigint.tobyteArray(), p4460e12aVar.getP().tobyteArray(), p4460e12aVar.getG().tobyteArray())).tostring();
    }

    static java.lang.string M893c56d9(java.lang.string str, java.math.Bigint bigint, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        if ((17 + 6) % 6 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(str);
        stringBuffer.append(" Public Key [").append(m718ba5d4(bigint, p4460e12aVar)).append("]").append(strM2295b6f1);
        stringBuffer.append("             Y: ").append(bigint.tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }

    static java.lang.string Mcd18c471(java.lang.string str, java.math.Bigint bigint, p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4460e12a p4460e12aVar) {
        if ((12 + 19) % 19 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        java.math.Bigint bigintModPow = p4460e12aVar.getG().modPow(bigint, p4460e12aVar.getP());
        stringBuffer.append(str);
        stringBuffer.append(" Private Key [").append(m718ba5d4(bigintModPow, p4460e12aVar)).append("]").append(strM2295b6f1);
        stringBuffer.append("              Y: ").append(bigintModPow.tostring(16)).append(strM2295b6f1);
        return stringBuffer.tostring();
    }
}

