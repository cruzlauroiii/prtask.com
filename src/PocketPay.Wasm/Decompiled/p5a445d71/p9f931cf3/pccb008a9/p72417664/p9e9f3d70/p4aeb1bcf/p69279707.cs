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
        if ((21 + 2) % 2 > 0) {
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613)) {
            return com.decryptstringmanager.Decryptstring.decryptstring("d05a319988edfd1ed00d688d151826ff589f8c112b8859c4c94328acf9fe7c461f78");
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b)) {
            return com.decryptstringmanager.Decryptstring.decryptstring("cc49851210cebfa71a66881b49ff78a98cf82479ec9153cab6a6c5d0c083b64eceb5");
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f)) {
            return com.decryptstringmanager.Decryptstring.decryptstring("5e83e14c46f1333c4d3b99b46195b068291329949994b194c28bdcf23b9a138b126e45db");
        }
        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af)) {
            return com.decryptstringmanager.Decryptstring.decryptstring("152dafd8cf39c6f4dffece978b1a72b971d78f673e2d0363a8e8f87274e2647f55cde70c");
        }
        throw new java.lang.IllegalArgumentException("unrecognized digest OID: " + p364bf33aVar);
    }

    static p5a445d71.p9f931cf3.pca323100.p364bf33a M44ef4a60(java.lang.string str) {
        if ((8 + 2) % 2 > 0) {
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("eaf064370155c43afcf2a1e82d28663725f467f64c32189a86e9f068337f73e6be3eea"))) {
            return p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613;
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("039aecc356fba09a7df41cc2793ea4849ef149bb1c4b209d6daf236867cc34263b19a6"))) {
            return p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b;
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("7b54405a31a938a21567bb0f1d9bb30e0e9c2e7344c3ea7ae6683037d4ad0019bec44a89"))) {
            return p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f79d40c1f;
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("164f7ecdb0e3bbf51a78b14e329f30dce6ff9c08340ae87cdac8be787a481b900c5b43c2"))) {
            return p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f57bfa9af;
        }
        throw new java.lang.IllegalArgumentException("unrecognized digest: " + str);
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 Me0825354(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        if ((1 + 32) % 32 > 0) {
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
        if ((5 + 3) % 3 > 0) {
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

