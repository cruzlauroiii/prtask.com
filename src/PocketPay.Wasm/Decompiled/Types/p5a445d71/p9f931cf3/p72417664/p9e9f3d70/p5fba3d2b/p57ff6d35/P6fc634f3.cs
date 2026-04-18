namespace WillowMaze.Wasm.Decompiled;

public class P6fc634f3 : KeyStoreSpi, P03c3d84c, P756b0dc3, Pfefdb996
{
    private static int F0acd82eb;
    private static p6fc634f3$pa4e7add0 F28a0631a;
    private static int F29b7e114;
    private static int F2ccc0903;
    private static int F2e25f31c;
    private static int F2ee0dd7d;
    private static int F395e8641;
    private static int F3b5949e0;
    private static int F44c7be48;
    private static int F4902c638;
    private static int F4c8af79a;
    private static int F4d7f668a;
    private static int F4e277dbd;
    private static int F506c98f1;
    private static string F5d82d5c5;
    private static int F6c3e226b;
    private static p6fc634f3$pa4e7add0 F6d2ae1cc;
    private static int F6de2ed91;
    private static int F6e7de40a;
    private static int F7d35e93b;
    private static int F7f41f428;
    private static int F805a6179;
    private static string F8a5ffce4;
    private static int F9ec607bc;
    private static int Fa270a607;
    private static int Fa8722c52;
    private static int Fad1694fa;
    private static int Fafb3691c;
    private static p6fc634f3$pa4e7add0 Fbd2ceff6;
    private static int Fbe649f96;
    private static int Fbfe14df4;
    private static int Fca04e556;
    private static int Fd19e8bcd;
    private static int Fe6e7ad6e;
    private static int Fe9f9043b;
    private static int Fea420a69;
    private static int Fec5d5b35;
    private static int Fec73f192;
    private static int Fec7e04dc;
    private static int Feefe8b94;
    private static int Ff478fbb5;
    private static int Ff758df5f;
    private static int Ff9884473;
    private static int Ff9a60143;
    private static int Ffd6331e9;
    private static int Ffdc293e2;
    private int F0a63d3aa;
    private p6fc634f3$p5decc6c8 F121c4c0d;
    private p6fc634f3$p5decc6c8 F14f802e1;
    private p364bf33a F1576b942;
    private readonly pb3b7fb02 F20af0887;
    private Hashtable F2381d7e2;
    private Hashtable F2b5f8a4b;
    private Hashtable F31bdd0a6;
    private int F323be18d;
    private p234a7530 F3d5875c7;
    private p6fc634f3$p5decc6c8 F4801883f;
    private p234a7530 F48960ecc;
    private p6fc634f3$p5decc6c8 F48b432a0;
    private p364bf33a F49e30bbf;
    private Hashtable F4b8f57d7;
    private CertificateFactory F4cc2dda5;
    private p364bf33a F4ec1d76d;
    private p6fc634f3$p5decc6c8 F5c99e9c5;
    private p364bf33a F638e9657;
    private Hashtable F6440ae7a;
    private p6fc634f3$p5decc6c8 F74e31c9a;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private int F7e6d50ee;
    private Hashtable F897a852b;
    private p364bf33a F95392a54;
    private p6fc634f3$p5decc6c8 F9f5f37fb;
    private Hashtable Fa00fa246;
    private System.Security.Cryptography.RandomNumberGenerator Fb190150f;
    private p6fc634f3$p5decc6c8 Fb23c5f58;
    private int Fb5dd26f4;
    private p234a7530 Fb85eb523;
    private p6fc634f3$p5decc6c8 Fbb906b79;
    private p364bf33a Fbeb37618;
    private CertificateFactory Fc1b7e4f5;
    private int Fc6e2e4b6;
    private System.Security.Cryptography.RandomNumberGenerator Fccde6a09;
    private System.Security.Cryptography.RandomNumberGenerator Fcd152276;
    private p364bf33a Fd2e6396c;
    private Hashtable Fd546df22;
    private Hashtable Fdee41a93;
    private p6fc634f3$p5decc6c8 Ff09a9103;
    private int Ff2eba9e4;
    private p364bf33a Ff9fb69e4;
    private Hashtable Ffd1856bc;
    private readonly pb3b7fb02 Ffde5d67b;

