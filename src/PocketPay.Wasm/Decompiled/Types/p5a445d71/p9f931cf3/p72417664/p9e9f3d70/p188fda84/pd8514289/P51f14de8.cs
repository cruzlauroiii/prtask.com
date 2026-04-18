namespace WillowMaze.Wasm.Decompiled;

public class P51f14de8 : Pd69ee98f
{
    private static pb79a74f5 F0ea7dd4d;
    private static pb79a74f5 F456be8b2;
    private static pb79a74f5 F4e907883;
    private static pb79a74f5 F86c19695;
    private static pb79a74f5 Fde69c0b7;
    private p21c2eb74 F0178fb54;
    private string F0d7f1a76;
    private p21c2eb74 F166e64f6;
    private string F2cfd623f;
    private string F38604adb;
    private p21c2eb74 F4c7d758a;
    private p52f19097 F5ba32052;
    private string F76b9a7e5;
    private p52f19097 F8a3077b2;
    private byte[] Fb4a88417;
    private p52f19097 Fbb9c5e27;
    private p21c2eb74 Fbc38008e;
    private byte[] Fcda5e2d7;

    private static pcfffbc4a Mc2499d21(PublicKey P0)
    {
        // call: p5d6836ed.engineGetKeyParameters
        // call: p37c4833e.mc2499d21
        return default!;
    }

    private static string Md5d22d18(Type P0)
    {
        // call: string.substring
        // call: Type.getName
        // call: string.lastIndexOf
        return string.Empty;
    }

    private void Mf8ac9c82(Key P0, AlgorithmParameterSpec P1)
    {
        // str: " key agreement requires "
        // str: " for initialisation"
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p52f19097.init
        // call: p473e31bf.<init>
        // call: p2b44c653.getUserKeyingMaterial
        // call: p37c4833e.m02ea6360
        // call: p51f14de8.md5d22d18
        // call: p06022b5a.getParameters
        // call: InvalidKeyException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p51f14de8.f166e64f6
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p51f14de8.f0d7f1a76
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p51f14de8.f5ba32052
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p51f14de8.f53f67e05
        // type: p5eff85bc
        // type: InvalidKeyException
        // type: p473e31bf
        // type: StringBuilder
    }

    private byte[] CalcSecret()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p51f14de8.fb4a88417
        return default!;
    }

    private Key EngineDoPhase(Key P0, bool P1)
    {
        // str: " not initialised."
        // str: " for doPhase"
        // str: " key agreement requires "
        // str: "calculation failed: "
        // str: " can only be between two parties."
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: Exception.getMessage
        // call: p51f14de8.md5d22d18
        // call: IllegalStateException.<init>
        // call: p51f14de8$1.<init>
        // call: p51f14de8.mc2499d21
        // call: p52f19097.calculateAgreement
        // call: InvalidKeyException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p51f14de8.f0d7f1a76
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p51f14de8.f5ba32052
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p51f14de8.fb4a88417
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pd8514289.p51f14de8.f166e64f6
        // type: pe256531b
        // type: StringBuilder
        // type: IllegalStateException
        // type: InvalidKeyException
        // type: p51f14de8$1
        return default!;
    }

    private void EngineInit(Key P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // call: p51f14de8.mf8ac9c82
    }

    private void EngineInit(Key P0, AlgorithmParameterSpec P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "No algorithm parameters supported"
        // call: p51f14de8.mf8ac9c82
        // call: InvalidAlgorithmParameterException.<init>
        // type: InvalidAlgorithmParameterException
    }

}
