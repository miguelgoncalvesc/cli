﻿namespace Cmf.Common.Cli.Constants
{
    /// <summary>
    ///
    /// </summary>
    public static class CliConstants
    {
        #region Folders

        /// <summary>
        /// The folder templates
        /// </summary>
        public const string FolderTemplates = "templateFiles";

        /// <summary>
        /// The folder install dependencies
        /// </summary>
        public const string FolderInstallDependencies = "installDependencies";

        /// <summary>
        /// Tests Folder
        /// </summary>
        public const string FolderTests = "/Tests";

        #endregion

        #region Files

        /// <summary>
        /// The deployment framework manifest template
        /// </summary>
        public const string DeploymentFrameworkManifestFileName = "manifest.xml";

        /// <summary>
        /// The CMF package file name
        /// </summary>
        public const string CmfPackageFileName = "cmfpackage.json";

        /// <summary>
        /// The CMF package default presentation configuration
        /// </summary>
        public const string CmfPackagePresentationConfig = "config.json";

        /// <summary>
        /// The CMF package default host configuration
        /// </summary>
        public const string CmfPackageHostConfig = "Cmf.Foundation.Services.HostService.dll.config";

        /// <summary>
        /// The package json
        /// </summary>
        public const string PackageJson = "package.json";

        /// <summary>
        /// The project config file name, located in the project root
        /// </summary>
        public const string ProjectConfigFileName = ".project-config.json";

        /// <summary>
        /// The repositories config file name, usually located in the project root
        /// </summary>
        public const string RepositoriesConfigFileName = "repositories.json";

        /// <summary>
        /// The lb os file location
        /// </summary>
        public const string LBOsFileLocation = "Libs/LBOs/NetStandard/Cmf.LightBusinessObjects.dll";

        /// <summary>
        /// Dependencies File Name
        /// </summary>
        public const string FileDependencies = "dependencies.json";

        #endregion

        #region Generic

        /// <summary>
        /// The root package default keyword
        /// </summary>
        public const string RootPackageDefaultKeyword = "cmf-root-package";

        /// <summary>
        /// The deployment metadata dependency
        /// </summary>
        public const string DeploymentMetadataDependency = "Cmf.Custom.DeploymentMetadata";

        /// <summary>
        /// Driver keyword for IoT Packages
        /// </summary>
        public const string Driver = "driver";

        /// <summary>
        /// npm.js repository url
        /// </summary>
        public const string NpmJsUrl = "https://registry.npmjs.com";

        /// <summary>
        /// The default organization for naming new packages
        /// </summary>
        public const string DefaultOrganization = "Cmf";

        /// <summary>
        /// the default product to name new packages
        /// </summary>
        public const string DefaultProduct = "Custom";
        /// <summary>
        /// Security Portal Path for deployment of strategies
        /// </summary>
        public const string DefaultStrategyPath = "$.tenants.config.$(tenant).strategies";

        #endregion

        #region Security Portal

        /// <summary>
        /// 
        /// </summary>
        public const string Strategy = "$(strategy)";

        /// <summary>
        /// 
        /// </summary>
        public const string StrategyPath = "$(strategyPath)";

        /// <summary>
        /// The token cache Id
        /// </summary>
        public const string MetadataUrl = "$(metadataUrl)";

        /// <summary>
        /// The token cache Id
        /// </summary>
        public const string RedirectUrl = "$(redirectUrl)";

        /// <summary>
        /// The token cache Id
        /// </summary>
        public const string ClientId = "$(clientId)";

        /// <summary>
        /// The token cache Id
        /// </summary>
        public const string Tenant = "$(tenant)";

        #endregion

        #region Tokens

        /// <summary>
        /// The token start element
        /// </summary>
        public const string TokenStartElement = "$(";

        /// <summary>
        /// The token end element
        /// </summary>
        public const string TokenEndElement = ")";

        /// <summary>
        /// The token XML injection
        /// </summary>
        public const string TokenXmlInjection = "$(xmlInjection)";

        /// <summary>
        /// The token packages to remove
        /// </summary>
        public const string TokenPackagesToRemove = "$(packagesToRemove)";

        /// <summary>
        /// The token packages to add
        /// </summary>
        public const string TokenPackagesToAdd = "$(packagesToAdd)";

        /// <summary>
        /// The token version
        /// </summary>
        public const string TokenVersion = "$(version)";

        /// <summary>
        /// The token for JDT injection
        /// </summary>
        public const string TokenJDTInjection = "$(JDTInjection)";

        /// <summary>
        /// The token package identifier
        /// </summary>
        public const string TokenPackageId = "$(packageId)";

        /// <summary>
        /// The token cache Id
        /// </summary>
        public const string CacheId = "$(cacheId)";

        #endregion
    }
}