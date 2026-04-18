namespace WillowMaze.Wasm.Decompiled;

public class Pe93197c1 : KeyStoreSpi, Pfefdb996
{
    private static int F04213cda;
    private static int F0954ac5a;
    private static int F0df0f6f6;
    private static int F0e083cc1;
    private static int F1a43fc1e;
    private static int F1b707200;
    private static int F200b33bd;
    private static string F23b56648;
    private static int F27d21d15;
    private static int F2d267308;
    private static string F33b2466d;
    private static int F395e8641;
    private static int F3b5949e0;
    private static string F3f559a9c;
    private static int F44c7be48;
    private static int F4902c638;
    private static string F4a1124b8;
    private static int F506c98f1;
    private static string F53dee188;
    private static int F58514c39;
    private static int F6555f1f7;
    private static int F66e379fb;
    private static int F6c3e226b;
    private static int F6ce72b78;
    private static int F71fe55f9;
    private static int F7db4702f;
    private static int F7e74a005;
    private static int F851327ab;
    private static int F91d670df;
    private static int F9bbd0471;
    private static int Fa9338470;
    private static int Fac01a48c;
    private static int Fad1694fa;
    private static int Fae432a33;
    private static int Fb4b57fe4;
    private static int Fbabf73f2;
    private static int Fbeb9a173;
    private static int Fc7eda8c1;
    private static string Fc982e896;
    private static int Fec5d5b35;
    private static int Fec7e04dc;
    private static string Ff13724e7;
    private static string Ff5c02363;
    private static int Ffcc7c6ba;
    private int F2af72f10;
    private Hashtable F2d4b7259;
    private readonly pb3b7fb02 F34293ace;
    private Hashtable F44f74754;
    private int F46676b10;
    private System.Security.Cryptography.RandomNumberGenerator F6680fc51;
    private readonly pb3b7fb02 F7ac34433;
    private System.Security.Cryptography.RandomNumberGenerator F7ddf32e1;
    private readonly pb3b7fb02 F84a21143;
    private int F89b89f42;
    private readonly pb3b7fb02 F9c51441d;
    private Hashtable Faab9e1de;
    private Hashtable Fab555dd2;
    private System.Security.Cryptography.RandomNumberGenerator Fb07090cc;
    private System.Security.Cryptography.RandomNumberGenerator Fc120bdee;
    private Hashtable Fee4d38c7;
    private System.Security.Cryptography.RandomNumberGenerator Ff50e06fe;
    private readonly pb3b7fb02 Ffde5d67b;

    private void M20d87dc8(Key P0, DataOutputStream P1)
    {
        // str: "unable to store encoding of protected key"
        // call: IOException.<init>
        // call: Key.getFormat
        // call: DataOutputStream.write
        // call: Key.getEncoded
        // call: DataOutputStream.writeInt
        // call: DataOutputStream.writeUTF
        // call: Key.getAlgorithm
        // type: IOException
    }

    private void M48722d2e(Certificate P0, DataOutputStream P1)
    {
        // call: CertificateEncodingException.toString
        // call: IOException.<init>
        // call: Certificate.getEncoded
        // call: Certificate.getType
        // call: DataOutputStream.writeUTF
        // call: DataOutputStream.writeInt
        // call: DataOutputStream.write
        // type: IOException
    }

    private Certificate M86614768(DataInputStream P0)
    {
        // call: IOException.<init>
        // call: CertificateException.toString
        // call: DataInputStream.readUTF
        // call: DataInputStream.readFully
        // call: pb3b7fb02.createCertificateFactory
        // call: MemoryStream.<init>
        // call: CertificateFactory.generateCertificate
        // call: NoSuchProviderException.toString
        // call: DataInputStream.readInt
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.ffde5d67b
        // type: IOException
        // type: MemoryStream
        return default!;
    }

    private Key Maa01bdd8(DataInputStream P0)
    {
        // str: "Key format "
        // str: " not recognised!"
        // str: "RAW"
        // str: "Key type "
        // str: "PKCS#8"
        // str: "PKCS8"
        // str: "Exception creating key: "
        // str: "X509"
        // str: "X.509"
        // call: string.equals
        // call: StringBuilder.append
        // call: DataInputStream.readUTF
        // call: pb3b7fb02.createSecretKeyFactory
        // call: SecretKeyFactory.generateSecret
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: IOException.<init>
        // call: p3cdccfc9.m8bab0102
        // call: p63d19d11.m1367c17c
        // call: p811299f8.m8bab0102
        // call: p63d19d11.me72b28f9
        // call: DataInputStream.readInt
        // call: DataInputStream.readFully
        // call: PKCS8EncodedKeySpec.<init>
        // call: DataInputStream.read
        // call: Exception.toString
        // call: X509EncodedKeySpec.<init>
        // call: byte[].<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.ffde5d67b
        // type: IOException
        // type: StringBuilder
        // type: PKCS8EncodedKeySpec
        // type: X509EncodedKeySpec
        // type: byte[]
        return default!;
    }

