namespace WillowMaze.Wasm.Decompiled;

public abstract class Pa80e639a : CipherSpi, Peff7c557
{
    private pe229a672 F05a8a75c;
    private int F07cde2df;
    private int F0c50f206;
    private Type[] F18cc1005;
    private int F18df3a92;
    private AlgorithmParameters F20c904fb;
    private int F24ee23bc;
    private int F2ac9847e;
    private AlgorithmParameters F346bc62b;
    private int F3487391b;
    private int F3710d6a6;
    private AlgorithmParameters F478adf2d;
    private int F54704ac5;
    private AlgorithmParameters F5b41ecb2;
    private int F642ca925;
    private int F6b31ac1d;
    private Type[] F6ccf5dac;
    private int F6d60c4f5;
    private int F871ff1c7;
    private bool F8b62e134;
    private readonly pb3b7fb02 F8ec17a91;
    private int F8f448747;
    private int F90727152;
    private int F9822683d;
    private pe229a672 F9e53b30d;
    private pa80e639a$pf0d24f46 Fa55baf29;
    private pa80e639a$pf0d24f46 Fa672717d;
    private pa80e639a$pf0d24f46 Fae8179f7;
    private int Fb3aeb44b;
    private Type[] Fbb39ffe9;
    private int Fc30b553f;
    private int Fc6af5bba;
    private int Fc8008b22;
    private byte[] Fcb6c45c9;
    private int Fd1a1ec24;
    private pa80e639a$pf0d24f46 Fd336c3e5;
    private Type[] Fe3804e56;
    private bool Fe468b4bf;
    private int Feb2d6d9f;
    private readonly pb3b7fb02 Feb590371;
    private byte[] Ff0b53b2d;
    private readonly pb3b7fb02 Ffde5d67b;

    private AlgorithmParameters CreateParametersInstance(string P0)
    {
        // call: pb3b7fb02.createAlgorithmParameters
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.ffde5d67b
        return default!;
    }

    private int EngineDoFinal(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "not supported in a wrapping mode"
        // str: "output buffer too short for input."
        // call: pa80e639a$pf0d24f46.write
        // call: ShortBufferException.<init>
        // call: p21c8c989.getMessage
        // call: BadPaddingException.<init>
        // call: pa80e639a$pf0d24f46.getBuf
        // call: pa80e639a$pf0d24f46.size
        // call: pe229a672.wrap
        // call: pa80e639a$pf0d24f46.erase
        // call: Exception.getMessage
        // call: IllegalBlockSizeException.<init>
        // call: pe229a672.unwrap
        // call: System.arraycopy
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.fae8179f7
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.fe468b4bf
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.f9e53b30d
        // type: ShortBufferException
        // type: BadPaddingException
        // type: IllegalStateException
        // type: IllegalBlockSizeException
        return 0;
    }

    private byte[] EngineDoFinal(byte[] P0, int P1, int P2)
    {
        // str: "not supported in a wrapping mode"
        // call: pa80e639a$pf0d24f46.erase
        // call: pa80e639a$pf0d24f46.write
        // call: pa80e639a$pf0d24f46.getBuf
        // call: pa80e639a$pf0d24f46.size
        // call: pe229a672.wrap
        // call: Exception.getMessage
        // call: IllegalBlockSizeException.<init>
        // call: pe229a672.unwrap
        // call: IllegalStateException.<init>
        // call: p21c8c989.getMessage
        // call: BadPaddingException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.fe468b4bf
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.f9e53b30d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.fae8179f7
        // type: IllegalBlockSizeException
        // type: IllegalStateException
        // type: BadPaddingException
        return default!;
    }

    private int EngineGetBlockSize()
    {
        return 0;
    }

    private byte[] EngineGetIV()
    {
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.ff0b53b2d
        return default!;
    }

    private int EngineGetKeySize(Key P0)
    {
        // call: Key.getEncoded
        return 0;
    }

    private int EngineGetOutputSize(int P0)
    {
        return 0;
    }

    private AlgorithmParameters EngineGetParameters()
    {
        // call: Exception.<init>
        // call: pe229a672.getAlgorithmName
        // call: Exception.toString
        // call: string.indexOf
        // call: string.substring
        // call: pa80e639a.createParametersInstance
        // call: IvParameterSpec.<init>
        // call: AlgorithmParameters.init
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.f9e53b30d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.f20c904fb
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.ff0b53b2d
        // type: Exception
        // type: IvParameterSpec
        return default!;
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameters P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "can't handle parameter "
        // call: StringBuilder.<init>
        // call: p6bf7077e.m0a78983b
        // call: InvalidAlgorithmParameterException.<init>
        // call: StringBuilder.append
        // call: AlgorithmParameters.toString
        // call: pa80e639a.engineInit
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.f18cc1005
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.f20c904fb
        // type: InvalidAlgorithmParameterException
        // type: StringBuilder
    }

