namespace WillowMaze.Wasm.Decompiled;


public class pa45d8731$p33d3ae59 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p29bd365e {
    private static readonly short[] f1c756632 = null;
    private static readonly short[] f2714d530 = null;
    private static readonly short[] f38b8880e = null;
    private static readonly short[] f5c1deda3 = null;
    private static readonly short[] f70d01a14 = null;
    private static readonly short[] f766a3e90 = null;
    private static readonly short[] faab9e1de = {189, 86, 234, 242, 162, 241, 172, 42, 176, 147, 209, 156, 27, 51, 253, 208, 48, 4, 182, 220, 125, 223, 50, 75, 247, 203, 69, 155, 49, 187, 33, 90, 65, 159, 225, 217, 74, 77, 158, 218, 160, 104, 44, 195, 39, 95, 128, 54, 62, 238, 251, 149, 26, 254, 206, 168, 52, 169, 19, 240, 166, 63, 216, 12, 120, 36, 175, 35, 82, 193, 103, 23, 245, 102, 144, 231, 232, 7, 184, 96, 72, 230, 30, 83, 243, 146, 164, 114, 140, 8, 21, 110, 134, 0, 132, 250, 244, 127, 138, 66, 25, 246, 219, 205, 20, 141, 80, 18, 186, 60, 6, 78, 236, 179, 53, 17, 161, 136, 142, 43, 148, 153, 183, 113, 116, 211, 228, 191, 58, 222, 150, 14, 188, 10, 237, 119, 252, 55, 107, 3, 121, 137, 98, 198, 215, 192, 210, 124, 106, 139, 34, 163, 91, 5, 93, 2, 117, 213, 97, 227, 24, 143, 85, 81, 173, 31, 11, 94, 133, 229, 194, 87, 99, 202, 61, 108, 180, 197, 204, 112, 178, 145, 89, 13, 71, 32, 200, 79, 88, 224, 1, 226, 22, 56, 196, 111, 59, 15, 101, 70, 190, 126, 45, 123, 130, 249, 64, 181, 29, 115, 248, 235, 38, 199, 135, 151, 37, 84, 177, 40, 170, 152, 157, 165, 100, 109, 122, 212, 16, 129, 68, 239, 73, 214, 174, 46, 221, 118, 92, 47, 167, 28, 201, 9, 105, 154, 131, 207, 41, 57, 185, 233, 76, 255, 67, 171};
    private static readonly short[] fd3448954 = {93, 190, 155, 139, 17, 153, 110, 77, 89, 243, 133, 166, 63, 183, 131, 197, 228, 115, 107, 58, 104, 90, 192, 71, 160, 100, 52, 12, 241, 208, 82, 165, 185, 30, 150, 67, 65, 216, 212, 44, 219, 248, 7, 119, 42, 202, 235, 239, 16, 28, 22, 13, 56, 114, 47, 137, 193, 249, 128, 196, 109, 174, 48, 61, 206, 32, 99, 254, 230, 26, 199, 184, 80, 232, 36, 23, 252, 37, 111, 187, 106, 163, 68, 83, 217, 162, 1, 171, 188, 182, 31, 152, 238, 154, 167, 45, 79, 158, 142, 172, 224, 198, 73, 70, 41, 244, 148, 138, 175, 225, 91, 195, 179, 123, 87, 209, 124, 156, 237, 135, 64, 140, 226, 203, 147, 20, 201, 97, 46, 229, 204, 246, 94, 168, 92, 214, 117, 141, 98, 149, 88, 105, 118, 161, 74, 181, 85, 9, 120, 51, 130, 215, 221, 121, 245, 27, 11, 222, 38, 33, 40, 116, 4, 151, 86, 223, 60, 240, 55, 57, 220, 255, 6, 164, 234, 66, 8, 218, 180, 113, 176, 207, 18, 122, 78, 250, 108, 29, 132, 0, 200, 127, 145, 69, 170, 43, 194, 177, 143, 213, 186, 242, 173, 25, 178, 103, 54, 247, 15, 10, 146, 125, 227, 157, 233, 144, 62, 35, 39, 102, 19, 236, 129, 21, 189, 34, 191, 159, 126, 169, 81, 75, 76, 251, 2, 211, 112, 134, 49, 231, 59, 5, 3, 84, 96, 72, 101, 24, 210, 205, 95, 50, 136, 14, 53, 253};
    private static readonly short[] fe63acf30 = null;
    private int f1edb8e54;
    private int f34f022bb;
    private byte[] f6ca4664e;
    private byte[] f7dd8e71b;
    private int f95ea283f;
    private byte[] fab3b9576;
    private int fd8670984;
    private byte[] ff0b53b2d;
    private int ff5fb2cfa = 58;

