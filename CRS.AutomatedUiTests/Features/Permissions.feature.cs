﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CRS.AutomatedUiTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Permissions")]
    public partial class PermissionsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Permissions.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Permissions", "In order to restrict user access\r\nAs a hospital user of CRS\r\nI want only be allow" +
                    "ed to access specific folders", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Users can only see valid folders")]
        [NUnit.Framework.CategoryAttribute("Permissions")]
        [NUnit.Framework.TestCaseAttribute("ABankoski", "pass$9033", null)]
        [NUnit.Framework.TestCaseAttribute("ABauman", "pass&9128", null)]
        [NUnit.Framework.TestCaseAttribute("ABurton", "Pass$2143", null)]
        [NUnit.Framework.TestCaseAttribute("ACunningham", "Pass#3002", null)]
        [NUnit.Framework.TestCaseAttribute("ADeutschendorf", "pass%9003", null)]
        [NUnit.Framework.TestCaseAttribute("AEvenson", "Pass$3214", null)]
        [NUnit.Framework.TestCaseAttribute("AHendricks", "Pass#4003", null)]
        [NUnit.Framework.TestCaseAttribute("AHorton", "Pass#6004", null)]
        [NUnit.Framework.TestCaseAttribute("Aknapp", "Pass#1005", null)]
        [NUnit.Framework.TestCaseAttribute("ALara", "pass$8348", null)]
        [NUnit.Framework.TestCaseAttribute("AMann", "pass^2512", null)]
        [NUnit.Framework.TestCaseAttribute("AMaule", "Pass#9006", null)]
        [NUnit.Framework.TestCaseAttribute("AMcCusker", "Pass#5007", null)]
        [NUnit.Framework.TestCaseAttribute("AMcMullen", "Pass#5008", null)]
        [NUnit.Framework.TestCaseAttribute("ANaik", "pass%4309", null)]
        [NUnit.Framework.TestCaseAttribute("ARivers", "Pass#0009", null)]
        [NUnit.Framework.TestCaseAttribute("ASchuster", "Pass$1423", null)]
        [NUnit.Framework.TestCaseAttribute("AWang", "Pass$3214", null)]
        [NUnit.Framework.TestCaseAttribute("AZanger", "pass#6010", null)]
        [NUnit.Framework.TestCaseAttribute("Bbennighoff", "pass#1011", null)]
        [NUnit.Framework.TestCaseAttribute("BByers", "pass#0012", null)]
        [NUnit.Framework.TestCaseAttribute("BDavis", "pass!9165", null)]
        [NUnit.Framework.TestCaseAttribute("BKelly", "pass#5015", null)]
        [NUnit.Framework.TestCaseAttribute("BNowakowski", "pass#2017", null)]
        [NUnit.Framework.TestCaseAttribute("BOliver", "pass#1018", null)]
        [NUnit.Framework.TestCaseAttribute("BPhillips", "pass#4019", null)]
        [NUnit.Framework.TestCaseAttribute("BYocubik", "pass&8734", null)]
        [NUnit.Framework.TestCaseAttribute("CBoothe", "pass#5020", null)]
        [NUnit.Framework.TestCaseAttribute("CBurgess", "pass#7021", null)]
        [NUnit.Framework.TestCaseAttribute("CCimaszewski", "Pass$3214", null)]
        [NUnit.Framework.TestCaseAttribute("Cclark", "pass&9712", null)]
        [NUnit.Framework.TestCaseAttribute("CCobbs", "pass#1022", null)]
        [NUnit.Framework.TestCaseAttribute("CColeman", "pass#7023", null)]
        [NUnit.Framework.TestCaseAttribute("CGizara", "pass+2816", null)]
        [NUnit.Framework.TestCaseAttribute("Clannen", "pass#6025", null)]
        [NUnit.Framework.TestCaseAttribute("CLeung", "pass-0219", null)]
        [NUnit.Framework.TestCaseAttribute("CNottingham", "pass%9001", null)]
        [NUnit.Framework.TestCaseAttribute("CSapp", "pass#8026", null)]
        [NUnit.Framework.TestCaseAttribute("CWilliams", "pass&8983", null)]
        [NUnit.Framework.TestCaseAttribute("DAllen", "pass#3027", null)]
        [NUnit.Framework.TestCaseAttribute("DBaker", "pass%9009", null)]
        [NUnit.Framework.TestCaseAttribute("DBetlyon", "pass#8028", null)]
        [NUnit.Framework.TestCaseAttribute("DBrooks", "pass#1029", null)]
        [NUnit.Framework.TestCaseAttribute("DCrawford", "pass#1892", null)]
        [NUnit.Framework.TestCaseAttribute("DDodson", "pass#7030", null)]
        [NUnit.Framework.TestCaseAttribute("DFeeney", "pass&5100", null)]
        [NUnit.Framework.TestCaseAttribute("DHarless", "pass#1031", null)]
        [NUnit.Framework.TestCaseAttribute("DHernandez", "pass#0032", null)]
        [NUnit.Framework.TestCaseAttribute("DHyman", "pass#0033", null)]
        [NUnit.Framework.TestCaseAttribute("DJohnson", "pass!2997", null)]
        [NUnit.Framework.TestCaseAttribute("DKinzer", "pass&0951", null)]
        [NUnit.Framework.TestCaseAttribute("DLucas", "Pass$3214", null)]
        [NUnit.Framework.TestCaseAttribute("DRomans", "pass!8023", null)]
        [NUnit.Framework.TestCaseAttribute("DRounds", "pass#1034", null)]
        [NUnit.Framework.TestCaseAttribute("DRyan", "pass#3035", null)]
        [NUnit.Framework.TestCaseAttribute("DSaraceno", "pass#1036", null)]
        [NUnit.Framework.TestCaseAttribute("DSirk", "pass#2037", null)]
        [NUnit.Framework.TestCaseAttribute("DWon", "pass%9007", null)]
        [NUnit.Framework.TestCaseAttribute("DYoungquist", "pass*6617", null)]
        [NUnit.Framework.TestCaseAttribute("EBeranek", "pass#7038", null)]
        [NUnit.Framework.TestCaseAttribute("EHaile", "Pass$1423", null)]
        [NUnit.Framework.TestCaseAttribute("ELangha", "pass#9039", null)]
        [NUnit.Framework.TestCaseAttribute("FCollins", "pass#9041", null)]
        [NUnit.Framework.TestCaseAttribute("GAnyumba", "pass!4506", null)]
        [NUnit.Framework.TestCaseAttribute("Hjacobs", "pass#6044", null)]
        [NUnit.Framework.TestCaseAttribute("HSiskind", "pass#7045", null)]
        [NUnit.Framework.TestCaseAttribute("IKatz", "pass^2513", null)]
        [NUnit.Framework.TestCaseAttribute("JAcuna", "pass#9046", null)]
        [NUnit.Framework.TestCaseAttribute("JAlpern", "Pass$3214", null)]
        [NUnit.Framework.TestCaseAttribute("JBrant", "pass#4047", null)]
        [NUnit.Framework.TestCaseAttribute("JBrinkley", "pass#1048", null)]
        [NUnit.Framework.TestCaseAttribute("JCarroll", "pass#5049", null)]
        [NUnit.Framework.TestCaseAttribute("JCraig", "Pass$3214", null)]
        [NUnit.Framework.TestCaseAttribute("JDeRyke", "pass#9050", null)]
        [NUnit.Framework.TestCaseAttribute("JDiehl", "pass%9005", null)]
        [NUnit.Framework.TestCaseAttribute("JFiergang", "pass^2514", null)]
        [NUnit.Framework.TestCaseAttribute("JFigler", "pass#6051", null)]
        [NUnit.Framework.TestCaseAttribute("JFofana", "pass#9052", null)]
        [NUnit.Framework.TestCaseAttribute("JFogg", "pass#7053", null)]
        [NUnit.Framework.TestCaseAttribute("JGill", "pass%9006", null)]
        [NUnit.Framework.TestCaseAttribute("JGordon", "pass#2054", null)]
        [NUnit.Framework.TestCaseAttribute("JHall", "pass#2055", null)]
        [NUnit.Framework.TestCaseAttribute("JHartman", "pass#7056", null)]
        [NUnit.Framework.TestCaseAttribute("JHoward", "pass#7057", null)]
        [NUnit.Framework.TestCaseAttribute("JHulvey", "pass#8059", null)]
        [NUnit.Framework.TestCaseAttribute("JKeese", "pass#7060", null)]
        [NUnit.Framework.TestCaseAttribute("Jmazzeo", "pass#7061", null)]
        [NUnit.Framework.TestCaseAttribute("JMitchell", "pass#0062", null)]
        [NUnit.Framework.TestCaseAttribute("JNagel", "pass#2063", null)]
        [NUnit.Framework.TestCaseAttribute("JPeters", "pass#7064", null)]
        [NUnit.Framework.TestCaseAttribute("JRaab", "pass#6065", null)]
        [NUnit.Framework.TestCaseAttribute("JRotz", "pass#7066", null)]
        [NUnit.Framework.TestCaseAttribute("JRowe", "pass#5067", null)]
        [NUnit.Framework.TestCaseAttribute("JSmith", "pass#8068", null)]
        [NUnit.Framework.TestCaseAttribute("JSwann", "pass#4069", null)]
        [NUnit.Framework.TestCaseAttribute("JTaylor", "pass#5070", null)]
        [NUnit.Framework.TestCaseAttribute("JTroyer", "pass&5105", null)]
        [NUnit.Framework.TestCaseAttribute("JTucker", "pass%0427", null)]
        [NUnit.Framework.TestCaseAttribute("KEckert", "pass#9071", null)]
        [NUnit.Framework.TestCaseAttribute("KFeliciano", "pass-0247", null)]
        [NUnit.Framework.TestCaseAttribute("KFrazier", "pass#6072", null)]
        [NUnit.Framework.TestCaseAttribute("KFridley", "pass#5073", null)]
        [NUnit.Framework.TestCaseAttribute("KGootee", "pass#5074", null)]
        [NUnit.Framework.TestCaseAttribute("Kharnish", "pass#2075", null)]
        [NUnit.Framework.TestCaseAttribute("KJerome", "pass#9076", null)]
        [NUnit.Framework.TestCaseAttribute("KJohnson", "pass#7077", null)]
        [NUnit.Framework.TestCaseAttribute("KKearney", "pass#2078", null)]
        [NUnit.Framework.TestCaseAttribute("KMulford", "pass#4079", null)]
        [NUnit.Framework.TestCaseAttribute("KPulio", "pass#6080", null)]
        [NUnit.Framework.TestCaseAttribute("KRing", "pass#9081", null)]
        [NUnit.Framework.TestCaseAttribute("KTalbot", "pass#0083", null)]
        [NUnit.Framework.TestCaseAttribute("LDixon", "pass#2084", null)]
        [NUnit.Framework.TestCaseAttribute("LDunaway", "pass^2511", null)]
        [NUnit.Framework.TestCaseAttribute("LHack", "pass#9085", null)]
        [NUnit.Framework.TestCaseAttribute("LKessler", "pass%9008", null)]
        [NUnit.Framework.TestCaseAttribute("LNelson", "pass#5087", null)]
        [NUnit.Framework.TestCaseAttribute("LSnyder", "pass#2088", null)]
        [NUnit.Framework.TestCaseAttribute("LStrimel", "pass%3490", null)]
        [NUnit.Framework.TestCaseAttribute("LTalbott", "pass+2817", null)]
        [NUnit.Framework.TestCaseAttribute("LTracey", "pass#5089", null)]
        [NUnit.Framework.TestCaseAttribute("LVidal", "pass#4090", null)]
        [NUnit.Framework.TestCaseAttribute("MBrozic", "pass#2091", null)]
        [NUnit.Framework.TestCaseAttribute("MConnor", "pass#6092", null)]
        [NUnit.Framework.TestCaseAttribute("MEdelen", "pass#4751", null)]
        [NUnit.Framework.TestCaseAttribute("MFrate", "pass+2818", null)]
        [NUnit.Framework.TestCaseAttribute("MGajewski", "pass#6093", null)]
        [NUnit.Framework.TestCaseAttribute("MGriffin", "pass#7095", null)]
        [NUnit.Framework.TestCaseAttribute("MHerpel", "pass#8096", null)]
        [NUnit.Framework.TestCaseAttribute("MJenkins", "pass!1037", null)]
        [NUnit.Framework.TestCaseAttribute("MKing", "pass#7097", null)]
        [NUnit.Framework.TestCaseAttribute("MLBond", "pass#8098", null)]
        [NUnit.Framework.TestCaseAttribute("MLomax", "pass#6099", null)]
        [NUnit.Framework.TestCaseAttribute("MMorgan", "pass#8100", null)]
        [NUnit.Framework.TestCaseAttribute("MMyers", "pass#0101", null)]
        [NUnit.Framework.TestCaseAttribute("MPankey", "pass#6103", null)]
        [NUnit.Framework.TestCaseAttribute("MPeacock", "pass#5104", null)]
        [NUnit.Framework.TestCaseAttribute("MPohl", "Pass$1432", null)]
        [NUnit.Framework.TestCaseAttribute("MRecor", "pass#6105", null)]
        [NUnit.Framework.TestCaseAttribute("MReiter", "pass#6106", null)]
        [NUnit.Framework.TestCaseAttribute("MReynolds", "pass-0236", null)]
        [NUnit.Framework.TestCaseAttribute("MSathiraju", "pass!3771", null)]
        [NUnit.Framework.TestCaseAttribute("Msokolow", "pass-0209", null)]
        [NUnit.Framework.TestCaseAttribute("MStefano", "pass#1107", null)]
        [NUnit.Framework.TestCaseAttribute("MTaylor", "pass#8108", null)]
        [NUnit.Framework.TestCaseAttribute("NSantiago", "pass#1109", null)]
        [NUnit.Framework.TestCaseAttribute("NUdom", "pass&7743", null)]
        [NUnit.Framework.TestCaseAttribute("OIbarra", "pass&3617", null)]
        [NUnit.Framework.TestCaseAttribute("PAllen", "pass#8110", null)]
        [NUnit.Framework.TestCaseAttribute("PHurley", "pass#2111", null)]
        [NUnit.Framework.TestCaseAttribute("PMarkunas", "pass#9112", null)]
        [NUnit.Framework.TestCaseAttribute("PMcWhorter", "pass#2113", null)]
        [NUnit.Framework.TestCaseAttribute("PRodriguez", "pass#8114", null)]
        [NUnit.Framework.TestCaseAttribute("PStable", "pass#9115", null)]
        [NUnit.Framework.TestCaseAttribute("RCarroll", "pass#1117", null)]
        [NUnit.Framework.TestCaseAttribute("RCase", "pass#3118", null)]
        [NUnit.Framework.TestCaseAttribute("REmrick", "pass#1119", null)]
        [NUnit.Framework.TestCaseAttribute("RKrothapalli", "pass%9002", null)]
        [NUnit.Framework.TestCaseAttribute("RMott", "pass#3120", null)]
        [NUnit.Framework.TestCaseAttribute("RPellegrino", "pass#7121", null)]
        [NUnit.Framework.TestCaseAttribute("RVaflor", "pass#9122", null)]
        [NUnit.Framework.TestCaseAttribute("RWells", "pass#7123", null)]
        [NUnit.Framework.TestCaseAttribute("RWhite", "pass#9124", null)]
        [NUnit.Framework.TestCaseAttribute("SAfzal", "Pass$3214", null)]
        [NUnit.Framework.TestCaseAttribute("SAnand", "pass#2125", null)]
        [NUnit.Framework.TestCaseAttribute("SAntony", "Pass$3214", null)]
        [NUnit.Framework.TestCaseAttribute("SCalikoglu", "Pass$1423", null)]
        [NUnit.Framework.TestCaseAttribute("SDawson", "pass#4126", null)]
        [NUnit.Framework.TestCaseAttribute("SDohony", "pass#3127", null)]
        [NUnit.Framework.TestCaseAttribute("SHendricks", "pass#2128", null)]
        [NUnit.Framework.TestCaseAttribute("ShiBrown", "pass^2510", null)]
        [NUnit.Framework.TestCaseAttribute("SLieb", "pass#7129", null)]
        [NUnit.Framework.TestCaseAttribute("SLim", "pass#1130", null)]
        [NUnit.Framework.TestCaseAttribute("SPorts", "pass&2853", null)]
        [NUnit.Framework.TestCaseAttribute("SSchooley", "pass-9254", null)]
        [NUnit.Framework.TestCaseAttribute("SSchwarz", "pass#0131", null)]
        [NUnit.Framework.TestCaseAttribute("SShrestha", "Pass$3214", null)]
        [NUnit.Framework.TestCaseAttribute("SVasudevan", "pass*1808", null)]
        [NUnit.Framework.TestCaseAttribute("TBowman", "PassC@1528", null)]
        [NUnit.Framework.TestCaseAttribute("TCalabria", "pass#2133", null)]
        [NUnit.Framework.TestCaseAttribute("TCannady", "pass#9134", null)]
        [NUnit.Framework.TestCaseAttribute("TChan", "pass#6135", null)]
        [NUnit.Framework.TestCaseAttribute("TColes", "pass#4136", null)]
        [NUnit.Framework.TestCaseAttribute("TKerr", "pass#1137", null)]
        [NUnit.Framework.TestCaseAttribute("TSpringmann", "pass%9004", null)]
        [NUnit.Framework.TestCaseAttribute("WZawwin", "pass#0139", null)]
        [NUnit.Framework.TestCaseAttribute("YHicks", "pass-0229", null)]
        [NUnit.Framework.TestCaseAttribute("YPhillips", "pass+2715", null)]
        [NUnit.Framework.TestCaseAttribute("Ywoldeye", "pass#1140", null)]
        [NUnit.Framework.TestCaseAttribute("Zgoodling", "pass&4423", null)]
        public virtual void UsersCanOnlySeeValidFolders(string username, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Permissions"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Users can only see valid folders", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I navigate to \'http://crs.crisphealth.org\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When(string.Format("I login as \'{0}\' and \'{1}\'", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("I am logged into the CRS website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.Then(string.Format("username \'{0}\' can see the folders for his permissions", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.Then(string.Format("username \'{0}\' cannot see the folders outside his permission", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