    private void M031f0a09(Stream P0, char[] P1, bool P2)
    {
        // str: "Error encoding certificate: "
        // str: "error constructing MAC: "
        // str: "1d024491a9688501ea125b461e3ff24c1d0c100310ab1ae106e7b1a87b127e"
        // str: "677913028931f336524f2fa4e95b3c6272ed9c398aa313b47d438e55061af5"
        // str: "no password supplied for PKCS#12 KeyStore"
        // call: pa1bc6907.<init>
        // call: p6f0e511c.<init>
        // call: p6fc634f3.m6d9255f0
        // call: IOException.<init>
        // call: p42b4b739.getEncoded
        // call: p6fc634f3.cryptData
        // call: DecryptString.decryptString
        // call: p18612607.<init>
        // call: StringBuilder.toString
        // call: p6fc634f3.wrapKey
        // call: Hashtable.<init>
        // call: p6a819fa7.getEncoded
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: pc7effecb.getBagAttribute
        // call: p32555e78.<init>
        // call: Hashtable.keys
        // call: pb840b7ef.getEncoded
        // call: pd6ccb7fc.<init>
        // call: p84dfc78a.<init>
        // call: p6fc634f3.engineGetCertificate
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.fb85eb523
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f0a63d3aa
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f8d777f38
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.fbeb37618
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.fbdf418d5
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.fa291bb8a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f1576b942
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.ffd9f143d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f897a852b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f7e6d50ee
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f8d777f38
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f37784a4a
        // type: p32555e78
        // type: IOException
        // type: pa1bc6907
        // type: p46a7aa58
        // type: p18612607
        // type: p42b4b739
        // type: p63cfd610
        // type: pebd0b4e4
        // type: p6f0e511c
        // type: p8f99ab96
    }

    private p84dfc78a M1363c7af(string P0, Certificate P1)
    {
        // call: pc7effecb.getBagAttribute
        // call: pb840b7ef.<init>
        // call: p84d498e6.<init>
        // call: p364bf33a.equals
        // call: pd6ccb7fc.add
        // call: p7dab65b1.<init>
        // call: pd6ccb7fc.<init>
        // call: p84dfc78a.<init>
        // call: p8f99ab96.<init>
        // call: p20484344.getString
        // call: p7dab65b1.toASN1Primitive
        // call: Certificate.getEncoded
        // call: Enumeration.hasMoreElements
        // call: Enumeration.nextElement
        // call: p6f0e511c.<init>
        // call: pc7effecb.getBagAttributeKeys
        // call: string.equals
        // call: pc7effecb.setBagAttribute
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.fbdf418d5
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f37784a4a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.fb3f0c42b
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.fa291bb8a
        // type: p6f0e511c
        // type: pb840b7ef
        // type: pd6ccb7fc
        // type: p84d498e6
        // type: p8f99ab96
        // type: p7dab65b1
        // type: p84dfc78a
        return default!;
    }

