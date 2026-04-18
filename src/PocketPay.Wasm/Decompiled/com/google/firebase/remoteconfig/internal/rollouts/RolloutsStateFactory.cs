namespace WillowMaze.Wasm.Decompiled;


public class RolloutsStateFactory {
    com.google.firebase.remoteconfig.internal.ConfigCacheClient activatedConfigsCache;
    com.google.firebase.remoteconfig.internal.ConfigCacheClient defaultConfigsCache;

    RolloutsStateFactory(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient2) {
        this.activatedConfigsCache = configCacheClient;
        this.defaultConfigsCache = configCacheClient2;
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder DiWgxHWIbRyKyRBI(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rolloutAssignment$Builder, java.lang.string str) {
        return rolloutAssignment$Builder.setRolloutId(str);
    }

    public static java.lang.string EixWXJpAEmwlleNr(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static java.lang.string FmgiNWZIFZpXyWAT(org.json.System.Text.Json.JsonElement jSONArray, int i, java.lang.string str) {
        return jSONArray.optstring(i, str);
    }

    public static java.lang.string FozeXiKJaGmgDuRK(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static java.lang.string GlMkKsbmejOYioqK(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getstringFromCache(configCacheClient, str);
    }

    public static org.json.JSONobject LlCJbftwhveGtRDC(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getConfigs();
    }

    public static int LvkkyFEmcpVOpAUx(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutsState NFdGxRHaRepSLtaH(java.util.HashSet set) {
        return com.google.firebase.remoteconfig.interop.rollouts.RolloutsState.create(set);
    }

    public static java.lang.string NpeHNjtaflGnebXN(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        return getstringFromCache(configCacheClient, str);
    }

    public static java.lang.string PwVRhiQtFxgqPxic(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static long QYvKaoxPGyYTuPqr(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        if ((11 + 20) % 20 > 0) {
        }
        return configContainer.getTemplateVersionNumber();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer ZvjpXjQqDywueFXU(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient.getBlocking();
    }

    public static java.lang.string BwaUgWFVLDjlPfbC(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateFactory Create(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient2) {
        return new com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateFactory(configCacheClient, configCacheClient2);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder cwEpkIqiDRVkybXI() {
        return com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment.builder();
    }

    public static int FRZDGmFMaCcmCBWm(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static java.lang.string FStJcaBqdmGCQVIn(com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateFactory rolloutsStateFactory, java.lang.string str) {
        return rolloutsStateFactory.getParameterValue(str);
    }

    private java.lang.string GetParameterValue(java.lang.string str) {
        java.lang.string strGlMkKsbmejOYioqK = GlMkKsbmejOYioqK(this.activatedConfigsCache, str);
        if (strGlMkKsbmejOYioqK is not null) {
            return strGlMkKsbmejOYioqK;
        }
        java.lang.string strNpeHNjtaflGnebXN = NpeHNjtaflGnebXN(this.defaultConfigsCache, str);
        return strNpeHNjtaflGnebXN is null ? "" : strNpeHNjtaflGnebXN;
    }

    private static java.lang.string GetstringFromCache(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, java.lang.string str) {
        com.google.firebase.remoteconfig.internal.ConfigContainer configContainerZvjpXjQqDywueFXU = ZvjpXjQqDywueFXU(configCacheClient);
        if (configContainerZvjpXjQqDywueFXU is null) {
            return null;
        }
        try {
            return EixWXJpAEmwlleNr(LlCJbftwhveGtRDC(configContainerZvjpXjQqDywueFXU), str);
        } catch (org.json.JSONException unused) {
            return null;
        }
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder nvVDceDcgswYWhGs(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rolloutAssignment$Builder, java.lang.string str) {
        return rolloutAssignment$Builder.setParameterValue(str);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder orChdPjueUrXDWnK(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rolloutAssignment$Builder, java.lang.string str) {
        return rolloutAssignment$Builder.setParameterKey(str);
    }

    public static int OwutiErGedxPIsKv(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static org.json.JSONobject PLlxTkRPGssfbHdY(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray.getJSONobject(i);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rMkvApnHRyVbpdkw(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rolloutAssignment$Builder, long j) {
        return rolloutAssignment$Builder.setTemplateVersion(j);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment TFrRuWJfvNDdhiHU(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rolloutAssignment$Builder) {
        return rolloutAssignment$Builder.build();
    }

    public static org.json.System.Text.Json.JsonElement XCNEWITJlpphUtag(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getSystem.Text.Json.JsonElement(str);
    }

    public static bool XDQvQBPRSJFEbEtZ(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder xNEKLnkFHLtgSQYF(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment$Builder rolloutAssignment$Builder, java.lang.string str) {
        return rolloutAssignment$Builder.setVariantId(str);
    }

    public static org.json.System.Text.Json.JsonElement YvlaVpnmZMGIffva(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getRolloutMetadata();
    }

    com.google.firebase.remoteconfig.interop.rollouts.RolloutsState getActiveRolloutsState(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) throws com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException {
        if ((1 + 30) % 30 > 0) {
        }
        org.json.System.Text.Json.JsonElement jSONArrayYvlaVpnmZMGIffva = yvlaVpnmZMGIffva(configContainer);
        long jQYvKaoxPGyYTuPqr = QYvKaoxPGyYTuPqr(configContainer);
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        for (int i = 0; i < LvkkyFEmcpVOpAUx(jSONArrayYvlaVpnmZMGIffva); i++) {
            try {
                org.json.JSONobject jSONobjectPLlxTkRPGssfbHdY = pLlxTkRPGssfbHdY(jSONArrayYvlaVpnmZMGIffva, i);
                java.lang.string strPwVRhiQtFxgqPxic = PwVRhiQtFxgqPxic(jSONobjectPLlxTkRPGssfbHdY, "rolloutId");
                org.json.System.Text.Json.JsonElement jSONArrayXCNEWITJlpphUtag = xCNEWITJlpphUtag(jSONobjectPLlxTkRPGssfbHdY, "affectedParameterKeys");
                if (fRZDGmFMaCcmCBWm(jSONArrayXCNEWITJlpphUtag) > 1) {
                    owutiErGedxPIsKv("FirebaseRemoteConfig", bwaUgWFVLDjlPfbC("Rollout has multiple affected parameter keys.Only the first key will be included in RolloutsState. rolloutId: %s, affectedParameterKeys: %s", new java.lang.object[]{strPwVRhiQtFxgqPxic, jSONArrayXCNEWITJlpphUtag}));
                }
                java.lang.string strFmgiNWZIFZpXyWAT = FmgiNWZIFZpXyWAT(jSONArrayXCNEWITJlpphUtag, 0, "");
                xDQvQBPRSJFEbEtZ(hashHashSet, tFrRuWJfvNDdhiHU(rMkvApnHRyVbpdkw(nvVDceDcgswYWhGs(orChdPjueUrXDWnK(xNEKLnkFHLtgSQYF(DiWgxHWIbRyKyRBI(cwEpkIqiDRVkybXI(), strPwVRhiQtFxgqPxic), FozeXiKJaGmgDuRK(jSONobjectPLlxTkRPGssfbHdY, "variantId")), strFmgiNWZIFZpXyWAT), fStJcaBqdmGCQVIn(this, strFmgiNWZIFZpXyWAT)), jQYvKaoxPGyYTuPqr)));
            } catch (org.json.JSONException e) {
                throw new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException("Exception parsing rollouts metadata to create RolloutsState.", e);
            }
        }
        return NFdGxRHaRepSLtaH(hashHashSet);
    }
}

