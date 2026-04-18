namespace WillowMaze.Wasm.Decompiled;


class p69279707 {
    p69279707() {
    }

    public static int M277ad7bf(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        bool z = pe5cfc515Var is p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022;
        int digestSize = pe5cfc515Var.getDigestSize();
        return !z ? digestSize : digestSize * 2;
    }

    public static java.lang.string M3d422dba(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((31 + 19) % 19 > 0) {
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613)) {
            return com.decryptstringmanager.Decryptstring.decryptstring("b3e3bf8db7bd072b01f2e2da6cb9181a7efe458fe651ad711dd67e495da14fbe6e3f");
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b)) {
            return com.decryptstringmanager.Decryptstring.decryptstring("ac87d0134815b316efd7d291a944a339270ae9a68ae5d665cd75f9686a5c4851eec1");
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f)) {
            return com.decryptstringmanager.Decryptstring.decryptstring("cb7b21075fa5b1490010c0c5ee68c87116b246e440d260098fe456fb2f72d6fc46de3dd8");
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af)) {
            return com.decryptstringmanager.Decryptstring.decryptstring("457a75630240b3345cb8197fcbe31d2be7a5e35d13359f165a80fa0981bdb735a794b17a");
        }
        throw new java.lang.IllegalArgumentException("unrecognized digest OID: " + p364bf33aVar);
    }

    public static byte[] Meca8e3f6(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((23 + 30) % 30 > 0) {
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

