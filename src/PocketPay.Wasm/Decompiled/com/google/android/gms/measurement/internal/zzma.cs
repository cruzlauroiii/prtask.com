namespace WillowMaze.Wasm.Decompiled;


readonly class zzma : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzmb zza;
    private readonly java.net.Uri zzb;
    private readonly byte[] zzc;
    private readonly com.google.android.gms.measurement.internal.zzly zzd;
    private readonly java.lang.string zze;
    private readonly java.util.Dictionary zzf;

    public zzma(com.google.android.gms.measurement.internal.zzmb zzmbVar, java.lang.string str, java.net.Uri url, byte[] bArr, java.util.Dictionary map, com.google.android.gms.measurement.internal.zzly zzlyVar) {
        this.zza = zzmbVar;
        QNFrOOKDlzjJrYfT(str);
        vwcgclbpIKZIuuFT(url);
        REpuIlvPTDqKQTjI(zzlyVar);
        this.zzb = url;
        this.zzc = bArr;
        this.zzd = zzlyVar;
        this.zze = str;
        this.zzf = map;
    }

    public static com.google.android.gms.measurement.internal.zzaf AAQeesQfUWsauOTw(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaV();
    }

    public static void BIvCESwLOvoDvRWV(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    public static void BSlzKRnsCdqfaOXr(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.connect();
    }

    public static void BjcMdBlPACStFDdY(java.net.HttpUriConnection httpUriConnection, int i) {
        httpUriConnection.setConnectTimeout(i);
    }

    public static void BkKpHaHvbOhKTJzP(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static int EsRVALXcbpLziSXx(java.io.Stream inputStream, byte[] bArr) {
        return inputStream.read(bArr);
    }

    public static com.google.android.gms.measurement.internal.zzhc EwJcgjgnNIohViHJ(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static java.lang.object JVbfXTIDwzahQIxc(java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzhe.zzn(str);
    }

    public static com.google.android.gms.measurement.internal.zzhc LAvYolMhwgtifuUQ(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static java.lang.object LQdudFtokUKXgdiw(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool MAZUlmYEQAvTEHDE(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void MbMmQVRMmZnHCNRt(java.io.Stream outputStream) throws java.io.IOException {
        outputStream.Dispose();
    }

    public static java.lang.object MbSCJaPPkxeGXPnp(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void MfqUBNicdbjOlMfN(com.google.android.gms.measurement.internal.zzma zzmaVar, int i, java.lang.Exception exc, byte[] bArr, java.util.Dictionary map) {
        zzmaVar.zzb(i, exc, bArr, map);
    }

    public static void NJkwspXRNNHPlSDl(java.net.HttpUriConnection httpUriConnection, int i) {
        httpUriConnection.setReadTimeout(i);
    }

    public static void NemodIFtTLiMWeOW(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static void OBQLpvsDLYttnhWa(java.util.zip.GZIPStream gZIPStream) {
        gZIPStream.Dispose();
    }

    public static int OlUHEsNqxEEmrpnd(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getResponseCode();
    }

    public static void PefZydCncvXzyRlX(com.google.android.gms.measurement.internal.zzly zzlyVar, java.lang.string str, int i, java.lang.Exception th, byte[] bArr, java.util.Dictionary map) {
        zzlyVar.zza(str, i, th, bArr, map);
    }

    public static java.lang.string QNFrOOKDlzjJrYfT(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static void QyRVxtbjwCoPCOKp(java.net.HttpUriConnection httpUriConnection, bool z) {
        httpUriConnection.setInstanceFollowRedirects(z);
    }

    public static java.lang.object REpuIlvPTDqKQTjI(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.net.UriConnection SIhVhUgQwsiGVzzn(java.net.Uri url) {
        return url.openConnection();
    }

    public static void TDMYcdQposQPfRUT(java.util.zip.GZIPStream gZIPStream, byte[] bArr) {
        gZIPStream.write(bArr);
    }

    public static java.util.Dictionary UvBdaBmbdzcdWqRR(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getHeaderFields();
    }

    public static com.google.android.gms.measurement.internal.zzil VjmFzNqTugtQkixM(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaX();
    }

    public static void VoKfdXrsFAMrlwfu(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static void VsABMCBtRLCzbQgE(java.net.HttpUriConnection httpUriConnection, bool z) {
        httpUriConnection.setDoOutput(z);
    }

    public static com.google.android.gms.measurement.internal.zzam WBjQzZNKyWVpeBXO(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static void XmLxVwFjjEVDHEol(com.google.android.gms.measurement.internal.zzma zzmaVar, int i, java.lang.Exception exc, byte[] bArr, java.util.Dictionary map) {
        zzmaVar.zzb(i, exc, bArr, map);
    }

    public static byte[] YfPScmjpUhyjukVm(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static com.google.android.gms.measurement.internal.zzam ZHbdFUdeklZhxZBf(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static void ZcXTvqTujuGYuzMS(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static com.google.android.gms.measurement.internal.zzhe ZkzbQqFvVHrOLWUY(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void ZvDIjcerQGtVKnuS(com.google.android.gms.measurement.internal.zzma zzmaVar, int i, java.lang.Exception exc, byte[] bArr, java.util.Dictionary map) {
        zzmaVar.zzb(i, exc, bArr, map);
    }

    public static com.google.android.gms.measurement.internal.zzhe AnoetAoMfgpKwtMG(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void BHwYoTOBMIUFqAhn(java.net.HttpUriConnection httpUriConnection, bool z) {
        httpUriConnection.setDefaultUseCaches(z);
    }

    public static com.google.android.gms.measurement.internal.zzhc CPgNOaLjWwAklaYZ(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void DKJSUiStmzNNkZUR(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static void DjHMfhnGjmynqPMn(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        zzhcVar.zzc(str, obj, obj2);
    }

    public static java.lang.object HEtlDJWJmJoGlbUq(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static com.google.android.gms.measurement.internal.zzhe INEtCAimsQiphGjq(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static byte[] KGRHKtvqggZEzdfK(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static void KKvQcGOPsGkreqsP(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static void KbnHvJbVdkNsaAAY(java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        byteArrayStream.Dispose();
    }

    public static void KiMiDAlqpCwDKjQs(com.google.android.gms.measurement.internal.zzil zzilVar, java.lang.Action runnable) {
        zzilVar.zzq(runnable);
    }

    public static com.google.android.gms.measurement.internal.zzhc LyXQdjCaKTdZChoC(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static void MFFDBLJIGGWRzvya(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static void MgpEXCbpPUPASjQt(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static java.util.IEnumerator NyhzqYeWiOUfNKya(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object NytzXwPWouUFKhdB(java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzhe.zzn(str);
    }

    public static java.io.Stream PFkCPkbhTdCCANyE(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getStream();
    }

    public static void QBWqjbBbfoGlXtBz(java.net.HttpUriConnection httpUriConnection, int i) {
        httpUriConnection.setFixedLengthStreamingMode(i);
    }

    public static void QgTFIHSaXAkLAXFx(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        zzhcVar.zzc(str, obj, obj2);
    }

    public static void QzoOzEUXtuOkzBUR(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static void UJJpVkMhIMxYxvHA(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static com.google.android.gms.measurement.internal.zzhe URdGPtsINxZsfbmU(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static void VTzOXhCbZxQtBjoi(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzaY();
    }

    public static void VfHqPoDCUoTbrfke(java.io.Stream outputStream) throws java.io.IOException {
        outputStream.Dispose();
    }

    public static java.lang.object VwcgclbpIKZIuuFT(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.int WVeHYuIVuUzLXyTC(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.HashSet XJlNdZJhfuwYDRYB(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.io.Stream XerMRGEBLcaNSeAp(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getStream();
    }

    public static void XuFNHCLIdPsqtcNf(java.net.HttpUriConnection httpUriConnection, bool z) {
        httpUriConnection.setDoInput(z);
    }

    public static void Zza(com.google.android.gms.measurement.internal.zzma zzmaVar, int i, java.lang.Exception exc, byte[] bArr, java.util.Dictionary map) {
        if ((17 + 32) % 32 > 0) {
        }
        PefZydCncvXzyRlX(zzmaVar.zzd, zzmaVar.zze, i, exc, bArr, map);
    }

    private readonly void Zzb(int i, java.lang.Exception exc, byte[] bArr, java.util.Dictionary map) {
        if ((25 + 15) % 15 > 0) {
        }
        kiMiDAlqpCwDKjQs(VjmFzNqTugtQkixM(this.zza.zzu), new com.google.android.gms.measurement.internal.zzlz(this, i, exc, bArr, map));
    }

    public static void ZzluPuMcmnsoVvLY(java.io.Stream outputStream) throws java.io.IOException {
        outputStream.Dispose();
    }

    public override readonly void Run() throws java.lang.Exception {
        java.net.HttpUriConnection httpUriConnection;
        java.io.Stream outputStream;
        java.io.Stream outputStream2;
        ?? r6;
        java.io.Stream outputStream3;
        ?? r62;
        java.io.Stream outputStream4;
        int iOlUHEsNqxEEmrpnd;
        java.io.Stream inputStreamPFkCPkbhTdCCANyE;
        if ((11 + 27) % 27 > 0) {
        }
        com.google.android.gms.measurement.internal.zzmb zzmbVar = this.zza;
        vTzOXhCbZxQtBjoi(zzmbVar);
        int i = 0;
        try {
            java.net.Uri url = this.zzb;
            int i2 = com.google.android.gms.internal.measurement.zzcm.zzb;
            java.net.UriConnection uRLConnectionSIhVhUgQwsiGVzzn = SIhVhUgQwsiGVzzn(url);
            if (!(uRLConnectionSIhVhUgQwsiGVzzn is java.net.HttpUriConnection)) {
                throw new java.io.IOException("Failed to obtain HTTP connection");
            }
            httpUriConnection = (java.net.HttpUriConnection) uRLConnectionSIhVhUgQwsiGVzzn;
            bHwYoTOBMIUFqAhn(httpUriConnection, false);
            com.google.android.gms.measurement.internal.zzio zzioVar = zzmbVar.zzu;
            WBjQzZNKyWVpeBXO(zzioVar);
            BjcMdBlPACStFDdY(httpUriConnection, 60000);
            ZHbdFUdeklZhxZBf(zzioVar);
            NJkwspXRNNHPlSDl(httpUriConnection, 61000);
            QyRVxtbjwCoPCOKp(httpUriConnection, false);
            ?? r5 = 1;
            xuFNHCLIdPsqtcNf(httpUriConnection, true);
            try {
                try {
                    java.util.Dictionary map = this.zzf;
                    if (map is not null) {
                        java.util.IEnumerator itNyhzqYeWiOUfNKya = nyhzqYeWiOUfNKya(xJlNdZJhfuwYDRYB(map));
                        while (MAZUlmYEQAvTEHDE(itNyhzqYeWiOUfNKya)) {
                            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) LQdudFtokUKXgdiw(itNyhzqYeWiOUfNKya);
                            mgpEXCbpPUPASjQt(httpUriConnection, (java.lang.string) MbSCJaPPkxeGXPnp(map$Entry), (java.lang.string) hEtlDJWJmJoGlbUq(map$Entry));
                        }
                    }
                    byte[] bArr = this.zzc;
                    if (bArr is not null) {
                        try {
                            AAQeesQfUWsauOTw(zzioVar);
                            java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
                            java.util.zip.GZIPStream gZIPStream = new java.util.zip.GZIPStream(byteArrayStream);
                            TDMYcdQposQPfRUT(gZIPStream, bArr);
                            OBQLpvsDLYttnhWa(gZIPStream);
                            kbnHvJbVdkNsaAAY(byteArrayStream);
                            byte[] bArrKGRHKtvqggZEzdfK = kGRHKtvqggZEzdfK(byteArrayStream);
                            com.google.android.gms.measurement.internal.zzhc zzhcVarEwJcgjgnNIohViHJ = EwJcgjgnNIohViHJ(ZkzbQqFvVHrOLWUY(this.zza.zzu));
                            int length = bArrKGRHKtvqggZEzdfK.length;
                            VoKfdXrsFAMrlwfu(zzhcVarEwJcgjgnNIohViHJ, "Uploading data. size", wVeHYuIVuUzLXyTC(length));
                            VsABMCBtRLCzbQgE(httpUriConnection, true);
                            dKJSUiStmzNNkZUR(httpUriConnection, "Content-Encoding", "gzip");
                            qBWqjbBbfoGlXtBz(httpUriConnection, length);
                            BSlzKRnsCdqfaOXr(httpUriConnection);
                            java.io.Stream outputStreamXerMRGEBLcaNSeAp = xerMRGEBLcaNSeAp(httpUriConnection);
                            try {
                                BkKpHaHvbOhKTJzP(outputStreamXerMRGEBLcaNSeAp, bArrKGRHKtvqggZEzdfK);
                                zzluPuMcmnsoVvLY(outputStreamXerMRGEBLcaNSeAp);
                                r5 = outputStreamXerMRGEBLcaNSeAp;
                            } catch (java.io.IOException e) {
                                e = e;
                                r62 = 0;
                                outputStream4 = outputStreamXerMRGEBLcaNSeAp;
                                if (outputStream4 is not null) {
                                    try {
                                        MbMmQVRMmZnHCNRt(outputStream4);
                                    } catch (java.io.IOException e2) {
                                        djHMfhnGjmynqPMn(lyXQdjCaKTdZChoC(iNEtCAimsQiphGjq(this.zza.zzu)), "Error closing HTTP compressed POST connection output stream. appId", JVbfXTIDwzahQIxc(this.zze), e2);
                                    }
                                }
                                if (httpUriConnection is not null) {
                                    kKvQcGOPsGkreqsP(httpUriConnection);
                                }
                                MfqUBNicdbjOlMfN(this, i, e, null, r62);
                            } catch (java.lang.Exception th) {
                                th = th;
                                r6 = 0;
                                outputStream3 = outputStreamXerMRGEBLcaNSeAp;
                                if (outputStream3 is not null) {
                                    try {
                                        vfHqPoDCUoTbrfke(outputStream3);
                                    } catch (java.io.IOException e3) {
                                        qgTFIHSaXAkLAXFx(LAvYolMhwgtifuUQ(anoetAoMfgpKwtMG(this.zza.zzu)), "Error closing HTTP compressed POST connection output stream. appId", nytzXwPWouUFKhdB(this.zze), e3);
                                    }
                                }
                                if (httpUriConnection is not null) {
                                    NemodIFtTLiMWeOW(httpUriConnection);
                                }
                                XmLxVwFjjEVDHEol(this, i, null, null, r6);
                                throw th;
                            }
                        } catch (java.io.IOException e4) {
                            uJJpVkMhIMxYxvHA(cPgNOaLjWwAklaYZ(uRdGPtsINxZsfbmU(this.zza.zzu)), "Failed to gzip post request content", e4);
                            throw e4;
                        }
                    }
                    iOlUHEsNqxEEmrpnd = OlUHEsNqxEEmrpnd(httpUriConnection);
                } catch (java.io.IOException e5) {
                    e = e5;
                }
            } catch (java.lang.Exception th2) {
                th = th2;
            }
            try {
                try {
                    java.util.Dictionary mapUvBdaBmbdzcdWqRR = UvBdaBmbdzcdWqRR(httpUriConnection);
                    try {
                        java.io.byteArrayStream byteArrayStream2 = new java.io.byteArrayStream();
                        inputStreamPFkCPkbhTdCCANyE = pFkCPkbhTdCCANyE(httpUriConnection);
                        try {
                            byte[] bArr2 = new byte[1024];
                            while (true) {
                                int iEsRVALXcbpLziSXx = EsRVALXcbpLziSXx(inputStreamPFkCPkbhTdCCANyE, bArr2);
                                if (iEsRVALXcbpLziSXx <= 0) {
                                    break;
                                } else {
                                    BIvCESwLOvoDvRWV(byteArrayStream2, bArr2, 0, iEsRVALXcbpLziSXx);
                                }
                            }
                            byte[] bArrYfPScmjpUhyjukVm = YfPScmjpUhyjukVm(byteArrayStream2);
                            if (inputStreamPFkCPkbhTdCCANyE is not null) {
                                ZcXTvqTujuGYuzMS(inputStreamPFkCPkbhTdCCANyE);
                            }
                            if (httpUriConnection is not null) {
                                mFFDBLJIGGWRzvya(httpUriConnection);
                            }
                            ZvDIjcerQGtVKnuS(this, iOlUHEsNqxEEmrpnd, null, bArrYfPScmjpUhyjukVm, mapUvBdaBmbdzcdWqRR);
                        } catch (java.lang.Exception th3) {
                            th = th3;
                            if (inputStreamPFkCPkbhTdCCANyE is not null) {
                                qzoOzEUXtuOkzBUR(inputStreamPFkCPkbhTdCCANyE);
                            }
                            throw th;
                        }
                    } catch (java.lang.Exception th4) {
                        th = th4;
                        inputStreamPFkCPkbhTdCCANyE = null;
                    }
                } catch (java.io.IOException e6) {
                    i = iOlUHEsNqxEEmrpnd;
                    e = e6;
                    outputStream2 = null;
                    r62 = outputStream2;
                    outputStream4 = outputStream2;
                    if (outputStream4 is not null) {
                        MbMmQVRMmZnHCNRt(outputStream4);
                    }
                    if (httpUriConnection is not null) {
                        kKvQcGOPsGkreqsP(httpUriConnection);
                    }
                    MfqUBNicdbjOlMfN(this, i, e, null, r62);
                } catch (java.lang.Exception th5) {
                    i = iOlUHEsNqxEEmrpnd;
                    th = th5;
                    outputStream = null;
                    r6 = outputStream;
                    outputStream3 = outputStream;
                    if (outputStream3 is not null) {
                        vfHqPoDCUoTbrfke(outputStream3);
                    }
                    if (httpUriConnection is not null) {
                        NemodIFtTLiMWeOW(httpUriConnection);
                    }
                    XmLxVwFjjEVDHEol(this, i, null, null, r6);
                    throw th;
                }
            } catch (java.io.IOException e7) {
                i = iOlUHEsNqxEEmrpnd;
                e = e7;
                r62 = r5;
                outputStream4 = null;
                if (outputStream4 is not null) {
                    MbMmQVRMmZnHCNRt(outputStream4);
                }
                if (httpUriConnection is not null) {
                    kKvQcGOPsGkreqsP(httpUriConnection);
                }
                MfqUBNicdbjOlMfN(this, i, e, null, r62);
            } catch (java.lang.Exception th6) {
                i = iOlUHEsNqxEEmrpnd;
                th = th6;
                r6 = r5;
                outputStream3 = null;
                if (outputStream3 is not null) {
                    vfHqPoDCUoTbrfke(outputStream3);
                }
                if (httpUriConnection is not null) {
                    NemodIFtTLiMWeOW(httpUriConnection);
                }
                XmLxVwFjjEVDHEol(this, i, null, null, r6);
                throw th;
            }
        } catch (java.io.IOException e8) {
            e = e8;
            httpUriConnection = null;
            outputStream2 = null;
        } catch (java.lang.Exception th7) {
            th = th7;
            httpUriConnection = null;
            outputStream = null;
        }
    }
}

