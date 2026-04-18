namespace WillowMaze.Wasm.Decompiled;

public class P51f14de8 : Pd69ee98f
{
    private byte[] F0968a2be;
    private byte[] F22328b7f;
    private p73c5877c F48c52d31;
    private pd0a4c378 F502b7b52;
    private pd0a4c378 F5561db6e;
    private pd0a4c378 F5ba32052;
    private p73c5877c F63ab53e0;
    private byte[] Fb4a88417;
    private pd0a4c378 Fbc456f22;
    private byte[] Fce0c2567;
    private pd0a4c378 Ff981082a;

    private static pcfffbc4a Mb2339da8(Key P0)
    {
        // str: "cannot identify XDH private key"
        // call: p339a599c.engineGetKeyParameters
        // call: InvalidKeyException.<init>
        // type: InvalidKeyException
        return default!;
    }

    private pd0a4c378 Mc006f45b(string P0)
    {
        // str: "14af9f78e008aaf5e6c5b108cd6d4ffe1d7ddb969d278fd969fa22b77f6c9395"
        // str: "XDH"
        // str: "inappropriate key for "
        // call: DecryptString.decryptString
        // call: string.startsWith
        // call: string.equals
        // call: StringBuilder.append
        // call: pe78a3bad.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: string.indexOf
        // call: p481a2391.<init>
        // call: InvalidKeyException.<init>
        // call: pb5032159.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.f0d7f1a76
        // type: InvalidKeyException
        // type: p481a2391
        // type: pb5032159
        // type: pe78a3bad
        // type: StringBuilder
        return default!;
    }

    private pcfffbc4a Mea3b0e4f(Key P0)
    {
        // str: "cannot identify XDH public key"
        // call: InvalidKeyException.<init>
        // call: pd4b4a290.engineGetKeyParameters
        // type: InvalidKeyException
        return default!;
    }

    private byte[] CalcSecret()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.fb4a88417
        return default!;
    }

    private Key EngineDoPhase(Key P0, bool P1)
    {
        // str: " not initialised."
        // str: " can only be between two parties."
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: IllegalStateException.<init>
        // call: p51f14de8.mea3b0e4f
        // call: pd0a4c378.getAgreementSize
        // call: pd0a4c378.calculateAgreement
        // call: StringBuilder.<init>
        // call: pd4b4a290.engineGetKeyParameters
        // call: p5b6165f0.<init>
        // call: p73c5877c.getOtherPartyEphemeralKey
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.fb4a88417
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.f48c52d31
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.f5ba32052
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.f0d7f1a76
        // type: StringBuilder
        // type: IllegalStateException
        // type: p5b6165f0
        return default!;
    }

    private void EngineInit(Key P0, System.Security.Cryptography.RandomNumberGenerator P1)
    {
        // str: "unsupported private key type"
        // str: "ff886a3bc6ddbc31c01b2c3151a886ddca96d2bbbab17f755258e5a048269a567fe0"
        // str: "2d9113fe991141a0ebe2480ec4b5894060d3feccc572494c9646579a10cb002a"
        // call: p51f14de8.mb2339da8
        // call: p51f14de8.mc006f45b
        // call: pd0a4c378.init
        // call: DecryptString.decryptString
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.f5ba32052
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.f53f67e05
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.f168e7cba
        // type: IllegalStateException
    }

    private void EngineInit(Key P0, AlgorithmParameterSpec P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "3449b88cbaf6f800dc24176864932b005291a26345a34f4be1f1a54e81f9e4fd099e"
        // str: "unsupported private key type"
        // str: "unknown ParameterSpec"
        // str: "no KDF specified for UserKeyingMaterialSpec"
        // str: "agreement algorithm not DHU based"
        // str: "a9028ee85ca6cd079024ec0c8d4ff9f77b1e116453529b8db3fcf22492877256"
        // call: pd4b4a290.engineGetKeyParameters
        // call: InvalidAlgorithmParameterException.<init>
        // call: pd0a4c378.init
        // call: p191b2363.<init>
        // call: p73c5877c.getEphemeralPublicKey
        // call: DecryptString.decryptString
        // call: p73c5877c.getUserKeyingMaterial
        // call: p73c5877c.getEphemeralPrivateKey
        // call: p51f14de8.mc006f45b
        // call: IllegalStateException.<init>
        // call: p51f14de8.mb2339da8
        // call: string.indexOf
        // call: p2b44c653.getUserKeyingMaterial
        // call: p339a599c.engineGetKeyParameters
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.f5ba32052
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.f0d7f1a76
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.f53f67e05
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.f168e7cba
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdbd28212.p51f14de8.f48c52d31
        // type: p191b2363
        // type: InvalidAlgorithmParameterException
        // type: IllegalStateException
    }

}
