namespace WillowMaze.Wasm.Decompiled;

public class P51f14de8 : Pd69ee98f
{
    private static pb79a74f5 F0ea7dd4d;
    private static pb79a74f5 F22163c96;
    private static pb79a74f5 F70a256c4;
    private static pb79a74f5 F9bcb61a2;
    private static pb79a74f5 Fe102dd79;
    private p52f19097 F01d6dd57;
    private byte[] F09d2bf3f;
    private string F0d7f1a76;
    private p21c2eb74 F166e64f6;
    private p21c2eb74 F1b13a94f;
    private p52f19097 F21745f24;
    private string F451e5e27;
    private byte[] F4afa913f;
    private p52f19097 F5ba32052;
    private byte[] F720e5b06;
    private byte[] Fb4a88417;
    private p52f19097 Fb85bf3c0;
    private p21c2eb74 Fbc0f8935;
    private p21c2eb74 Fd9d98c92;
    private p52f19097 Fe80ef467;
    private p21c2eb74 Ff54d6067;

    private static pcfffbc4a Mc2499d21(PublicKey P0)
    {
        // call: p37c4833e.mc2499d21
        // call: pecf68685.engineGetKeyParameters
        return default!;
    }

    private static string Md5d22d18(Type P0)
    {
        // call: string.lastIndexOf
        // call: string.substring
        // call: Type.getName
        return string.Empty;
    }

    private void Mf8ac9c82(Key P0, AlgorithmParameterSpec P1)
    {
        // str: " for initialisation"
        // str: " key agreement requires "
        // call: StringBuilder.toString
        // call: p37c4833e.m02ea6360
        // call: StringBuilder.append
        // call: p473e31bf.<init>
        // call: p52f19097.init
        // call: p51f14de8.md5d22d18
        // call: InvalidKeyException.<init>
        // call: StringBuilder.<init>
        // call: p06022b5a.getParameters
        // call: p2b44c653.getUserKeyingMaterial
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p51f14de8.f5ba32052
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p51f14de8.f53f67e05
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p51f14de8.f0d7f1a76
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p51f14de8.f166e64f6
        // type: p473e31bf
        // type: InvalidKeyException
        // type: StringBuilder
        // type: p5eff85bc
    }

    private byte[] CalcSecret()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p51f14de8.fb4a88417
        return default!;
    }

    private Key EngineDoPhase(Key P0, bool P1)
    {
        // str: "calculation failed: "
        // str: " key agreement requires "
        // str: " not initialised."
        // str: " for doPhase"
        // str: " can only be between two parties."
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: p51f14de8.md5d22d18
        // call: p51f14de8$1.<init>
        // call: IllegalStateException.<init>
        // call: p51f14de8.mc2499d21
        // call: p52f19097.calculateAgreement
        // call: InvalidKeyException.<init>
        // call: Exception.getMessage
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p51f14de8.f0d7f1a76
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p51f14de8.f5ba32052
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p51f14de8.fb4a88417
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p51f14de8.f166e64f6
        // type: IllegalStateException
        // type: StringBuilder
        // type: p51f14de8$1
        // type: pe256531b
        // type: InvalidKeyException
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
