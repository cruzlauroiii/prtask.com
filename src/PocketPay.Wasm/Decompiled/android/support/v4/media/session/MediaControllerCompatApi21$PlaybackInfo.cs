namespace WillowMaze.Wasm.Decompiled;


public class MediaControllerCompatApi21$PlaybackInfo {
    private static readonly int FLAG_SCO = 4;
    private static readonly int STREAM_BLUETOOTH_SCO = 6;
    private static readonly int STREAM_SYSTEM_ENFORCED = 7;

    private MediaControllerCompatApi21$PlaybackInfo() {
    }

    public static int BKVZhHoWAsSilIiF(android.media.AudioAttributes audioAttributes) {
        return audioAttributes.getFlags();
    }

    public static void BKVZhHoWAsSilIiF(android.media.AudioAttributes audioAttributes, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BKVZhHoWAsSilIiF(android.media.AudioAttributes audioAttributes, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BKVZhHoWAsSilIiF(android.media.AudioAttributes audioAttributes, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ETuhOMwdRvQwCftj(android.media.AudioAttributes audioAttributes) {
        return toLegacyStreamType(audioAttributes);
    }

    public static void ETuhOMwdRvQwCftj(android.media.AudioAttributes audioAttributes, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ETuhOMwdRvQwCftj(android.media.AudioAttributes audioAttributes, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ETuhOMwdRvQwCftj(android.media.AudioAttributes audioAttributes, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int EzeJaYzfzBirHIOG(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo) {
        return mediaController$PlaybackInfo.getMaxVolume();
    }

    public static void EzeJaYzfzBirHIOG(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EzeJaYzfzBirHIOG(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EzeJaYzfzBirHIOG(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.media.AudioAttributes GuInkRyHuLgywNrj(java.lang.object obj) {
        return getAudioAttributes(obj);
    }

    public static void GuInkRyHuLgywNrj(java.lang.object obj, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GuInkRyHuLgywNrj(java.lang.object obj, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GuInkRyHuLgywNrj(java.lang.object obj, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.media.AudioAttributes UJLWRGHAnIWRGcis(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo) {
        return mediaController$PlaybackInfo.getAudioAttributes();
    }

    public static void UJLWRGHAnIWRGcis(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UJLWRGHAnIWRGcis(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UJLWRGHAnIWRGcis(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YlIWdweeGUoSyIvp(android.media.AudioAttributes audioAttributes) {
        return audioAttributes.getUsage();
    }

    public static void YlIWdweeGUoSyIvp(android.media.AudioAttributes audioAttributes, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YlIWdweeGUoSyIvp(android.media.AudioAttributes audioAttributes, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YlIWdweeGUoSyIvp(android.media.AudioAttributes audioAttributes, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.media.AudioAttributes GetAudioAttributes(java.lang.object obj) {
        return UJLWRGHAnIWRGcis((android.media.session.MediaController$PlaybackInfo) obj);
    }

    public static void GetAudioAttributes(java.lang.object obj, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GetAudioAttributes(java.lang.object obj, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GetAudioAttributes(java.lang.object obj, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GetCurrentVolume(java.lang.object obj) {
        return tXHTjrHOcsetQMmt((android.media.session.MediaController$PlaybackInfo) obj);
    }

    public static void GetCurrentVolume(java.lang.object obj, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GetCurrentVolume(java.lang.object obj, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GetCurrentVolume(java.lang.object obj, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int GetLegacyAudioStream(java.lang.object obj) {
        return ETuhOMwdRvQwCftj(GuInkRyHuLgywNrj(obj));
    }

    public static void GetLegacyAudioStream(java.lang.object obj, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GetLegacyAudioStream(java.lang.object obj, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GetLegacyAudioStream(java.lang.object obj, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GetMaxVolume(java.lang.object obj) {
        return EzeJaYzfzBirHIOG((android.media.session.MediaController$PlaybackInfo) obj);
    }

    public static void GetMaxVolume(java.lang.object obj, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GetMaxVolume(java.lang.object obj, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GetMaxVolume(java.lang.object obj, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int GetPlaybackType(java.lang.object obj) {
        return rSZwxkhpTfFRuLpS((android.media.session.MediaController$PlaybackInfo) obj);
    }

    public static void GetPlaybackType(java.lang.object obj, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GetPlaybackType(java.lang.object obj, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GetPlaybackType(java.lang.object obj, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int GetVolumeControl(java.lang.object obj) {
        return xhtWvcNCLLAdDoRe((android.media.session.MediaController$PlaybackInfo) obj);
    }

    public static void GetVolumeControl(java.lang.object obj, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GetVolumeControl(java.lang.object obj, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GetVolumeControl(java.lang.object obj, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RSZwxkhpTfFRuLpS(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo) {
        return mediaController$PlaybackInfo.getPlaybackType();
    }

    public static void RSZwxkhpTfFRuLpS(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RSZwxkhpTfFRuLpS(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RSZwxkhpTfFRuLpS(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int TXHTjrHOcsetQMmt(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo) {
        return mediaController$PlaybackInfo.getCurrentVolume();
    }

    public static void TXHTjrHOcsetQMmt(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TXHTjrHOcsetQMmt(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TXHTjrHOcsetQMmt(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private static int ToLegacyStreamType(android.media.AudioAttributes audioAttributes) {
        if ((29 + 17) % 17 > 0) {
        }
        if ((BKVZhHoWAsSilIiF(audioAttributes) & 1) == 1) {
            return 7;
        }
        if ((xqVZYiDLsxsWplJK(audioAttributes) & 4) == 4) {
            return 6;
        }
        int iYlIWdweeGUoSyIvp = YlIWdweeGUoSyIvp(audioAttributes);
        if (iYlIWdweeGUoSyIvp == 13) {
            return 1;
        }
        switch (iYlIWdweeGUoSyIvp) {
            case 2:
                return 0;
            case 3:
                return 8;
            case 4:
                return 4;
            case 5:
            case 7:
            case 8:
            case 9:
            case 10:
                return 5;
            case 6:
                return 2;
            default:
                return 3;
        }
    }

    private static void ToLegacyStreamType(android.media.AudioAttributes audioAttributes, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private static void ToLegacyStreamType(android.media.AudioAttributes audioAttributes, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void ToLegacyStreamType(android.media.AudioAttributes audioAttributes, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XhtWvcNCLLAdDoRe(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo) {
        return mediaController$PlaybackInfo.getVolumeControl();
    }

    public static void XhtWvcNCLLAdDoRe(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XhtWvcNCLLAdDoRe(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XhtWvcNCLLAdDoRe(android.media.session.MediaController$PlaybackInfo mediaController$PlaybackInfo, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int XqVZYiDLsxsWplJK(android.media.AudioAttributes audioAttributes) {
        return audioAttributes.getFlags();
    }

    public static void XqVZYiDLsxsWplJK(android.media.AudioAttributes audioAttributes, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XqVZYiDLsxsWplJK(android.media.AudioAttributes audioAttributes, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XqVZYiDLsxsWplJK(android.media.AudioAttributes audioAttributes, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }
}

