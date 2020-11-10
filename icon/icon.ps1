$svg = "icon"

$Sizes = @(16, 24, 32, 48, 64, 128, 256)

$MagickArgumentList = [System.Collections.ArrayList]@("convert", "$($svg).ico")
foreach ($Size in $Sizes) {
    Write-Host "Creating variant $Size"
    $SizedFile = "$($svg)-$($Size).png"
    $InkscapeArguments = @("--export-filename=$($SizedFile)", "--export-width=$($Size)", "--export-height=$($Size)", "$($svg).svg" )
    Start-Process 'C:\Program Files\Inkscape\bin\inkscape.exe' -ArgumentList $InkscapeArguments -Wait -NoNewWindow
    $MagickArgumentList.Insert(1, $SizedFile)
}
Write-Host "Creating final file"
Start-Process -FilePath magick.exe -ArgumentList $MagickArgumentList -Wait -NoNewWindow
