namespace PrTask.Git.Generated;

internal static partial class Graph
{
    internal enum GraphState
    {
        GRAPH_PADDING,
        GRAPH_SKIP,
        GRAPH_PRE_COMMIT,
        GRAPH_COMMIT,
        GRAPH_POST_MERGE,
        GRAPH_COLLAPSING,
    }
    internal static void GraphShowLinePrefix(nint Diffopt)
    {
    }

    internal static void ParseGraphColorsConfig(nint Colors, string String)
    {
    }

    internal static void GraphSetColumnColors(string Colors, Unshort ColorsMax)
    {
    }

    internal static void GraphLineAddch(nint Line, int C)
    {
    }

    internal static void GraphLineAddchars(nint Line, int C, nuint N)
    {
    }

    internal static void GraphLineAddstr(nint Line, string S)
    {
    }

    internal static void GraphLineAddcolor(nint Line, Unshort Color)
    {
    }

    internal static void GraphSetupLinePrefix(nint Diffopt)
    {
    }

    internal static void GraphClear(nint Graph)
    {
    }

    internal static void GraphUpdateState(nint Graph, GraphState S)
    {
    }

    internal static void GraphEnsureCapacity(nint Graph, int NumColumns)
    {
    }

    internal static int GraphIsInteresting(nint Graph, nint Commit)
        => default;

    internal static Unshort GraphGetCurrentColumnColor(nint Graph)
        => default;

    internal static void GraphIncrementColumnColor(nint Graph)
    {
    }

    internal static void GraphUpdateColumns(nint Graph)
    {
    }

    internal static int GraphNumDashedParents(nint Graph)
        => default;

    internal static int GraphNumExpansionRows(nint Graph)
        => default;

    internal static int GraphNeedsPreCommitLine(nint Graph)
        => default;

    internal static void GraphUpdate(nint Graph, nint Commit)
    {
    }

    internal static int GraphIsMappingCorrect(nint Graph)
        => default;

    internal static void GraphPadHorizontally(nint Graph, nint Line)
    {
    }

    internal static int GraphWidth(nint Graph)
        => default;

    internal static void GraphOutputSkipLine(nint Graph, nint Line)
    {
    }

    internal static void GraphOutputCommitChar(nint Graph, nint Line)
    {
    }

    internal static void GraphDrawOctopusMerge(nint Graph, nint Line)
    {
    }

    internal static void GraphOutputCommitLine(nint Graph, nint Line)
    {
    }

    internal static void GraphOutputPostMergeLine(nint Graph, nint Line)
    {
    }

    internal static void GraphOutputCollapsingLine(nint Graph, nint Line)
    {
    }

    internal static int GraphNextLine(nint Graph, nint Sb)
        => default;

    internal static void GraphPaddingLine(nint Graph, nint Sb)
    {
    }

    internal static int GraphIsCommitFinished(nint Graph)
        => default;

    internal static void GraphShowCommit(nint Graph)
    {
    }

    internal static void GraphShowOneline(nint Graph)
    {
    }

    internal static void GraphShowPadding(nint Graph)
    {
    }

    internal static int GraphShowRemainder(nint Graph)
        => default;

}
