namespace WillowMaze.Wasm.Decompiled;


public interface ReviewManager {
    com.google.android.gms.tasks.Task<java.lang.void> launchReviewFlow(android.app.object activity, com.google.android.play.core.review.ReviewInfo reviewInfo);

    com.google.android.gms.tasks.Task<com.google.android.play.core.review.ReviewInfo> requestReviewFlow();
}

