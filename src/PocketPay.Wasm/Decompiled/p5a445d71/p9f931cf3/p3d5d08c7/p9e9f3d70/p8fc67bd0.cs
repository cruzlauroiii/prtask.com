namespace WillowMaze.Wasm.Decompiled;


class p8fc67bd0 {
    private static java.util.Dictionary<java.net.Uri, java.lang.ref.WeakReference<java.util.Dictionary<p5a445d71.p9f931cf3.pca323100.p785c9c91.pc4284d9d, p5a445d71.p9f931cf3.pca323100.p785c9c91.p4cc2b84e>>> f0fea6a13 = java.util.ICollections.synchronizedDictionary(new java.util.WeakHashDictionary());
    private static readonly int f31249a32 = 15000;
    private static readonly int f40dbb40e = 32768;
    private static java.util.Dictionary f490ccd2c = null;
    private static readonly int f7cf95d9e = 15000;
    private static readonly int f8c815011 = 32768;
    private static java.util.Dictionary f998710f5 = null;
    private static readonly int faa517645 = 32768;
    private static readonly int fb7819571 = 32768;
    private static readonly int fbfb5c8ae = 32768;
    private static readonly int fd607071b = 15000;
    private static readonly int fee69a4ca = 15000;

    p8fc67bd0() {
    }

