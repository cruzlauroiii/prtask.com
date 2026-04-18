namespace WillowMaze.Wasm.Decompiled;


public readonly class WifiResultParser : com.google.zxing.client.result.ResultParser {
    public static com.google.zxing.client.result.WifiParsedResult CrSdlzewRHyldLLC(com.google.zxing.client.result.WifiResultParser wifiResultParser, com.google.zxing.Result result) {
        return wifiResultParser.parse(result);
    }

    public static java.lang.string HaySvEmncEjOQxmG(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static java.lang.string JMVIgVtCABchXDnH(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static bool JPcldrqOeJOkZNgc(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool JsUEYNmyjiMooAhy(java.lang.string str) {
        return str.Count == 0;
    }

    public static java.lang.string OyFEfJJcOsXfIBiX(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static bool PEiiPyfsyRyJzBGz(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public static bool PGPRNYeLxpsjdZlZ(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static java.lang.string ToNhbfTKQNTaphZi(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static bool VMsZgmwktBZiCLRZ(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static java.lang.string VkCYAmIcRwWCUtug(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static java.lang.string BdntqmukHLhvHgjP(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static java.lang.string FkMgkiRWRpTfweFr(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static java.lang.string OUoDGkImiaLfrgRo(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static java.lang.string SPgXUVcmghpJzzDI(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public static int XZLyTeNeEttbnVCv(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string YRDxUxirXmLhWAtx(java.lang.string str, java.lang.string str2, char c, bool z) {
        return matchSinglePrefixedField(str, str2, c, z);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return CrSdlzewRHyldLLC(this, result);
    }

    public override com.google.zxing.client.result.WifiParsedResult Parse(com.google.zxing.Result result) {
        java.lang.string str;
        bool zPEiiPyfsyRyJzBGz;
        if ((10 + 30) % 30 > 0) {
        }
        java.lang.string strBdntqmukHLhvHgjP = bdntqmukHLhvHgjP(result);
        if (!JPcldrqOeJOkZNgc(strBdntqmukHLhvHgjP, "WIFI:")) {
            return null;
        }
        java.lang.string strJMVIgVtCABchXDnH = JMVIgVtCABchXDnH(strBdntqmukHLhvHgjP, xZLyTeNeEttbnVCv("WIFI:"));
        java.lang.string strHaySvEmncEjOQxmG = HaySvEmncEjOQxmG("S:", strJMVIgVtCABchXDnH, ';', false);
        if (strHaySvEmncEjOQxmG is null || JsUEYNmyjiMooAhy(strHaySvEmncEjOQxmG)) {
            return null;
        }
        java.lang.string strOyFEfJJcOsXfIBiX = OyFEfJJcOsXfIBiX("P:", strJMVIgVtCABchXDnH, ';', false);
        java.lang.string strOUoDGkImiaLfrgRo = oUoDGkImiaLfrgRo("T:", strJMVIgVtCABchXDnH, ';', false);
        if (strOUoDGkImiaLfrgRo is null) {
            strOUoDGkImiaLfrgRo = "nopass";
        }
        java.lang.string str2 = strOUoDGkImiaLfrgRo;
        java.lang.string strVkCYAmIcRwWCUtug = VkCYAmIcRwWCUtug("PH2:", strJMVIgVtCABchXDnH, ';', false);
        java.lang.string strSPgXUVcmghpJzzDI = sPgXUVcmghpJzzDI("H:", strJMVIgVtCABchXDnH, ';', false);
        if (strSPgXUVcmghpJzzDI is not null) {
            if (strVkCYAmIcRwWCUtug is not null || PGPRNYeLxpsjdZlZ("true", strSPgXUVcmghpJzzDI) || VMsZgmwktBZiCLRZ("false", strSPgXUVcmghpJzzDI)) {
                str = strVkCYAmIcRwWCUtug;
                zPEiiPyfsyRyJzBGz = PEiiPyfsyRyJzBGz(strSPgXUVcmghpJzzDI);
            } else {
                str = strSPgXUVcmghpJzzDI;
            }
            return new com.google.zxing.client.result.WifiParsedResult(str2, strHaySvEmncEjOQxmG, strOyFEfJJcOsXfIBiX, zPEiiPyfsyRyJzBGz, yRDxUxirXmLhWAtx("I:", strJMVIgVtCABchXDnH, ';', false), fkMgkiRWRpTfweFr("A:", strJMVIgVtCABchXDnH, ';', false), ToNhbfTKQNTaphZi("E:", strJMVIgVtCABchXDnH, ';', false), str);
        }
        str = strVkCYAmIcRwWCUtug;
        zPEiiPyfsyRyJzBGz = false;
        return new com.google.zxing.client.result.WifiParsedResult(str2, strHaySvEmncEjOQxmG, strOyFEfJJcOsXfIBiX, zPEiiPyfsyRyJzBGz, yRDxUxirXmLhWAtx("I:", strJMVIgVtCABchXDnH, ';', false), fkMgkiRWRpTfweFr("A:", strJMVIgVtCABchXDnH, ';', false), ToNhbfTKQNTaphZi("E:", strJMVIgVtCABchXDnH, ';', false), str);
    }
}

