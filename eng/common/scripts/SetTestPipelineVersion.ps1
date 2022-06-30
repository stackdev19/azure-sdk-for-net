# Sets a valid version for a package using the buildID

param (
  [Parameter(mandatory = $true)]
  $BuildID,
  [Parameter(mandatory = $true)]
  $PackageName,
  [Parameter(mandatory = $true)]
  $ServiceDirectory
)

. (Join-Path $PSScriptRoot common.ps1)

$newVersion = "1.0.0"
$latestTags = git tag -l "${PackageName}_*"
$semVars = @()

Foreach ($tags in $latestTags)
{
  $semVars += $tags.Replace("${PackageName}_", "")
}

if ($semVars -and $semVars.Length -gt 0)
{
  $semVarsSorted = [AzureEngSemanticVersion]::SortVersionStrings($semVars)
  LogDebug "Last Published Version $($semVarsSorted[0])"
  $newVersion = [AzureEngSemanticVersion]::new($semVarsSorted[0])
}

$newVersion.PrereleaseLabel = $newVersion.DefaultPrereleaseLabel
$newVersion.PrereleaseNumber = $BuildID

LogDebug "Version to publish [ $($newVersion.ToString()) ]"

SetPackageVersion -PackageName $PackageName `
  -Version $newVersion `
  -ServiceDirectory $ServiceDirectory