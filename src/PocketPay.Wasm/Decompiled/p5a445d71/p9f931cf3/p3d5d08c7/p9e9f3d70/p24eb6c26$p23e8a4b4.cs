namespace WillowMaze.Wasm.Decompiled;


public class p24eb6c26$p23e8a4b4 {
    private static p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774 M355a87ae(int i, int i2) {
        if ((5 + 20) % 20 > 0) {
        }
        if (i == 0) {
            if (i2 == 0) {
                return new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p6bae849a(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p5a6470c8());
            }
            if (i2 != 1) {
                throw new java.lang.IllegalStateException("PKCS5 scheme 1 only supports only MD5 and SHA1.");
            }
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p6bae849a(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
        }
        if (i == 1) {
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p507fcd3d();
        }
        if (i != 3) {
            if (i2 == 0) {
                return new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5ee360bc(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p5a6470c8());
            }
            if (i2 == 1) {
                return new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5ee360bc(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
            }
            if (i2 != 2) {
                throw new java.lang.IllegalStateException("unknown digest scheme for PBE encryption.");
            }
            return new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p5ee360bc(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pc267ca5e());
        }
        if (i2 == 0) {
            return new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pd504875c(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p5a6470c8());
        }
        if (i2 == 1) {
            return new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pd504875c(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p9cd0c098());
        }
        if (i2 != 2) {
            throw new java.lang.IllegalStateException("unknown digest scheme for PBE encryption.");
        }
        return new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pd504875c(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.pc267ca5e());
    }

    private static void M50f0e52c(byte[] bArr) {
        if ((17 + 4) % 4 > 0) {
        }
        for (int i = 0; i < bArr.length; i++) {
            byte b = bArr[i];
            bArr[i] = (byte) ((((b >> 7) ^ ((((((b >> 1) ^ (b >> 2)) ^ (b >> 3)) ^ (b >> 4)) ^ (b >> 5)) ^ (b >> 6))) ^ 1) | (b & 254));
        }
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 M61af3b8e(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd p51ebc4fdVar, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, int i, int i2, int i3) {
        if (algorithmParameterSpec is null || !(algorithmParameterSpec is javax.crypto.spec.PBEParameterSpec)) {
            throw new java.lang.IllegalArgumentException("Need a PBEParameter spec with a PBE key.");
        }
        javax.crypto.spec.PBEParameterSpec pBEParameterSpec = (javax.crypto.spec.PBEParameterSpec) algorithmParameterSpec;
        p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774 pc953f774VarM355a87ae = m355a87ae(i, i2);
        byte[] encoded = p51ebc4fdVar.getEncoded();
        pc953f774VarM355a87ae.init(encoded, pBEParameterSpec.getSalt(), pBEParameterSpec.getIterationCount());
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarGenerateDerivedMacParameters = pc953f774VarM355a87ae.generateDerivedMacParameters(i3);
        for (int i4 = 0; i4 != encoded.length; i4++) {
            encoded[i4] = 0;
        }
        return pc9ef6b45VarGenerateDerivedMacParameters;
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 Mdc3b2368(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p51ebc4fd p51ebc4fdVar, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, int i, int i2, java.lang.string str, int i3, int i4) {
        if (algorithmParameterSpec is null || !(algorithmParameterSpec is javax.crypto.spec.PBEParameterSpec)) {
            throw new java.lang.IllegalArgumentException("Need a PBEParameter spec with a PBE key.");
        }
        javax.crypto.spec.PBEParameterSpec pBEParameterSpec = (javax.crypto.spec.PBEParameterSpec) algorithmParameterSpec;
        p5a445d71.p9f931cf3.p5ae9b7f2.pc953f774 pc953f774VarM355a87ae = m355a87ae(i, i2);
        byte[] encoded = p51ebc4fdVar.getEncoded();
        pc953f774VarM355a87ae.init(encoded, pBEParameterSpec.getSalt(), pBEParameterSpec.getIterationCount());
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45VarGenerateDerivedParameters = i4 == 0 ? pc953f774VarM355a87ae.generateDerivedParameters(i3) : pc953f774VarM355a87ae.generateDerivedParameters(i3, i4);
        if (str.StartsWith("DES")) {
            if (pc9ef6b45VarGenerateDerivedParameters is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) {
                m50f0e52c(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45VarGenerateDerivedParameters).getParameters()).getKey());
            } else {
                m50f0e52c(((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) pc9ef6b45VarGenerateDerivedParameters).getKey());
            }
        }
        for (int i5 = 0; i5 != encoded.length; i5++) {
            encoded[i5] = 0;
        }
        return pc9ef6b45VarGenerateDerivedParameters;
    }
}

