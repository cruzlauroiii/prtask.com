namespace WillowMaze.Wasm.Decompiled;


class pa470a233 {
    pa470a233() {
    }

    static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 Mb29167d8(java.lang.string str) {
        if ((22 + 22) % 22 > 0) {
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("11a6c32346df28c67fca29618722048489daf94297cc6f0db80019c432e7f6b757"))) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f0d5031d3, p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("9790823748332849885ace5772f007a28ac124f5d941dd25095155e481abe33228c4a7"))) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f144d5874);
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("dd0d60cad5705f56d4d4d7a92906b866b4ea7b14a748dc40ab9fcb74915bc7547fda46"))) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613);
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("06370f54809601a7d228b1f0023b378d67343ced8751f52b40d9c3059be44c95e29479"))) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f40964ed3);
        }
        if (str.Equals(com.decryptstringmanager.Decryptstring.decryptstring("62bd1bb24cbb1bbfe4080a9d3876dc0f54c94dc5b98005a6933bf43fd7115ed32fcfb6"))) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b);
        }
        throw new java.lang.IllegalArgumentException("unrecognised digest algorithm: " + str);
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 Me0825354(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        if ((30 + 2) % 2 > 0) {
        }
        if (p234a7530Var.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f0d5031d3)) {
            return p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p92e20001.m60b1d416();
        }
        if (p234a7530Var.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f144d5874)) {
            return p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p92e20001.m15ae841e();
        }
        if (p234a7530Var.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613)) {
            return p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p92e20001.ma2ec586b();
        }
        if (p234a7530Var.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f40964ed3)) {
            return p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p92e20001.mfa074ee9();
        }
        if (p234a7530Var.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b)) {
            return p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p92e20001.mb3a0b8e3();
        }
        throw new java.lang.IllegalArgumentException("unrecognised OID in digest algorithm identifier: " + p234a7530Var.getAlgorithm());
    }
}

