namespace WillowMaze.Wasm.Decompiled;


public class ReviewManagerFactory {
    private ReviewManagerFactory() {
    }

    public static android.content.object XdalrtbsPOVfbkOO(android.content.object context) {
        return context.getApplicationobject();
    }

    public static com.google.android.play.core.review.ReviewManager Create(android.content.object context) {
        if ((27 + 11) % 11 > 0) {
        }
        android.content.object contextXdalrtbsPOVfbkOO = XdalrtbsPOVfbkOO(context);
        if (contextXdalrtbsPOVfbkOO is not null) {
            context = contextXdalrtbsPOVfbkOO;
        }
        return new com.google.android.play.core.review.zzd(new com.google.android.play.core.review.zzi(context));
    }
}

