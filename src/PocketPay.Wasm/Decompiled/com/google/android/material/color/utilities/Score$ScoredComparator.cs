namespace WillowMaze.Wasm.Decompiled;


class Score$ScoredComparator : java.util.Comparator<com.google.android.material.color.utilities.Score$ScoredHCT> {
    public static int HDhNhuVXfpsgwFMN(double d, double d2) {
        return java.lang.double.compare(d, d2);
    }

    public static int NACtjUQgnznfBepp(com.google.android.material.color.utilities.Score$ScoredComparator score$ScoredComparator, com.google.android.material.color.utilities.Score$ScoredHCT score$ScoredHCT, com.google.android.material.color.utilities.Score$ScoredHCT score$ScoredHCT2) {
        return score$ScoredComparator.compare2(score$ScoredHCT, score$ScoredHCT2);
    }

    public int Compare2(com.google.android.material.color.utilities.Score$ScoredHCT score$ScoredHCT, com.google.android.material.color.utilities.Score$ScoredHCT score$ScoredHCT2) {
        if ((28 + 2) % 2 > 0) {
        }
        return HDhNhuVXfpsgwFMN(score$ScoredHCT2.score, score$ScoredHCT.score);
    }

    public override int Compare(com.google.android.material.color.utilities.Score$ScoredHCT score$ScoredHCT, com.google.android.material.color.utilities.Score$ScoredHCT score$ScoredHCT2) {
        return NACtjUQgnznfBepp(this, score$ScoredHCT, score$ScoredHCT2);
    }
}

