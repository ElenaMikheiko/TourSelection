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
namespace ProfileV2Test.FeatureFiles._5
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("5.11 To fill in block \"Additional information\"", Description="\tIn order to inform employer\r\n\tAs authorized user\r\n\tI should have possibility to " +
        "fill in block \"Additional information\"", SourceFile="FeatureFiles\\_5\\5.11 To fill in block \'Additional information\'.feature", SourceLine=4)]
    public partial class _5_11ToFillInBlockAdditionalInformationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "5.11 To fill in block 'Additional information'.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "5.11 To fill in block \"Additional information\"", "\tIn order to inform employer\r\n\tAs authorized user\r\n\tI should have possibility to " +
                    "fill in block \"Additional information\"", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 10
#line 11
 testRunner.Given("As unauthorised user I come to landing page of Profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
 testRunner.And("I log in as Additional1 Test", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("I open my personal menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And("I select button \"Resume\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("I go to block \"Additional information\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student checking resume block title of page", SourceLine=16)]
        public virtual void StudentCheckingResumeBlockTitleOfPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Student checking resume block title of page", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 10
this.FeatureBackground();
#line 18
   testRunner.Then("I see resume block title \"Additional information\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
   testRunner.And("I see that tab name \"Additional information\" is active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "TEXT"});
            table1.AddRow(new string[] {
                        "Here you can write about your professional interests, hobby, civic activities, aw" +
                            "ards or volunteering"});
#line 20
   testRunner.And("I see placeholder text in field \"Additional information\"", ((string)(null)), table1, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student Saves information", SourceLine=23)]
        public virtual void StudentSavesInformation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Student Saves information", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 10
this.FeatureBackground();
#line 25
    testRunner.Given("I filled all fields in \"Additional information\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
    testRunner.When("I press \"NEXT\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
    testRunner.And("I press \"BACK\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
    testRunner.Then("I can see data \"Additional information\" is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student check Countdown\'s work in block \"Additional information\"", SourceLine=29)]
        public virtual void StudentCheckCountdownsWorkInBlockAdditionalInformation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Student check Countdown\'s work in block \"Additional information\"", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 10
this.FeatureBackground();
#line 31
    testRunner.When("I write in \"Additional information\" \"1001\" of symbol", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("Countdown number is \"-1/1000\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.And("Countdown is encircled red", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student check language filter in block \"Additional information\"", SourceLine=34)]
        public virtual void StudentCheckLanguageFilterInBlockAdditionalInformation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Student check language filter in block \"Additional information\"", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 10
this.FeatureBackground();
#line 36
 testRunner.When("I write \"Абв\" in field \"Additional information\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("I see the written \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student can Check block \"Additional information\" on error", SourceLine=43)]
        public virtual void StudentCanCheckBlockAdditionalInformationOnError()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Student can Check block \"Additional information\" on error", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line 10
this.FeatureBackground();
#line 45
 testRunner.Given("I leave block \"Additional information\" empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.When("I press \"NEXT\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("I moved to block \"Recommendations\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
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
