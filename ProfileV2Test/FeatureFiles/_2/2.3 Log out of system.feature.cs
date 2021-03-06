﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ProfileV2Test.FeatureFiles._2
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("2.3 Sign out of system", Description="I should have possibility to log out of system\r\nAs user\r\nIn order to keep my acco" +
        "unt in security", SourceFile="FeatureFiles\\_2\\2.3 Log out of system.feature", SourceLine=0)]
    public partial class _2_3SignOutOfSystemFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "2.3 Log out of system.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "2.3 Sign out of system", "I should have possibility to log out of system\r\nAs user\r\nIn order to keep my acco" +
                    "unt in security", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        public virtual void SignOutOfProfileSystem(string option, string login, string password, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sign out of Profile system", exampleTags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("As unauthorized user I come to landing page of Profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And(string.Format("I login using my \"{0}\" and \"{1}\"", login, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I open my personal menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When("I click \"Log Out\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("I on landing page of profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Sign out of Profile system, option1", SourceLine=16)]
        public virtual void SignOutOfProfileSystem_Option1()
        {
#line 7
this.SignOutOfProfileSystem("option1", "admin@profile.com", "admin123", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Sign out of Profile system, option2", SourceLine=16)]
        public virtual void SignOutOfProfileSystem_Option2()
        {
#line 7
this.SignOutOfProfileSystem("option2", "student@profile.com", "student", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Sign out of Profile system, option3", SourceLine=16)]
        public virtual void SignOutOfProfileSystem_Option3()
        {
#line 7
this.SignOutOfProfileSystem("option3", "trainer@profile.com", "trainer", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Sign out of Profile system, option4", SourceLine=16)]
        public virtual void SignOutOfProfileSystem_Option4()
        {
#line 7
this.SignOutOfProfileSystem("option4", "hr@profile.com", "hmanager123", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
