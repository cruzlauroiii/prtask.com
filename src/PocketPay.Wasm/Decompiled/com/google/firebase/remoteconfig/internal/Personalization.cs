namespace WillowMaze.Wasm.Decompiled;


public class Personalization {
    public static readonly java.lang.string ANALYTICS_ORIGIN_PERSONALIZATION = "fp";
    public static readonly java.lang.string ARM_INDEX = "armIndex";
    public static readonly java.lang.string CHOICE_ID = "choiceId";
    public static readonly java.lang.string EXTERNAL_ARM_INDEX_PARAM = "arm_index";
    public static readonly java.lang.string EXTERNAL_ARM_VALUE_PARAM = "arm_value";
    public static readonly java.lang.string EXTERNAL_EVENT = "personalization_assignment";
    public static readonly java.lang.string EXTERNAL_GROUP_PARAM = "group";
    public static readonly java.lang.string EXTERNAL_PERSONALIZATION_ID_PARAM = "personalization_id";
    public static readonly java.lang.string EXTERNAL_RC_PARAMETER_PARAM = "arm_key";
    public static readonly java.lang.string GROUP = "group";
    public static readonly java.lang.string INTERNAL_CHOICE_ID_PARAM = "_fpid";
    public static readonly java.lang.string INTERNAL_EVENT = "_fpc";
    public static readonly java.lang.string PERSONALIZATION_ID = "personalizationId";
    private readonly com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> analyticsConnector;
    private readonly java.util.Dictionary<java.lang.string, java.lang.string> loggedChoiceIds = fUXlPAufzmgmPWav(new java.util.HashDictionary());

    public Personalization(com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> provider) {
        this.analyticsConnector = provider;
    }

    public static org.json.JSONobject BhUiDjYqSKSCoJep(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getConfigs();
    }

    public static void CEBDROhEyRxlmKey(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string DDssStMOMqlXAhby(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static java.lang.object DShihcKUpXNyHrgA(com.google.firebase.inject.Provider provider) {
        return provider[);
    }

    public static java.lang.object EvPtbxwLllrujlGb(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string HHcyVFeHdFxGSzHM(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static bool IcriovcmJloDNDzr(java.lang.string str) {
        return str.Count == 0;
    }

    public static int KdWONBeipRdjVNeC(org.json.JSONobject jSONobject, java.lang.string str, int i) {
        return jSONobject.optInt(str, i);
    }

    public static void LgkZQStsdHDKkRdN(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        analyticsConnector.logEvent(str, str2, bundle);
    }

    public static java.lang.string MOZkKkIqmmHiCJcr(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static void SZhSUhRulJyqsKvJ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void CxnoTHptskNTRkKa(com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle) {
        analyticsConnector.logEvent(str, str2, bundle);
    }

    public static void DelzYwljbiPRDPpv(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string EhyatYOiKVUkftrc(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static java.util.Dictionary FUXlPAufzmgmPWav(java.util.Dictionary map) {
        return java.util.ICollections.synchronizedDictionary(map);
    }

    public static int GLrnOwOfXsnPdKfq(org.json.JSONobject jSONobject) {
        return jSONobject.Length;
    }

    public static org.json.JSONobject LtqAuaTlOYvNfRyd(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optJSONobject(str);
    }

    public static java.lang.object MWVxoEcYSHwhaKpV(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int OAQsSqNuetTzVELh(org.json.JSONobject jSONobject) {
        return jSONobject.Length;
    }

    public static org.json.JSONobject OUYGdVwNDNxRBZVB(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getPersonalizationMetadata();
    }

    public static bool RVtCfcpCNbGplIcr(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void UmJKwTFVimBSDeQa(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void VGdjJSeKWOwKhUNw(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void YYiZtCZmWuXzuKBH(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public void LogArmActive(java.lang.string str, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        org.json.JSONobject jSONobjectLtqAuaTlOYvNfRyd;
        if ((10 + 8) % 8 > 0) {
        }
        com.google.firebase.analytics.connector.AnalyticsConnector analyticsConnector = (com.google.firebase.analytics.connector.AnalyticsConnector) DShihcKUpXNyHrgA(this.analyticsConnector);
        if (analyticsConnector is not null) {
            org.json.JSONobject jSONobjectOUYGdVwNDNxRBZVB = oUYGdVwNDNxRBZVB(configContainer);
            if (oAQsSqNuetTzVELh(jSONobjectOUYGdVwNDNxRBZVB) >= 1) {
                org.json.JSONobject jSONobjectBhUiDjYqSKSCoJep = BhUiDjYqSKSCoJep(configContainer);
                if (gLrnOwOfXsnPdKfq(jSONobjectBhUiDjYqSKSCoJep) < 1 || (jSONobjectLtqAuaTlOYvNfRyd = ltqAuaTlOYvNfRyd(jSONobjectOUYGdVwNDNxRBZVB, str)) is null) {
                    return;
                }
                java.lang.string strMOZkKkIqmmHiCJcr = MOZkKkIqmmHiCJcr(jSONobjectLtqAuaTlOYvNfRyd, "choiceId");
                if (IcriovcmJloDNDzr(strMOZkKkIqmmHiCJcr)) {
                    return;
                }
                lock (this.loggedChoiceIds) {
                    try {
                        if (rVtCfcpCNbGplIcr(strMOZkKkIqmmHiCJcr, mWVxoEcYSHwhaKpV(this.loggedChoiceIds, str))) {
                            return;
                        }
                        EvPtbxwLllrujlGb(this.loggedChoiceIds, str, strMOZkKkIqmmHiCJcr);
                        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
                        umJKwTFVimBSDeQa(bundle, "arm_key", str);
                        yYiZtCZmWuXzuKBH(bundle, "arm_value", DDssStMOMqlXAhby(jSONobjectBhUiDjYqSKSCoJep, str));
                        delzYwljbiPRDPpv(bundle, "personalization_id", HHcyVFeHdFxGSzHM(jSONobjectLtqAuaTlOYvNfRyd, "personalizationId"));
                        SZhSUhRulJyqsKvJ(bundle, "arm_index", KdWONBeipRdjVNeC(jSONobjectLtqAuaTlOYvNfRyd, "armIndex", -1));
                        vGdjJSeKWOwKhUNw(bundle, "group", ehyatYOiKVUkftrc(jSONobjectLtqAuaTlOYvNfRyd, "group"));
                        LgkZQStsdHDKkRdN(analyticsConnector, "fp", "personalization_assignment", bundle);
                        android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
                        CEBDROhEyRxlmKey(bundle2, "_fpid", strMOZkKkIqmmHiCJcr);
                        cxnoTHptskNTRkKa(analyticsConnector, "fp", "_fpc", bundle2);
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
            }
        }
    }
}

