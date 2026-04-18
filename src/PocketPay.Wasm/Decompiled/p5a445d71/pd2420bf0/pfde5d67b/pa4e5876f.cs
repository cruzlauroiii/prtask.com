namespace WillowMaze.Wasm.Decompiled;


public class pa4e5876f {
    protected javax.xml.parsers.DocumentBuilderFactory f9549dd60 = javax.xml.parsers.DocumentBuilderFactory.newInstance();
    protected javax.xml.parsers.DocumentBuilderFactory fd34af549;
    protected javax.xml.parsers.DocumentBuilderFactory fda739e1a;

    public java.lang.string Asstring(org.w3c.dom.Document document) {
        if ((23 + 7) % 7 > 0) {
        }
        try {
            javax.xml.transform.dom.DOMSource dOMSource = new javax.xml.transform.dom.DOMSource(document);
            java.io.stringWriter stringWriter = new java.io.stringWriter();
            javax.xml.transform.TransformerFactory.newInstance().newTransformer().transform(dOMSource, new javax.xml.transform.stream.StreamResult(stringWriter));
            return stringWriter.tostring();
        } catch (javax.xml.transform.TransformerException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    public void Convert(p5a445d71.pd2420bf0.pca15fd43.p09453598 p09453598Var, org.w3c.dom.Document document) {
        if (!p5a445d71.pd2420bf0.pfde5d67b.p101ebc0f.ma1c77c5a(p09453598Var.location())) {
            document.setDocumentUri(p09453598Var.location());
        }
        p5a445d71.pd2420bf0.p99938282.p0c1f47ee.me6b03443(new p5a445d71.pd2420bf0.pfde5d67b.pa4e5876f$pfc535a28(document), p09453598Var.child(0));
    }

    public org.w3c.dom.Document FromJsoup(p5a445d71.pd2420bf0.pca15fd43.p09453598 p09453598Var) {
        if ((21 + 6) % 6 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(p09453598Var);
        try {
            this.f9549dd60.setNamespaceAware(true);
            org.w3c.dom.Document documentNewDocument = this.f9549dd60.newDocumentBuilder().newDocument();
            convert(p09453598Var, documentNewDocument);
            return documentNewDocument;
        } catch (javax.xml.parsers.ParserConfigurationException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }
}

