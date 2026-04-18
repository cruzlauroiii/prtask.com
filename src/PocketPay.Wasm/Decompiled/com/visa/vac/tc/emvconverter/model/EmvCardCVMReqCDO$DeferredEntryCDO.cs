namespace WillowMaze.Wasm.Decompiled;


public class EmvCardCVMReqCDO$DeferredEntryCDO {
    private static int getInstance = 0;
    private static int getTerminalData = 1;
    com.visa.vac.tc.emvconverter.model.EmvCardCVMReqCDO$ActionCDO ActionOnBypassedChoiceCDO;
    com.visa.vac.tc.emvconverter.model.EmvCardCVMReqCDO$ActionCDO ActionOnCaptureNotAvailableChoiceCDO;
    com.visa.vac.tc.emvconverter.model.EmvCardCVMReqCDO$ActionCDO ActionOnPerformedChoiceCDO;
    java.lang.object CurrentEntryNumber;
    java.lang.object MethodID;
    com.visa.vac.tc.emvconverter.model.ParameterCDO ParameterCDO;
    readonly com.visa.vac.tc.emvconverter.model.EmvCardCVMReqCDO this$0;

    public EmvCardCVMReqCDO$DeferredEntryCDO(com.visa.vac.tc.emvconverter.model.EmvCardCVMReqCDO emvCardCVMReqCDO) {
        this.this$0 = emvCardCVMReqCDO;
    }