    private System.Security.Cryptography.Aes M1ee8cad8(int P0, char[] P1, p234a7530 P2)
    {
        // call: p8afe544a.getIterationCount
        // call: p8afe544a.getPrf
        // call: System.Security.Cryptography.Aes.init
        // call: p0ec4c025.getEncryptionScheme
        // call: p8afe544a.getSalt
        // call: p0ec4c025.getKeyDerivationFunc
        // call: p0780ac48.getParameters
        // call: p6fc634f3.m84ff9faf
        // call: p0ec4c025.m8bab0102
        // call: p0780ac48.getAlgorithm
        // call: p34e8537f.getParameters
        // call: PBEKeySpec.<init>
        // call: p8afe544a.m8bab0102
        // call: p364bf33a.getId
        // call: p9f54f8ae.m8bab0102
        // call: p234a7530.getParameters
        // call: pc5c653c7.<init>
        // call: pb3b7fb02.createSecretKeyFactory
        // call: p9f54f8ae.getIV
        // call: p34e8537f.getAlgorithm
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f6d2ae1cc
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.ffde5d67b
        // type: pec83c338
        // type: pc5c653c7
        // type: IvParameterSpec
        // type: PBEKeySpec
        return default!;
    }

    private pfb409ce6 M6d9255f0(PublicKey P0)
    {
        // str: "error creating key"
        // call: Exception.<init>
        // call: PublicKey.getEncoded
        // call: p3cdccfc9.m8bab0102
        // call: p6fc634f3.me0825354
        // call: pfb409ce6.<init>
        // type: pfb409ce6
        // type: Exception
        return default!;
    }

    private int M84ff9faf(System.Numerics.BigInteger P0)
    {
        // str: "iteration count "
        // str: "ab50a78ec9948458108f70e6869a7ab39a370147692baab201815a8e344297a57ff23ccf684828b2c8d87ca7999ce554f..."
        // str: "negative iteration count found"
        // str: " greater than "
        // call: StringBuilder.append
        // call: IllegalStateException.<init>
        // call: StringBuilder.toString
        // call: p9fc2d28c.m4a2b7392
        // call: System.Numerics.BigInteger.intValue
        // call: StringBuilder.<init>
        // call: DecryptString.decryptString
        // type: IllegalStateException
        // type: StringBuilder
        return 0;
    }

    private byte[] M863292be(p364bf33a P0, byte[] P1, int P2, char[] P3, bool P4, byte[] P5)
    {
        // call: p364bf33a.getId
        // call: System.Security.Cryptography.HMAC.doFinal
        // call: pb3b7fb02.createMac
        // call: p626e3b11.<init>
        // call: System.Security.Cryptography.HMAC.init
        // call: System.Security.Cryptography.HMAC.update
        // call: PBEParameterSpec.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.ffde5d67b
        // type: p626e3b11
        // type: PBEParameterSpec
        return default!;
    }

    private static byte[] Me0825354(p3cdccfc9 P0)
    {
        // call: pe5cfc515.getDigestSize
        // call: pe5cfc515.update
        // call: pe5cfc515.doFinal
        // call: p92e20001.m60b1d416
        // call: p29d19857.getBytes
        // call: p3cdccfc9.getPublicKeyData
        return default!;
    }

    private HashSet<object> Meb408bb9()
    {
        // call: HashSet<object>.add
        // call: p6fc634f3.engineGetCertificateChain
        // call: Enumeration.hasMoreElements
        // call: Enumeration.nextElement
        // call: p6fc634f3.engineGetCertificate
        // call: p6fc634f3$p5decc6c8.keys
        // call: HashSet<object>.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        // type: HashSet<object>
        return default!;
    }

    private static pfb409ce6 Mf8f67da7(p6fc634f3 P0, PublicKey P1)
    {
        // call: p6fc634f3.m6d9255f0
        return default!;
    }

    private byte[] CryptData(bool P0, p234a7530 P1, char[] P2, bool P3, byte[] P4)
    {
        // str: "unknown PBE algorithm: "
        // str: "exception decrypting data - "
        // call: p234a7530.getParameters
        // call: IOException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: p234a7530.getAlgorithm
        // call: p46a7aa58.m8bab0102
        // call: p46a7aa58.getIV
        // call: p46a7aa58.getIterations
        // call: System.Numerics.BigInteger.intValue
        // call: PBEParameterSpec.<init>
        // call: p626e3b11.<init>
        // call: p364bf33a.getId
        // call: pb3b7fb02.createCipher
        // call: System.Security.Cryptography.Aes.init
        // call: System.Security.Cryptography.Aes.doFinal
        // call: StringBuilder.<init>
        // call: p364bf33a.on
        // call: Exception.toString
        // call: p364bf33a.equals
        // call: p6fc634f3.m1ee8cad8
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.ffde5d67b
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f7c941b08
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f77a01143
        // type: IOException
        // type: StringBuilder
        // type: PBEParameterSpec
        // type: p626e3b11
        return default!;
    }

