namespace WillowMaze.Wasm.Decompiled;

public class P7264d28b : Pa80e639a, Peff7c557
{
    private static Type F01b40e3c;
    private static Type F71bf8e28;
    private static int Fcf87d174;
    private static int Fdebc405d;
    private static int Fee4ef6e2;
    private bool F00dac6af;
    private string F0108f992;
    private PBEParameterSpec F043b52de;
    private Type[] F067f72fe;
    private p7264d28b$pd185725f F080f0b98;
    private p7264d28b$pd185725f F08406a6e;
    private int F0858938b;
    private pd81e8b93 F0a21e0e6;
    private string F0d6f7c67;
    private Type[] F18cc1005;
    private pd81e8b93 F19d4c013;
    private int F1c69d8b9;
    private p7264d28b$pd185725f F320ac44f;
    private string F36dc88f8;
    private int F41323917;
    private string F462d15c8;
    private string F47749558;
    private int F47e838e0;
    private Type[] F4cf201bf;
    private int F4e9cc4ed;
    private bool F50eaf8b5;
    private bool F538c6fb1;
    private bool F5cf32afe;
    private int F6098a144;
    private Type[] F687b016a;
    private p7264d28b$pd185725f F696ed896;
    private ped128738 F6ce4fd99;
    private int F70acea45;
    private string F7110dbc1;
    private int F71646298;
    private bool F7aee9392;
    private p7264d28b$pd185725f F83d0c3d2;
    private pd81e8b93 F85685ff5;
    private bool F8ff14387;
    private pd81e8b93 F901f3b06;
    private int F982e5d42;
    private string F9c6d2ded;
    private int F9df41163;
    private pdd5da44e Fa014cfd4;
    private int Fa694c87d;
    private bool Fb08bc543;
    private int Fba50f5e0;
    private pcea52f3a Fbc652942;
    private int Fc10f7796;
    private pcea52f3a Fcb5f28a8;
    private int Fcef6bb7a;
    private int Fd56540d2;
    private pd81e8b93 Fd670c4a0;
    private ped128738 Fe2d97d32;
    private PBEParameterSpec Feb09b467;
    private pdd5da44e Fed165a2f;
    private PBEParameterSpec Ff088d4f2;
    private bool Ff1d1624b;
    private PBEParameterSpec Ff9fe8c7e;

    private bool M1946131c(string P0)
    {
        // str: "OCB"
        // str: "GCM-SIV"
        // str: "EAX"
        // str: "CCM"
        // str: "GCM"
        // call: string.equals
        return false;
    }

    private pc9ef6b45 Mb0c6cc22(AlgorithmParameterSpec P0, pc9ef6b45 P1)
    {
        // call: pdd5da44e.<init>
        // call: pc5c653c7.getIV
        // call: IvParameterSpec.getIV
        // call: pc5c653c7.getSbox
        // call: p819716a1.<init>
        // call: pdd5da44e.getParameters
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fa014cfd4
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f47e838e0
        // type: p819716a1
        // type: pdd5da44e
        return default!;
    }

    private int EngineDoFinal(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "output buffer too short for input."
        // call: IllegalBlockSizeException.<init>
        // call: p2500579c.getMessage
        // call: ShortBufferException.<init>
        // call: p96068848.getMessage
        // call: p7264d28b.engineGetOutputSize
        // call: p7264d28b$pd185725f.processBytes
        // call: p7264d28b$pd185725f.doFinal
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f08406a6e
        // type: ShortBufferException
        // type: IllegalBlockSizeException
        return 0;
    }

    private byte[] EngineDoFinal(byte[] P0, int P1, int P2)
    {
        // str: "internal buffer overflow"
        // call: p96068848.getMessage
        // call: IllegalBlockSizeException.<init>
        // call: System.arraycopy
        // call: p7264d28b$pd185725f.doFinal
        // call: p7264d28b$pd185725f.processBytes
        // call: p7264d28b.engineGetOutputSize
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f08406a6e
        // type: IllegalBlockSizeException
        return default!;
    }

    private int EngineGetBlockSize()
    {
        // call: pd81e8b93.getBlockSize
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fd670c4a0
        return 0;
    }

    private byte[] EngineGetIV()
    {
        // call: ped128738.getNonce
        // call: pdd5da44e.getIV
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fe2d97d32
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fa014cfd4
        return default!;
    }

    private int EngineGetKeySize(Key P0)
    {
        // call: Key.getEncoded
        return 0;
    }

    private int EngineGetOutputSize(int P0)
    {
        // call: p7264d28b$pd185725f.getOutputSize
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f08406a6e
        return 0;
    }

