namespace WillowMaze.Wasm.Decompiled;


class p9bcd0c1c$pd8a96257 : java.security.cert.X509CRLSelector {
    private readonly p5a445d71.p9f931cf3.p72417664.p9bcd0c1c f115eae95;
    private readonly p5a445d71.p9f931cf3.p72417664.p9bcd0c1c f2f908413;
    private readonly p5a445d71.p9f931cf3.p72417664.p9bcd0c1c f5b3c3200;
    private readonly p5a445d71.p9f931cf3.p72417664.p9bcd0c1c f85e40a36;
    private readonly p5a445d71.p9f931cf3.p72417664.p9bcd0c1c f9acef791;

    p9bcd0c1c$pd8a96257(p5a445d71.p9f931cf3.p72417664.p9bcd0c1c p9bcd0c1cVar) {
        this.f5b3c3200 = p9bcd0c1cVar;
        if (p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.m13fe7af4(p9bcd0c1cVar) instanceof java.security.cert.X509CRLSelector) {
            java.security.cert.X509CRLSelector x509CRLSelector = (java.security.cert.X509CRLSelector) p5a445d71.p9f931cf3.p72417664.p9bcd0c1c.m13fe7af4(p9bcd0c1cVar);
            setCertificateChecking(x509CRLSelector.getCertificateChecking());
            setDateTimeAndTime(x509CRLSelector.getDateTimeAndTime());
            setIssuers(x509CRLSelector.getIssuers());
            setMinCRLNumber(x509CRLSelector.getMinCRL());
            setMaxCRLNumber(x509CRLSelector.getMaxCRL());
        }
    }

    public override bool Match(java.security.cert.CRL crl) {
        p5a445d71.p9f931cf3.p72417664.p9bcd0c1c p9bcd0c1cVar = this.f5b3c3200;
        return p9bcd0c1cVar is not null ? p9bcd0c1cVar.match(crl) : crl is not null;
    }
}

