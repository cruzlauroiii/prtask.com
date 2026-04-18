namespace WillowMaze.Wasm.Decompiled;

public class P3935a66f : P240d858d
{
    private static int F610661f4;
    private static int F98287da5;
    private static int Fc4c45c62;
    private short[] F3b183806;
    private p7054151d F3c6e0b8a;
    private p76fc445d F4e29342d;
    private int F54aae9fb;
    private p7054151d F695cd1cd;
    private short[] F6a2ec663;
    private p7054151d F6afa000d;
    private int F6bd2a397;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private p76fc445d F81efa620;
    private short[] F9dd4e461;
    private int Fa5b8281e;
    private p76fc445d Fc36c9c6b;
    private System.Security.Cryptography.RandomNumberGenerator Fee663c29;

    private short[] M239b22ba(p359b71e8[] P0, short[] P1)
    {
        // call: p359b71e8.getVi
        // call: p490616be.getB1
        // call: p490616be.getInvA1
        // call: System.Security.Cryptography.RandomNumberGenerator.nextInt
        // call: p76fc445d.addVect
        // call: p76fc445d.multiplyMatrix
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f.f4e29342d
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f.f9dd4e461
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f.f7ddf32e1
        return default!;
    }

    private short[] M9a5f6e44(byte[] P0)
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f.f6bd2a397
        return default!;
    }

    private short[] Mb282a0ce(short[] P0)
    {
        // call: p7c9fdbf6.m77ea3ce0
        // call: p53a99402.getCoeffSingular
        // call: p7c9fdbf6.m029bd47b
        // call: p53a99402.getCoeffQuadratic
        // call: p53a99402.getCoeffScalar
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f.f3c6e0b8a
        return default!;
    }

    public byte[] GenerateSignature(byte[] P0)
    {
        // str: "LES is not solveable!"
        // str: "unable to generate signature - LES not solvable"
        // call: IllegalStateException.<init>
        // call: p359b71e8.getViNext
        // call: p3935a66f.m239b22ba
        // call: p359b71e8.getOi
        // call: p359b71e8.plugInVinegars
        // call: p76fc445d.solveEquation
        // call: p359b71e8.getVi
        // call: Exception.<init>
        // call: p490616be.getB2
        // call: p76fc445d.addVect
        // call: p490616be.getInvA2
        // call: p76fc445d.multiplyMatrix
        // call: p490616be.getLayers
        // call: p3935a66f.m9a5f6e44
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f.f4e29342d
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f.f9dd4e461
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f.f3c6e0b8a
        // type: Exception
        // type: IllegalStateException
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: pa9682fb5.m07091bf1
        // call: p4715f007.getParameters
        // call: p4715f007.getRandom
        // call: p7054151d.getDocLength
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f.f7ddf32e1
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p3935a66f.f6bd2a397
    }

    public bool VerifySignature(byte[] P0, byte[] P1)
    {
        // call: p3935a66f.mb282a0ce
        // call: p3935a66f.m9a5f6e44
        return false;
    }

}