    private static void Mf23e8626(pe93197c1 P0, Key P1, DataOutputStream P2)
    {
        // call: pe93197c1.m20d87dc8
    }

    private static Key Mf8f67da7(pe93197c1 P0, DataInputStream P1)
    {
        // call: pe93197c1.maa01bdd8
        return default!;
    }

    public Enumeration EngineAliases()
    {
        // call: Hashtable.keys
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        return default!;
    }

    public bool EngineContainsAlias(string P0)
    {
        // call: Hashtable.get
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        return false;
    }

    public void EngineDeleteEntry(string P0)
    {
        // call: Hashtable.get
        // call: Hashtable.remove
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
    }

    public Certificate EngineGetCertificate(string P0)
    {
        // call: pe93197c1$pa93f496c.getCertificateChain
        // call: pe93197c1$pa93f496c.getType
        // call: pe93197c1$pa93f496c.getObject
        // call: Hashtable.get
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        return default!;
    }

    public string EngineGetCertificateAlias(Certificate P0)
    {
        // call: Enumeration.hasMoreElements
        // call: Enumeration.nextElement
        // call: pe93197c1$pa93f496c.getObject
        // call: pe93197c1$pa93f496c.getAlias
        // call: pe93197c1$pa93f496c.getCertificateChain
        // call: Hashtable.elements
        // call: Certificate.equals
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        return string.Empty;
    }

    public Certificate[] EngineGetCertificateChain(string P0)
    {
        // call: Hashtable.get
        // call: pe93197c1$pa93f496c.getCertificateChain
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        return default!;
    }

    public DateTime EngineGetCreationDate(string P0)
    {
        // call: pe93197c1$pa93f496c.getDate
        // call: Hashtable.get
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        return default!;
    }

    public Key EngineGetKey(string P0, char[] P1)
    {
        // call: pe93197c1$pa93f496c.getType
        // call: Hashtable.get
        // call: pe93197c1$pa93f496c.getObject
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        return default!;
    }

    public bool EngineIsCertificateEntry(string P0)
    {
        // call: Hashtable.get
        // call: pe93197c1$pa93f496c.getType
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        return false;
    }

    public bool EngineIsKeyEntry(string P0)
    {
        // call: pe93197c1$pa93f496c.getType
        // call: Hashtable.get
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        return false;
    }

    public void EngineLoad(Stream P0, char[] P1)
    {
        // str: "Invalid salt detected"
        // str: "Wrong version of key store."
        // str: "KeyStore integrity check failed."
        // call: p089e1c8f.getMacSize
        // call: p9cd0c098.<init>
        // call: pe93197c1.loadStore
        // call: pa10d1e48.<init>
        // call: DataInputStream.readFully
        // call: DataInputStream.<init>
        // call: pff43b8de.m66e765de
        // call: DataInputStream.readInt
        // call: pc953f774.m7cb57dae
        // call: p089e1c8f.doFinal
        // call: p089e1c8f.init
        // call: Hashtable.clear
        // call: IOException.<init>
        // call: p089e1c8f.<init>
        // call: pc953f774.generateDerivedMacParameters
        // call: pff43b8de.ma552c747
        // call: p5ee360bc.<init>
        // call: pc953f774.init
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        // type: pa10d1e48
        // type: p9cd0c098
        // type: DataInputStream
        // type: IOException
        // type: p5ee360bc
        // type: p089e1c8f
    }

    public void EngineSetCertificateEntry(string P0, Certificate P1)
    {
        // str: "key store already has a key entry with alias "
        // call: Hashtable.put
        // call: Hashtable.get
        // call: StringBuilder.toString
        // call: pe93197c1$pa93f496c.<init>
        // call: StringBuilder.<init>
        // call: pe93197c1$pa93f496c.getType
        // call: KeyStoreException.<init>
        // call: StringBuilder.append
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        // type: pe93197c1$pa93f496c
        // type: KeyStoreException
        // type: StringBuilder
    }