    public Enumeration EngineAliases()
    {
        // str: "key"
        // str: "cert"
        // call: Enumeration.hasMoreElements
        // call: Enumeration.nextElement
        // call: Hashtable.get
        // call: Hashtable.put
        // call: Hashtable.keys
        // call: p6fc634f3$p5decc6c8.keys
        // call: Hashtable.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        // type: Hashtable
        return default!;
    }

    public bool EngineContainsAlias(string P0)
    {
        // call: p6fc634f3$p5decc6c8.get
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        return false;
    }

    public void EngineDeleteEntry(string P0)
    {
        // call: p6fc634f3$p5decc6c8.remove
        // call: Hashtable.remove
        // call: Certificate.getPublicKey
        // call: p6fc634f3$p36e40fce.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f74e31c9a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f897a852b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.ffd1856bc
        // type: p6fc634f3$p36e40fce
    }

    public Certificate EngineGetCertificate(string P0)
    {
        // str: "null alias passed to getCertificate."
        // call: Hashtable.get
        // call: p6fc634f3$p5decc6c8.get
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f74e31c9a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.ffd1856bc
        // type: IllegalArgumentException
        return default!;
    }

    public string EngineGetCertificateAlias(Certificate P0)
    {
        // call: Enumeration.hasMoreElements
        // call: Enumeration.nextElement
        // call: Hashtable.elements
        // call: Certificate.equals
        // call: p6fc634f3$p5decc6c8.elements
        // call: Hashtable.keys
        // call: p6fc634f3$p5decc6c8.keys
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.ffd1856bc
        return string.Empty;
    }

    public Certificate[] EngineGetCertificateChain(string P0)
    {
        // str: "null alias passed to getCertificateChain."
        // call: p11b04310.m8bab0102
        // call: X509Certificate.getExtensionValue
        // call: Enumeration.nextElement
        // call: Vector.size
        // call: p9746cd54.getKeyIdentifier
        // call: X509Certificate.getSubjectDN
        // call: Hashtable.keys
        // call: Hashtable.get
        // call: IllegalArgumentException.<init>
        // call: X509Certificate.getPublicKey
        // call: X509Certificate.verify
        // call: object.equals
        // call: X509Certificate.getIssuerDN
        // call: p9746cd54.m8bab0102
        // call: p364bf33a.getId
        // call: p11b04310.getOctets
        // call: Vector.elementAt
        // call: Vector.contains
        // call: Vector.addElement
        // call: Vector.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f897a852b
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f0145697d
        // type: p6fc634f3$p36e40fce
        // type: Vector
        // type: IllegalArgumentException
        return default!;
    }

    public DateTime EngineGetCreationDate(string P0)
    {
        // str: "alias == null"
        // call: DateTime.<init>
        // call: NullPointerException.<init>
        // call: p6fc634f3$p5decc6c8.get
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        // type: DateTime
        // type: NullPointerException
        return default!;
    }

    public Key EngineGetKey(string P0, char[] P1)
    {
        // str: "null alias passed to getKey."
        // call: p6fc634f3$p5decc6c8.get
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        // type: IllegalArgumentException
        return default!;
    }

    public bool EngineIsCertificateEntry(string P0)
    {
        // call: p6fc634f3$p5decc6c8.get
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        return false;
    }

    public bool EngineIsKeyEntry(string P0)
    {
        // call: p6fc634f3$p5decc6c8.get
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        return false;
    }

