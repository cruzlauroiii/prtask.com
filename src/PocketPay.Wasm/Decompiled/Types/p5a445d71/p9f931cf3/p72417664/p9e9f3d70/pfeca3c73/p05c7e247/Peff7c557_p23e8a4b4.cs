namespace WillowMaze.Wasm.Decompiled;

public class Peff7c557_p23e8a4b4
{
    private static pc953f774 M355a87ae(int P0, int P1)
    {
        // str: "PKCS5 scheme 1 only supports MD2, MD5 and SHA1."
        // str: "unknown digest scheme for PBE encryption."
        // str: "unknown digest scheme for PBE PKCS5S2 encryption."
        // call: p5420ac2a.<init>
        // call: p5ee360bc.<init>
        // call: p507fcd3d.<init>
        // call: p6bae849a.<init>
        // call: p92e20001.m60b1d416
        // call: IllegalStateException.<init>
        // call: p92e20001.m034c69f6
        // call: p92e20001.mee6316ec
        // call: p52acb772.<init>
        // call: p92e20001.mfa074ee9
        // call: p92e20001.m1ff9fef3
        // call: p92e20001.ma500566e
        // call: p92e20001.mdd18c262
        // call: p3c5fe95b.<init>
        // call: p11735585.<init>
        // call: p92e20001.mb3a0b8e3
        // call: pb83f940f.<init>
        // call: p92e20001.ma2ec586b
        // call: pc267ca5e.<init>
        // call: p92e20001.m15ae841e
        // type: IllegalStateException
        // type: p507fcd3d
        // type: pc267ca5e
        // type: p52acb772
        // type: p5ee360bc
        // type: p6bae849a
        // type: p5420ac2a
        // type: pb83f940f
        // type: p11735585
        // type: p3c5fe95b
        return default!;
    }

    private static byte[] M3dbfc216(int P0, PBEKeySpec P1)
    {
        // call: pc953f774.md3e9f7cd
        // call: PBEKeySpec.getPassword
        // call: pc953f774.m1e403689
        // call: pc953f774.m7cb57dae
        return default!;
    }

    public static pc9ef6b45 M61af3b8e(SecretKey P0, int P1, int P2, int P3, PBEParameterSpec P4)
    {
        // call: pc953f774.generateDerivedMacParameters
        // call: SecretKey.getEncoded
        // call: PBEParameterSpec.getIterationCount
        // call: PBEParameterSpec.getSalt
        // call: pc953f774.init
        // call: peff7c557$p23e8a4b4.m355a87ae
        return default!;
    }

    public static pc9ef6b45 M61af3b8e(PBEKeySpec P0, int P1, int P2, int P3)
    {
        // call: peff7c557$p23e8a4b4.m355a87ae
        // call: peff7c557$p23e8a4b4.m3dbfc216
        // call: PBEKeySpec.getIterationCount
        // call: pc953f774.generateDerivedMacParameters
        // call: PBEKeySpec.getSalt
        // call: pc953f774.init
        return default!;
    }

    public static pc9ef6b45 M61af3b8e(p51ebc4fd P0, AlgorithmParameterSpec P1)
    {
        // str: "Need a PBEParameter spec with a PBE key."
        // call: p51ebc4fd.getDigest
        // call: peff7c557$p23e8a4b4.m355a87ae
        // call: p51ebc4fd.getEncoded
        // call: p51ebc4fd.getType
        // call: PBEParameterSpec.getSalt
        // call: PBEParameterSpec.getIterationCount
        // call: p51ebc4fd.getKeySize
        // call: pc953f774.init
        // call: IllegalArgumentException.<init>
        // call: pc953f774.generateDerivedMacParameters
        // type: IllegalArgumentException
        return default!;
    }

    public static pc9ef6b45 Mdc3b2368(PBEKeySpec P0, int P1, int P2, int P3, int P4)
    {
        // call: pc953f774.generateDerivedParameters
        // call: peff7c557$p23e8a4b4.m3dbfc216
        // call: PBEKeySpec.getIterationCount
        // call: pc953f774.init
        // call: PBEKeySpec.getSalt
        // call: peff7c557$p23e8a4b4.m355a87ae
        return default!;
    }

    public static pc9ef6b45 Mdc3b2368(p51ebc4fd P0, AlgorithmParameterSpec P1, string P2)
    {
        // str: "Need a PBEParameter spec with a PBE key."
        // str: "DES"
        // call: p83bdc664.m50f0e52c
        // call: IllegalArgumentException.<init>
        // call: p51ebc4fd.shouldTryWrongPKCS12
        // call: p94919be6.getKey
        // call: p51ebc4fd.getEncoded
        // call: p51ebc4fd.getKeySize
        // call: p51ebc4fd.getDigest
        // call: pc953f774.init
        // call: PBEParameterSpec.getIterationCount
        // call: pc953f774.generateDerivedParameters
        // call: peff7c557$p23e8a4b4.m355a87ae
        // call: p51ebc4fd.getType
        // call: p51ebc4fd.getIvSize
        // call: string.startsWith
        // call: PBEParameterSpec.getSalt
        // call: pdd5da44e.getParameters
        // type: IllegalArgumentException
        return default!;
    }

    public static pc9ef6b45 Mdc3b2368(byte[] P0, int P1, int P2, int P3, int P4, AlgorithmParameterSpec P5, string P6)
    {
        // str: "Need a PBEParameter spec with a PBE key."
        // str: "DES"
        // call: peff7c557$p23e8a4b4.m355a87ae
        // call: p83bdc664.m50f0e52c
        // call: PBEParameterSpec.getSalt
        // call: p94919be6.getKey
        // call: InvalidAlgorithmParameterException.<init>
        // call: pdd5da44e.getParameters
        // call: string.startsWith
        // call: PBEParameterSpec.getIterationCount
        // call: pc953f774.init
        // call: pc953f774.generateDerivedParameters
        // type: InvalidAlgorithmParameterException
        return default!;
    }

}
