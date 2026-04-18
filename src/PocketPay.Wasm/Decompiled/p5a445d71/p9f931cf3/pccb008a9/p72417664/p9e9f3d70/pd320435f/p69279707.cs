namespace WillowMaze.Wasm.Decompiled;


class p69279707 {
    p69279707() {
    }

    public static int M277ad7bf(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        bool z = pe5cfc515Var is p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022;
        int digestSize = pe5cfc515Var.getDigestSize();
        return !z ? digestSize : digestSize * 2;
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 Me0825354(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((16 + 11) % 11 > 0) {
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c();
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf();
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(128);
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af)) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(256);
        }
        throw new java.lang.IllegalArgumentException("unrecognized digest OID: " + p364bf33aVar);
    }

    public static byte[] Meca8e3f6(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((25 + 31) % 31 > 0) {
        }
        int iM277ad7bf = m277ad7bf(pe5cfc515Var);
        byte[] bArr = new byte[iM277ad7bf];
        if (pe5cfc515Var is p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022) {
            ((p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022) pe5cfc515Var).doFinal(bArr, 0, iM277ad7bf);
            return bArr;
        }
        pe5cfc515Var.doFinal(bArr, 0);
        return bArr;
    }
}