    private AlgorithmParameters EngineGetParameters()
    {
        // str: "GCM"
        // call: p7264d28b$pd185725f.getUnderlyingCipher
        // call: string.substring
        // call: p7264d28b.createParametersInstance
        // call: pdd5da44e.getIV
        // call: IvParameterSpec.<init>
        // call: AlgorithmParameters.init
        // call: ped128738.getNonce
        // call: ped128738.getMacSize
        // call: pe05e3ad3.<init>
        // call: pe05e3ad3.getEncoded
        // call: p364bf33a.getId
        // call: p6f0e511c.<init>
        // call: p6f0e511c.getEncoded
        // call: Exception.toString
        // call: string.indexOf
        // call: Exception.<init>
        // call: pd81e8b93.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f20c904fb
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fa014cfd4
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fe2d97d32
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fe5c6460c
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fd670c4a0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f0d6f7c67
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.feb09b467
        // type: IvParameterSpec
        // type: pe05e3ad3
        // type: p6f0e511c
        // type: Exception
        return default!;
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameters P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "can't handle parameter "
        // call: StringBuilder.toString
        // call: p7264d28b.engineInit
        // call: InvalidAlgorithmParameterException.<init>
        // call: p6bf7077e.m0a78983b
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: AlgorithmParameters.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f20c904fb
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f18cc1005
        // type: StringBuilder
        // type: InvalidAlgorithmParameterException
    }

    private void EngineInit(int P0, Key P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // call: p7264d28b.engineInit
        // call: InvalidKeyException.<init>
        // call: InvalidAlgorithmParameterException.getMessage
        // type: InvalidKeyException
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameterSpec P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: " not suitable for symmetric enryption."
        // str: "RC5 already set up for a word size of 32 not "
        // str: "Key for algorithm "
        // str: "RC5 requires an RC5ParametersSpec to be passed in."
        // str: "72a9f8fa447fe35f610058bd001ef8ba999d6cf19a72f92598c85b9c4d"
        // str: "RC5 parameters passed to a cipher that is not RC5."
        // str: "RC5-32"
        // str: "Algorithm requires a PBE key"
        // str: "RC5"
        // str: "RC5-64"
        // str: "IV must be "
        // str: "unknown parameter type."
        // str: "PBEKey requires parameters to specify salt"
        // str: "ECB"
        // str: "PKCS12 requires a SecretKey/PBEKey"
        // str: " passed"
        // str: "unknown opmode "
        // str: "GCMParameterSpec can only be used with AEAD modes."
        // str: "Algorithm requires a PBE key suitable for PKCS12"
        // str: "RC5 already set up for a word size of 64 not "
        // call: peff7c557$p23e8a4b4.mdc3b2368
        // call: string.equals
        // call: InvalidAlgorithmParameterException.<init>
        // call: RC5ParameterSpec.getWordSize
        // call: pdd5da44e.<init>
        // call: Key.getAlgorithm
        // call: p51ebc4fd.getAlgorithm
        // call: StringBuilder.append
        // call: pc1b76273.isUsingInverseFunction
        // call: p7264d28b.mb0c6cc22
        // call: pd8182d1b.getMacSizeInBits
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: pdd5da44e.getParameters
        // call: PBEParameterSpec.<init>
        // call: pc5c653c7.getIV
        // call: p51ebc4fd.getParam
        // call: StringBuilder.<init>
        // call: RC5ParameterSpec.getRounds
        // call: PBEKey.getSalt
        // call: p7264d28b$pd185725f.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fd670c4a0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f0d6f7c67
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.feb09b467
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f7110dbc1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f47e838e0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fa694c87d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fa014cfd4
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f41323917
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fe2d97d32
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fc10f7796
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f5cf32afe
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f01b40e3c
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f8ff14387
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f20c904fb
        // type: InvalidAlgorithmParameterException
        // type: InvalidKeyException
        // type: pdd5da44e
        // type: StringBuilder
        // type: ped128738
        // type: InvalidParameterException
        // type: PBEParameterSpec
        // type: p819716a1
        // type: p2ae228dd
        // type: p94919be6
    }

