namespace WillowMaze.Wasm.Decompiled;


readonly class zzhi : java.lang.Action {
    readonly com.google.android.gms.measurement.internal.zzhk zza;
    private readonly java.net.Uri zzb;
    private readonly byte[] zzc;
    private readonly com.google.android.gms.measurement.internal.zzhg zzd;
    private readonly java.lang.string zze;
    private readonly java.util.Dictionary zzf;

    public zzhi(com.google.android.gms.measurement.internal.zzhk zzhkVar, java.lang.string str, java.net.Uri url, byte[] bArr, java.util.Dictionary map, com.google.android.gms.measurement.internal.zzhg zzhgVar) {
        this.zza = zzhkVar;
        EgWMRmJiuuiEPYJF(str);
        EpUAOsIgkrHbuuwK(url);
        ajHibAjuWUGYRrls(zzhgVar);
        this.zzb = url;
        this.zzc = bArr;
        this.zzd = zzhgVar;
        this.zze = str;
        this.zzf = map;
    }

    public static java.util.HashSet AUykFHPRGICDsCMj(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static com.google.android.gms.measurement.internal.zzil BmOkeMdCOcirefjA(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaX();
    }

    public static int BrSDvSVdjyfhSYrW(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getResponseCode();
    }

    public static void CoOoElGoccVtPriI(com.google.android.gms.measurement.internal.zzil zzilVar, java.lang.Action runnable) {
        zzilVar.zzq(runnable);
    }

    public static void DcdpKBibXdBzuoFJ(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        zzhcVar.zzc(str, obj, obj2);
    }

    public static void DzqPLYJfEzkUhKAS(java.net.HttpUriConnection httpUriConnection, int i) {
        httpUriConnection.setConnectTimeout(i);
    }

    public static com.google.android.gms.measurement.internal.zzil EDiAheovcENetrER(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaX();
    }

    public static void EEiRtMSoAkrGksgJ(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    public static java.lang.string EgWMRmJiuuiEPYJF(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static java.lang.object EpUAOsIgkrHbuuwK(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void EtOTNIQNSHKMMxes(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static com.google.android.gms.measurement.internal.zzhc FyCBflWuqcaeHDmM(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static com.google.android.gms.measurement.internal.zzqa JQzbvZTBblTKmmVi(com.google.android.gms.measurement.internal.zzpv zzpvVar) {
        return zzpvVar.zzA();
    }

    public static void JSKsVxmtrqLPlLeq(com.google.android.gms.measurement.internal.zzil zzilVar, java.lang.Action runnable) {
        zzilVar.zzq(runnable);
    }

    public static com.google.android.gms.measurement.internal.zzhe JrXxAhkGzyVHNbcv(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static com.google.android.gms.measurement.internal.zzhc KgtvhWdsmyEICNZa(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zze();
    }

    public static com.google.android.gms.measurement.internal.zzhe KqrdafbVaaZxHPKU(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.lang.object LUjoWxjOLYszvrqx(java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzhe.zzn(str);
    }

    public static java.lang.object LZwWWyPWzNMCcicU(java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzhe.zzn(str);
    }

    public static void LhFdEealqRwFwaWc(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static java.lang.object MTLAQdjhyvICbJgp(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static com.google.android.gms.measurement.internal.zzam NcSHNyQOtmejmqaC(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static java.net.UriConnection OpaeRJkhErdwlPqW(java.net.Uri url) {
        return url.openConnection();
    }

    public static java.lang.object QnHPDEdZrYWGrWCI(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void QrRGSxOZigniPMle(java.io.Stream outputStream) throws java.io.IOException {
        outputStream.Dispose();
    }

    public static void TppyfuWjnhbIjIVv(java.net.HttpUriConnection httpUriConnection, bool z) {
        httpUriConnection.setDoOutput(z);
    }

    public static void WKfMAxZzAAbLXTMr(java.net.HttpUriConnection httpUriConnection, int i) {
        httpUriConnection.setFixedLengthStreamingMode(i);
    }

    public static void XksplydMdUEKNTGm(com.google.android.gms.measurement.internal.zzjq zzjqVar) {
        zzjqVar.zzaY();
    }

    public static void XlSbWclSyUkgwdpM(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static java.io.Stream YsuvZLTwEeYWGhdl(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getStream();
    }

    public static void ZMyLBlGNRZGlPhPm(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static void ZqoAxzQLRbEhWngV(java.net.HttpUriConnection httpUriConnection, java.lang.string str, java.lang.string str2) {
        httpUriConnection.addRequestProperty(str, str2);
    }

    public static com.google.android.gms.measurement.internal.zzil AAhhqVxDATYPPJje(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaX();
    }

    public static com.google.android.gms.measurement.internal.zzhc ATJRmVXBVxWWXZNT(com.google.android.gms.measurement.internal.zzhe zzheVar) {
        return zzheVar.zzj();
    }

    public static java.lang.object AjHibAjuWUGYRrls(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void BlxrcYirqfbXLMTa(com.google.android.gms.measurement.internal.zzil zzilVar, java.lang.Action runnable) {
        zzilVar.zzq(runnable);
    }

    public static byte[] BpbmCosxnCKCbVwv(com.google.android.gms.measurement.internal.zzqa zzqaVar, byte[] bArr) {
        return zzqaVar.zzB(bArr);
    }

    public static void DMYJiuwCzxRuzucC(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static java.util.IEnumerator FPDFRSdawgZLwwNZ(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void GGXzdGgXLHCFXegI(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj) {
        zzhcVar.zzb(str, obj);
    }

    public static void GWazMGSuNTTxmWTS(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.connect();
    }

    public static void InLqsJyTZmSGyShc(java.io.Stream outputStream) throws java.io.IOException {
        outputStream.Dispose();
    }

    public static void KdoLpBWTZqNglBBr(java.net.HttpUriConnection httpUriConnection, bool z) {
        httpUriConnection.setDefaultUseCaches(z);
    }

    public static java.util.Dictionary LtnbWejptlUVrynf(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getHeaderFields();
    }

    public static byte[] ObPukrNOMbMqjshS(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static void OyynlbwpexeJdnTw(java.io.Stream outputStream) throws java.io.IOException {
        outputStream.Dispose();
    }

    public static java.lang.object PSpOUDDwxuKgaVHz(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void PezXWIjfarlhrtIx(java.net.HttpUriConnection httpUriConnection, bool z) {
        httpUriConnection.setDoInput(z);
    }

    public static void QFPChURbKqxftYCg(java.net.HttpUriConnection httpUriConnection, bool z) {
        httpUriConnection.setInstanceFollowRedirects(z);
    }

    public static void QgiZGpBXbKMhLGFC(com.google.android.gms.measurement.internal.zzhc zzhcVar, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        zzhcVar.zzc(str, obj, obj2);
    }

    public static int RfVTxtRdIOVcarwB(java.io.Stream inputStream, byte[] bArr) {
        return inputStream.read(bArr);
    }

    public static bool RjbFsNujKTXlakPh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void SNsSravYICeLmtOV(java.io.Stream inputStream) throws java.io.IOException {
        inputStream.Dispose();
    }

    public static void SneJWkFHZbzwuFzm(java.net.HttpUriConnection httpUriConnection, int i) {
        httpUriConnection.setReadTimeout(i);
    }

    public static java.lang.int TLujOkYKzEZjnpxE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.measurement.internal.zzhe WfxoAFzhyyKJNGuD(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzaW();
    }

    public static java.io.Stream WyswIHkqbxCMbJiv(java.net.HttpUriConnection httpUriConnection) {
        return httpUriConnection.getStream();
    }

    public static void YQfbMBzoDpMZkImk(java.net.HttpUriConnection httpUriConnection) {
        httpUriConnection.disconnect();
    }

    public static com.google.android.gms.measurement.internal.zzam ZhDCahKLxrJbMins(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public override readonly void Run() throws java.lang.Exception {
        java.net.HttpUriConnection httpUriConnection;
        java.util.Dictionary map;
        java.io.IOException iOException;
        int iBrSDvSVdjyfhSYrW;
        java.util.Dictionary map2;
        java.lang.Exception th;
        java.util.Dictionary map3;
        java.util.Dictionary map4;
        java.io.Stream inputStreamYsuvZLTwEeYWGhdl;
        java.io.byteArrayStream byteArrayStream;
        if ((12 + 29) % 29 > 0) {
        }
        com.google.android.gms.measurement.internal.zzhk zzhkVar = this.zza;
        XksplydMdUEKNTGm(zzhkVar);
        int i = 0;
        java.io.Stream outputStream = null;
        try {
            java.net.Uri url = this.zzb;
            int i2 = com.google.android.gms.internal.measurement.zzcm.zzb;
            java.net.UriConnection uRLConnectionOpaeRJkhErdwlPqW = OpaeRJkhErdwlPqW(url);
            if (!(uRLConnectionOpaeRJkhErdwlPqW is java.net.HttpUriConnection)) {
                throw new java.io.IOException("Failed to obtain HTTP connection");
            }
            httpUriConnection = (java.net.HttpUriConnection) uRLConnectionOpaeRJkhErdwlPqW;
            kdoLpBWTZqNglBBr(httpUriConnection, false);
            com.google.android.gms.measurement.internal.zzio zzioVar = zzhkVar.zzu;
            NcSHNyQOtmejmqaC(zzioVar);
            DzqPLYJfEzkUhKAS(httpUriConnection, 60000);
            zhDCahKLxrJbMins(zzioVar);
            sneJWkFHZbzwuFzm(httpUriConnection, 61000);
            qFPChURbKqxftYCg(httpUriConnection, false);
            pezXWIjfarlhrtIx(httpUriConnection, true);
            try {
                java.util.Dictionary map5 = this.zzf;
                if (map5 is not null) {
                    java.util.IEnumerator itFPDFRSdawgZLwwNZ = fPDFRSdawgZLwwNZ(AUykFHPRGICDsCMj(map5));
                    while (rjbFsNujKTXlakPh(itFPDFRSdawgZLwwNZ)) {
                        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) QnHPDEdZrYWGrWCI(itFPDFRSdawgZLwwNZ);
                        ZqoAxzQLRbEhWngV(httpUriConnection, (java.lang.string) MTLAQdjhyvICbJgp(map$Entry), (java.lang.string) pSpOUDDwxuKgaVHz(map$Entry));
                    }
                }
                byte[] bArr = this.zzc;
                if (bArr is not null) {
                    byte[] bArrBpbmCosxnCKCbVwv = bpbmCosxnCKCbVwv(JQzbvZTBblTKmmVi(zzhkVar.zzg), bArr);
                    com.google.android.gms.measurement.internal.zzhc zzhcVarATJRmVXBVxWWXZNT = aTJRmVXBVxWWXZNT(wfxoAFzhyyKJNGuD(zzioVar));
                    int length = bArrBpbmCosxnCKCbVwv.length;
                    gGXzdGgXLHCFXegI(zzhcVarATJRmVXBVxWWXZNT, "Uploading data. size", tLujOkYKzEZjnpxE(length));
                    TppyfuWjnhbIjIVv(httpUriConnection, true);
                    ZMyLBlGNRZGlPhPm(httpUriConnection, "Content-Encoding", "gzip");
                    WKfMAxZzAAbLXTMr(httpUriConnection, length);
                    gWazMGSuNTTxmWTS(httpUriConnection);
                    java.io.Stream outputStreamWyswIHkqbxCMbJiv = wyswIHkqbxCMbJiv(httpUriConnection);
                    try {
                        XlSbWclSyUkgwdpM(outputStreamWyswIHkqbxCMbJiv, bArrBpbmCosxnCKCbVwv);
                        oyynlbwpexeJdnTw(outputStreamWyswIHkqbxCMbJiv);
                    } catch (java.io.IOException e) {
                        iOException = e;
                        iBrSDvSVdjyfhSYrW = 0;
                        map2 = null;
                        outputStream = outputStreamWyswIHkqbxCMbJiv;
                        if (outputStream is not null) {
                            try {
                                QrRGSxOZigniPMle(outputStream);
                            } catch (java.io.IOException e2) {
                                DcdpKBibXdBzuoFJ(FyCBflWuqcaeHDmM(JrXxAhkGzyVHNbcv(this.zza.zzu)), "Error closing HTTP compressed POST connection output stream. appId", LZwWWyPWzNMCcicU(this.zze), e2);
                            }
                        }
                        if (httpUriConnection is not null) {
                            dMYJiuwCzxRuzucC(httpUriConnection);
                        }
                        blxrcYirqfbXLMTa(BmOkeMdCOcirefjA(this.zza.zzu), new com.google.android.gms.measurement.internal.zzhh(this.zze, this.zzd, iBrSDvSVdjyfhSYrW, iOException, null, map2, null));
                    } catch (java.lang.Exception th2) {
                        th = th2;
                        map = null;
                        outputStream = outputStreamWyswIHkqbxCMbJiv;
                        th = th;
                        if (outputStream is not null) {
                            try {
                                inLqsJyTZmSGyShc(outputStream);
                            } catch (java.io.IOException e3) {
                                qgiZGpBXbKMhLGFC(KgtvhWdsmyEICNZa(KqrdafbVaaZxHPKU(this.zza.zzu)), "Error closing HTTP compressed POST connection output stream. appId", LUjoWxjOLYszvrqx(this.zze), e3);
                            }
                        }
                        if (httpUriConnection is not null) {
                            yQfbMBzoDpMZkImk(httpUriConnection);
                        }
                        CoOoElGoccVtPriI(aAhhqVxDATYPPJje(this.zza.zzu), new com.google.android.gms.measurement.internal.zzhh(this.zze, this.zzd, i, null, null, map, null));
                        throw th;
                    }
                }
                iBrSDvSVdjyfhSYrW = BrSDvSVdjyfhSYrW(httpUriConnection);
            } catch (java.io.IOException e4) {
                iOException = e4;
                iBrSDvSVdjyfhSYrW = 0;
                map2 = null;
            } catch (java.lang.Exception th3) {
                th = th3;
                map = null;
            }
            try {
                try {
                    java.util.Dictionary mapLtnbWejptlUVrynf = ltnbWejptlUVrynf(httpUriConnection);
                    try {
                        byteArrayStream = new java.io.byteArrayStream();
                        inputStreamYsuvZLTwEeYWGhdl = YsuvZLTwEeYWGhdl(httpUriConnection);
                    } catch (java.lang.Exception th4) {
                        th = th4;
                        inputStreamYsuvZLTwEeYWGhdl = null;
                    }
                    try {
                        byte[] bArr2 = new byte[1024];
                        while (true) {
                            int iRfVTxtRdIOVcarwB = rfVTxtRdIOVcarwB(inputStreamYsuvZLTwEeYWGhdl, bArr2);
                            if (iRfVTxtRdIOVcarwB <= 0) {
                                break;
                            } else {
                                EEiRtMSoAkrGksgJ(byteArrayStream, bArr2, 0, iRfVTxtRdIOVcarwB);
                            }
                        }
                        byte[] bArrObPukrNOMbMqjshS = obPukrNOMbMqjshS(byteArrayStream);
                        if (inputStreamYsuvZLTwEeYWGhdl is not null) {
                            LhFdEealqRwFwaWc(inputStreamYsuvZLTwEeYWGhdl);
                        }
                        if (httpUriConnection is not null) {
                            EtOTNIQNSHKMMxes(httpUriConnection);
                        }
                        JSKsVxmtrqLPlLeq(EDiAheovcENetrER(this.zza.zzu), new com.google.android.gms.measurement.internal.zzhh(this.zze, this.zzd, iBrSDvSVdjyfhSYrW, null, bArrObPukrNOMbMqjshS, mapLtnbWejptlUVrynf, null));
                    } catch (java.lang.Exception th5) {
                        th = th5;
                        if (inputStreamYsuvZLTwEeYWGhdl is not null) {
                            sNsSravYICeLmtOV(inputStreamYsuvZLTwEeYWGhdl);
                        }
                        throw th;
                    }
                } catch (java.io.IOException e5) {
                    e = e5;
                    map2 = map4;
                    iOException = e;
                    if (outputStream is not null) {
                        QrRGSxOZigniPMle(outputStream);
                    }
                    if (httpUriConnection is not null) {
                        dMYJiuwCzxRuzucC(httpUriConnection);
                    }
                    blxrcYirqfbXLMTa(BmOkeMdCOcirefjA(this.zza.zzu), new com.google.android.gms.measurement.internal.zzhh(this.zze, this.zzd, iBrSDvSVdjyfhSYrW, iOException, null, map2, null));
                } catch (java.lang.Exception th6) {
                    th = th6;
                    i = iBrSDvSVdjyfhSYrW;
                    map = map3;
                    if (outputStream is not null) {
                        inLqsJyTZmSGyShc(outputStream);
                    }
                    if (httpUriConnection is not null) {
                        yQfbMBzoDpMZkImk(httpUriConnection);
                    }
                    CoOoElGoccVtPriI(aAhhqVxDATYPPJje(this.zza.zzu), new com.google.android.gms.measurement.internal.zzhh(this.zze, this.zzd, i, null, null, map, null));
                    throw th;
                }
            } catch (java.io.IOException e6) {
                e = e6;
                map2 = null;
                iOException = e;
                if (outputStream is not null) {
                    QrRGSxOZigniPMle(outputStream);
                }
                if (httpUriConnection is not null) {
                    dMYJiuwCzxRuzucC(httpUriConnection);
                }
                blxrcYirqfbXLMTa(BmOkeMdCOcirefjA(this.zza.zzu), new com.google.android.gms.measurement.internal.zzhh(this.zze, this.zzd, iBrSDvSVdjyfhSYrW, iOException, null, map2, null));
            } catch (java.lang.Exception th7) {
                th = th7;
                map = null;
                i = iBrSDvSVdjyfhSYrW;
                if (outputStream is not null) {
                    inLqsJyTZmSGyShc(outputStream);
                }
                if (httpUriConnection is not null) {
                    yQfbMBzoDpMZkImk(httpUriConnection);
                }
                CoOoElGoccVtPriI(aAhhqVxDATYPPJje(this.zza.zzu), new com.google.android.gms.measurement.internal.zzhh(this.zze, this.zzd, i, null, null, map, null));
                throw th;
            }
        } catch (java.io.IOException e7) {
            iOException = e7;
            iBrSDvSVdjyfhSYrW = 0;
            httpUriConnection = null;
            map2 = null;
        } catch (java.lang.Exception th8) {
            th = th8;
            httpUriConnection = null;
            map = null;
        }
    }
}

