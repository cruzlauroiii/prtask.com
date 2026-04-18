namespace WillowMaze.Wasm.Decompiled;

public class P8fe57a8e : P240d858d
{
    private int F00edd05d;
    private byte[][][] F0c5d229d;
    private pe5cfc515 F0dad9634;
    private byte[] F0e9f39a6;
    private p9b4761a1 F128f7520;
    private int F20b7c688;
    private int[] F3a2e4310;
    private p472adfbb F3b4622d6;
    private pbf954337 F3c6e0b8a;
    private p177006ab F41b02adf;
    private p2ffd3a5d F4b17f825;
    private System.Security.Cryptography.RandomNumberGenerator F56961d96;
    private byte[] F58eae31d;
    private p2ffd3a5d F603ffe08;
    private pe5cfc515 F6852978e;
    private int[] F6a992d55;
    private p2ffd3a5d F6b157112;
    private byte[][] F6bc33694;
    private int F6c47ca6b;
    private int F7210bd77;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private pe5cfc515 F7e39223b;
    private int F87377e8e;
    private p472adfbb F88fc9712;
    private p472adfbb F8a6dd52f;
    private System.Security.Cryptography.RandomNumberGenerator F8e0c6129;
    private int[] F921b04bd;
    private byte[] F9823c34c;
    private byte[] F99b857be;
    private pe5cfc515 Fa2f51144;
    private int[] Fa6463b7b;
    private pe5cfc515 Face58a8f;
    private byte[][][] Faf109273;
    private p2ffd3a5d Fb01a5e2f;
    private System.Security.Cryptography.RandomNumberGenerator Fb718ec09;
    private int Fbc613787;
    private p9b4761a1 Fc9dec9be;
    private int[] Fcb51ee7b;
    private byte[] Fcc235d8e;
    private byte[][] Fcd872394;
    private pb23b88d7 Fce6c6a36;
    private pb23b88d7 Fd007ea3d;
    private pbf954337 Fd39b4bd4;
    private p177006ab Fd9b26f80;
    private int Fd9d5bc1e;
    private pe5cfc515 Fddf1ebaf;
    private p177006ab Fe1e57f49;
    private p2ffd3a5d Feba85522;
    private int Ff8cf6753;

    private void M239b22ba()
    {
        // str: "Private key already used"
        // str: "No more signatures can be generated"
        // call: p77f57b29.getSubtreeRootSig
        // call: pb23b88d7.get
        // call: IllegalStateException.<init>
        // call: pe5cfc515.reset
        // call: p77f57b29.getParameters
        // call: p77f57b29.getIndex
        // call: p2ffd3a5d.getNumOfLayers
        // call: System.arraycopy
        // call: p77f57b29.getCurrentSeeds
        // call: p77f57b29.getNumLeafs
        // call: p77f57b29.getCurrentAuthPaths
        // call: p472adfbb.<init>
        // call: p2ffd3a5d.getWinternitzParameter
        // call: p77f57b29.markUsed
        // call: p77f57b29.isUsed
        // call: p177006ab.nextSeed
        // call: Array.newInstance
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.faf109273
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f603ffe08
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f0dad9634
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.ff8cf6753
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f6bc33694
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f6a992d55
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.fbc613787
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.fce6c6a36
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f3b4622d6
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f41b02adf
        // field: java.lang.Byte.TYPE
        // type: p472adfbb
        // type: IllegalStateException
    }

    private void M8f7fe6c1()
    {
        // call: p400145e8.getParameters
        // call: p400145e8.getPublicKey
        // call: p2ffd3a5d.getNumOfLayers
        // call: pe5cfc515.reset
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f9823c34c
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.fbc613787
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f0dad9634
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f603ffe08
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f3c6e0b8a
    }

    public byte[] GenerateSignature(byte[] P0)
    {
        // call: System.arraycopy
        // call: p9b4761a1.concatenateArray
        // call: p9b4761a1.intToBytesLittleEndian
        // call: p472adfbb.getSignature
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.ff8cf6753
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f128f7520
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.fbc613787
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f6a992d55
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.faf109273
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f3b4622d6
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f6bc33694
        return default!;
    }

    public void Init(bool P0, pc9ef6b45 P1)
    {
        // call: p8fe57a8e.m8f7fe6c1
        // call: p4715f007.getRandom
        // call: pa9682fb5.m07091bf1
        // call: p8fe57a8e.m239b22ba
        // call: p4715f007.getParameters
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f3c6e0b8a
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f7ddf32e1
    }

    public bool VerifySignature(byte[] P0, byte[] P1)
    {
        // str: "OTS Public Key is null in GMSSSignature.verify"
        // call: pb23b88d7.get
        // call: paed5a8bc.Verify
        // call: TextWriter.println
        // call: pe5cfc515.update
        // call: p2ffd3a5d.getHeightOfTrees
        // call: System.arraycopy
        // call: pe5cfc515.reset
        // call: p9b4761a1.bytesToIntLittleEndian
        // call: p2ffd3a5d.getWinternitzParameter
        // call: paed5a8bc.getSignatureLength
        // call: pff43b8de.m2a3f81d2
        // call: pe5cfc515.getDigestSize
        // call: Array.newInstance
        // call: paed5a8bc.<init>
        // call: pe5cfc515.doFinal
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f6852978e
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f0dad9634
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.fce6c6a36
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.ff8cf6753
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.fbc613787
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f9823c34c
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f128f7520
        // field: java.lang.System.err
        // field: java.lang.Byte.TYPE
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p8fe57a8e.f603ffe08
        // type: paed5a8bc
        return false;
    }

}
