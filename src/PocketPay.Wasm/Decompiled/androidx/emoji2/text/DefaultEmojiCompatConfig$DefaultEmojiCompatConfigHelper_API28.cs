namespace WillowMaze.Wasm.Decompiled;


public class DefaultEmojiCompatConfig$DefaultEmojiCompatConfigHelper_API28 : androidx.emoji2.text.DefaultEmojiCompatConfig$DefaultEmojiCompatConfigHelper_API19 {
    public override android.content.pm.Signature[] GetSigningSignatures(android.content.pm.PackageManager packageManager, java.lang.string str) throws android.content.pm.PackageManager$NameNotFoundException {
        return packageManager.getPackageInfo(str, 64).signatures;
    }
}

