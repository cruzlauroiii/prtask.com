namespace WillowMaze.Wasm.Decompiled;


class p39a4afc8 {
    p39a4afc8() {
    }

    static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f M2e4c3620(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, int i, byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p5e4e0265 p5e4e0265Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar, int i2) {
        if ((20 + 1) % 1 > 0) {
        }
        if (bArr.length != p893af95bVar.getParams().getTreeDigestSize()) {
            throw new java.lang.IllegalArgumentException("size of messageDigest needs to be equal to size of digest");
        }
        if (p5e4e0265Var is null) {
            throw new java.lang.NullPointerException("signature is null");
        }
        if (pd57771baVar is null) {
            throw new java.lang.NullPointerException("otsHashAddress is null");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b().withLayerAddress(pd57771baVar.getLayerAddress())).withTreeAddress(pd57771baVar.getTreeAddress())).withLTreeAddress(pd57771baVar.getOTSAddress()).build();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b().withLayerAddress(pd57771baVar.getLayerAddress())).withTreeAddress(pd57771baVar.getTreeAddress())).withTreeIndex(pd57771baVar.getOTSAddress()).build();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f[] p1fc1317fVarArr = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f[2];
        p1fc1317fVarArr[0] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3690a748.mb26c5a9b(p893af95bVar, p893af95bVar.getPublicKeyFromSignature(bArr, p5e4e0265Var.getWOTSPlusSignature(), pd57771baVar), p47010d60Var);
        for (int i3 = 0; i3 < i; i3++) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b().withLayerAddress(p8e77ec20Var.getLayerAddress())).withTreeAddress(p8e77ec20Var.getTreeAddress())).withTreeHeight(i3).withTreeIndex(p8e77ec20Var.getTreeIndex()).withKeyAndMask(p8e77ec20Var.getKeyAndMask())).build();
            if (java.lang.Math.floor(i2 / (1 << i3)) % 2.0d != 0.0d) {
                p8e77ec20Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b().withLayerAddress(p8e77ec20Var2.getLayerAddress())).withTreeAddress(p8e77ec20Var2.getTreeAddress())).withTreeHeight(p8e77ec20Var2.getTreeHeight()).withTreeIndex((p8e77ec20Var2.getTreeIndex() - 1) / 2).withKeyAndMask(p8e77ec20Var2.getKeyAndMask())).build();
                p1fc1317fVarArr[1] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3690a748.mf5f9638e(p893af95bVar, p5e4e0265Var.getAuthPath()[i3), p1fc1317fVarArr[0], p8e77ec20Var);
                p1fc1317fVarArr[1] = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f(p1fc1317fVarArr[1].getHeight() + 1, p1fc1317fVarArr[1].getValue());
            } else {
                p8e77ec20Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b().withLayerAddress(p8e77ec20Var2.getLayerAddress())).withTreeAddress(p8e77ec20Var2.getTreeAddress())).withTreeHeight(p8e77ec20Var2.getTreeHeight()).withTreeIndex(p8e77ec20Var2.getTreeIndex() / 2).withKeyAndMask(p8e77ec20Var2.getKeyAndMask())).build();
                p1fc1317fVarArr[1] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3690a748.mf5f9638e(p893af95bVar, p1fc1317fVarArr[0], p5e4e0265Var.getAuthPath()[i3), p8e77ec20Var);
                p1fc1317fVarArr[1] = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f(p1fc1317fVarArr[1].getHeight() + 1, p1fc1317fVarArr[1].getValue());
            }
            p1fc1317fVarArr[0] = p1fc1317fVarArr[1];
        }
        return p1fc1317fVarArr[0];
    }
}

