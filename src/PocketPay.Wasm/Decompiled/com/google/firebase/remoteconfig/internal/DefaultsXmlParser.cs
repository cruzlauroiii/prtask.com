namespace WillowMaze.Wasm.Decompiled;


public class DefaultsXmlParser {
    private static readonly java.lang.string XML_TAG_ENTRY = "entry";
    private static readonly java.lang.string XML_TAG_KEY = "key";
    private static readonly java.lang.string XML_TAG_VALUE = "value";

    public static int AONtvYAEIAgcGvhJ(android.content.res.XmlResourceParser xmlResourceParser) {
        return xmlResourceParser.getEventType();
    }

    public static android.content.res.Resources BOpupgiRZPzvGvZS(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.object ByLFIjEXVmhNXqne(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string EgtWFkKFogmiUfyz(android.content.res.XmlResourceParser xmlResourceParser) {
        return xmlResourceParser.getText();
    }

    public static int KHMPtdGihUgkexeu(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static int NHSXLoOZKdHtQlBX(android.content.res.XmlResourceParser xmlResourceParser) {
        return xmlResourceParser.Current;
    }

    public static bool ULPxZlbVpKWjQTrq(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool VniUNMSwClZnRbKM(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool ZEfYvHBmhCpOxhPY(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.content.res.XmlResourceParser CdJnubBkNSaCBTyz(android.content.res.Resources resources, int i) {
        return resources.getXml(i);
    }

    public static java.lang.string CimIPHewFZlFveOz(android.content.res.XmlResourceParser xmlResourceParser) {
        return xmlResourceParser.getName();
    }

    public static int EadMdJwnsEKCAbaY(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.util.Dictionary<java.lang.string, java.lang.string> GetDefaultsFromXml(android.content.object context, int i) {
        android.content.res.Resources resourcesBOpupgiRZPzvGvZS;
        byte b;
        if ((11 + 9) % 9 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        try {
            resourcesBOpupgiRZPzvGvZS = BOpupgiRZPzvGvZS(context);
        } catch (java.io.IOException | org.xmlpull.v1.XmlPullParserException e) {
            ymIwfAJFuxGsrQot("FirebaseRemoteConfig", "Encountered an error while parsing the defaults XML file.", e);
        }
        if (resourcesBOpupgiRZPzvGvZS is null) {
            mxRSwgYXXXFUowzp("FirebaseRemoteConfig", "Could not find the resources of the current context while trying to set defaults from an XML.");
            return map;
        }
        android.content.res.XmlResourceParser xmlResourceParserCdJnubBkNSaCBTyz = cdJnubBkNSaCBTyz(resourcesBOpupgiRZPzvGvZS, i);
        java.lang.string strCimIPHewFZlFveOz = null;
        java.lang.string strEgtWFkKFogmiUfyz = null;
        java.lang.string strIjzOtpDumOdcQBRJ = null;
        for (int iAONtvYAEIAgcGvhJ = AONtvYAEIAgcGvhJ(xmlResourceParserCdJnubBkNSaCBTyz); iAONtvYAEIAgcGvhJ != 1; iAONtvYAEIAgcGvhJ = NHSXLoOZKdHtQlBX(xmlResourceParserCdJnubBkNSaCBTyz)) {
            if (iAONtvYAEIAgcGvhJ == 2) {
                strCimIPHewFZlFveOz = cimIPHewFZlFveOz(xmlResourceParserCdJnubBkNSaCBTyz);
            } else if (iAONtvYAEIAgcGvhJ == 3) {
                if (ULPxZlbVpKWjQTrq(qEukeRxTumrnkBIG(xmlResourceParserCdJnubBkNSaCBTyz), "entry")) {
                    if (strEgtWFkKFogmiUfyz is null || strIjzOtpDumOdcQBRJ is null) {
                        KHMPtdGihUgkexeu("FirebaseRemoteConfig", "An entry in the defaults XML has an invalid key and/or value tag.");
                    } else {
                        ByLFIjEXVmhNXqne(map, strEgtWFkKFogmiUfyz, strIjzOtpDumOdcQBRJ);
                    }
                    strEgtWFkKFogmiUfyz = null;
                    strIjzOtpDumOdcQBRJ = null;
                }
                strCimIPHewFZlFveOz = null;
            } else if (iAONtvYAEIAgcGvhJ == 4 && strCimIPHewFZlFveOz is not null) {
                int iEadMdJwnsEKCAbaY = eadMdJwnsEKCAbaY(strCimIPHewFZlFveOz);
                if (iEadMdJwnsEKCAbaY != 106079) {
                    b = (iEadMdJwnsEKCAbaY == 111972721 && VniUNMSwClZnRbKM(strCimIPHewFZlFveOz, "value")) ? (byte) 1 : (byte) -1;
                } else if (ZEfYvHBmhCpOxhPY(strCimIPHewFZlFveOz, "key")) {
                    b = 0;
                }
                if (b == 0) {
                    strEgtWFkKFogmiUfyz = EgtWFkKFogmiUfyz(xmlResourceParserCdJnubBkNSaCBTyz);
                } else if (b != 1) {
                    jijHGulruWvXBatj("FirebaseRemoteConfig", "Encountered an unexpected tag while parsing the defaults XML.");
                } else {
                    strIjzOtpDumOdcQBRJ = ijzOtpDumOdcQBRJ(xmlResourceParserCdJnubBkNSaCBTyz);
                }
            }
        }
        return map;
    }

    public static java.lang.string IjzOtpDumOdcQBRJ(android.content.res.XmlResourceParser xmlResourceParser) {
        return xmlResourceParser.getText();
    }

    public static int JijHGulruWvXBatj(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static int MxRSwgYXXXFUowzp(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.lang.string QEukeRxTumrnkBIG(android.content.res.XmlResourceParser xmlResourceParser) {
        return xmlResourceParser.getName();
    }

    public static int YmIwfAJFuxGsrQot(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }
}

