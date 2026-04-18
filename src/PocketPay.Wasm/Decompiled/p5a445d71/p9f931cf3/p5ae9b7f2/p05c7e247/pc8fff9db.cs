namespace WillowMaze.Wasm.Decompiled;


public class pc8fff9db {
    static readonly byte[] f314f0af0 = null;
    static readonly byte[] f5276a074 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(com.decryptstringmanager.Decryptstring.decryptstring("e67fc470deae63d8551439ea9c08344adcd3920c731248128c0a83d6e65a99740cc438855ddfa52fccf680"));
    static readonly byte[] f9b390d65 = null;
    static readonly byte[] ffe6d854d = null;

    private pc8fff9db() {
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a M72ace772(byte[] bArr) {
        if ((31 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a p06022b5aVar = null;
        if (bArr[0] != 48) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594 p0402a594Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594(f5276a074, bArr);
            if (!com.decryptstringmanager.Decryptstring.decryptstring("f19b661e5524b1d2b74586cc2d6e93a2c97439a8acb3f339c34c09599c7ff282").Equals(p0402a594Var.readstring())) {
                throw new java.lang.IllegalStateException("encrypted keys not supported");
            }
            p0402a594Var.skipBlock();
            p0402a594Var.skipBlock();
            if (p0402a594Var.readU32() != 1) {
                throw new java.lang.IllegalStateException("multiple keys not supported");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pcc11822a.m5355d3b5(p0402a594Var.readBlock());
            byte[] paddedBlock = p0402a594Var.readPaddedBlock();
            if (p0402a594Var.hasRemaining()) {
                throw new java.lang.IllegalArgumentException("decoded key has trailing data");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594 p0402a594Var2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p0402a594(paddedBlock);
            if (p0402a594Var2.readU32() != p0402a594Var2.readU32()) {
                throw new java.lang.IllegalStateException("private key check values are not the same");
            }
            java.lang.string string = p0402a594Var2.readstring();
            if (com.decryptstringmanager.Decryptstring.decryptstring("969c4f94122d2f4e8a410343ceaba4104269ba6e8809e9cc452e950a3e1955b82a9df31cdca868").Equals(string)) {
                p0402a594Var2.readBlock();
                byte[] block = p0402a594Var2.readBlock();
                if (block.length != 64) {
                    throw new java.lang.IllegalStateException("private key value of wrong length");
                }
                p06022b5aVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1(block, 0);
            } else if (string.StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("d93e636ea30ae7fb21d9be803d064b4d1b3926267bc250a340c8ae0e323fee59eb"))) {
                p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarMb83b9f17 = p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pae8830f7.mb83b9f17(p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(p0402a594Var2.readBlock()));
                if (p364bf33aVarMb83b9f17 is null) {
                    throw new java.lang.IllegalStateException("OID not found for: " + string);
                }
                p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMd0402605 = p5a445d71.p9f931cf3.pca323100.pfed10774.p20ace684.md0402605(p364bf33aVarMb83b9f17);
                if (p35e46fcbVarMd0402605 is null) {
                    throw new java.lang.IllegalStateException("Curve not found for: " + p364bf33aVarMb83b9f17);
                }
                p0402a594Var2.readBlock();
                p06022b5aVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a(new java.math.Bigint(1, p0402a594Var2.readBlock()), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(p364bf33aVarMb83b9f17, p35e46fcbVarMd0402605));
            }
            p0402a594Var2.skipBlock();
            if (p0402a594Var2.hasRemaining()) {
                throw new java.lang.IllegalArgumentException("private key block has trailing data");
            }
        } else {
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(bArr);
            if (p80f8c729VarM8bab0102.Count != 6) {
                if (p80f8c729VarM8bab0102.Count != 9) {
                    if (p80f8c729VarM8bab0102.Count == 4 && (p80f8c729VarM8bab0102.getobjectAt(3) instanceof p5a445d71.p9f931cf3.pca323100.p582a4948) && (p80f8c729VarM8bab0102.getobjectAt(2) instanceof p5a445d71.p9f931cf3.pca323100.p582a4948)) {
                        p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc p5eff85bcVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p74459ca3.p5eff85bc.m8bab0102(p80f8c729VarM8bab0102);
                        p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p5eff85bcVarM8bab0102.getParametersobject());
                        p06022b5aVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a(p5eff85bcVarM8bab0102.getKey(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pac352b6c(p364bf33aVarM8bab0102, p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.md0402605(p364bf33aVarM8bab0102)));
                    }
                } else if (md3b7c4b2(p80f8c729VarM8bab0102) && ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729VarM8bab0102.getobjectAt(0)).getPositiveValue().Equals(p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.f529e9e0b)) {
                    p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1 p970a24b1VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.p970a24b1.m8bab0102(p80f8c729VarM8bab0102);
                    p06022b5aVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9(p970a24b1VarM8bab0102.getModulus(), p970a24b1VarM8bab0102.getPublicExponent(), p970a24b1VarM8bab0102.getPrivateExponent(), p970a24b1VarM8bab0102.getPrime1(), p970a24b1VarM8bab0102.getPrime2(), p970a24b1VarM8bab0102.getExponent1(), p970a24b1VarM8bab0102.getExponent2(), p970a24b1VarM8bab0102.getCoefficient());
                }
            } else if (md3b7c4b2(p80f8c729VarM8bab0102) && ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729VarM8bab0102.getobjectAt(0)).getPositiveValue().Equals(p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.f529e9e0b)) {
                p06022b5aVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170(((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729VarM8bab0102.getobjectAt(5)).getPositiveValue(), new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd(((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729VarM8bab0102.getobjectAt(1)).getPositiveValue(), ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729VarM8bab0102.getobjectAt(2)).getPositiveValue(), ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729VarM8bab0102.getobjectAt(3)).getPositiveValue()));
            }
        }
        if (p06022b5aVar is null) {
            throw new java.lang.IllegalArgumentException("unable to parse key");
        }
        return p06022b5aVar;
    }

    private static bool Md3b7c4b2(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((26 + 22) % 22 > 0) {
        }
        for (int i = 0; i < p80f8c729Var.Count; i++) {
            if (!(p80f8c729Var.getobjectAt(i) instanceof p5a445d71.p9f931cf3.pca323100.pf391b73d)) {
                return false;
            }
        }
        return true;
    }

    public static byte[] Mf78d1be7(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) throws java.io.IOException {
        if ((17 + 4) % 4 > 0) {
        }
        if (pcfffbc4aVar is null) {
            throw new java.lang.IllegalArgumentException("param is null");
        }
        if (!(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p859968b9) && !(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p06022b5a)) {
            if (pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170 pacb8a170Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pacb8a170) pcfffbc4aVar;
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe0946edd parameters = pacb8a170Var.getParameters();
                p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
                pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(0L));
                pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(parameters.getP()));
                pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(parameters.getQ()));
                pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(parameters.getG()));
                pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(parameters.getG().modPow(pacb8a170Var.getX(), parameters.getP())));
                pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(pacb8a170Var.getX()));
                try {
                    return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar).getEncoded();
                } catch (java.lang.Exception e) {
                    throw new java.lang.IllegalStateException("unable to encode DSAPrivateKeyParameters " + e.getMessage());
                }
            }
            if (!(pcfffbc4aVar is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1)) {
                throw new java.lang.IllegalArgumentException("unable to convert " + pcfffbc4aVar.GetType().getName() + " to openssh private key");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1 pe1b9a0e1Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pe1b9a0e1) pcfffbc4aVar;
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p070794c1 p070794c1VarGeneratePublicKey = pe1b9a0e1Var.generatePublicKey();
            p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06 paeb89c06Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06();
            paeb89c06Var.writebytes(f5276a074);
            java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("1e26576f9be030a4e56828a4257b2256f4c5e8e268cb309dec37cee500e0eed9");
            paeb89c06Var.writestring(strDecryptstring);
            paeb89c06Var.writestring(strDecryptstring);
            paeb89c06Var.writestring("");
            paeb89c06Var.u32(1);
            paeb89c06Var.writeBlock(p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pcc11822a.m092fb0ff(p070794c1VarGeneratePublicKey));
            p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06 paeb89c06Var2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.paeb89c06();
            int iNextInt = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1().nextInt();
            paeb89c06Var2.u32(iNextInt);
            paeb89c06Var2.u32(iNextInt);
            paeb89c06Var2.writestring(com.decryptstringmanager.Decryptstring.decryptstring("e3c799e685393e8376935c561d20e5628572a5f81b1bcbdc00e3067accbcac808d887817bbf158"));
            byte[] encoded = p070794c1VarGeneratePublicKey.getEncoded();
            paeb89c06Var2.writeBlock(encoded);
            paeb89c06Var2.writeBlock(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(pe1b9a0e1Var.getEncoded(), encoded));
            paeb89c06Var2.writestring("");
            paeb89c06Var.writeBlock(paeb89c06Var2.getPaddedbytes());
            return paeb89c06Var.getbytes();
        }
        return p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pb3a2dfcc.m258e1870(pcfffbc4aVar).parsePrivateKey().toASN1Primitive().getEncoded();
    }
}

