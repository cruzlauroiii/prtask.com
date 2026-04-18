namespace WillowMaze.Wasm.Decompiled;

public class P27cbb5a8 : X509CertSelector, P0c3cd33e
{
    public static p27cbb5a8 M8bab0102(X509CertSelector P0)
    {
        // str: "cannot create from null selector"
        // str: "error in passed in selector: "
        // call: p27cbb5a8.setSubject
        // call: X509CertSelector.getSubjectKeyIdentifier
        // call: X509CertSelector.getPrivateKeyValid
        // call: X509CertSelector.getIssuer
        // call: X509CertSelector.getCertificateValid
        // call: p27cbb5a8.setSubjectPublicKey
        // call: X509CertSelector.getBasicConstraints
        // call: p27cbb5a8.setAuthorityKeyIdentifier
        // call: StringBuilder.toString
        // call: IllegalArgumentException.<init>
        // call: X509CertSelector.getKeyUsage
        // call: p27cbb5a8.setSerialNumber
        // call: StringBuilder.<init>
        // call: X509CertSelector.getMatchAllSubjectAltNames
        // call: X509CertSelector.getAuthorityKeyIdentifier
        // call: p27cbb5a8.<init>
        // call: p27cbb5a8.setCertificate
        // call: StringBuilder.append
        // call: p27cbb5a8.setSubjectKeyIdentifier
        // call: X509CertSelector.getSubject
        // type: IllegalArgumentException
        // type: p27cbb5a8
        // type: StringBuilder
        return default!;
    }

    public object Clone()
    {
        // call: X509CertSelector.clone
        return default!;
    }

    public bool Match(object P0)
    {
        // call: X509CertSelector.match
        return false;
    }

    public bool Match(Certificate P0)
    {
        // call: p27cbb5a8.match
        return false;
    }

}
