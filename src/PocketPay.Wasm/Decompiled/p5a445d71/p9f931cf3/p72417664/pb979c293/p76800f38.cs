namespace WillowMaze.Wasm.Decompiled;


public class p76800f38 : java.security.spec.AlgorithmParameterSpec {
    private readonly java.lang.string f0eed4159;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f392bf8da;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f3f4e6636;
    private readonly java.lang.string f63e73c44;
    private byte[] f668f728d;
    private readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f70e912b5;
    private byte[] f7cff3120;
    private readonly int f840b67b6;
    private byte[] f8b96f217;
    private readonly java.security.spec.AlgorithmParameterSpec f911c0578;
    private readonly java.lang.string fa21ec2a1;
    private readonly int fa694c87d;
    private byte[] faf9f078a;
    private readonly java.security.spec.AlgorithmParameterSpec fbb51aec2;
    private readonly java.lang.string fdaa210a1;
    private readonly java.lang.string ff693e3b2;
    private byte[] ffdce7a34;

    private p76800f38(java.lang.string str, int i, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr) {
        this.f63e73c44 = str;
        this.fa694c87d = i;
        this.fbb51aec2 = algorithmParameterSpec;
        this.f392bf8da = p234a7530Var;
        this.ffdce7a34 = bArr;
    }

    p76800f38(java.lang.string str, int i, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr, p5a445d71.p9f931cf3.p72417664.pb979c293.p76800f38$1 p76800f38_1) {
        this(str, i, algorithmParameterSpec, p234a7530Var, bArr);
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetKdfAlgorithm() {
        return this.f392bf8da;
    }

    public java.lang.string GetKeyAlgorithmName() {
        return this.f63e73c44;
    }

    public int GetKeySize() {
        return this.fa694c87d;
    }

    public byte[] GetOtherInfo() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ffdce7a34);
    }

    public java.security.spec.AlgorithmParameterSpec GetParameterSpec() {
        return this.fbb51aec2;
    }
}