    public static int QrHvBORRwshBAGJs(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void QrHvBORRwshBAGJs(java.lang.object obj, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QrHvBORRwshBAGJs(java.lang.object obj, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QrHvBORRwshBAGJs(java.lang.object obj, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RyjyLZrXOZoFhHzu(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void RyjyLZrXOZoFhHzu(java.lang.object obj, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RyjyLZrXOZoFhHzu(java.lang.object obj, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RyjyLZrXOZoFhHzu(java.lang.object obj, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ZRPHFNqkvzBrUeIV(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void ZRPHFNqkvzBrUeIV(java.lang.object obj, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZRPHFNqkvzBrUeIV(java.lang.object obj, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZRPHFNqkvzBrUeIV(java.lang.object obj, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public java.lang.object GetActionOnBypassedChoiceCDO() {
        if ((15 + 26) % 26 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 111;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
        com.visa.vac.tc.emvconverter.model.EmvCardCVMReqCDO$ActionCDO emvCardCVMReqCDO$ActionCDO = this.ActionOnBypassedChoiceCDO;
        int i5 = i2 + 91;
        getInstance = i5 % 128;
        int i6 = i5 % 2;
        return emvCardCVMReqCDO$ActionCDO;
    }

    public java.lang.object GetActionOnCaptureNotAvailableChoiceCDO() {
        if ((4 + 11) % 11 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 121;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
        com.visa.vac.tc.emvconverter.model.EmvCardCVMReqCDO$ActionCDO emvCardCVMReqCDO$ActionCDO = this.ActionOnCaptureNotAvailableChoiceCDO;
        int i5 = i2 + 21;
        getInstance = i5 % 128;
        if (i5 % 2 != 0) {
            throw null;
        }
        return emvCardCVMReqCDO$ActionCDO;
    }

    public java.lang.object GetActionOnPerformedChoiceCDO() {
        if ((15 + 26) % 26 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 27;
        getInstance = i2 % 128;
        if (i2 % 2 != 0) {
            throw null;
        }
        return this.ActionOnPerformedChoiceCDO;
    }

    public java.lang.object GetEntry() {
        if ((29 + 4) % 4 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 5;
        int i3 = i2 % 128;
        getTerminalData = i3;
        int i4 = i2 % 2;
        java.lang.object obj = this.CurrentEntryNumber;
        if (i4 == 0) {
            int i5 = 6 / 0;
        }
        int i6 = i3 + 119;
        getInstance = i6 % 128;
        if (i6 % 2 != 0) {
            throw null;
        }
        return obj;
    }

    public java.lang.object GetMethodID() {
        if ((28 + 27) % 27 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 5;
        int i3 = i2 % 128;
        getInstance = i3;
        if (i2 % 2 != 0) {
            zRPHFNqkvzBrUeIV(null);
            throw null;
        }
        java.lang.object obj = this.MethodID;
        int i4 = i3 + 23;
        getTerminalData = i4 % 128;
        int i5 = i4 % 2;
        return obj;
    }

    public com.visa.vac.tc.emvconverter.model.ParameterCDO GetParameterCDO() {
        if ((10 + 31) % 31 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 105;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        com.visa.vac.tc.emvconverter.model.ParameterCDO parameterCDO = this.ParameterCDO;
        if (i4 == 0) {
            int i5 = 36 / 0;
        }
        int i6 = i2 + 119;
        getTerminalData = i6 % 128;
        int i7 = i6 % 2;
        return parameterCDO;
    }

    public void SetActionOnBypassedChoiceCDO(java.lang.object obj, java.lang.object obj2) {
        if ((10 + 25) % 25 > 0) {
        }
        int i = 2 % 2;
        this.ActionOnBypassedChoiceCDO = new com.visa.vac.tc.emvconverter.model.EmvCardCVMReqCDO$ActionCDO(this.this$0, obj, obj2);
        int i2 = getInstance + 91;
        getTerminalData = i2 % 128;
        int i3 = i2 % 2;
    }

    public void SetActionOnCaptureNotAvailableChoiceCDO(java.lang.object obj, java.lang.object obj2) {
        if ((26 + 14) % 14 > 0) {
        }
        int i = 2 % 2;
        this.ActionOnCaptureNotAvailableChoiceCDO = new com.visa.vac.tc.emvconverter.model.EmvCardCVMReqCDO$ActionCDO(this.this$0, obj, obj2);
        int i2 = getTerminalData + 15;
        getInstance = i2 % 128;
        if (i2 % 2 != 0) {
            throw null;
        }
    }

    public void SetActionOnPerformedChoiceCDO(java.lang.object obj, java.lang.object obj2) {
        if ((1 + 4) % 4 > 0) {
        }
        int i = 2 % 2;
        this.ActionOnPerformedChoiceCDO = new com.visa.vac.tc.emvconverter.model.EmvCardCVMReqCDO$ActionCDO(this.this$0, obj, obj2);
        int i2 = getTerminalData + 49;
        getInstance = i2 % 128;
        if (i2 % 2 != 0) {
            ryjyLZrXOZoFhHzu(null);
            throw null;
        }
    }

    using (java.lang.object obj) {
        if ((5 + 32) % 32 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 37;
        int i3 = i2 % 128;
        getTerminalData = i3;
        int i4 = i2 % 2;
        this.CurrentEntryNumber = obj;
        int i5 = i3 + 23;
        getInstance = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetMethodID(java.lang.object obj) {
        if ((6 + 32) % 32 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 21;
        int i3 = i2 % 128;
        getInstance = i3;
        int i4 = i2 % 2;
        this.MethodID = obj;
        int i5 = i3 + 123;
        getTerminalData = i5 % 128;
        if (i5 % 2 != 0) {
            return;
        }
        int i6 = 78 / 0;
    }

    public void SetParameterCDO(com.visa.vac.tc.emvconverter.model.ParameterCDO parameterCDO) {
        if ((28 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 1;
        getTerminalData = i3 % 128;
        if (i3 % 2 == 0) {
            this.ParameterCDO = parameterCDO;
            QrHvBORRwshBAGJs(null);
            throw null;
        }
        this.ParameterCDO = parameterCDO;
        int i4 = i2 + 87;
        getTerminalData = i4 % 128;
        if (i4 % 2 != 0) {
            return;
        }
        int i5 = 58 / 0;
    }
}