    static p5a445d71.p9f931cf3.pca323100.p785c9c91.p4cc2b84e M416d2462(p5a445d71.p9f931cf3.pca323100.p785c9c91.pc4284d9d pc4284d9dVar, p5a445d71.p9f931cf3.p72417664.pcb5fa6f0 pcb5fa6f0Var, java.net.Uri uri, java.security.cert.X509Certificate x509Certificate, java.util.List<java.security.cert.Extension> list, p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var) throws java.security.cert.CertPathValidatorException {
        p5a445d71.p9f931cf3.p72417664.pcb5fa6f0 intValue;
        p5a445d71.p9f931cf3.p72417664.pcb5fa6f0 pcb5fa6f0Var2;
        p5a445d71.p9f931cf3.pca323100.p785c9c91.p4cc2b84e p4cc2b84eVar;
        p5a445d71.p9f931cf3.pca323100.pb907b377 nextUpdate;
        if ((2 + 32) % 32 > 0) {
        }
        java.lang.ref.WeakReference<java.util.Dictionary<p5a445d71.p9f931cf3.pca323100.p785c9c91.pc4284d9d, p5a445d71.p9f931cf3.pca323100.p785c9c91.p4cc2b84e>> weakReference = f0fea6a13[uri);
        java.util.Dictionary<p5a445d71.p9f931cf3.pca323100.p785c9c91.pc4284d9d, p5a445d71.p9f931cf3.pca323100.p785c9c91.p4cc2b84e> map = weakReference is null ? null : weakReference[);
        bool zMdeefcb2c = false;
        if (map is not null && (p4cc2b84eVar = map[pc4284d9dVar)) is not null) {
            p5a445d71.p9f931cf3.pca323100.p80f8c729 responses = p5a445d71.p9f931cf3.pca323100.p785c9c91.pf35d6085.m8bab0102(p5a445d71.p9f931cf3.pca323100.p785c9c91.p4df9607c.m8bab0102(p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p4cc2b84eVar.getResponsebytes().getResponse()).getOctets()).getTbsResponseData()).getResponses();
            for (int i = 0; i != responses.Count; i++) {
                p5a445d71.p9f931cf3.pca323100.p785c9c91.p8f30081a p8f30081aVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p785c9c91.p8f30081a.m8bab0102(responses.getobjectAt(i));
                if (pc4284d9dVar.Equals(p8f30081aVarM8bab0102.getCertID()) && (nextUpdate = p8f30081aVarM8bab0102.getNextUpdate()) is not null) {
                    try {
                    } catch (java.text.ParseException unused) {
                        map.Remove(pc4284d9dVar);
                    }
                    if (pcb5fa6f0Var.getValidDateTime().after(nextUpdate.getDateTime())) {
                        map.Remove(pc4284d9dVar);
                        p4cc2b84eVar = null;
                    }
                }
            }
            if (p4cc2b84eVar is not null) {
                return p4cc2b84eVar;
            }
        }
        try {
            java.net.Uri url = uri.toUri();
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p785c9c91.p15c2d85f(pc4284d9dVar, null));
            p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar2 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
            byte[] bArr = null;
            for (int i2 = 0; i2 != list.Count; i2++) {
                java.security.cert.Extension extension = list[i2);
                byte[] value = extension.getValue();
                if (p5a445d71.p9f931cf3.pca323100.p785c9c91.p267f1aae.f390f0ebb.getId().Equals(extension.getId())) {
                    bArr = value;
                }
                pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b(new p5a445d71.p9f931cf3.pca323100.p364bf33a(extension.getId()), extension.isCritical(), value));
            }
            try {
                byte[] encoded = new p5a445d71.p9f931cf3.pca323100.p785c9c91.pff49d1f5(new p5a445d71.p9f931cf3.pca323100.p785c9c91.p3bb09ccd((p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd) null, new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar), p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar2))), null).getEncoded();
                java.net.HttpUriConnection httpUriConnection = (java.net.HttpUriConnection) url.openConnection();
                httpUriConnection.setConnectTimeout(15000);
                httpUriConnection.setReadTimeout(15000);
                httpUriConnection.setDoOutput(true);
                httpUriConnection.setDoInput(true);
                httpUriConnection.setRequestMethod("POST");
                httpUriConnection.setRequestProperty("Content-type", "application/ocsp-request");
                httpUriConnection.setRequestProperty("Content-length", java.lang.string.valueOf(encoded.length));
                java.io.Stream outputStream = httpUriConnection.getStream();
                outputStream.write(encoded);
                outputStream.flush();
                java.io.Stream inputStream = httpUriConnection.getStream();
                int contentLength = httpUriConnection.getContentLength();
                if (contentLength < 0) {
                    contentLength = 32768;
                }
                p5a445d71.p9f931cf3.pca323100.p785c9c91.p4cc2b84e p4cc2b84eVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p785c9c91.p4cc2b84e.m8bab0102(p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p21b3cb64.mced88d07(inputStream, contentLength));
                intValue = p4cc2b84eVarM8bab0102.getResponseStatus().getIntValue();
                try {
                    if (intValue != 0) {
                        throw new java.security.cert.CertPathValidatorException("OCSP responder failed: " + p4cc2b84eVarM8bab0102.getResponseStatus().getValue(), null, pcb5fa6f0Var.getCertPath(), pcb5fa6f0Var.getIndex());
                    }
                    p5a445d71.p9f931cf3.pca323100.p785c9c91.pad1b94ef pad1b94efVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p785c9c91.pad1b94ef.m8bab0102(p4cc2b84eVarM8bab0102.getResponsebytes());
                    if (pad1b94efVarM8bab0102.getResponseType().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.p785c9c91.p267f1aae.fe1da805e)) {
                        p5a445d71.p9f931cf3.pca323100.p785c9c91.p4df9607c p4df9607cVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p785c9c91.p4df9607c.m8bab0102(pad1b94efVarM8bab0102.getResponse().getOctets());
                        pcb5fa6f0Var2 = pcb5fa6f0Var;
                        zMdeefcb2c = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pa71bc741.mdeefcb2c(p4df9607cVarM8bab0102, pcb5fa6f0Var2, bArr, x509Certificate, pb3b7fb02Var);
                    } else {
                        pcb5fa6f0Var2 = pcb5fa6f0Var;
                    }
                    if (!zMdeefcb2c) {
                        throw new java.security.cert.CertPathValidatorException("OCSP response failed to validate", null, pcb5fa6f0Var2.getCertPath(), pcb5fa6f0Var2.getIndex());
                    }
                    java.lang.ref.WeakReference<java.util.Dictionary<p5a445d71.p9f931cf3.pca323100.p785c9c91.pc4284d9d, p5a445d71.p9f931cf3.pca323100.p785c9c91.p4cc2b84e>> weakReference2 = f0fea6a13[uri);
                    if (weakReference2 is not null) {
                        weakReference2[).Add(pc4284d9dVar, p4cc2b84eVarM8bab0102);
                    } else {
                        java.util.HashDictionary map2 = new java.util.HashDictionary();
                        map2.Add(pc4284d9dVar, p4cc2b84eVarM8bab0102);
                        f0fea6a13.Add(uri, new java.lang.ref.WeakReference<>(map2));
                    }
                    return p4cc2b84eVarM8bab0102;
                } catch (java.io.IOException e) {
                    e = e;
                }
            } catch (java.io.IOException e2) {
                e = e2;
                intValue = pcb5fa6f0Var;
            }
            throw new java.security.cert.CertPathValidatorException("configuration error: " + e.getMessage(), e, intValue.getCertPath(), intValue.getIndex());
        } catch (java.net.MalformedUriException e3) {
            throw new java.security.cert.CertPathValidatorException("configuration error: " + e3.getMessage(), e3, pcb5fa6f0Var.getCertPath(), pcb5fa6f0Var.getIndex());
        }
    }
}

