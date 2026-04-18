namespace WillowMaze.Wasm.Decompiled;

public class P00f661de : KeyStoreSpi
{
    private static string F06a04f5b;
    private static string F55ffca6e;
    private static string F6203a00f;
    private readonly pb3b7fb02 F0eb99fb2;
    private readonly Hashtable F230416b6;
    private readonly Hashtable F924d4bba;
    private readonly pb3b7fb02 Fa1cd4401;
    private readonly Hashtable Fb0285c38;
    private readonly pb3b7fb02 Fe6a423d8;
    private readonly pb3b7fb02 Ffde5d67b;

    private CertificateFactory M6fbd3fba(string P0)
    {
        // call: CertificateFactory.getInstance
        // call: CertificateException.<init>
        // call: pb3b7fb02.createCertificateFactory
        // call: NoSuchProviderException.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de.ffde5d67b
        // type: CertificateException
        return default!;
    }

    private p00f661de$p50a25850 M7a4b6d36(Stream P0, char[] P1)
    {
        // str: "fa7a12db83d9d81fc9f6d684d146d4943dbf49ed053317af65dee25574316dd70e"
        // str: "password incorrect or store tampered with"
        // call: pe5cfc515.getDigestSize
        // call: p00f661de.me6f7011b
        // call: p00f661de$p50a25850.<init>
        // call: pe5cfc515.doFinal
        // call: pff43b8de.m66e765de
        // call: pe5cfc515.update
        // call: DecryptString.decryptString
        // call: IOException.<init>
        // call: p92e20001.me0825354
        // call: p21b3cb64.m257a59b8
        // call: pff43b8de.ma552c747
        // call: System.arraycopy
        // type: p00f661de$p50a25850
        // type: IOException
        return default!;
    }

    private void Me6f7011b(pe5cfc515 P0, char[] P1)
    {
        // str: "Mighty Aphrodite"
        // call: pe5cfc515.update
        // call: p89be9433.md6c3dad7
    }

    public Enumeration EngineAliases()
    {
        // call: Hashtable.keys
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de.f230416b6
        return default!;
    }

    public bool EngineContainsAlias(string P0)
    {
        // str: "alias value is null"
        // call: NullPointerException.<init>
        // call: Hashtable.containsKey
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de.f230416b6
        // type: NullPointerException
        return false;
    }

    public void EngineDeleteEntry(string P0)
    {
        // str: "1c55c5c23538ab77db98929c1c7786898041fe7af59d6f645cb1f747d550c30a9d1d49554214e91d4ec68b27f21e7be31..."
        // call: DecryptString.decryptString
        // call: KeyStoreException.<init>
        // type: KeyStoreException
    }

    public Certificate EngineGetCertificate(string P0)
    {
        // call: Hashtable.get
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de.f230416b6
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p4beb841c.fb6ba9fa6
        return default!;
    }

    public string EngineGetCertificateAlias(Certificate P0)
    {
        // call: Hashtable.entrySet
        // call: HashSet<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: Map$Entry.getValue
        // call: Certificate.equals
        // call: Map$Entry.getKey
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de.f230416b6
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p4beb841c.fb6ba9fa6
        return string.Empty;
    }

    public Certificate[] EngineGetCertificateChain(string P0)
    {
        return default!;
    }

    public DateTime EngineGetCreationDate(string P0)
    {
        // call: Hashtable.get
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de.f230416b6
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de$p4beb841c.f5fc73231
        return default!;
    }

    public Key EngineGetKey(string P0, char[] P1)
    {
        return default!;
    }

    public bool EngineIsCertificateEntry(string P0)
    {
        // call: Hashtable.containsKey
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de.f230416b6
        return false;
    }

    public bool EngineIsKeyEntry(string P0)
    {
        return false;
    }

    public void EngineLoad(Stream P0, char[] P1)
    {
        // str: "password incorrect or store tampered with"
        // str: "unable to discern entry type"
        // str: "2c05b5543fb1176710cb67719a551f609a9d11181140cba30cfb2f08bc983dde89e9f79f4d4e5830b949f322e292c9e45..."
        // str: "unable to discern store version"
        // str: "X.509"
        // call: IOException.<init>
        // call: p00f661de$p50a25850.erase
        // call: IllegalStateException.<init>
        // call: DecryptString.decryptString
        // call: p00f661de$p50a25850.available
        // call: DataInputStream.<init>
        // call: DataInputStream.readInt
        // call: Hashtable.<init>
        // call: p00f661de.m6fbd3fba
        // call: DataInputStream.readUTF
        // call: DataInputStream.readLong
        // call: DateTime.<init>
        // call: Hashtable.containsKey
        // call: Hashtable.get
        // call: Hashtable.put
        // call: DataInputStream.readFully
        // call: p00f661de$p50a25850.<init>
        // call: CertificateFactory.generateCertificate
        // call: p00f661de$p4beb841c.<init>
        // call: p00f661de.m7a4b6d36
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de.f230416b6
        // type: IOException
        // type: IllegalStateException
        // type: DataInputStream
        // type: Hashtable
        // type: DateTime
        // type: p00f661de$p50a25850
        // type: p00f661de$p4beb841c
    }

    public void EngineLoad(KeyStore$LoadStoreParameter P0)
    {
        // str: "no support for 'param' of type "
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: p00f661de.engineLoad
        // call: StringBuilder.append
        // call: pcba16447.md32792cd
        // call: p3b62ae2c.getInputStream
        // call: object.getClass
        // call: Type.getName
        // type: StringBuilder
        // type: IllegalArgumentException
    }

    public bool EngineProbe(Stream P0)
    {
        // call: DataInputStream.<init>
        // call: DataInputStream.readInt
        // type: DataInputStream
        return false;
    }

    public void EngineSetCertificateEntry(string P0, Certificate P1)
    {
        // str: "dba71627b402acbabdb132f184738d2baf1a452b3a5817dcb7c7cc4d1821935ec2baed1f080d9c97d5704310d20f0801f..."
        // call: KeyStoreException.<init>
        // call: DecryptString.decryptString
        // type: KeyStoreException
    }

    public void EngineSetKeyEntry(string P0, Key P1, char[] P2, Certificate[] P3)
    {
        // str: "71041a9d644895b04840e57c694f0263b9f6441f5d59cc5c09e0c776bcbe6fdf03cf292464e911037da7f93704dc2277f..."
        // call: KeyStoreException.<init>
        // call: DecryptString.decryptString
        // type: KeyStoreException
    }

    public void EngineSetKeyEntry(string P0, byte[] P1, Certificate[] P2)
    {
        // str: "2ae001f9fa7589a49e879d40eee9eb2deb770ed3aa2c6274fbf3632837e21943b43f7c43bd9609a4237ca0b2d42806c76..."
        // call: KeyStoreException.<init>
        // call: DecryptString.decryptString
        // type: KeyStoreException
    }

    public int EngineSize()
    {
        // call: Hashtable.size
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p05c7e247.p00f661de.f230416b6
        return 0;
    }

    public void EngineStore(Stream P0, char[] P1)
    {
        // str: "61dc2df409dbe22855216013b1eac7b83f442c0e907f5ce00d83024a4460f1087af79c102db0fcbdfeaf699afb3f7e2e1..."
        // call: DecryptString.decryptString
        // call: IOException.<init>
        // type: IOException
    }

}
