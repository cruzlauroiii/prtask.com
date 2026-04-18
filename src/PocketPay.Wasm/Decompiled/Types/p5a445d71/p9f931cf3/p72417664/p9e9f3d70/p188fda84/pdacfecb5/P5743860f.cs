namespace WillowMaze.Wasm.Decompiled;

public class P5743860f : X509CRLEntry
{
    private p5944520d$p82f1dd3e F21bd2048;
    private int F26542c2a;
    private bool F3c71836e;
    private int F491de0d7;
    private p5944520d$p82f1dd3e F4a8a08f0;
    private bool F576f9dc2;
    private p694426e7 F9a03fdac;
    private bool Faae1529b;
    private p694426e7 Fb5d2f874;
    private int Fdb4b8b86;
    private bool Fe2011431;
    private bool Febb3d7e6;
    private p5944520d$p82f1dd3e Fec8aaf8c;

    private p694426e7 M6887721a(bool P0, p694426e7 P1)
    {
        // call: p5743860f.m7b9a9d43
        // call: p63e4e92b.getParsedValue
        // call: pfb202cf8.m8bab0102
        // call: pfb202cf8.getNames
        // call: pf17d2ecd.getTagNo
        // call: pf17d2ecd.getName
        // call: p694426e7.m8bab0102
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac
        return default!;
    }

    private p63e4e92b M7b9a9d43(p364bf33a P0)
    {
        // call: p5944520d$p82f1dd3e.getExtensions
        // call: p5e2f5f3c.getExtension
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.f4a8a08f0
        return default!;
    }

    private HashSet<object> Mf684fa0b(bool P0)
    {
        // call: HashSet<object>.add
        // call: p63e4e92b.isCritical
        // call: Enumeration.hasMoreElements
        // call: p5944520d$p82f1dd3e.getExtensions
        // call: Enumeration.nextElement
        // call: p5e2f5f3c.oids
        // call: p5e2f5f3c.getExtension
        // call: HashSet<object>.<init>
        // call: p364bf33a.getId
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.f4a8a08f0
        // type: HashSet<object>
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: p5944520d$p82f1dd3e.equals
        // call: X509CRLEntry.equals
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.f491de0d7
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.fe2011431
        return false;
    }

    public X500Principal GetCertificateIssuer()
    {
        // call: p694426e7.getEncoded
        // call: X500Principal.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.f9a03fdac
        // type: X500Principal
        return default!;
    }

    public HashSet<object> GetCriticalExtensionOIDs()
    {
        // call: p5743860f.mf684fa0b
        return default!;
    }

    public byte[] GetEncoded()
    {
        // str: "6ccdc3d3abc493648dce3d8b50fbaf6109dfb7735bbf309ce91d851a765a59"
        // call: IOException.toString
        // call: CRLException.<init>
        // call: DecryptString.decryptString
        // call: p5944520d$p82f1dd3e.getEncoded
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.f4a8a08f0
        // type: CRLException
        return default!;
    }

    public byte[] GetExtensionValue(string P0)
    {
        // str: "Exception encoding: "
        // call: Exception.toString
        // call: IllegalStateException.<init>
        // call: StringBuilder.<init>
        // call: p63e4e92b.getExtnValue
        // call: p11b04310.getEncoded
        // call: p5743860f.m7b9a9d43
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p364bf33a.<init>
        // type: p364bf33a
        // type: StringBuilder
        // type: IllegalStateException
        return default!;
    }

    public HashSet<object> GetNonCriticalExtensionOIDs()
    {
        // call: p5743860f.mf684fa0b
        return default!;
    }

    public DateTime GetRevocationDate()
    {
        // call: p5944520d$p82f1dd3e.getRevocationDate
        // call: pa76d4ef5.getDate
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.f4a8a08f0
        return default!;
    }

    public System.Numerics.BigInteger GetSerialNumber()
    {
        // call: p5944520d$p82f1dd3e.getUserCertificate
        // call: pf391b73d.getValue
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.f4a8a08f0
        return default!;
    }

    public bool HasExtensions()
    {
        // call: p5944520d$p82f1dd3e.getExtensions
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.f4a8a08f0
        return false;
    }

    public bool HasUnsupportedCriticalExtension()
    {
        // call: HashSet<object>.isEmpty
        // call: p5743860f.getCriticalExtensionOIDs
        return false;
    }

    public int HashCode()
    {
        // call: X509CRLEntry.hashCode
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.f491de0d7
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.fe2011431
        return 0;
    }

    public string ToString()
    {
        // str: "      userCertificate: "
        // str: "   crlEntryExtensions:"
        // str: "       certificateIssuer: "
        // str: "       revocationDate: "
        // str: "                       critical("
        // str: ") "
        // str: "Certificate issuer: "
        // str: " value = "
        // str: " value = *****"
        // call: p5e2f5f3c.oids
        // call: StringBuilder.append
        // call: p89be9433.m2295b6f1
        // call: Enumeration.hasMoreElements
        // call: p364bf33a.getId
        // call: p11b04310.getOctets
        // call: p5944520d$p82f1dd3e.getExtensions
        // call: Enumeration.nextElement
        // call: p5743860f.getSerialNumber
        // call: StringBuilder.<init>
        // call: p5743860f.getRevocationDate
        // call: p63e4e92b.isCritical
        // call: p5743860f.getCertificateIssuer
        // call: p63e4e92b.getExtnValue
        // call: StringBuilder.toString
        // call: p364bf33a.equals
        // call: pd1c2953c.readObject
        // call: p4f02e7ce.m8bab0102
        // call: p67669737.m8bab0102
        // call: pfb202cf8.m8bab0102
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f.f4a8a08f0
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f61cea794
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac
        // type: StringBuilder
        // type: pd1c2953c
        return string.Empty;
    }

}
