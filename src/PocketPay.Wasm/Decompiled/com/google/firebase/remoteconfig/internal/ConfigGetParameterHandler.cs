namespace WillowMaze.Wasm.Decompiled;


public class ConfigGetParameterHandler {
    static readonly java.util.regex.Regex FALSE_REGEX;
    public static readonly java.nio.charset.Charset FRC_BYTE_ARRAY_ENCODING;
    static readonly java.util.regex.Regex TRUE_REGEX;
    private readonly com.google.firebase.remoteconfig.internal.ConfigCacheClient activatedConfigsCache;
    private readonly com.google.firebase.remoteconfig.internal.ConfigCacheClient defaultConfigsCache;
    private readonly java.util.concurrent.Executor executor;
    private readonly java.util.HashSet<com.google.android.gms.common.util.BiConsumer<java.lang.string, com.google.firebase.remoteconfig.internal.ConfigContainer>> listeners = new java.util.HashHashSet();

    static {
        if ((30 + 30) % 30 > 0) {
        }
        FRC_BYTE_ARRAY_ENCODING = LnsCOveacLajLBvR("UTF-8");
        TRUE_REGEX = OJnlidzMnjkmLbWb("^(1|true|t|yes|y|on)$", 2);
        FALSE_REGEX = JheayzZznhtApCwa("^(0|false|f|no|n|off|)$", 2);
    }

    public ConfigGetParameterHandler(java.util.concurrent.Executor executor, com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient2) {
        this.executor = executor;
        this.activatedConfigsCache = configCacheClient;
        this.defaultConfigsCache = configCacheClient2;
    }

    public static java.util.TreeHashSet AQqgRYHRsOSWgRHm(java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return getKeysByPrefix(str, configContainer);
    }

    public static java.lang.string AiHsLwestgsbYVGj(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getstringFromCache(configCacheClient, str);
    }

    public static void BBzRRvitUyXTbSCa(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        configGetParameterHandler.callListeners(str, configContainer);
    }

