@Library("jenkins-templates")
@Library("jenkins-utils")_

TempTemplate {
    dotnetCore = "2.2.300"
    portApp = "4085"
    appName ="canaleselectronicosapv-front"
	sonarProperties ="/k:'canaleselectronicosapv-front' /d:sonar.cs.opencover.reportsPaths='./CanalesElectronicosAPV.Test/coverage.opencover.xml' /d:sonar.coverage.exclusions='**/*Profile.cs,**/*Extensions.cs,**/*Program.cs,**/wwwroot/**'"
    nameAppEnvironment = "CanalesElectronicosAPV"
    urlRepo = "http://egeo.crecer.com.sv/CanalesElectronicos/FrontCanalesElectronicosApv.git"
	typeInfra = "rancher"
    appNameDockerhub = "canal-afiliadosApv-front"
    approvalArchitectUser = "rescobar"
    approvalMailArquitect = "rescobar@crecer.com.sv"
    approvalDBAUser = "rescobar"
    approvalMailDBA = "rescobar@crecer.com.sv"
    approvalSecurityUser = "rescobar"
    approvalMailSecurity = "rescobar@crecer.com.sv"
    teamNotification = "rescobar@crecer.com.sv, synmreynos@crecer.com.sv"
	folderTest = "CanalesElectronicosAPV.Test"
	isDockerCompose = false
    isAksAzure = false
}