    public void EngineSetKeyEntry(string P0, Key P1, char[] P2, Certificate[] P3)
    {
        // str: "no certificate chain for private key"
        // call: Hashtable.put
        // call: DateTime.<init>
        // call: KeyStoreException.<init>
        // call: Exception.toString
        // call: pe93197c1$p57640572.<init>
        // call: pe93197c1$pa93f496c.<init>
        // call: Key.getEncoded
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        // type: DateTime
        // type: pe93197c1$pa93f496c
        // type: pe93197c1$p57640572
        // type: KeyStoreException
    }

    public void EngineSetKeyEntry(string P0, byte[] P1, Certificate[] P2)
    {
        // call: pe93197c1$pa93f496c.<init>
        // call: Hashtable.put
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        // type: pe93197c1$pa93f496c
    }

    public int EngineSize()
    {
        // call: Hashtable.size
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        return 0;
    }

    public void EngineStore(Stream P0, char[] P1)
    {
        // call: p089e1c8f.<init>
        // call: DataOutputStream.write
        // call: DataOutputStream.close
        // call: pe93197c1.saveStore
        // call: pc953f774.init
        // call: p089e1c8f.init
        // call: System.Security.Cryptography.RandomNumberGenerator.nextInt
        // call: p089e1c8f.getMacSize
        // call: p5ee360bc.<init>
        // call: p089e1c8f.doFinal
        // call: p9cd0c098.<init>
        // call: DataOutputStream.<init>
        // call: pdf4cabf6.<init>
        // call: DataOutputStream.writeInt
        // call: System.Security.Cryptography.RandomNumberGenerator.nextBytes
        // call: pc953f774.m7cb57dae
        // call: pc953f774.generateDerivedMacParameters
        // call: pb4c910c6.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.f7ddf32e1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.f2af72f10
        // type: p5ee360bc
        // type: pdf4cabf6
        // type: p9cd0c098
        // type: DataOutputStream
        // type: pb4c910c6
        // type: p089e1c8f
    }

    private void LoadStore(Stream P0)
    {
        // str: "Unknown object type in store."
        // call: Hashtable.put
        // call: pe93197c1.m86614768
        // call: DataInputStream.readFully
        // call: IOException.<init>
        // call: pe93197c1$pa93f496c.<init>
        // call: DataInputStream.read
        // call: DataInputStream.readUTF
        // call: DataInputStream.readLong
        // call: DateTime.<init>
        // call: DataInputStream.readInt
        // call: pe93197c1.maa01bdd8
        // call: DataInputStream.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        // type: pe93197c1$pa93f496c
        // type: IOException
        // type: DateTime
        // type: DataInputStream
    }

    private System.Security.Cryptography.Aes MakePBECipher(string P0, int P1, char[] P2, byte[] P3, int P4)
    {
        // str: "Error initialising store of key store: "
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: IOException.<init>
        // call: PBEKeySpec.<init>
        // call: pb3b7fb02.createSecretKeyFactory
        // call: PBEParameterSpec.<init>
        // call: pb3b7fb02.createCipher
        // call: SecretKeyFactory.generateSecret
        // call: System.Security.Cryptography.Aes.init
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.ffde5d67b
        // type: IOException
        // type: StringBuilder
        // type: PBEKeySpec
        // type: PBEParameterSpec
        return default!;
    }

    private void SaveStore(Stream P0)
    {
        // str: "Unknown object type in store."
        // call: DataOutputStream.writeInt
        // call: pe93197c1$pa93f496c.getObject
        // call: pe93197c1.m20d87dc8
        // call: DataOutputStream.writeLong
        // call: Enumeration.hasMoreElements
        // call: DataOutputStream.write
        // call: pe93197c1.m48722d2e
        // call: pe93197c1$pa93f496c.getCertificateChain
        // call: Enumeration.nextElement
        // call: DataOutputStream.<init>
        // call: Hashtable.elements
        // call: DateTime.getTime
        // call: pe93197c1$pa93f496c.getAlias
        // call: IOException.<init>
        // call: pe93197c1$pa93f496c.getType
        // call: DataOutputStream.writeUTF
        // call: pe93197c1$pa93f496c.getDate
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.faab9e1de
        // type: IOException
        // type: DataOutputStream
    }

    public void SetRandom(System.Security.Cryptography.RandomNumberGenerator P0)
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p5360af35.pe93197c1.f7ddf32e1
    }

}
