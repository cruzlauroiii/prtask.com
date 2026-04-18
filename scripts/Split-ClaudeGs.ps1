param(
    [string]$InputFile = "$env:USERPROFILE\.local\bin\claude.Transpiled\Claude.g.cs",
    [string]$OutputDir = "$env:USERPROFILE\.local\bin\claude.Transpiled",
    [int]$MaxLinesPerFile = 200000
)

$HeaderEndLine = 1224
$DispatchStartLine = 12332857

Write-Host "Splitting $InputFile by line count ($MaxLinesPerFile lines per file)..."

$Reader = [System.IO.StreamReader]::new($InputFile)
$LineNum = 0
$PartLineCount = 0
$FileIndex = 0
$CurrentWriter = $null
$InDispatch = $false

$HeaderPath = [System.IO.Path]::Combine($OutputDir, "Claude.Part0.g.cs")
$HeaderWriter = [System.IO.StreamWriter]::new($HeaderPath)
Write-Host "Writing header to Claude.Part0.g.cs"

while (($Line = $Reader.ReadLine()) -ne $null) {
    $LineNum++

    if ($LineNum -le $HeaderEndLine) {
        $HeaderWriter.WriteLine($Line)
        continue
    }

    if ($LineNum -eq $DispatchStartLine) {
        if ($CurrentWriter) {
            $CurrentWriter.WriteLine("}")
            $CurrentWriter.Close()
            Write-Host "  Closed Claude.Part$FileIndex.g.cs ($PartLineCount lines)"
        }

        $DispatchPath = [System.IO.Path]::Combine($OutputDir, "Claude.Dispatch.g.cs")
        $CurrentWriter = [System.IO.StreamWriter]::new($DispatchPath)
        $CurrentWriter.WriteLine("namespace claude;")
        $CurrentWriter.WriteLine("")
        $CurrentWriter.WriteLine("internal static partial class Claude")
        $CurrentWriter.WriteLine("{")
        $InDispatch = $true
        $PartLineCount = 0
        Write-Host "  Writing Claude.Dispatch.g.cs"
    }

    if ($InDispatch) {
        $CurrentWriter.WriteLine($Line)
        continue
    }

    $IsBlockStart = $Line.TrimStart().StartsWith("private static void Block_")
    $NeedNewFile = ($CurrentWriter -eq $null) -or ($PartLineCount -ge $MaxLinesPerFile -and $IsBlockStart)

    if ($NeedNewFile) {
        if ($CurrentWriter) {
            $CurrentWriter.WriteLine("}")
            $CurrentWriter.Close()
            Write-Host "  Closed Claude.Part$FileIndex.g.cs ($PartLineCount lines)"
        }
        $FileIndex++
        $PartPath = [System.IO.Path]::Combine($OutputDir, "Claude.Part$FileIndex.g.cs")
        $CurrentWriter = [System.IO.StreamWriter]::new($PartPath)
        $CurrentWriter.WriteLine("namespace claude;")
        $CurrentWriter.WriteLine("")
        $CurrentWriter.WriteLine("internal static partial class Claude")
        $CurrentWriter.WriteLine("{")
        $PartLineCount = 0
        Write-Host "  Writing Claude.Part$FileIndex.g.cs (starting at line $LineNum)"
    }

    $CurrentWriter.WriteLine($Line)
    $PartLineCount++
}

$HeaderWriter.WriteLine("}")
$HeaderWriter.Close()
$Reader.Close()

if ($CurrentWriter -and -not $InDispatch) {
    $CurrentWriter.WriteLine("}")
    $CurrentWriter.Close()
}
if ($CurrentWriter -and $InDispatch) {
    $CurrentWriter.Close()
}

Write-Host "`nSplit complete into $($FileIndex + 2) files (header + $FileIndex parts + dispatch)"
