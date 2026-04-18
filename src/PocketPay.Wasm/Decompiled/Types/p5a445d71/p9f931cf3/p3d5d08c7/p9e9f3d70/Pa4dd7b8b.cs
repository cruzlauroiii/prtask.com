namespace WillowMaze.Wasm.Decompiled;

public class Pa4dd7b8b : P24eb6c26
{
    private p66d30ee8 F08406a6e;
    private int F0ea838cb;
    private pdd5da44e F141ed3ef;
    private Type[] F18cc1005;
    private int F18df3a92;
    private Type[] F193efccd;
    private Type[] F1ca43d00;
    private AlgorithmParameters F20c904fb;
    private Type[] F26ada470;
    private p66d30ee8 F3c9f3535;
    private int F453ec226;
    private int F47e838e0;
    private int F4c407ed8;
    private p66d30ee8 F500f7188;
    private AlgorithmParameters F5230e516;
    private pdd5da44e F5296a7b4;
    private pdd5da44e F5a452f3f;
    private p66d30ee8 F5a74f407;
    private int F633ddfbb;
    private int F709de99e;
    private int F72c6eae0;
    private AlgorithmParameters F83fc3f09;
    private int F871ff1c7;
    private p66d30ee8 F8abf8a15;
    private int F90727152;
    private Type[] F91679999;
    private int F9822683d;
    private pdd5da44e Fa014cfd4;
    private int Fa683652b;
    private int Fb4f16933;
    private AlgorithmParameters Fc413f7d1;
    private int Fd3330ff0;
    private int Fd657b75c;
    private pdd5da44e Febcb8501;
    private int Ff4f1d8f2;
    private AlgorithmParameters Ffe5b0f04;
    private int Fffee2e2f;

    private int EngineDoFinal(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: IllegalBlockSizeException.<init>
        // call: p66d30ee8.doFinal
        // call: p96068848.getMessage
        // call: BadPaddingException.<init>
        // call: p66d30ee8.processBytes
        // call: p21c8c989.getMessage
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f08406a6e
        // type: IllegalBlockSizeException
        // type: BadPaddingException
        return 0;
    }

    private byte[] EngineDoFinal(byte[] P0, int P1, int P2)
    {
        // call: p21c8c989.getMessage
        // call: pa4dd7b8b.engineGetOutputSize
        // call: p66d30ee8.processBytes
        // call: BadPaddingException.<init>
        // call: p66d30ee8.doFinal
        // call: System.arraycopy
        // call: IllegalBlockSizeException.<init>
        // call: p96068848.getMessage
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f08406a6e
        // type: BadPaddingException
        // type: IllegalBlockSizeException
        return default!;
    }

    private int EngineGetBlockSize()
    {
        // call: p66d30ee8.getBlockSize
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f08406a6e
        return 0;
    }

    private byte[] EngineGetIV()
    {
        // call: pdd5da44e.getIV
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.fa014cfd4
        return default!;
    }

    private int EngineGetKeySize(Key P0)
    {
        // call: Key.getEncoded
        return 0;
    }

    private int EngineGetOutputSize(int P0)
    {
        // call: p66d30ee8.getOutputSize
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f08406a6e
        return 0;
    }

    private AlgorithmParameters EngineGetParameters()
    {
        // str: "b96509acf91f35a98da956b2e066964aa0af007ab21a1fa6a8999e178d4b"
        // call: string.indexOf
        // call: Exception.<init>
        // call: string.substring
        // call: DecryptString.decryptString
        // call: AlgorithmParameters.getInstance
        // call: pdd5da44e.getIV
        // call: AlgorithmParameters.init
        // call: Exception.toString
        // call: p66d30ee8.getUnderlyingCipher
        // call: pd81e8b93.getAlgorithmName
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f20c904fb
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f08406a6e
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.fa014cfd4
        // type: Exception
        return default!;
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameters P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "can't handle parameter "
        // call: StringBuilder.append
        // call: AlgorithmParameters.getParameterSpec
        // call: StringBuilder.toString
        // call: pa4dd7b8b.engineInit
        // call: AlgorithmParameters.toString
        // call: StringBuilder.<init>
        // call: InvalidAlgorithmParameterException.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f20c904fb
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f18cc1005
        // type: StringBuilder
        // type: InvalidAlgorithmParameterException
    }

    private void EngineInit(int P0, Key P1, System.Security.Cryptography.RandomNumberGenerator P2)
    {
        // call: pa4dd7b8b.engineInit
        // call: IllegalArgumentException.<init>
        // call: InvalidAlgorithmParameterException.getMessage
        // type: IllegalArgumentException
    }