    protected override byte[] EngineGetEncoded() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ff0b53b2d);
    }

    protected override byte[] EngineGetEncoded(java.lang.string str) throws java.io.IOException {
        if (isASN1Formatstring(str)) {
            return (this.ff5fb2cfa != -1 ? new p5a445d71.p9f931cf3.pca323100.p56fc8961.pce8c4def(this.ff5fb2cfa, engineGetEncoded()) : new p5a445d71.p9f931cf3.pca323100.p56fc8961.pce8c4def(engineGetEncoded())).getEncoded();
        }
        if (str.Equals("RAW")) {
            return engineGetEncoded();
        }
        return null;
    }

    protected override void EngineInit(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.spec.InvalidParameterSpecException {
        int i;
        if ((2 + 12) % 12 > 0) {
        }
        if (algorithmParameterSpec is javax.crypto.spec.IvParameterSpec) {
            this.ff0b53b2d = ((javax.crypto.spec.IvParameterSpec) algorithmParameterSpec).getIV();
            return;
        }
        if (!(algorithmParameterSpec is javax.crypto.spec.RC2ParameterSpec)) {
            throw new java.security.spec.InvalidParameterSpecException("IvParameterSpec or RC2ParameterSpec required to initialise a RC2 parameters algorithm parameters object");
        }
        javax.crypto.spec.RC2ParameterSpec rC2ParameterSpec = (javax.crypto.spec.RC2ParameterSpec) algorithmParameterSpec;
        int effectiveKeyBits = rC2ParameterSpec.getEffectiveKeyBits();
        if (effectiveKeyBits != -1) {
            if (effectiveKeyBits < 256) {
                i = effectiveKeyBits;
                i = faab9e1de[effectiveKeyBits];
            }
            i = effectiveKeyBits;
            this.ff5fb2cfa = i;
        }
        this.ff0b53b2d = rC2ParameterSpec.getIV();
    }

    protected override void EngineInit(byte[] bArr) throws java.io.IOException {
        this.ff0b53b2d = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    protected override void EngineInit(byte[] bArr, java.lang.string str) throws java.io.IOException {
        if (!isASN1Formatstring(str)) {
            if (!str.Equals("RAW")) {
                throw new java.io.IOException("Unknown parameters format in IV parameters object");
            }
            engineInit(bArr);
        } else {
            p5a445d71.p9f931cf3.pca323100.p56fc8961.pce8c4def pce8c4defVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p56fc8961.pce8c4def.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr));
            if (pce8c4defVarM8bab0102.getRC2ParameterVersion() is not null) {
                this.ff5fb2cfa = pce8c4defVarM8bab0102.getRC2ParameterVersion().intValue();
            }
            this.ff0b53b2d = pce8c4defVarM8bab0102.getIV();
        }
    }

    protected override java.lang.string EngineTostring() {
        return "RC2 Parameters";
    }

    protected override java.security.spec.AlgorithmParameterSpec LocalEngineGetParameterSpec(java.lang.Class cls) throws java.security.spec.InvalidParameterSpecException {
        if ((25 + 21) % 21 > 0) {
        }
        if (cls == javax.crypto.spec.RC2ParameterSpec.class || cls == java.security.spec.AlgorithmParameterSpec.class) {
            int i = this.ff5fb2cfa;
            if (i != -1) {
                return i >= 256 ? new javax.crypto.spec.RC2ParameterSpec(this.ff5fb2cfa, this.ff0b53b2d) : new javax.crypto.spec.RC2ParameterSpec(fd3448954[this.ff5fb2cfa], this.ff0b53b2d);
            }
        }
        if (cls != javax.crypto.spec.IvParameterSpec.class) {
            throw new java.security.spec.InvalidParameterSpecException("unknown parameter spec passed to RC2 parameters object.");
        }
        return new javax.crypto.spec.IvParameterSpec(this.ff0b53b2d);
    }
}

