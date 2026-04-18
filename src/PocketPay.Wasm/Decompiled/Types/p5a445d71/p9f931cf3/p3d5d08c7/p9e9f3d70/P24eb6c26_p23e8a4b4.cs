namespace WillowMaze.Wasm.Decompiled;

public class P24eb6c26_p23e8a4b4
{
    private static pc953f774 M355a87ae(int P0, int P1)
    {
        // str: "PKCS5 scheme 1 only supports only MD5 and SHA1."
        // str: "unknown digest scheme for PBE encryption."
        // call: IllegalStateException.<init>
        // call: pc267ca5e.<init>
        // call: p507fcd3d.<init>
        // call: p9cd0c098.<init>
        // call: pd504875c.<init>
        // call: p6bae849a.<init>
        // call: p5a6470c8.<init>
        // call: p5ee360bc.<init>
        // type: p5a6470c8
        // type: p507fcd3d
        // type: pd504875c
        // type: p9cd0c098
        // type: p6bae849a
        // type: p5ee360bc
        // type: pc267ca5e
        // type: IllegalStateException
        return default!;
    }

    private static void M50f0e52c(byte[] P0)
    {
    }

    private static pc9ef6b45 M61af3b8e(p51ebc4fd P0, AlgorithmParameterSpec P1, int P2, int P3, int P4)
    {
        // str: "Need a PBEParameter spec with a PBE key."
        // call: IllegalArgumentException.<init>
        // call: PBEParameterSpec.getIterationCount
        // call: pc953f774.generateDerivedMacParameters
        // call: p24eb6c26$p23e8a4b4.m355a87ae
        // call: p51ebc4fd.getEncoded
        // call: pc953f774.init
        // call: PBEParameterSpec.getSalt
        // type: IllegalArgumentException
        return default!;
    }

    private static pc9ef6b45 Mdc3b2368(p51ebc4fd P0, AlgorithmParameterSpec P1, int P2, int P3, string P4, int P5, int P6)
    {
        // str: "Need a PBEParameter spec with a PBE key."
        // str: "DES"
        // call: p24eb6c26$p23e8a4b4.m50f0e52c
        // call: IllegalArgumentException.<init>
        // call: p94919be6.getKey
        // call: PBEParameterSpec.getSalt
        // call: pdd5da44e.getParameters
        // call: pc953f774.generateDerivedParameters
        // call: pc953f774.init
        // call: string.startsWith
        // call: p24eb6c26$p23e8a4b4.m355a87ae
        // call: p51ebc4fd.getEncoded
        // call: PBEParameterSpec.getIterationCount
        // type: IllegalArgumentException
        return default!;
    }

}