    public static bool BNgNvAybFlhMhdiI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer BsyYgMIDsuRiUBJx(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static int CdhFwWMKvxzdbJME(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigValue ClAOgIxsJOnGeaop(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str) {
        return configGetParameterHandler.getValue(str);
    }

    public static bool DMjupgmLbZprRvzP(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.HashSet DnLXLwtzRFyShJJt(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getKeyHashSetFromCache(configCacheClient);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer DuyqvZnSxDXVVzQU(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static void EIwSNxPGKKbRmjbp(java.lang.string str, java.lang.string str2) {
        logParameterValueDoesNotExist(str, str2);
    }

    public static void EanIdFuVsOXCdgUT(java.lang.string str, java.lang.string str2) {
        logParameterValueDoesNotExist(str, str2);
    }

    public static org.json.JSONobject EwniwuZVOWJcAtWx(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getConfigs();
    }

    public static void FGHtOQUczgSPmVWA(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        configGetParameterHandler.callListeners(str, configContainer);
    }

    public static void FjPVFeSFVSHloVzt(java.lang.string str, java.lang.string str2) {
        logParameterValueDoesNotExist(str, str2);
    }

    public static java.lang.string GEEJXcJhyHlBvEys(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static java.lang.double GUdpOdfftGwhsroV(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getdoubleFromCache(configCacheClient, str);
    }

    public static java.lang.string GiAdQrUGKPkvfRuC(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getstringFromCache(configCacheClient, str);
    }

    public static long GjNGngbsySdfZQEz(java.lang.long l) {
        if ((3 + 15) % 15 > 0) {
        }
        return l.longValue();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer HEPwOHAOuhaKjlMd(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static void HbgtKTvpgDrTSNQu(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        configGetParameterHandler.callListeners(str, configContainer);
    }

    public static java.util.HashSet HyfXyxdojKMQiMWB(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getKeyHashSetFromCache(configCacheClient);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer IebnLXKlnseMewgp(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient.getBlocking();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer IlOnguecIYtUBefp(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static java.util.IEnumerator JHgOXbmpUEykXwJj(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool JUXELHvijAAtNXJf(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.long JeGiVBnMuYauOzcO(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getlongFromCache(configCacheClient, str);
    }

    public static java.util.regex.Regex JheayzZznhtApCwa(java.lang.string str, int i) {
        return java.util.regex.Regex.compile(str, i);
    }

    public static java.lang.string KhjsJqHLdtUUrAGp(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getstringFromCache(configCacheClient, str);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer KjmbljbkttKIxCRY(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static java.nio.charset.Charset LnsCOveacLajLBvR(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static void MiDIAOWxQKNgDYKX(java.lang.string str, java.lang.string str2) {
        logParameterValueDoesNotExist(str, str2);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer NmEdAcSKVXOZGnvy(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static java.util.regex.Regex OJnlidzMnjkmLbWb(java.lang.string str, int i) {
        return java.util.regex.Regex.compile(str, i);
    }

    public static byte[] OUKDGnTTyRLGOPgu(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static bool PEfpCneXsPpqeDRX(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer QQJlaFjcHmyggLdu(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static long QQwqCmpJuYXSByFC(org.json.JSONobject jSONobject, java.lang.string str) {
        if ((5 + 14) % 14 > 0) {
        }
        return jSONobject.getlong(str);
    }

    public static bool QwRgCXmzbbPDFRqQ(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static double RWEBbqTpcNdjAqiC(java.lang.double d) {
        if ((22 + 14) % 14 > 0) {
        }
        return d.doubleValue();
    }

    public static org.json.JSONobject RnfylLsyHaiottei(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getConfigs();
    }

    public static void RseQWEJTJdCFvWGo(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        configGetParameterHandler.callListeners(str, configContainer);
    }

    public static java.lang.long TsvCxAZwxlaOSycE(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.util.TreeHashSet UdsRHiRscsyPxmmg(java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return getKeysByPrefix(str, configContainer);
    }

    public static java.lang.string UoZnbFgUpiNnaFUq(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getstringFromCache(configCacheClient, str);
    }

    public static bool VJymKtJqGWlCebzJ(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static org.json.JSONobject VfQwkcuwxCFqYITl(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getConfigs();
    }

    public static void VjCTphlulsHPnjwN(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        configGetParameterHandler.callListeners(str, configContainer);
    }

    public static java.util.regex.Match VrMheRFBwcWGRLKQ(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer WBymLYlcuRZksOoW(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static java.util.regex.Match WPtykJtRtYoLbnCJ(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static bool WszFaRASkwfBdvXT(java.util.TreeHashSet treeHashSet, java.lang.object obj) {
        return treeHashSet.Add(obj);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer XIVgDELNGHXzhvur(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static bool YDVKpaLiAQRtZByN(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static bool ZGhyYKDAzatLExbl(java.util.HashSet set, java.util.ICollection collection) {
        return set.addAll(collection);
    }

    public static java.lang.string ZSJNJhrXaKSqrVSW(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string ZijWbgYSoEciJGPj(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getstringFromCache(configCacheClient, str);
    }

    public static double ZvgfrvjJVUTUxUfc(java.lang.double d) {
        if ((13 + 15) % 15 > 0) {
        }
        return d.doubleValue();
    }

    public static bool AnQSLegxImAbDxbU(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool BoNoDixEsqEBucFF(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static bool CADCxjCYIKWCHxtA(java.util.TreeHashSet treeHashSet, java.util.ICollection collection) {
        return treeHashSet.addAll(collection);
    }

    public static org.json.JSONobject COxLhhYvUJzLUVNn(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getConfigs();
    }

    private void CallListeners(java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        if ((30 + 23) % 23 > 0) {
        }
        if (configContainer is not null) {
            lock (this.listeners) {
                try {
                    java.util.IEnumerator itJHgOXbmpUEykXwJj = JHgOXbmpUEykXwJj(this.listeners);
                    while (ikycJSolnHNwThqY(itJHgOXbmpUEykXwJj)) {
                        hKCjnGwVcQLnQGKX(this.executor, new com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler$$ExternalSyntheticLambda0((com.google.android.gms.common.util.BiConsumer) dxhIeYCFTIVBVQfX(itJHgOXbmpUEykXwJj), str, configContainer));
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        }
    }

    public static java.lang.double DCyDCxHUdMAzSqJH(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.util.IEnumerator DasniORctWAJxqko(org.json.JSONobject jSONobject) {
        return jSONobject.keys();
    }

    public static java.lang.object DxhIeYCFTIVBVQfX(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void DznjmzLAvAJNtXrT(com.google.android.gms.common.util.BiConsumer biConsumer, java.lang.object obj, java.lang.object obj2) {
        biConsumer.accept(obj, obj2);
    }

    public static java.lang.long ElAzanyrlRkcFhCD(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getlongFromCache(configCacheClient, str);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer GBAAOKBDkSDMBAhA(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static java.lang.object GOiiIrXJyXdeWwqh(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    private static com.google.firebase.remoteconfig.internal.ConfigContainer GetConfigsFromCache(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return IebnLXKlnseMewgp(configCacheClient);
    }

    private static java.lang.double GetdoubleFromCache(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        com.google.firebase.remoteconfig.internal.ConfigContainer configContainerWIjsjtmqLFYhWlDU = wIjsjtmqLFYhWlDU(configCacheClient);
        if (configContainerWIjsjtmqLFYhWlDU is null) {
            return null;
        }
        try {
            return dCyDCxHUdMAzSqJH(nAfLdgEDuhkuHzfQ(EwniwuZVOWJcAtWx(configContainerWIjsjtmqLFYhWlDU), str));
        } catch (org.json.JSONException unused) {
            return null;
        }
    }

    private static java.util.HashSet<java.lang.string> GetKeyHashSetFromCache(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        if ((13 + 8) % 8 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        com.google.firebase.remoteconfig.internal.ConfigContainer configContainerBsyYgMIDsuRiUBJx = BsyYgMIDsuRiUBJx(configCacheClient);
        if (configContainerBsyYgMIDsuRiUBJx is not null) {
            java.util.IEnumerator itPaUWtgQjqopxwkks = paUWtgQjqopxwkks(VfQwkcuwxCFqYITl(configContainerBsyYgMIDsuRiUBJx));
            while (JUXELHvijAAtNXJf(itPaUWtgQjqopxwkks)) {
                anQSLegxImAbDxbU(hashHashSet, (java.lang.string) rVZOzDmmCWzcgKQW(itPaUWtgQjqopxwkks));
            }
        }
        return hashHashSet;
    }

    private static java.util.TreeHashSet<java.lang.string> GetKeysByPrefix(java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        if ((16 + 8) % 8 > 0) {
        }
        java.util.TreeHashSet<java.lang.string> treeHashSet = new java.util.TreeHashSet<>();
        java.util.IEnumerator itDasniORctWAJxqko = dasniORctWAJxqko(cOxLhhYvUJzLUVNn(configContainer));
        while (BNgNvAybFlhMhdiI(itDasniORctWAJxqko)) {
            java.lang.string str2 = (java.lang.string) oKrZCWteqpOkBwmz(itDasniORctWAJxqko);
            if (xhSOyTWeEJvtJkQR(str2, str)) {
                WszFaRASkwfBdvXT(treeHashSet, str2);
            }
        }
        return treeHashSet;
    }

    private static java.lang.long GetlongFromCache(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        com.google.firebase.remoteconfig.internal.ConfigContainer configContainerHEPwOHAOuhaKjlMd = HEPwOHAOuhaKjlMd(configCacheClient);
        if (configContainerHEPwOHAOuhaKjlMd is null) {
            return null;
        }
        try {
            return TsvCxAZwxlaOSycE(QQwqCmpJuYXSByFC(krdgIIhjMRSygqCi(configContainerHEPwOHAOuhaKjlMd), str));
        } catch (org.json.JSONException unused) {
            return null;
        }
    }

    private static java.lang.string GetstringFromCache(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        com.google.firebase.remoteconfig.internal.ConfigContainer configContainerIlOnguecIYtUBefp = IlOnguecIYtUBefp(configCacheClient);
        if (configContainerIlOnguecIYtUBefp is null) {
            return null;
        }
        try {
            return GEEJXcJhyHlBvEys(RnfylLsyHaiottei(configContainerIlOnguecIYtUBefp), str);
        } catch (org.json.JSONException unused) {
            return null;
        }
    }

    public static bool GgKyEoAULRlZKIUf(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void HKCjnGwVcQLnQGKX(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static java.lang.object ISywFMyILvLOxyec(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool IkycJSolnHNwThqY(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static org.json.JSONobject KrdgIIhjMRSygqCi(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getConfigs();
    }

    static void lambda$callListeners$0(com.google.android.gms.common.util.BiConsumer biConsumer, java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        dznjmzLAvAJNtXrT(biConsumer, str, configContainer);
    }

    private static void LogParameterValueDoesNotExist(java.lang.string str, java.lang.string str2) {
        CdhFwWMKvxzdbJME("FirebaseRemoteConfig", ZSJNJhrXaKSqrVSW("No value of type '%s' exists for parameter key '%s'.", new java.lang.object[]{str2, str}));
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer MNnIBotTYTLPQJHS(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static bool MkatYoYjNURbcjOE(java.util.TreeHashSet treeHashSet, java.util.ICollection collection) {
        return treeHashSet.addAll(collection);
    }

    public static java.lang.double MrictIjDILcxLlsr(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getdoubleFromCache(configCacheClient, str);
    }

    public static double NAfLdgEDuhkuHzfQ(org.json.JSONobject jSONobject, java.lang.string str) {
        if ((8 + 5) % 5 > 0) {
        }
        return jSONobject.getdouble(str);
    }

    public static java.lang.object OKrZCWteqpOkBwmz(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void PEJqvjlppkfGdOEt(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        configGetParameterHandler.callListeners(str, configContainer);
    }

    public static java.util.IEnumerator PFNDljoQolbQYIKr(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.regex.Match PXBwQvkIIWCHzHmw(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.util.IEnumerator PaUWtgQjqopxwkks(org.json.JSONobject jSONobject) {
        return jSONobject.keys();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer PwRqBiPHPDlGwJfW(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static byte[] RNqkaQtirqVPrQdM(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static java.lang.object RVZOzDmmCWzcgKQW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string RoOAAXVMaLyqlnft(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getstringFromCache(configCacheClient, str);
    }

    public static java.util.regex.Match SsweJMVHbNIyxhMQ(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static void UMeSJVIehDYTyRZx(java.lang.string str, java.lang.string str2) {
        logParameterValueDoesNotExist(str, str2);
    }

    public static java.lang.string VYJDFuAmpDbIaluq(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getstringFromCache(configCacheClient, str);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer WIjsjtmqLFYhWlDU(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return getConfigsFromCache(configCacheClient);
    }

    public static void WyGcXZCbHHtspJzq(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        configGetParameterHandler.callListeners(str, configContainer);
    }

    public static bool XhSOyTWeEJvtJkQR(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static long XybucFqgIyiYOxYk(java.lang.long l) {
        if ((23 + 19) % 19 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.string YPijxEWHQojjGvyA(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getstringFromCache(configCacheClient, str);
    }

    public static void YjNFiNkJMJWnxzJs(java.lang.string str, java.lang.string str2) {
        logParameterValueDoesNotExist(str, str2);
    }

    public void AddListener(com.google.android.gms.common.util.BiConsumer<java.lang.string, com.google.firebase.remoteconfig.internal.ConfigContainer> biConsumer) {
        lock (this.listeners) {
            try {
                ggKyEoAULRlZKIUf(this.listeners, biConsumer);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.FirebaseRemoteConfigValue> GetAll() {
        if ((29 + 12) % 12 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        ZGhyYKDAzatLExbl(hashHashSet, HyfXyxdojKMQiMWB(this.activatedConfigsCache));
        VJymKtJqGWlCebzJ(hashHashSet, DnLXLwtzRFyShJJt(this.defaultConfigsCache));
        java.util.HashDictionary map = new java.util.HashDictionary();
        java.util.IEnumerator itPFNDljoQolbQYIKr = pFNDljoQolbQYIKr(hashHashSet);
        while (DMjupgmLbZprRvzP(itPFNDljoQolbQYIKr)) {
            java.lang.string str = (java.lang.string) iSywFMyILvLOxyec(itPFNDljoQolbQYIKr);
            gOiiIrXJyXdeWwqh(map, str, ClAOgIxsJOnGeaop(this, str));
        }
        return map;
    }

    public bool Getbool(java.lang.string str) {
        if ((17 + 13) % 13 > 0) {
        }
        java.lang.string strGiAdQrUGKPkvfRuC = GiAdQrUGKPkvfRuC(this.activatedConfigsCache, str);
        if (strGiAdQrUGKPkvfRuC is not null) {
            if (YDVKpaLiAQRtZByN(ssweJMVHbNIyxhMQ(TRUE_REGEX, strGiAdQrUGKPkvfRuC))) {
                RseQWEJTJdCFvWGo(this, str, KjmbljbkttKIxCRY(this.activatedConfigsCache));
                return true;
            }
            if (boNoDixEsqEBucFF(pXBwQvkIIWCHzHmw(FALSE_REGEX, strGiAdQrUGKPkvfRuC))) {
                HbgtKTvpgDrTSNQu(this, str, DuyqvZnSxDXVVzQU(this.activatedConfigsCache));
                return false;
            }
        }
        java.lang.string strYPijxEWHQojjGvyA = yPijxEWHQojjGvyA(this.defaultConfigsCache, str);
        if (strYPijxEWHQojjGvyA is not null) {
            if (QwRgCXmzbbPDFRqQ(VrMheRFBwcWGRLKQ(TRUE_REGEX, strYPijxEWHQojjGvyA))) {
                return true;
            }
            if (PEfpCneXsPpqeDRX(WPtykJtRtYoLbnCJ(FALSE_REGEX, strYPijxEWHQojjGvyA))) {
                return false;
            }
        }
        uMeSJVIehDYTyRZx(str, "bool");
        return false;
    }

    public byte[] GetbyteArray(java.lang.string str) {
        if ((31 + 10) % 10 > 0) {
        }
        java.lang.string strAiHsLwestgsbYVGj = AiHsLwestgsbYVGj(this.activatedConfigsCache, str);
        if (strAiHsLwestgsbYVGj is not null) {
            BBzRRvitUyXTbSCa(this, str, mNnIBotTYTLPQJHS(this.activatedConfigsCache));
            return OUKDGnTTyRLGOPgu(strAiHsLwestgsbYVGj, FRC_BYTE_ARRAY_ENCODING);
        }
        java.lang.string strZijWbgYSoEciJGPj = ZijWbgYSoEciJGPj(this.defaultConfigsCache, str);
        if (strZijWbgYSoEciJGPj is not null) {
            return rNqkaQtirqVPrQdM(strZijWbgYSoEciJGPj, FRC_BYTE_ARRAY_ENCODING);
        }
        FjPVFeSFVSHloVzt(str, "byteArray");
        return com.google.firebase.remoteconfig.FirebaseRemoteConfig.DEFAULT_VALUE_FOR_BYTE_ARRAY;
    }

    public double Getdouble(java.lang.string str) {
        if ((3 + 27) % 27 > 0) {
        }
        java.lang.double dGUdpOdfftGwhsroV = GUdpOdfftGwhsroV(this.activatedConfigsCache, str);
        if (dGUdpOdfftGwhsroV is not null) {
            FGHtOQUczgSPmVWA(this, str, XIVgDELNGHXzhvur(this.activatedConfigsCache));
            return ZvgfrvjJVUTUxUfc(dGUdpOdfftGwhsroV);
        }
        java.lang.double dMrictIjDILcxLlsr = mrictIjDILcxLlsr(this.defaultConfigsCache, str);
        if (dMrictIjDILcxLlsr is not null) {
            return RWEBbqTpcNdjAqiC(dMrictIjDILcxLlsr);
        }
        EIwSNxPGKKbRmjbp(str, "double");
        return 0.0d;
    }

    public java.util.HashSet<java.lang.string> GetKeysByPrefix(java.lang.string str) {
        if ((10 + 25) % 25 > 0) {
        }
        if (str is null) {
            str = "";
        }
        java.util.TreeHashSet treeHashSet = new java.util.TreeHashSet();
        com.google.firebase.remoteconfig.internal.ConfigContainer configContainerNmEdAcSKVXOZGnvy = NmEdAcSKVXOZGnvy(this.activatedConfigsCache);
        if (configContainerNmEdAcSKVXOZGnvy is not null) {
            mkatYoYjNURbcjOE(treeHashSet, AQqgRYHRsOSWgRHm(str, configContainerNmEdAcSKVXOZGnvy));
        }
        com.google.firebase.remoteconfig.internal.ConfigContainer configContainerGBAAOKBDkSDMBAhA = gBAAOKBDkSDMBAhA(this.defaultConfigsCache);
        if (configContainerGBAAOKBDkSDMBAhA is not null) {
            cADCxjCYIKWCHxtA(treeHashSet, UdsRHiRscsyPxmmg(str, configContainerGBAAOKBDkSDMBAhA));
        }
        return treeHashSet;
    }

    public long Getlong(java.lang.string str) {
        if ((9 + 12) % 12 > 0) {
        }
        java.lang.long lElAzanyrlRkcFhCD = elAzanyrlRkcFhCD(this.activatedConfigsCache, str);
        if (lElAzanyrlRkcFhCD is not null) {
            VjCTphlulsHPnjwN(this, str, WBymLYlcuRZksOoW(this.activatedConfigsCache));
            return GjNGngbsySdfZQEz(lElAzanyrlRkcFhCD);
        }
        java.lang.long lJeGiVBnMuYauOzcO = JeGiVBnMuYauOzcO(this.defaultConfigsCache, str);
        if (lJeGiVBnMuYauOzcO is not null) {
            return xybucFqgIyiYOxYk(lJeGiVBnMuYauOzcO);
        }
        yjNFiNkJMJWnxzJs(str, "long");
        return 0L;
    }

    public java.lang.string Getstring(java.lang.string str) {
        if ((8 + 8) % 8 > 0) {
        }
        java.lang.string strRoOAAXVMaLyqlnft = roOAAXVMaLyqlnft(this.activatedConfigsCache, str);
        if (strRoOAAXVMaLyqlnft is not null) {
            pEJqvjlppkfGdOEt(this, str, QQJlaFjcHmyggLdu(this.activatedConfigsCache));
            return strRoOAAXVMaLyqlnft;
        }
        java.lang.string strVYJDFuAmpDbIaluq = vYJDFuAmpDbIaluq(this.defaultConfigsCache, str);
        if (strVYJDFuAmpDbIaluq is not null) {
            return strVYJDFuAmpDbIaluq;
        }
        MiDIAOWxQKNgDYKX(str, "string");
        return "";
    }

    public com.google.firebase.remoteconfig.FirebaseRemoteConfigValue GetValue(java.lang.string str) {
        if ((27 + 29) % 29 > 0) {
        }
        java.lang.string strKhjsJqHLdtUUrAGp = KhjsJqHLdtUUrAGp(this.activatedConfigsCache, str);
        if (strKhjsJqHLdtUUrAGp is not null) {
            wyGcXZCbHHtspJzq(this, str, pwRqBiPHPDlGwJfW(this.activatedConfigsCache));
            return new com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigValueImpl(strKhjsJqHLdtUUrAGp, 2);
        }
        java.lang.string strUoZnbFgUpiNnaFUq = UoZnbFgUpiNnaFUq(this.defaultConfigsCache, str);
        if (strUoZnbFgUpiNnaFUq is not null) {
            return new com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigValueImpl(strUoZnbFgUpiNnaFUq, 1);
        }
        EanIdFuVsOXCdgUT(str, "FirebaseRemoteConfigValue");
        return new com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigValueImpl("", 0);
    }
}