    private void EngineInit(int P0, Key P1, AlgorithmParameterSpec P2, System.Security.Cryptography.RandomNumberGenerator P3)
    {
        // str: "no IV set when one expected"
        // str: "can only accept RC5 word size 32 (at the moment...)"
        // str: "eeek!"
        // str: "unknown parameter type."
        // call: pa9682fb5.m07091bf1
        // call: IvParameterSpec.getIV
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: pd81e8b93.getAlgorithmName
        // call: p66d30ee8.getUnderlyingCipher
        // call: pdd5da44e.<init>
        // call: IllegalArgumentException.<init>
        // call: Key.getEncoded
        // call: p66d30ee8.init
        // call: RC5ParameterSpec.getIV
        // call: p94919be6.<init>
        // call: InvalidAlgorithmParameterException.<init>
        // call: RC5ParameterSpec.getWordSize
        // call: RC2ParameterSpec.getIV
        // call: RC2ParameterSpec.getEffectiveKeyBits
        // call: p397c291f.<init>
        // call: RC5ParameterSpec.getRounds
        // call: p24eb6c26$p23e8a4b4.mdc3b2368
        // call: TextWriter.println
        // call: p2ae228dd.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f47e838e0
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f08406a6e
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f90727152
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.fa014cfd4
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f9822683d
        // field: java.lang.System.out
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f18df3a92
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f871ff1c7
        // type: pdd5da44e
        // type: p94919be6
        // type: IllegalArgumentException
        // type: InvalidAlgorithmParameterException
        // type: p2ae228dd
        // type: p397c291f
    }

    private void EngineSetMode(string P0)
    {
        // str: "CFB"
        // str: "ECB"
        // str: "OFB"
        // str: "CBC"
        // str: "can't support mode "
        // call: StringBuilder.<init>
        // call: p8350a7a9.<init>
        // call: p32551d15.<init>
        // call: p66d30ee8.getBlockSize
        // call: IllegalArgumentException.<init>
        // call: string.length
        // call: p66d30ee8.getUnderlyingCipher
        // call: p89be9433.mb8a8247c
        // call: string.substring
        // call: string.equals
        // call: StringBuilder.append
        // call: pd81e8b93.getBlockSize
        // call: int.parseInt
        // call: p469137e7.<init>
        // call: string.startsWith
        // call: StringBuilder.toString
        // call: pc5fbce64.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f47e838e0
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f08406a6e
        // type: StringBuilder
        // type: p32551d15
        // type: pc5fbce64
        // type: p8350a7a9
        // type: p469137e7
        // type: IllegalArgumentException
    }

    private void EngineSetPadding(string P0)
    {
        // str: "ISO10126PADDING"
        // str: "PKCS5PADDING"
        // str: "PKCS7PADDING"
        // str: "NOPADDING"
        // str: "WITHCTS"
        // str: " unknown."
        // str: "Padding "
        // call: p37d1254e.<init>
        // call: StringBuilder.append
        // call: string.equals
        // call: NoSuchPaddingException.<init>
        // call: p66d30ee8.getUnderlyingCipher
        // call: p32551d15.<init>
        // call: StringBuilder.toString
        // call: p89be9433.mb8a8247c
        // call: p66d30ee8.<init>
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f08406a6e
        // type: StringBuilder
        // type: p32551d15
        // type: p66d30ee8
        // type: NoSuchPaddingException
        // type: p37d1254e
    }

    private Key EngineUnwrap(byte[] P0, string P1, int P2)
    {
        // str: "Unknown key type "
        // str: "852254b2eadbc30b11876122b511f896842a052d9d6315b68bdafbf3d366"
        // call: IllegalBlockSizeException.getMessage
        // call: InvalidKeyException.<init>
        // call: StringBuilder.append
        // call: NoSuchAlgorithmException.getMessage
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: byte[].<init>
        // call: BadPaddingException.getMessage
        // call: NoSuchProviderException.getMessage
        // call: pa4dd7b8b.engineDoFinal
        // call: InvalidKeySpecException.getMessage
        // call: DecryptString.decryptString
        // call: KeyFactory.getInstance
        // call: X509EncodedKeySpec.<init>
        // call: KeyFactory.generatePublic
        // call: PKCS8EncodedKeySpec.<init>
        // call: KeyFactory.generatePrivate
        // type: byte[]
        // type: InvalidKeyException
        // type: StringBuilder
        // type: X509EncodedKeySpec
        // type: PKCS8EncodedKeySpec
        return default!;
    }

    private int EngineUpdate(byte[] P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: p66d30ee8.processBytes
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f08406a6e
        return 0;
    }

    private byte[] EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: p66d30ee8.processBytes
        // call: p66d30ee8.getUpdateOutputSize
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa4dd7b8b.f08406a6e
        return default!;
    }

    private byte[] EngineWrap(Key P0)
    {
        // str: "Cannot wrap key, null encoding."
        // call: Key.getEncoded
        // call: BadPaddingException.getMessage
        // call: pa4dd7b8b.engineDoFinal
        // call: InvalidKeyException.<init>
        // call: IllegalBlockSizeException.<init>
        // type: IllegalBlockSizeException
        // type: InvalidKeyException
        return default!;
    }

}
