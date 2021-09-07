[xml]$fileContent = Get-Content -Path .\assignment.xml


$fileContent.root.InstallationSetting.InstallationPath = "C:\installation"
$fileContent.root.InstallationSetting.ApplicationFeatures.add.value = "1"
$fileContent.root.GeneralSettings.add.value = "testserver,8885\testdatabase"
$fileContent.root.DatabaseSettings.DatabaseNames.add.value = "1"
$fileContent.root.ConfigurationScript.ConfigurationService.ReplaceVariable.add.value = "testserver,8885\testdatabase"
$fileContent.root.HostServerConfig.configuration.'system.serviceModel'.bindings.wsHttpBinding.binding.security.transport.SetAttribute("clientCredentialType", "Windows")

$fileContent.root.HostServerConfig.configuration.'system.serviceModel'.bindings.wsHttpBinding.binding.security.InnerXml = 
    $fileContent.root.HostServerConfig.configuration.'system.serviceModel'.bindings.wsHttpBinding.binding.security.InnerXml + '<binding name="customBinding"></binding>'

$fileContent.Save(".\assignment-result.xml")