    private void EngineInit(int P0, Key P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // call: InvalidAlgorithmParameterException.getMessage
        // call: pa80e639a$p1a6189ca.<init>
        // call: pa80e639a.engineInit
        // type: pa80e639a$p1a6189ca
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameterSpec P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "PBE requires PBE parameters to be set."
        // str: "Unknown mode parameter passed to init."
        // call: Key.getEncoded
        // call: peff7c557$p23e8a4b4.mdc3b2368
        // call: InvalidAlgorithmParameterException.<init>
        // call: pdd5da44e.<init>
        // call: p51ebc4fd.getParam
        // call: p819716a1.<init>
        // call: pa80e639a$p1a6189ca.<init>
        // call: p94919be6.<init>
        // call: pe229a672.init
        // call: InvalidParameterException.<init>
        // call: pa80e639a$pf0d24f46.<init>
        // call: p4715f007.<init>
        // call: p0da1e0d1.getSBox
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: pe229a672.getAlgorithmName
        // call: IvParameterSpec.getIV
        // call: Exception.getMessage
        // call: p473e31bf.<init>
        // call: p0da1e0d1.getUKM
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.f9e53b30d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.fae8179f7
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.fe468b4bf
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.f6d60c4f5
        // type: p4715f007
        // type: p819716a1
        // type: pdd5da44e
        // type: InvalidAlgorithmParameterException
        // type: InvalidParameterException
        // type: pa80e639a$pf0d24f46
        // type: p94919be6
        // type: p473e31bf
        // type: pa80e639a$p1a6189ca
    }

    private void EngineSetMode(string P0)
    {
        // str: "can't support mode "
        // call: NoSuchAlgorithmException.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // type: StringBuilder
        // type: NoSuchAlgorithmException
    }

    private void EngineSetPadding(string P0)
    {
        // str: "Padding "
        // str: " unknown."
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: NoSuchPaddingException.<init>
        // call: StringBuilder.toString
        // type: StringBuilder
        // type: NoSuchPaddingException
    }

    private Key EngineUnwrap(byte[] P0, string P1, int P2)
    {
        // str: ""
        // str: " not supported"
        // str: "Unknown key type "
        // str: "Invalid key encoding."
        // str: "algorithm "
        // call: InvalidKeyException.<init>
        // call: StringBuilder.<init>
        // call: p811299f8.m8bab0102
        // call: p63d19d11.me72b28f9
        // call: p811299f8.getPrivateKeyAlgorithm
        // call: p234a7530.getAlgorithm
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: string.equals
        // call: IllegalBlockSizeException.getMessage
        // call: InvalidKeySpecException.getMessage
        // call: byte[].<init>
        // call: p21c8c989.getMessage
        // call: BadPaddingException.getMessage
        // call: pb3b7fb02.createKeyFactory
        // call: X509EncodedKeySpec.<init>
        // call: KeyFactory.generatePublic
        // call: PKCS8EncodedKeySpec.<init>
        // call: KeyFactory.generatePrivate
        // call: NoSuchProviderException.getMessage
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.ffde5d67b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.f9e53b30d
        // type: InvalidKeyException
        // type: StringBuilder
        // type: X509EncodedKeySpec
        // type: PKCS8EncodedKeySpec
        // type: byte[]
        return default!;
    }

    private int EngineUpdate(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "not supported in a wrapping mode"
        // call: IllegalStateException.<init>
        // call: pa80e639a$pf0d24f46.write
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.fae8179f7
        // type: IllegalStateException
        return 0;
    }

    private byte[] EngineUpdate(byte[] P0, int P1, int P2)
    {
        // str: "not supported in a wrapping mode"
        // call: IllegalStateException.<init>
        // call: pa80e639a$pf0d24f46.write
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.fae8179f7
        // type: IllegalStateException
        return default!;
    }

    private byte[] EngineWrap(Key P0)
    {
        // str: "Cannot wrap key, null encoding."
        // call: InvalidKeyException.<init>
        // call: Key.getEncoded
        // call: BadPaddingException.getMessage
        // call: IllegalBlockSizeException.<init>
        // call: pa80e639a.engineDoFinal
        // call: pe229a672.wrap
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.pa80e639a.f9e53b30d
        // type: InvalidKeyException
        // type: IllegalBlockSizeException
        return default!;
    }

}