    public void EngineLoad(Stream P0, char[] P1)
    {
        // str: "org.bouncycastle.pkcs12.ignore_useless_passwd"
        // str: "password supplied for keystore that does not require one"
        // str: "attempt to add existing attribute with different value"
        // str: "PKCS12 key store mac invalid - wrong password or corrupted file."
        // str: "extra in data "
        // str: "stream does not represent a PKCS12 key store"
        // str: "extra "
        // str: "Unsupported certificate type: "
        // str: "extra in encryptedData "
        // str: "error constructing MAC: "
        // str: "no password supplied when one expected"
        // str: "no data in keystore stream"
        // str: "unmarked"
        // call: p92622dbe.getEncryptionAlgorithm
        // call: p364bf33a.equals
        // call: p80f8c729.getObjectAt
        // call: p0fd1bdf1.toASN1Primitive
        // call: pc7effecb.setBagAttribute
        // call: p18612607.getMacData
        // call: p6fc634f3$p5decc6c8.m337ceba5
        // call: StringBuilder.toString
        // call: p11b04310.getOctets
        // call: p80f8c729.size
        // call: TextWriter.println
        // call: p6fc634f3$p5decc6c8.put
        // call: pd1c2953c.<init>
        // call: pd1c2953c.readObject
        // call: p18612607.m8bab0102
        // call: IOException.<init>
        // call: Enumeration.hasMoreElements
        // call: Hashtable.put
        // call: p11b04310.m8bab0102
        // call: p7dab65b1.getCertValue
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        // field: java.lang.System.out
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f4cc2dda5
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f74e31c9a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.fa291bb8a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.ffd1856bc
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f7e6d50ee
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.fbdf418d5
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f37784a4a
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f8d777f38
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f897a852b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.fd305dd77
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.fb85eb523
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f0a63d3aa
        // type: MemoryStream
        // type: string
        // type: IOException
        // type: StringBuilder
        // type: Hashtable
        // type: Exception
        // type: p6fc634f3$p36e40fce
        // type: p6fc634f3$p5decc6c8
        // type: EOFException
        // type: Vector
    }

    public void EngineLoad(KeyStore$LoadStoreParameter P0)
    {
        // str: "no support for 'param' of type "
        // call: Type.getName
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: p3b62ae2c.getInputStream
        // call: p6fc634f3.engineLoad
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: pcba16447.md32792cd
        // call: object.getClass
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public bool EngineProbe(Stream P0)
    {
        return false;
    }

    public void EngineSetCertificateEntry(string P0, Certificate P1)
    {
        // str: "f9ca69fdc70daa942ac9d779b74b6739942691d62abbfaa28b5ccd6444"
        // str: "There is a key entry with the name "
        // call: KeyStoreException.<init>
        // call: StringBuilder.append
        // call: p6fc634f3$p5decc6c8.put
        // call: StringBuilder.<init>
        // call: p6fc634f3$p36e40fce.<init>
        // call: p6fc634f3$p5decc6c8.get
        // call: Certificate.getPublicKey
        // call: DecryptString.decryptString
        // call: StringBuilder.toString
        // call: Hashtable.put
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f897a852b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        // type: StringBuilder
        // type: KeyStoreException
        // type: p6fc634f3$p36e40fce
    }

    public void EngineSetKeyEntry(string P0, Key P1, char[] P2, Certificate[] P3)
    {
        // str: "no certificate chain for private key"
        // str: "PKCS12 does not support non-PrivateKeys"
        // call: KeyStoreException.<init>
        // call: p6fc634f3.engineDeleteEntry
        // call: p6fc634f3$p5decc6c8.put
        // call: p6fc634f3$p5decc6c8.get
        // call: p6fc634f3$p36e40fce.<init>
        // call: Certificate.getPublicKey
        // call: Hashtable.put
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f897a852b
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        // type: KeyStoreException
        // type: p6fc634f3$p36e40fce
    }

    public void EngineSetKeyEntry(string P0, byte[] P1, Certificate[] P2)
    {
        // str: "operation not supported"
        // call: Exception.<init>
        // type: Exception
    }

    public int EngineSize()
    {
        // str: "key"
        // str: "cert"
        // call: Hashtable.put
        // call: p6fc634f3$p5decc6c8.keys
        // call: Enumeration.nextElement
        // call: Hashtable.get
        // call: Enumeration.hasMoreElements
        // call: Hashtable.size
        // call: Hashtable.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f5c99e9c5
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f14f802e1
        // type: Hashtable
        return 0;
    }

    public void EngineStore(Stream P0, char[] P1)
    {
        // call: p6fc634f3.m031f0a09
    }

    public void EngineStore(KeyStore$LoadStoreParameter P0)
    {
        // str: "No support for 'param' of type "
        // str: "No support for protection parameter of type "
        // str: "'param' arg cannot be null"
        // call: object.getClass
        // call: StringBuilder.<init>
        // call: IllegalArgumentException.<init>
        // call: Type.getName
        // call: StringBuilder.append
        // call: p6389cf94.isForDEREncoding
        // call: StringBuilder.toString
        // call: p6fc634f3.m031f0a09
        // call: KeyStore$PasswordProtection.getPassword
        // call: pc96b628d.isUseDEREncoding
        // call: pc96b628d.getOutputStream
        // call: p6389cf94.getOutputStream
        // call: KeyStore$LoadStoreParameter.getProtectionParameter
        // call: p6389cf94.<init>
        // type: IllegalArgumentException
        // type: StringBuilder
        // type: p6389cf94
    }

    public void SetRandom(System.Security.Cryptography.RandomNumberGenerator P0)
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.f7ddf32e1
    }

