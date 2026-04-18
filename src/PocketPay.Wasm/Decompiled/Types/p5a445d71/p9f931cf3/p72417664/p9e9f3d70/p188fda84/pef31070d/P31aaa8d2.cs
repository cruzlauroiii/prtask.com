namespace WillowMaze.Wasm.Decompiled;

public class P31aaa8d2 : P0529b267
{
    private AlgorithmParameters F03957e2d;
    private p42a46bbe F08406a6e;
    private AlgorithmParameters F20c904fb;
    private AlgorithmParameterSpec F29fa4215;
    private AlgorithmParameterSpec F303fde02;
    private bool F3247ce79;
    private AlgorithmParameterSpec F50dd2d7c;
    private p42a46bbe F71aa2be1;
    private AlgorithmParameterSpec F7f147658;
    private bool F8c2d8443;
    private p42a46bbe Fa97078c7;
    private p0529b267$pf0d24f46 Faed90dde;
    private p42a46bbe Fb9319c5b;
    private readonly pb3b7fb02 Fb97c689f;
    private bool Fcca896c4;
    private bool Fce26c9ef;
    private p42a46bbe Fd42c23ce;
    private AlgorithmParameterSpec Fd656ade4;
    private bool Fed414023;
    private p0529b267$pf0d24f46 Ff55b8df9;
    private readonly pb3b7fb02 Ffde5d67b;

    private void M8872f202(OAEPParameterSpec P0)
    {
        // str: "no match on OAEP constructor for digest algorithm: "
        // call: pa06e6d1d.<init>
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: MGF1ParameterSpec.getDigestAlgorithm
        // call: StringBuilder.toString
        // call: OAEPParameterSpec.getPSource
        // call: p9d452d94.<init>
        // call: NoSuchPaddingException.<init>
        // call: p92e20001.me0825354
        // call: PSource$PSpecified.getValue
        // call: OAEPParameterSpec.getMGFParameters
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f303fde02
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f08406a6e
        // type: StringBuilder
        // type: NoSuchPaddingException
        // type: p9d452d94
        // type: pa06e6d1d
    }

    private byte[] Me09f6787()
    {
        // str: "unable to decrypt block"
        // call: p0529b267$pf0d24f46.erase
        // call: pec7a0e67.<init>
        // call: p0529b267$pf0d24f46.getBuf
        // call: p0529b267$pf0d24f46.size
        // call: p42a46bbe.processBlock
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.ff55b8df9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f08406a6e
        // type: pec7a0e67
        return default!;
    }

    private int EngineDoFinal(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "too much data for RSA block"
        // str: "output buffer too short for input."
        // call: p42a46bbe.getInputBlockSize
        // call: p0529b267$pf0d24f46.write
        // call: ShortBufferException.<init>
        // call: p31aaa8d2.me09f6787
        // call: p31aaa8d2.engineGetOutputSize
        // call: p0529b267$pf0d24f46.size
        // call: ArrayIndexOutOfBoundsException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.ff55b8df9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f08406a6e
        // type: ArrayIndexOutOfBoundsException
        // type: ShortBufferException
        return 0;
    }

    private byte[] EngineDoFinal(byte[] P0, int P1, int P2)
    {
        // str: "too much data for RSA block"
        // call: ArrayIndexOutOfBoundsException.<init>
        // call: p31aaa8d2.me09f6787
        // call: p42a46bbe.getInputBlockSize
        // call: p0529b267$pf0d24f46.write
        // call: p0529b267$pf0d24f46.size
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.ff55b8df9
        // type: ArrayIndexOutOfBoundsException
        return default!;
    }

    private int EngineGetBlockSize()
    {
        // str: "RSA Cipher not initialised"
        // call: p42a46bbe.getInputBlockSize
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f08406a6e
        // type: IllegalStateException
        return 0;
    }

    private int EngineGetKeySize(Key P0)
    {
        // str: "not an RSA key!"
        // call: RSAPublicKey.getModulus
        // call: RSAPrivateKey.getModulus
        // call: System.Numerics.BigInteger.bitLength
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return 0;
    }

    private int EngineGetOutputSize(int P0)
    {
        // str: "RSA Cipher not initialised"
        // call: p42a46bbe.getOutputBlockSize
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f08406a6e
        // type: IllegalStateException
        return 0;
    }

    private AlgorithmParameters EngineGetParameters()
    {
        // str: "OAEP"
        // call: Exception.<init>
        // call: Exception.toString
        // call: pb3b7fb02.createAlgorithmParameters
        // call: AlgorithmParameters.init
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.ffde5d67b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f20c904fb
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f303fde02
        // type: Exception
        return default!;
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameters P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "cannot recognise parameters: "
        // call: StringBuilder.<init>
        // call: InvalidParameterSpecException.toString
        // call: StringBuilder.append
        // call: InvalidAlgorithmParameterException.<init>
        // call: p31aaa8d2.engineInit
        // call: StringBuilder.toString
        // call: AlgorithmParameters.getParameterSpec
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f20c904fb
        // type: InvalidAlgorithmParameterException
        // type: OAEPParameterSpec
        // type: StringBuilder
    }

