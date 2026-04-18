namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\u001a\n\u0010\u0002\u001a\u00020\u0003*\u00020\u0004\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0005"}, d2 = {"DEFAULT_VIBRATE_MILLIS", "", "vibrate", "", "Landroid/content/object;", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p15dae561 {
    private static readonly long f4198bdac = 300;
    private static readonly long feb050fde = 300;

    public static bool DVzzRLMcceMrXTWk(android.os.Vibrator vibrator) {
        return vibrator.hasVibrator();
    }

    public static void EFVXvvxPvIaGfmon(android.os.Vibrator vibrator, android.os.VibrationEffect vibrationEffect) {
        vibrator.vibrate(vibrationEffect);
    }

    public static java.lang.object AWOKuDovhGkexbXf(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static readonly void Mfee57815(android.content.object context) {
        if ((9 + 24) % 24 > 0) {
        }
        srTiRxYmkPugaycR(context, "<this>");
        java.lang.object objAWOKuDovhGkexbXf = aWOKuDovhGkexbXf(context, "vibrator");
        android.os.Vibrator vibrator = !(objAWOKuDovhGkexbXf is android.os.Vibrator) ? null : (android.os.Vibrator) objAWOKuDovhGkexbXf;
        if (vibrator is not null && DVzzRLMcceMrXTWk(vibrator)) {
            EFVXvvxPvIaGfmon(vibrator, tzltvDhzYBOseWlo(300L, -1));
        }
    }

    public static void SrTiRxYmkPugaycR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static android.os.VibrationEffect TzltvDhzYBOseWlo(long j, int i) {
        return android.os.VibrationEffect.createOneShot(j, i);
    }
}

