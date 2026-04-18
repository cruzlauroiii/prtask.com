namespace WillowMaze.Wasm.Decompiled;

public class P63daa24a
{
    private static pb9fa8367 F65f12f6a;
    private static pb9fa8367 F89db80a5;
    private static Dictionary<string, object> F988ae871;
    private static Dictionary<string, object> F9e600621;
    private static Dictionary<string, object> Fb08d162a;
    private static Dictionary<string, object> Feb3985dd;

    private static string M15b600f8(p364bf33a P0)
    {
        // str: "SHA3"
        // call: p45eb53fe.mba8d3a36
        // call: string.startsWith
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: string.substring
        // call: StringBuilder.append
        // call: string.indexOf
        // type: StringBuilder
        return string.Empty;
    }

    private static void M2db390b9(byte[] P0, StringBuilder P1, string P2)
    {
        // str: "                       "
        // str: "            Signature: "
        // call: p92640bd7.m81519f2a
        // call: StringBuilder.append
    }

    private static string M38467eb2(Provider P0, p364bf33a P1)
    {
        // str: "Alg.Alias.Signature.OID."
        // str: "Alg.Alias.Signature."
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: Provider.getProperty
        // type: StringBuilder
        return string.Empty;
    }

    private static void M666068eb(Signature P0, p0fd1bdf1 P1)
    {
        // str: "IOException decoding parameters: "
        // str: "facc3bff5787d4a787f7a12a2c3fef821332d09c741fc26e38efbe70301dc2b2"
        // str: "Exception extracting parameters: "
        // call: StringBuilder.toString
        // call: GeneralSecurityException.getMessage
        // call: StringBuilder.<init>
        // call: Signature.getAlgorithm
        // call: StringBuilder.append
        // call: AlgorithmParameters.getInstance
        // call: p0fd1bdf1.toASN1Primitive
        // call: p301c7ed4.getEncoded
        // call: AlgorithmParameters.init
        // call: SignatureException.<init>
        // call: DecryptString.decryptString
        // call: string.endsWith
        // call: IOException.getMessage
        // call: Signature.getProvider
        // call: pb9fa8367.equals
        // call: AlgorithmParameters.getParameterSpec
        // call: Signature.setParameter
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.f89db80a5
        // type: StringBuilder
        // type: SignatureException
        // type: PSSParameterSpec
    }

    private static string M6d7cc104(p234a7530 P0)
    {
        // str: "withECDSA"
        // str: "withRSAandMGF1"
        // call: p364bf33a.equals
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p63daa24a.m15b600f8
        // call: pfa0321ce.getHashAlgorithm
        // call: p234a7530.getAlgorithm
        // call: p234a7530.getParameters
        // call: p80f8c729.getObjectAt
        // call: StringBuilder.<init>
        // call: Dictionary<string, object>.get
        // call: p63daa24a.mbf389016
        // call: pb9fa8367.equals
        // call: pfa0321ce.m8bab0102
        // call: p80f8c729.m8bab0102
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.f89db80a5
        // field: p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.f3b0e454b
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.f9e600621
        // type: StringBuilder
        return string.Empty;
    }

    private static bool M98b32efc(p234a7530 P0)
    {
        // call: p234a7530.getAlgorithm
        // call: p364bf33a.equals
        // field: p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.fb2b1f738
        return false;
    }

    private static string Mbf389016(p364bf33a P0)
    {
        // str: "a91181abed4cd4afca78a8799750e2b9285545e7de186838635e3f78618e"
        // call: p63daa24a.m38467eb2
        // call: DecryptString.decryptString
        // call: p364bf33a.getId
        // call: Security.getProvider
        // call: Security.getProviders
        return string.Empty;
    }

}
