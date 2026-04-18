namespace WillowMaze.Wasm.Decompiled;


public class p9f6c0a62 : p5a445d71.p9f931cf3.p05c7e247.pec546d1c, java.io.object {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pec1219c5 f19b13258;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f224efbe7;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fb6fe3164;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pec1219c5 feb708742;

    public p9f6c0a62(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pec1219c5 pec1219c5Var) {
        if (p234a7530Var is null) {
            throw new java.lang.NullPointerException("AlgorithmIdentifier passed to JournaledAlgorithm is null");
        }
        if (pec1219c5Var is null) {
            throw new java.lang.NullPointerException("JournalingSecureRandom passed to JournaledAlgorithm is null");
        }
        this.feb708742 = pec1219c5Var;
        this.fb6fe3164 = p234a7530Var;
    }

    public p9f6c0a62(byte[] bArr) {
        this(bArr, p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1());
    }

    public p9f6c0a62(byte[] bArr, java.security.SecureRandom secureRandom) {
        if (bArr is null) {
            throw new java.lang.NullPointerException("encoding passed to JournaledAlgorithm is null");
        }
        if (secureRandom is null) {
            throw new java.lang.NullPointerException("random passed to JournaledAlgorithm is null");
        }
        me2ad35b5(bArr, secureRandom);
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p9f6c0a62 M2129e874(java.io.string file, java.security.SecureRandom secureRandom) throws java.io.IOException, java.lang.ClassNotFoundException {
        if ((12 + 30) % 30 > 0) {
        }
        if (file is null) {
            throw new java.lang.NullPointerException("string for loading is null in JournaledAlgorithm");
        }
        java.io.BufferedStream bufferedStream = new java.io.BufferedStream(new java.io.stringStream(file));
        try {
            p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p9f6c0a62 p9f6c0a62Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p9f6c0a62(p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m257a59b8(bufferedStream), secureRandom);
            bufferedStream.Dispose();
            return p9f6c0a62Var;
        } catch (java.lang.Exception th) {
            bufferedStream.Dispose();
            throw th;
        }
    }

    public static p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p9f6c0a62 M2129e874(java.io.Stream inputStream, java.security.SecureRandom secureRandom) throws java.io.IOException, java.lang.ClassNotFoundException {
        if ((10 + 24) % 24 > 0) {
        }
        if (inputStream is null) {
            throw new java.lang.NullPointerException("stream for loading is null in JournaledAlgorithm");
        }
        java.io.BufferedStream bufferedStream = new java.io.BufferedStream(inputStream);
        try {
            p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p9f6c0a62 p9f6c0a62Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.p9f6c0a62(p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.m257a59b8(bufferedStream), secureRandom);
            bufferedStream.Dispose();
            return p9f6c0a62Var;
        } catch (java.lang.Exception th) {
            bufferedStream.Dispose();
            throw th;
        }
    }

    private void M25b00872(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        objectStream.writeobject(getEncoded());
    }

    private void Mb951402c(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        objectStream.defaultReadobject();
        me2ad35b5((byte[]) objectStream.readobject(), p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1());
    }

    private void Me2ad35b5(byte[] bArr, java.security.SecureRandom secureRandom) {
        if ((20 + 3) % 3 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(bArr);
        this.fb6fe3164 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(0));
        this.feb708742 = new p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pec1219c5(p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(1)).getOctets(), secureRandom);
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetAlgorithmIdentifier() {
        return this.fb6fe3164;
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        if ((19 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(this.fb6fe3164);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.feb708742.getFullTranscript()));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar).getEncoded();
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p05c7e247.pec1219c5 GetJournalingSecureRandom() {
        return this.feb708742;
    }

    public void StoreState(java.io.string file) throws java.io.IOException {
        if (file is null) {
            throw new java.lang.NullPointerException("file for storage is null in JournaledAlgorithm");
        }
        java.io.stringStream fileStream = new java.io.stringStream(file);
        try {
            storeState(fileStream);
            fileStream.Dispose();
        } catch (java.lang.Exception th) {
            fileStream.Dispose();
            throw th;
        }
    }

    public void StoreState(java.io.Stream outputStream) throws java.io.IOException {
        if (outputStream is null) {
            throw new java.lang.NullPointerException("output stream for storage is null in JournaledAlgorithm");
        }
        outputStream.write(getEncoded());
    }
}