    private PrivateKey UnwrapKey(p234a7530 P0, byte[] P1, char[] P2, bool P3)
    {
        // str: ""
        // str: "exception unwrapping private key - "
        // str: "exception unwrapping private key - cannot recognise: "
        // call: StringBuilder.<init>
        // call: p234a7530.getAlgorithm
        // call: p364bf33a.on
        // call: IOException.<init>
        // call: StringBuilder.append
        // call: p234a7530.getParameters
        // call: p46a7aa58.m8bab0102
        // call: p46a7aa58.getIV
        // call: p46a7aa58.getIterations
        // call: p6fc634f3.m84ff9faf
        // call: PBEParameterSpec.<init>
        // call: p364bf33a.getId
        // call: pb3b7fb02.createCipher
        // call: p626e3b11.<init>
        // call: System.Security.Cryptography.Aes.init
        // call: p364bf33a.equals
        // call: p6fc634f3.m1ee8cad8
        // call: System.Security.Cryptography.Aes.unwrap
        // call: Exception.toString
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f77a01143
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.ffde5d67b
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f7c941b08
        // type: IOException
        // type: PBEParameterSpec
        // type: p626e3b11
        // type: StringBuilder
        return default!;
    }

    private byte[] WrapKey(string P0, Key P1, p46a7aa58 P2, char[] P3)
    {
        // str: "exception encrypting data - "
        // call: IOException.<init>
        // call: StringBuilder.toString
        // call: Exception.toString
        // call: PBEKeySpec.<init>
        // call: pb3b7fb02.createSecretKeyFactory
        // call: p46a7aa58.getIV
        // call: p46a7aa58.getIterations
        // call: System.Numerics.BigInteger.intValue
        // call: PBEParameterSpec.<init>
        // call: pb3b7fb02.createCipher
        // call: SecretKeyFactory.generateSecret
        // call: System.Security.Cryptography.Aes.init
        // call: System.Security.Cryptography.Aes.wrap
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.ffde5d67b
        // type: PBEKeySpec
        // type: PBEParameterSpec
        // type: StringBuilder
        // type: IOException
        return default!;
    }

}
