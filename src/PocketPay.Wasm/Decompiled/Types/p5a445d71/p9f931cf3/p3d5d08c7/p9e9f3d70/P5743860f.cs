namespace WillowMaze.Wasm.Decompiled;

public class P5743860f : X509CRLEntry
{
    private p5944520d$p82f1dd3e F020358af;
    private bool F17986c59;
    private bool F3f514a92;
    private int F491de0d7;
    private p5944520d$p82f1dd3e F4a8a08f0;
    private int F55bbfbe9;
    private p694426e7 F9a03fdac;
    private p694426e7 Fc4fa92c5;
    private bool Fcc1e85b7;
    private p694426e7 Fd614c401;
    private p694426e7 Fda5fa540;
    private bool Fe7f2ab82;
    private bool Fea5623de;

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
        // call: p5e2f5f3c.getExtension
        // call: p5944520d$p82f1dd3e.getExtensions
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p5743860f.f4a8a08f0
        return default!;
    }

    private HashSet<object> Mf684fa0b(bool P0)
    {
        // call: p63e4e92b.isCritical
        // call: p364bf33a.getId
        // call: HashSet<object>.<init>
        // call: Enumeration.hasMoreElements
        // call: HashSet<object>.add
        // call: p5944520d$p82f1dd3e.getExtensions
        // call: p5e2f5f3c.getExtension
        // call: p5e2f5f3c.oids
        // call: Enumeration.nextElement
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p5743860f.f4a8a08f0
        // type: HashSet<object>
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: X509CRLEntry.equals
        // call: p5944520d$p82f1dd3e.equals
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p5743860f.f4a8a08f0
        return false;
    }

    public X500Principal GetCertificateIssuer()
    {
        // call: p694426e7.getEncoded
        // call: X500Principal.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p5743860f.f9a03fdac
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
        // str: "6012c4190f93d610c02f0cde772b5ebbdbc13f28833159a6be568f6b2a90f2"
        // call: IOException.toString
        // call: CRLException.<init>
        // call: DecryptString.decryptString
        // call: p5944520d$p82f1dd3e.getEncoded
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p5743860f.f4a8a08f0
        // type: CRLException
        return default!;
    }

    public byte[] GetExtensionValue(string P0)
    {
        // str: "error encoding "
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: p63e4e92b.getExtnValue
        // call: p11b04310.getEncoded
        // call: Exception.toString
        // call: p5743860f.m7b9a9d43
        // call: Exception.<init>
        // call: StringBuilder.<init>
        // call: p364bf33a.<init>
        // type: p364bf33a
        // type: StringBuilder
        // type: Exception
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
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p5743860f.f4a8a08f0
        return default!;
    }

    public System.Numerics.BigInteger GetSerialNumber()
    {
        // call: p5944520d$p82f1dd3e.getUserCertificate
        // call: pf391b73d.getValue
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p5743860f.f4a8a08f0
        return default!;
    }

    public bool HasExtensions()
    {
        // call: p5944520d$p82f1dd3e.getExtensions
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p5743860f.f4a8a08f0
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
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p5743860f.f491de0d7
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p5743860f.fea5623de
        return 0;
    }

    public string ToString()
    {
        // str: "      userCertificate: "
        // str: "Certificate issuer: "
        // str: " value = "
        // str: " value = *****"
        // str: "                       critical("
        // str: "   crlEntryExtensions:"
        // str: ") "
        // str: "       certificateIssuer: "
        // str: "       revocationDate: "
        // call: p63e4e92b.getExtnValue
        // call: StringBuilder.append
        // call: Enumeration.hasMoreElements
        // call: pd1c2953c.<init>
        // call: p364bf33a.equals
        // call: pd1c2953c.readObject
        // call: p4f02e7ce.m8bab0102
        // call: p67669737.m8bab0102
        // call: pfb202cf8.m8bab0102
        // call: p364bf33a.getId
        // call: p3d470894.ma30a895b
        // call: p63e4e92b.isCritical
        // call: p5944520d$p82f1dd3e.getExtensions
        // call: p5e2f5f3c.oids
        // call: p5743860f.getCertificateIssuer
        // call: p11b04310.getOctets
        // call: Enumeration.nextElement
        // call: p89be9433.m2295b6f1
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf801238f.f61cea794
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf801238f.f9a03fdac
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p5743860f.f4a8a08f0
        // type: StringBuilder
        // type: pd1c2953c
        return string.Empty;
    }

}
