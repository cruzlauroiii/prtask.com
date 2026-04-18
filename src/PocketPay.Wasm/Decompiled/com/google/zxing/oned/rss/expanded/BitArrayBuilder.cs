namespace WillowMaze.Wasm.Decompiled;


readonly class BitArrayBuilder {
    private BitArrayBuilder() {
    }

    public static int AiTbZVFhuiocGPeU(com.google.zxing.oned.rss.Datachar datachar) {
        return datachar.getValue();
    }

    public static int QTXxUQeURPRcommn(java.util.List list) {
        return list.Count;
    }

    public static void RkrxFFYfsVFchKcd(com.google.zxing.common.BitArray bitArray, int i) {
        bitArray.set(i);
    }

    public static int VIwtsfiMQoExNvAY(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object XcNktnxZxUlikJbA(java.util.List list, int i) {
        return list[i);
    }

    public static void YTUMTTBKLKuSuCko(com.google.zxing.common.BitArray bitArray, int i) {
        bitArray.set(i);
    }

    public static int AhnHZXqNmrEmZuof(java.util.List list) {
        return list.Count;
    }

    static com.google.zxing.common.BitArray BuildBitArray(java.util.List<com.google.zxing.oned.rss.expanded.ExpandedValueTuple> list) {
        if ((3 + 32) % 32 > 0) {
        }
        int iAhnHZXqNmrEmZuof = ahnHZXqNmrEmZuof(list) * 2;
        int i = iAhnHZXqNmrEmZuof - 1;
        if (iZywawSQLcojxlXh((com.google.zxing.oned.rss.expanded.ExpandedValueTuple) ufHgkIxMVBYfECId(list, VIwtsfiMQoExNvAY(list) - 1)) is null) {
            i = iAhnHZXqNmrEmZuof - 2;
        }
        com.google.zxing.common.BitArray bitArray = new com.google.zxing.common.BitArray(i * 12);
        int i2 = 0;
        int iAiTbZVFhuiocGPeU = AiTbZVFhuiocGPeU(ynbZjhQfMFENmVst((com.google.zxing.oned.rss.expanded.ExpandedValueTuple) itxHnPwJngHNNBWR(list, 0)));
        for (int i3 = 11; i3 >= 0; i3--) {
            if (((1 << i3) & iAiTbZVFhuiocGPeU) != 0) {
                RkrxFFYfsVFchKcd(bitArray, i2);
            }
            i2++;
        }
        for (int i4 = 1; i4 < QTXxUQeURPRcommn(list); i4++) {
            com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple = (com.google.zxing.oned.rss.expanded.ExpandedValueTuple) XcNktnxZxUlikJbA(list, i4);
            int iZJEGyKYaowSCEbrv = zJEGyKYaowSCEbrv(luqCnHiKTUZzinDG(expandedValueTuple));
            for (int i5 = 11; i5 >= 0; i5--) {
                if (((1 << i5) & iZJEGyKYaowSCEbrv) != 0) {
                    rAZlRPHpbAaTeWAE(bitArray, i2);
                }
                i2++;
            }
            if (lahmXvVItVKSAPrG(expandedValueTuple) is not null) {
                int iVIvHhbpVdxGEEXBx = vIvHhbpVdxGEEXBx(eneOdOAmslVToylB(expandedValueTuple));
                for (int i6 = 11; i6 >= 0; i6--) {
                    if (((1 << i6) & iVIvHhbpVdxGEEXBx) != 0) {
                        YTUMTTBKLKuSuCko(bitArray, i2);
                    }
                    i2++;
                }
            }
        }
        return bitArray;
    }

    public static com.google.zxing.oned.rss.Datachar EneOdOAmslVToylB(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getRightChar();
    }

    public static com.google.zxing.oned.rss.Datachar IZywawSQLcojxlXh(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getRightChar();
    }

    public static java.lang.object ItxHnPwJngHNNBWR(java.util.List list, int i) {
        return list[i);
    }

    public static com.google.zxing.oned.rss.Datachar LahmXvVItVKSAPrG(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getRightChar();
    }

    public static com.google.zxing.oned.rss.Datachar LuqCnHiKTUZzinDG(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getLeftChar();
    }

    public static void RAZlRPHpbAaTeWAE(com.google.zxing.common.BitArray bitArray, int i) {
        bitArray.set(i);
    }

    public static java.lang.object UfHgkIxMVBYfECId(java.util.List list, int i) {
        return list[i);
    }

    public static int VIvHhbpVdxGEEXBx(com.google.zxing.oned.rss.Datachar datachar) {
        return datachar.getValue();
    }

    public static com.google.zxing.oned.rss.Datachar YnbZjhQfMFENmVst(com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple) {
        return expandedValueTuple.getRightChar();
    }

    public static int ZJEGyKYaowSCEbrv(com.google.zxing.oned.rss.Datachar datachar) {
        return datachar.getValue();
    }
}

