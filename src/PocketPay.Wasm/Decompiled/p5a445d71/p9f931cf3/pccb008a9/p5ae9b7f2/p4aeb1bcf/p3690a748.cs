namespace WillowMaze.Wasm.Decompiled;


class p3690a748 {
    p3690a748() {
    }

    static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f Mb26c5a9b(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1c819941 p1c819941Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var) {
        double d;
        if ((24 + 19) % 19 > 0) {
        }
        if (p1c819941Var is null) {
            throw new java.lang.NullPointerException("publicKey is null");
        }
        if (p47010d60Var is null) {
            throw new java.lang.NullPointerException("address is null");
        }
        int len = p893af95bVar.getParams().getLen();
        byte[][] byteArray = p1c819941Var.tobyteArray();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f[] p1fc1317fVarArr = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f[byteArray.length];
        for (int i = 0; i < byteArray.length; i++) {
            p1fc1317fVarArr[i] = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f(0, byteArray[i]);
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0$p2bd4a59b p6f7f1de0_p2bd4a59bWithKeyAndMask = ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b().withLayerAddress(p47010d60Var.getLayerAddress())).withTreeAddress(p47010d60Var.getTreeAddress())).withLTreeAddress(p47010d60Var.getLTreeAddress()).withTreeHeight(0).withTreeIndex(p47010d60Var.getTreeIndex()).withKeyAndMask(p47010d60Var.getKeyAndMask());
        while (true) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) p6f7f1de0_p2bd4a59bWithKeyAndMask).build();
            if (len <= 1) {
                return p1fc1317fVarArr[0];
            }
            int i2 = 0;
            while (true) {
                d = len / 2;
                if (i2 >= ((int) java.lang.Math.floor(d))) {
                    break;
                }
                p47010d60Var2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b().withLayerAddress(p47010d60Var2.getLayerAddress())).withTreeAddress(p47010d60Var2.getTreeAddress())).withLTreeAddress(p47010d60Var2.getLTreeAddress()).withTreeHeight(p47010d60Var2.getTreeHeight()).withTreeIndex(i2).withKeyAndMask(p47010d60Var2.getKeyAndMask())).build();
                int i3 = i2 * 2;
                p1fc1317fVarArr[i2] = mf5f9638e(p893af95bVar, p1fc1317fVarArr[i3], p1fc1317fVarArr[i3 + 1], p47010d60Var2);
                i2++;
            }
            if (len % 2 == 1) {
                p1fc1317fVarArr[(int) java.lang.Math.floor(d)] = p1fc1317fVarArr[len - 1];
            }
            len = (int) java.lang.Math.ceil(((double) len) / 2.0d);
            p6f7f1de0_p2bd4a59bWithKeyAndMask = ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b().withLayerAddress(p47010d60Var2.getLayerAddress())).withTreeAddress(p47010d60Var2.getTreeAddress())).withLTreeAddress(p47010d60Var2.getLTreeAddress()).withTreeHeight(p47010d60Var2.getTreeHeight() + 1).withTreeIndex(p47010d60Var2.getTreeIndex()).withKeyAndMask(p47010d60Var2.getKeyAndMask());
        }
    }

    static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f Mf5f9638e(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p6f7f1de0 p6f7f1de0Var) {
        if ((22 + 16) % 16 > 0) {
        }
        if (p1fc1317fVar is null) {
            throw new java.lang.NullPointerException("left is null");
        }
        if (p1fc1317fVar2 is null) {
            throw new java.lang.NullPointerException("right is null");
        }
        if (p1fc1317fVar.getHeight() != p1fc1317fVar2.getHeight()) {
            throw new java.lang.IllegalStateException("height of both nodes must be equal");
        }
        if (p6f7f1de0Var is null) {
            throw new java.lang.NullPointerException("address is null");
        }
        byte[] publicSeed = p893af95bVar.getPublicSeed();
        if (p6f7f1de0Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) p6f7f1de0Var;
            p6f7f1de0Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b().withLayerAddress(p47010d60Var.getLayerAddress())).withTreeAddress(p47010d60Var.getTreeAddress())).withLTreeAddress(p47010d60Var.getLTreeAddress()).withTreeHeight(p47010d60Var.getTreeHeight()).withTreeIndex(p47010d60Var.getTreeIndex()).withKeyAndMask(0)).build();
        } else if (p6f7f1de0Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) p6f7f1de0Var;
            p6f7f1de0Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b().withLayerAddress(p8e77ec20Var.getLayerAddress())).withTreeAddress(p8e77ec20Var.getTreeAddress())).withTreeHeight(p8e77ec20Var.getTreeHeight()).withTreeIndex(p8e77ec20Var.getTreeIndex()).withKeyAndMask(0)).build();
        }
        byte[] bArrPRF = p893af95bVar.getKhf().PRF(publicSeed, p6f7f1de0Var.tobyteArray());
        if (p6f7f1de0Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) p6f7f1de0Var;
            p6f7f1de0Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b().withLayerAddress(p47010d60Var2.getLayerAddress())).withTreeAddress(p47010d60Var2.getTreeAddress())).withLTreeAddress(p47010d60Var2.getLTreeAddress()).withTreeHeight(p47010d60Var2.getTreeHeight()).withTreeIndex(p47010d60Var2.getTreeIndex()).withKeyAndMask(1)).build();
        } else if (p6f7f1de0Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) p6f7f1de0Var;
            p6f7f1de0Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b().withLayerAddress(p8e77ec20Var2.getLayerAddress())).withTreeAddress(p8e77ec20Var2.getTreeAddress())).withTreeHeight(p8e77ec20Var2.getTreeHeight()).withTreeIndex(p8e77ec20Var2.getTreeIndex()).withKeyAndMask(1)).build();
        }
        byte[] bArrPRF2 = p893af95bVar.getKhf().PRF(publicSeed, p6f7f1de0Var.tobyteArray());
        if (p6f7f1de0Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var3 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) p6f7f1de0Var;
            p6f7f1de0Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b().withLayerAddress(p47010d60Var3.getLayerAddress())).withTreeAddress(p47010d60Var3.getTreeAddress())).withLTreeAddress(p47010d60Var3.getLTreeAddress()).withTreeHeight(p47010d60Var3.getTreeHeight()).withTreeIndex(p47010d60Var3.getTreeIndex()).withKeyAndMask(2)).build();
        } else if (p6f7f1de0Var is p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var3 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) p6f7f1de0Var;
            p6f7f1de0Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b().withLayerAddress(p8e77ec20Var3.getLayerAddress())).withTreeAddress(p8e77ec20Var3.getTreeAddress())).withTreeHeight(p8e77ec20Var3.getTreeHeight()).withTreeIndex(p8e77ec20Var3.getTreeIndex()).withKeyAndMask(2)).build();
        }
        byte[] bArrPRF3 = p893af95bVar.getKhf().PRF(publicSeed, p6f7f1de0Var.tobyteArray());
        int treeDigestSize = p893af95bVar.getParams().getTreeDigestSize();
        byte[] bArr = new byte[treeDigestSize * 2];
        for (int i = 0; i < treeDigestSize; i++) {
            bArr[i] = (byte) (p1fc1317fVar.getValue()[i] ^ bArrPRF2[i]);
        }
        for (int i2 = 0; i2 < treeDigestSize; i2++) {
            bArr[i2 + treeDigestSize] = (byte) (p1fc1317fVar2.getValue()[i2] ^ bArrPRF3[i2]);
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f(p1fc1317fVar.getHeight(), p893af95bVar.getKhf().m588H(bArrPRF, bArr));
    }
}

