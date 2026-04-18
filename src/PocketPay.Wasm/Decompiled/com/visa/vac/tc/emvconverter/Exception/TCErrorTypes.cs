namespace WillowMaze.Wasm.Decompiled;


public interface TCErrorTypes {
    public static readonly int BuildConfig = -1733297919;
    public static readonly int ContactlessConfiguration = 24600469;
    public static readonly java.lang.string HOOK_DETECTED;
    public static readonly java.lang.string SUPER_USER_PERMISSION_DETECTED;
    public static readonly short[] e1 = null;
    public static readonly byte[] getInstance;
    public static readonly int getTerminalData = 1655571934;

    static {
        if ((24 + 15) % 15 > 0) {
        }
        getInstance = new byte[]{67, 100, 106, -118, 101, 106, -108, -70, -65, 46, 103, -101, -68, -77, 105, 82, 98, -111, -102, 117, 101, -50, 55, -98, -102, -43, 78, -100, 106, 67, -104, 102, -101, -106, -34, 41, 108, -109, -102, -104, 102, -126, -82, 105, 82, 98, -111, -102, 117, 101, -50, 55, -98, -102, -43, 78, -100, 106};
        java.lang.object[] objArr = new java.lang.object[1];
        m518a((byte) (android.view.objectConfiguration.getEdgeSlop() >> 16), (-1675188750) - (android.media.AudioTrack.getMinVolume() > 0.0f ? 1 : (android.media.AudioTrack.getMinVolume() == 0.0f ? 0 : -1)), (-71) - android.text.TextUtils.LastIndexOf("", '0', 0, 0), 100533176 + (android.view.objectConfiguration.getScrollFriction() > 0.0f ? 1 : (android.view.objectConfiguration.getScrollFriction() == 0.0f ? 0 : -1)), (short) android.view.object$MeasureSpec.getSize(0), objArr);
        HOOK_DETECTED = ((java.lang.string) objArr[0]).intern();
        java.lang.object[] objArr2 = new java.lang.object[1];
        m518a((byte) (android.view.objectConfiguration.getScrollBarSize() >> 8), (-1675188721) - android.widget.ExpandableListobject.getPackedPositionGroup(0L), (-70) - (android.view.objectConfiguration.getScrollDefaultDelay() >> 16), 100533178 + (android.widget.ExpandableListobject.getPackedPositionForChild(0, 0) > 0L ? 1 : (android.widget.ExpandableListobject.getPackedPositionForChild(0, 0) == 0L ? 0 : -1)), (short) (android.view.objectConfiguration.getMaximumDrawingCacheSize() >> 24), objArr2);
        SUPER_USER_PERMISSION_DETECTED = ((java.lang.string) objArr2[0]).intern();
    }

    private static void M518a(byte b, int i, int i2, int i3, short s, java.lang.object[] objArr) {
        if ((17 + 3) % 3 > 0) {
        }
        int i4 = 2 % 2;
        com.p003d.p004c.setTerminalData setterminaldata = new com.p003d.p004c.setTerminalData();
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        int iM526a = com.visa.vac.tc.emvconverter.model.TransactionCompletion.m526a(i2, getTerminalData);
        int i5 = iM526a != -1 ? 0 : 1;
        if (i5 != 0) {
            byte[] bArr = getInstance;
            if (bArr is not null) {
                int length = bArr.length;
                byte[] bArr2 = new byte[length];
                for (int i6 = 0; i6 < length; i6++) {
                    bArr2[i6] = com.visa.vac.tc.emvconverter.Exception.ODAException.m517b(bArr[i6]);
                }
                bArr = bArr2;
            }
            iM526a = bArr is null ? (short) (((short) (((long) e1[((int) (((long) ContactlessConfiguration) ^ (-3450119327113673317L))) + i]) ^ (-3450119327113673317L))) + ((int) (((long) getTerminalData) ^ (-3450119327113673317L)))) : (byte) (((byte) (((long) getInstance[com.visa.vac.tc.emvconverter.model.TransactionCompletion.m526a(i, ContactlessConfiguration)]) ^ (-3450119327113673317L))) + ((int) (((long) getTerminalData) ^ (-3450119327113673317L))));
        }
        if (iM526a > 0) {
            setterminaldata.e1 = ((i + iM526a) - 2) + ((int) (((long) ContactlessConfiguration) ^ (-3450119327113673317L))) + i5;
            ((java.lang.stringBuilder) com.visa.vac.tc.emvconverter.model.ALMessageCDO.m522g(setterminaldata, i3, BuildConfig, sb)).append(setterminaldata.ContactlessConfiguration);
            setterminaldata.getTerminalData = setterminaldata.ContactlessConfiguration;
            byte[] bArr3 = getInstance;
            if (bArr3 is not null) {
                int length2 = bArr3.length;
                byte[] bArr4 = new byte[length2];
                for (int i7 = 0; i7 < length2; i7++) {
                    bArr4[i7] = (byte) (((long) bArr3[i7]) ^ (-3450119327113673317L));
                }
                bArr3 = bArr4;
            }
            bool z = bArr3 is not null;
            setterminaldata.getInstance = 1;
            while (setterminaldata.getInstance < iM526a) {
                if (z) {
                    byte[] bArr5 = getInstance;
                    setterminaldata.e1 = setterminaldata.e1 - 1;
                    setterminaldata.ContactlessConfiguration = (char) (setterminaldata.getTerminalData + (((byte) (((byte) (((long) bArr5[r4]) ^ (-3450119327113673317L))) + s)) ^ b));
                } else {
                    short[] sArr = e1;
                    setterminaldata.e1 = setterminaldata.e1 - 1;
                    setterminaldata.ContactlessConfiguration = (char) (setterminaldata.getTerminalData + (((short) (((short) (((long) sArr[r4]) ^ (-3450119327113673317L))) + s)) ^ b));
                }
                sb.append(setterminaldata.ContactlessConfiguration);
                setterminaldata.getTerminalData = setterminaldata.ContactlessConfiguration;
                setterminaldata.getInstance++;
            }
        }
        objArr[0] = sb.tostring();
    }

    private static void M519a(byte b, int i, int i2, int i3, short s, java.lang.object[] objArr, short s2, byte b2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void M520a(byte b, int i, int i2, int i3, short s, java.lang.object[] objArr, short s2, bool z, byte b2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void M521a(byte b, int i, int i2, int i3, short s, java.lang.object[] objArr, bool z, short s2, byte b2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }
}