    private void EngineInit(int P0, Key P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // str: "Eeeek! "
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: InvalidAlgorithmParameterException.toString
        // call: InvalidKeyException.<init>
        // call: p31aaa8d2.engineInit
        // call: StringBuilder.toString
        // type: StringBuilder
        // type: InvalidKeyException
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameterSpec P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: " passed to RSA"
        // str: "unknown opmode "
        // str: "no match on MGF digest algorithm: "
        // str: "unknown parameter type: "
        // str: "78da444882d92c4c6700cf443b7e2b249006b66acb3cc89c0212522b09c0ddc8"
        // str: "no match on digest algorithm: "
        // str: "unknown mask generation function specified"
        // str: "unknown key type passed to RSA"
        // str: "mode 1 requires RSAPrivateKey"
        // str: "mode 2 requires RSAPublicKey"
        // str: "unkown MGF parameters"
        // call: MGF1ParameterSpec.getDigestAlgorithm
        // call: pf3488fc4.m02ea6360
        // call: StringBuilder.append
        // call: InvalidAlgorithmParameterException.<init>
        // call: DecryptString.decryptString
        // call: StringBuilder.<init>
        // call: PSource$PSpecified.getValue
        // call: p92e20001.me0825354
        // call: StringBuilder.toString
        // call: pf3488fc4.mc2499d21
        // call: p42a46bbe.init
        // call: object.getClass
        // call: OAEPParameterSpec.getMGFParameters
        // call: pa9682fb5.m07091bf1
        // call: InvalidKeyException.<init>
        // call: p4715f007.<init>
        // call: OAEPParameterSpec.getPSource
        // call: p0529b267$pf0d24f46.reset
        // call: Type.getName
        // call: OAEPParameterSpec.getDigestAlgorithm
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f303fde02
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.ff55b8df9
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.fce26c9ef
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f3247ce79
        // type: StringBuilder
        // type: p4715f007
        // type: pa06e6d1d
        // type: InvalidKeyException
        // type: InvalidParameterException
        // type: InvalidAlgorithmParameterException
        // type: p9d452d94
    }

    private void EngineSetMode(string P0)
    {
        // str: "082c952cc4c84974f0eab1eb6fb4c5c7ccefb196c421e583591496c520"
        // str: "2c272194b4d1720a259f66ee67cc2fddebd33da3714d680583078142abc1f204"
        // str: "d4d3d1444d8a8859042420ca7d641ff85c6b1445fa677e9ad146565732"
        // str: "can't support mode "
        // str: "ECB"
        // call: string.equals
        // call: DecryptString.decryptString
        // call: NoSuchAlgorithmException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p89be9433.mb8a8247c
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.fce26c9ef
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f3247ce79
        // type: NoSuchAlgorithmException
        // type: StringBuilder
    }

    private void EngineSetPadding(string P0)
    {
        // str: "OAEPWITHSHA3-512ANDMGF1PADDING"
        // str: "MD5"
        // str: "SHA3-384"
        // str: "4ebf43f6ca8956d9c4274e6f944626167747a2a7cfa5f3b185778da4fb966f6ec1e059"
        // str: "NOPADDING"
        // str: "OAEPWITHSHA3-384ANDMGF1PADDING"
        // str: "OAEPWITHSHA224ANDMGF1PADDING"
        // str: "OAEPWITHSHA384ANDMGF1PADDING"
        // str: "OAEPWITHSHA256ANDMGF1PADDING"
        // str: "OAEPWITHSHA1ANDMGF1PADDING"
        // str: "OAEPWITHSHA-384ANDMGF1PADDING"
        // str: " unavailable with RSA."
        // str: "0c2e22f0e28765b14293c8f22d2a794d22dbf897332548d8617a87b800f5bea5af664f"
        // str: "OAEPWITHSHA-512ANDMGF1PADDING"
        // str: "OAEPWITHSHA-224ANDMGF1PADDING"
        // str: "OAEPPADDING"
        // str: "561700d971893e1d380164efaa69e2fc672ed25520988fbc13e4afaf1909a6a2b77f5e0f"
        // str: "OAEPWITHSHA-1ANDMGF1PADDING"
        // str: "OAEPWITHMD5ANDMGF1PADDING"
        // str: "OAEPWITHSHA3-224ANDMGF1PADDING"
        // call: OAEPParameterSpec.<init>
        // call: p31aaa8d2.m8872f202
        // call: StringBuilder.append
        // call: string.equals
        // call: NoSuchPaddingException.<init>
        // call: DecryptString.decryptString
        // call: pb4e47103.<init>
        // call: MGF1ParameterSpec.<init>
        // call: p89be9433.mb8a8247c
        // call: StringBuilder.toString
        // call: p9d452d94.<init>
        // call: p2ddea612.<init>
        // call: StringBuilder.<init>
        // field: javax.crypto.spec.PSource$PSpecified.DEFAULT
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f08406a6e
        // field: javax.crypto.spec.OAEPParameterSpec.DEFAULT
        // field: java.security.spec.MGF1ParameterSpec.SHA256
        // field: java.security.spec.MGF1ParameterSpec.SHA384
        // field: java.security.spec.MGF1ParameterSpec.SHA512
        // type: OAEPParameterSpec
        // type: MGF1ParameterSpec
        // type: pb4e47103
        // type: p9d452d94
        // type: p2ddea612
        // type: StringBuilder
        // type: NoSuchPaddingException
    }

    private int EngineUpdate(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "too much data for RSA block"
        // call: p0529b267$pf0d24f46.size
        // call: p0529b267$pf0d24f46.write
        // call: p42a46bbe.getInputBlockSize
        // call: ArrayIndexOutOfBoundsException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.ff55b8df9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f08406a6e
        // type: ArrayIndexOutOfBoundsException
        return 0;
    }

    private byte[] EngineUpdate(byte[] P0, int P1, int P2)
    {
        // str: "too much data for RSA block"
        // call: p0529b267$pf0d24f46.size
        // call: p0529b267$pf0d24f46.write
        // call: p42a46bbe.getInputBlockSize
        // call: ArrayIndexOutOfBoundsException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pef31070d.p31aaa8d2.ff55b8df9
        // type: ArrayIndexOutOfBoundsException
        return default!;
    }

}