    private void EngineSetMode(string P0)
    {
        // str: "GCM"
        // str: "GCM-SIV"
        // str: "OPENPGPCFB"
        // str: "PGPCFBWITHIV"
        // str: "Warning: SIC-Mode can become a twotime-pad if the blocksize of the cipher is too small. Use a cip..."
        // str: "CFB"
        // str: "CBC"
        // str: "OCB"
        // str: "FF1"
        // str: "CTR"
        // str: "no mode support for "
        // str: "CCM"
        // str: "ECB"
        // str: "EAX"
        // str: "can't support mode "
        // str: "OFB"
        // str: "FF3-1"
        // str: "GOFB"
        // str: "PGPCFB"
        // str: "no mode supported for this algorithm"
        // call: StringBuilder.append
        // call: pc5fbce64.<init>
        // call: string.equals
        // call: NoSuchAlgorithmException.<init>
        // call: p7264d28b$p27b80ba7.<init>
        // call: int.parseInt
        // call: p7264d28b$p6bbc4e8a.<init>
        // call: p0b9229ba.<init>
        // call: pd81e8b93.getBlockSize
        // call: StringBuilder.toString
        // call: p8350a7a9.<init>
        // call: p5a3b9aee.<init>
        // call: IllegalArgumentException.<init>
        // call: p0844e914.<init>
        // call: StringBuilder.<init>
        // call: p66d30ee8.<init>
        // call: p27945597.<init>
        // call: p33e2fd8f.<init>
        // call: p469137e7.<init>
        // call: string.startsWith
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fd670c4a0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f47e838e0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fbc652942
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f7110dbc1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f8ff14387
        // type: p7264d28b$p27b80ba7
        // type: p27945597
        // type: p66d30ee8
        // type: NoSuchAlgorithmException
        // type: StringBuilder
        // type: p7264d28b$p6bbc4e8a
        // type: pc86acbdb
        // type: pe85be1b2
        // type: p37d1254e
        // type: p6871c538
    }

    private void EngineSetPadding(string P0)
    {
        // str: "ZEROBYTEPADDING"
        // str: "X923PADDING"
        // str: "PKCS5PADDING"
        // str: "no padding supported for this algorithm"
        // str: " unknown."
        // str: "ISO10126-2PADDING"
        // str: "ISO7816-4PADDING"
        // str: "PKCS7PADDING"
        // str: "Only NoPadding can be used with AEAD modes."
        // str: "ISO9797-1PADDING"
        // str: "WITHCTS"
        // str: "TBCPADDING"
        // str: "X9.23PADDING"
        // str: "CS3PADDING"
        // str: "ISO10126PADDING"
        // str: "CTSPADDING"
        // str: "NOPADDING"
        // str: "Padding "
        // call: string.equals
        // call: p7264d28b$pd185725f.getUnderlyingCipher
        // call: pb09721e8.<init>
        // call: p7264d28b$p27b80ba7.<init>
        // call: StringBuilder.append
        // call: p1ab9514f.<init>
        // call: pd50b36f1.<init>
        // call: StringBuilder.toString
        // call: NoSuchPaddingException.<init>
        // call: p7264d28b.m1946131c
        // call: p81df8203.<init>
        // call: p7264d28b$pd185725f.wrapOnNoPadding
        // call: p37d1254e.<init>
        // call: p89be9433.mb8a8247c
        // call: p66d30ee8.<init>
        // call: StringBuilder.<init>
        // call: p60f94c80.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f7110dbc1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f5cf32afe
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.fd670c4a0
        // type: p7264d28b$p27b80ba7
        // type: StringBuilder
        // type: NoSuchPaddingException
        // type: p81df8203
        // type: p60f94c80
        // type: p1ab9514f
        // type: pb09721e8
        // type: p66d30ee8
        // type: p37d1254e
        // type: pd50b36f1
    }

    private int EngineUpdate(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // str: "output buffer too short for input."
        // call: ShortBufferException.<init>
        // call: p96068848.toString
        // call: p7264d28b$pd185725f.processBytes
        // call: p7264d28b$pd185725f.getUpdateOutputSize
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f08406a6e
        // type: ShortBufferException
        // type: IllegalStateException
        return 0;
    }

    private byte[] EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: p7264d28b$pd185725f.getUpdateOutputSize
        // call: p7264d28b$pd185725f.processBytes
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f08406a6e
        return default!;
    }

    private void EngineUpdateAAD(byte[] P0)
    {
        // call: byte[].position
        // call: byte[].get
        // call: p7264d28b.engineUpdateAAD
        // call: Math.min
        // call: byte[].array
        // call: pff43b8de.ma552c747
        // call: byte[].arrayOffset
        // call: byte[].limit
        // call: byte[].hasArray
        // call: byte[].remaining
    }

    private void EngineUpdateAAD(byte[] P0, int P1, int P2)
    {
        // call: p7264d28b$pd185725f.updateAAD
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.f08406a6e
    }

}
